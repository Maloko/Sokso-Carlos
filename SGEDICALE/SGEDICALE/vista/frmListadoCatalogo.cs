using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.controlador;


namespace SGEDICALE.vista
{
    public partial class frmListadoCatalogo : DevComponents.DotNetBar.Office2007Form
    {
        public frmListadoCatalogo()
        {
            InitializeComponent();
        }

        private void frmListasdoCatalogo_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                //cargaCampaña();
                //cargaCategoria();
                cargaraño();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        public void cargaraño()
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

            cboAño_SelectedIndexChanged(null,null);

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
            if (cboAño.SelectedValue!=null)
            {
                if (cboAño.Items.Count >0)
                {
                    cboCampaña.DataSource = CCampaña.buscarxaño(cboAño.SelectedValue.ToString());
                    cboCampaña.ValueMember = "codcampana";
                    cboCampaña.DisplayMember = "descripcion";
                    cboCampaña.Refresh();

                    cargaCategoria();
                }
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                int codcampana = 0;
                string categoria = "";
                DataTable dt = new DataTable();


                dgvPrecios.DataSource = null;
                dgvPrecios.Rows.Clear();

                if (cboCampaña.Items.Count == 0)
                {
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (cbCategoria.Items.Count == 0)
                {
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (cbCategoria.Text == "")
                {
                    this.Cursor = Cursors.Default;
                    return;
                }

             

                codcampana = Convert.ToInt32(cboCampaña.SelectedValue.ToString());

                dgvPrecios.DataSource = CPrecio.busquedaDetalle(codcampana);

                dgvPrecios.Refresh();
                lbregistro.Text = dgvPrecios.Rows.Count + " registros.";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void frmListadoCatalogo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cboCampaña_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargaCategoria();
        }

  

        private void cboAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaCampaña();
        }
    }
}
