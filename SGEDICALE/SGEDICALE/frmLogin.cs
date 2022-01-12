using System;
using System.Linq;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using SGEDICALE.clases;
using SGEDICALE.controlador;
using SGEDICALE.vista;

namespace SGEDICALE
{
    public partial class frmLogin : DevComponents.DotNetBar.Office2007Form
    {

        private Usuario usuario = null;
        private Acceso acceso = null;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {  
            txtUsuario.Focus();
            txtUsuario.Text = "";

            ActiveControl=txtUsuario;
            txtUsuario.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            validarLogin();
        }

        public void validarLogin()
        {

           
            try
            {

                this.Cursor = Cursors.WaitCursor;

                if (txtUsuario.Text.Length > 0 && txtClave.Text.Length > 0)
                {
                    usuario = new Usuario();
                    usuario.Cuenta = txtUsuario.Text;
                    usuario.Clave = txtClave.Text;
                    usuario = CUsuario.validar_ingreso(usuario);

                    if (usuario != null)
                    {
                        if (usuario.Usuarioid > 0)
                        {

                            acceso = new Acceso();
                            acceso.Usuario = usuario;
                            usuario.Lista_acceso = CAcceso.listar_acceso_aformulario_xusuario(acceso);


                            Session.CodUsuario = usuario.Usuarioid;
                            this.Visible = false;

                            frmPrincipal frmPrincipal = new frmPrincipal();
                            if (dar_accesos(usuario, frmPrincipal))
                            {
                                frmPrincipal.usuario = usuario;
                                frmPrincipal.ShowDialog(this);
                            }
                            else
                            {

                                MessageBox.Show("Problemas en los accesos de Usuario...", "Advertencia");

                            }

                            //frmPrincipal.usuario = usuario;
                            //frmPrincipal.ShowDialog(this);

                            this.Close();  
                        }
                        else
                        {
                            MessageBox.Show("Usuario/Clave incorrectos...", "Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario/Clave incorrectos...", "Error");
                    }
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro este error:" + ex.Message.ToString(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }


        public bool dar_accesos(Usuario u, frmPrincipal form)
        {
            SubItemsCollection lista_tag = null;
            bool accesos = true;

            if (u != null)
            {
                if (u.Lista_acceso != null)
                {
                    if (u.Lista_acceso.Count > 0)
                    {
                        lista_tag = form.ribbonControl1.Items;

                        foreach (RibbonTabItem tag in lista_tag)
                        {

                            //var nombretag = (from x in usuario.Lista_acceso where x.Nombre == tag.Name select x.Nombre);

                            if (usuario.Lista_acceso.Where(x => x.Nombre == tag.Name).Select(x => x.Nombre).Any())
                            {
                                var nombretag = (usuario.Lista_acceso.Where(x => x.Nombre == tag.Name).Select(x => x.Nombre).ToList())[0];

                                if (nombretag != null)
                                {
                                    form.ribbonControl1.Items[nombretag].Visible = true;
                                }
                            }
                        }

                    }
                    else
                    {

                        accesos = false;
                    }
                }
                else
                {

                    accesos = false;
                }

            }

            return accesos;

        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                validarLogin();
            }
        }

        private void frmLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void radTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)Keys.Enter)
            {
                validarLogin();
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            validarLogin();
        }
    }
}
