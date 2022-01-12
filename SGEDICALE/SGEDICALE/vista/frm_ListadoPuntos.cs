using SGEDICALE.clases;
using SGEDICALE.controlador;
using SGEDICALE.reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGEDICALE.vista
{
    public partial class frm_ListadoPuntos : DevComponents.DotNetBar.Office2007Form
    {
        public frm_ListadoPuntos()
        {
            InitializeComponent();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void lbregistro_Click(object sender, EventArgs e)
        {

        }

        private void frm_ListadoPuntos_Load(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            cargapuntos();

            this.Cursor = Cursors.Default;
        }

        public void cargapuntos()
        {

            this.Cursor = Cursors.WaitCursor;

            dgvPuntos.DataSource = CPunto.listado();
            dgvPuntos.Refresh();

            lbregistro.Text = dgvPuntos.Rows.Count.ToString() + " registros.";

            this.Cursor = Cursors.Default;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {

                int codpunto = 0;
                if (dgvPuntos.Rows.Count > 0)
                {

                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar el puntaje ?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {

                        codpunto = Convert.ToInt32(dgvPuntos.CurrentRow.Cells["codpunto"].Value.ToString());
                        bool rpta = CPunto.borrar(codpunto);
                        cargapuntos();
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


        public void dText_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (!Char.IsDigit(e.KeyChar) && !Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.Length == 0)
            {
                e.Handled = true;
            }

        }


        private void frm_ListadoPuntos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvPuntos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

            dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
        }

        private void dgvPuntos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            int codpunto = 0;

            try
            {

                if (dgvPuntos.RowCount > 0)
                {

                    if (dgvPuntos.CurrentRow.Cells["puntaje"].Value != null)
                    {

                        if (dgvPuntos.CurrentRow.Cells["puntaje"].Value.ToString() == "")
                        {
                            cargapuntos();
                            this.Cursor = Cursors.Default;
                            return;
                        }
                        else
                        {
                            if (Convert.ToDecimal(dgvPuntos.CurrentRow.Cells["puntaje"].Value) <= 0)
                            {
                                cargapuntos();
                                this.Cursor = Cursors.Default;
                                return;
                            }
                        }
                    }



                    codpunto = Convert.ToInt32(dgvPuntos.CurrentRow.Cells["codpunto"].Value.ToString());

                    Puntos puntos = new Puntos();
                    puntos.Codpunto = codpunto;
                    puntos.Puntaje = Convert.ToDecimal(dgvPuntos.CurrentRow.Cells["puntaje"].Value.ToString());


                    bool rpta = CPunto.update(puntos);

                    if (rpta == true)
                    {
                        MessageBox.Show("Registro Actualizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                dgvPuntos.DataSource = CPunto.busqueda(nombre);
                lbregistro.Text = dgvPuntos.Rows.Count.ToString() + " registros.";
                dgvPuntos.Refresh();
            }
            else
            {
                cargapuntos();
            }

            this.Cursor = Cursors.Default;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvPuntos.Rows.Count == 0)
                {
                    MessageBox.Show("Lista vacía", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }


                DataSet ds = new DataSet();
                DataTable dt = new DataTable("ListaPuntos");
                dt.Columns.Add("codpunto", typeof(int));
                dt.Columns.Add("nombre", typeof(string));
                dt.Columns.Add("dni", typeof(string));
                dt.Columns.Add("puntaje", typeof(decimal));
                dt.Columns.Add("nombresapellidos", typeof(string));
                dt.Columns.Add("fecharegistro", typeof(DateTime));
                

                foreach (DataGridViewRow dgv in dgvPuntos.Rows)
                {
                    dt.Rows.Add(dgv.Cells["codpunto"].Value,
                    dgv.Cells["nombre"].Value,
                    dgv.Cells["dni"].Value,
                    dgv.Cells["puntaje"].Value,
                    dgv.Cells["nombresapellidos"].Value,
                    Convert.ToDateTime(dgv.Cells["fecharegistro"].Value));
               
                }
                ds.Tables.Add(dt);
                ds.WriteXml("C:\\XML\\ListaPuntosDicaleRPT.xml", XmlWriteMode.WriteSchema);

                CRListaPuntos rpt = new CRListaPuntos();
                frmRptListaPuntos frm = new frmRptListaPuntos();
                rpt.SetDataSource(ds);
                frm.crvListaPuntos.ReportSource = rpt;
                frm.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;

            }

            this.Cursor = Cursors.Default;
        }
    }
}
