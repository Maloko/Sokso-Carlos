using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmRegistroMetodoPago : DevComponents.DotNetBar.Office2007Form
    {

        int codmetodopago = 0;

        public frmRegistroMetodoPago()
        {
            InitializeComponent();
        }

        public frmRegistroMetodoPago(int cod)
        {
            InitializeComponent();
            codmetodopago = cod;
        }



        public void cargaremtodopago()
        {
            MetodoPago metodpago = CMetodoPago.BuscaMetodoPago(codmetodopago);

            if (metodpago != null)
            {
                
                txtdescripcion.Text = metodpago.Descripcion;
                cboEstado.SelectedValue = metodpago.Estado;
            }
        }


        private void frmRegistroMetodoPago_Load(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            cargarestado();
            if (codmetodopago != 0)
            {
                cargaremtodopago();
            }

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

        private void frmRegistroMetodoPago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool rpta = true;
            string mensaje = "";

            try
            {

                if (txtdescripcion.Text == "" && cboEstado.Text == "")
                {
                    MessageBox.Show("Complete los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                MetodoPago metodopago = new MetodoPago();

                metodopago.Descripcion =txtdescripcion.Text;
                metodopago.Estado = Convert.ToInt32(cboEstado.SelectedValue);
                metodopago.Codusuario = Session.CodUsuario;


                if (codmetodopago == 0)
                {
                    rpta = CMetodoPago.insert(metodopago);
                    mensaje = "Guardado correctamente";
                    this.Cursor = Cursors.Default;
                    this.Close();
                }
                else
                {
                    metodopago.Codmetodopago = codmetodopago;
                    
                    rpta = CMetodoPago.update(metodopago);
                    mensaje = "Actualizado correctamente";
                    this.Cursor = Cursors.Default;
                    this.Close();
                }

                if (rpta == true)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                }

            }
            catch (Exception ex)
            {

                this.Cursor = Cursors.Default;
                throw ex;
            }

            this.Cursor = Cursors.Default;
        }
    }
}
