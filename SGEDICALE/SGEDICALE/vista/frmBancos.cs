using System;
using System.Windows.Forms;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmBancos : DevComponents.DotNetBar.Office2007Form
    {

        public static BindingSource data = new BindingSource();
        String filtro = String.Empty;


        public frmBancos()
        {
            InitializeComponent();
        }

        private void frmBancos_Load(object sender, EventArgs e)
        {
            CargaLista();
            label2.Text = "Descripción:";
            label3.Text = "descripcion";
        }

        private void dgvMetodoPago_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            label2.Text = dgvBancos.Columns[e.ColumnIndex].HeaderText + ": ";
            label3.Text = dgvBancos.Columns[e.ColumnIndex].DataPropertyName;
            txtfiltro.Focus();
        }


        private void CargaLista()
        {

            this.Cursor = Cursors.WaitCursor;

            dgvBancos.AutoGenerateColumns = false;
            dgvBancos.DataSource = data;
            data.DataSource = CBanco.listar();
            data.Filter = String.Empty;
            filtro = String.Empty;
            dgvBancos.ClearSelection();

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
                throw ex;
              
              
            }
            this.Cursor = Cursors.Default;
        }


        public void editar()
        {

            this.Cursor = Cursors.WaitCursor;

            int codmetodo;
            if (dgvBancos.Rows.Count >= 1)
            {
                if (dgvBancos.CurrentRow.Index != -1)
                {

                    codmetodo = Convert.ToInt32(dgvBancos.CurrentRow.Cells["codigo"].Value);

                    frmRegistroBanco frm = new frmRegistroBanco(codmetodo);
                    frm.ShowDialog();
                    CargaLista();

                }
            }

            this.Cursor = Cursors.Default;
        }

        private void dgvBancos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            editar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            editar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRegistroBanco"] != null)
            {
                Application.OpenForms["frmRegistroBanco"].Activate();
            }
            else
            {
                frmRegistroBanco frm_rb = new frmRegistroBanco();
                frm_rb.ShowDialog();
                CargaLista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int codmetodo = 0;

            if (dgvBancos.Rows.Count > 0)
            {
                if (dgvBancos.CurrentCell != null)
                {
                    if (dgvBancos.CurrentCell.RowIndex != -1)
                    {
                        codmetodo = Convert.ToInt32(dgvBancos.CurrentRow.Cells[0].Value);

                        if (codmetodo > 0)
                        {

                            CBanco.eliminar(codmetodo);
                            CargaLista();
                        }
                    }

                }
            }

            this.Cursor = Cursors.Default;
        }

        private void frmBancos_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
