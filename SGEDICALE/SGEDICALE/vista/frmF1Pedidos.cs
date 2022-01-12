using System;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;

namespace SGEDICALE.vista
{
    public partial class frmF1Pedidos : DevComponents.DotNetBar.Office2007Form
    {

        public Pedido pedi = null;
        public int codpromotor=0;

        public frmF1Pedidos()
        {
            InitializeComponent();
        }

        private void frmF1Pedidos_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            cargapedidos();
            this.Cursor = Cursors.Default;
        }

        public void cargapedidos()
        {

            this.Cursor = Cursors.WaitCursor;

            dgvPedidos.DataSource = CPedido.listarPedidosxPromotor_Fecha_Filtro(codpromotor, txtnombre.Text);
            dgvPedidos.Refresh();

            lbregistro.Text = dgvPedidos.Rows.Count.ToString() + " registros.";

            this.Cursor = Cursors.Default;
        }

        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                if (dgvPedidos.Rows.Count > 0)
                {
                    if (dgvPedidos.CurrentCell != null)
                    {
                        if (dgvPedidos.CurrentCell.RowIndex != -1)
                        {
                            pedi = new Pedido();
                            pedi.CodPedido = Convert.ToInt32(dgvPedidos.Rows[e.RowIndex].Cells[0].Value);
                            pedi.Numeropedido =dgvPedidos.Rows[e.RowIndex].Cells[1].Value.ToString();
                            pedi.Promotor=dgvPedidos.Rows[e.RowIndex].Cells[2].Value.ToString();

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
            cargapedidos();
     
        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            cargapedidos();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            string nombre = "";

            nombre = txtnombre.Text;

            if (nombre != "")
            {
                cargapedidos();
                lbregistro.Text = dgvPedidos.Rows.Count.ToString() + " registros.";
                dgvPedidos.Refresh();
            }
     
            this.Cursor = Cursors.Default;
        }

        private void frmF1Pedidos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
