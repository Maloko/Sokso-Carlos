using System;
using System.Drawing;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;

namespace SGEDICALE.vista
{
    public partial class frmConsultaPedido : DevComponents.DotNetBar.Office2007Form
    {
        public int codpedido = 0;

        public frmConsultaPedido(int cod)
        {
            codpedido = cod;
            InitializeComponent();
        }

        public frmConsultaPedido()
        {
            InitializeComponent();
        }

        private void frmConsultaPedido_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            cargarpedido();
           
            this.Cursor = Cursors.Default;
        }

        public void cargarpedido()
        {
            try
            {
                int color = 0;
                Pedido pedido = CPedido.buscar(codpedido);

                if (pedido == null)
                {
                    this.Cursor = Cursors.Default;
                    return;
                }

                txtcodigo.Text = pedido.CodPedido.ToString();
                txtnumeropedido.Text = pedido.Numeropedido.ToString();
                dtpFecha.Value = pedido.Fechapedido;
                txtPromotor.Text = pedido.Promotor.ToString();


                txtsubtotal.Text = pedido.Subtotal.ToString();
                txtIgv.Text = pedido.Igv.ToString();
                txttotal.Text = pedido.Total.ToString();

                dgvdetallepedido.DataSource = CDetallePedido.listardetallefiltro(codpedido);

                if (dgvdetallepedido.Rows.Count > 0)
                {

                    foreach (DataGridViewRow row in dgvdetallepedido.Rows)
                    {
                        color = Convert.ToInt32(row.Cells[13].Value);
                        darColorGrilla(row.Index,color);
                    }
                }

                dgvdetallepedido.Refresh();
                lblregistro.Text = dgvdetallepedido.Rows.Count + " registros.";
                dgvdetallepedido.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }

        public void darColorGrilla(int i,int color)
        {

            //dgvdetallepedido.Rows[i].DefaultCellStyle.Font = new Font(dgvdetallepedido.DefaultCellStyle.Font, FontStyle.Bold);
            switch (color)
            {
                case 1:
                    dgvdetallepedido.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                    break;
                case 2:
                    dgvdetallepedido.Rows[i].DefaultCellStyle.BackColor = Color.CornflowerBlue;
                    break;
                /*
                case 0:
                    dgvdetallepedido.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    break;*/
            }

        }

        private void frmConsultaPedido_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}
