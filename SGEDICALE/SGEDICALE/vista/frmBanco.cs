using System;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using System.Collections.Generic;

namespace SGEDICALE.vista
{
    public partial class frmBanco : DevComponents.DotNetBar.Office2007Form
    {

        int codbanco = 0;
        public frmBanco()
        {
            InitializeComponent();
        }

        public frmBanco(int cod)
        {
            InitializeComponent();
            codbanco = cod;
        }

        private void frmBanco_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            cargarestado();
            cargabanco();

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

        public void cargabanco()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {

                Banco banco = new Banco();
                banco=  CBanco.buscar(codbanco);

                if (banco == null)
                {
                    MessageBox.Show("Banco no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                txtsigla.Text = banco.Sigla.ToString();
                txtdescripcion.Text = banco.Descripcion.ToString();

                if (banco.Estado)
                {
                    cboEstado.SelectedValue = 1;
                }
                else
                {
                    cboEstado.SelectedValue = 0;
                }

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
            bool rpta = true;
            string mensaje = "";

            try
            {
                Banco ban = new Banco();

                ban.Sigla = txtsigla.Text;
                ban.Descripcion = txtdescripcion.Text;
                ban.Codusuario = Session.CodUsuario;
                ban.Estado = Convert.ToBoolean(cboEstado.SelectedValue);
                
                if (txtdescripcion.Text == "" || txtsigla.Text =="")
                {
                   this.Cursor = Cursors.Default;
                   return;
                }

                if (codbanco == 0)
                {
                    rpta = CBanco.insertar(ban);
                    mensaje = "Banco guardado correctamente";
                }
                else
                {
                    ban.Codbanco = codbanco;
                    rpta = CBanco.update(ban);
                    mensaje = "Banco actualizado correctamente";
                }

                if (rpta == true)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }


        private void frmBanco_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool rpta = true;
            string mensaje = "";

            try
            {
                Banco ban = new Banco();

                ban.Sigla = txtsigla.Text;
                ban.Descripcion = txtdescripcion.Text;
                ban.Codusuario = Session.CodUsuario;
                ban.Estado = Convert.ToBoolean(cboEstado.SelectedValue);

                if (txtdescripcion.Text == "" || txtsigla.Text == "")
                {
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (codbanco == 0)
                {
                    rpta = CBanco.insertar(ban);
                    mensaje = "Banco guardado correctamente";
                }
                else
                {
                    ban.Codbanco = codbanco;
                    rpta = CBanco.update(ban);
                    mensaje = "Banco actualizado correctamente";
                }

                if (rpta == true)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
