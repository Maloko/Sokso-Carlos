using SGEDICALE.clases;
using SGEDICALE.controlador;
using SGEDICALE.vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalXML.vista.cajero
{
    public partial class frmVerAperturaCaja : DevComponents.DotNetBar.Office2007Form
    {
        public Usuario usureg { get; set; }
        private CCaja admca = new CCaja();
        private Caja caja = null;
        private DataTable cajas = null;
        public frmVerAperturaCaja()
        {
            InitializeComponent();
        }

        private void frmVerAperturaCaja_Load(object sender, EventArgs e)
        {
            dg_resultado.AutoGenerateColumns = false;
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_caja();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_resultado.Rows.Count > 0)
                {
                    dg_resultado.MultiSelect = true;
                    dg_resultado.SelectAll();
                    dg_resultado.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                    DataObject dataObj = dg_resultado.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);

                    dg_resultado.MultiSelect = false;

                    MessageBox.Show("Puede copiarlo a cualquier editor de texto...", "Información");
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**********************Mis Metodos***********************/

        public void cargar_caja()
        {
            try
            {
                dg_resultado.DataSource = null;
                cajas = CCaja.listar_caja_apertura();

                if (cajas != null)
                {
                    if (cajas.Rows.Count > 0)
                    {

                        dg_resultado.DataSource = cajas;
                    }

                }
            }
            catch (Exception) { }

        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_resultado.Rows.Count > 0)
                {
                    if (dg_resultado.CurrentCell != null)
                    {
                        if (dg_resultado.CurrentCell.RowIndex != -1)
                        {

                            DialogResult respuesta = MessageBox.Show("¿Desea anular caja?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (respuesta == DialogResult.Yes)
                            {
                                caja = new Caja()
                                {
                                    Codcaja = int.Parse(dg_resultado.Rows[dg_resultado.CurrentCell.RowIndex].Cells[1].Value.ToString()),

                                };

                                if (CCaja.anular_caja(caja, usureg) > 0)
                                {
                                    MessageBox.Show("Caja anulada correctamente...", "Información");
                                    cargar_caja();
                                }
                                else
                                {
                                    MessageBox.Show("Caja no se puede anular tiene movimientos...", "Advertencia");

                                }

                            }
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_resultado.Rows.Count > 0)
                {
                    if (dg_resultado.CurrentCell != null)
                    {
                        if (dg_resultado.CurrentCell.RowIndex != -1)
                        {

                            caja = new Caja()
                            {
                                Codcaja = int.Parse(dg_resultado.Rows[dg_resultado.CurrentCell.RowIndex].Cells[1].Value.ToString())
                            };

                            if (Application.OpenForms["frmCajaMovimiento"] != null)
                            {
                                Application.OpenForms["frmCajaMovimiento"].Activate();
                            }
                            else
                            {
                                frmCajaMovimiento frm_cajamovimiento = new frmCajaMovimiento();
                                frm_cajamovimiento.usureg = new Usuario() { Usuarioid = int.Parse(dg_resultado.Rows[dg_resultado.CurrentCell.RowIndex].Cells[idusuario.Index].Value.ToString()) };
                                frm_cajamovimiento._Cajaid = caja.Codcaja;
                                frm_cajamovimiento.Estado = 1;
                                frm_cajamovimiento.ShowDialog();

                            }
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void btn_item_ver_Click(object sender, EventArgs e)
        {
            btn_ver.PerformClick();
        }

        private void frmVerAperturaCaja_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
