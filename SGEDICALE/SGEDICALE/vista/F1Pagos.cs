using System;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;

namespace SGEDICALE.vista
{
    public partial class F1Pagos : DevComponents.DotNetBar.Office2007Form
    {

        public Pago pago=null;
        int codban = 0;
        int codcuent = 0;

        public F1Pagos()
        {
            InitializeComponent();
        }

        public F1Pagos(int cb, int cc)
        {
            InitializeComponent();
            codban = cb;
            codcuent = cc;
        }

        private void F1Pagos_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dtpFechaI.Value = DateTime.Now.AddDays(-7);
            dtpFechaFin.Value = DateTime.Now;

            this.Cursor = Cursors.Default;
        }

        private void txtnumerooperacion_TextChanged(object sender, EventArgs e)
        {
            busqueda();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busqueda();
        }


        public void busqueda()
        {

            this.Cursor = Cursors.WaitCursor;

            try
            {

                DataTable dt = new DataTable();
                dgvPagos.DataSource = null;

                if (dtpFechaI.Value > dtpFechaFin.Value)
                {
                    MessageBox.Show("Fecha inicial no puede ser mayyor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (codban > 0 && codcuent > 0)
                {
                    dgvPagos.AutoGenerateColumns = false;
                    dgvPagos.DataSource = CPago.listarpagoxfechaoperacion(txtnumerooperacion.Text, codban, codcuent, dtpFechaI.Value, dtpFechaFin.Value);
                    dgvPagos.Refresh();
                }
                else
                {
                    MessageBox.Show("Seleccione banco y cuenta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                lblregistros.Text = dgvPagos.Rows.Count + " registros.";
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void dgvPagos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                if (dgvPagos.Rows.Count > 0)
                {
                    if (dgvPagos.CurrentCell != null)
                    {
                        if (dgvPagos.CurrentCell.RowIndex != -1)
                        {
                            pago = new Pago();
                            pago.CodPago = Convert.ToInt32(dgvPagos.Rows[e.RowIndex].Cells["codpago"].Value);

                            Pago pagosaldo = CPago.buscarSaldoPago(pago.CodPago);

                            if (pagosaldo != null)
                            {
                                pago.Monto = pagosaldo.Monto;
                            }
                            else
                            {
                                pago.Monto = Convert.ToDecimal(dgvPagos.Rows[e.RowIndex].Cells["monto"].Value);
                            }

                            pago.Codbanco = Convert.ToInt32(dgvPagos.Rows[e.RowIndex].Cells["codbanco"].Value);
                            pago.Codcuenta = Convert.ToInt32(dgvPagos.Rows[e.RowIndex].Cells["codcuenta"].Value);
                            pago.Operacionnumero = dgvPagos.Rows[e.RowIndex].Cells["operacionnumero"].Value.ToString();
                            pago.Operacionhora= dgvPagos.Rows[e.RowIndex].Cells["operacionhora"].Value.ToString();
                   
                    
                            

                            DialogResult = DialogResult.OK;
                            this.Cursor = Cursors.Default;


                        }
                    }
                }

                this.Close();

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }

        private void dtpFechaI_ValueChanged(object sender, EventArgs e)
        {
            if (!dtpFechaFin.Value.ToString().Contains("1/01/0001"))
            {
                busqueda();
            }
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            busqueda();
        }

        private void F1Pagos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtnumerooperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            enteros(e);  
        }

        public void enteros(KeyPressEventArgs e)
        {
            String Aceptados = "0123456789" + Convert.ToChar(8);

            if (Aceptados.Contains("" + e.KeyChar))
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
    }
}
