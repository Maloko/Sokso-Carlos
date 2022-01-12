using System;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using SGEDICALE.reportes;
using SGEDICALE.reportes.clsReportes;

namespace SGEDICALE.vista
{
    public partial class frmEntregar : DevComponents.DotNetBar.Office2007Form
    {

        private Premio premio = null;

        public frmEntregar()
        {
            InitializeComponent();
        }

        private void frmEntregar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmEntregar_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

        
            llenacombos();
           

            this.Cursor = Cursors.Default;
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

        private void cbAño_SelectedIndexChanged(object sender, EventArgs e)
        {

            cargaCampaña();
  

            /*
            try
            {

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
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void txtCod_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    if (Application.OpenForms["frmListadoPromotores"] != null)
                    {
                        Application.OpenForms["frmListadoPromotores"].Activate();
                    }
                    else
                    {
                        Promotor pro = null;
                        frmListadoPromotores form = new frmListadoPromotores();

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            pro = form.promotor;

                            if (pro != null)
                            {
                                txtCod.Text = pro.CodPromotor.ToString();
                                txtpromotor.Text = pro.Nombrecompleto;



                            }
                            else
                            {
                                txtCod.Focus();
                                this.Cursor = Cursors.Default;
                                return;
                            }
                        }
                    }
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void txtcodpedido_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txtCod.Text != "")
                {
                    if (e.KeyCode == Keys.F1)
                    {
                        if (Application.OpenForms["frmF1Premios"] != null)
                        {
                            Application.OpenForms["frmF1Premios"].Activate();
                        }
                        else
                        {

                            frmF1Premios formf1 = new frmF1Premios();

                            formf1.codcampana = Convert.ToInt32(cbCampaña.SelectedValue);
                            formf1.codpromotor = Convert.ToInt32(txtCod.Text);

                            if (formf1.ShowDialog() == DialogResult.OK)
                            {

                                premio = formf1.premio;


                                /*

                                if (pedi != null)
                                {
                                    txtcodpedido.Text = pedi.CodPedido.ToString();
                                    txtnumero.Text = pedi.Numeropedido.ToString();
                                    pedi.CodPromotor = Convert.ToInt32(txtCod.Text);

                                    cargarpedido();

                                }
                                else
                                {
                                    this.Cursor = Cursors.Default;
                                    return;
                                }*/
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese Promotor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                if (cbCampaña != null)
                {

                    if (cbCampaña.Items.Count > 0)
                    {

                        if (txtCod.Text != "")
                        {

                            if (cbCampaña.Text != "")
                            {

                                if (Application.OpenForms["frmF1Premios"] != null)
                                {
                                    Application.OpenForms["frmF1Premios"].Activate();
                                }
                                else
                                {

                                    frmF1Premios formf1 = new frmF1Premios();

                                    formf1.codpromotor = Convert.ToInt32(txtCod.Text);
                                    formf1.codcampana = Convert.ToInt32(cbCampaña.SelectedValue);

                                    if (formf1.ShowDialog() == DialogResult.OK)
                                    {

                                        /*
                                            pedi = formf1.pedi;

                                            if (pedi != null)
                                            {
                                                txtcodpedido.Text = pedi.CodPedido.ToString();
                                                txtnumero.Text = pedi.Numeropedido.ToString();
                                                pedi.CodPromotor = Convert.ToInt32(txtCod.Text);

                                                cargarpedido();

                                            }
                                            else
                                            {
                                                this.Cursor = Cursors.Default;
                                                return;
                                            }

                                            */
                                    }

                                }
                            }
                            else
                            {
                                MessageBox.Show("Seleccione campaña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ingrese Promotor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPremios.Rows.Count > 0)
            {

                dgvPremios.Rows.Remove(dgvPremios.CurrentRow);

            }
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (cbCampaña != null)
                {
                    if (cbCampaña.Items.Count > 0)
                    {
                        if (txtCod.Text != "")
                        {
                            if (cbCampaña.Text != "")
                            {
                                if (dgvPremios.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dgvPremios.Rows.Count; i++)
                                    {
                                        premio = new Premio();
                                        premio.CodPremio = Convert.ToInt32(dgvPremios.Rows[i].Cells["codpremio"].Value.ToString());
                                        premio.CodCampaña = Convert.ToInt32(cbCampaña.SelectedValue);
                                        premio.Entregado = 1;

                                        CPremio.entregar(premio);

                                        actualizagrilla();


                                        
                                    }
                                    MessageBox.Show("Premios entregados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    imprimir();


                                }
                            }
                            else
                            {
                                MessageBox.Show("Seleccione campaña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Ingrese Promotor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        public void actualizagrilla()
        {
            for (int i = 0; i < dgvPremios.Rows.Count; i++)
            {
                dgvPremios.Rows[i].Cells["entregado"].Value="ENTREGADO";
                dgvPremios.Refresh();   
            }
        }

        public void imprimir()
        {
            try
            {

                if (dgvPremios.Rows.Count == 0)
                {
                    MessageBox.Show("Lista vacía", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;

                }


                DataSet ds = new DataSet();
                DataTable dt = new DataTable("ListaGuias");
                // Columnas
                foreach (DataGridViewColumn column in dgvPremios.Columns)
                {
                    DataColumn dc = new DataColumn(column.Name.ToString());
                    dt.Columns.Add(dc);
                }
                // Datos
                for (int i = 0; i < dgvPremios.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvPremios.Rows[i];
                    DataRow dr = dt.NewRow();

                    for (int j = 0; j < dgvPremios.Columns.Count; j++)
                    {
                        dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                    }
                    dt.Rows.Add(dr);
                }

                ds.Tables.Add(dt);
                ds.WriteXml("C:\\XML\\EntregarPremioDicaleRPT.xml", XmlWriteMode.WriteSchema);


                CREntregaPremio rpt = new CREntregaPremio();
                frmRptEntrega frm = new frmRptEntrega();
                rpt.SetDataSource(ds);
                frm.crvEntrega.ReportSource = rpt;
                frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;

            }

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

            if (premio == null)
            {
                MessageBox.Show("Registrar primero la entrega", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;
                return;
            }


            imprimir();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
