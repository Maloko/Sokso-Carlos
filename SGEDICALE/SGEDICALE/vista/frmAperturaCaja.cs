using System;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;


namespace SGEDICALE.vista
{
    public partial class frmAperturaCaja : DevComponents.DotNetBar.Office2007Form
    {

        Caja caja;
        Usuario usuario;
    

        public frmAperturaCaja()
        {
            InitializeComponent();
        }

        private void frmAperturaCaja_Load(object sender, EventArgs e)
        {
            usuario = new Usuario();
        }

        private void txt_monto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_monto_KeyDown(object sender, KeyEventArgs e)
        {
            int id = -1;


            try
            {



                if (e.KeyCode == Keys.Enter)
                {

                    if (txt_monto.Text.Length > 0)
                    {
                        if (decimal.Parse(txt_monto.Text) >= 0)
                        {
                            id = CCaja.buscar_caja_abierta(Session.CodUsuario);

                            if (id == -1)
                            {
                                usuario.Usuarioid = Session.CodUsuario;
                                caja = new Caja()
                                {
                                    Montoapertura = decimal.Round(decimal.Parse(txt_monto.Text), 2),
                                    Usuario =usuario,
                                    Estado = 1

                                };

                                if (CCaja.registrar_caja(caja) > 0)
                                {
                                    MessageBox.Show("Apertura de caja correcta...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {

                                    MessageBox.Show("Problemas para la apertura de caja...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ya tiene caja aperturada...", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }


        }
    }
}
