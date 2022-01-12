using System;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frm_ComprobantesPorCliente : DevComponents.DotNetBar.Office2007Form
    {

        public Promotor cliente { get; set; }
        private DataTable table_comprobante = null;
        public Comprobantee comprobantee = null;

        public frm_ComprobantesPorCliente()
        {
            InitializeComponent();
        }

        private void frm_ComprobantesPorCliente_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                dg_comprobante.AutoGenerateColumns = false;
                listar_comprobantes_xestado_xcliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }


        public void listar_comprobantes_xestado_xcliente()
        {
            try
            {
                dg_comprobante.DataSource = null;

                table_comprobante = CComprobante.listar_comprobantes_xestado_xcliente(cliente);

                if (table_comprobante != null)
                {
                    if (table_comprobante.Rows.Count > 0)
                    {
                        dg_comprobante.DataSource = table_comprobante;
                        dg_comprobante.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }



        private void dg_nota_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (dg_comprobante.Rows.Count > 0)
                {
                    comprobantee = new Comprobantee()
                    {
                        CodComprobante = int.Parse(dg_comprobante.Rows[e.RowIndex].Cells[0].Value.ToString()),
                        Scomprobante = dg_comprobante.Rows[e.RowIndex].Cells[2].Value.ToString(),
                        Total = decimal.Parse(dg_comprobante.Rows[e.RowIndex].Cells[3].Value.ToString())
                    };

                    if (comprobantee != null)
                    {
                        this.DialogResult = DialogResult.OK;
                    }

                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;

            }

            this.Cursor = Cursors.Default;
        }
    }
}
