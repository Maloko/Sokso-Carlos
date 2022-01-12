using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;
using SGEDICALE.reportes;
using SGEDICALE.reportes.clsReportes;
using System.IO;
using System.Drawing.Printing;
using SGEDICALE.vista;

namespace SGEDICALE.vista
{
    public partial class frmFacturar : DevComponents.DotNetBar.Office2007Form
    {
        private List<Serie> listaseries = null;
        public Pedido pedido1;
        Promotor promo = null;
        Pedido pedido = null;
        public Comprobantee comprobante = null;
        SGEDICALE.SunatFacElec.Facturacion facturacion = new SunatFacElec.Facturacion();
        List<dynamic> listatipoimpuesto;
        private DataTable ticketfacturar = null;

        Caja caja = null;
        private bool lectura = false;
        public int codPromotor = 0;


        public int cantidaddetalle = 0;
        public int estadopedido = 0;


        private List<DiscrepanciaNotaCredito> lista_discrepancia_ncc = null;
        public int respuesta = 0;
        public Byte[] firmadigital { get; set; }


        public Promotor promo2 = null;

        public frmFacturar()
        {
            InitializeComponent();
        }

        private void frmFacturar_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dtpFecha.Value = DateTime.Now.Date;

            cargartipocomprobante();
            cargarmoneda();
            cargartipoimpuesto();
            cargarformapago();
            cboTiempoIMpuesto_SelectedIndexChanged(null, null);


            if (comprobante != null)
            {

                listar_discrepancia_ncc();
                lectura = true;
                listar_detalle_comprobante_xidcomprobante();
            }
            else
            {

                cargarpedido();
                cargardetallepedido();

            }



            this.Cursor = Cursors.Default;
        }


        public void listar_discrepancia_ncc()
        {
            try
            {
                lista_discrepancia_ncc = CDiscrepanciaNotaCredito.listar_discrepancia_ncc();
            }
            catch (Exception) { }
        }

        public void listar_detalle_comprobante_xidcomprobante()
        {



            try
            {
                ticketfacturar = CComprobante.listar_detalle_comprobante_xidcomprobante(comprobante);
                comprobante = CComprobante.buscacomprobante(comprobante.CodComprobante);

                if (comprobante != null && ticketfacturar != null)
                {
                    if (ticketfacturar.Rows.Count > 0)
                    {
                        dgvdetalle.DataSource = ticketfacturar;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;
                return;
            }

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            bool rpta = true;
            try
            {

                respuesta = 0;
                if (pedido == null)
                {
                    MessageBox.Show("Pedido es nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                /* Comprobantee compro = CComprobante.buscacomprobantexcodPedido(pedido.CodPedido);

                  if (compro != null)
                  {
                      MessageBox.Show("Pedido ya ha sido facturado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      this.Cursor = Cursors.Default;
                      return;
                  }*/


                if (pedido.Estado == 2)
                {
                    MessageBox.Show("Pedido ya ha sido facturado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }



                if (promo == null)
                {
                    MessageBox.Show("Promotor es nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (cbMoneda == null || cbMoneda.Items.Count == 0)
                {
                    MessageBox.Show("Escoja moneda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (cbSerie == null || cbSerie.Items.Count == 0)
                {
                    MessageBox.Show("Escoja serie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (promo != null)
                {
                    if (promo.Dni.Length < 8)
                    {
                        MessageBox.Show("Cliente tiene N° Documento Identidad Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }


                if (dgvdetalle.Rows.Count > 0)
                {

                    DetalleComprobante detallecomprobante = null;

                    comprobante = new Comprobantee();

                    comprobante.CodPedido = pedido.CodPedido;
                    comprobante.CodTransaccion = 7; //ventainterna
                    comprobante.CodTipoComprobante = Convert.ToInt32(cbTDocumento.SelectedValue);

                    cbSerie_SelectionChangeCommitted(null, null);

                    comprobante.Scomprobante = cbSerie.Text + "-" + txtCorrelativo.Text;


                    comprobante.Codserie = Convert.ToInt32(cbSerie.SelectedValue);
                    comprobante.Serie = cbSerie.Text;
                    comprobante.Codpromotor = promo.CodPromotor;
                    comprobante.Codmoneda = Convert.ToInt32(cbMoneda.SelectedValue);
                    comprobante.Tipocambio = Convert.ToDecimal(txttipocambio.Text);
                    comprobante.Descripcion = "";
                    comprobante.Fechaemision = dtpFecha.Value;
                    comprobante.Descuento = 0;
                    comprobante.Subtotal = Convert.ToDecimal(txtsubtotal.Text);
                    comprobante.Igv = Convert.ToDecimal(txtIgv.Text);
                    comprobante.Total = Convert.ToDecimal(txttotal.Text);
                    comprobante.Formapago = 6; //contado
                    comprobante.Codusuario = Session.CodUsuario;
                    comprobante.Codempresa = 1;
                    comprobante.Abonado = 0;
                    comprobante.Pendiente = comprobante.Total;


                    comprobante.Comprobanterelacionado = new Comprobantee();
                    comprobante.Comprobanterelacionado.CodComprobante = 0;
                    comprobante.Comprobanterelacionado.Scomprobante = "";
                    comprobante.Scomprobante = cbSerie.Text + "-" + txtCorrelativo.Text;




                    comprobante.Gravadas = Math.Round((dgvdetalle.Rows.Cast<DataGridViewRow>().Where(
                                                                x => x.Cells["timpuesto"].Value.ToString() == "10"

                                                              ).Select(x => decimal.Parse(x.Cells["precioreal"].Value.ToString())).Sum()), 2);

                    comprobante.Exoneradas = Math.Round((dgvdetalle.Rows.Cast<DataGridViewRow>().Where(
                                                                    x => x.Cells["timpuesto"].Value.ToString() == "20"

                                                                  ).Select(x => decimal.Parse(x.Cells["precioreal"].Value.ToString())).Sum()), 2);

                    comprobante.Inafectas = Math.Round((dgvdetalle.Rows.Cast<DataGridViewRow>().Where(
                                                                     x => x.Cells["timpuesto"].Value.ToString() == "30"

                                                                   ).Select(x => decimal.Parse(x.Cells["precioreal"].Value.ToString())).Sum()), 2);

                    comprobante.Gratuitas = Math.Round((dgvdetalle.Rows.Cast<DataGridViewRow>().Where(
                                                                     x => x.Cells["timpuesto"].Value.ToString() == "21"

                                                                   ).Select(x => decimal.Parse(x.Cells["precioreal"].Value.ToString())).Sum()), 2);


                    for (int i = 0; i < dgvdetalle.Rows.Count; i++)
                    {
                        detallecomprobante = new DetalleComprobante();


                        detallecomprobante.Unidadingresada = Convert.ToInt32(dgvdetalle.Rows[i].Cells["unidad"].Value.ToString());
                        detallecomprobante.CodProducto = Convert.ToInt32(dgvdetalle.Rows[i].Cells["codproducto"].Value.ToString());
                        detallecomprobante.Descripcion = dgvdetalle.Rows[i].Cells["producto"].Value.ToString();

                        detallecomprobante.Cantidad = Convert.ToInt32(dgvdetalle.Rows[i].Cells["cantidad"].Value.ToString());
                        detallecomprobante.Preciounitario = Convert.ToDecimal(dgvdetalle.Rows[i].Cells["precio"].Value.ToString());
                        detallecomprobante.Total = Convert.ToDecimal(dgvdetalle.Rows[i].Cells["preciost"].Value.ToString());

                        //var result = (detallecomprobante.Total / Convert.ToDecimal(1.18)).ToString("#.0000");
                        // var result=TruncateDecimal(detallecomprobante.Total / Convert.ToDecimal(1.18),4);
                        //detallecomprobante.Subtotal = Convert.ToDecimal(result);

                        detallecomprobante.Subtotal = (detallecomprobante.Total / Convert.ToDecimal(1.18));
                        detallecomprobante.Igv = (detallecomprobante.Total - detallecomprobante.Subtotal);

                        detallecomprobante.Descuento1 = 0;
                        detallecomprobante.Tipoimpuesto = Convert.ToInt32(dgvdetalle.Rows[i].Cells["timpuesto"].Value.ToString());


                        /*
                        switch (dgvdetalle.Rows[i].Cells["timpuesto"].Value.ToString())
                        {
                            case :"GRAVADO"
                                detallecomprobante.Tipoimpuesto = 10;
                                break;
                            case "EXONERADO":
                                detallecomprobante.Tipoimpuesto = 20;
                                break;
                            case "INAFECTO":
                                detallecomprobante.Tipoimpuesto = 30;
                                break;
                            case "GRATUITA":
                                detallecomprobante.Tipoimpuesto = 21;
                                break;
                        }*/


                        detallecomprobante.Anulado = 0;
                        detallecomprobante.Codusuario = Session.CodUsuario;

                        comprobante.ListaDetalleComprobante.Add(detallecomprobante);
                    }


                    if (comprobante.Formapago != 6)
                    {
                        comprobante.Formapago = 2;
                    }

                    if (cantidaddetalle == dgvdetalle.Rows.Count)
                    {
                        estadopedido = 2;
                    }
                    else
                    {
                        estadopedido = 1;
                    }

                    comprobante.Estadopedido = estadopedido;

                    rpta = CComprobante.insertar(comprobante);

                    if (rpta == true)
                    {
                        btnGuardar.Enabled = false;
                        btnPago.Enabled = true;
                        MessageBox.Show("Datos guardados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        Puntos punto = new Puntos();
                        punto.Promotor = new Promotor();
                        punto.Promotor.CodPromotor = promo.CodPromotor;
                        punto.Puntaje = comprobante.Total;
                        punto.CodUsuario = Session.CodUsuario;

                        int ola = CPunto.guardar(punto);

                        respuesta = 1;

                        frmF form = (frmF)Application.OpenForms["frmF"];
                        form.respuesta = respuesta;
                        form.limpiar();
                        pedido1 = null;
                        promo2 = null;


                        //FACTURACION ELECTRONICA

                        //conex.GeneraXML(promo, comprobante, comprobante.ListaDetalleComprobante);
                        await facturacion.GeneraDocumento(promo, comprobante, comprobante.ListaDetalleComprobante);
                        firmadigital = facturacion.LogoEmp;

                        btnImprimir_Click();

                    }
                    else
                    {
                        btnGuardar.Enabled = true;
                        MessageBox.Show("Error al guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Cursor = Cursors.Default;
                        return;
                    }



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }


        public decimal TruncateDecimal(decimal value, int precision)
        {
            decimal step = (decimal)Math.Pow(10, precision);
            decimal tmp = Math.Truncate(step * value);
            return tmp / step;
        }



        private void btnImprimir_Click()
        {
            try
            {

                this.Cursor = Cursors.WaitCursor;

                DataSet jes = new DataSet();
                frmRptFactura frm = new frmRptFactura();
                CRFacturaFomatoContinuo rpt = new CRFacturaFomatoContinuo();

                string NombreImpresora = impresora_xdefecto();

                String nombrearchivo = "";

                //venta = AdmVenta.BuscaFacturaVenta(Convert.ToInt32(venta.CodFacturaVenta), frmLogin.iCodAlmacen);
                Comprobantee comp = CComprobante.buscacomprobante(Convert.ToInt32(comprobante.CodComprobante));

                if (comp.CodTipoComprobante == 1)
                {
                    nombrearchivo = Session.Ruc + "-03-" + comp.Scomprobante;
                }
                else if (comp.CodTipoComprobante == 2)
                {
                    nombrearchivo = Session.Ruc + "-01-" + comp.Scomprobante;
                }

                firmadigital = CargarImagen(@"C:\DOCUMENTOS-" + Session.Ruc + "\\CERTIFIK\\QR\\" + nombrearchivo + ".jpeg");
                rpt.Load("CRFacturaFomatoContinuo.rpt");
                jes = clsReporteFactura.ReporteFactura2(Convert.ToInt32(comp.CodComprobante));
                foreach (DataTable mel in jes.Tables)
                {
                    foreach (DataRow changesRow in mel.Rows)
                    {

                        changesRow["firma"] = firmadigital;
                    }
                    if (mel.HasErrors)
                    {
                        foreach (DataRow changesRow in mel.Rows)
                        {
                            if ((int)changesRow["Item", DataRowVersion.Current] > 100)
                            {
                                changesRow.RejectChanges();
                                changesRow.ClearErrors();
                            }
                        }
                    }
                }
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



        private void cboTiempoIMpuesto_SelectionChangeCommitted(object sender, EventArgs e)
        {


        }

        private void cboTiempoIMpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {

                string tipo = "";
                if (cboTiempoIMpuesto.Items.Count > 0)
                {
                    tipo = cboTiempoIMpuesto.Text;
                }
                if (dgvdetalle.Rows.Count > 0)
                {

                    for (int i = 0; i < dgvdetalle.Rows.Count; i++)
                    {
                        dgvdetalle.Rows[i].Cells["timpuesto"].Value = cboTiempoIMpuesto.SelectedValue;
                        dgvdetalle.Refresh();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;

        }

        public static Byte[] CargarImagen(string rutaArchivo)
        {
            if (rutaArchivo != "")
            {
                try
                {
                    FileStream Archivo = new FileStream(rutaArchivo, FileMode.Open);//Creo el archivo
                    BinaryReader binRead = new BinaryReader(Archivo);//Cargo el Archivo en modo binario
                    Byte[] imagenEnBytes = new Byte[(Int64)Archivo.Length]; //Creo un Array de Bytes donde guardare la imagen
                    binRead.Read(imagenEnBytes, 0, (int)Archivo.Length);//Cargo la imagen en el array de Bytes
                    binRead.Close();
                    Archivo.Close();
                    return imagenEnBytes;//Devuelvo la imagen convertida en un array de bytes
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return new Byte[0];
                }
            }
            return new byte[0];
        }

        public void cargarpedido()
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {

                dgvdetalle.DataSource = null;
                pedido = CPedido.buscar(pedido1.CodPedido);

                if (pedido != null)
                {
                    txtsubtotal.Text = pedido.Subtotal.ToString();
                    txtIgv.Text = pedido.Igv.ToString();
                    txttotal.Text = pedido.Total.ToString();

                    cargarpromotor(pedido.CodPromotor);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }



        public void cargarpromotor(int codpromotor)
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {

                promo = CPromotor.buscarxcodigo(codpromotor);
                txtcodcliente.Text = promo.CodPromotor.ToString();
                txtcliente.Text = promo.Nombrecompleto;
                txtDireccion.Text = promo.Direccion;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        public void cargardetallepedido()
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {
                dgvdetalle.DataSource = null;
                dgvdetalle.DataSource = CDetallePedido.listardetalle(pedido1.CodPedido);
                cantidaddetalle = dgvdetalle.Rows.Count;

                if (cantidaddetalle > 0)
                {
                    btnEliminar.Enabled = true;
                }

                foreach (DataGridViewRow row in dgvdetalle.Rows)
                {
                    DataGridViewComboBoxCell a = (DataGridViewComboBoxCell)(row.Cells["unidad"]);
                    a.DataSource = CUnidadMedida.MuestraUnidades(); ;
                    a.DisplayMember = "descripcion";
                    a.ValueMember = "codUnidadMedida";
                    a.Value = 1;

                    DataGridViewComboBoxCell b = (DataGridViewComboBoxCell)(row.Cells["timpuesto"]);
                    b.DataSource = listatipoimpuesto;
                    b.DisplayMember = "descripcion";
                    b.ValueMember = "codigo";
                    b.Value = 10;
                }

                lbregistro.Text = dgvdetalle.Rows.Count + " registros";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        public void cargarmoneda()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                cbMoneda.DataSource = null;
                cbMoneda.DataSource = CMoneda.CargaMonedasHabiles();
                cbMoneda.ValueMember = "codMoneda";
                cbMoneda.DisplayMember = "descripcion";
                cbMoneda.SelectedIndex = 0;

                cbMoneda_SelectionChangeCommitted(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        public void cargarformapago()
        {


            this.Cursor = Cursors.WaitCursor;
            try
            {
                cbFormaPago.DataSource = null;
                cbFormaPago.DataSource = CPago.CargaFormaPagos();
                cbFormaPago.ValueMember = "codFormaPago";
                cbFormaPago.DisplayMember = "descripcion";
                cbFormaPago.SelectedIndex = 0;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }


        public void cargartipoimpuesto()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                listatipoimpuesto = new List<dynamic>
                {

                    new {codigo=10,descripcion="GRAVADO"},
                    new {codigo=20,descripcion="EXONERADO"},
                    new {codigo=30,descripcion="INAFECTO"},
                    new {codigo=21,descripcion="GRATUITA"}

                };

                cboTiempoIMpuesto.DataSource = listatipoimpuesto;
                cboTiempoIMpuesto.ValueMember = "codigo";
                cboTiempoIMpuesto.DisplayMember = "descripcion";

                cboTiempoIMpuesto.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        public void cargartipocomprobante()
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {
                cbTDocumento.DataSource = null;
                cbTDocumento.DataSource = CTipoComprobante.cargarTipoComprobante();
                cbTDocumento.ValueMember = "codtipocomprobante";
                cbTDocumento.DisplayMember = "nombre";


                if (promo2 != null)
                {
                    switch (promo2.DocumentoIdentidad.Idtipodocumentoidentidad)
                    {
                        case 1:
                            cbTDocumento.SelectedIndex = 0;
                            break;
                        case 2:
                            cbTDocumento.SelectedIndex = 1;
                            break;
                    }
                }

                cbTDocumento_SelectionChangeCommitted(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        private void frmFacturar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cbMoneda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbMoneda != null)
            {
                if (cbMoneda.Items.Count > 0)
                {
                    tipo_cambio();
                }
            }
        }

        public void tipo_cambio()
        {
            TipoCambio tipocambio = CTipoCambio.listartipocambioxmoneda(Convert.ToInt32(cbMoneda.SelectedValue.ToString()), dtpFecha.Value);
            if (tipocambio != null)
            {
                txttipocambio.Text = Math.Round(tipocambio.Compra, 3).ToString();
            }
            else
            {
                txttipocambio.Text = "0.00";
            }
        }

        private void cbTDocumento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbTDocumento != null)
            {
                if (cbTDocumento.Items.Count > 0)
                {
                    cargar_serie_correlativo();
                }
            }
        }

        public void cargar_serie_correlativo()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                listaseries = CSerie.cargarSeriexTipocomprobante(Convert.ToInt32(cbTDocumento.SelectedValue.ToString()));
                cbSerie.DataSource = listaseries;
                cbSerie.ValueMember = "codSerie";
                cbSerie.DisplayMember = "Sserie";

                cbSerie_SelectionChangeCommitted(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void cbSerie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_correlativo();
        }

        public void cargar_correlativo()
        {
            if (cbSerie.SelectedIndex != -1)
            {
                if (listaseries.Count > 0)
                {
                    txtCorrelativo.Text = listaseries[cbSerie.SelectedIndex].Correlativo.ToString().PadLeft(8, '0');
                }
            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            int id = -1;
            try
            {

                Comprobantee compro = CComprobante.buscacomprobantexcodPedido(pedido.CodPedido);

                if (compro == null)
                {
                    MessageBox.Show("Primero debe registrar el comprobante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }


                id = CCaja.buscar_caja_abierta(Session.CodUsuario);

                if (id > 0)
                {
                    caja = new Caja()
                    {
                        Codcaja = id
                    };

                    frmCancelarPago frm_cp = new frmCancelarPago(compro);
                    frm_cp.caja = caja;
                    frm_cp.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Aperture caja", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {


                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el producto ?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {

                    if (dgvdetalle.Rows.Count > 1)
                    {
                        dgvdetalle.Rows.Remove(dgvdetalle.CurrentRow);
                        CalculaTotales();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;
                return;
            }
            this.Cursor = Cursors.Default;
        }



        private void CalculaTotales()
        {

            Double valor = 0;
            Double igvt = 0;
            Double preciot = 0;



            foreach (DataGridViewRow row in dgvdetalle.Rows)
            {

                preciot = preciot + Convert.ToDouble(row.Cells["preciost"].Value);

            }
            // }
            //}


            valor = Convert.ToDouble(Math.Round((preciot / 1.18), 2));
            igvt = Convert.ToDouble(Math.Round((valor * 0.18), 2));

            txtsubtotal.Text = String.Format("{0:#,##0.00}", valor);
            txtIgv.Text = String.Format("{0:#,##0.00}", igvt);
            txttotal.Text = String.Format("{0:#,##0.00}", preciot);



            pedido.Subtotal = Convert.ToDecimal(valor);
            pedido.Igv = Convert.ToDecimal(igvt);
            pedido.Total = Convert.ToDecimal(preciot);





        }

        private void txtcodcliente_KeyDown(object sender, KeyEventArgs e)
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
                        //pro = null;
                        frmListadoPromotores form = new frmListadoPromotores();
                        form.filtro = 1;

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            promo = form.promotor;

                            if (promo != null)
                            {
                                txtcodcliente.Text = promo.CodPromotor.ToString();
                                txtcliente.Text = promo.Nombrecompleto;
                            }
                            else
                            {
                                txtcodcliente.Focus();
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
    }
}
