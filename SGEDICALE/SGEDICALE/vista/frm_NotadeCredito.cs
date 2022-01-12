using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;
using SGEDICALE.reportes;
using System.IO;
using System.Drawing.Printing;
using SGEDICALE.reportes.clsReportes;
namespace SGEDICALE.vista
{
    public partial class frm_NotadeCredito : DevComponents.DotNetBar.Office2007Form
    {

        private Usuario usuario = null;
        private List<Serie> listaserie = null;
        private List<DiscrepanciaNotaCredito> lista_discrepancia_ncc = null;

        public Comprobantee comprobantee = null;
        private Comprobantee notacredito = null;

        private DataTable ticketfacturar = null;

        SGEDICALE.SunatFacElec.Facturacion facturacion = new SunatFacElec.Facturacion();
        Promotor promo = null;
        public int numdiscrepancia = 0;

        public int cantidadestatica = 0;
        Promotor pro = null;
        public int GLOSA = 0;

        public Byte[] firmadigital
        {
            get; set;
        }

        public frm_NotadeCredito()
        {
            InitializeComponent();
        }

        private void frm_NotadeCredito_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dtpFecha.Value = DateTime.Now.Date;
            usuario = new Usuario();
            usuario.Usuarioid = Session.CodUsuario;

            cargartipocomprobante();
            listar_discrepancia_ncc();


            cargarmoneda();
            //cargartipoimpuesto();
            //cargarformapago();

            if (comprobantee != null)
            {
                listar_detalle_notacredito_xidcomprobante();


                dtpFecha.Enabled = false;
                cbTDocumento.Enabled = false;
                cbSerie.Enabled = false;
                cbMotivo.Enabled = false;
                txt_descripcion.Enabled = false;
                cboMoneda.Enabled = false;

                btnGuardar.Enabled = false;
                btnnuevo.Enabled = false;
                btnEliminar.Enabled = false;
                btnImprimir.Visible = true;

            }
            else
            {
                btnGuardar.Enabled = true;
                btnnuevo.Enabled = true;
                btnImprimir.Visible = false;
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


                //cboMoneda_SelectionChangeCommitted(null, null);

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
                //lista_discrepancia_ncc = CDiscrepanciaNotaCredito.listar_discrepancia_ncc();
                cbMotivo.DataSource = null;
                cbMotivo.DataSource = CDiscrepanciaNotaCredito.listar_discrepancia_ncc();
                cbMotivo.ValueMember = "Iddiscrepancia";
                cbMotivo.DisplayMember = "descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
        }

        public void cargartipocomprobante()
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {
                cbTDocumento.DataSource = null;
                cbTDocumento.DataSource = CTipoComprobante.cargarTipoComprobanteCredito();
                cbTDocumento.ValueMember = "codtipocomprobante";
                cbTDocumento.DisplayMember = "nombre";

                cargarseries();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }


        public void cargarseries()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (cbTDocumento.Items.Count > 0)
                {
                    if (cbTDocumento.Text != "")
                    {
                        if (pro != null)
                        {
                            switch (pro.DocumentoIdentidad.Idtipodocumentoidentidad)
                            {
                                case 1:
                                    cbTDocumento.SelectedIndex = 0;
                                    break;
                                case 2:
                                    cbTDocumento.SelectedIndex = 1;
                                    break;
                            }
                        }

                        cbSerie.DataSource = null;
                        cbSerie.DataSource = CSerie.cargarSeriexTipocomprobante(Convert.ToInt32(cbTDocumento.SelectedValue));
                        cbSerie.ValueMember = "codSerie";
                        cbSerie.DisplayMember = "Sserie";

                        cbSerie.SelectedIndex = -1;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        private void cbSerie_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {

                if (cbSerie.SelectedIndex != -1)
                {
                    if (cbSerie.Items.Count > 0)
                    {
                        if (Convert.ToInt32(cbSerie.SelectedValue) > 0)
                        {
                            Serie serie = CSerie.cargarCorrelativo(Convert.ToInt32(cbTDocumento.SelectedValue), Convert.ToInt32(cbSerie.SelectedValue));

                            if (serie != null)
                            {
                                txtCorrelativo.Text = serie.Correlativo.ToString().PadLeft(8, '0').ToString();

                                if (txtCorrelativo.Text != "" && dgvdetalle.Rows.Count > 0)
                                {
                                    btnGuardar.Enabled = true;
                                }
                                else
                                {
                                    btnGuardar.Enabled = false;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;

        }

        private void cbTDocumento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargarseries();
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
                        pro = null;
                        frmListadoPromotores form = new frmListadoPromotores();

                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            pro = form.promotor;

                            if (pro != null)
                            {
                                txtCod.Text = pro.CodPromotor.ToString();
                                txtpromotor.Text = pro.Nombrecompleto;

                                dgvdetalle.DataSource = null;
                                txtdocref.Focus();
                                txtdocref.Clear();

                                cargarseries();

                            }
                            else
                            {
                                txtCod.Focus();
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

        private void txtdocref_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Promotor promotor = null;

            try
            {

                if (e.KeyCode == Keys.F1)
                {
                    if (Application.OpenForms["frm_ComprobantesPorCliente"] != null)
                    {
                        Application.OpenForms["frm_ComprobantesPorCliente"].Activate();
                    }
                    else
                    {
                        promotor = new Promotor();
                        promotor.CodPromotor = Convert.ToInt32(txtCod.Text);

                        frm_ComprobantesPorCliente frm_comprobante = new frm_ComprobantesPorCliente();
                        frm_comprobante.cliente = promotor;

                        if (frm_comprobante.ShowDialog() == DialogResult.OK)
                        {
                            comprobantee = frm_comprobante.comprobantee;

                            if (comprobantee != null)
                            {
                                txtdocref.Text = comprobantee.Scomprobante;
                                txtcodComprobante.Text = comprobantee.CodComprobante.ToString();

                                listar_detalle_comprobante_xidcomprobante();

                                if (txtCorrelativo.Text != "" && dgvdetalle.Rows.Count > 0)
                                {
                                    btnGuardar.Enabled = true;
                                }
                                else
                                {
                                    btnGuardar.Enabled = false;
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        public void listar_detalle_comprobante_xidcomprobante()
        {

            try
            {
                dgvdetalle.AutoGenerateColumns = false;

                ticketfacturar = CComprobante.listar_detalle_comprobante_xidcomprobante(comprobantee);
                comprobantee = CComprobante.buscacomprobante(comprobantee.CodComprobante);

                if (comprobantee != null && ticketfacturar != null)
                {

                    txtsubtotal.Text = comprobantee.Subtotal.ToString();
                    txtIgv.Text = comprobantee.Igv.ToString();
                    txttotal.Text = comprobantee.Total.ToString();


                    cboMoneda.SelectedValue = comprobantee.Codmoneda;
                    cargarpromotor(comprobantee.Codpromotor);


                    if (ticketfacturar.Rows.Count > 0)
                    {
                        dgvdetalle.DataSource = ticketfacturar;
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


        public void listar_detalle_notacredito_xidcomprobante()
        {

            try
            {
                dgvdetalle.AutoGenerateColumns = false;

                ticketfacturar = CComprobante.listar_detalle_comprobante_xidcomprobante(comprobantee);
                comprobantee = CComprobante.buscacomprobante(comprobantee.CodComprobante);

                if (comprobantee != null && ticketfacturar != null)
                {

                    txtsubtotal.Text = comprobantee.Subtotal.ToString();
                    txtIgv.Text = comprobantee.Igv.ToString();
                    txttotal.Text = comprobantee.Total.ToString();


                    cboMoneda.SelectedValue = comprobantee.Codmoneda;

                    cbSerie.SelectedValue = comprobantee.Codserie;
                    txtdocref.Text = comprobantee.Documentoreferencia;
                    cbTDocumento.SelectedValue = comprobantee.CodTipoComprobante;
                    txt_descripcion.Text = comprobantee.Descripcion;
                    txtCorrelativo.Text = comprobantee.Scomprobante.Substring(5, 8);

                    promo = CPromotor.buscarxcodigo(comprobantee.Codpromotor);

                    if (promo != null)
                    {
                        txtCod.Text = promo.CodPromotor.ToString();
                        txtpromotor.Text = promo.Nombrecompleto;
                    }

                    if (ticketfacturar.Rows.Count > 0)
                    {
                        dgvdetalle.DataSource = ticketfacturar;
                        lbregistro.Text = dgvdetalle.Rows.Count + " registros.";

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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }


        private void cbMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMotivo.Items.Count > 0)
            {
                if (cbMotivo.Text != "")
                {
                    if (cbMotivo.Text == "ANULACIÓN DE OPERACIÓN")
                    {
                        btnEliminar.Enabled = false;
                    }

                    if (cbMotivo.Text == "DEVOLUCIÓN POR ITEM")
                    {
                        btnEliminar.Enabled = true;
                    }

                    if (cbMotivo.Text == "DEVOLUCIÓN TOTAL")
                    {
                        btnEliminar.Enabled = false;
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
                if (dgvdetalle.Rows.Count > 0 && txtCorrelativo.Text != "")
                {
                    if (comprobantee != null)
                    {

                        if (comprobantee.Estado == 1)
                        {
                            Comprobantee co = CComprobante.buscarComprobanteCredito(comprobantee);

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
                            MessageBox.Show("Comprobante se encuentra Anulado !!!", "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Cursor = Cursors.Default;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Comprobante no puede ser nulo !!!", "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                    }
                }
                else
                {
                    MessageBox.Show("Complete todo los campos !!!", "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema" + ex.Message, "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }


            this.Cursor = Cursors.Default;

        }

        public void registrar_comprobante_ncc()
        {

            string correlativocredito;
            DetalleComprobante detallecomprobante = null;
            bool rpta = false;

            try
            {

                if (comprobantee == null)
                {
                    MessageBox.Show("Comprobante no puede ser nulo", "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Default;
                    return;
                }

                cbSerie_SelectionChangeCommitted(null, null);

                correlativocredito = cbSerie.Text + "-" + txtCorrelativo.Text;

                Comprobantee nota = CComprobante.buscarNotaCredito(correlativocredito);

                if (nota != null)
                {
                    MessageBox.Show("Ya existe una Nota de Crédito con ese correlativo:" + txtCorrelativo.Text, "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }


                //Repositorio repo = CRepositorio.buscarComprobante(comprobantee);
                Repositorio repo = CRepositorio.buscarComprobanteNotaCredito(comprobantee);

                if (repo == null)
                {
                    MessageBox.Show("Comprobante no se encuentra en el repositorio", "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (repo.Estadosunat != "0")
                {
                    MessageBox.Show("Primero debe de enviar el comprobante a sunat", "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (cbSerie.Text == "")
                {
                    MessageBox.Show("Seleccione una serie", "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }


                Serie serie = new Serie();

                //lista_serie = CSerie.listarseries();
                TipoCambio tipocambio = CTipoCambio.listartipocambioxmoneda(Convert.ToInt32(cboMoneda.SelectedValue.ToString()), dtpFecha.Value);

                if (tipocambio == null)
                {
                    MessageBox.Show("Ingrese tipo de cambio", "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Default;
                    return;
                }


                if (Convert.ToDecimal(txttotal.Text)> comprobantee.Total)
                {
                    MessageBox.Show("Monto pasa el total del comprobante", "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Default;
                    return;
                }

                //correlativocredito = txtdocref.Text;

                if (cbMotivo.Text == "ANULACIÓN DE OPERACIÓN")
                {
                    notacredito = new Comprobantee
                    {

                        CodPedido = comprobantee.CodPedido,
                        Fechaemision = CComprobante.listar_fecha_actual(),
                        CodTipoComprobante = Convert.ToInt32(cbTDocumento.SelectedValue),
                        Codserie = Convert.ToInt32(cbSerie.SelectedValue),
                        Codpromotor = comprobantee.Codpromotor,
                        CodTransaccion = 20, //NOTA DE CREDITO VENTA
                        Descripcion = txt_descripcion.Text,
                        Codmoneda = comprobantee.Codmoneda,
                        Descuento = comprobantee.Descuento,
                        Subtotal = comprobantee.Subtotal,
                        Igv = comprobantee.Igv,
                        Total = comprobantee.Total,
                        Gravadas = comprobantee.Gravadas,
                        Exoneradas = comprobantee.Exoneradas,
                        Inafectas = comprobantee.Inafectas,
                        Gratuitas = comprobantee.Gratuitas,
                        Tipocambio = tipocambio.Compra,
                        Serie = cbSerie.Text,
                        Scomprobante = correlativocredito,
                        Formapago = comprobantee.Formapago,

                        Comprobanterelacionado = comprobantee,
                        Coddiscrepancia = Convert.ToInt32(cbMotivo.SelectedValue)
                    };

                }
                else
                {


                    notacredito = new Comprobantee
                    {

                        CodPedido = comprobantee.CodPedido,
                        Fechaemision = CComprobante.listar_fecha_actual(),
                        CodTipoComprobante = Convert.ToInt32(cbTDocumento.SelectedValue),
                        Codserie = Convert.ToInt32(cbSerie.SelectedValue),
                        Codpromotor = comprobantee.Codpromotor,
                        CodTransaccion = 20, //NOTA DE CREDITO VENTA
                        Descripcion = txt_descripcion.Text,
                        Codmoneda = comprobantee.Codmoneda,
                        Descuento = comprobantee.Descuento,
                        Subtotal = Convert.ToDecimal(txtsubtotal.Text),
                        Igv = Convert.ToDecimal(txtIgv.Text),
                        Total = Convert.ToDecimal(txttotal.Text),
                        Gravadas = Convert.ToDecimal(txtsubtotal.Text),
                        Exoneradas = 0,
                        Inafectas = 0,
                        Gratuitas = 0,
                        Tipocambio = tipocambio.Compra,
                        Serie = cbSerie.Text,
                        Scomprobante = correlativocredito,
                        Formapago = comprobantee.Formapago,

                        Comprobanterelacionado = comprobantee,
                        Coddiscrepancia = Convert.ToInt32(cbMotivo.SelectedValue)
                    };
                }

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

                notacredito.Codusuario = Session.CodUsuario;

                rpta = CComprobante.insertar(notacredito);

                facturacion.numdiscrepancia = Convert.ToInt32(cbMotivo.SelectedValue);
                facturacion.DatosNCredito(promo, notacredito, notacredito.ListaDetalleComprobante);

                if (rpta == true)
                {
                    MessageBox.Show("Registro correcto", "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Imprimir(notacredito);

                    btnGuardar.Enabled = false;
                    btnEliminar.Enabled = false;
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    MessageBox.Show("Error al registrar", "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Default;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Se encontro el siguiente problema" + ex.Message, "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;

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


        private void Imprimir(Comprobantee nc)
        {
            try
            {

                this.Cursor = Cursors.WaitCursor;

                DataSet jes = new DataSet();
                frmRptNotaContinuo frm = new frmRptNotaContinuo();
                CRCreditoFomatoContinuo rpt = new CRCreditoFomatoContinuo();

                string NombreImpresora = impresora_xdefecto();

                String nombrearchivo = "";

                nombrearchivo = Session.Ruc + "-07-" + nc.Scomprobante;

                firmadigital = CargarImagen(@"C:\DOCUMENTOS-" + Session.Ruc + "\\CERTIFIK\\QR\\" + nombrearchivo + ".jpeg");
                rpt.Load("CRCreditoFomatoContinuo.rpt");
                jes = clsReporteFactura.ReportNotaCreditoVenta(Convert.ToInt32(nc.CodComprobante), 1);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                if (dgvdetalle.Rows.Count > 1)
                {
                    dgvdetalle.Rows.Remove(dgvdetalle.CurrentRow);
                    CalculaTotales();

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


            /*
            if (dgvdetalle.CurrentCell != null)
            {

                if (dgvdetalle.CurrentCell.RowIndex != -1)
                {*/

            foreach (DataGridViewRow row in dgvdetalle.Rows)
            {
                valor = valor + Convert.ToDouble(row.Cells["valorventa"].Value);
                igvt = igvt + Convert.ToDouble(row.Cells["igv"].Value);
                preciot = preciot + Convert.ToDouble(row.Cells["precioventa"].Value);

            }
            // }
            //}

            txtsubtotal.Text = String.Format("{0:#,##0.00}", valor);
            txtIgv.Text = String.Format("{0:#,##0.00}", igvt);
            txttotal.Text = String.Format("{0:#,##0.00}", preciot);


        }

        private void dgvdetalle_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //CalculaTotales();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            try
            {

                comprobantee = null;
                dgvdetalle.DataSource = null;
                txtdocref.Clear();
                txtCod.Clear();
                txtpromotor.Clear();
                txt_descripcion.Text = "";


                cbSerie_SelectionChangeCommitted(null, null);


                txtsubtotal.Text = "0.00";
                txtIgv.Text = "0.00";
                txttotal.Text = "0.00";

                btnGuardar.Enabled = true;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;
                return;
            }
            this.Cursor = Cursors.Default;
        }

        private void cbTDocumento_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                DataSet jes = new DataSet();
                frmRptFactura frm = new frmRptFactura();
                CRFacturaFomatoContinuo rpt = new CRFacturaFomatoContinuo();

                if (comprobantee != null)
                {

                    if (comprobantee.CodComprobante == 0)
                    {
                        MessageBox.Show("No se encontro un comprobante", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                        return;
                    }

                }


                Empresa empresa = null;
                string nombreArchivo = "";
                empresa = CEmpresa.CargaEmpresa();

                nombreArchivo = empresa.Ruc + "-07" + "-" + comprobantee.Scomprobante;
                String RutaArch = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\NOTAS CREDITO\\" + nombreArchivo + ".pdf";

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = RutaArch;
                proc.Start();
                proc.Close();



                this.Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema" + ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void frm_NotadeCredito_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cbMotivo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (dgvdetalle.Rows.Count > 0)
            {
                if (Convert.ToString(cbMotivo.SelectedValue) == "2")  //devolucion de producto
                {
                    dgvdetalle.Columns[cantidad.Name].DefaultCellStyle.BackColor = Color.PeachPuff;
                    dgvdetalle.Columns[cantidad.Name].ReadOnly = false;



                    btnClean.Visible = true;
                }
                else
                {
                    dgvdetalle.Columns[cantidad.Name].DefaultCellStyle.BackColor = Color.White;
                    dgvdetalle.Columns[cantidad.Name].ReadOnly = true;

                    dgvdetalle.Columns[preciounitario.Name].ReadOnly = true;
                    dgvdetalle.Columns[producto.Name].ReadOnly = true;

                    btnClean.Visible = false;
                }

                ActiveControl = dgvdetalle;

            }
        }

        private void dgvdetalle_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Double igvsis = 0, impor = 0, imptotal = 0, cant = 0, preuni = 0, valorven = 0, igvT = 0;

                DataGridViewRow row = dgvdetalle.Rows[e.RowIndex];

                if (Convert.ToString(cbMotivo.SelectedValue) == "2")//devolucion or item
                {
                  

                    cant = Convert.ToInt32(row.Cells[cantidad.Name].Value);

                    if (GLOSA == 1)
                    {
                        preuni = Convert.ToDouble(row.Cells[preciounitario.Name].Value);
                        impor = cant * preuni;
                        row.Cells[precioventa.Name].Value = impor;
                        if (dgvdetalle.CurrentRow.Cells[tipoimpuesto.Name].Value.ToString() == "GRAVADO")
                        {
                            igvsis = Convert.ToDouble(Session.Igv);
                            valorven = impor / (1 + igvsis);
                        }
                        else
                        {
                            valorven = impor;
                        }
                        igvT = impor - valorven;
                        row.Cells[valorventa.Name].Value = (impor - igvT).ToString("N4");
                        row.Cells[igv.Name].Value = igvT.ToString("N4");
                        row.Cells[precioventa.Name].Value = impor.ToString("N4");
                    }

                    else
                    {


                        if (cant > 0 && cant < cantidadestatica)
                        {
                            preuni = Convert.ToDouble(row.Cells[preciounitario.Name].Value);
                            impor = cant * preuni;
                            row.Cells[precioventa.Name].Value = impor;
                            if (dgvdetalle.CurrentRow.Cells[tipoimpuesto.Name].Value.ToString() == "GRAVADO")
                            {
                                igvsis = Convert.ToDouble(Session.Igv);
                                valorven = impor / (1 + igvsis);
                            }
                            else
                            {
                                valorven = impor;
                            }
                            igvT = impor - valorven;
                            row.Cells[valorventa.Name].Value = (impor - igvT).ToString("N4");
                            row.Cells[igv.Name].Value = igvT.ToString("N4");
                            row.Cells[precioventa.Name].Value = impor.ToString("N4");
                        }
                        else
                        {

                            dgvdetalle.Rows[e.RowIndex].Cells[cantidad.Name].Value = cantidadestatica;

                            MessageBox.Show("Cantidad no puede ser mayor a la original", "Nota Credito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                this.CalculaTotales();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema" + ex.Message, "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }
        }

        private void dgvdetalle_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridViewTextBoxEditingControl dText = (DataGridViewTextBoxEditingControl)e.Control;

            dText.KeyPress -= new KeyPressEventHandler(dText_KeyPress);
            dText.KeyPress += new KeyPressEventHandler(dText_KeyPress);
        }

        public void dText_KeyPress(object sender, KeyPressEventArgs e)
        {


           if (dgvdetalle.CurrentCell.ColumnIndex != 3)
           {

                if (!Char.IsDigit(e.KeyChar) && !Char.IsNumber(e.KeyChar) && e.KeyChar != (Char)Keys.Back && e.KeyChar != '.')

                {
                    e.Handled = true;
                }

                if (e.KeyChar == ' ')
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
          

            if (e.KeyChar == '.' && (sender as TextBox).Text.Length == 0)
            {
                e.Handled = true;
            }

        }

        private void dgvdetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            /*
            try
            {


                if (e.RowIndex != -1)
                {

                    if(dgvdetalle)

                    cantidadestatica = Convert.ToInt32(dgvdetalle.Rows[e.RowIndex].Cells[cantidad.Name].Value.ToString());


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema" + ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }*/
        }

        private void dgvdetalle_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvdetalle.Rows.Count > 0)
                {
                    if (dgvdetalle.CurrentCell != null)
                    {
                        if (dgvdetalle.CurrentCell.RowIndex != -1)
                        {


                            cantidadestatica = Convert.ToInt32(dgvdetalle.Rows[dgvdetalle.CurrentCell.RowIndex].Cells[cantidad.Name].Value.ToString());

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema" + ex.Message, "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;

            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            GLOSA = 0;
            try
            {
                if (dgvdetalle.Rows.Count > 0)
                {
                    for (int i = 1; i < dgvdetalle.Rows.Count; i++)
                    {

                        dgvdetalle.Rows.RemoveAt(i);
      

                    }

                    dgvdetalle.Columns[preciounitario.Name].ReadOnly = false;
                    dgvdetalle.Columns[producto.Name].ReadOnly = false;
              

                    CalculaTotales();
                }


                GLOSA = 1;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema" + ex.Message, "Nota de Crédito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }
        }
    }
}
