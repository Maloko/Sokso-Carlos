using System;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;

namespace SGEDICALE.vista
{
    public partial class frmTipoTarjeta : DevComponents.DotNetBar.Office2007Form
    {

        public static BindingSource data = new BindingSource();
        String filtro = String.Empty;


        public frmTipoTarjeta()
        {
            InitializeComponent();
        }

        private void frmTipoTarjeta_Load(object sender, EventArgs e)
        {

            txtfiltro.Focus();
            CargaLista();
            label2.Text = "Descripción:";
            label3.Text = "descripcion";
        }

        private void CargaLista()
        {

            this.Cursor = Cursors.WaitCursor;

            dgvTipoTarjeta.AutoGenerateColumns = false;
            dgvTipoTarjeta.DataSource = data;
            data.DataSource = CTipoTarjeta.ListadoTipoTarjeta();
            data.Filter = String.Empty;
            filtro = String.Empty;
            dgvTipoTarjeta.ClearSelection();

            this.Cursor = Cursors.Default;
        }


        private void frmTipoTarjeta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
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
            if (dgvTipoTarjeta.Rows.Count >= 1)
            {
                if (dgvTipoTarjeta.CurrentRow.Index != -1)
                {

                    codmetodo = Convert.ToInt32(dgvTipoTarjeta.CurrentRow.Cells["codigo"].Value);

                    frmRegistroTipoTarjeta frmmetodo = new frmRegistroTipoTarjeta(codmetodo);
                    frmmetodo.ShowDialog();
                    CargaLista();

                }
            }

            this.Cursor = Cursors.Default;
        }

        private void dgvMetodoPago_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = dgvTipoTarjeta.Columns[e.ColumnIndex].HeaderText + ": ";
            label3.Text = dgvTipoTarjeta.Columns[e.ColumnIndex].DataPropertyName;
            txtfiltro.Focus();
        }

        private void dgvMetodoPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frmRegistroTipoTarjeta"] != null)
            {
                Application.OpenForms["frmRegistroTipoTarjeta"].Activate();
            }
            else
            {
                frmRegistroTipoTarjeta frm_tp = new frmRegistroTipoTarjeta();
                frm_tp.ShowDialog();
                CargaLista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int codmetodo = 0;

            if (dgvTipoTarjeta.Rows.Count > 0)
            {
                if (dgvTipoTarjeta.CurrentCell != null)
                {
                    if (dgvTipoTarjeta.CurrentCell.RowIndex != -1)
                    {
                        codmetodo = Convert.ToInt32(dgvTipoTarjeta.CurrentRow.Cells[0].Value);

                        if (codmetodo > 0)
                        {

                            CTipoTarjeta.Delete(codmetodo);
                            CargaLista();
                        }
                    }

                }
            }

            this.Cursor = Cursors.Default;
        }
    }
}
