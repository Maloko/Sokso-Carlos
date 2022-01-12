using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;

namespace SGEDICALE.vista
{
    public partial class frmRegistroProductos : DevComponents.DotNetBar.Office2007Form
    {


        public static BindingSource data = new BindingSource();
        String filtro = String.Empty;

        private List<TipoDocumentoIdentidad> lista_tipodoc = null;
        private List<TipoPersona> lista_tipopro = null;
        public int codp = 0;


        public frmRegistroProductos()
        {
            InitializeComponent();
        }

        private void frmRegistroProductos_Load(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            cargarestado();

            cboEstado.SelectedIndex = 0;
            dgvProductos.AutoGenerateColumns = false;
            txtproducto.Focus();

            label7.Text = "PRODUCTO";
            label6.Text = "descripcion";

            this.Cursor = Cursors.Default;
        }

        public void cargarestado()
        {

            List<dynamic> listadinamica = new List<dynamic>()
            {

                new {codigo=1,descripcion = "ACTIVO" },
                new {codigo=0,descripcion="INACTIVO" }
            };

            cboEstado.DataSource = listadinamica;
            cboEstado.ValueMember = "codigo";
            cboEstado.DisplayMember = "descripcion";

        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                
                dgvProductos.DataSource = null;
                dgvProductos.AutoGenerateColumns = false;


                dgvProductos.DataSource = data;
                data.DataSource = CProducto.listado();
                data.Filter = String.Empty;
                filtro = String.Empty;
                dgvProductos.ClearSelection();

                lbregistro.Text = dgvProductos.Rows.Count + " registros.";

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            bool rpta = false;
            string mensaje = "";
            int numerodocumento = 0;

            try
            {

                Producto prom = new Producto();
                
                prom.Descripcion = txtproducto.Text.Trim();
                prom.Totalpreprom2 = Convert.ToDecimal(txtPrecio.Text.Trim());
                prom.Color = txtcolor.Text.Trim();
                prom.Talla = txtTalla.Text.Trim();
                prom.Estado = Convert.ToBoolean(cboEstado.SelectedValue);

                prom.Descripcion2 = prom.Descripcion + " - "+ prom.Color;

                if (prom.Descripcion2 == "" || prom.Totalpreprom2<=0)
                {
                    MessageBox.Show("Complete todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (txtcod.Text != "")
                {
                    codp = Convert.ToInt32(txtcod.Text);
                }

                if (codp == 0)
                {
                    rpta = CProducto.insertarProductoNuevo(prom);

                    LimpiarSoloCajas();
                    mensaje = "Producto guardado correctamente";

                }
                else
                {
                    prom.CodProducto = codp;
                    rpta = CProducto.actualizarProductoNuevo(prom);
                    mensaje = "Producto actualizado correctamente";

                }

                if (rpta == true)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;

                }

                btnListar_Click(null, null);

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            limpiar();

            this.Cursor = Cursors.Default;
        }

        public void limpiar()
        {
            btnListar_Click(null,null);

            txtcod.Clear();
            txtproducto.Clear();
            txtTalla.Clear();
            txtcolor.Clear();
            txtPrecio.Clear();
            txtcod.ReadOnly = true;
            txtproducto.Focus();
        }

        public void LimpiarSoloCajas()
        {
            txtcod.Clear();
            
            txtproducto.Clear();
            txtTalla.Clear();
            txtcolor.Clear();
            txtPrecio.Clear();
            txtcod.ReadOnly = true;
            txtproducto.Focus();

        }

        private void frmRegistroProductos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                
                if (dgvProductos.Rows.Count > 0)
                {
                    if (e.RowIndex != -1)
                    {
                        txtcod.Text = dgvProductos.Rows[e.RowIndex].Cells[codproducto.Index].Value.ToString();
                        txtPrecio.Text = dgvProductos.Rows[e.RowIndex].Cells[totalpreprom2.Index].Value.ToString();
                        txtproducto.Text = dgvProductos.Rows[e.RowIndex].Cells[descripcion.Index].Value.ToString();
                        txtcolor.Text = dgvProductos.Rows[e.RowIndex].Cells[color.Index].Value.ToString();
                        txtTalla.Text = dgvProductos.Rows[e.RowIndex].Cells[talla.Index].Value.ToString();
                        cboEstado.SelectedValue = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells[estado.Index].Value.ToString());

                    }
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        private void dgvDoctores_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label7.Text = dgvProductos.Columns[e.ColumnIndex].HeaderText;
            label6.Text = dgvProductos.Columns[e.ColumnIndex].DataPropertyName;
            if (expandablePanel1.Expanded)
            {
                txtFiltro.Focus();
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (!expandablePanel1.Expanded)
            {
                expandablePanel1.Expanded = true;
                txtFiltro.Focus();
            }
            else
            {
                expandablePanel1.Expanded = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = false;
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                expandablePanel1.Expanded = false;
            }
        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltro.Text.Length >= 2)
                {
                    //data.Filter = String.Format("Convert([codProducto], System.String) LIKE '%{0}%' OR [codUniversal] LIKE '%{0}%' OR [ubicacion] LIKE '%{0}%' OR [descripcion] LIKE '%{0}%' OR [modelo] LIKE '%{0}%' OR [nmarca] LIKE '%{0}%' OR [unidad] LIKE '%{0}%'", txtFiltro.Text.Trim());
                    data.Filter = String.Format("Convert([{0}], System.String) like '*{1}*'", label6.Text.Trim(), txtFiltro.Text.Trim());
                    //data.Filter = String.Format("[{0}] like '*{1}*'", label6.Text.Trim(), txtFiltro.Text.Trim());
                }
                else
                {
                    data.Filter = String.Empty;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!expandablePanel1.Expanded)
            {
                expandablePanel1.Expanded = true;
                txtFiltro.Focus();
            }
            else
            {
                expandablePanel1.Expanded = false;
            }
        }

   
    }
}
