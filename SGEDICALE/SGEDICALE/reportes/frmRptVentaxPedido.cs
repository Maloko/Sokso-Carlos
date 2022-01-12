using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGEDICALE.reportes
{
    public partial class frmRptVentaxPedido : DevComponents.DotNetBar.Office2007Form
    {
        public frmRptVentaxPedido()
        {
            InitializeComponent();
        }

        private void frmRptVentaxPedido_Load(object sender, EventArgs e)
        {

        }

        private void frmRptVentaxPedido_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {

                this.Close();
            }
        }
    }
}
