using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmRegistroTipoTarjeta : DevComponents.DotNetBar.Office2007Form
    {


        int codtipotarjeta = 0;

        public frmRegistroTipoTarjeta()
        {
            InitializeComponent();
        }

        public frmRegistroTipoTarjeta(int cod)
        {
            InitializeComponent();
            codtipotarjeta = cod;
        }


        private void frmRegistroTipoTarjeta_Load(object sender, EventArgs e)
        {


            this.Cursor = Cursors.WaitCursor;


            txtdescripcion.Focus();

            cargarestado();
            if (codtipotarjeta != 0)
            {
                cargartipopago();
            }

            this.Cursor = Cursors.Default;

        }


        public void cargartipopago()
        {
            TipoTarjeta tipo = CTipoTarjeta.buscar(codtipotarjeta);

            if (tipo != null)
            {

                txtdescripcion.Text = tipo.Descripcion;
                cboEstado.SelectedValue = tipo.Estado;
            }
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

                TipoTarjeta tipotarjeta = new TipoTarjeta();

                tipotarjeta.Descripcion = txtdescripcion.Text;
                tipotarjeta.Estado = Convert.ToInt32(cboEstado.SelectedValue);
                tipotarjeta.Codusuario = Session.CodUsuario;


                if (codtipotarjeta == 0)
                {
                    rpta = CTipoTarjeta.Insert(tipotarjeta);
                    mensaje = "Guardado correctamente";
                
                }
                else
                {
                    tipotarjeta.Codtipotarjeta = codtipotarjeta;

                    rpta = CTipoTarjeta.Update(tipotarjeta);
                    mensaje = "Actualizado correctamente";
                   
                }

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

        private void frmRegistroTipoTarjeta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
