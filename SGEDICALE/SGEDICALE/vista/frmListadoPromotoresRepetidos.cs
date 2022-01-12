using System;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;

namespace SGEDICALE.vista
{
    public partial class frmListadoPromotoresRepetidos : DevComponents.DotNetBar.Office2007Form
    {
        public frmListadoPromotoresRepetidos()
        {
            InitializeComponent();
        }

        private void frmListadoPromotoresRepetidos_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            cargapromotores();

            this.Cursor = Cursors.Default;
        }

        public void cargapromotores()
        {

            this.Cursor = Cursors.WaitCursor;

            dgvPromotores.DataSource = CPromotor.listadorepetidos();
            dgvPromotores.Refresh();

            lbregistro.Text = dgvPromotores.Rows.Count.ToString() + " registros.";

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

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string nombre = "";

            nombre = txtnombre.Text;

            if (nombre != "")
            {
                dgvPromotores.DataSource = CPromotor.busquedarepetidos(nombre);
                lbregistro.Text = dgvPromotores.Rows.Count.ToString() + " registros.";
                dgvPromotores.Refresh();
            }
            else
            {
                cargapromotores();
            }

            this.Cursor = Cursors.Default;
        }
    }
}
