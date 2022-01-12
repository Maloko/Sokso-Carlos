using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using SGEDICALE.reportes;
using SGEDICALE.reportes.clsReportes;
using System.Drawing.Printing;

namespace SGEDICALE.vista
{
    public partial class frm_Depositos : DevComponents.DotNetBar.Office2007Form
    {

        public static BindingSource data = new BindingSource();
        String filtro = String.Empty;
        Caja caja = null;

        int codpcomprobante = 0;
        public string numeroOperacion = string.Empty;

        public frm_Depositos()
        {
            InitializeComponent();
        }

        private void frm_Depositos_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dtpFechaInicio.Value = DateTime.Now.AddDays(-7);
            dtpFechaFin.Value = DateTime.Now;

            cargarestadofiltro();


            this.Cursor = Cursors.Default;
        }


        public void cargarestadofiltro()
        {

            List<dynamic> listafiltro = new List<dynamic>()
            {
                new {codigo=0,descripcion="LIBRES" },
                new {codigo=1,descripcion="SALDO A FAVOR" },
                new {codigo=2,descripcion="COBRADOS" },
                new {codigo=4,descripcion="ANULADOS" }

            };

            cbEstado.DataSource = listafiltro;
            cbEstado.ValueMember = "codigo";
            cbEstado.DisplayMember = "descripcion";
            cbEstado.Refresh();
        }

        private void frm_Depositos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                int codpromotor = 0;
                dgvDepositos.AutoGenerateColumns = false;
                dgvDepositos.DataSource = null;

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

                dgvDepositos.DataSource = data;
                data.DataSource = CComprobante.MuestraDepositos(Convert.ToInt32(cbEstado.SelectedValue), dtpFechaInicio.Value, dtpFechaFin.Value, codpromotor);
                data.Filter = String.Empty;
                filtro = String.Empty;
                dgvDepositos.ClearSelection();

                total_deposito();
                lbregistro.Text = dgvDepositos.Rows.Count + " registros.";

                this.Cursor = Cursors.Default;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

        }


        public void total_deposito()
        {
            try
            {
                if (dgvDepositos.Rows.Count > 0)
                {
                    txttotal.Text = (dgvDepositos.Rows.Cast<DataGridViewRow>().Select(x => decimal.Parse(x.Cells["monto"].Value.ToString())).Sum()).ToString();
                }
                else
                {
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

                                btnBuscar_Click(null, null);

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

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbEstado.Items.Count > 0)
            {
                if (cbEstado.Text != "")
                {
                    if (cbEstado.Text == "SALDO A FAVOR" || cbEstado.Text == "COBRADOS")
                    {
                        txtcod.Visible = true;
                        txtpromotor.Visible = true;
                        lblcliente.Visible = true;

                        txtcod.Focus();
                        ActiveControl = txtcod;

                    }
                    else
                    {
                        txtcod.Visible = false;
                        txtpromotor.Visible = false;
                        lblcliente.Visible = false;

                        txtpromotor.Clear();
                        txtcod.Clear();
                    }
                }

                if (cbEstado.Text == "LIBRES")
                {
                    btnBuscar_Click(null, null);
                }

            }
        }




        public void imprimirSaldoaFavor()
        {

            try
            {

                this.Cursor = Cursors.WaitCursor;

                DataSet jes = new DataSet();
                frmRptSaldoFavor frm = new frmRptSaldoFavor();
                CRSaldo rpt = new CRSaldo();

                string NombreImpresora = impresora_xdefecto();

                jes = clsReporte.ReporteSaldoFavor(codpcomprobante);

                rpt.SetDataSource(jes);
                CrystalDecisions.CrystalReports.Engine.PrintOptions rptoption = rpt.PrintOptions;
                rptoption.PrinterName = NombreImpresora;
                //rptoption.PaperSize = (CrystalDecisions.Shared.PaperSize)ext.GetIDPaperSize(ser.NombreImpresora, ser.PaperSize);

                rptoption.ApplyPageMargins(new CrystalDecisions.Shared.PageMargins(0, 0, 0, 20));
                rpt.PrintToPrinter(1, false, 1, 1);
                rpt.Close();
                rpt.Dispose();


                this.Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema" + ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }
        }

        public string impresora_xdefecto()
        {

            string nombreimpresora = "";//Donde guardare el nombre de la impresora por defecto
            try
            {
                //Busco la impresora por defecto
                for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                {
                    PrinterSettings a = new PrinterSettings();
                    a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();
                    if (a.IsDefaultPrinter)
                    {
                        nombreimpresora = PrinterSettings.InstalledPrinters[i].ToString();

                    }
                }

                return nombreimpresora;
            }
            catch (Exception)
            {
                return nombreimpresora;
            }
        }




        private void dgvDepositos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {

                    codpcomprobante = Convert.ToInt32(dgvDepositos.Rows[e.RowIndex].Cells["codpagocomprobante"].Value.ToString());
                    numeroOperacion = dgvDepositos.Rows[e.RowIndex].Cells["operacionnumero"].Value.ToString();
                    if (numeroOperacion != "")
                    {
                        if (dgvDepositos.CurrentCell.Value.ToString() == "Imprimir")
                        {
                            imprimirSaldoaFavor();
                        }
                        if (dgvDepositos.CurrentCell.Value.ToString() == "Ver Uso")
                        {
                            frmUsoDeposito frm_ud = new frmUsoDeposito(numeroOperacion);
                            frm_ud.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvDepositos.DataSource = null;
            txtcod.Clear();
            txtpromotor.Clear();

            txttotal.Text = "0.00";
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {

                if (dgvDepositos.Rows.Count > 0)
                {

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("codpagocomprobante", typeof(int));
                    dt.Columns.Add("codpago", typeof(int));
                    dt.Columns.Add("fecha", typeof(DateTime));

                    dt.Columns.Add("banco", typeof(string));
                    dt.Columns.Add("cuenta", typeof(string));
                    dt.Columns.Add("transacion", typeof(string));
                    dt.Columns.Add("monto", typeof(decimal));
                    dt.Columns.Add("operacionnumero", typeof(string));
                    dt.Columns.Add("operacionhora", typeof(string));
                    dt.Columns.Add("sucursal", typeof(string));
                    dt.Columns.Add("usuario", typeof(string));

                    dt.Columns.Add("montopagado", typeof(decimal));
                    dt.Columns.Add("montofavor", typeof(decimal));

                    dt.Columns.Add("fecha1", typeof(DateTime));
                    dt.Columns.Add("fecha2", typeof(DateTime));
                    dt.Columns.Add("estado", typeof(string));
                    dt.Columns.Add("promotor", typeof(string));
                    dt.Columns.Add("total", typeof(decimal));


                    foreach (DataGridViewRow dgv in dgvDepositos.Rows)
                    {
                        dt.Rows.Add(dgv.Cells["codpagocomprobante"].Value,
                        dgv.Cells["codpago"].Value,
                        Convert.ToDateTime(dgv.Cells["fecha"].Value),
                        dgv.Cells["banco"].Value,
                        dgv.Cells["cuenta"].Value,
                        dgv.Cells["transacion"].Value,
                        dgv.Cells["monto"].Value,
                        dgv.Cells["operacionnumero"].Value,
                        dgv.Cells["operacionhora"].Value,
                        dgv.Cells["sucursal"].Value,
                        dgv.Cells["usuario"].Value,
                        dgv.Cells["montopagado"].Value,
                        dgv.Cells["montofavor"].Value,
                        dtpFechaInicio.Text,
                        dtpFechaFin.Text,
                        cbEstado.Text,
                        txtpromotor.Text,
                        Convert.ToDecimal(txttotal.Text));
                    }
                    ds.Tables.Add(dt);
                    ds.WriteXml("C:\\XML\\DepositosDicaleRPT.xml", XmlWriteMode.WriteSchema);

                    CRDepositos rpt = new CRDepositos();

                    frmRptDepositos frm = new frmRptDepositos();
                    rpt.SetDataSource(ds);
                    frm.crvDepositos.ReportSource = rpt;
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

        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnBuscar_Click(null, null);
        }

        private void dgvDepositos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                string mensaje = "";
                string monto = "";
                int estado = 0;
                int codpago = 0;

                if (dgvDepositos.Rows.Count > 0)
                {

                    if (cbEstado.Text != "LIBRES" && cbEstado.Text != "ANULADOS")
                    {
                        return;
                    }

                    monto = dgvDepositos.Rows[e.RowIndex].Cells["monto"].Value.ToString();
                    codpago = Convert.ToInt32(dgvDepositos.Rows[e.RowIndex].Cells["codpago"].Value.ToString());

                    if (cbEstado.Text == "LIBRES")
                    {
                        mensaje = "¿ Desea anular este depósito con monto " + monto + " . ?";
                        estado = 0;
                    }

                    if (cbEstado.Text == "ANULADOS")
                    {
                        mensaje = "¿ Desea activar este depósito con monto " + monto + " . ?";
                        estado = 1;
                    }


                    frmEstadoPago frm_fac = new frmEstadoPago(codpago, estado, mensaje);
                    frm_fac.ShowDialog();


                    btnBuscar_Click(null, null);
                    string ola = "";
                    /*
                    DialogResult respuesta = MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {

                        CPago.cambiarestado(codpago, estado);
                        btnBuscar_Click(null, null);
                    }*/
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
