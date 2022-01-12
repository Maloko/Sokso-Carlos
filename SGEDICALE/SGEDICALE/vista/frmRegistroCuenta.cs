using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;

namespace SGEDICALE.vista
{
    public partial class frmRegistroCuenta : DevComponents.DotNetBar.Office2007Form
    {

        int codcuenta = 0;

        public frmRegistroCuenta()
        {
            InitializeComponent();
        }

        public frmRegistroCuenta(int cod)
        {
            InitializeComponent();

            codcuenta = cod;
        }


        public void cargarestado()
        {

            List<dynamic> listadinamica = new List<dynamic>()
            {

                new {codigo=1,descripcion = "ACTIVO" },
                new {codigo=0,descripcion="INACTIVO" }
            };

            cboEstado.DataSource = listadinamica;
            cboEstado.ValueMember = "codigo";
            cboEstado.DisplayMember = "descripcion";

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




        private void frmRegistroCuenta_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            cargarestado();
            CargaBancos();
            CargaMoneda();
       

            if (codcuenta != 0)
            {
                cargacuenta();
            }

            this.Cursor = Cursors.Default;
        }


        public void cargacuenta()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {

                Cuenta cuenta = new Cuenta();
                cuenta = CCuenta.buscar(codcuenta);

                if (cuenta == null)
                {
                    MessageBox.Show("Banco no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                 cbBanco.SelectedValue = cuenta.CodBanco;
                 cbMoneda.SelectedValue = cuenta.Moneda;
                 cboEstado.SelectedValue = cuenta.Estado;

                 txtcuenta.Text = cuenta.CuentaCorriente;
                 txttipocuenta.Text = cuenta.TipoCuenta;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
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

                cuenta.CodBanco = Convert.ToInt32(cbBanco.SelectedValue.ToString());
                cuenta.TipoCuenta = txttipocuenta.Text;
                cuenta.CuentaCorriente = txtcuenta.Text;
                cuenta.Moneda = Convert.ToInt32(cbMoneda.SelectedValue.ToString());
                cuenta.CodAlmacen = 1;
                cuenta.CodUsuario = Session.CodUsuario;
                cuenta.Estado = Convert.ToInt32(cboEstado.SelectedValue);

                if (codcuenta == 0)
                {
                    rpta = CCuenta.Insert(cuenta);
                    mensaje = "Cuenta guardada correctamente";
                }
                else
                {
                    cuenta.CodCuentaCorriente = codcuenta;
                    rpta = CCuenta.Update(cuenta);
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
    }
}
