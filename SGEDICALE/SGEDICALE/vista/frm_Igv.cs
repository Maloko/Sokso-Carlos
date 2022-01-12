using SGEDICALE.clases;
using SGEDICALE.controlador;
using DevComponents.DotNetBar;
using System;
using System.Data;
using System.Windows.Forms;

namespace Avicola.vista
{
    public partial class frm_Igv : DevComponents.DotNetBar.Office2007Form
    {
        public Usuario Usuario { get; set; }

        private Igv igv = null;
        private DataTable lista_igv = null;
        public frm_Igv()
        {
            InitializeComponent();
        }

        private void frm_Igv_Load(object sender, EventArgs e)
        {
            dg_resultado.AutoGenerateColumns = false;
            
            txt_anho.Text = DateTime.Now.Year.ToString();
            cb_estado.SelectedIndex = 0;
        }

        private void txt_valor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text.Length == 0)
            {
                if (txt_valor.Text.Length > 0 && txt_valor_inverso.Text.Length>0)
                {
                    if (decimal.Parse(txt_valor.Text) > 0 && decimal.Parse(txt_valor_inverso.Text)>0)
                    {
                        igv = new Igv() {

                            Valor = decimal.Parse(txt_valor.Text),
                            Valorinverso=decimal.Parse(txt_valor_inverso.Text),
                            Anho = int.Parse(txt_anho.Text),
                                                   
                        };
                        if (cb_estado.SelectedIndex == 0) { igv.Estado = 1; } else { igv.Estado = 0; }

                        if (CIgv.registar_igv(igv) > 0)
                        {
                            MessageBoxEx.Show("Registro correcto...", "Información");
                            btn_cargar.PerformClick();
                        }
                        else {

                            MessageBoxEx.Show("Problemas para registrar igv...", "Advertencia");
                        }

                    }
                    else {
                            MessageBoxEx.Show("Valor de igv no puede ser cero...", "Advertencia");
                    }
                }
                else {

                            MessageBoxEx.Show("Complete valor de igv...","Advertencia");
                }
            }
            else {

                if (txt_valor.Text.Length > 0 && txt_valor_inverso.Text.Length > 0)
                {
                    if (decimal.Parse(txt_valor.Text) > 0 && decimal.Parse(txt_valor_inverso.Text) > 0)
                    {
                        igv = new Igv()
                        {
                            Igvid=int.Parse(txt_cod.Text),
                            Valor = decimal.Parse(txt_valor.Text),
                            Valorinverso = decimal.Parse(txt_valor_inverso.Text),
                            Anho = int.Parse(txt_anho.Text)
                           
                        };
                        if (cb_estado.SelectedIndex == 0) { igv.Estado = 1; } else { igv.Estado = 0; }

                        if (CIgv.actualizar_igv(igv) > 0)
                        {
                            MessageBoxEx.Show("Actualización correcta...", "Información");
                            btn_cargar.PerformClick();
                        }
                        else
                        {

                            MessageBoxEx.Show("Problemas para actualizar igv...", "Advertencia");
                        }

                    }
                    else
                    {

                        MessageBoxEx.Show("Valor de igv no puede ser cero...", "Advertencia");
                    }
                }
                else
                {

                    MessageBoxEx.Show("Complete valor de igv...", "Advertencia");
                }

            }
        }

        private void txt_valor_Leave(object sender, EventArgs e)
        {
            if (txt_valor.Text.Length == 0) {

                txt_valor.Text = "0.00";
            }
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            lista_igv = CIgv.listar_igv();

            if (lista_igv != null) {

                if (lista_igv.Rows.Count > 0) {

                    dg_resultado.DataSource = lista_igv;

                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            dg_resultado.DataSource = null;
            txt_cod.Text = string.Empty;
            txt_valor.Text = "0.00";
            txt_valor_inverso.Text = "0.00";
            txt_anho.Text = DateTime.Now.Year.ToString();
            cb_estado.SelectedIndex = 0;
        }

        private void txt_valor_inverso_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_valor_inverso_Leave(object sender, EventArgs e)
        {
            if (txt_valor_inverso.Text.Length == 0)
            {
                txt_valor_inverso.Text = "0.00";
            }
        }

        private void dg_resultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dg_resultado.Rows.Count > 0)
            {

                if (e.RowIndex != -1)
                {

                    txt_cod.Text = dg_resultado.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txt_valor.Text = dg_resultado.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txt_valor_inverso.Text = dg_resultado.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txt_anho.Text = dg_resultado.Rows[e.RowIndex].Cells[3].Value.ToString();
                    if (dg_resultado.Rows[e.RowIndex].Cells[4].Value.ToString() == "ACTIVO") { cb_estado.SelectedIndex = 0; } else { cb_estado.SelectedIndex = 1; }
                }
            }
        }
    }
}
