using System;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.reportes;
using SGEDICALE.clases;
using SGEDICALE.controlador;
using System.Collections.Generic;
using Ñwinsoft_Ruc;
using Avicola.vista;
using FinalXML.vista;
using FinalXML.vista.cajero;
using FinalXML;
using System.ComponentModel;
using SGEDICALE.modelo;

namespace SGEDICALE.vista
{
    public partial class frmPrincipal : DevComponents.DotNetBar.RibbonForm
    {
        clsReportes ds = new clsReportes();
        private TipoCambio tipocambio = null;
        private List<Moneda> lista_moneda = null;


        Conexion cn = new Conexion();


        public Usuario usuario { get; set; }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            cargarempresa();
            crearDirectorio();
            cargarigv();

            cargarmoneda();
            cargartipocambio();
            //muestraalmacen();
            this.Cursor = Cursors.Default;
        }

        public void muestraalmacen()
        {
            /*
            frmSeleccionarAlmacen frm = new frmSeleccionarAlmacen();
            frm.ShowDialog();*/
        }



        public void cargarmoneda()
        {
            lista_moneda = CMoneda.listar_Moneda();
        }

        public void cargarigv()
        {
            try
            {
                Igv igv = CIgv.listar_igv_anual();
                if (igv != null)
                {
                    Session.Igv = igv.Valor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }


        public void cargartipocambio()
        {
            registrar_tipo_cambio();
        }

        public void registrar_tipo_cambio()
        {
            bool rpta = true;

            try
            {
                if (lista_moneda != null)
                {
                    if (lista_moneda.Count > 0)
                    {
                        foreach (Moneda m in lista_moneda)
                        {

                            tipocambio = CTipoCambio.buscar(DateTime.Now, m.Codmoneda);

                            if (tipocambio == null)
                            {
                                if (m.Codsunat == "PEN")
                                {
                                    tipocambio = new TipoCambio();
                                    tipocambio.Compra = 1;
                                    tipocambio.Venta = 1;
                                    tipocambio.Codmoneda = m.Codmoneda;
                                    tipocambio.Codusuario = Session.CodUsuario;
                                    tipocambio.Fecha = DateTime.Now;
                                    tipocambio.Estado = 1;

                                    rpta = CTipoCambio.insert(tipocambio);
                                }

                                if (m.Codsunat == "USD")
                                {

                                    Sunat sunat = new Sunat();
                                    tipocambio = sunat.obtener_Tipo_Cambio();
                                    if (tipocambio != null)
                                    {
                                        tipocambio.Codmoneda = m.Codmoneda;
                                        rpta = CTipoCambio.insert(tipocambio);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }

        public void cargarempresa()
        {
            Empresa empresa = CEmpresa.CargaEmpresa();
            if (empresa != null)
            {
                Session.CodEmpresa = empresa.CodEmpresa;
                Session.Ruc = empresa.Ruc;
            }
            else
            {
                MessageBox.Show("No existe niguna empresa registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                return;
            }
        }

        private void btnItemPromotor_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmPromotor"] != null)
            {
                Application.OpenForms["frmPromotor"].Activate();
            }
            else
            {
                frmPromotor frm_pro = new frmPromotor();
                //frm_usu.Usuario_accedido = Usuario;
                frm_pro.MdiParent = this;
                frm_pro.Show();
            }
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmPedido"] != null)
            {
                Application.OpenForms["frmPedido"].Activate();
            }
            else
            {
                frmPedido frm_pedi = new frmPedido();
                //frm_usu.Usuario_accedido = Usuario;
                frm_pedi.MdiParent = this;
                frm_pedi.Show();
            }
        }

        private void btnItemCampaña_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmProducto"] != null)
            {
                Application.OpenForms["frmProducto"].Activate();
            }
            else
            {
                frmProducto frm_prod = new frmProducto();
                //frm_usu.Usuario_accedido = Usuario;
                frm_prod.MdiParent = this;
                frm_prod.Show();
            }
        }

        private void btnListadoPedido_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListadoPedidos"] != null)
            {
                Application.OpenForms["frmListadoPedidos"].Activate();
            }
            else
            {
                frmListadoPedidos frm_lp = new frmListadoPedidos();
                //frm_usu.Usuario_accedido = Usuario;
                frm_lp.MdiParent = this;
                frm_lp.Show();
            }
        }

        private void btnItemCatalogo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCatalogo"] != null)
            {
                Application.OpenForms["frmCatalogo"].Activate();
            }
            else
            {
                frmCatalogo frm_cat = new frmCatalogo();
                //frm_usu.Usuario_accedido = Usuario;
                frm_cat.MdiParent = this;
                frm_cat.Show();
            }
        }

        private void btnItemReportePrecio_Click(object sender, EventArgs e)
        {
            /*
            this.Cursor = Cursors.WaitCursor;

            CRReportePrecio rpt = new CRReportePrecio();
            frmReportePrecio frm = new frmReportePrecio();
            DataTable nuevo = new DataTable();
        
            try
            {
                
                 nuevo = ds.ReportePrecio().Tables[0];
                 rpt.SetDataSource(nuevo);
                 frm.crReportePrecio.ReportSource = rpt;
                 frm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;*/
        }

        private void btnItemListado_Click(object sender, EventArgs e)
        {


            this.Cursor = Cursors.WaitCursor;
            if (Application.OpenForms["frmListadoPromotores"] != null)
            {
                Application.OpenForms["frmListadoPromotores"].Activate();
            }
            else
            {
                frmListadoPromotores frm_lpro = new frmListadoPromotores();
                frm_lpro.botonborrar = "No";
                frm_lpro.MdiParent = this;
                frm_lpro.Show();
            }
            this.Cursor = Cursors.Default;
        }

        private void btnItemProducto_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            if (Application.OpenForms["frmListadoProducto"] != null)
            {
                Application.OpenForms["frmListadoProducto"].Activate();
            }
            else
            {
                frmListadoProducto frm_lprod = new frmListadoProducto();
                frm_lprod.MdiParent = this;
                frm_lprod.Show();
            }
            this.Cursor = Cursors.Default;
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            if (Application.OpenForms["frmListadoCatalogo"] != null)
            {
                Application.OpenForms["frmListadoCatalogo"].Activate();
            }
            else
            {
                frmListadoCatalogo frm_lcat = new frmListadoCatalogo();
                frm_lcat.MdiParent = this;
                frm_lcat.Show();
            }

            this.Cursor = Cursors.Default;
        }

        private void btnItemBanco_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListadoBanco"] != null)
            {
                Application.OpenForms["frmListadoBanco"].Activate();
            }
            else
            {
                frmListadoBanco frm_ban = new frmListadoBanco();
                //frm_usu.Usuario_accedido = Usuario;
                frm_ban.MdiParent = this;
                frm_ban.Show();
            }
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {

        }

        private void btnItemCuenta_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListadoCuentaCte"] != null)
            {
                Application.OpenForms["frmListadoCuentaCte"].Activate();
            }
            else
            {
                frmListadoCuentaCte frm_cue = new frmListadoCuentaCte();
                //frm_usu.Usuario_accedido = Usuario;
                frm_cue.MdiParent = this;
                frm_cue.Show();
            }
        }

        private void btnItemPago_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCargaPago"] != null)
            {
                Application.OpenForms["frmCargaPago"].Activate();
            }
            else
            {
                frmCargaPago frm_cp = new frmCargaPago();
                //frm_usu.Usuario_accedido = Usuario;
                frm_cp.MdiParent = this;
                frm_cp.Show();
            }
        }

        private void btnItemListadoPagos_Click(object sender, EventArgs e)
        {


            if (Application.OpenForms["frmListadoPago"] != null)
            {
                Application.OpenForms["frmListadoPago"].Activate();
            }
            else
            {
                frmListadoPago frm_lp = new frmListadoPago();
                //frm_usu.Usuario_accedido = Usuario;
                frm_lp.MdiParent = this;
                frm_lp.Show();
            }
        }

        private void btnItemFacturación_Click(object sender, EventArgs e)
        {
            /*
            frmCancelarPago frm_cp = new frmCancelarPago();
            frm_cp.ShowDialog();*/

    
            int validarPendiente = CRepositorio.ValidarEnviosPendientes();

            if (validarPendiente > 0)
            {
                int resultado = CRepositorio.ContadorNoEnviados();

                if (resultado > 0)
                {
                    MessageBox.Show("Tiene comprobantes pendiente de enviar a SUNAT", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Cursor = Cursors.Default;
                    return;

                }
            }

            if (Application.OpenForms["frmF"] != null)
            {
                Application.OpenForms["frmF"].Activate();
            }
            else
            {
                frmF frm_f = new frmF();
                frm_f.MdiParent = this;
                frm_f.Show();
            }

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }


        private void crearDirectorio()
        {
            //crear las rutas

            string XML = @"C:\XML";
            string CAPTCHA = @"C:\CAPTCHA";
            string DOCUMENTOS_ELECTRONICAS = @"C:\DOCUMENTOS-" + Session.Ruc;
            string FIRMA = @"C:\DOCUMENTOS-" + Session.Ruc + "\\CERTIFIK";
            string QR = @"C:\DOCUMENTOS-" + Session.Ruc + "\\CERTIFIK\\QR";
            string DOCUMENTOS_ENVIA = @"C:\DOCUMENTOS-" + Session.Ruc + "\\DOCUMENTOS ENVIAR";
            string NOTASDEBITO = @"C:\DOCUMENTOS-" + Session.Ruc + "\\DOCUMENTOS ENVIAR\\NOTAS DEBITO";
            string NOTASCREDITO = @"C:\DOCUMENTOS-" + Session.Ruc + "\\DOCUMENTOS ENVIAR\\NOTAS CREDITO";
            string FACTURAS = @"C:\DOCUMENTOS-" + Session.Ruc + "\\DOCUMENTOS ENVIAR\\FACTURAS";
            string BOLETAS = @"C:\DOCUMENTOS-" + Session.Ruc + "\\DOCUMENTOS ENVIAR\\BOLETAS";
            string CDR = @"C:\DOCUMENTOS-" + Session.Ruc + "\\CDR";
            string DOCUMENTOSBAJA = @"C:\DOCUMENTOS-" + Session.Ruc + "\\DOCUMENTOSBAJA";
            try
            {//si no existe la carpeta temporal la creamos                
                if (!(System.IO.Directory.Exists(XML)))
                {
                    System.IO.Directory.CreateDirectory(XML);
                }
                if (!(System.IO.Directory.Exists(CAPTCHA)))
                {
                    System.IO.Directory.CreateDirectory(CAPTCHA);
                }
                if (!(System.IO.Directory.Exists(DOCUMENTOS_ELECTRONICAS)))
                {
                    System.IO.Directory.CreateDirectory(DOCUMENTOS_ELECTRONICAS);
                    if (!(System.IO.Directory.Exists(FIRMA)))
                    {
                        System.IO.Directory.CreateDirectory(FIRMA);
                        if (!(System.IO.Directory.Exists(QR)))
                        {
                            System.IO.Directory.CreateDirectory(QR);
                        }
                    }
                    if (!(System.IO.Directory.Exists(CDR)))
                    {
                        System.IO.Directory.CreateDirectory(CDR);
                    }
                    if (!(System.IO.Directory.Exists(DOCUMENTOSBAJA)))
                    {
                        System.IO.Directory.CreateDirectory(DOCUMENTOSBAJA);
                    }
                    if (!(System.IO.Directory.Exists(DOCUMENTOS_ENVIA)))
                    {
                        System.IO.Directory.CreateDirectory(DOCUMENTOS_ENVIA);

                        if (!(System.IO.Directory.Exists(NOTASDEBITO))) { System.IO.Directory.CreateDirectory(NOTASDEBITO); }
                        if (!(System.IO.Directory.Exists(NOTASCREDITO))) { System.IO.Directory.CreateDirectory(NOTASCREDITO); }
                        if (!(System.IO.Directory.Exists(FACTURAS))) { System.IO.Directory.CreateDirectory(FACTURAS); }
                        if (!(System.IO.Directory.Exists(BOLETAS))) { System.IO.Directory.CreateDirectory(BOLETAS); }
                    }

                }

            }
            catch (Exception errorC)
            {
                MessageBox.Show(errorC.Message, "Error al crear fichero temporal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }

        private void btnItemEnvio_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frmEnvioSunat"] != null)
            {
                Application.OpenForms["frmEnvioSunat"].Activate();
            }
            else
            {
                frmEnvioSunat form = new frmEnvioSunat();
                //form.Proce = 1;
                form.MdiParent = this;
                form.Show();
            }

        }

        private void btnItemTipoCambio_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmTipoCambio"] != null)
            {
                Application.OpenForms["frmTipoCambio"].Activate();
            }
            else
            {
                frmTipoCambio frm_tc = new frmTipoCambio();
                frm_tc.MdiParent = this;
                frm_tc.Show();
            }
        }

        private void btn_item_igv_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Igv"] != null)
            {
                Application.OpenForms["frm_Igv"].Activate();
            }
            else
            {
                frm_Igv frm_i = new frm_Igv();
                frm_i.MdiParent = this;
                frm_i.Show();
            }
        }

        private void btnItemAperturaCaja_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAperturaCaja"] != null)
            {
                Application.OpenForms["frmAperturaCaja"].Activate();
            }
            else
            {
                frmAperturaCaja frm_ac = new frmAperturaCaja();
                frm_ac.MdiParent = this;
                frm_ac.Show();
            }
        }

        private void btnItemCajaMovimiento_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCajaMovimiento"] != null)
            {
                Application.OpenForms["frmCajaMovimiento"].Activate();
            }
            else
            {
                frmCajaMovimiento frm_cm = new frmCajaMovimiento();
                frm_cm.Estado = 1;
                frm_cm.MdiParent = this;
                frm_cm.Show();
            }
        }

        private void btnTipoCambio_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmTipoCambio"] != null)
            {
                Application.OpenForms["frmTipoCambio"].Activate();
            }
            else
            {
                frmTipoCambio frm_tc = new frmTipoCambio();
                frm_tc.MdiParent = this;
                frm_tc.Show();
            }
        }

        private void btnIIgv_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Igv"] != null)
            {
                Application.OpenForms["frm_Igv"].Activate();
            }
            else
            {
                frm_Igv frm_i = new frm_Igv();
                frm_i.MdiParent = this;
                frm_i.Show();
            }
        }

        private void buttonItem4_Click(object sender, EventArgs e)
        {

        }

        private void btnItemMetodoPago_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmMetodoPago"] != null)
            {
                Application.OpenForms["frmMetodoPago"].Activate();
            }
            else
            {
                frmMetodoPago frm_mp = new frmMetodoPago();
                frm_mp.MdiParent = this;
                frm_mp.Show();
            }
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmBancos"] != null)
            {
                Application.OpenForms["frmBancos"].Activate();
            }
            else
            {
                frmBancos frm_bancos = new frmBancos();
                //frm_usu.Usuario_accedido = Usuario;
                frm_bancos.MdiParent = this;
                frm_bancos.Show();
            }
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCuentaBancaria"] != null)
            {
                Application.OpenForms["frmCuentaBancaria"].Activate();
            }
            else
            {
                frmCuentaBancaria frm_cub = new frmCuentaBancaria();
                //frm_usu.Usuario_accedido = Usuario;
                frm_cub.MdiParent = this;
                frm_cub.Show();
            }
        }

        private void btnitemTipoTarjeta_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmTipoTarjeta"] != null)
            {
                Application.OpenForms["frmTipoTarjeta"].Activate();
            }
            else
            {
                frmTipoTarjeta frm_tp = new frmTipoTarjeta();
                //frm_usu.Usuario_accedido = Usuario;
                frm_tp.MdiParent = this;
                frm_tp.Show();
            }
        }

        private void btnItemNotaCredito_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListaVentas"] != null)
            {
                Application.OpenForms["frmListaVentas"].Activate();
            }
            else
            {
                frmListaVentas frm_lp = new frmListaVentas();
                //frm_usu.Usuario_accedido = Usuario;
                frm_lp.MdiParent = this;
                frm_lp.Show();
            }
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frmCampaña"] != null)
            {
                Application.OpenForms["frmCampaña"].Activate();
            }
            else
            {
                frmCampaña frm_campaña = new frmCampaña();
                //frm_usu.Usuario_accedido = Usuario;
                frm_campaña.MdiParent = this;
                frm_campaña.Show();
            }

        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCargaPremio"] != null)
            {
                Application.OpenForms["frmCargaPremio"].Activate();
            }
            else
            {
                frmCargaPremio frm_cpre = new frmCargaPremio();
                //frm_usu.Usuario_accedido = Usuario;
                frm_cpre.MdiParent = this;
                frm_cpre.Show();
            }
        }

        private void buttonItem11_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListadoPremios"] != null)
            {
                Application.OpenForms["frmListadoPremios"].Activate();
            }
            else
            {
                frmListadoPremios frm_lpre = new frmListadoPremios();
                //frm_usu.Usuario_accedido = Usuario;
                frm_lpre.MdiParent = this;
                frm_lpre.Show();
            }

        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmEntregar"] != null)
            {
                Application.OpenForms["frmEntregar"].Activate();
            }
            else
            {
                frmEntregar frm_entrega = new frmEntregar();
                //frm_usu.Usuario_accedido = Usuario;
                frm_entrega.MdiParent = this;
                frm_entrega.Show();
            }
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListaNotaCredito"] != null)
            {
                Application.OpenForms["frmListaNotaCredito"].Activate();
            }
            else
            {
                frmListaNotaCredito frm_lnc = new frmListaNotaCredito();
                //frm_usu.Usuario_accedido = Usuario;
                frm_lnc.MdiParent = this;
                frm_lnc.Show();
            }
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListaEntregados"] != null)
            {
                Application.OpenForms["frmListaEntregados"].Activate();
            }
            else
            {
                frmListaEntregados frm_len = new frmListaEntregados();
                //frm_usu.Usuario_accedido = Usuario;
                frm_len.MdiParent = this;
                frm_len.Show();
            }
        }

        private void buttonItem14_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCobro"] != null)
            {
                Application.OpenForms["frmCobro"].Activate();
            }
            else
            {
                frmCobro frm_co = new frmCobro();
                //frm_usu.Usuario_accedido = Usuario;
                frm_co.MdiParent = this;
                frm_co.Show();
            }
        }

        private void btnItemDeposito_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frm_Depositos"] != null)
            {
                Application.OpenForms["frm_Depositos"].Activate();
            }
            else
            {
                frm_Depositos frm_depo = new frm_Depositos();
                //frm_usu.Usuario_accedido = Usuario;
                frm_depo.MdiParent = this;
                frm_depo.Show();
            }
        }

        private void btnItemNotaCredito_Click_1(object sender, EventArgs e)
        {
            Igv ig= CIgv.listar_igv_anual();

            if (ig == null)
            {
                MessageBox.Show("Registre igv del año actual en el sistema", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
                return;
            }


            if (Application.OpenForms["frm_NotadeCredito"] != null)
            {
                Application.OpenForms["frm_NotadeCredito"].Activate();
            }
            else
            {
                frm_NotadeCredito form_nc = new frm_NotadeCredito();
                //form.Proce = 1;
                form_nc.MdiParent = this;
                form_nc.Show();
            }
        }

        private void btnItemListadoNotaCredito_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListaNotaCredito"] != null)
            {
                Application.OpenForms["frmListaNotaCredito"].Activate();
            }
            else
            {
                frmListaNotaCredito frm_lnc = new frmListaNotaCredito();
                //frm_usu.Usuario_accedido = Usuario;
                frm_lnc.MdiParent = this;
                frm_lnc.Show();
            }
        }

        private void btnItemProductosNuevos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRegistroProductos"] != null)
            {
                Application.OpenForms["frmRegistroProductos"].Activate();
            }
            else
            {
                frmRegistroProductos frm_rp = new frmRegistroProductos();
                //frm_usu.Usuario_accedido = Usuario;
                frm_rp.MdiParent = this;
                frm_rp.Show();
            }

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ListadoPuntos"] != null)
            {
                Application.OpenForms["frm_ListadoPuntos"].Activate();
            }
            else
            {
                frm_ListadoPuntos frm_listadopuntos = new frm_ListadoPuntos();
                //frm_usu.Usuario_accedido = Usuario;
                frm_listadopuntos.MdiParent = this;
                frm_listadopuntos.Show();
            }
        }

        private void btnItemCajasAbiertas_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmVerAperturaCaja"] != null)
                {
                    Application.OpenForms["frmVerAperturaCaja"].Activate();
                }
                else
                {
                    frmVerAperturaCaja frm_cajaabierta = new frmVerAperturaCaja();
                    frm_cajaabierta.usureg = usuario;
                    frm_cajaabierta.MdiParent = this;
                    frm_cajaabierta.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnItemCajasCerradas_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmVerCierreCaja"] != null)
                {
                    Application.OpenForms["frmVerCierreCaja"].Activate();
                }
                else
                {
                    frmVerCierreCaja frm_cajacerrada = new frmVerCierreCaja();
                    frm_cajacerrada.usureg = usuario;
                    frm_cajacerrada.MdiParent = this;
                    frm_cajacerrada.Show();
                }
            }
            catch (Exception) { }
        }

        private void btnItemCajaAbierta_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmVerAperturaCaja"] != null)
                {
                    Application.OpenForms["frmVerAperturaCaja"].Activate();
                }
                else
                {
                    frmVerAperturaCaja frm_cajaabierta = new frmVerAperturaCaja();
                    frm_cajaabierta.usureg = usuario;
                    frm_cajaabierta.MdiParent = this;
                    frm_cajaabierta.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnItemCajaCerrada_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmVerCierreCaja"] != null)
                {
                    Application.OpenForms["frmVerCierreCaja"].Activate();
                }
                else
                {
                    frmVerCierreCaja frm_cajacerrada = new frmVerCierreCaja();
                    frm_cajacerrada.usureg = usuario;
                    frm_cajacerrada.MdiParent = this;
                    frm_cajacerrada.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnItemCajaMovimiento_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmCajaMovimiento"] != null)
            {
                Application.OpenForms["frmCajaMovimiento"].Activate();
            }
            else
            {
                frmCajaMovimiento frm_cm = new frmCajaMovimiento();
                frm_cm.Estado = 1;
                frm_cm.usureg = usuario;
                frm_cm.MdiParent = this;
                frm_cm.Show();
            }
        }

        private void btnItemCategoria_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Categoria"] != null)
            {
                Application.OpenForms["frm_Categoria"].Activate();
            }
            else
            {
                frm_Categoria frm_cat = new frm_Categoria();
                //frm_usu.Usuario_accedido = Usuario;
                frm_cat.MdiParent = this;
                frm_cat.Show();
            }
        }

        private void ReportePrecios_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                frm_Comparativa frm = new frm_Comparativa();
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void btnItemTicket_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Ticket"] != null)
            {
                Application.OpenForms["frm_Ticket"].Activate();
            }
            else
            {
                frm_Ticket form_t = new frm_Ticket();
                //form.Proce = 1;
                form_t.MdiParent = this;
                form_t.Show();
            }
        }

        private void btnItemCliente_Click(object sender, EventArgs e)
        {


            if (Application.OpenForms["FrmCliente"] != null)
            {
                Application.OpenForms["FrmCliente"].Activate();
            }
            else
            {

                FrmCliente frm_cliente = new FrmCliente();
                frm_cliente.MdiParent = this;
                frm_cliente.Show();

            }
        }

        private void btnItemListaTicket_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["frm_listadoTicket"] != null)
            {
                Application.OpenForms["frm_listadoTicket"].Activate();
            }
            else
            {
                frm_listadoTicket frm_lt = new frm_listadoTicket();
                //frm_usu.Usuario_accedido = Usuario;
                frm_lt.MdiParent = this;
                frm_lt.Show();
            }
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRegistroPromotores"] != null)
            {
                Application.OpenForms["frmRegistroPromotores"].Activate();
            }
            else
            {
                frmRegistroPromotor frm_rp = new frmRegistroPromotor();
                //frm_usu.Usuario_accedido = Usuario;
                frm_rp.MdiParent = this;
                frm_rp.Show();
            }
        }

        private void ribbonTabItem2_Click(object sender, EventArgs e)
        {

        }

        private void btnItemUsu_Click(object sender, EventArgs e)
        {
            try
            {
                if (Application.OpenForms["frmUsuario"] != null)
                {
                    Application.OpenForms["frmUsuario"].Activate();
                }
                else
                {
                    frmUsuario frm_usuario = new frmUsuario();
                    frm_usuario.usureg = usuario;
                    frm_usuario.MdiParent = this;
                    frm_usuario.Show();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnItemBackup_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            cn.GeneraraBackup(saveFileDialog1.FileName);

        }

        private void btnItemAcceso_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Acceso"] != null)
            {
                Application.OpenForms["frm_Acceso"].Activate();
            }
            else
            {
                frm_Acceso frm_acceso = new frm_Acceso();
                //frm_usuario.usureg = usuario;
                frm_acceso.MdiParent = this;
                frm_acceso.Show();
            }
        }

        private void btmItemReporteDocumentosEnviados_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmReporteElectronico"] != null)
            {
                Application.OpenForms["frmReporteElectronico"].Activate();
            }
            else
            {
                frmReporteElectronico frm_re = new frmReporteElectronico();
                //frm_usuario.usureg = usuario;
                frm_re.MdiParent = this;
                frm_re.Show();
            }
        }

        private void btnItemProductosRepetidos_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonItemEmpresa_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmRegistroEmpresa"] != null)
            {
                Application.OpenForms["frmRegistroEmpresa"].Activate();
            }
            else
            {
                frmRegistroEmpresa frm_empresa = new frmRegistroEmpresa();
                //frm_usuario.usureg = usuario;
                frm_empresa.MdiParent = this;
                frm_empresa.Show();
            }
        }

        private void buttonItemVenta_Click(object sender, EventArgs e)
        {
            
            if (Application.OpenForms["frmNuevaVenta"] != null)
            {
                Application.OpenForms["frmNuevaVenta"].Activate();
            }
            else
            {
                frmNuevaVenta frm_venta = new frmNuevaVenta();
                frm_venta.MdiParent = this;
                frm_venta.Show();
            }
        }

        private void buttonItem3_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["ValidarPendientesEnvio"] != null)
            {
                Application.OpenForms["ValidarPendientesEnvio"].Activate();
            }
            else
            {
                ValidarPendientesEnvio frm_v = new ValidarPendientesEnvio();
                frm_v.MdiParent = this;
                frm_v.Show();
            }
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ReportexPedio"] != null)
            {
                Application.OpenForms["ReportexPedio"].Activate();
            }
            else
            {
                ReportexPedio frm_rp = new ReportexPedio();
                //frm_usuario.usureg = usuario;
                frm_rp.MdiParent = this;
                frm_rp.Show();
            }
        }

        private void buttonItem12_Click_1(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListadoPromotoresRepetidos"] != null)
            {
                Application.OpenForms["frmListadoPromotoresRepetidos"].Activate();
            }
            else
            {
                frmListadoPromotoresRepetidos frm_l = new frmListadoPromotoresRepetidos();
                //frm_usuario.usureg = usuario;
                frm_l.MdiParent = this;
                frm_l.Show();
            }
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListadoPromotoresRepetidosEmail"] != null)
            {
                Application.OpenForms["frmListadoPromotoresRepetidosEmail"].Activate();
            }
            else
            {
                frmListadoPromotoresRepetidosEmail frm_le = new frmListadoPromotoresRepetidosEmail();
                //frm_usuario.usureg = usuario;
                frm_le.MdiParent = this;
                frm_le.Show();
            }
        }

        private void btnReportePedido_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["ReportexPedio"] != null)
            {
                Application.OpenForms["ReportexPedio"].Activate();
            }
            else
            {
                ReportexPedio frm_rp = new ReportexPedio();
                //frm_usuario.usureg = usuario;
                frm_rp.MdiParent = this;
                frm_rp.Show();
            }
        }

        private void BTNrEPORTEsUNAT_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmReporteElectronico"] != null)
            {
                Application.OpenForms["frmReporteElectronico"].Activate();
            }
            else
            {
                frmReporteElectronico frm_re = new frmReporteElectronico();
                //frm_usuario.usureg = usuario;
                frm_re.MdiParent = this;
                frm_re.Show();
            }
        }

        private void btnPorDni_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListadoPromotoresRepetidos"] != null)
            {
                Application.OpenForms["frmListadoPromotoresRepetidos"].Activate();
            }
            else
            {
                frmListadoPromotoresRepetidos frm_l = new frmListadoPromotoresRepetidos();
                //frm_usuario.usureg = usuario;
                frm_l.MdiParent = this;
                frm_l.Show();
            }
        }

        private void btnPorEmail_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmListadoPromotoresRepetidosEmail"] != null)
            {
                Application.OpenForms["frmListadoPromotoresRepetidosEmail"].Activate();
            }
            else
            {
                frmListadoPromotoresRepetidosEmail frm_le = new frmListadoPromotoresRepetidosEmail();
                //frm_usuario.usureg = usuario;
                frm_le.MdiParent = this;
                frm_le.Show();
            }
        }
    }
}
