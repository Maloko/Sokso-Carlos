using System;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.reportes;

namespace SGEDICALE.vista
{
    public partial class frmListadoBanco : DevComponents.DotNetBar.Office2007Form
    {
        public frmListadoBanco()
        {
            InitializeComponent();
        }

        private void FrmBanco_Load(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            cargalista();

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
                frmBanco frm_banco = new frmBanco();
                frm_banco.ShowDialog();
                cargalista();
            }
        }


        private void cargalista()
        {
            this.Cursor = Cursors.WaitCursor;
            dgvBanco.DataSource = CBanco.listar();
            //data.DataSource = AdmPro.CatalogoProductos();
            //data.Filter = String.Empty;
            //filtro = String.Empty;
            dgvBanco.ClearSelection();

            this.Cursor = Cursors.Default;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            cargalista();
        }

        private void dgvBanco_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int codbanco=0;
            if (Application.OpenForms["frmBanco"] != null)
            {
                Application.OpenForms["frmBanco"].Activate();
            }
            else
            {
                if (dgvBanco.Rows.Count > 0)
                {

                    codbanco = Convert.ToInt32(dgvBanco.Rows[e.RowIndex].Cells[0].Value);

                    if (codbanco > 0)
                    {

                        frmBanco frm_banco = new frmBanco(codbanco);
                        frm_banco.ShowDialog();
                        cargalista();
                    }

                }

             
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            int codbanco = 0;
            if (Application.OpenForms["frmBanco"] != null)
            {
                Application.OpenForms["frmBanco"].Activate();
            }
            else
            {
                if (dgvBanco.Rows.Count > 0)
                {
                    if (dgvBanco.CurrentCell != null)
                    {
                        if (dgvBanco.CurrentCell.RowIndex != -1)
                        {
                            codbanco = Convert.ToInt32(dgvBanco.CurrentRow.Cells[0].Value);

                            if (codbanco > 0)
                            {

                                frmBanco frm_banco = new frmBanco(codbanco);
                                frm_banco.ShowDialog();
                                cargalista();
                                
                            }
                        }

                    }
                }


            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int codbanco = 0;
            if (Application.OpenForms["frmBanco"] != null)
            {
                Application.OpenForms["frmBanco"].Activate();
            }
            else
            {
                if (dgvBanco.Rows.Count > 0)
                {
                    if (dgvBanco.CurrentCell != null)
                    {
                        if (dgvBanco.CurrentCell.RowIndex != -1)
                        {
                            codbanco = Convert.ToInt32(dgvBanco.CurrentRow.Cells[0].Value);

                            if (codbanco > 0)
                            {

                                CBanco.eliminar(codbanco);
                                cargalista();
                            }
                        }

                    }
                }


            }
        }

        private void frmListadoBanco_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("Bancos");
            // Columnas
            foreach (DataGridViewColumn column in dgvBanco.Columns)
            {
                DataColumn dc = new DataColumn(column.Name.ToString());
                dt.Columns.Add(dc);
            }
            // Datos
            for (int i = 0; i < dgvBanco.Rows.Count; i++)
            {
                DataGridViewRow row = dgvBanco.Rows[i];
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dgvBanco.Columns.Count; j++)
                {
                    dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                }
                dt.Rows.Add(dr);
            }

            ds.Tables.Add(dt);
            ds.WriteXml("C:\\XML\\BancoRPT.xml", XmlWriteMode.WriteSchema);

            CRBanco rpt = new CRBanco();
            frmBancoRP frm = new frmBancoRP();
            rpt.SetDataSource(ds);
            frm.crReporteBanco.ReportSource = rpt;
            frm.Show();

       
           

            this.Cursor = Cursors.Default;
        }
    }
}
