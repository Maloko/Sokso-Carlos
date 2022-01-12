using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;


namespace SGEDICALE.vista
{
    public partial class frmUsoDeposito : DevComponents.DotNetBar.Office2007Form
    {

        string numeroOperacion = string.Empty;

        public frmUsoDeposito()
        {
            InitializeComponent();
        }

        public frmUsoDeposito(string numeroOp)
        {
            InitializeComponent();
            numeroOperacion = numeroOp;
        }

        private void frmUsoDeposito_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            cargarUsoDepositos();

            this.Cursor = Cursors.Default;
        }

        public void cargarUsoDepositos()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                dgvListaUsoDeposito.AutoGenerateColumns = false;
                dgvListaUsoDeposito.DataSource = null;

                dgvListaUsoDeposito.DataSource = CPagoComprobante.muestra_UsoDepositosxNumeroOperacion(numeroOperacion);
                lbregistro.Text = dgvListaUsoDeposito.Rows.Count.ToString() + " registros.";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void frmUsoDeposito_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
