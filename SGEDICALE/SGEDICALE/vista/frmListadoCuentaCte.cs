using System;
using System.Windows.Forms;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmListadoCuentaCte : DevComponents.DotNetBar.Office2007Form
    {
        public frmListadoCuentaCte()
        {
            InitializeComponent();
        }

        private void frmCuentaCte_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            cargalista();

            this.Cursor = Cursors.Default;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCuenta"] != null)
            {
                Application.OpenForms["frmCuenta"].Activate();
            }
            else
            {
                frmCuenta frm_cuenta = new frmCuenta();
                frm_cuenta.ShowDialog();
                cargalista();
            }
        }

        private void cargalista()
        {
            this.Cursor = Cursors.WaitCursor;

            dgvCuenta.DataSource = CCuenta.listar();
            //data.DataSource = AdmPro.CatalogoProductos();
            //data.Filter = String.Empty;
            //filtro = String.Empty;
            dgvCuenta.ClearSelection();

            this.Cursor = Cursors.Default;
        }

        private void frmListadoCuentaCte_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            int codcuenta = 0;
            if (Application.OpenForms["frmCuenta"] != null)
            {
                Application.OpenForms["frmCuenta"].Activate();
            }
            else
            {
                if (dgvCuenta.Rows.Count > 0)
                {
                    if (dgvCuenta.CurrentCell != null)
                    {
                        if (dgvCuenta.CurrentCell.RowIndex != -1)
                        {
                            codcuenta = Convert.ToInt32(dgvCuenta.CurrentRow.Cells[0].Value);

                            if (codcuenta > 0)
                            {

                                frmCuenta frm_cuenta = new frmCuenta(codcuenta);
                                frm_cuenta.ShowDialog();
                                cargalista();

                            }
                        }

                    }
                }


            }
        }
    }
}
