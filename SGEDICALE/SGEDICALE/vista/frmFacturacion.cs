using System;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;

namespace SGEDICALE.vista
{
    public partial class frmF : DevComponents.DotNetBar.Office2007Form
    {

        Pedido pedi = null;
        Promotor pro = null;

        public int respuesta=0;

        public frmF()
        {
            InitializeComponent();
        }

        private void frmF_Load(object sender, EventArgs e)
        {

        }
        private void txtCod_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    if (Application.OpenForms["frmListadoPromotores"] != null)
                    {
                        Application.OpenForms["frmListadoPromotores"].Activate();
                    }
                    else
                    {
                        pro = null;
                        frmListadoPromotores form = new frmListadoPromotores();
                        form.filtro = 0;

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            pro = form.promotor;

                            if (pro != null)
                            {
                                txtCod.Text = pro.CodPromotor.ToString();
                                txtpromotor.Text = pro.Nombrecompleto;


                                txtcodpedido.Text = "";
                                txtnumero.Text = "";
                                pedi = null;
                                dgvdetalle.DataSource = null;
                                txtcodpedido.Focus();

                            }
                            else
                            {
                                txtCod.Focus();
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

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //enteros(e);
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

        private void txtcodpedido_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txtCod.Text != "")
                {
                    if (e.KeyCode == Keys.F1)
                    {
                        if (Application.OpenForms["frmF1Pedidos"] != null)
                        {
                            Application.OpenForms["frmF1Pedidos"].Activate();
                        }
                        else
                        {
                           
                            frmF1Pedidos formf1 = new frmF1Pedidos();

                            formf1.codpromotor = Convert.ToInt32(txtCod.Text);

                            if (formf1.ShowDialog() == DialogResult.OK)
                            {
                                pedi = formf1.pedi;

                                if (pedi != null)
                                {
                                    txtcodpedido.Text = pedi.CodPedido.ToString();
                                    txtnumero.Text = pedi.Numeropedido.ToString();
                                    pedi.CodPromotor = Convert.ToInt32(txtCod.Text);

                                    cargarpedido();

                                }
                                else
                                {
                                    this.Cursor = Cursors.Default;
                                    return;
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese Promotor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }


        public void cargarpedido()
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {
                dgvdetalle.DataSource = null;
                dgvdetalle.AutoGenerateColumns = false;
                if (txtcodpedido.Text != "")
                {
                    dgvdetalle.DataSource = CPedido.listarPedidosxCodigo(Convert.ToInt32(txtcodpedido.Text));
                    lbregistro.Text = dgvdetalle.Rows.Count + "registros";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }


        /*
        public void  cargardetallepedido()
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (txtcodpedido.Text != "")
                {
                    dgvdetalle.DataSource = CDetallePedido.listarDetalle(Convert.ToInt32(txtcodpedido.Text));
                    lbregistro.Text = dgvdetalle.Rows.Count + "registros";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }*/

        private void frmF_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            /*
            if (Application.OpenForms["frmFacturar"] != null)
            {
                Application.OpenForms["frmFacturar"].Activate();
            }
            else
            {*/

                if (pedi != null)
                {
                    frmFacturar frm_fac = new frmFacturar();
                    frm_fac.pedido1 = pedi;
                    frm_fac.promo2 = pro;
                    frm_fac.Show();


                }
                else
                {
                    MessageBox.Show("Ingrese pedido a facturar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
           //}
        }

        public void limpiar()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (respuesta == 1)
                {
                    dgvdetalle.DataSource = null;
                    dgvdetalle.AutoGenerateColumns = false;
                    pedi = null;
                    txtcodpedido.Text = "";
                    txtnumero.Text = "";
                    txtCod.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;

        }

        private void lbregistro_Click(object sender, EventArgs e)
        {

        }
    }
}
