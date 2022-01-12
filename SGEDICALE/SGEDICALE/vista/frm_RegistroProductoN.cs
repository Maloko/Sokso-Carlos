using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frm_RegistroProductoN : DevComponents.DotNetBar.Office2007Form
    {
        DataTable unidad = null;
        ProductoUnidad pu = null;
        Producto pro = new Producto();
        int codpro = 0;


        public frm_RegistroProductoN()
        {
            InitializeComponent();
        }

        public frm_RegistroProductoN(int codp)
        {
            InitializeComponent();
            codpro = codp;
        }


        private void frm_RegistroProductoN_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            txtproducto.Text = "";

            cargarunidades();

            ActiveControl = txtproducto;
            txtproducto.Focus();

            if (codpro != 0)
            {
                cargarproducto();
            }

            this.Cursor = Cursors.Default;
        }

        public void cargarproducto()
        {

            try
            {

                Producto p = CProducto.busquedaxcod(codpro);

                if (p != null)
                {

                    txtproducto.Text = p.Descripcion2;
                    dgvpunidades.DataSource = null;


                    unidad = CProductoUnidad.listadoxcodProducto(codpro); ;
                    //dgvpunidades.DataSource=CProductoUnidad.listadoxcodProducto(codpro);
                    dgvpunidades.DataSource = unidad;


                    dgvpunidades.Columns["codUnidadMedida"].Visible = false;
                    dgvpunidades.Columns["codproducto"].Visible = false;
                    dgvpunidades.Columns["codproductounidad"].Visible = false;
                    dgvpunidades.Columns["producto"].Visible = false;
                    dgvpunidades.Columns["estado"].Visible = false;
             


                    /*
                    foreach (DataRow row in unidad.Rows)
                    {
                        foreach (DataColumn column in unidad.Columns)
                        {

                            row["codproductounidad"] = row["codproductounidad"].ToString();
                            row["descripcion"] =row["descripcion"].ToString();
                            row["precioventa"] = row["precioventa"].ToString();
                            row["preciocompra"] = row["preciocompra"].ToString();
                        }

                        //unidad.Rows.Add(row);
                    }*/

                    /*
                    foreach (DataGridViewRow r in unidad.Rows)
                    {
                        DataRow ro = unidad.NewRow();

                        ro["CodUnidad"] = r.Cells["codunidad"].Value.ToString();
                        ro["Unidad"] = r.Cells["descripcion"].Value.ToString();
                        ro["Venta"] = r.Cells["precioventa"].Value.ToString();
                        ro["Compra"] = r.Cells["preciocompra"].Value.ToString();

                        unidad.Rows.Add(ro);
                    }/*/


                    // dgvpunidades.DataSource = unidad;


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
        }


        public void cargarunidades()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                cbUnidad.DataSource = null;
                cbUnidad.DataSource = CUnidadMedida.MuestraUnidades();
                cbUnidad.ValueMember = "codUnidadMedida";
                cbUnidad.DisplayMember = "descripcion";
                //cbUnidad.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }



        private void textBoxX3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_RegistroProductoN_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            try
            {

                //dgvpunidades.AutoGenerateColumns = false;

                if (unidad == null)
                {

                    unidad = new DataTable();

                    unidad.Columns.Add("codUnidadMedida");
                    unidad.Columns.Add("codproducto");
                    unidad.Columns.Add("codproductounidad");
                    unidad.Columns.Add("producto");
                    unidad.Columns.Add("UNIDAD");
                    unidad.Columns.Add("P.VENTA");
                    unidad.Columns.Add("P.COMPRA");
                    unidad.Columns.Add("estado");
                }

                int a = unidad.AsEnumerable().Where(x => x.Field<string>("UNIDAD") == cbUnidad.Text).Count();



                if (a > 0)
                {
                    MessageBox.Show("Unidad ya existe", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                    return;
                }

                DataRow ro = unidad.NewRow();

                ro["codUnidadMedida"] = cbUnidad.SelectedValue.ToString();
                ro["UNIDAD"] = cbUnidad.Text;
                ro["P.VENTA"] = 0;
                ro["P.COMPRA"] = 0;
                ro["codproducto"] = 0;
                ro["codproductounidad"] = 0;
                ro["producto"] = 0;
                ro["estado"]=1 ;

                unidad.Rows.Add(ro);

                dgvpunidades.DataSource = null;
                dgvpunidades.DataSource = unidad;

                dgvpunidades.Columns["codproducto"].Visible = false;
                dgvpunidades.Columns["codproductounidad"].Visible = false;
                dgvpunidades.Columns["codUnidadMedida"].Visible = false;
                dgvpunidades.Columns["producto"].Visible = false;
                dgvpunidades.Columns["estado"].Visible = false;
               



                /*
                dgvpunidades.Rows[0].Cells[1].Selected = false;
                dgvpunidades.CurrentCell = dgvpunidades.CurrentRow.Cells[2];
                dgvpunidades.Rows[0].Cells[2].Selected = true;*/
                ActiveControl = dgvpunidades;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool rpta = false;
            string mensaje = "";

            try
            {
                if (dgvpunidades.Rows.Count > 0)
                {

                    pro.Descripcion2 = txtproducto.Text;
                    pro.Codusuario = Session.CodUsuario;

                    if (pro.Descripcion2 == "")
                    {
                        MessageBox.Show("Ingrese un nombre", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Cursor = Cursors.Default;
                        return;
                    }


                    if (codpro == 0)
                    {

                        Producto p = CProducto.busquedaxnombre(pro.Descripcion2);

                        if (p != null)
                        {
                            MessageBox.Show("Ya existe un producto con ese nombre", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Cursor = Cursors.Default;
                            return;
                        }
                    }



                    if (codpro == 0)
                    {
                        rpta = CProducto.insertar(pro);

                        if (rpta == true)
                        {


                            for (int i = 0; i < dgvpunidades.Rows.Count; i++)
                            {
                                pu = new ProductoUnidad();

                                pu.CodProducto = pro.CodProducto;
                                pu.CodProductoUnidad = Convert.ToInt32(dgvpunidades.Rows[i].Cells["codproductounidad"].Value.ToString());
                                pu.CodUnidad = Convert.ToInt32(dgvpunidades.Rows[i].Cells["codUnidadMedida"].Value.ToString());
                                pu.Preciocompra = Convert.ToDecimal(dgvpunidades.Rows[i].Cells["P.COMPRA"].Value.ToString());
                                pu.Precioventa = Convert.ToDecimal(dgvpunidades.Rows[i].Cells["P.VENTA"].Value.ToString());
                                pu.Codusuario = Session.CodUsuario;

                                rpta = CProductoUnidad.insertar(pu);
                                mensaje = "Producto guardado";
                            }
                        }
                    }
                    else
                    {
                        pro.CodProducto = codpro;
                        rpta = CProducto.actualizar(pro);

                        if (rpta == true)
                        {

                            for (int i = 0; i < dgvpunidades.Rows.Count; i++)
                            {
                                pu = new ProductoUnidad();

                                pu.CodProducto = pro.CodProducto;
                                pu.CodProductoUnidad = Convert.ToInt32(dgvpunidades.Rows[i].Cells["codproductounidad"].Value.ToString());
                                pu.CodUnidad = Convert.ToInt32(dgvpunidades.Rows[i].Cells["codUnidadMedida"].Value.ToString());
                                pu.Preciocompra = Convert.ToDecimal(dgvpunidades.Rows[i].Cells["P.COMPRA"].Value.ToString());
                                pu.Precioventa = Convert.ToDecimal(dgvpunidades.Rows[i].Cells["P.VENTA"].Value.ToString());
                                pu.Codusuario = Session.CodUsuario;

                                if (pu.CodProductoUnidad == 0)
                                {
                                    rpta = CProductoUnidad.insertar(pu);
                                }
                                else
                                {
                                    rpta = CProductoUnidad.actualizar(pu);
                                }
                            
                            }
                            mensaje = "Producto actualizado";
                        }

                    }

                    if (rpta == true)
                    {
                       MessageBox.Show(mensaje, "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       this.Cursor = Cursors.Default;
                    
                    }
                    else
                    {
                        MessageBox.Show("Producto no guardado", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una unidad de medida", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema" + ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;

        }


        public void cargaProductos()
        {

            try
            {

                dgvpunidades.AutoGenerateColumns = false;
                dgvpunidades.DataSource = null;
                dgvpunidades.DataSource = CProductoUnidad.listado();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}
