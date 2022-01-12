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
    public partial class frmVerCierreCaja : DevComponents.DotNetBar.Office2007Form
    {
        public Usuario usureg { get; set; }
        private CCaja admca = new CCaja();
        private Caja caja = null;
        private DataTable cajas = null;
        public frmVerCierreCaja()
        {
            InitializeComponent();
        }

        private void frmVerCierreCaja_Load(object sender, EventArgs e)
        {
            dg_resultado.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dg_resultado.AutoGenerateColumns = false;
            dg_resultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            dt_fecha_ini.Value = DateTime.Now;
            dt_fecha_fin.Value = DateTime.Now;

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                                frm_cajamovimiento.usureg = usureg;
                                frm_cajamovimiento._Cajaid = caja.Codcaja;
                                frm_cajamovimiento.Estado = 2;
                                frm_cajamovimiento.ShowDialog();

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        
        private void btn_item_ver_Click(object sender, EventArgs e)
        {
            btn_ver.PerformClick();
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            try
            {
                cargar_caja();
            }
            catch (Exception) { }
        }

        /**********************Mis Metodos***********************/

        public void cargar_caja()
        {
            try
            {
                dg_resultado.DataSource = null;
                cajas = CCaja.listar_caja_cerrada(dt_fecha_ini.Value, dt_fecha_fin.Value);

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

        private void frmVerCierreCaja_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
