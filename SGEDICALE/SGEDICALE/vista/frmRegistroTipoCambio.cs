using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmRegistroTipoCambio : DevComponents.DotNetBar.Office2007Form
    {

        private List<Moneda> lista_moneda = null;
        public int codtipocambio = 0;
        TipoCambio tc = null;

        public frmRegistroTipoCambio()
        {
            InitializeComponent();
        }

        public frmRegistroTipoCambio(int codtipo)
        {
            InitializeComponent();
            codtipocambio = codtipo;

          
        }


        public void cargartipocambio()
        {
            tc=CTipoCambio.buscarxcodigo(codtipocambio);

            if(tc!=null)
            {
                cbMoneda.SelectedValue = tc.Codmoneda;
                dtpFecha.Value = tc.Fecha;
                txtcompra.Text = tc.Compra.ToString();
                txtventa.Text = tc.Venta.ToString();
            }

          

        }


        private void frmRegistroTipoCambio_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dtpFecha.Value = DateTime.Now;
            cargarmoneda();
            cargartipocambio();

            this.Cursor = Cursors.Default;
        }

        public void cargarmoneda()
        {
            lista_moneda = CMoneda.listar_Moneda();
            cbMoneda.DataSource = lista_moneda;
            cbMoneda.ValueMember = "codMoneda";
            cbMoneda.DisplayMember = "descripcion";

        }

        private void frmRegistroTipoCambio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool rpta = true;
            string mensaje = "";

            try
            {

                if (txtcompra.Text == "" && txtventa.Text == "")
                {
                    MessageBox.Show("Complete los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (cbMoneda == null)
                {

                    this.Cursor = Cursors.Default;
                    return;
                }

                if (cbMoneda.Items.Count < 0)
                {

                    this.Cursor = Cursors.Default;
                    return;
                }

              
                    TipoCambio tipocambio = new TipoCambio();

                    tipocambio.Codmoneda = Convert.ToInt32(cbMoneda.SelectedValue);
                    tipocambio.Fecha = dtpFecha.Value;
                    tipocambio.Compra = Convert.ToDecimal(txtcompra.Text);
                    tipocambio.Venta = Convert.ToDecimal(txtventa.Text);
                    tipocambio.Codusuario = Session.CodUsuario;


                    if (codtipocambio == 0)
                    {
                        rpta = CTipoCambio.insert(tipocambio);
                        mensaje = "Guardado correctamente";
                    }
                    else
                    {
                        tipocambio.Codtipocambio = codtipocambio;
                        rpta = CTipoCambio.update(tipocambio);
                        mensaje = "Actualizado correctamente";
                    }

                if (rpta == true)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                }

            }
            catch (Exception ex)
            {

                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void txtcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }


            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {

                TextBox textBox = (TextBox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 4)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar))
            {
                TextBox textBox = (TextBox)sender;

                if (textBox.Text.IndexOf('.') > -1 &&
                         textBox.Text.Substring(textBox.Text.IndexOf('.')).Length >= 4)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
