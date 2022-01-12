using System;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frm_ProductosSalida : DevComponents.DotNetBar.Office2007Form
    {

        public Producto producto = null;

        public frm_ProductosSalida()
        {
            InitializeComponent();
        }

        private void frm_ProductosSalida_Load(object sender, EventArgs e)
        {
            try
            {
                txtproducto.Focus();
                busqueda();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void busqueda()
        {
            try
            {
                string filtro = "";
                dgvSalida.DataSource = null;


                dgvSalida.AutoGenerateColumns = false;
                dgvSalida.DataSource = CProducto.busquedaxfiltro(txtproducto.Text, filtro);

                lbregistro.Text = dgvSalida.Rows.Count.ToString() + " registros.";
                //dgvProductos.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvSalida_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgvSalida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (dgvSalida.Rows.Count >= 1 && e.RowIndex != -1 && dgvSalida.CurrentRow.Index == e.RowIndex)
                {
                    DataGridViewRow Row = dgvSalida.Rows[e.RowIndex];

                    producto = new Producto();
                    producto.CodProducto = Convert.ToInt32(Row.Cells[codproducto.Name].Value);
                    producto.Descripcion2 = Row.Cells[descripcion2.Name].Value.ToString();
                    producto.Color = Row.Cells[color.Name].Value.ToString();
                    producto.Talla = Row.Cells[talla.Name].Value.ToString();
                    producto.Totalpreprom2=Convert.ToDecimal(Row.Cells[totalpreprom2.Name].Value.ToString());

                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtproducto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                dgvSalida.DataSource = null;
                string filtro = "";

                dgvSalida.AutoGenerateColumns = false;
                dgvSalida.DataSource = CProducto.busquedaxfiltro(txtproducto.Text, filtro);
                lbregistro.Text = dgvSalida.Rows.Count.ToString() + " registros.";
                dgvSalida.Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_ProductosSalida_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void frm_ProductosSalida_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
