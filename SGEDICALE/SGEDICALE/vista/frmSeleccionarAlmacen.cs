using System;
using System.Windows.Forms;

namespace SGEDICALE.vista
{
    public partial class frmSeleccionarAlmacen : DevComponents.DotNetBar.Office2007Form
    {
        public frmSeleccionarAlmacen()
        {
            InitializeComponent();
        }

        private void frmSeleccionarAlmacen_Load(object sender, EventArgs e)
        {

            CargaSucursales();
            CargaAlmacenes();

        }


        private void CargaSucursales()
        {
            /*
            cmbSucursal.DataSource = AdmSuc.CargaSucursales(Session.CodEmpresa);
            cmbSucursal.DisplayMember = "nombre";
            cmbSucursal.ValueMember = "codSucursal";
            */

        }


        private void CargaAlmacenes()
        {
          
           /* dgvAlmacenes.DataSource = admalm.MuestraAlmacenesDisponibles(Convert.ToInt32(cmbSucursal.SelectedValue));*/
    
        }

        private void frmSeleccionarAlmacen_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
