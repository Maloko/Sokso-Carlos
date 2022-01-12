using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frm_Detalle : DevComponents.DotNetBar.Office2007Form
    {

        Producto pro = null;
        public string formulario = "";
        //  public CultureInfo elP;

        public frm_Detalle()
        {
            InitializeComponent();
        }

        private void frm_Detalle_Load(object sender, EventArgs e)
        {

            // elP = CultureInfo.CreateSpecificCulture("es-PE");


            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-PE");

            txtcodproducto.Focus();
            ActiveControl = txtcodproducto;

            txtTotal.Text = "0.00";
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void frm_Detalle_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyData == Keys.F1)
            {
                txtcliente_KeyDown(this, new KeyEventArgs(Keys.F1));
            }
        }

        private void txtcliente_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                String precio = "0.00";

                if (e.KeyCode == Keys.F1)
                {
                    if (Application.OpenForms["frm_ProductosSalida"] != null)
                    {
                        Application.OpenForms["frm_ProductosSalida"].Activate();
                    }
                    else
                    {

                        frm_ProductosSalida form = new frm_ProductosSalida();
                        limpiar();

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            pro = form.producto;
                            if (pro != null)
                            {
                                txtcodproducto.Text = pro.CodProducto.ToString();
                                txtProducto.Text = pro.Descripcion2;

                                //if (pro.Codigosap == 0)
                                //{

                                CargaUnidades();
                                txtCantidad.Focus();

                                precio = String.Format("{0:#,##0.00}", pro.Totalpreprom2);
                                txtPrecioUni.Text = precio;
                                txtTalla.Text = pro.Talla;
                                //}
                                /*
                                else
                                {
                                    txtPrecioUni.Focus();
                                    cbUnidad.Enabled = false;
                                }*/

                            }
                            else
                            {
                                txtcodproducto.Focus();
                                this.Cursor = Cursors.Default;
                                return;
                            }
                        }
                    }
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        public void limpiar()
        {
            txtcodproducto.Clear();
            txtProducto.Clear();
            txtPrecioUni.Clear();
            txtTotal.Clear();
            txtCantidad.Clear();
            cbUnidad.DataSource = null;
        }

        private void CargaUnidades()
        {

            cbUnidad.Enabled = true;

            DataTable table = new DataTable();

            table = CUnidadMedida.MuestraUnidades();
            cbUnidad.DataSource = table;


            cbUnidad.DisplayMember = "descripcion";
            cbUnidad.ValueMember = "codUnidadMedida";

            if (table.Rows.Count > 0)
            {

                cbUnidad.SelectedIndex = 0;
                cbUnidad_SelectionChangeCommitted(null, null);
            }
            else
            {
                cbUnidad.Enabled = false;
            }
        }


        private void txtcliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbUnidad_SelectionChangeCommitted(object sender, EventArgs e)
        {

            String precio = "0.00";

            if (cbUnidad != null)
            {
                if (cbUnidad.Items.Count > 0)
                {
                    ProductoUnidad pu = CProductoUnidad.precioventaxunidad(pro.CodProducto, Convert.ToInt32(cbUnidad.SelectedValue));

                    if (pu != null)
                    {
                        // precio = String.Format(elP,"{0:#,##0.00}", pu.Precioventa);
                        precio = String.Format("{0:#,##0.00}", pu.Precioventa);
                        txtPrecioUni.Text = precio;
                    }
                    else
                    {
                        txtPrecioUni.Text = precio;
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string talla = string.Empty;
            decimal cantidad = 0;
            decimal precio = 0;
            decimal total = 0;
            int codunidad = 0;
            string unidad = "";
            string tipoimpuesto = "10";
            try
            {
                if (txtTotal.Text != "")
                {

                    if (Convert.ToDecimal(txtTotal.Text) > 0)
                    {
                        if (pro.Codigosap == 0)
                        {

                            if (cbUnidad.Items.Count == 0)
                            {
                                MessageBox.Show("Ingrese Unidad Medida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        if (formulario == "NuevaVenta")
                        {

                            frmNuevaVenta form = (frmNuevaVenta)Application.OpenForms["frmNuevaVenta"];

                            cantidad = Convert.ToDecimal(txtCantidad.Text);
                            precio = Convert.ToDecimal(txtPrecioUni.Text);
                            total = Convert.ToDecimal(txtTotal.Text);
                            talla = txtTalla.Text;

                            if (cbUnidad.SelectedValue == null)
                            {
                                codunidad = 1;
                                unidad = "";
                            }
                            else
                            {
                                codunidad = Convert.ToInt32(cbUnidad.SelectedValue);
                                unidad = cbUnidad.Text;
                            }


                            form.dgvdetalle.Rows.Add(pro.CodProducto, pro.Descripcion2, talla, codunidad,
                                unidad, tipoimpuesto, cantidad, precio, total);


                            form.calculatotales();

                            this.Close();
                        }
                        else
                        {
                            frm_Ticket form = (frm_Ticket)Application.OpenForms["frm_Ticket"];

                            cantidad = Convert.ToDecimal(txtCantidad.Text);
                            precio = Convert.ToDecimal(txtPrecioUni.Text);
                            total = Convert.ToDecimal(txtTotal.Text);
                            talla = txtTalla.Text;

                            if (cbUnidad.SelectedValue == null)
                            {
                                codunidad = 0;
                                unidad = "";
                            }
                            else
                            {
                                codunidad = Convert.ToInt32(cbUnidad.SelectedValue);
                                unidad = cbUnidad.Text;
                            }


                            form.dgvProducto.Rows.Add(pro.CodProducto, pro.Descripcion2, talla, codunidad,
                                "", unidad, tipoimpuesto, cantidad, precio, total);



                            form.calculatotales();

                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Total no puede ser 0.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Total no puede ser vacío.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            if (txtCantidad.Text != "")
            {
                if (txtPrecioUni.Text != "")
                {
                    if (Convert.ToDecimal(txtCantidad.Text) > 0 && Convert.ToDecimal(txtPrecioUni.Text) > 0)


                        //txtTotal.Text = String.Format(elP,"{0:#,##0.00}", Convert.ToDouble(txtPrecioUni.Text) * Convert.ToDouble(txtCantidad.Text));
                        txtTotal.Text = String.Format("{0:#,##0.00}", Convert.ToDouble(txtPrecioUni.Text) * Convert.ToDouble(txtCantidad.Text));


                }
            }

            this.Cursor = Cursors.Default;
        }

        private void txtPrecioUni_Leave(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;



            if (txtPrecioUni.Text != "")
            {
                if (txtCantidad.Text != "")
                {
                    if (Convert.ToInt32(txtCantidad.Text) > 0 && Convert.ToDecimal(txtPrecioUni.Text) > 0)
                    {

                        //txtTotal.Text = String.Format(elP, "{0:#,##0.00}", (Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecioUni.Text)));
                        txtTotal.Text = String.Format("{0:#,##0.00}", (Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecioUni.Text)));
                    }

                }
            }

            this.Cursor = Cursors.Default;

        }



        public void SOLONumeros(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtPrecioUni_KeyPress(object sender, KeyPressEventArgs e)
        {
            SOLONumeros(sender, e);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SOLONumeros(sender, e);
        }



        /*
         
        CANTIDAD
             this.Cursor = Cursors.WaitCursor;

    

            if (txtCantidad.Text != "")
            {
                if (txtPrecioUni.Text != "")
                {
                    if (Convert.ToInt32(txtCantidad.Text) > 0 && Convert.ToDecimal(txtPrecioUni.Text) > 0)

                        //    total = String.Format("{0:#,##0.00}", (Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecioUni.Text)));

                        txtTotal.Text = String.Format("{0:#,##0.00}", Convert.ToDouble(txtPrecioUni.Text) * Convert.ToDouble(txtCantidad.Text));

                 
                    
                }
            }

            this.Cursor = Cursors.Default;


           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {

                TextBox textBox = (TextBox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }

            }

         * */




        /*
         PRECIO


           this.Cursor = Cursors.WaitCursor;

 

            if (txtPrecioUni.Text != "")
            {
                if (txtCantidad.Text != "")
                {
                    if (Convert.ToInt32(txtCantidad.Text) > 0 && Convert.ToDecimal(txtPrecioUni.Text) > 0)

                        txtTotal.Text = String.Format("{0:#,##0.00}", (Convert.ToDecimal(txtCantidad.Text) * Convert.ToDecimal(txtPrecioUni.Text)));
        
                }
            }

            this.Cursor = Cursors.Default;


             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {

                TextBox textBox = (TextBox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 3)
                {
                    e.Handled = true;
                }

            }

       
         * */
    }
}
