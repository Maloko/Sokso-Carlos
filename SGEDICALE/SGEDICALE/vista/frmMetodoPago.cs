using System;
using System.Windows.Forms;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmMetodoPago : DevComponents.DotNetBar.Office2007Form
    {

        public static BindingSource data = new BindingSource();
        String filtro = String.Empty;

        public frmMetodoPago()
        {
            InitializeComponent();
        }

        private void frmMetodoPago_Load(object sender, EventArgs e)
        {
            CargaLista();
            label2.Text = "Descripción:";
            label3.Text = "descripcion";
        }

        private void dgvTipoCambio_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = dgvMetodoPago.Columns[e.ColumnIndex].HeaderText+": ";
            label3.Text = dgvMetodoPago.Columns[e.ColumnIndex].DataPropertyName;
            txtfiltro.Focus();
        }


        private void CargaLista()
        {

            this.Cursor = Cursors.WaitCursor;

            dgvMetodoPago.AutoGenerateColumns = false;
            dgvMetodoPago.DataSource = data;
            data.DataSource = CMetodoPago.ListaMetodoPagos();
            data.Filter = String.Empty;
            filtro = String.Empty;
            dgvMetodoPago.ClearSelection();

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

        private void dgvMetodoPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           
            editar();
      
        }


        public void editar()
        {

            this.Cursor = Cursors.WaitCursor;

            int codmetodo;
            if (dgvMetodoPago.Rows.Count >= 1)
            {
                if (dgvMetodoPago.CurrentRow.Index != -1)
                {

                    codmetodo = Convert.ToInt32(dgvMetodoPago.CurrentRow.Cells["codigo"].Value);

                    frmRegistroMetodoPago frmmetodo = new frmRegistroMetodoPago(codmetodo);
                    frmmetodo.ShowDialog();
                    CargaLista();

                }
            }

            this.Cursor = Cursors.Default;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBanco"] != null)
            {
                Application.OpenForms["frmBanco"].Activate();
            }
            else
            {
                frmRegistroMetodoPago frm_mp = new frmRegistroMetodoPago();
                frm_mp.ShowDialog();
                CargaLista();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int codmetodo = 0;

            if (dgvMetodoPago.Rows.Count > 0)
            {
                if (dgvMetodoPago.CurrentCell != null)
                {
                    if (dgvMetodoPago.CurrentCell.RowIndex != -1)
                    {
                        codmetodo = Convert.ToInt32(dgvMetodoPago.CurrentRow.Cells[0].Value);

                        if (codmetodo > 0)
                        {

                            CMetodoPago.delete(codmetodo);
                            CargaLista();
                        }
                    }

                }
            }

            this.Cursor = Cursors.Default;
        }

        private void frmMetodoPago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
