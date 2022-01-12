using System;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmCargaPremio : DevComponents.DotNetBar.Office2007Form
    {
        public frmCargaPremio()
        {
            InitializeComponent();
        }

        private void frmCargaPremio_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            llenacombos();
        
            this.Cursor = Cursors.Default;
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {

                dgvpremios.DataSource = null;

                openFileDialog1.Filter = "Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx";
                openFileDialog1.Title = "Seleccione el archivo de Excel";
                openFileDialog1.FileName = String.Empty;

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    this.Cursor = Cursors.Default;

                    txtRuta.Text = openFileDialog1.FileName;

                    if (txtRuta.Text == "")
                    {
                        MessageBox.Show("Escoja la ruta del archivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                        return;
                    }

                    DataTable tabla= CPremio.cargarGrilla(txtRuta.Text);

                    if (tabla != null)
                    {
                        dgvpremios.DataSource = tabla;
                    }

                    // dgvpremios.DataSource = CPremio.cargarGrilla(txtRuta.Text);
                    //dgvpremios.Refresh();

                    lbregistro.Text = dgvpremios.Rows.Count + " registros.";
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool rpta = true;
            this.Cursor = Cursors.WaitCursor;
            int cantidad = 0;
            int contador = 0;

            try
            {
                if (txtRuta.Text == "")
                {
                    MessageBox.Show("Ingrese ruta de archivo excel", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (dgvpremios.Rows.Count == 0)
                {
                    MessageBox.Show("Primero carge grilla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (cbCampaña.Text == "")
                {
                    MessageBox.Show("Primero carge la campaña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                contador = dgvpremios.Rows.Count;

                Premio pre = new Premio();

                pre.CodCampaña = Convert.ToInt32(cbCampaña.SelectedValue.ToString());
                

                for (int i = 0; i < dgvpremios.Rows.Count; i++)
                {

                    pre.Dni = dgvpremios.Rows[i].Cells[0].Value.ToString().Trim();
                    pre.Promotor =dgvpremios.Rows[i].Cells[1].Value.ToString().Trim();
                    pre.CompraFacturada= dgvpremios.Rows[i].Cells[6].Value.ToString().Trim();
                    pre.FechaValidacion1 = dgvpremios.Rows[i].Cells[7].Value.ToString().Trim();
                    pre.PremioRegular = dgvpremios.Rows[i].Cells[8].Value.ToString().Trim();
                    pre.EnvioPremioRegular = dgvpremios.Rows[i].Cells[9].Value.ToString().Trim();
                    pre.PremioAfi = dgvpremios.Rows[i].Cells[10].Value.ToString().Trim();
                    pre.Valido = dgvpremios.Rows[i].Cells[11].Value.ToString().Trim();
                    pre.Codusuario = Session.CodUsuario;

                    rpta = CPremio.insertar(pre);

                    if (rpta == true)
                    {
                        cantidad = cantidad + 1;
                    }
                    else
                    {
                        txtPromotor.Text += pre.Promotor+ Environment.NewLine;
                    }
                }

                dgvpremios.Refresh();

                MessageBox.Show(cantidad + " premios guardados. " + (contador - cantidad) + " no se guardaron.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbregistro.Text = dgvpremios.Rows.Count + " registros.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

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

        private void cbAño_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
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
                        cbCampaña.SelectedIndex = -1;

                        cbCampaña.Refresh();
                    }
                }*/

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void frmCargaPremio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
