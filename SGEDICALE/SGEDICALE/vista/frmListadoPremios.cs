using System;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmListadoPremios : DevComponents.DotNetBar.Office2007Form
    {
        public frmListadoPremios()
        {
            InitializeComponent();
        }

        private void frmListadoPremios_Load(object sender, EventArgs e)
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



        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }


        public void buscar()
        {

            this.Cursor = Cursors.WaitCursor;

            string nombre = "";

            nombre = txtnombre.Text;

            dgvPremios.DataSource = null;
            dgvPremios.Rows.Clear();
            dgvPremios.DataSource = CPremio.busqueda(nombre, Convert.ToInt32(cbCampaña.SelectedValue));
            lbregistro.Text = dgvPremios.Rows.Count.ToString() + " registros.";
            dgvPremios.Refresh();
            

            this.Cursor = Cursors.Default;
        }


        private void frmListadoPremios_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {

                this.Close();
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

        private void cbCampaña_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbCampaña != null)
            {
                if (cbCampaña.Text != "")
                {
                    buscar();
                }
            }

          
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (cbCampaña.SelectedValue != null)
                {

                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar todos los premios ?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool rpta = CPremio.borrar(Convert.ToInt32(cbCampaña.SelectedValue));
                        buscar();
                    }
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
