using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;

namespace SGEDICALE.vista
{
    public partial class frm_RegistroCategoria : DevComponents.DotNetBar.Office2007Form
    {

        int codcategoria = 0;

        public frm_RegistroCategoria()
        {
            InitializeComponent();
        }

        public frm_RegistroCategoria(int codcat)
        {
            InitializeComponent();
            codcategoria = codcat;
        }


        private void frm_RegistroCategoria_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            txtdescripcion.Focus();


            cargarestado();
            if (codcategoria != 0)
            {
                cargarcategoria();
            }

            this.Cursor = Cursors.Default;
        }


        public void cargarcategoria()
        {
            Categoria cat = CCategoria.buscar(codcategoria);

            if (cat != null)
            {

                txtdescripcion.Text = cat.Descripcion;
                cboEstado.SelectedValue = cat.Estado;
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


        private void frm_RegistroCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {

                this.Close();
            }
        }

        private void lblFechaFin_Click(object sender, EventArgs e)
        {

        }

        private void dtpFin_Click(object sender, EventArgs e)
        {

        }

        private void dtpInicio_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaInicio_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool rpta = true;
            string mensaje = "";

            try
            {
                if (txtdescripcion.Text == "" || cboEstado.Text == "")
                {
                    MessageBox.Show("Complete los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                Categoria categoria = new Categoria();

                categoria.Descripcion = txtdescripcion.Text;

                categoria.Estado = Convert.ToInt32(cboEstado.SelectedValue);
                categoria.CodUsuario = Session.CodUsuario;


                if (codcategoria == 0)
                {
                    rpta = CCategoria.Insert(categoria);
                    mensaje = "Guardado correctamente";
                }
                else
                {
                    categoria.CodCategoria = codcategoria;

                    rpta = CCategoria.Update(categoria);
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
    }
}
