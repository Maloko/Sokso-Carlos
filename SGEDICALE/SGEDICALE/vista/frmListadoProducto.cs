using System;
using System.Windows.Forms;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmListadoProducto : DevComponents.DotNetBar.Office2007Form
    {

        public string botonborrar = "";

        public frmListadoProducto()
        {
            InitializeComponent();
        }

        private void frmListasdoProducto_Load(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            if (botonborrar == "")
            {
                btnEliminar.Visible = false;
            }

            cargaproductos();

            this.Cursor = Cursors.Default;
        }

        public void cargaproductos()
        {

            dgvProducto.DataSource = null;
            dgvProducto.AutoGenerateColumns = false;

            dgvProducto.DataSource = CProducto.listado();
            dgvProducto.Refresh();

            lbregistro.Text = dgvProducto.Rows.Count.ToString() + " registros.";

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            string nombre = "";

            nombre = txtnombre.Text;

            if (nombre != "")
            {
                dgvProducto.DataSource = CProducto.busqueda(nombre);
                lbregistro.Text = dgvProducto.Rows.Count.ToString() + " registros.";
                dgvProducto.Refresh();
            }

            this.Cursor = Cursors.Default;
        }

        private void frmListadoProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            try
            {

                if (dgvProducto.Rows.Count > 0)
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar todos los productos ?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool rpta = CProducto.borrarTodo();
                        cargaproductos();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbregistro_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            try
            {

                int codpromotor = 0;
                if (dgvProducto.Rows.Count > 0)
                {

                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar el producto ?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {

                        codpromotor = Convert.ToInt32(dgvProducto.CurrentRow.Cells[0].Value);
                        bool rpta = CProducto.borrar(codpromotor);

                        if (rpta == true)
                        {
                            MessageBox.Show("Producto eliminado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se puede eliminar porque tiene pedidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        cargaproductos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }
    }
}
