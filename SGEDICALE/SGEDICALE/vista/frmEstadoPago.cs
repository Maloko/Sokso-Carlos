using SGEDICALE.controlador;
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
    public partial class frmEstadoPago : DevComponents.DotNetBar.Office2007Form
    {

        string mensaje = "";
        string monto = "";
        int estado = 0;
        int codpago = 0;
        string observacion = string.Empty;


        public frmEstadoPago()
        {
            InitializeComponent();
        }

        public frmEstadoPago(int codp, int est, string men)
        {
            InitializeComponent();
            codpago = codp;
            estado = est;
            mensaje = men;
        }

        private void frmEstadoPago_Load(object sender, EventArgs e)
        {
            lblpregunta.Text = mensaje;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CPago.cambiarestado(codpago, estado,txtObservacion.Text.Trim());
            this.Close();
        }

        private void frmEstadoPago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
