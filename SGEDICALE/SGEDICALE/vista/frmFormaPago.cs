using System;
using System.Windows.Forms;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmFormaPago : DevComponents.DotNetBar.Office2007Form
    {

        public static BindingSource data = new BindingSource();
        String filtro = String.Empty;



        public frmFormaPago()
        {
            InitializeComponent();
        }

        private void frmFormaPagocs_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmFormaPagocs_Load(object sender, EventArgs e)
        {
            txtfiltro.Focus();
            CargaLista();
            label2.Text = "Descripción:";
            label3.Text = "descripcion";
        }


        private void CargaLista()
        {

            this.Cursor = Cursors.WaitCursor;

            dgvFormaPago.AutoGenerateColumns = false;
            dgvFormaPago.DataSource = data;
            data.DataSource = CTipoTarjeta.ListadoTipoTarjeta();
            data.Filter = String.Empty;
            filtro = String.Empty;
            dgvFormaPago.ClearSelection();

            this.Cursor = Cursors.Default;
        }


        public void editar()
        {

            this.Cursor = Cursors.WaitCursor;

            int codmetodo;
            if (dgvFormaPago.Rows.Count >= 1)
            {
                if (dgvFormaPago.CurrentRow.Index != -1)
                {

                    codmetodo = Convert.ToInt32(dgvFormaPago.CurrentRow.Cells["codigo"].Value);

                    frmRegistroTipoTarjeta frmmetodo = new frmRegistroTipoTarjeta(codmetodo);
                    frmmetodo.ShowDialog();
                    CargaLista();

                }
            }

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void dgvTipoTarjeta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int codmetodo = 0;

            if (dgvFormaPago.Rows.Count > 0)
            {
                if (dgvFormaPago.CurrentCell != null)
                {
                    if (dgvFormaPago.CurrentCell.RowIndex != -1)
                    {
                        codmetodo = Convert.ToInt32(dgvFormaPago.CurrentRow.Cells[0].Value);

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

        private void dgvTipoTarjeta_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = dgvFormaPago.Columns[e.ColumnIndex].HeaderText + ": ";
            label3.Text = dgvFormaPago.Columns[e.ColumnIndex].DataPropertyName;
            txtfiltro.Focus();
        }
    }
}
