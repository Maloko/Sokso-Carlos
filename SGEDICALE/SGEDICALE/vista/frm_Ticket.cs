using SGEDICALE.clases;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SGEDICALE.controlador;
using AForge.Imaging.Filters;
using AForge;
using System.Text.RegularExpressions;
using Ñwinsoft_Ruc;
using Tesseract;
using FinalXML;
using SGEDICALE.reportes;
using System.Drawing.Printing;
using SGEDICALE.reportes.clsReportes;

namespace SGEDICALE.vista
{
    public partial class frm_Ticket : DevComponents.DotNetBar.Office2007Form
    {

        public Promotor promotor { get; set; }
        SunatRuc MyInfoSunat;
        Reniec MyInfoReniec;

        IntRange red = new IntRange(0, 255);
        IntRange green = new IntRange(0, 255);
        IntRange blue = new IntRange(0, 255);

        public Ticket ticket = null;

        DetalleTicket detalleticket = null;
        private Usuario usuario = null;

        private DataTable tablaticket = null;
        Caja caja = null;

        public frm_Ticket()
        {
            InitializeComponent();
        }

        private void frm_Ticket_Load(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            txtDocIdentidad.Focus();
            dtpFecha.Value = DateTime.Now.Date;

            if (ticket != null)
            {
                usuario = new Usuario();
                usuario.Usuarioid = Session.CodUsuario;
                listar_detalle_ticket_xidticket();

                btnAñadir.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = false;

                txtNombreLegalRec.ReadOnly = true;
                txtDocIdentidad.ReadOnly = true;
                txtDirRec.ReadOnly = true;
                dtpFecha.Enabled = true;

                btnImprimir.Visible = true;
           
            }

            this.Cursor = Cursors.Default;

        }


        public void listar_detalle_ticket_xidticket()
        {
            try
            {
                dgvProducto.AutoGenerateColumns = false;

                tablaticket = CTicket.listar_detalle_ticket_xidticket(ticket);
                ticket = CTicket.buscaticket(ticket.CodTicket);

                if (ticket != null && tablaticket != null)
                {

                    
                    txtTotal.Text = ticket.Total.ToString();
                    dtpFecha.Value =  ticket.Fecha;

                    cargarcliente(ticket.CodCliente);


                    if ( tablaticket.Rows.Count > 0)
                    {
                        dgvProducto.DataSource =  tablaticket;
                        dgvProducto.Refresh();
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

        public void cargarcliente(int codcliente)
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {

                /*
                cliente = CCliente.buscar_clientexcodigo(codcliente);

                if (cliente != null)
                {

                    txtNombreLegalRec.Text = cliente.Nombreyapellido;
                    txtDocIdentidad.Text = cliente.Documento;
                    txtDirRec.Text = cliente.Direccion;
                }*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }


        private void frm_Ticket_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyData == Keys.F5)
            {
                btnGuardar_Click(null, null);
            }

            if (e.KeyData == Keys.F6)
            {
                btnNuevo_Click(null, null);
            }

            if (e.KeyData == Keys.F1)
            {
                txtDocIdentidad_KeyDown(this, new KeyEventArgs(Keys.F1));
            }


        }


        private void LeerCaptchaSunat()
        {
            using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                using (var image = new System.Drawing.Bitmap(pbCapchatS.Image))
                {
                    using (var pix = PixConverter.ToPix(image))
                    {
                        using (var page = engine.Process(pix))
                        {
                            var Porcentaje = String.Format("{0:P}", page.GetMeanConfidence());
                            string CaptchaTexto = page.GetText();
                            char[] eliminarChars = { '\n', ' ' };
                            CaptchaTexto = CaptchaTexto.TrimEnd(eliminarChars);
                            CaptchaTexto = CaptchaTexto.Replace(" ", string.Empty);
                            CaptchaTexto = Regex.Replace(CaptchaTexto, "[^a-zA-Z]+", string.Empty);
                            if (CaptchaTexto != string.Empty & CaptchaTexto.Length == 4)
                                txtSunat_Capchat.Text = CaptchaTexto.ToUpper();
                            else
                                CargarImagenSunat();
                        }
                    }
                }

            }

        }

        private void CargarImagenSunat()
        {
            try
            {
                if (MyInfoSunat == null)
                    MyInfoSunat = new SunatRuc();
                this.pbCapchatS.Image = MyInfoSunat.GetCapcha;
                LeerCaptchaSunat();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar con SUNAT, sírvase Ingresar los datos manualmente...");
            }
        }


        private void FiltroInvertir(Bitmap bmp)
        {
            IFilter Filtro = new Invert();
            Bitmap XImage = Filtro.Apply(bmp);
            pbCapchatS.Image = XImage;
        }

        private void ColorFiltros()
        {
            //Red Min - MAX
            red.Min = Math.Min(red.Max, byte.Parse("229"));
            red.Max = Math.Max(red.Min, byte.Parse("255"));
            //Verde Min - MAX
            green.Min = Math.Min(green.Max, byte.Parse("0"));
            green.Max = Math.Max(green.Min, byte.Parse("255"));
            //Azul Min - MAX
            blue.Min = Math.Min(blue.Max, byte.Parse("0"));
            blue.Max = Math.Max(blue.Min, byte.Parse("130"));
            ActualizarFiltro();
        }

        private void ActualizarFiltro()
        {
            ColorFiltering FiltroColor = new ColorFiltering();
            FiltroColor.Red = red;
            FiltroColor.Green = green;
            FiltroColor.Blue = blue;
            IFilter Filtro = FiltroColor;
            Bitmap bmp = new Bitmap(pbCapchatS.Image);
            Bitmap XImage = Filtro.Apply(bmp);
            pbCapchatS.Image = XImage;
        }


        private void AplicacionFiltros()
        {
            Bitmap bmp = new Bitmap(pbCapchatS.Image);
            FiltroInvertir(bmp);
            ColorFiltros();
            Bitmap bmp1 = new Bitmap(pbCapchatS.Image);
            FiltroInvertir(bmp1);
            Bitmap bmp2 = new Bitmap(pbCapchatS.Image);
            FiltroSharpen(bmp2);
        }

        private void FiltroSharpen(Bitmap bmp)
        {
            IFilter Filtro = new Sharpen();
            Bitmap XImage = Filtro.Apply(bmp);
            pbCapchatS.Image = XImage;
        }


        private void CargarImagenReniec()
        {
            try
            {
                if (MyInfoReniec == null)
                    MyInfoReniec = new Reniec();
                this.pbCapchatS.Image = MyInfoReniec.GetCapcha;
                AplicacionFiltros();
                LeerCaptchaReniec();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LeerCaptchaReniec()
        {
            using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                using (var image = new System.Drawing.Bitmap(pbCapchatS.Image))
                {
                    using (var pix = PixConverter.ToPix(image))
                    {
                        using (var page = engine.Process(pix))
                        {
                            var Porcentaje = String.Format("{0:P}", page.GetMeanConfidence());
                            string CaptchaTexto = page.GetText();
                            char[] eliminarChars = { '\n', ' ' };
                            CaptchaTexto = CaptchaTexto.TrimEnd(eliminarChars);
                            CaptchaTexto = CaptchaTexto.Replace(" ", string.Empty);
                            CaptchaTexto = Regex.Replace(CaptchaTexto, "[^a-zA-Z0-9]+", string.Empty);
                            if (CaptchaTexto != string.Empty & CaptchaTexto.Length == 4)
                                txtSunat_Capchat.Text = CaptchaTexto.ToUpper();
                            //else
                            //    CargarImagenReniec();
                        }
                    }
                }
            }
        }

        private void CargaDNI()
        {
            MyInfoReniec.GetInfo(this.txtDocIdentidad.Text, this.txtSunat_Capchat.Text);
            switch (MyInfoReniec.GetResul)
            {
                case Reniec.Resul.Ok:
                    limpiarSunat();
                    txtDocIdentidad.Text = MyInfoReniec.Dni;
                    String apellidos = MyInfoReniec.ApePaterno + " " + MyInfoReniec.ApeMaterno;
                    txtNombreLegalRec.Text = MyInfoReniec.Nombres + " " + apellidos;
                    txtDirRec.Text = "S/D";
                    break;
                case Reniec.Resul.NoResul:
                    limpiarSunat();
                    MessageBox.Show("No Existe DNI");
                    break;
                case Reniec.Resul.ErrorCapcha:
                    limpiarSunat();
                    MessageBox.Show("Ingrese imagen correctamente");
                    break;
                default:
                    MessageBox.Show("Error Desconocido");
                    break;
            }
            //Comentar esta linea para consultar multiples DNI usando un solo captcha.
            CargarImagenReniec();
        }

        private void limpiarSunat()
        {

            txtDocIdentidad.Text = string.Empty;
            txtNombreLegalRec.Text = string.Empty;
            txtDirRec.Text = string.Empty;
            txtSunat_Capchat.Text = string.Empty;
        }


        private void CargaRUC()
        {
            if (this.txtDocIdentidad.Text.Length == 11)
            {
                LeerDatos();
            }
        }

        private void LeerDatos()
        {

            string cadena = "";

            //llamamos a los metodos de la libreria ConsultaReniec...
            MyInfoSunat.GetInfo(this.txtDocIdentidad.Text, this.txtSunat_Capchat.Text);
            switch (MyInfoSunat.GetResul)
            {
                case SunatRuc.Resul.Ok:
                    limpiarSunat();
                    txtDocIdentidad.Text = MyInfoSunat.Ruc;



                    txtDirRec.Text = MyInfoSunat.Direcion;
                    txtNombreLegalRec.Text = MyInfoSunat.RazonSocial;

                    cadena = txtDirRec.Text;
                    cadena = cadena.Replace("</TD>\r\n </TR>\r\n\r\n <TR>", " ");
                    txtDirRec.Text = cadena;
                    //Ciudad(MyInfoSunat.Direcion);
                    // BloqueaDatos();
                    break;
                case SunatRuc.Resul.NoResul:
                    limpiarSunat();
                    MessageBox.Show("No Existe RUC");
                    break;
                case SunatRuc.Resul.ErrorCapcha:
                    limpiarSunat();
                    MessageBox.Show("Ingrese imagen correctamente");
                    break;
                default:
                    MessageBox.Show("Error Desconocido");
                    break;
            }
            //CargarImagenSunat();
        }





        private void txtproducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            int id = -1;

            try
            {
                Cursor = Cursors.WaitCursor;
                if ((int)e.KeyChar == (int)Keys.Enter)
                {
                    if (txtDocIdentidad.Text.Length > 0)
                    {
                        promotor = new Promotor()
                        {
                            Dni = txtDocIdentidad.Text.ToString()
                        };

                   
                        promotor = CPromotor.buscar_promotorxnumerodocumento(promotor);
                       

                        if (promotor != null)
                        {

                            txtDocIdentidad.Text = promotor.Dni;
                            txtNombreLegalRec.Text = promotor.Nombrecompleto;
                            txtDirRec.Text = promotor.Direccion.Trim();

                            if (txtDocIdentidad.Text.Length == 11)
                            {
                                CargarImagenSunat();
                                //CargarImagenReniec();
                            }
                            else
                            {

                            }
                        }

                        /*
                        else
                        {

                            switch (txtDocIdentidad.Text.Length)
                            {
                                
                                //case 8:
                                   // CargarImagenReniec();
                                   // CargaDNI();
                                  //  break;
                                case 11:
                                    CargarImagenSunat();
                                    CargaRUC();
                                    break;

                            }

                            if (txtDocIdentidad.Text.Length > 0 && txtNombreLegalRec.Text.Length > 0 && txtDirRec.Text.Length > 0)
                            {

                                id = CCliente.registrar_cliente(new Cliente()
                                {
                                    Tipodocumentoidentidad = new TipoDocumentoIdentidad()
                                    {
                                        Idtipodocumentoidentidad = 2
                                    },
                                    Nombreyapellido = txtNombreLegalRec.Text,
                                    Documento = txtDocIdentidad.Text,
                                    Direccion = txtDirRec.Text.Trim()
                                });

                                if (id == -1)
                                {
                                    MessageBox.Show("Problemas para registrar promotor...", "Advertencia");
                                }

                            }
                            else
                            {
                                MessageBox.Show("F1 para registrar promotor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }*/
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Consultar al documento. Presionar F1 para registrarlo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void txtDocIdentidad_KeyDown(object sender, KeyEventArgs e)
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
              
                        frmListadoPromotores form = new frmListadoPromotores();
                        promotor = new Promotor();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            promotor = form.promotor;

                            if (promotor != null)
                            {
                                txtDocIdentidad.Text = promotor.Dni.ToString();
                                txtNombreLegalRec.Text = promotor.Nombrecompleto.Trim();
                                txtDirRec.Text = promotor.Direccion.Trim();
                            }
                            else
                            {
                                promotor = null;
                                txtDocIdentidad.Focus();
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

            /*
            if (e.KeyCode == Keys.F1)
            {


                if (Application.OpenForms["frmListadoPromotores"] != null)
                {
                    Application.OpenForms["frmListadoPromotores"].Activate();
                }
                else
                {
                    cliente = null;
                    frmListadoPromotores frm_cliente = new frmListadoPromotores();
                    frm_cliente.ShowDialog();

                    if (cliente == null)
                    {
                        txtDocIdentidad.Text = string.Empty;
                        txtNombreLegalRec.Text = string.Empty;
                        txtDirRec.Text = string.Empty;
                    }
                    else
                    {
                        txtDocIdentidad.Text = cliente.Documento;
                        txtNombreLegalRec.Text = cliente.Nombreyapellido;
                        txtDirRec.Text = cliente.Direccion.Trim();
                    }
                }
            }*/
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Detalle"] != null)
            {
                Application.OpenForms["frm_Detalle"].Activate();
            }
            else
            {
                frm_Detalle frm_detalle = new frm_Detalle();
                //frm_prosalida.frm_ticket = this;
                frm_detalle.ShowDialog();
            }
        }

        public void calculatotales()
        {

            Decimal total = 0;


            //if (dgvProducto.Rows.Count > 0)
            //{

            txtTotal.Text = String.Format("{0:#,##0.00}",
                   (dgvProducto.Rows.Cast<DataGridViewRow>().Select(x => decimal.Parse(x.Cells["total"].Value.ToString())).Sum())
                );

            //}

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.Rows.Count > 0 & dgvProducto.SelectedRows.Count > 0)
            {

                dgvProducto.Rows.Remove(dgvProducto.CurrentRow);
                calculatotales();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            bool rpta = true;
            int id = -1;
            try
            {
                if (producto == null)
                {
                    MessageBox.Show("Producto es nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (promotor == null)
                {
                    MessageBox.Show("Promotor es nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }


                if (dgvProducto.Rows.Count > 0)
                {

                    DetalleTicket detalleTicket = null;

                    ticket = new Ticket();

                    ticket.Codtipocomprobante = 7;

                    ticket.CodCliente = promotor.CodPromotor;
                    //comprobante.Codmoneda = Convert.ToInt32(cbMoneda.SelectedValue);
                    //comprobante.Tipocambio = Convert.ToDecimal(txttipocambio.Text);
                    //comprobante.Descripcion = "";
                    ticket.Fecha = dtpFecha.Value;

                    ticket.Subtotal = 0;
                    ticket.Igv = 0;
                    ticket.Total = Convert.ToDecimal(txtTotal.Text);

                    ticket.Codusuario = Session.CodUsuario;
                    ticket.Codempresa = 1;


                    for (int i = 0; i < dgvProducto.Rows.Count; i++)
                    {
                        detalleticket = new DetalleTicket();


                        detalleticket.CodProducto = Convert.ToInt32(dgvProducto.Rows[i].Cells["codProducto"].Value.ToString());

                        if (dgvProducto.Rows[i].Cells["codUnidadMedida"].Value == null)
                        {
                            detalleticket.CodUnidad = 0;
                        }
                        else
                        {
                            detalleticket.CodUnidad = Convert.ToInt32(dgvProducto.Rows[i].Cells["codUnidadMedida"].Value.ToString());
                        }

                        detalleticket.Cantidad = Convert.ToInt32(dgvProducto.Rows[i].Cells["cantidad"].Value.ToString());
                        detalleticket.Precio = Convert.ToDecimal(dgvProducto.Rows[i].Cells["Precio"].Value.ToString());
                        detalleticket.Total = Convert.ToDecimal(dgvProducto.Rows[i].Cells["total"].Value.ToString());


                        detalleticket.Codusuario = Session.CodUsuario;

                        ticket.ListaDetalleTicket.Add(detalleticket);
                    }

                    rpta = CTicket.insertar(ticket);

                    if (rpta == true)
                    {
                        btnGuardar.Enabled = false;
                        MessageBox.Show("Datos guardados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnImprimir_Click(null, null);



                        id = CCaja.buscar_caja_abierta(Session.CodUsuario);

                        if (id > 0)
                        {
                            caja = new Caja()
                            {
                                Codcaja = id
                            };
                            /*
                            frmCancelarPago frm_cp = new frmCancelarPago(compro);
                            frm_cp.caja = caja;
                            frm_cp.ShowDialog();*/

                        }



                        // btnImprimir_Click();
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            limpiarventana();

            this.Cursor = Cursors.Default;
        }



        public void limpiarventana()
        {

            dgvProducto.DataSource = null;
            dgvProducto.Rows.Clear();
            txtDocIdentidad.Clear();
            txtNombreLegalRec.Clear();
            txtDirRec.Clear();
            txtTotal.Text = "0.00";
            dtpFecha.Value = DateTime.Now;
            btnGuardar.Enabled = true;
            ticket = null;
            promotor = null;


        }

        private void dgvProducto_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {

            /*
            this.Cursor = Cursors.WaitCursor;
            try
            {

                int index = dgvProducto.CurrentRow.Index;

                dgvProducto.Rows.RemoveAt(index);
                calculatotales();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;
            }
            */

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                this.Cursor = Cursors.WaitCursor;

                DataSet jes = new DataSet();
                frmRptTicket frm = new frmRptTicket();
                CRTicket rpt = new CRTicket();

                string NombreImpresora = impresora_xdefecto();

                //Ticket tic = CTicket.buscaticket(ticket.CodTicket);

                if (ticket != null)
                {

                    if (ticket.CodTicket == 0)
                    {
                        MessageBox.Show("No se encontro un ticket", "TICKET", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }

                rpt.Load("CRTicket.rpt");
                jes = clsReporteFactura.ReporteTicket(ticket.CodTicket);

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
    }
}
