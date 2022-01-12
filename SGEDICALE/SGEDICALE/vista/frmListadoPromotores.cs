using System;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;

namespace SGEDICALE.vista
{
    public partial class frmListadoPromotores : DevComponents.DotNetBar.Office2007Form
    {
        public Promotor promotor = null;
        public string botonborrar = "";


        public int filtro = -1;//1 equivale mostrar promotros sin codigo sap

        public frmListadoPromotores()
        {
            InitializeComponent();
        }

        private void frmListadoPromotores_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            btnBorrar.Visible = true;

            if (botonborrar == "")
            {
                btnBorrar.Visible = false;
                btnEliminar.Visible = false;

            }

            cargapromotores();

            this.Cursor = Cursors.Default;
        }


        public void cargapromotores()
        {

            this.Cursor = Cursors.WaitCursor;
            dgvPromotores.DataSource = null;
            dgvPromotores.AutoGenerateColumns = false;

            if (filtro == -1)
            {
                dgvPromotores.DataSource = CPromotor.listado();
                dgvPromotores.Refresh();
            }
            else
            {
                dgvPromotores.DataSource = CPromotor.listadoFiltro(filtro);
                dgvPromotores.Refresh();
            }



            lbregistro.Text = dgvPromotores.Rows.Count.ToString() + " registros.";

            this.Cursor = Cursors.Default;
        }

        private void frmListadoPromotores_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtnombre_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            string nombre = "";

            nombre = txtnombre.Text;

            if (nombre != "")
            {

                if (filtro == -1)
                {

                    dgvPromotores.DataSource = CPromotor.busqueda(nombre);
                }
                else
                {
                    dgvPromotores.DataSource = CPromotor.busquedafiltro(nombre, filtro);
                }

                lbregistro.Text = dgvPromotores.Rows.Count.ToString() + " registros.";
                dgvPromotores.Refresh();
            }
            else
            {
                cargapromotores();
            }

            this.Cursor = Cursors.Default;
        }

        private void dgvPromotores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {

                if (dgvPromotores.Rows.Count > 0)
                {
                    if (dgvPromotores.CurrentCell != null)
                    {
                        if (dgvPromotores.CurrentCell.RowIndex != -1)
                        {
                            promotor = new Promotor();
                            promotor.DocumentoIdentidad = new TipoDocumentoIdentidad();
                            promotor.CodPromotor = Convert.ToInt32(dgvPromotores.Rows[e.RowIndex].Cells["codpromotor"].Value);
                            promotor.Nombrecompleto = dgvPromotores.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                            promotor.Direccion = dgvPromotores.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
                            promotor.Dni = dgvPromotores.Rows[e.RowIndex].Cells["dni"].Value.ToString();

                            promotor.DocumentoIdentidad.Idtipodocumentoidentidad = Convert.ToInt32(dgvPromotores.Rows[e.RowIndex].Cells["coddocumentoidentidad"].Value.ToString());
                            promotor.DocumentoIdentidad.Descripcion = dgvPromotores.Rows[e.RowIndex].Cells["tipodocumento"].Value.ToString();
                            promotor.DocumentoIdentidad.Codsunat = dgvPromotores.Rows[e.RowIndex].Cells["codsunat"].Value.ToString();

                            DialogResult = DialogResult.OK;
                            this.Cursor = Cursors.Default;


                        }
                    }
                }

                this.Close();

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }

        private void dgvPromotores_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {


            this.Cursor = Cursors.WaitCursor;
            try
            {

                if (dgvPromotores.Rows.Count > 0)
                {

                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar todos los promotores ?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool rpta = CPromotor.borrarTodo();
                        cargapromotores();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            try
            {

                int codpromotor = 0;
                if (dgvPromotores.Rows.Count > 0)
                {

                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar el promotor ?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {

                        codpromotor = Convert.ToInt32(dgvPromotores.CurrentRow.Cells[0].Value);
                        bool rpta = CPromotor.borrar(codpromotor);

                        if (rpta == true)
                        {
                            MessageBox.Show("Promotor eliminado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se puede eliminar porque tiene pedidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        cargapromotores();
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
    }
}
