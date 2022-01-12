using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.reportes;
using SGEDICALE.reportes.clsReportes;

namespace SGEDICALE.vista
{
    public partial class frm_Comparativa : DevComponents.DotNetBar.Office2007Form
    {
        clsReporte ds = new clsReporte();
        public frm_Comparativa()
        {
            InitializeComponent();
        }

        private void frm_Comparativa_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                cargaAños();
                //cargaCampaña();
                //cargaCategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }


        public void cargaAños()
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


            cboAño.DataSource = dt1;
            cboAño.ValueMember = "Descripcion";
            cboAño.DisplayMember = "Descripcion";

            cboAño_SelectedIndexChanged(null, null);

        }


        public void cargaCategoria()
        {
            cbCategoria.DataSource = null;
            if (cboCampaña.SelectedValue != null)
            {

                cbCategoria.DataSource = CCategoria.ListadoCategoriaxCampaña(Convert.ToInt32(cboCampaña.SelectedValue));
                cbCategoria.ValueMember = "codcategoria";
                cbCategoria.DisplayMember = "descripcion";
                cbCategoria.Refresh();
            }
        }

        public void cargaCampaña()
        {
            //cboCampaña.DataSource = CCampaña.CargaCampañaActivas();
            cboCampaña.DataSource = null;
            if (cboAño.SelectedValue != null)
            {
                if (cboAño.Items.Count > 0)
                {
                    cboCampaña.DataSource = CCampaña.buscarxaño(cboAño.SelectedValue.ToString());
                    cboCampaña.ValueMember = "codcampana";
                    cboCampaña.DisplayMember = "descripcion";
                    cboCampaña.Refresh();

                    cargaCategoria();
                }
            }
        }
        private void frm_Comparativa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {


                int codcampana = 0;
                dgvComparacion.DataSource = null;


                if (cboCampaña.SelectedValue != null)
                {
                    codcampana = Convert.ToInt32(cboCampaña.SelectedValue.ToString());
                    dgvComparacion.DataSource = CPrecio.Comparacion(codcampana);
                }

                dgvComparacion.Refresh();
                lbregistro.Text = dgvComparacion.Rows.Count + " registros.";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvComparacion.Rows.Count == 0)
                {
                    MessageBox.Show("Lista vacía", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                DataSet ds = new DataSet();
                DataTable dt = new DataTable("ListaGuias");
                dt.Columns.Add("nombrepromotor", typeof(string));
                dt.Columns.Add("campana", typeof(string));
                dt.Columns.Add("pag", typeof(string));
                dt.Columns.Add("producto", typeof(string));
                dt.Columns.Add("marca", typeof(string));
                dt.Columns.Add("modelo", typeof(string));
                dt.Columns.Add("color", typeof(string));
                dt.Columns.Add("categoria", typeof(string));
                dt.Columns.Add("talla", typeof(string));
                dt.Columns.Add("ppromotor", typeof(decimal));
                dt.Columns.Add("totalpreprom2", typeof(decimal));
                dt.Columns.Add("cat", typeof(string));


                foreach (DataGridViewRow dgv in dgvComparacion.Rows)
                {
                    dt.Rows.Add(dgv.Cells["nombrepromotor"].Value,
                    dgv.Cells["campana"].Value,
                    dgv.Cells["pag"].Value,
                    dgv.Cells["producto"].Value,
                    dgv.Cells["marca"].Value,
                    dgv.Cells["modelo"].Value,
                    dgv.Cells["color"].Value,
                    dgv.Cells["categoria"].Value,
                    dgv.Cells["talla"].Value,
                    dgv.Cells["ppromotor"].Value,
                    dgv.Cells["totalpreprom2"].Value,
                    cbCategoria.Text);
                }
                ds.Tables.Add(dt);
                ds.WriteXml("C:\\XML\\ReportePrecioDicaleRPT.xml", XmlWriteMode.WriteSchema);

                //CRReportePrecio rpt = new CRReportePrecio();
                CRComparativaPrecios rpt = new CRComparativaPrecios();
                frmReportePrecio frm = new frmReportePrecio();
                rpt.SetDataSource(ds);
                frm.crReportePrecio.ReportSource = rpt;
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;

            }

            this.Cursor = Cursors.Default;
        }

        private void cboAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaCampaña();
        }
    }
}
