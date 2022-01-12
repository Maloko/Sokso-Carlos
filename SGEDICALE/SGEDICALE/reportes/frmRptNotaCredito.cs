using System;
using System.Windows.Forms;

namespace SGEDICALE.reportes
{
    public partial class frmRptNotaCredito : DevComponents.DotNetBar.Office2007Form
    {
        public frmRptNotaCredito()
        {
            InitializeComponent();
        }

        private void frmRptNotaCredito_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }

        }

        private void frmRptNotaCredito_Load(object sender, EventArgs e)
        {

        }
    }
}
