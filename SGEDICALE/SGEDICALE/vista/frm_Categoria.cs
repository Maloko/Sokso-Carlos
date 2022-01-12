using System;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;


namespace SGEDICALE.vista
{
    public partial class frm_Categoria : DevComponents.DotNetBar.Office2007Form
    {

        public static BindingSource data = new BindingSource();
        String filtro = String.Empty;

        public frm_Categoria()
        {
            InitializeComponent();
        }

        private void frm_Categoria_Load(object sender, EventArgs e)
        {
            txtfiltro.Focus();
            CargaLista();
            label2.Text = "Descripción:";
            label3.Text = "descripcion";
        }

        private void frm_Categoria_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_RegistroCategoria"] != null)
            {
                Application.OpenForms["frm_RegistroCategoria"].Activate();
            }
            else
            {
                frm_RegistroCategoria frm_ct = new frm_RegistroCategoria();
                frm_ct.ShowDialog();
                CargaLista();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        public void editar()
        {

            this.Cursor = Cursors.WaitCursor;

            int codcam;
            if (dgvCategoria.Rows.Count >= 1)
            {
                if (dgvCategoria.CurrentRow.Index != -1)
                {

                    codcam = Convert.ToInt32(dgvCategoria.CurrentRow.Cells["codigo"].Value);

                    frm_RegistroCategoria frmcat = new frm_RegistroCategoria(codcam);
                    frmcat.ShowDialog();
                    CargaLista();

                }
            }

            this.Cursor = Cursors.Default;
        }


        private void CargaLista()
        {

            this.Cursor = Cursors.WaitCursor;

            dgvCategoria.AutoGenerateColumns = false;
            dgvCategoria.DataSource = data;
            data.DataSource = CCategoria.ListadoCategoria();
            data.Filter = String.Empty;
            filtro = String.Empty;
            dgvCategoria.ClearSelection();

            this.Cursor = Cursors.Default;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int codmetodo = 0;

            if (dgvCategoria.Rows.Count > 0)
            {
                if (dgvCategoria.CurrentCell != null)
                {
                    if (dgvCategoria.CurrentCell.RowIndex != -1)
                    {
                        codmetodo = Convert.ToInt32(dgvCategoria.CurrentRow.Cells[0].Value);

                        if (codmetodo > 0)
                        {

                            CCategoria.Delete(codmetodo);
                            CargaLista();
                        }
                    }

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

        private void dgvCategoria_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = dgvCategoria.Columns[e.ColumnIndex].HeaderText + ": ";
            label3.Text = dgvCategoria.Columns[e.ColumnIndex].DataPropertyName;
            txtfiltro.Focus();
        }
    }
}
