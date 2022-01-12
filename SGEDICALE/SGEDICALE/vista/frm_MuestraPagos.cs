using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;

namespace SGEDICALE.vista
{
    public partial class frm_MuestraPagos : DevComponents.DotNetBar.Office2007Form
    {

        public Comprobantee comprobante=null;



        public frm_MuestraPagos()
        {
            InitializeComponent();
        }

        public frm_MuestraPagos(Comprobantee comprobantee)
        {
            InitializeComponent();
            comprobante = comprobantee;
        }


        private void frm_MuestraPagos_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            cargarcobros();

            this.Cursor = Cursors.Default;
        }

        public void cargarcobros()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                dgvListaCobros.AutoGenerateColumns = false;
                dgvListaCobros.DataSource = null;

                dgvListaCobros.DataSource=CCobro.muestra_cobrosxcodComprobante(comprobante.CodComprobante);

                lbregistro.Text = dgvListaCobros.Rows.Count.ToString() + " registros.";

                totales();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        public void totales()
        {
            try
            {

                if (dgvListaCobros.Rows.Count > 0)
                {


                    txttotal.Text =comprobante.Total.ToString();

                    txtcobrado.Text = Math.Round((dgvListaCobros.Rows.Cast<DataGridViewRow>().Where(
                        x => x.Cells["estado"].Value.ToString() == "ACTIVO"

                      ).Select(x => decimal.Parse(x.Cells["monto"].Value.ToString())).Sum()), 2).ToString();


                    txtpendiente.Text =Convert.ToString(Convert.ToDecimal(txttotal.Text) - Convert.ToDecimal(txtcobrado.Text));

                }
                else
                {

                    txtpendiente.Text = "0.00";
                    txtcobrado.Text = "0.00";
                    txttotal.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }

        }


        private void frm_MuestraPagos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
