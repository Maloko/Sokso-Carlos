using System;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using System.Transactions;
using SGEDICALE.reportes;
using SGEDICALE.reportes.clsReportes;
using System.Drawing.Printing;

namespace SGEDICALE.vista
{
    public partial class frmCancelarPago : DevComponents.DotNetBar.Office2007Form
    {

        int codcomprobante = 0;
        Comprobantee comprobante = null;
        Comprobantee notacredito = null;
        Pago pago = null;
        public Caja caja = null;
        string tipofavor = "";  //variable para saber si el monto de pago, es un  saldo pendiente o un saldo a afvor
        PagoComprobante pagocom = null;

        public frmCancelarPago()
        {
            InitializeComponent();
        }

        public frmCancelarPago(Comprobantee com)
        {
            InitializeComponent();
            comprobante = com;
            cargadatoscomprobante();
        }

        public void cargadatoscomprobante()
        {

            btnCobro.Enabled = true;
            try
            {
                if (comprobante != null)
                {
                    txt_comprobante.Text = comprobante.Scomprobante;
                    txt_monto_pendiente.Text = comprobante.Pendiente.ToString();
                    txt_monto.Text= comprobante.Pendiente.ToString(); 


                    if (comprobante.Pendiente == 0)
                    {
                        btnCobro.Enabled = false;
                    }


                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void frmCancelarPago_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            txt_monto.Focus();
            dtpFechaPago.Value = DateTime.Now;
            CargaMetodosPagos();

            CargarTipoTarjeta();
            CargarBancos();
            cbMetodoPago_SelectionChangeCommitted(null, null);

            this.Cursor = Cursors.Default;
        }


        public void CargaMetodosPagos()
        {
            try
            {
                cbMetodoPago.DataSource = CMetodoPago.CargaMetodoPagos();
                cbMetodoPago.DisplayMember = "descripcion";
                cbMetodoPago.ValueMember = "codMetodoPago";

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void CargarTipoTarjeta()
        {
            try
            {
                cbTipoTarjeta.DataSource = CTipoTarjeta.CargaTipoTarjeta();
                cbTipoTarjeta.DisplayMember = "descripcion";
                cbTipoTarjeta.ValueMember = "codtipotarjeta";

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void CargarBancos()
        {
            try
            {

                cbbanco.DataSource = CBanco.cargacombobancos();
                cbbanco.DisplayMember = "descripcion";
                cbbanco.ValueMember = "codbanco";

                cbbanco_SelectionChangeCommitted(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }


        private void CargarCuenta()
        {

        }


        private void frmCancelarPago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cbbanco_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarCuenta();
        }

        private void cbbanco_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                if (cbbanco != null)
                {
                    if (cbbanco.Items.Count > 0)
                    {
                        cb_cuenta.DataSource = CCuenta.buscarxcodbanco(Convert.ToInt32(cbbanco.SelectedValue));
                        cb_cuenta.DisplayMember = "cuentaCorriente";
                        cb_cuenta.ValueMember = "codCuentaCorriente";
                    }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        private void txt_operacion_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            decimal monto = 0;
            int codbanco;
            int codcuenta;
            try
            {
                if (cbbanco.Items.Count > 0 && cb_cuenta.Items.Count > 0)
                {
                    if (e.KeyCode == Keys.F1)
                    {
                        if (Application.OpenForms["F1Pagos"] != null)
                        {
                            Application.OpenForms["F1Pagos"].Activate();
                        }
                        else
                        {
                            if (cbMetodoPago.Text != "DEPOSITO")
                            {
                                MessageBox.Show("Valido solo para pagos a deposito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Cursor = Cursors.Default;
                                return;
                            }

                            codbanco = Convert.ToInt32(cbbanco.SelectedValue);
                            codcuenta = Convert.ToInt32(cb_cuenta.SelectedValue);
                            F1Pagos formf1P = new F1Pagos(codbanco, codcuenta);


                            if (formf1P.ShowDialog() == DialogResult.OK)
                            {
                                pago = formf1P.pago;

                                if (pago != null)
                                {
                                    monto = Convert.ToInt32(txt_monto_pendiente.Text);

                                    if (pago.Monto >= monto)
                                    {
                                        txt_monto.Text = monto.ToString();
                                        txt_parcial.Text = Convert.ToString(pago.Monto - monto);
                                        txt_operacion.Text = pago.Operacionnumero;
                                        tipofavor = "FAVOR";
                                    }
                                    else
                                    {

                                        txt_monto.Text = pago.Monto.ToString();
                                        txt_parcial.Text = Convert.ToString(monto - pago.Monto);
                                        txt_operacion.Text = pago.Operacionnumero;
                                        txt_observacion.Text = "Es un pago parcial";
                                        tipofavor = "PENDIENTE";

                                    }
                                }
                                else
                                {
                                    this.Cursor = Cursors.Default;
                                    return;
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Complete los datos  (banco,cuenta)", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void cbMetodoPago_SelectionChangeCommitted(object sender, EventArgs e)
        {

            cbTipoTarjeta.Enabled = true;
            cbbanco.Enabled = true;
            cb_cuenta.Enabled = true;
            txt_operacion.Enabled = true;

            if (comprobante.Pendiente > 0)
            {
                btnCobro.Enabled = true;
            }
            

            if (cbMetodoPago.Items.Count > 0)
            {
                if (cbTipoTarjeta != null)
                {
                    if (cbTipoTarjeta.Items.Count > 0 && cbTipoTarjeta.Text != "")
                    {

                        if (cbMetodoPago.Text == "EFECTIVO")
                        {
                            cbTipoTarjeta.Enabled = false;
                            cbbanco.Enabled = false;
                            cb_cuenta.Enabled = false;
                            txt_operacion.Enabled = false;
                        }

                        if (cbMetodoPago.Text == "DEPOSITO")
                        {
                            cbTipoTarjeta.Enabled = false;
                        }

                        if (cbMetodoPago.Text == "NOTA CREDITO")
                        {
                            cbTipoTarjeta.Enabled = false;
                            cbbanco.Enabled = false;
                            cb_cuenta.Enabled = false;
                            txt_operacion.Enabled = false;

                        }

                        if (cbMetodoPago.Text != "EFECTIVO" && cbMetodoPago.Text != "DEPOSITO" && cbMetodoPago.Text != "NOTA CREDITO" && cbMetodoPago.Text != "TARJETA")
                        {
                            cbTipoTarjeta.Enabled = false;
                            cbbanco.Enabled = false;
                            cb_cuenta.Enabled = false;
                            txt_operacion.Enabled = false;

                        }

                    }
                }
            }
        }

        private void btnCobro_Click(object sender, EventArgs e)
        {

            bool rpta = false;
            bool correcto = true;

            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (decimal.Parse(txt_monto.Text) > 0 && decimal.Parse(txt_monto.Text) <= decimal.Parse(txt_monto_pendiente.Text))
                {

                    if (cbMetodoPago.Text == "NOTA CREDITO")
                    {
                        if (txt_ncc.Text.Length > 0)
                        {
                            correcto = true;
                        }
                        else
                        {
                            MessageBox.Show("Ingrese nota de credito...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            correcto = false;
                            this.Cursor = Cursors.Default;
                            return;
                        }
                    }

                    if (cbMetodoPago.Text == "DEPOSITO")
                    {

                        if (pago == null)
                        {
                            correcto = false;
                            MessageBox.Show("No ha seleccionado un deposito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Cursor = Cursors.Default;
                            return;
                        }

                        if (cbbanco.Items.Count <= 0)
                        {
                            correcto = false;
                            MessageBox.Show("No ha seleccionado ningún banco", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Cursor = Cursors.Default;
                            return;
                        }


                        if (cb_cuenta.Items.Count <= 0)
                        {
                            correcto = false;
                            MessageBox.Show("No ha seleccionado ninguna cuenta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Cursor = Cursors.Default;
                            return;
                        }

                        correcto = true;
                    }

                    if (correcto == true)
                    {

                        Cobro cobro = new Cobro();

                        cobro.Codmetodopago = Convert.ToInt32(cbMetodoPago.SelectedValue);
                        cobro.Fechacobro = dtpFechaPago.Value;
                        cobro.Monto = Convert.ToDecimal(txt_monto.Text);
                        cobro.Observacion = txt_observacion.Text;
                        cobro.Codcaja = caja.Codcaja;
                        cobro.Codcomprobante = comprobante.CodComprobante;
                        cobro.Estado = 1;
                        cobro.Codusuario = Session.CodUsuario;

                        if (cbMetodoPago.Text == "NOTA CREDITO")
                        {
                            cobro.Codtipotarjeta = 0;
                            cobro.Codbanco = 0;
                            cobro.Codcuenta = 0;
                            cobro.Noperacion = txt_operacion.Text;
                            cobro.Codnotacredito = notacredito.CodComprobante;

                        }

                        if (cbMetodoPago.Text == "EFECTIVO")
                        {
                            cobro.Codtipotarjeta = 0;
                            cobro.Codbanco = 0;
                            cobro.Codcuenta = 0;
                            cobro.Noperacion = "";
                            cobro.Codnotacredito = 0;
                        }

                        if (cbMetodoPago.Text == "DEPOSITO")
                        {

                            pagocom = new PagoComprobante();

                            pagocom.Codpago = pago.CodPago;
                            pagocom.Codcomprobante = comprobante.CodComprobante;
                            pagocom.Pago = pago.Monto;
                            pagocom.Montopagado = Convert.ToDecimal(txt_monto.Text);
                            pagocom.Fechapago = dtpFechaPago.Value;
                            cobro.Estado = 1;


                            if (tipofavor == "FAVOR")
                            {
                                pagocom.Montopendiente = 0;
                                pagocom.Montofavor = Convert.ToDecimal(txt_parcial.Text);
                            }

                            if (tipofavor == "PENDIENTE")
                            {
                                pagocom.Montofavor = 0;
                                pagocom.Montopendiente = Convert.ToDecimal(txt_parcial.Text);
                            }

                            pagocom.Codusuario = Session.CodUsuario;

                            //Registro de cobro

                            cobro.Codtipotarjeta = Convert.ToInt32(cbMetodoPago.SelectedValue);
                            cobro.Codbanco = Convert.ToInt32(cbbanco.SelectedValue);
                            cobro.Codcuenta = Convert.ToInt32(cb_cuenta.SelectedValue);
                            cobro.Noperacion = txt_operacion.Text;
                            cobro.Codnotacredito = 0;

                            using (var Scope = new TransactionScope())
                            {

                                rpta = CPagoComprobante.insertar(pagocom);

                                if (rpta == true)
                                {

                                    if (CCobro.registar_cobro(cobro) > 0)
                                    {

                                    }

                                    else
                                    {
                                        Transaction.Current.Rollback();
                                        Scope.Dispose();
                                        MessageBox.Show("Pago  no realizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        this.Cursor = Cursors.Default;
                                        return;

                                    }


                                    Scope.Complete();
                                    Scope.Dispose();

                                }
                                else
                                {
                                    Transaction.Current.Rollback();
                                    Scope.Dispose();
                                    MessageBox.Show("Pago  no realizado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    this.Cursor = Cursors.Default;
                                    return;
                                }
                            }


                            this.Cursor = Cursors.Default;
                            MessageBox.Show("Pago realizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (pago.Monto > pagocom.Montopagado)
                            {
                                imprimirSaldoaFavor();
                            }

                            this.Close();

                        }

                        if (cbMetodoPago.Text != "DEPOSITO")
                        {

                            if (cobro.Noperacion == null)
                            {
                                cobro.Noperacion = "";
                            }
                            if (CCobro.registar_cobro(cobro) > 0)
                            {
                                MessageBox.Show("Pago realizado con exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Problemas en el registro de pago...", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Revisar el monto de pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Cursor = Cursors.Default;

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

                if (pagocom == null)
                {
                    MessageBox.Show("No se encontro un pago", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

         
                jes = clsReporte.ReporteSaldoFavor(pagocom.Codpagocomprobante);
               
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

        private void txt_ncc_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Promotor promotor = null;
            decimal monto = 0;

            try
            {
                if (cbMetodoPago.Items.Count > 0 )
                {
                    if (e.KeyCode == Keys.F1)
                    {
                        if (Application.OpenForms["frmNotaCreditoPendiente"] != null)
                        {
                            Application.OpenForms["frmNotaCreditoPendiente"].Activate();
                        }
                        else
                        {
                            if (cbMetodoPago.Text != "NOTA CREDITO")
                            {
                                MessageBox.Show("Valido solo para pagos con Nota de Crédito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Cursor = Cursors.Default;
                                return;
                            }

                            promotor = new Promotor();
                            promotor.CodPromotor = comprobante.Codpromotor;

                            frmNotaCreditoPendiente frm_notacredito = new frmNotaCreditoPendiente();
                            frm_notacredito.cliente = promotor;
                            if (frm_notacredito.ShowDialog() == DialogResult.OK)
                            {
                                notacredito = frm_notacredito.notacredito;
                                if (notacredito != null)
                                {
                                    txt_ncc.Text = notacredito.Scomprobante;
                                    txt_monto.Text = notacredito.Total.ToString();
                                    monto = Convert.ToDecimal(txt_monto_pendiente.Text);

                                    if (monto >= notacredito.Total)
                                    {
                                        txt_parcial.Text = Convert.ToString(monto - notacredito.Total);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Complete los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }
    }
}
