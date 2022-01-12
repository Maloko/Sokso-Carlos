using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;
using SGEDICALE.reportes;
using SGEDICALE.reportes.clsReportes;
using System.Drawing.Printing;
using QRCoder;
using System.IO;

namespace SGEDICALE.vista
{
    public partial class frmVenta : DevComponents.DotNetBar.Office2007Form
    {

        public Byte[] LogoEmp { get; set; }

        private List<Serie> listaseries = null;
        public Pedido pedido1;
        Promotor promo = null;
        Pedido pedido = null;
        public Comprobantee comprobante = null;

        List<dynamic> listatipoimpuesto;
        private DataTable ticketfacturar = null;

        Caja caja = null;
        private bool lectura = false;

        private List<DiscrepanciaNotaCredito> lista_discrepancia_ncc = null;
        private Comprobantee notacredito = null;
        private List<Serie> lista_serie = null;
        private Usuario usuario = null;

        SGEDICALE.SunatFacElec.Facturacion facturacion = new SunatFacElec.Facturacion();


        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            cbTDocumento.Enabled = true;
            btnImprimir.Enabled = true;
            btnPago.Enabled = true;

            dtpFecha.Value = DateTime.Now.Date;

            if (comprobante != null)
            {
                usuario = new Usuario();
                usuario.Usuarioid = Session.CodUsuario;
                listar_detalle_comprobante_xidcomprobante();
                cargarmoneda();
                cargartipoimpuesto();
                cargarformapago();
                cargartipocomprobante();
                listar_discrepancia_ncc();
                lectura = true;

                cbTDocumento.Enabled = false;

                dtpFecha.Enabled = false;
                txtDireccion.ReadOnly = true;
                txtcliente.ReadOnly = true;
                txttipocambio.ReadOnly = true;
                txtCorrelativo.ReadOnly = true;

                cboMoneda.Enabled = false;
                cboTiempoIMpuesto.Enabled = false;
                cbFormaPago.Enabled = false;
                txtcodcliente.ReadOnly = true;
                txt_descripcion.ReadOnly = true;




                if (cbTDocumento.Text.Contains("NOTA DE CREDITO"))
                {

                    btnPago.Enabled = false;
                    ch_notacredito.Checked = true;
                    ch_notacredito.Enabled = false;
                }

            }
            else
            {

                MessageBox.Show("No se encontro comprobante seleccionado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;
                return;

            }


            this.Cursor = Cursors.Default;
        }

        public void listar_detalle_comprobante_xidcomprobante()
        {



            try
            {
                dgvdetalle.AutoGenerateColumns = false;

                ticketfacturar = CComprobante.listar_detalle_comprobante_xidcomprobante(comprobante);
                comprobante = CComprobante.buscacomprobante(comprobante.CodComprobante);

                if (comprobante != null && ticketfacturar != null)
                {

                    txtsubtotal.Text = comprobante.Subtotal.ToString();
                    txtIgv.Text = comprobante.Igv.ToString();
                    txttotal.Text = comprobante.Total.ToString();
                    dtpFecha.Value = comprobante.Fechaemision;
                    txtCorrelativo.Text = comprobante.Scomprobante;


                    cargarpromotor(comprobante.Codpromotor);


                    if (ticketfacturar.Rows.Count > 0)
                    {
                        dgvdetalle.DataSource = ticketfacturar;
                        lbregistro.Text = dgvdetalle.Rows.Count + " registros";
                        dgvdetalle.Refresh();
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


        public void cargarpromotor(int codpromotor)
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {

                promo = CPromotor.buscarxcodigo(codpromotor);

                if (promo != null)
                {

                    txtcodcliente.Text = promo.CodPromotor.ToString();
                    txtcliente.Text = promo.Nombrecompleto;
                    txtDireccion.Text = promo.Direccion;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
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


        public void cargarformapago()
        {


            this.Cursor = Cursors.WaitCursor;
            try
            {
                cbFormaPago.DataSource = null;
                cbFormaPago.DataSource = CPago.CargaFormaPagos();
                cbFormaPago.ValueMember = "codFormaPago";
                cbFormaPago.DisplayMember = "descripcion";
                cbFormaPago.SelectedIndex = 1;

                if (comprobante.Formapago != 0)
                {
                    cbFormaPago.SelectedValue = comprobante.Formapago;
                }

                cbFormaPago.Refresh();

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

                cbTDocumento.SelectedIndex = 0;

                if (comprobante.CodTipoComprobante != 0)
                {
                    cbTDocumento.SelectedValue = comprobante.CodTipoComprobante;
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


        public void cargarmoneda()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                cboMoneda.DataSource = null;
                cboMoneda.DataSource = CMoneda.CargaMonedasHabiles();
                cboMoneda.ValueMember = "codMoneda";
                cboMoneda.DisplayMember = "descripcion";


                if (comprobante.Codmoneda != 0)
                {
                    cboMoneda.SelectedValue = comprobante.Codmoneda;
                }

                cboMoneda_SelectionChangeCommitted(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        private void cbTDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbTDocumento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbTDocumento != null)
            {
                if (cbTDocumento.Items.Count > 0)
                {

                    if (cbTDocumento.Text != "")
                    {
                        cargar_serie_correlativo();
                    }
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
            //cargar_correlativo();
        }

        public void cargar_correlativo()
        {

            if (cbSerie.SelectedIndex != -1)
            {
                if (listaseries.Count > 0)
                {

                    if (cbSerie.Text != "")
                    {
                        //txtCorrelativo.Text = listaseries[cbSerie.SelectedIndex].Correlativo.ToString().PadLeft(8, '0');}

                    }
                }
            }
        }



        public void tipo_cambio()
        {

            if (comprobante.Fechaemision != null)
            {
                TipoCambio tipocambio = CTipoCambio.listartipocambioxmoneda(Convert.ToInt32(cboMoneda.SelectedValue.ToString()), comprobante.Fechaemision);
                if (tipocambio != null)
                {
                    txttipocambio.Text = Math.Round(tipocambio.Compra, 3).ToString();
                }
                else
                {
                    txttipocambio.Text = "0.00";
                }
                

            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                DataSet jes = new DataSet();
                frmRptFactura frm = new frmRptFactura();
                CRFacturaFomatoContinuo rpt = new CRFacturaFomatoContinuo();

                string NombreImpresora = impresora_xdefecto();
                String nombrearchivo = "";


                Empresa emp = CEmpresa.CargaEmpresa();

                if (comprobante != null)
                {

                   
                    if (comprobante.CodComprobante == 0)
                    {
                        MessageBox.Show("No se encontro un comprobante", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                        return;
                    }

                    if (comprobante.Estado == 0)
                    {
                        MessageBox.Show("Comprobante se encuentra Anulado !!!", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }

                if (comprobante.CodTipoComprobante == 1 || comprobante.CodTipoComprobante == 2)
                {

                    if (comprobante.CodTipoComprobante == 1)
                    {
                        nombrearchivo = Session.Ruc + "-03-" + comprobante.Scomprobante;
                    }
                    else if (comprobante.CodTipoComprobante == 2)
                    {
                        nombrearchivo = Session.Ruc + "-01-" + comprobante.Scomprobante;
                    }



                    LogoEmp = CargarImagen(@"C:\DOCUMENTOS-" + emp.Ruc + "\\CERTIFIK\\QR\\" + nombrearchivo + ".jpeg");

                    foreach (DataTable mel in jes.Tables)
                    {
                        foreach (DataRow changesRow in mel.Rows)
                        {
                            changesRow["firma"] = LogoEmp;
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


                    rpt.Load("CRFacturaFomatoContinuo.rpt");
                    jes = clsReporteFactura.ReporteFactura2(Convert.ToInt32(comprobante.CodComprobante));

                    foreach (DataTable mel in jes.Tables)
                    {
                        foreach (DataRow changesRow in mel.Rows)
                        {
                            changesRow["firma"] = LogoEmp;
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
                }

                if (comprobante.CodTipoComprobante == 4)
                {
                    Empresa empresa = null;
                    string nombreArchivo = "";
                    empresa = CEmpresa.CargaEmpresa();

                    nombreArchivo = empresa.Ruc + "-07" + "-" + comprobante.Scomprobante;
                    String RutaArch = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\NOTAS CREDITO\\" + nombreArchivo + ".pdf";

                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = RutaArch;
                    proc.Start();
                    proc.Close();
                }



                this.Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema" + ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                catch
                {
                    return new Byte[0];
                }
            }
            return new byte[0];
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

        private void cboMoneda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboMoneda != null)
            {
                if (cboMoneda.Items.Count > 0)
                {

                    if (cboMoneda.Text != "")
                    {
                        tipo_cambio();
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            DialogResult respuesta = DialogResult.No;

            try
            {
                if (dgvdetalle.Rows.Count > 0)
                {

                    if (ch_notacredito.Checked)
                    {

                        if (comprobante != null)
                        {

                            if (comprobante.Estado == 1)
                            {
                                Comprobantee co = CComprobante.buscarComprobanteCredito(comprobante);

                                if (co != null)
                                {
                                    respuesta = MessageBox.Show("Ya existe una Nota de Crédito relacionada con ese Comprobante .. Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                }
                                else
                                {
                                    respuesta = MessageBox.Show("Está seguro que desea generar una Nota de Credito .. Desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                }

                                if (respuesta == DialogResult.Yes)
                                {

                                    registrar_comprobante_ncc();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Comprobante se encuentra Anulado !!!", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Cursor = Cursors.Default;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Comprobante no puede ser nulo !!!", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Cursor = Cursors.Default;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema" + ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;

        }

        public void registrar_comprobante_ncc()
        {

            int index_tipocomprobante = 0;
            string correlativocredito;
            DetalleComprobante detallecomprobante = null;
            bool rpta = false;

            try
            {

                if (comprobante == null)
                {
                    MessageBox.Show("Comprobante no puede ser nulo", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Default;
                    return;
                }


                Repositorio repo = CRepositorio.buscarComprobante(comprobante);

                if (repo == null)
                {
                    MessageBox.Show("Comprobante no se encuentra en el repositorio", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (repo.Estadosunat != "0")
                {
                    MessageBox.Show("Primero debe de enviar a sunat el comprobante", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }


                Serie serie = new Serie();

                lista_serie = CSerie.listarseries();
                TipoCambio tipocambio = CTipoCambio.listartipocambioxmoneda(Convert.ToInt32(cboMoneda.SelectedValue.ToString()), dtpFecha.Value);

                if (tipocambio == null)
                {
                    MessageBox.Show("Ingrese tipo de cambio", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (comprobante.CodTipoComprobante == 1)
                {
                    index_tipocomprobante = 2;
                }

                if (comprobante.CodTipoComprobante == 2)
                {
                    index_tipocomprobante = 3;
                }

                correlativocredito = lista_serie[index_tipocomprobante].Sserie + "-" + lista_serie[index_tipocomprobante].Correlativo.ToString().PadLeft(8, '0');

                notacredito = new Comprobantee
                {

                    CodPedido = comprobante.CodPedido,
                    Fechaemision = CComprobante.listar_fecha_actual(),
                    CodTipoComprobante = lista_serie[index_tipocomprobante].Codtipocomprobante,
                    Codserie = lista_serie[index_tipocomprobante].CodSerie,
                    Codpromotor = comprobante.Codpromotor,
                    CodTransaccion = 20, //NOTA DE CREDITO VENTA
                    Descripcion = txt_descripcion.Text,
                    Codmoneda = comprobante.Codmoneda,
                    Descuento = comprobante.Descuento,
                    Subtotal = comprobante.Subtotal,
                    Igv = comprobante.Igv,
                    Total = comprobante.Total,
                    Gravadas = comprobante.Gravadas,
                    Exoneradas = comprobante.Exoneradas,
                    Inafectas = comprobante.Inafectas,
                    Gratuitas = comprobante.Gratuitas,
                    Tipocambio = tipocambio.Compra,
                    Serie = comprobante.Serie,
                    Scomprobante = correlativocredito,
                    Formapago = comprobante.Formapago,

                    Comprobanterelacionado = comprobante
                };


                notacredito.Formapago = 6;


                for (int i = 0; i < dgvdetalle.Rows.Count; i++)
                {
                    detallecomprobante = new DetalleComprobante();


                    detallecomprobante.Unidadingresada = Convert.ToInt32(dgvdetalle.Rows[i].Cells["codUnidadMedida"].Value.ToString());
                    detallecomprobante.CodProducto = Convert.ToInt32(dgvdetalle.Rows[i].Cells["codproducto"].Value.ToString());
                    detallecomprobante.Descripcion = dgvdetalle.Rows[i].Cells["producto"].Value.ToString();
                    detallecomprobante.Cantidad = Convert.ToInt32(dgvdetalle.Rows[i].Cells["cantidad"].Value.ToString());
                    detallecomprobante.Preciounitario = Convert.ToDecimal(dgvdetalle.Rows[i].Cells["preciounitario"].Value.ToString());
                    detallecomprobante.Subtotal = Convert.ToDecimal(dgvdetalle.Rows[i].Cells["valorventa"].Value.ToString());
                    detallecomprobante.Igv = Convert.ToDecimal(dgvdetalle.Rows[i].Cells["igv"].Value.ToString());
                    detallecomprobante.Total = Convert.ToDecimal(dgvdetalle.Rows[i].Cells["precioventa"].Value.ToString());
                    detallecomprobante.Descuento1 = 0;

                    detallecomprobante.Tipoimpuesto = Convert.ToInt32(dgvdetalle.Rows[i].Cells["codtipoimpuesto"].Value.ToString());

                    detallecomprobante.Anulado = 0;
                    detallecomprobante.Codusuario = usuario.Usuarioid;

                    notacredito.ListaDetalleComprobante.Add(detallecomprobante);
                }



                rpta = CComprobante.insertar(notacredito);

                facturacion.DatosNCredito(promo, notacredito, notacredito.ListaDetalleComprobante);

                if (rpta == true)
                {
                    MessageBox.Show("Registro correcto", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Error al registrar", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Default;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Se encontro el siguiente problema" + ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

        }


        private void ch_notacredito_CheckedChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnImprimir.Enabled = true;

            if (ch_notacredito.Checked == true)
            {

                if (cbTDocumento.Text.Contains("NOTA DE CREDITO"))
                {
                    btnGuardar.Enabled = false;
                    //btnImprimir.Enabled = false;
                }
            }
            else
            {

                if (cbTDocumento.Text.Contains("NOTA DE CREDITO"))
                {
                    btnGuardar.Enabled = false;
                    //btnImprimir.Enabled = false;
                }

            }
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            int id = -1;
            this.Cursor = Cursors.WaitCursor;

            try
            {

                if (comprobante == null)
                {
                    MessageBox.Show("Primero debe registrar el comprobante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (comprobante.Estado == 0)
                {
                    MessageBox.Show("Comprobante se encuentra Anulado !!!", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    if (comprobante.Pendiente > 0)
                    {
                        comprobante = CComprobante.buscacomprobante(comprobante.CodComprobante);
                    }

                    frmCancelarPago frm_cp = new frmCancelarPago(comprobante);
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

            this.Cursor = Cursors.Default;

        }

        private void frmVenta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Cursor = Cursors.Default;
                this.Close();
            }
        }

        private void lbregistro_Click(object sender, EventArgs e)
        {

        }
    }
}
