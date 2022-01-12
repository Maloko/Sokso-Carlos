using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using SGEDICALE.reportes;
using SGEDICALE.reportes.clsReportes;

namespace SGEDICALE.vista
{
    public partial class frmCobro : DevComponents.DotNetBar.Office2007Form
    {

        public static BindingSource data = new BindingSource();
        String filtro = String.Empty;
        Caja caja = null;

        public frmCobro()
        {
            InitializeComponent();
        }

        private void frmCobro_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dtpFechaInicio.Value = DateTime.Now.AddDays(-7);
            dtpFechaFin.Value = DateTime.Now;

            cargarestadofiltro();

            txtcod.Focus();

            ActiveControl = txtcod;

            this.Cursor = Cursors.Default;
        }

        public void cargarestadofiltro()
        {

            List<dynamic> listafiltro = new List<dynamic>()
            {
                new {codigo=0,descripcion="PENDIENTES" },
                new {codigo=1,descripcion="CANCELADOS" }
            };

            cbEstado.DataSource = listafiltro;
            cbEstado.ValueMember = "codigo";
            cbEstado.DisplayMember = "descripcion";
            cbEstado.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            try
            {
                int codpromotor = 0;
                dgvCobros.DataSource =null;
                dgvCobros.AutoGenerateColumns = false;


                if (dtpFechaInicio.Value.Date > dtpFechaFin.Value.Date)
                {
                    MessageBox.Show("Fecha de inicio debe ser menor a la fecha fin", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (txtcod.Text != "")
                {
                    codpromotor = Convert.ToInt32(txtcod.Text);
                }


                dgvCobros.DataSource = data;
                data.DataSource = CComprobante.MuestraCobros(Convert.ToInt32(cbEstado.SelectedValue), dtpFechaInicio.Value, dtpFechaFin.Value, codpromotor);
                data.Filter = String.Empty;
                filtro = String.Empty;
                dgvCobros.ClearSelection();


                lbregistro.Text = dgvCobros.Rows.Count + " registros.";

                total_cobro();

                this.Cursor = Cursors.Default;


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
      
        }

        public void total_cobro()
        {

            try
            {

                if (dgvCobros.Rows.Count > 0)
                {

                    txttotal.Text = (dgvCobros.Rows.Cast<DataGridViewRow>().Select(x => decimal.Parse(x.Cells["total"].Value.ToString())).Sum()).ToString();

                    txtpendiente.Text = (dgvCobros.Rows.Cast<DataGridViewRow>().Select(x => decimal.Parse(x.Cells["pendiente"].Value.ToString())).Sum()).ToString();

                    txtcobrado.Text = (dgvCobros.Rows.Cast<DataGridViewRow>().Select(x => decimal.Parse(x.Cells["abonado"].Value.ToString())).Sum()).ToString();

                }
                else
                {

                    txtpendiente.Text = "0.00";
                    txtcobrado.Text = "0.00";
                    txttotal.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }
        }


        private void txtcod_KeyPress(object sender, KeyPressEventArgs e)
        {
            enteros(e);
        }

        public void enteros(KeyPressEventArgs e)
        {
            String Aceptados = "0123456789" + Convert.ToChar(8);

            if (Aceptados.Contains("" + e.KeyChar))
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void frmCobro_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            dgvCobros.DataSource = null;
            txtcod.Clear();
            txtpromotor.Clear();

            txtpendiente.Text = "0.00";
            txtcobrado.Text = "0.00";
            txttotal.Text = "0.00";

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            try
            {

                if (dgvCobros.Rows.Count > 0)
                {

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("codcomprobante", typeof(int));
                    dt.Columns.Add("fechaemision", typeof(DateTime));
                    dt.Columns.Add("comprobante", typeof(string));
                    dt.Columns.Add("nombre", typeof(string));
                    dt.Columns.Add("dni", typeof(string));
                    dt.Columns.Add("descripcion", typeof(string));
                    dt.Columns.Add("total", typeof(decimal));
                    dt.Columns.Add("pendiente", typeof(decimal));

                    dt.Columns.Add("fecha1", typeof(DateTime));
                    dt.Columns.Add("fecha2", typeof(DateTime));
                    dt.Columns.Add("estado", typeof(string));
                    dt.Columns.Add("promotor", typeof(string));
                    dt.Columns.Add("deudatotal", typeof(decimal));
                    dt.Columns.Add("totalcobrado", typeof(decimal));
                    dt.Columns.Add("totalpendiente", typeof(decimal));

                    foreach (DataGridViewRow dgv in dgvCobros.Rows)
                    {
                        dt.Rows.Add(dgv.Cells["codcomprobante"].Value,
                        Convert.ToDateTime(dgv.Cells["fechaemision"].Value),
                        dgv.Cells["comprobante"].Value,
                        dgv.Cells["nombre"].Value,
                        dgv.Cells["dni"].Value,
                        dgv.Cells["descripcion"].Value,
                        dgv.Cells["total"].Value,
                        dgv.Cells["pendiente"].Value,
                        dtpFechaInicio.Text,
                        dtpFechaFin.Text,
                        cbEstado.Text,
                        txtpromotor.Text,
                        Convert.ToDecimal(txttotal.Text),
                        Convert.ToDecimal(txtcobrado.Text),
                        Convert.ToDecimal(txtpendiente.Text));
                    }
                    ds.Tables.Add(dt);
                    ds.WriteXml("C:\\XML\\CobrosGeneralDicaleRPT.xml", XmlWriteMode.WriteSchema);

                    CRCobros rpt = new CRCobros();

                    frmRptCobros frm = new frmRptCobros();
                    rpt.SetDataSource(ds);
                    frm.crvCobro.ReportSource = rpt;
                    frm.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;

        }

        private void txtcod_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    if (Application.OpenForms["frmListadoPromotores"] != null)
                    {
                        Application.OpenForms["frmListadoPromotores"].Activate();
                    }
                    else
                    {
                        Promotor pro = null;
                        frmListadoPromotores form = new frmListadoPromotores();

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            pro = form.promotor;

                            if (pro != null)
                            {
                                txtcod.Text = pro.CodPromotor.ToString();
                                txtpromotor.Text = pro.Nombrecompleto;

                                btnBuscar_Click(null,null);

                            }
                            else
                            {
                                txtcod.Focus();
                                this.Cursor = Cursors.Default;
                                return;
                            }
                        }
                    }
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void txtpromotor_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCobros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string accion = "";
                int codcomprobante = 0;
                int id = -1;
                Comprobantee comprobante = null;

                if (dgvCobros.Rows.Count >= 1 && e.RowIndex != -1)
                {

                    accion = dgvCobros.CurrentCell.Value.ToString();

                    if (accion.ToString() == "Ingresar Pago" || accion.ToString() == "Muestra Pagos")
                    { 

                        codcomprobante = Convert.ToInt32(dgvCobros.Rows[e.RowIndex].Cells["codcomprobante"].Value.ToString());
                        comprobante = CComprobante.buscacomprobante(codcomprobante);

                        if (comprobante == null)
                        {
                            MessageBox.Show("Comprobante no encontrado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Cursor = Cursors.Default;
                            return;
                        }
                    }

                    if (accion.ToString() == "Ingresar Pago")
                    {

                        if (codcomprobante != 0)
                        {
                            id = CCaja.buscar_caja_abierta(Session.CodUsuario);

                            if (id > 0)
                            {
                                caja = new Caja()
                                {
                                    Codcaja = id
                                };

                           
                                
                                frmCancelarPago frm_cp = new frmCancelarPago(comprobante);
                                frm_cp.caja = caja;
                                frm_cp.ShowDialog();

                                btnBuscar_Click(null,null);

                            }
                            else
                            {
                                MessageBox.Show("Aperture caja", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Cursor = Cursors.Default;
                                return;
                            }

                        }
                        else
                        {
                            MessageBox.Show("No ha seleccionado un fila", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Cursor = Cursors.Default;
                            return;
                        }

                    }

                    if (accion.ToString() == "Muestra Pagos")
                    {
                        frm_MuestraPagos frm_cp = new frm_MuestraPagos(comprobante);
                        frm_cp.ShowDialog();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

    }
}
