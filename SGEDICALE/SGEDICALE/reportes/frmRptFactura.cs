using System;
using System.Windows.Forms;

namespace SGEDICALE.reportes
{
    public partial class frmRptFactura : DevComponents.DotNetBar.Office2007Form
    {
        public frmRptFactura()
        {
            InitializeComponent();
        }

        private void frmRptFactura_Load(object sender, EventArgs e)
        {

        }

        private void frmRptFactura_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
