using System;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmListadoPago : DevComponents.DotNetBar.Office2007Form
    {
        public frmListadoPago()
        {
            InitializeComponent();
        }

        private void frmListadoPago_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dtpFechaI.Value = DateTime.Now.Date;
            dtpFechaFin.Value = DateTime.Now.Date;

            CargaBancos();
            cbBanco_SelectionChangeCommitted(null, null);

            this.Cursor = Cursors.Default;
        }


        private void CargaBancos()
        {
            cbBanco.DataSource = CBanco.cargacombobancos();
            cbBanco.DisplayMember = "descripcion";
            cbBanco.ValueMember = "codBanco";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {

                int codbanco = 0;
                int codcuenta = 0;
                DataTable dt = new DataTable();

                dgvPagos.DataSource = null;

                if (cbBanco == null || cbCuenta==null)
                {
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (cbBanco.Text == "" || cbCuenta.Text == "")
                {
                    this.Cursor = Cursors.Default;
                    return;
                }

                dgvPagos.DataSource = null;
                dgvPagos.Rows.Clear();

                codbanco = Convert.ToInt32(cbBanco.SelectedValue.ToString());
                codcuenta = Convert.ToInt32(cbCuenta.SelectedValue.ToString());

            
                dgvPagos.DataSource = CPago.listarPagosFiltro(codbanco, codcuenta,dtpFechaI.Value,dtpFechaFin.Value);


                //dgvlistado.DataSource=CPedido.listarPedidos(Convert.ToInt32(cbPedido.SelectedValue));
                dgvPagos.Refresh();
                lblregistros.Text = dgvPagos.Rows.Count + " registros.";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void cbBanco_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int codban = 0;
            cbCuenta.DataSource = null;

            if (cbBanco != null)
            {

                if (cbBanco.Items.Count > 0)
                {

                    codban = Convert.ToInt32(cbBanco.SelectedValue.ToString());

                    cbCuenta.DataSource = CCuenta.buscarxcodbanco(codban);
                    cbCuenta.DisplayMember = "cuentaCorriente";
                    cbCuenta.ValueMember = "codCuentaCorriente";

                }
            }

        }

        private void frmListadoPago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void lblregistros_Click(object sender, EventArgs e)
        {

        }
    }
}
