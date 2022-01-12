using SGEDICALE.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGEDICALE.vista
{
    public partial class ValidarPendientesEnvio : DevComponents.DotNetBar.Office2007Form
    {
        public ValidarPendientesEnvio()
        {
            InitializeComponent();
        }

        private void ValidarPendientesEnvio_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            cargarcombo();

            this.Cursor = Cursors.Default;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool rpta = true;
            string mensaje = "";

            try
            {
                if (cboEstado.SelectedValue != null)
                {

                    string valor = cboEstado.SelectedValue.ToString();
                    rpta = CRepositorio.update(valor);
                    mensaje = "Actualizado correctamente";


                    if (rpta == true)
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        public void cargarcombo()
        {

            List<dynamic> listadinamica = new List<dynamic>()
            {

                new {codigo=1,descripcion = "SI" },
                new {codigo=0,descripcion="NO" }
            };

            cboEstado.DataSource = listadinamica;
            cboEstado.ValueMember = "codigo";
            cboEstado.DisplayMember = "descripcion";

        }

    }
}
