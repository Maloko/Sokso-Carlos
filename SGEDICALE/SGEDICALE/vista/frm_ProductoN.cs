using System;
using System.Drawing;
using System.Windows.Forms;
using SGEDICALE.controlador;


namespace SGEDICALE.vista
{
    public partial class frm_ProductoN : DevComponents.DotNetBar.Office2007Form
    {
        public frm_ProductoN()
        {
            InitializeComponent();
        }

        private void frm_ProductoN_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dg_producto.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dg_producto.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9);
            cargaProductos();


            this.Cursor = Cursors.Default;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frm_RegistroProductoN frmpn = new frm_RegistroProductoN();
            frmpn.ShowDialog();

            cargaProductos();
        }


        public void cargaProductos()
        {

            try
            {

               
                dg_producto.DataSource = null;
                dg_producto.AutoGenerateColumns = false;
                dg_producto.DataSource = CProducto.listadoNuevos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        public void editar()
        {

            this.Cursor = Cursors.WaitCursor;

            int codpro;
            if (dg_producto.Rows.Count >= 1)
            {
                if (dg_producto.CurrentRow.Index != -1)
                {

                    codpro = Convert.ToInt32(dg_producto.CurrentRow.Cells["codproducto"].Value);

                    frm_RegistroProductoN frmpro = new frm_RegistroProductoN(codpro);
                    frmpro.ShowDialog();
                    cargaProductos();

                }
            }

            this.Cursor = Cursors.Default;
        }

        private void dg_producto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int codproducto = 0;
                if (dg_producto.Rows.Count > 0)
                {
                    if (dg_producto.CurrentCell != null)
                    {
                        if (dg_producto.CurrentCell.RowIndex != -1)
                        {
                            codproducto = Convert.ToInt32(dg_producto.Rows[e.RowIndex].Cells["codproducto"].Value);

                            if (codproducto > 0)
                            {
                                frm_RegistroProductoN frmconsulta = new frm_RegistroProductoN(codproducto);
                                frmconsulta.ShowDialog();
                            }
                        }
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
