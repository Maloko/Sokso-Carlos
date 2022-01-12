using System;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;


namespace SGEDICALE.vista
{
    public partial class frmNotaCreditoPendiente : DevComponents.DotNetBar.Office2007Form
    {

        public Promotor cliente { get; set; }
        private DataTable table_nota_credito = null;
        public  Comprobantee notacredito = null;

        public frmNotaCreditoPendiente()
        {
            InitializeComponent();
        }

        private void frmNotaCreditoPendiente_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                dg_nota.AutoGenerateColumns = false;
                listar_notas_xestado_xcliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        public void listar_notas_xestado_xcliente()
        {
            try
            {
                dg_nota.DataSource = null;

                table_nota_credito = CComprobante.listar_notas_xestado_xcliente(cliente);

                if (table_nota_credito != null)
                {
                    if (table_nota_credito.Rows.Count > 0)
                    {
                        dg_nota.DataSource = table_nota_credito;
                        dg_nota.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }


        private void frmNotaCreditoPendiente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dg_nota_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (dg_nota.Rows.Count > 0)
                {
                        notacredito = new Comprobantee()
                        {
                            CodComprobante = int.Parse(dg_nota.Rows[e.RowIndex].Cells[0].Value.ToString()),
                            Scomprobante = dg_nota.Rows[e.RowIndex].Cells[2].Value.ToString(),
                            Total = decimal.Parse(dg_nota.Rows[e.RowIndex].Cells[3].Value.ToString())
                        };

                    if (notacredito != null)
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
