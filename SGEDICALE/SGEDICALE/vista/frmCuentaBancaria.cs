using System;
using System.Windows.Forms;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmCuentaBancaria : DevComponents.DotNetBar.Office2007Form
    {

        public static BindingSource data = new BindingSource();
        String filtro = String.Empty;

        public frmCuentaBancaria()
        {
            InitializeComponent();
        }

        private void frmCuentaBancaria_Load(object sender, EventArgs e)
        {
            CargaLista();
            label2.Text = "Descripción:";
            label3.Text = "descripcion";
        }


        private void CargaLista()
        {

            this.Cursor = Cursors.WaitCursor;

            dgvCuenta.AutoGenerateColumns = false;
            dgvCuenta.DataSource = data;
            data.DataSource = CCuenta.listar();
            data.Filter = String.Empty;
            filtro = String.Empty;
            dgvCuenta.ClearSelection();

            this.Cursor = Cursors.Default;
        }



        private void txtfiltro_TextChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

            try
            {
                if (txtfiltro.Text.Length >= 2)
                {
                    data.Filter = String.Format("[{0}] like '*{1}*'", label3.Text.Trim(), txtfiltro.Text.Trim());
                }
                else
                {
                    data.Filter = String.Empty;
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                return;
            }
            this.Cursor = Cursors.Default;
        }


        public void editar()
        {

            this.Cursor = Cursors.WaitCursor;

            int codmetodo;
            if (dgvCuenta.Rows.Count >= 1)
            {
                if (dgvCuenta.CurrentRow.Index != -1)
                {

                    codmetodo = Convert.ToInt32(dgvCuenta.CurrentRow.Cells["codigo"].Value);

                    frmRegistroCuenta frm = new frmRegistroCuenta(codmetodo);
                    frm.ShowDialog();
                    CargaLista();

                }
            }

            this.Cursor = Cursors.Default;
        }


        private void dgvCuenta_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = dgvCuenta.Columns[e.ColumnIndex].HeaderText + ": ";
            label3.Text = dgvCuenta.Columns[e.ColumnIndex].DataPropertyName;
            txtfiltro.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRegistroCuenta"] != null)
            {
                Application.OpenForms["frmRegistroCuenta"].Activate();
            }
            else
            {
                frmRegistroCuenta frm_c = new frmRegistroCuenta();
                frm_c.ShowDialog();
                CargaLista();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int codmetodo = 0;

            if (dgvCuenta.Rows.Count > 0)
            {
                if (dgvCuenta.CurrentCell != null)
                {
                    if (dgvCuenta.CurrentCell.RowIndex != -1)
                    {
                        codmetodo = Convert.ToInt32(dgvCuenta.CurrentRow.Cells[0].Value);

                        if (codmetodo > 0)
                        {

                            CCuenta.Delete(codmetodo);
                            CargaLista();
                        }
                    }

                }
            }

            this.Cursor = Cursors.Default;
        }

        private void dgvCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editar();
        }

        private void frmCuentaBancaria_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
