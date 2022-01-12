using System;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;

namespace SGEDICALE.vista
{
    public partial class frmCuenta : DevComponents.DotNetBar.Office2007Form
    {

        int codcuenta = 0;
        public frmCuenta()
        {
            InitializeComponent();
        }

        public frmCuenta(int cod)
        {
            InitializeComponent();
            codcuenta = cod;
        }

        private void frmCuenta_Load(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            CargaBancos();
            CargaMoneda();
            cargacuenta();

            this.Cursor = Cursors.Default;
        }

        public void cargacuenta()
        {

            /*
            this.Cursor = Cursors.WaitCursor;

            try
            {

                Cuenta cuenta = new Cuenta();
                cuenta = CBanco.buscar(codcuenta);

                if (banco == null)
                {
                    MessageBox.Show("Banco no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                txtsigla.Text = banco.Sigla.ToString();
                txtdescripcion.Text = banco.Descripcion.ToString();

                if (banco.Estado)
                {
                    cboEstado.SelectedValue = 1;
                }
                else
                {
                    cboEstado.SelectedValue = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
            */
        }


        private void CargaBancos()
        {
            cbBanco.DataSource = CBanco.listar();
            cbBanco.DisplayMember = "descripcion";
            cbBanco.ValueMember = "codBanco";
            //cbBanco.SelectedIndex = -1;
        }

        private void CargaMoneda()
        {
            cbMoneda.DataSource = CMoneda.CargaMonedasHabiles();
            cbMoneda.DisplayMember = "descripcion";
            cbMoneda.ValueMember = "codMoneda";
            //cbMoneda.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool rpta = true;
            string mensaje = "";

            try
            {
                Cuenta cuenta = new Cuenta();

                if (txtcuenta.Text == "" || txttipocuenta.Text == "")
                {
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (cbBanco.Text == "" || cbMoneda.Text == "")
                {
                    this.Cursor = Cursors.Default;
                    return;
                }

                cuenta.CodBanco= Convert.ToInt32(cbBanco.SelectedValue.ToString());
                cuenta.TipoCuenta = txttipocuenta.Text;
                cuenta.CuentaCorriente = txtcuenta.Text ;
                cuenta.Moneda= Convert.ToInt32(cbMoneda.SelectedValue.ToString());
                cuenta.CodAlmacen = 1;
                cuenta.CodUsuario = Session.CodUsuario;

                if (codcuenta == 0)
                {
                    rpta = CCuenta.Insert(cuenta);
                    mensaje = "Cuenta guardada correctamente";
                }
                else
                {
                    cuenta.CodCuentaCorriente = codcuenta;
                    
                    mensaje = "Cuenta actualizada correctamente";
                }

                if (rpta == true)
                {

                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void cbBanco_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void frmCuenta_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
