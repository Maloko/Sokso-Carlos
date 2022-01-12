using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;


namespace SGEDICALE.vista
{
    public partial class frmRegistroEmpresa : DevComponents.DotNetBar.Office2007Form
    {
        public frmRegistroEmpresa()
        {
            InitializeComponent();
        }

        private void frmRegistroEmpresa_Load(object sender, EventArgs e)
        {
            cargarempresa();
        }

        public void cargarempresa()
        {
            Empresa emp = CEmpresa.CargaEmpresa();

            if (emp != null)
            {

                txtrazon.Text = emp.RazonSocial;
                txtruc.Text = emp.Ruc;
                txtdireccion.Text = emp.Direccion;
                txtcelular.Text = emp.Telefono;
                txtclavecertificado.Text = emp.Contrasena;
                txtusuariosol.Text = emp.UsuarioSunat;
                txtclavesol.Text = emp.ClaveSunat;
                txturlsunat.Text = emp.UrlSunat;
                txtemail.Text = emp.Email;
                txtClaveEmail.Text = emp.Claveemail;


            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool rpta = true;
            string mensaje = "";

            try
            {

                Empresa emp = new Empresa();
                emp.CodEmpresa = Session.CodEmpresa;
                emp.RazonSocial = txtrazon.Text;
                emp.Ruc = txtruc.Text;
                emp.Direccion = txtdireccion.Text;
                emp.Telefono = txtcelular.Text;
                emp.Contrasena = txtclavecertificado.Text;
                emp.UsuarioSunat = txtusuariosol.Text;
                emp.ClaveSunat = txtclavesol.Text;
                emp.UrlSunat = txturlsunat.Text;
                emp.Email = txtemail.Text;


                rpta = CEmpresa.update(emp);
                mensaje = "Actualizado correctamente";

                if (rpta == true)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }
    }
}
