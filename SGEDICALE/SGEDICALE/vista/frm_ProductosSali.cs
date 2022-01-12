using System;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frm_ProductosSali : DevComponents.DotNetBar.Office2007Form
    {

        public Producto producto = null;

        public frm_ProductosSali()
        {
            InitializeComponent();
        }

        private void frm_ProductosSali_Load(object sender, EventArgs e)
        {

            try
            {
                radioButton1.Checked = true;
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

                if (radioButton1.Checked == true)
                {
                    filtro = "nuevos";
                }
                if (radioButton2.Checked == true)
                {
                    filtro = "antiguos";
                }

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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton1.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton2.Checked = false;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            txtproducto.Focus();
            radioButton2.Checked = false;
            if (txtproducto.Text == "")
            {
                busqueda();
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {

            txtproducto.Focus();
            radioButton1.Checked = false;

            if (txtproducto.Text == "")
            {
                busqueda();
            }
        }

        private void txtproducto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtproducto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                dgvSalida.DataSource = null;
                string filtro = "";


                if (radioButton1.Checked == true)
                {
                    filtro = "nuevos";
                }
                if (radioButton2.Checked == true)
                {
                    filtro = "antiguos";
                }

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

        private void frm_ProductosSali_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
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
                    producto.Codigosap = Convert.ToInt32(Row.Cells[codigosap.Name].Value.ToString());

                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frm_ProductosSali_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
