using System;
using System.Windows.Forms;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmCampaña : DevComponents.DotNetBar.Office2007Form
    {

        public static BindingSource data = new BindingSource();
        String filtro = String.Empty;

        public frmCampaña()
        {
            InitializeComponent();
        }

        private void frmCampaña_Load(object sender, EventArgs e)
        {
            txtfiltro.Focus();
            CargaLista();
            label2.Text = "Descripción:";
            label3.Text = "descripcion";
        }

        private void frmCampaña_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Escape)
            {
                this.Close();
            }
        }


        private void CargaLista()
        {

            this.Cursor = Cursors.WaitCursor;

            dgvCampaña.AutoGenerateColumns = false;
            dgvCampaña.DataSource = data;
            data.DataSource = CCampaña.ListadoCampaña();
            data.Filter = String.Empty;
            filtro = String.Empty;
            dgvCampaña.ClearSelection();

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
          if (Application.OpenForms["frmRegistroCampaña"] != null)
            {
                Application.OpenForms["frmRegistroCampaña"].Activate();
            }
            else
            {
                frmRegistroCampaña frm_cam = new frmRegistroCampaña();
                frm_cam.ShowDialog();
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
            if (dgvCampaña.Rows.Count >= 1)
            {
                if (dgvCampaña.CurrentRow.Index != -1)
                {

                    codcam = Convert.ToInt32(dgvCampaña.CurrentRow.Cells["codigo"].Value);

                    frmRegistroCampaña frmcam = new frmRegistroCampaña(codcam);
                    frmcam.ShowDialog();
                    CargaLista();

                }
            }

            this.Cursor = Cursors.Default;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int codmetodo = 0;

            if (dgvCampaña.Rows.Count > 0)
            {
                if (dgvCampaña.CurrentCell != null)
                {
                    if (dgvCampaña.CurrentCell.RowIndex != -1)
                    {
                        codmetodo = Convert.ToInt32(dgvCampaña.CurrentRow.Cells[0].Value);

                        if (codmetodo > 0)
                        {

                            CCampaña.Delete(codmetodo);
                            CargaLista();
                        }
                    }

                }
            }

            this.Cursor = Cursors.Default;
        }

        private void dgvCampaña_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = dgvCampaña.Columns[e.ColumnIndex].HeaderText + ": ";
            label3.Text = dgvCampaña.Columns[e.ColumnIndex].DataPropertyName;
            txtfiltro.Focus();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

        }
    }
}
