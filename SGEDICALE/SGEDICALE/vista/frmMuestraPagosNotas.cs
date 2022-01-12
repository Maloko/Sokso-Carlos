using System;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmMuestraPagosNotas : DevComponents.DotNetBar.Office2007Form
    {
        public Promotor cliente { get; set; }
        private DataTable table_nota_credito = null;
        public Comprobantee notacredito = null;

        public int codNotaCredito =0;

        public frmMuestraPagosNotas()
        {
            InitializeComponent();
        }

        public frmMuestraPagosNotas(int codNota)
        {
            codNotaCredito = codNota;
            InitializeComponent();
        }

        private void frmMuestraPagosNotas_Load(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            try
            {
                dg_nota.AutoGenerateColumns = false;
                listar_pagos_notas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        public void listar_pagos_notas()
        {
            try
            {
                dg_nota.DataSource = null;

                table_nota_credito = CCobro.listar_pagos_notas(codNotaCredito);

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

        private void frmMuestraPagosNotas_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
