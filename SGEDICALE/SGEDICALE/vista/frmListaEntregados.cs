using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using SGEDICALE.reportes;
using SGEDICALE.reportes.clsReportes;

namespace SGEDICALE.vista
{
    public partial class frmListaEntregados : DevComponents.DotNetBar.Office2007Form
    {
        public frmListaEntregados()
        {
            InitializeComponent();
        }

        private void frmListaEntregados_Load(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            llenacombos();
            llenarestado();

            this.Cursor = Cursors.Default;
        }


        public void llenarestado()
        {
            List<dynamic> listaestado = new List<dynamic>()
            {
                new {codigo=1,descripcion="ENTREGADO" },
                new {codigo=0,descripcion="NO ENTREGADO" },
                new {codigo=2,descripcion="TODO" }
    
            };

            cbEstado.DataSource = listaestado;
            cbEstado.ValueMember = "codigo";
            cbEstado.DisplayMember = "descripcion";
            cbEstado.Refresh();

        }


        private void llenacombos()
        {

            DataTable dt1 = new DataTable("Tabla1");

            dt1.Columns.Add("Codigo");
            dt1.Columns.Add("Descripcion");

            DataRow dr1;

            dr1 = dt1.NewRow(); dr1[0] = "2018"; dr1[1] = "2018"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2019"; dr1[1] = "2019"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2020"; dr1[1] = "2020"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2021"; dr1[1] = "2021"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2022"; dr1[1] = "2022"; dt1.Rows.Add(dr1);

            cbAño.DataSource = dt1;
            cbAño.ValueMember = "Descripcion";
            cbAño.DisplayMember = "Descripcion";

            cbAño_SelectedIndexChanged(null, null);
        }


        private void frmListaEntregados_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {

                this.Cursor = Cursors.WaitCursor;

                int codcampana = 0;


                if (cbCampaña != null)
                {

                    if (cbCampaña.Items.Count > 0)
                    {
                        dg_premio.AutoGenerateColumns = false;
                        dg_premio.DataSource = null;

                        codcampana = Convert.ToInt32(cbCampaña.SelectedValue);
                        dg_premio.DataSource = CPremio.listadoxcodcampana(codcampana,Convert.ToInt32(cbEstado.SelectedValue));
                        dg_premio.Refresh();

                    }
                    else
                    {
                        MessageBox.Show("Seleccione campaña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Complete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }





                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }


        }


        public void cargaCategoria()
        {

            cboCategoria.DataSource = null;
            if (cbCampaña.SelectedValue != null)
            {

                cboCategoria.DataSource = CCategoria.ListadoCategoriaxCampaña(Convert.ToInt32(cbCampaña.SelectedValue));
                cboCategoria.ValueMember = "codcategoria";
                cboCategoria.DisplayMember = "descripcion";
                cboCategoria.Refresh();
            }

        }

        public void cargaCampaña()
        {

            //cboCampaña.DataSource = CCampaña.CargaCampañaActivas();
            cbCampaña.DataSource = null;
            if (cbAño.SelectedValue != null)
            {
                if (cbAño.Items.Count > 0)
                {
                    cbCampaña.DataSource = CCampaña.buscarxaño(cbAño.SelectedValue.ToString());
                    cbCampaña.ValueMember = "codcampana";
                    cbCampaña.DisplayMember = "descripcion";
                    cbCampaña.Refresh();

                    cargaCategoria();
                }
            }

        }
        private void cbAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                cargaCampaña();
         
                /*
                if (cbAño != null)
                {
                    if (cbAño.Items.Count > 0 && cbAño.Text != "")
                    {
                        cbCampaña.DataSource = null;
                        cbCampaña.DataSource = CCampaña.buscarxaño(cbAño.Text);
                        cbCampaña.DisplayMember = "descripcion";
                        cbCampaña.ValueMember = "codcampaña";


                        cbCampaña.Refresh();
                    }
                }*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                if (dg_premio.Rows.Count == 0)
                {
                    MessageBox.Show("Lista vacía", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;

                }


                DataSet ds = new DataSet();
                DataTable dt = new DataTable("ListaGuias");
                // Columnas
                foreach (DataGridViewColumn column in dg_premio.Columns)
                {
                    DataColumn dc = new DataColumn(column.Name.ToString());
                    dt.Columns.Add(dc);
                }
                // Datos
                for (int i = 0; i < dg_premio.Rows.Count; i++)
                {
                    DataGridViewRow row = dg_premio.Rows[i];
                    DataRow dr = dt.NewRow();

                    for (int j = 0; j < dg_premio.Columns.Count; j++)
                    {
                        dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                    }
                    dt.Rows.Add(dr);
                }

                ds.Tables.Add(dt);
                ds.WriteXml("C:\\XML\\ListaPremioDicaleRPT.xml", XmlWriteMode.WriteSchema);


                CRListaPremios rpt = new CRListaPremios();
                frmRptListaPremios frm = new frmRptListaPremios();
                rpt.SetDataSource(ds);
                frm.crvLista.ReportSource = rpt;
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;

            }
        }
    }
}
