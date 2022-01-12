using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinApp.API;
using WinApp.Comun.Dto.Intercambio;
using WinApp.Comun.Dto.Modelos;
using WinApp.Firmado;
using WinApp.Servicio;
using WinApp.Servicio.Soap;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data;
using iTextSharp.text.pdf;
using QRCoder;
using SGEDICALE.reportes;
using SGEDICALE.reportes.clsReportes;
using SGEDICALE.clases;
using SGEDICALE.controlador;
using WinApp.Comun;
namespace SGEDICALE.SunatFacElec
{
    public class Facturacion
    {

        private DocumentoElectronico _documento;
        private Contribuyente dtsReceptor;
        private FirmadoResponse respuestaFirmado;


        #region Propiedades
        public string RutaArchivo { get; set; }
        public string RutaArchivoEnvio { get; set; }
        public string IdDocumento { get; set; }
        public String RutaAlterna { get; set; }
        public Byte[] LogoEmp { get; set; }
        public Int32 enviado = 0;
        public RespuestaComunConArchivo respuestaEnvio;
        public EnviarDocumentoResponse rpta;
        public Int32 VerificaContribuyente = 0;
        public String datosAdicionales_CDB { get; set; }
        public String CodigoCertificado { get; set; }
        public String firmadig { get; set; }
        public String resumenfirmadig { get; set; }

        /*Clases*/
        Empresa empresa = new Empresa();
        Producto productos = new Producto();


        Repositorio repositorio = new Repositorio();


        Conversion conv = new Conversion();
        Discrepancia discrepancia = new Discrepancia();
        DocumentoRelacionado dr = new DocumentoRelacionado();

        public int numdiscrepancia = 0;

        /*Listas*
        List<Repositorio> lista_repositorio = null;

        /*Administradores*/

        // clsReporteFactura ds = new clsReporteFactura();


        #endregion



        public Int32 CodigoErrorEnvio = 0;// 1) Error en el xml  2) Error de envio a sunat - falla de servidor



        TipoComprobate doc = new TipoComprobate();
        Transaccion transas = new Transaccion();


        public Facturacion()
        {
            _documento = new DocumentoElectronico();
            respuestaFirmado = new FirmadoResponse();

        }
        #region Metodos de llendo de datos

        /**
         * Carga datos del comtribuyente
         * @param CosEmpresa @type int
         * @return 1 - 2
         * 1 - Correcto
         * 2 - Incorrecto
         * Mejorar la parte de cargar Departamento - Provincia - Distrito - Ubigeo
         **/
        private int DatosComtribuyente(Int32 CodEmpresa)
        {
            try
            {
                empresa = CEmpresa.CargaEmpresa();
                if (empresa != null)
                {
                    var dtsEmisor = new Contribuyente()
                    {
                        NroDocumento = empresa.Ruc,
                        TipoDocumento = "6",
                        Direccion = empresa.Direccion,
                        Departamento = "TUMBES",
                        Provincia = "TUMBES",
                        Distrito = "TUMBES",
                        NombreLegal = empresa.RazonSocial,
                        NombreComercial = "",
                        Ubigeo = "240101",
                        CodDomicilioFiscal = "0000" //Código de cuatro dígitos asignado por SUNAT

                    };
                    _documento.Emisor = dtsEmisor;
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            catch (Exception a) { MessageBox.Show(a.Message); return 2; }


        }


        public async Task GeneraDocumentoFirmado(Promotor cliente, Comprobantee comprobante, List<DetalleComprobante> detallecomprobante, int repoId)
        {
            try
            {

                Cursor.Current = Cursors.WaitCursor;
                string codsunat = "";
                repositorio.Nombredoc = "";

                /**
                 * Carga TipoDocumento y Transacciones
                 * @param CodTipoDocumento
                 * @return TipoDocumento
                 * 
                 * @param CotTipoTransaccion
                 * @return Transacciones
                 **/

                doc = CTipoComprobante.CargaTipoDocumento(comprobante.CodTipoComprobante);
                transas = CTransaccion.MuestraTransaccion(comprobante.CodTransaccion);


                comprobante.Codempresa = 1;
                comprobante = CComprobante.buscacomprobante(comprobante.CodComprobante);


                if (comprobante == null)
                {
                    MessageBox.Show("No se encontro datos del comprobante");
                    return;
                }



                /*
                if (cliente.Dni.Length == 8)
                {
                    codsunat = "1";
                }*/

                /**
                 *
                 * Objeto que tiene los datos del cliente
                 *
                 **/


                dtsReceptor = new Contribuyente()
                {
                    NroDocumento = cliente.Dni.Trim(),
                    //TipoDocumento = venta.DocumentoIdentidad.CodigoSunat.ToString(),
                    TipoDocumento = cliente.DocumentoIdentidad.Codsunat,
                    NombreLegal = cliente.Nombrecompleto.Trim(),
                    NombreComercial = "",
                    Direccion = cliente.Direccion.Trim()
                };

                /**
                 * @val _documento.TipoDocumento
                 *  01 Factura
                 *  03 Boleta
                 *  07 NC
                 *  08 ND
                 *  
                 *  @val _documento.Glosa
                 *  Agregado en la nueva version 2.1
                 *  
                 *  @val  _documento.TipoOperacion
                 *  Agregado en la nueva version 2.1, considerando como venta interna 0101
                 *  Valor de Códigos Catálogo N°51
                 * 
                 **/

                if (_documento.TipoDocumento == "01")
                {

                    if (comprobante.Formapago == 1)
                    {
                        _documento.FormaPago = new WinApp.Comun.Dto.Modelos.PaymentMeans
                        {
                            ID = "FormaPago",
                            PaymentMeansCode = "Contado",
                            Monto = 0m
                        };
                    }
                    else
                    {
                        _documento.FormaPago = new WinApp.Comun.Dto.Modelos.PaymentMeans
                        {
                            ID = "FormaPago",
                            PaymentMeansCode = "Credito",
                            Monto = comprobante.Total
                        };


                        //Si forma de pago es Credito se agregan las cuotas restantes
                        _documento.TerminosPagos = new List<WinApp.Comun.Dto.Modelos.PaymentTerms>() {
                           new WinApp.Comun.Dto.Modelos.PaymentTerms{
                               PaymentMeansID = "Cuota001",
                                Amount = comprobante.Total,
                                PaymentDueDate = DateTime.Today
                           },
                            new WinApp.Comun.Dto.Modelos.PaymentTerms{
                               PaymentMeansID = "Cuota002",
                                Amount = 50m,
                                PaymentDueDate = DateTime.Today
                           },
                            new WinApp.Comun.Dto.Modelos.PaymentTerms{
                               PaymentMeansID = "Cuota003",
                                Amount = 80m,
                                PaymentDueDate = DateTime.Today
                           }
                     };
                    }
                }
            

                _documento.TipoDocumento = doc.Codsunat.ToString();
                _documento.Receptor = dtsReceptor;
                _documento.FechaEmision = comprobante.Fechaemision.Date.ToString();
                _documento.IssueTime = String.Format("{0:HH:mm:ss}", comprobante.Fechaemision);
                _documento.TipoOperacion = transas.Codsunat;//0101 - Venta interna
                _documento.Glosa = "";

                /**
                 * 
                 * Valida el tipo de moneda
                 * 
                 **/

                if (comprobante.Codmoneda == 1)
                {
                    _documento.Moneda = "PEN";
                }
                else
                {
                    _documento.Moneda = "USD";
                }

                /**
                 * Consulta y valída contribuyente
                 * @param Codempresa
                 * @return 1 - 2
                 * 1 válido 
                 * 2 error
                 **/

                VerificaContribuyente = DatosComtribuyente(comprobante.Codempresa);

                if (VerificaContribuyente == 2)
                {
                    MessageBox.Show("No se puede generar documento\n Falta cargar datos de la empresa");
                    return;
                }

                /**
                 * 
                 *Solo evaluamos Facturas y Boletas debido a que las NC y ND se eejecutan desde otro formulario
                 * y usa otros métodos.
                 * Evaluar alguna solución para ejecutar todo aquí
                 **/

                switch (_documento.TipoDocumento)
                {
                    case "07":

                        break;
                    case "08":

                        break;
                    case "03":

                        _documento.IdDocumento = comprobante.Scomprobante;
                        DatosFactura(cliente, comprobante, detallecomprobante);

                        break;
                    case "01":
                        _documento.IdDocumento = comprobante.Scomprobante;
                        DatosFactura(cliente, comprobante, detallecomprobante);
                        break;
                }

                _documento.MontoEnLetras = conv.enletras(comprobante.Total.ToString()); //Monto en letras agregado

                /**
                 * @val  serializador
                 * Serializa todo el objeto _documento y es enviado al método Post
                 * 
                 * @param _documento
                 * @method GenerarFactura
                 * Tener en cuenta que estos métodos son Asyncronos
                 * @return response
                 * 
                 * 
                 **/
                ISerializador serializador = new Serializador();
                DocumentoResponse response = new DocumentoResponse
                {
                    Exito = false
                };

                response = await new GenerarFactura(serializador).Post(_documento);

                /**
                 * @return response | type bool
                 * True | Guarda el archivo XML en carpeta
                 * false | Muestra Error
                 * RutaArchivo | Todos los documentos sin firmar se guardan en esa ruta
                 **/
                if (!response.Exito)
                    MessageBox.Show(response.MensajeError);


                RutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "documentos\\",
                    $"{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml");

                if (System.IO.File.Exists(RutaArchivo))
                    System.IO.File.Delete(RutaArchivo);


                if (_documento.TipoDocumento == "01")//1 es boleta,2 es factura
                {
                    RutaArchivoEnvio = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\FACTURAS\\" + _documento.IdDocumento + ".xml";
                }
                else
                {
                    RutaArchivoEnvio = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\BOLETAS\\" + _documento.IdDocumento + ".xml";
                }


                if (System.IO.File.Exists(RutaArchivoEnvio))
                    System.IO.File.Delete(RutaArchivoEnvio);

                File.WriteAllBytes(RutaArchivo, Convert.FromBase64String(response.TramaXmlSinFirma));

                /**
                 *@Method Firmar()                 
                 * Se realiza el firmado del documento
                 * se usa await debido a que llama a un método asincrono, este no devuelve ningún valor
                 * 
                 */

                //Firmar();

                //firma

                string rutacertifik;
                rutacertifik = @"C:\DOCUMENTOS-" + empresa.Ruc.Trim() + "\\CERTIFIK\\" + empresa.Certificado.Trim();

                if (string.IsNullOrEmpty(_documento.IdDocumento))
                {
                    MessageBox.Show("La Serie y el Correlativo no pueden estar vacíos");
                    return;
                }

                /**
                 * Lee el XML sin firma en la ruta especificada
                 * 
                 **/

                var tramaXmlSinFirma = Convert.ToBase64String(File.ReadAllBytes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "documentos\\",
                    $"{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml")));

                /**
                 * @val UnSoloNodoExtension 
                 * 
                 * Ya no es necesario evaluar si es True o False
                 */

                var firmadoRequest = new FirmadoRequest
                {
                    TramaXmlSinFirma = tramaXmlSinFirma,
                    CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\CERTIFIK\\" + empresa.Certificado)),
                    //CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(rutacertifik)),
                    PasswordCertificado = empresa.Contrasena,
                    UnSoloNodoExtension = false
                };

                ICertificador certificador = new Certificador();
                respuestaFirmado = await new Firmar(certificador).Post(firmadoRequest);


                //firma


                /**
                 * @val RutaAlterna
                 * Ruta donde se guardan los documentos C:\
                 * Evalua las rutas donde se van a guardar los documentos firmados, se guardan en 2 rutas para contrarestar pérdida de los mismos
                 * 
                 */

                switch (_documento.TipoDocumento)
                {

                    case "03":

                        File.WriteAllBytes($"{Program.CarpetaBoletas}\\{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml",
                                  Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));

                        File.WriteAllBytes(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\BOLETAS\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".xml",
                            Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));


                        break;
                    case "01":

                        File.WriteAllBytes($"{Program.CarpetaFacturas}\\{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml",
                                 Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));


                        File.WriteAllBytes(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\FACTURAS\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".xml",
                            Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));


                        break;
                }


                /**
                 * @Method GeneraPDF
                 * @Param CodFacturaVenta
                 * @resumenfirmadig Resumen de Firma Digital
                 * @firmadig Valor de Firma Digital 
                 **/

                resumenfirmadig = respuestaFirmado.ResumenFirma;
                firmadig = respuestaFirmado.ValorFirma;


                /**
                 * Set's para el repositorio de documentos                 
                 */


                string mirutadearchivo = "";
                string mirutadearchivo3 = "";
                repositorio.Repoid = repoId;
                repositorio.Nombredoc = _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento;

                if (_documento.TipoDocumento == "01")//1 es boleta,2 es factura
                {
                    mirutadearchivo = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\FACTURAS\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".xml";
                }
                else
                {
                    mirutadearchivo = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\BOLETAS\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".xml";
                }

                repositorio.Xml = File.ReadAllBytes(mirutadearchivo);
                repositorio.Usuario = Session.CodUsuario;

                if (!CRepositorio.actualiza_repositorio_xml(repositorio))
                {
                    MessageBox.Show("Documento no se pudo enviar al repositorio");
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                Cursor.Current = Cursors.Default;
            }


        }


        #region Set datos externos
        /**
         * Genera XML para ser guardados o enviados a SUNAT
         * @param cliente
         * @param venta
         * @param detalleventa
         * @return void
         * 
         **/
        public async Task GeneraDocumento(Promotor cliente, Comprobantee comprobante, List<DetalleComprobante> detallecomprobante)
        {
            try
            {

                Cursor.Current = Cursors.WaitCursor;
                string codsunat = "";

                /**
                 * Carga TipoDocumento y Transacciones
                 * @param CodTipoDocumento
                 * @return TipoDocumento
                 * 
                 * @param CotTipoTransaccion
                 * @return Transacciones
                 **/

                doc = CTipoComprobante.CargaTipoDocumento(comprobante.CodTipoComprobante);
                transas = CTransaccion.MuestraTransaccion(comprobante.CodTransaccion);


                comprobante.Codempresa = 1;
                comprobante = CComprobante.buscacomprobante(comprobante.CodComprobante);


                if (comprobante == null)
                {
                    MessageBox.Show("No se encontro datos del comprobante");
                    return;
                }



                /*
                if (cliente.Dni.Length == 8)
                {
                    codsunat = "1";
                }*/

                /**
                 *
                 * Objeto que tiene los datos del cliente
                 *
                 **/


                dtsReceptor = new Contribuyente()
                {
                    NroDocumento = cliente.Dni.Trim(),
                    //TipoDocumento = venta.DocumentoIdentidad.CodigoSunat.ToString(),
                    TipoDocumento = cliente.DocumentoIdentidad.Codsunat,
                    NombreLegal = cliente.Nombrecompleto.Trim(),
                    NombreComercial = "",
                    Direccion = cliente.Direccion.Trim()
                };

                /**
                 * @val _documento.TipoDocumento
                 *  01 Factura
                 *  03 Boleta
                 *  07 NC
                 *  08 ND
                 *  
                 *  @val _documento.Glosa
                 *  Agregado en la nueva version 2.1
                 *  
                 *  @val  _documento.TipoOperacion
                 *  Agregado en la nueva version 2.1, considerando como venta interna 0101
                 *  Valor de Códigos Catálogo N°51
                 * 
                 **/

                _documento.TipoDocumento = doc.Codsunat.ToString();
                _documento.Receptor = dtsReceptor;
                _documento.FechaEmision = DateTime.Today.ToShortDateString();
                _documento.IssueTime = String.Format("{0:HH:mm:ss}", DateTime.Now);
                _documento.TipoOperacion = transas.Codsunat;//0101 - Venta interna
                _documento.Glosa = "";

                /**
                 * 
                 * Valida el tipo de moneda
                 * 
                 **/

                if (comprobante.Codmoneda == 1)
                {
                    _documento.Moneda = "PEN";
                }
                else
                {
                    _documento.Moneda = "USD";
                }

                /**
                 * Consulta y valída contribuyente
                 * @param Codempresa
                 * @return 1 - 2
                 * 1 válido 
                 * 2 error
                 **/

                VerificaContribuyente = DatosComtribuyente(comprobante.Codempresa);

                if (VerificaContribuyente == 2)
                {
                    MessageBox.Show("No se puede generar documento\n Falta cargar datos de la empresa");
                    return;
                }

                if (_documento.TipoDocumento == "01")
                {

                    if (comprobante.Formapago == 6)
                    {
                        _documento.FormaPago = new WinApp.Comun.Dto.Modelos.PaymentMeans
                        {
                            ID = "FormaPago",
                            PaymentMeansCode = "Contado",
                            Monto = 0m
                        };
                    }
                    else
                    {
                        _documento.FormaPago = new WinApp.Comun.Dto.Modelos.PaymentMeans
                        {
                            ID = "FormaPago",
                            PaymentMeansCode = "Credito",
                            Monto = comprobante.Total
                        };


                        //Si forma de pago es Credito se agregan las cuotas restantes
                        _documento.TerminosPagos = new List<WinApp.Comun.Dto.Modelos.PaymentTerms>() {
                           new WinApp.Comun.Dto.Modelos.PaymentTerms{
                               PaymentMeansID = "Cuota001",
                                Amount = comprobante.Total,
                                PaymentDueDate = DateTime.Today
                           },
                            new WinApp.Comun.Dto.Modelos.PaymentTerms{
                               PaymentMeansID = "Cuota002",
                                Amount = 50m,
                                PaymentDueDate = DateTime.Today
                           },
                            new WinApp.Comun.Dto.Modelos.PaymentTerms{
                               PaymentMeansID = "Cuota003",
                                Amount = 80m,
                                PaymentDueDate = DateTime.Today
                           }
                     };
                    }
                }


                /**
                 * 
                 *Solo evaluamos Facturas y Boletas debido a que las NC y ND se eejecutan desde otro formulario
                 * y usa otros métodos.
                 * Evaluar alguna solución para ejecutar todo aquí
                 **/

                switch (_documento.TipoDocumento)
                {
                    case "07":

                        break;
                    case "08":

                        break;
                    case "03":

                        _documento.IdDocumento = comprobante.Scomprobante;
                        DatosFactura(cliente, comprobante, detallecomprobante);

                        break;
                    case "01":
                        _documento.IdDocumento = comprobante.Scomprobante;
                        DatosFactura(cliente, comprobante, detallecomprobante);
                        break;
                }

                _documento.MontoEnLetras = conv.enletras(comprobante.Total.ToString()); //Monto en letras agregado

                /**
                 * @val  serializador
                 * Serializa todo el objeto _documento y es enviado al método Post
                 * 
                 * @param _documento
                 * @method GenerarFactura
                 * Tener en cuenta que estos métodos son Asyncronos
                 * @return response
                 * 
                 * 
                 **/
                ISerializador serializador = new Serializador();
                DocumentoResponse response = new DocumentoResponse
                {
                    Exito = false
                };

                response = await new GenerarFactura(serializador).Post(_documento);

                /**
                 * @return response | type bool
                 * True | Guarda el archivo XML en carpeta
                 * false | Muestra Error
                 * RutaArchivo | Todos los documentos sin firmar se guardan en esa ruta
                 **/
                if (!response.Exito)
                    MessageBox.Show(response.MensajeError);

                RutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "documentos\\",
                    $"{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml");

                File.WriteAllBytes(RutaArchivo, Convert.FromBase64String(response.TramaXmlSinFirma));

                /**
                 *@Method Firmar()                 
                 * Se realiza el firmado del documento
                 * se usa await debido a que llama a un método asincrono, este no devuelve ningún valor
                 * 
                 */

                await Firmar();


                /**
                 * @val RutaAlterna
                 * Ruta donde se guardan los documentos C:\
                 * Evalua las rutas donde se van a guardar los documentos firmados, se guardan en 2 rutas para contrarestar pérdida de los mismos
                 * 
                 */

                switch (_documento.TipoDocumento)
                {

                    case "03":

                        File.WriteAllBytes($"{Program.CarpetaBoletas}\\{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml",
                                  Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));

                        File.WriteAllBytes(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\BOLETAS\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".xml",
                            Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));


                        break;
                    case "01":

                        File.WriteAllBytes($"{Program.CarpetaFacturas}\\{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml",
                                 Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));


                        File.WriteAllBytes(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\FACTURAS\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".xml",
                            Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));


                        break;
                }


                /**
                 * @Method GeneraPDF
                 * @Param CodFacturaVenta
                 * @resumenfirmadig Resumen de Firma Digital
                 * @firmadig Valor de Firma Digital 
                 **/

                resumenfirmadig = respuestaFirmado.ResumenFirma;
                firmadig = respuestaFirmado.ValorFirma;

                GeneraPDF(Convert.ToInt32(comprobante.CodComprobante));

                /**
                 * Set's para el repositorio de documentos                 
                 */


                string mirutadearchivo = "";
                repositorio.Tipodoc = comprobante.CodTipoComprobante;
                repositorio.Nombredoc = _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento;
                repositorio.Fechaemision = comprobante.Fechaemision;
                repositorio.Serie = comprobante.Serie;
                repositorio.Correlativo = comprobante.Scomprobante.Substring(5, 8);
                repositorio.Monto = Convert.ToDecimal(comprobante.Total);
                repositorio.CodEmpresa = comprobante.Codempresa;
                repositorio.CodSucursal = 1;
                repositorio.CodAlmacen = 1;
                repositorio.CodFacturaVenta = Convert.ToInt32(comprobante.CodComprobante);


                repositorio.Estadosunat = "-1";
                repositorio.Mensajesunat = "No enviada";

                if (repositorio.Tipodoc == 2)//1 es boleta,2 es factura
                {
                    mirutadearchivo = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\FACTURAS\\" + repositorio.Nombredoc + ".xml";
                }
                else
                {
                    mirutadearchivo = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\BOLETAS\\" + repositorio.Nombredoc + ".xml";
                }
                repositorio.Xml = File.ReadAllBytes(mirutadearchivo);
                repositorio.Pdf = File.ReadAllBytes(mirutadearchivo.Replace(".xml", ".pdf"));
                repositorio.Usuario = Session.CodUsuario;



                bool respuesta = CRepositorio.registra_repositorio(repositorio);

                if (respuesta == true)
                {
                    CRepositorio.registra_repositorioRespaldo(repositorio);
                }
                else
                {
                    MessageBox.Show("Documento no se pudo enviar al repositorio");
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                Cursor.Current = Cursors.Default;
            }


        }

        #endregion

        /**
        * Llenado de datos para la Factura
        * 
        **/

        private void DatosFactura(Promotor cliente, Comprobantee venta, List<DetalleComprobante> detalleventa)
        {
            try
            {
                _documento.Items.Clear();

                Int32 contadori = 1;
                foreach (DetalleComprobante lista in detalleventa)
                {            
                    var dtsItems = new DetalleDocumento
                    {
                        Id = contadori,
                        Cantidad = Convert.ToDecimal(lista.Cantidad),
                        UnidadMedida = CProducto.SiglaUnidadBase(lista.Unidadingresada),
                        CodigoItem = lista.CodProducto.ToString(),
                        //ItemClassificationCode = "82141601",// Este código será obligatorio para el 1-1-2019 - catálogo N° 15 del Anexo N° 8
                        Descripcion = lista.Descripcion.Trim(),
                        PrecioUnitario = Convert.ToDecimal(Math.Round((lista.Preciounitario / Convert.ToDecimal(1.18)), 2)),
                        PrecioReferencial = Convert.ToDecimal(lista.Preciounitario),
                        TipoPrecio = "01",
                        TipoImpuesto = lista.Tipoimpuesto.ToString(),
                        OtroImpuesto = 0,
                        Descuento = Convert.ToDecimal(lista.Descuento1),
                        Suma = Convert.ToDecimal(lista.Subtotal),
                        Impuesto = Convert.ToDecimal(lista.Igv),
                        ImpuestoSelectivo = 0,
                        TotalVenta = (Convert.ToDecimal(lista.Subtotal)) - Convert.ToDecimal(lista.Descuento1)
                    };


                    /**
                     * @param CodProducto
                     * @param CodAlmacen
                     * @return Object
                     **/


                    /*
                    productos = admProductos.CargaProducto(lista.CodProducto, frmLogin.iCodAlmacen);
                    if (productos.CodTipoArticulo == 2) // 2 - servicios
                    {
                        //comentado jkl no tiene la columna retencion
                        // _documento.MontoDetraccion = Convert.ToDecimal(Convert.ToDouble(_documento.Gravadas) * Convert.ToDouble(productos.Porcentajerentencion));
                    }

                    */

                    //Agregamos Detalle
                    _documento.Items.Add(dtsItems);
                    contadori++;
                }



                CalcularTotales();
            }
            catch (Exception a) { MessageBox.Show(a.Message); }
        }


        public async Task DatosNCreditoFirma(Promotor cliente, Comprobantee nc, List<DetalleComprobante> detalle_nc, int repoId)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string codsunat = "";


                _documento = new DocumentoElectronico();
                empresa = CEmpresa.CargaEmpresa();

                /**
                 * Carga TipoDocumento y Transacciones
                 * @param CodTipoDocumento
                 * @return TipoDocumento
                 * 
                 * @param CotTipoTransaccion
                 * @return Transacciones
                 **/

                doc = CTipoComprobante.CargaTipoDocumento(nc.CodTipoComprobante);
                transas = CTransaccion.MuestraTransaccion(nc.CodTransaccion);

                /**
                 * Carga la venta relacionada a la factura
                 * @Method CargaFacturaVenta
                 * @param CodReferencia
                 * 
                 **/

                //clsFacturaVenta venta = new clsFacturaVenta();
                //venta = admfac.CargaFacturaVenta(nc.CodReferencia);




                /**
                 *
                 * Objeto que tiene los datos del cliente
                 *
                 **/
                dtsReceptor = new Contribuyente()
                {
                    NroDocumento = cliente.Dni.Trim(),
                    //TipoDocumento = venta.DocumentoIdentidad.CodigoSunat.ToString(),
                    TipoDocumento = cliente.DocumentoIdentidad.Codsunat,
                    NombreLegal = cliente.Nombrecompleto.Trim(),
                    NombreComercial = "",
                    Direccion = cliente.Direccion.Trim()
                };

                /**
                 * @val _documento.TipoDocumento
                 *  01 Factura
                 *  03 Boleta
                 *  07 NC
                 *  08 ND            
                 * 
                 **/

                if (_documento.TipoDocumento == "01")
                {

                    if (nc.Formapago == 6)
                    {
                        _documento.FormaPago = new WinApp.Comun.Dto.Modelos.PaymentMeans
                        {
                            ID = "FormaPago",
                            PaymentMeansCode = "Contado",
                            Monto = 0m
                        };
                    }
                    else
                    {
                        _documento.FormaPago = new WinApp.Comun.Dto.Modelos.PaymentMeans
                        {
                            ID = "FormaPago",
                            PaymentMeansCode = "Credito",
                            Monto = nc.Total
                        };


                        //Si forma de pago es Credito se agregan las cuotas restantes
                        _documento.TerminosPagos = new List<WinApp.Comun.Dto.Modelos.PaymentTerms>() {
                           new WinApp.Comun.Dto.Modelos.PaymentTerms{
                               PaymentMeansID = "Cuota001",
                                Amount = nc.Total,
                                PaymentDueDate = DateTime.Today
                           },
                            new WinApp.Comun.Dto.Modelos.PaymentTerms{
                               PaymentMeansID = "Cuota002",
                                Amount = 50m,
                                PaymentDueDate = DateTime.Today
                           },
                            new WinApp.Comun.Dto.Modelos.PaymentTerms{
                               PaymentMeansID = "Cuota003",
                                Amount = 80m,
                                PaymentDueDate = DateTime.Today
                           }
                     };
                    }
                }



                _documento.TipoDocumento = doc.Codsunat.ToString();

                _documento.Receptor = dtsReceptor;
                _documento.FechaEmision = nc.Fechaemision.Date.ToString();
                _documento.TipoOperacion = transas.Codsunat;//0101 - Venta interna


                /**
                * 
                * Valida el tipo de moneda
                * 
                **/

                if (nc.Comprobanterelacionado.Codmoneda == 1)
                {
                    _documento.Moneda = "PEN";
                }
                else
                {
                    _documento.Moneda = "USD";
                }

                /**
                 * Consulta y valída contribuyente
                 * @param Codempresa
                 * @return 1 - 2
                 * 1 válido 
                 * 2 error
                 **/

                VerificaContribuyente = DatosComtribuyente(nc.Comprobanterelacionado.Codempresa);

                if (VerificaContribuyente == 2)
                {
                    MessageBox.Show("No se puede generar documento\n Falta cargar datos de la empresa");
                    return;
                }



                Int32 contador = 1;
                foreach (DetalleComprobante lista in detalle_nc)
                {
                    var dtsItems = new DetalleDocumento
                    {
                        Id = contador,
                        Cantidad = Convert.ToDecimal(lista.Cantidad),
                        UnidadMedida = CProducto.SiglaUnidadBase(lista.Unidadingresada),
                        CodigoItem = contador.ToString(),
                        //ItemClassificationCode = "82141601",
                        Descripcion = lista.Descripcion.Trim(),
                        PrecioUnitario = Convert.ToDecimal(lista.Subtotal),
                        PrecioReferencial = Convert.ToDecimal(lista.Preciounitario),
                        TipoPrecio = "01",
                        TipoImpuesto = lista.Tipoimpuesto.ToString(),
                        OtroImpuesto = 0,
                        Descuento = 0,
                        Suma = Convert.ToDecimal(lista.Subtotal) * Convert.ToDecimal(lista.Cantidad),
                        Impuesto = (Convert.ToDecimal(lista.Subtotal) * Convert.ToDecimal(lista.Cantidad)) * _documento.CalculoIgv,
                        ImpuestoSelectivo = 0,
                        TotalVenta = (Convert.ToDecimal(lista.Subtotal) * Convert.ToDecimal(lista.Cantidad)) - Convert.ToDecimal(lista.Descuento1)
                    };




                    //Agregamos Detalle
                    _documento.Items.Add(dtsItems);
                    contador++;
                }


                /**
                 * 
                 * Verifica si el tipo de documento al que se relaciona
                 * es Boleta - Factura, y según eso se le asigna la serie
                 **/

                if (nc.Comprobanterelacionado.CodTipoComprobante == 2)
                {
                    _documento.IdDocumento = nc.Scomprobante;
                    _documento.TipoDocumento = doc.Codsunat;
                    _documento.TipoOperacion = transas.Codsunat;
                }
                else if (nc.Comprobanterelacionado.CodTipoComprobante == 1)
                {
                    _documento.IdDocumento = nc.Scomprobante;
                    _documento.TipoDocumento = doc.Codsunat;
                    _documento.TipoOperacion = transas.Codsunat;
                }


                _documento.Receptor = dtsReceptor;

                /**
                 * 
                 * Calcula Totales
                 **/
                CalcularTotales();



                /**
                 * 
                 * Verificamos y agregamos documento relaciona a la NC
                 **/

                var dtsDocumentoRelacionado = new DocumentoRelacionado
                {
                    NroDocumento = nc.Comprobanterelacionado.CodTipoComprobante == 2 ? nc.Comprobanterelacionado.Scomprobante : nc.Comprobanterelacionado.Scomprobante,
                    TipoDocumento = nc.Comprobanterelacionado.CodTipoComprobante == 2 ? "01" : "03"
                };
                _documento.Relacionados.Add(dtsDocumentoRelacionado);



                List<DiscrepanciaNotaCredito> lista_discrepancia_ncc = null;
                lista_discrepancia_ncc = CDiscrepanciaNotaCredito.listar_discrepancia_ncc();

                switch (numdiscrepancia)
                {
                    case 1:
                        numdiscrepancia = 0;
                        break;
                    case 2:
                        numdiscrepancia = 1;
                        break;
                    case 3:
                        numdiscrepancia = 2;
                        break;

                }


                var dtsDiscrepancia = new Discrepancia
                {
                    NroReferencia = nc.Comprobanterelacionado.Scomprobante,
                    Tipo = lista_discrepancia_ncc[numdiscrepancia].Codsunat,
                    Descripcion = lista_discrepancia_ncc[numdiscrepancia].Descripcion
                };
                _documento.Discrepancias.Add(dtsDiscrepancia);




                /**
                 * @val  serializador
                 * Serializa todo el objeto _documento y es enviado al método Post
                 * 
                 * @param _documento
                 * @method GenerarFactura
                 * Tener en cuenta que estos métodos son Asyncronos
                 * @return response
                 * 
                 * 
                 **/
                ISerializador serializador = new Serializador();
                DocumentoResponse response = new DocumentoResponse
                {
                    Exito = false
                };
                response = await new GenerarNotaCredito(serializador).Post(_documento);

                /**
                 * @return response | type bool
                 * True | Guarda el archivo XML en carpeta
                 * false | Muestra Error
                 * RutaArchivo | Todos los documentos sin firmar se guardan en esa ruta
                 **/
                if (!response.Exito)
                    MessageBox.Show(response.MensajeError);



                RutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "documentos\\",
              $"{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml");

                if (System.IO.File.Exists(RutaArchivo))
                    System.IO.File.Delete(RutaArchivo);


                RutaArchivoEnvio = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\NOTAS CREDITO\\" + _documento.IdDocumento + ".xml";


                if (System.IO.File.Exists(RutaArchivoEnvio))
                    System.IO.File.Delete(RutaArchivoEnvio);

                File.WriteAllBytes(RutaArchivo, Convert.FromBase64String(response.TramaXmlSinFirma));


                /**
                 *@Method Firmar()                 
                 * Se realiza el firmado del documento
                 * se usa await debido a que llama a un método asincrono, este no devuelve ningún valor
                 * 
                 */


                //firma

                string rutacertifik;
                rutacertifik = @"C:\DOCUMENTOS-" + empresa.Ruc.Trim() + "\\CERTIFIK\\" + empresa.Certificado.Trim();

                if (string.IsNullOrEmpty(_documento.IdDocumento))
                {
                    MessageBox.Show("La Serie y el Correlativo no pueden estar vacíos");
                    return;
                }

                /**
                 * Lee el XML sin firma en la ruta especificada
                 * 
                 **/

                var tramaXmlSinFirma = Convert.ToBase64String(File.ReadAllBytes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "documentos\\",
                    $"{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml")));

                /**
                 * @val UnSoloNodoExtension 
                 * 
                 * Ya no es necesario evaluar si es True o False
                 */

                var firmadoRequest = new FirmadoRequest
                {
                    TramaXmlSinFirma = tramaXmlSinFirma,
                    CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\CERTIFIK\\" + empresa.Certificado)),
                    //CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(rutacertifik)),
                    PasswordCertificado = empresa.Contrasena,
                    UnSoloNodoExtension = false
                };

                ICertificador certificador = new Certificador();
                respuestaFirmado = await new Firmar(certificador).Post(firmadoRequest);


                //firma


                /**
                 * @val RutaAlterna
                 * Ruta donde se guardan los documentos C:\
                 * Evalua las rutas donde se van a guardar los documentos firmados, se guardan en 2 rutas para contrarestar pérdida de los mismos
                 * 
                 */


                File.WriteAllBytes($"{Program.CarpetaNC}\\{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml",
                            Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));

                File.WriteAllBytes(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\NOTAS CREDITO\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".xml",
                    Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));



                /**
                 * @Method GeneraPDF_NC
                 * @Param CodFacturaVenta
                 * @resumenfirmadig Resumen de Firma Digital
                 * @firmadig Valor de Firma Digital 
                 **/

                resumenfirmadig = respuestaFirmado.ResumenFirma;
                firmadig = respuestaFirmado.ValorFirma;


                /**
                 * Set's para el repositorio de documentos                 
                 */

                string mirutadearchivo = "";

                repositorio.Repoid = repoId;
                repositorio.Nombredoc = _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento;

                mirutadearchivo = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\NOTAS CREDITO\\" + repositorio.Nombredoc + ".xml";

                repositorio.Xml = File.ReadAllBytes(mirutadearchivo);
                repositorio.Usuario = Session.CodUsuario;

                if (!CRepositorio.actualiza_repositorio_xml(repositorio))
                {
                    MessageBox.Show("Documento no se pudo enviar al repositorio");
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                Cursor.Current = Cursors.Default;
            }

        }



        public async void DatosNCredito(Promotor cliente, Comprobantee nc, List<DetalleComprobante> detalle_nc)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                string codsunat = "";


                _documento = new DocumentoElectronico();
                empresa = CEmpresa.CargaEmpresa();

                /**
                 * Carga TipoDocumento y Transacciones
                 * @param CodTipoDocumento
                 * @return TipoDocumento
                 * 
                 * @param CotTipoTransaccion
                 * @return Transacciones
                 **/

                doc = CTipoComprobante.CargaTipoDocumento(nc.CodTipoComprobante);
                transas = CTransaccion.MuestraTransaccion(nc.CodTransaccion);

                /**
                 * Carga la venta relacionada a la factura
                 * @Method CargaFacturaVenta
                 * @param CodReferencia
                 * 
                 **/

                //clsFacturaVenta venta = new clsFacturaVenta();
                //venta = admfac.CargaFacturaVenta(nc.CodReferencia);




                /**
                 *
                 * Objeto que tiene los datos del cliente
                 *
                 **/
                dtsReceptor = new Contribuyente()
                {
                    NroDocumento = cliente.Dni.Trim(),
                    //TipoDocumento = venta.DocumentoIdentidad.CodigoSunat.ToString(),
                    TipoDocumento = cliente.DocumentoIdentidad.Codsunat,
                    NombreLegal = cliente.Nombrecompleto.Trim(),
                    NombreComercial = "",
                    Direccion = cliente.Direccion.Trim()
                };

                /**
                 * @val _documento.TipoDocumento
                 *  01 Factura
                 *  03 Boleta
                 *  07 NC
                 *  08 ND            
                 * 
                 **/


                if (_documento.TipoDocumento == "01")
                {

                    if (nc.Formapago == 6)
                    {
                        _documento.FormaPago = new WinApp.Comun.Dto.Modelos.PaymentMeans
                        {
                            ID = "FormaPago",
                            PaymentMeansCode = "Contado",
                            Monto = 0m
                        };
                    }
                    else
                    {
                        _documento.FormaPago = new WinApp.Comun.Dto.Modelos.PaymentMeans
                        {
                            ID = "FormaPago",
                            PaymentMeansCode = "Credito",
                            Monto = nc.Total
                        };


                        //Si forma de pago es Credito se agregan las cuotas restantes
                        _documento.TerminosPagos = new List<WinApp.Comun.Dto.Modelos.PaymentTerms>() {
                           new WinApp.Comun.Dto.Modelos.PaymentTerms{
                               PaymentMeansID = "Cuota001",
                                Amount = nc.Total,
                                PaymentDueDate = DateTime.Today
                           },
                            new WinApp.Comun.Dto.Modelos.PaymentTerms{
                               PaymentMeansID = "Cuota002",
                                Amount = 50m,
                                PaymentDueDate = DateTime.Today
                           },
                            new WinApp.Comun.Dto.Modelos.PaymentTerms{
                               PaymentMeansID = "Cuota003",
                                Amount = 80m,
                                PaymentDueDate = DateTime.Today
                           }
                     };
                    }
                }




                _documento.TipoDocumento = doc.Codsunat.ToString();

                _documento.Receptor = dtsReceptor;
                _documento.FechaEmision = DateTime.Today.ToShortDateString();
                _documento.TipoOperacion = transas.Codsunat;//0101 - Venta interna


                /**
                * 
                * Valida el tipo de moneda
                * 
                **/

                if (nc.Comprobanterelacionado.Codmoneda == 1)
                {
                    _documento.Moneda = "PEN";
                }
                else
                {
                    _documento.Moneda = "USD";
                }

                /**
                 * Consulta y valída contribuyente
                 * @param Codempresa
                 * @return 1 - 2
                 * 1 válido 
                 * 2 error
                 **/

                VerificaContribuyente = DatosComtribuyente(nc.Comprobanterelacionado.Codempresa);

                if (VerificaContribuyente == 2)
                {
                    MessageBox.Show("No se puede generar documento\n Falta cargar datos de la empresa");
                    return;
                }



                Int32 contador = 1;
                foreach (DetalleComprobante lista in detalle_nc)
                {
                    var dtsItems = new DetalleDocumento
                    {
                        Id = contador,
                        Cantidad = Convert.ToDecimal(lista.Cantidad),
                        UnidadMedida = CProducto.SiglaUnidadBase(lista.Unidadingresada),
                        CodigoItem = contador.ToString(),
                        //ItemClassificationCode = "82141601",
                        Descripcion = lista.Descripcion.Trim(),
                        PrecioUnitario = Convert.ToDecimal(Math.Round((lista.Preciounitario / Convert.ToDecimal(1.18)), 2)),
                        PrecioReferencial = Convert.ToDecimal(lista.Preciounitario),
                        TipoPrecio = "01",
                        TipoImpuesto = lista.Tipoimpuesto.ToString(),
                        OtroImpuesto = 0,
                        Descuento = 0,
                        Suma = Convert.ToDecimal(lista.Subtotal),
                        Impuesto = lista.Igv,
                        ImpuestoSelectivo = 0,
                        TotalVenta = Convert.ToDecimal(lista.Subtotal) - Convert.ToDecimal(lista.Descuento1)
                    };


                    /**
                      * @param CodProducto
                      * @param CodAlmacen
                      * @return Object
                      **/

                    /*
                    productos = admProductos.CargaProducto(lista.CodProducto, frmLogin.iCodAlmacen);

                    if (productos.CodTipoArticulo == 2) // 2 - servicios
                    {
                        // _documento.MontoDetraccion = Convert.ToDecimal(Convert.ToDouble(_documento.Gravadas) * Convert.ToDouble(productos.Porcentajerentencion));
                    }
                    */

                    //Agregamos Detalle
                    _documento.Items.Add(dtsItems);
                    contador++;
                }


                /**
                 * 
                 * Verifica si el tipo de documento al que se relaciona
                 * es Boleta - Factura, y según eso se le asigna la serie
                 **/

                if (nc.Comprobanterelacionado.CodTipoComprobante == 2)
                {
                    _documento.IdDocumento = nc.Scomprobante;
                    _documento.TipoDocumento = doc.Codsunat;
                    _documento.TipoOperacion = transas.Codsunat;
                }
                else if (nc.Comprobanterelacionado.CodTipoComprobante == 1)
                {
                    _documento.IdDocumento = nc.Scomprobante;
                    _documento.TipoDocumento = doc.Codsunat;
                    _documento.TipoOperacion = transas.Codsunat;
                }


                _documento.Receptor = dtsReceptor;

                /**
                 * 
                 * Calcula Totales
                 **/
                CalcularTotales();



                /**
                 * 
                 * Verificamos y agregamos documento relaciona a la NC
                 **/

                var dtsDocumentoRelacionado = new DocumentoRelacionado
                {
                    NroDocumento = nc.Comprobanterelacionado.CodTipoComprobante == 2 ? nc.Comprobanterelacionado.Scomprobante : nc.Comprobanterelacionado.Scomprobante,
                    TipoDocumento = nc.Comprobanterelacionado.CodTipoComprobante == 2 ? "01" : "03"
                };
                _documento.Relacionados.Add(dtsDocumentoRelacionado);



                List<DiscrepanciaNotaCredito> lista_discrepancia_ncc = null;
                lista_discrepancia_ncc = CDiscrepanciaNotaCredito.listar_discrepancia_ncc();

                switch (numdiscrepancia)
                {
                    case 1:
                        numdiscrepancia = 0;
                        break;
                    case 2:
                        numdiscrepancia = 1;
                        break;
                    case 3:
                        numdiscrepancia = 2;
                        break;

                }

                /*

                Discrepancia disk = new Discrepancia();

                disk.Descripcion = lista_discrepancia_ncc[numdiscrepancia].Descripcion;
                disk.NroReferencia = nc.Comprobanterelacionado.Scomprobante;
                disk.Tipo = lista_discrepancia_ncc[numdiscrepancia].Codsunat;*/



                var dtsDiscrepancia = new Discrepancia
                {
                    NroReferencia = nc.Comprobanterelacionado.Scomprobante,
                    Tipo = lista_discrepancia_ncc[numdiscrepancia].Codsunat,
                    Descripcion = lista_discrepancia_ncc[numdiscrepancia].Descripcion
                };
                _documento.Discrepancias.Add(dtsDiscrepancia);




                /**
                 * @val  serializador
                 * Serializa todo el objeto _documento y es enviado al método Post
                 * 
                 * @param _documento
                 * @method GenerarFactura
                 * Tener en cuenta que estos métodos son Asyncronos
                 * @return response
                 * 
                 * 
                 **/
                ISerializador serializador = new Serializador();
                DocumentoResponse response = new DocumentoResponse
                {
                    Exito = false
                };
                response = await new GenerarNotaCredito(serializador).Post(_documento);

                /**
                 * @return response | type bool
                 * True | Guarda el archivo XML en carpeta
                 * false | Muestra Error
                 * RutaArchivo | Todos los documentos sin firmar se guardan en esa ruta
                 **/
                if (!response.Exito)
                    MessageBox.Show(response.MensajeError);

                RutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "documentos\\",
                    $"{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml");

                File.WriteAllBytes(RutaArchivo, Convert.FromBase64String(response.TramaXmlSinFirma));

                /**
                 *@Method Firmar()                 
                 * Se realiza el firmado del documento
                 * se usa await debido a que llama a un método asincrono, este no devuelve ningún valor
                 * 
                 */

                await Firmar();


                /**
                 * @val RutaAlterna
                 * Ruta donde se guardan los documentos C:\
                 * Evalua las rutas donde se van a guardar los documentos firmados, se guardan en 2 rutas para contrarestar pérdida de los mismos
                 * 
                 */


                File.WriteAllBytes($"{Program.CarpetaNC}\\{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml",
                            Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));

                File.WriteAllBytes(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\NOTAS CREDITO\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".xml",
                    Convert.FromBase64String(respuestaFirmado.TramaXmlFirmado));



                /**
                 * @Method GeneraPDF_NC
                 * @Param CodFacturaVenta
                 * @resumenfirmadig Resumen de Firma Digital
                 * @firmadig Valor de Firma Digital 
                 **/

                resumenfirmadig = respuestaFirmado.ResumenFirma;
                firmadig = respuestaFirmado.ValorFirma;

                GeneraPDF_NC(Convert.ToInt32(nc.CodComprobante));

                /**
                 * Set's para el repositorio de documentos                 
                 */


                string mirutadearchivo = "";
                repositorio.Tipodoc = nc.CodTipoComprobante;
                repositorio.Nombredoc = _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento; ;
                repositorio.Fechaemision = nc.Fechaemision;
                repositorio.Serie = nc.Serie;
                repositorio.Correlativo = nc.Scomprobante.Substring(5, 8);
                repositorio.Monto = Convert.ToDecimal(nc.Total);
                repositorio.Estadosunat = "-1";
                repositorio.Mensajesunat = "No enviada";
                mirutadearchivo = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\NOTAS CREDITO\\" + repositorio.Nombredoc + ".xml";
                repositorio.Xml = File.ReadAllBytes(mirutadearchivo);
                repositorio.Pdf = File.ReadAllBytes(mirutadearchivo.Replace(".xml", ".pdf"));
                repositorio.Usuario = Session.CodUsuario;
                repositorio.CodEmpresa = Session.CodEmpresa;
                repositorio.CodSucursal = 1;
                repositorio.CodAlmacen = 1;
                repositorio.CodFacturaVenta = Convert.ToInt32(nc.CodComprobante);
                repositorio.TipDocRelacion = _documento.IdDocumento;




                if (!CRepositorio.registra_repositorio(repositorio))
                {
                    MessageBox.Show("Documento no se pudo enviar al repositorio");
                }
                else
                {
                    CRepositorio.registra_repositorioRespaldo(repositorio);
                }



            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                Cursor.Current = Cursors.Default;
            }

        }

        private void CalcularTotales()
        {
            // Realizamos los cálculos respectivos.

            _documento.TotalIgv = _documento.Items.Sum(d => d.Impuesto);
            _documento.TotalIsc = _documento.Items.Sum(d => d.ImpuestoSelectivo);
            _documento.TotalOtrosTributos = _documento.Items.Sum(d => d.OtroImpuesto);

            _documento.Gravadas = _documento.Items
                .Where(d => d.TipoImpuesto.StartsWith("1"))
                .Sum(d => d.Suma);

            _documento.Exoneradas = _documento.Items
                .Where(d => d.TipoImpuesto.Contains("20"))
                .Sum(d => d.Suma);

            _documento.Inafectas = _documento.Items
                .Where(d => d.TipoImpuesto.StartsWith("3") || d.TipoImpuesto.Contains("40"))
                .Sum(d => d.Suma);

            _documento.Gratuitas = _documento.Items
                .Where(d => d.TipoImpuesto.Contains("21"))
                .Sum(d => d.Suma);
            _documento.LineCountNumeric = Convert.ToString(_documento.Items.Count());
            // Cuando existe ISC se debe recalcular el IGV.
            if (_documento.TotalIsc > 0)
            {
                _documento.TotalIgv = (_documento.Gravadas + _documento.TotalIsc) * _documento.CalculoIgv;
                // Se recalcula nuevamente el Total de Venta.
            }

            _documento.TotalVenta = _documento.Gravadas + _documento.Exoneradas + _documento.Inafectas +
                                    _documento.TotalIgv + _documento.TotalIsc + _documento.TotalOtrosTributos;


        }

        async Task Firmar()
        {
            try
            {

                string rutacertifik;
                rutacertifik = @"C:\DOCUMENTOS-" + empresa.Ruc.Trim() + "\\CERTIFIK\\" + empresa.Certificado.Trim();

                if (string.IsNullOrEmpty(_documento.IdDocumento))
                {
                    MessageBox.Show("La Serie y el Correlativo no pueden estar vacíos");
                    return;
                }

                /**
                 * Lee el XML sin firma en la ruta especificada
                 * 
                 **/

                var tramaXmlSinFirma = Convert.ToBase64String(File.ReadAllBytes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "documentos\\",
                    $"{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml")));

                /**
                 * @val UnSoloNodoExtension 
                 * 
                 * Ya no es necesario evaluar si es True o False
                 */

                var firmadoRequest = new FirmadoRequest
                {
                    TramaXmlSinFirma = tramaXmlSinFirma,
                    CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\CERTIFIK\\" + empresa.Certificado)),
                    //CertificadoDigital = Convert.ToBase64String(File.ReadAllBytes(rutacertifik)),
                    PasswordCertificado = empresa.Contrasena,
                    UnSoloNodoExtension = false
                };

                ICertificador certificador = new Certificador();
                respuestaFirmado = await new Firmar(certificador).Post(firmadoRequest);

                if (!respuestaFirmado.Exito)
                {

                    MessageBox.Show(respuestaFirmado.MensajeError);
                    return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        public async Task Enviar(Empresa empresa, string IdDocumento, string TipoDocumento, string TramaXmlFirmado)
        {
            try
            {
                var enviarDocumentoRequest = new EnviarDocumentoRequest
                {
                    Ruc = empresa.Ruc.Trim(),
                    UsuarioSol = empresa.UsuarioSunat.Trim().ToUpper(),
                    ClaveSol = empresa.ClaveSunat.Trim(),
                    EndPointUrl = empresa.UrlSunat.Trim(),
                    IdDocumento = IdDocumento,
                    TipoDocumento = TipoDocumento,
                    TramaXmlFirmado = TramaXmlFirmado
                };

                ISerializador serializador = new Serializador();
                IServicioSunatDocumentos servicioSunatDocumentos = new ServicioSunatDocumentos();

                respuestaEnvio = await new EnviarDocumento(serializador, servicioSunatDocumentos).PostSunat(enviarDocumentoRequest);

                rpta = (EnviarDocumentoResponse)respuestaEnvio;

                if(rpta!=null)
                {
                    if(rpta.MensajeError!=null)
                    { 
                        if(rpta.MensajeError.Length>=2000)
                        {
                            rpta.MensajeError = rpta.MensajeError.Substring(0, 2000);
                        }
                    }
                }

                try
                {


                    switch (TipoDocumento)
                    {
                        case "07":
                            File.WriteAllBytes($"{Program.CarpetaNC}\\{empresa.Ruc + "-" + TipoDocumento + "-" + IdDocumento}.xml",
                                       Convert.FromBase64String(TramaXmlFirmado));

                            File.WriteAllBytes(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\NOTAS CREDITO\\" + empresa.Ruc + "-" + TipoDocumento + "-" + IdDocumento + ".xml",
                          Convert.FromBase64String(TramaXmlFirmado));

                            break;
                        case "08":

                            File.WriteAllBytes($"{Program.CarpetaND}\\{empresa.Ruc + "-" + TipoDocumento + "-" + IdDocumento}.xml",
                                       Convert.FromBase64String(TramaXmlFirmado));

                            File.WriteAllBytes(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\NOTAS DEBITO\\" + empresa.Ruc + "-" + TipoDocumento + "-" + IdDocumento + ".xml",
                          Convert.FromBase64String(TramaXmlFirmado));

                            break;
                        case "03":

                            File.WriteAllBytes($"{Program.CarpetaBoletas}\\{empresa.Ruc + "-" + TipoDocumento + "-" + IdDocumento}.xml",
                                      Convert.FromBase64String(TramaXmlFirmado));

                            File.WriteAllBytes(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\BOLETAS\\" + empresa.Ruc + "-" + TipoDocumento + "-" + IdDocumento + ".xml",
                           Convert.FromBase64String(TramaXmlFirmado));

                            break;
                        case "01":

                            File.WriteAllBytes($"{Program.CarpetaFacturas}\\{empresa.Ruc + "-" + TipoDocumento + "-" + IdDocumento}.xml",
                                     Convert.FromBase64String(TramaXmlFirmado));

                            File.WriteAllBytes(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\FACTURAS\\" + empresa.Ruc + "-" + TipoDocumento + "-" + IdDocumento + ".xml",
                            Convert.FromBase64String(TramaXmlFirmado));

                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor.Current = Cursors.Default;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Cursor.Current = Cursors.Default;
            }
        }

        #endregion

        #region PDF'S
        /**
         * Métodos usados para generar PDF
         */

        public void GeneraPDF(Int32 codigo)
        {
            DataSet jes = new DataSet();
            DataSet abi = new DataSet();
            String RutaArch = "";
            String RutaXML = "";
            if (_documento.TipoDocumento == "01")
            {
                RutaArch = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\FACTURAS\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".xml";
                RutaXML = $"{Program.CarpetaFacturas}\\{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml";
            }
            else
            {
                RutaArch = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\BOLETAS\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".xml";
                RutaXML = $"{Program.CarpetaBoletas}\\{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml";
            }

            String[] cad = _documento.IdDocumento.Split('-');
            String[] fecha = _documento.FechaEmision.Split('/');

            datosAdicionales_CDB = _documento.Emisor.NroDocumento + "|" + _documento.TipoDocumento + "|" + cad[0].ToString() + "|" + cad[1].ToString() + "|"
                                   + _documento.TotalIgv + "|" + _documento.TotalVenta + "|" + fecha[2] + "-" + fecha[1] + "-" + fecha[0] + "|"
                                   + _documento.Receptor.TipoDocumento + "|" + _documento.Receptor.NroDocumento;

            CodigoCertificado = datosAdicionales_CDB + "|" + resumenfirmadig;

            QRCodeGenerator codigobarras = new QRCodeGenerator();
            QRCodeData qrcode = codigobarras.CreateQrCode(CodigoCertificado, QRCodeGenerator.ECCLevel.Q);
            QRCode qrco = new QRCode(qrcode);
            System.Drawing.Bitmap bm = qrco.GetGraphic(20);


            /*
            BarcodePDF417 codigobarras = new BarcodePDF417();
            codigobarras.Options = BarcodePDF417.PDF417_USE_ASPECT_RATIO;
            codigobarras.ErrorLevel = 5;
            codigobarras.YHeight = 6f;
            codigobarras.SetText(CodigoCertificado);
            System.Drawing.Bitmap bm = new System.Drawing.Bitmap(codigobarras.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White));*/


            bm.Save(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\CERTIFIK\\QR\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //bm.Save(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\CERTIFIK\\QR\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);



            LogoEmp = CargarImagen(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\CERTIFIK\\QR\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".jpeg");

            frmRptFactura form = new frmRptFactura();
            CRReporteFactura rpt = new CRReporteFactura();
            rpt.Load("CRReporteFactura.rpt");

            jes = clsReporteFactura.ReporteFactura2(Convert.ToInt32(codigo));

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
            form.crvReporteFactura.ReportSource = rpt;
            //form.ShowDialog();
            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, RutaArch.Replace(".xml", ".pdf"));
            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, RutaXML.Replace(".xml", ".pdf"));

            rpt.Close();
            rpt.Dispose();
        }

        public void GeneraPDF_NC(Int32 codigo)
        {
            DataSet jes = new DataSet();
            DataSet abi = new DataSet();
            String RutaArch = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\NOTAS CREDITO\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".xml";
            String RutaXML = $"{Program.CarpetaNC}\\{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml";

            String[] cad = _documento.IdDocumento.Split('-');
            String[] fecha = _documento.FechaEmision.Split('/');

            datosAdicionales_CDB = _documento.Emisor.NroDocumento + "|" + _documento.TipoDocumento + "|" + cad[0].ToString() + "|" + cad[1].ToString() + "|"
                                   + _documento.TotalIgv + "|" + _documento.TotalVenta + "|" + fecha[2] + "-" + fecha[1] + "-" + fecha[0] + "|"
                                   + _documento.Receptor.TipoDocumento + "|" + _documento.Receptor.NroDocumento;

            CodigoCertificado = datosAdicionales_CDB + "|" + resumenfirmadig;


            QRCodeGenerator codigobarras = new QRCodeGenerator();
            QRCodeData qrcode = codigobarras.CreateQrCode(CodigoCertificado, QRCodeGenerator.ECCLevel.Q);
            QRCode qrco = new QRCode(qrcode);
            System.Drawing.Bitmap bm = qrco.GetGraphic(20);



            /*
            BarcodePDF417 codigobarras = new BarcodePDF417();
            codigobarras.Options = BarcodePDF417.PDF417_USE_ASPECT_RATIO;
            codigobarras.ErrorLevel = 5;
            codigobarras.YHeight = 6f;
            codigobarras.SetText(CodigoCertificado);
            System.Drawing.Bitmap bm = new System.Drawing.Bitmap(codigobarras.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White));*/
            bm.Save(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\CERTIFIK\\QR\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);

            LogoEmp = CargarImagen(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\CERTIFIK\\QR\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".jpeg");

            frmRptNotaCredito form = new frmRptNotaCredito();
            CRNotaCreditoVenta rpt = new CRNotaCreditoVenta();
            rpt.Load("CRNotaCreditoVenta.rpt");

            jes = clsReporteFactura.ReportNotaCreditoVenta(Convert.ToInt32(codigo), 1);

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
            form.crvNotaCredito.ReportSource = rpt;
            form.ShowDialog();
            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, RutaArch.Replace(".xml", ".pdf"));
            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, RutaXML.Replace(".xml", ".pdf"));


            rpt.Close();
            rpt.Dispose();
        }
        public void GeneraPDF_ND(Int32 codigo)
        {
            /*
            DataSet jes = new DataSet();
            DataSet abi = new DataSet();
            String RutaArch = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\NOTAS DEBITO\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".xml";
            String RutaXML = $"{Program.CarpetaND}\\{_documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento}.xml";

            String[] cad = _documento.IdDocumento.Split('-');
            String[] fecha = _documento.FechaEmision.Split('/');

            datosAdicionales_CDB = _documento.Emisor.NroDocumento + "|" + _documento.TipoDocumento + "|" + cad[0].ToString() + "|" + cad[1].ToString() + "|"
                                   + _documento.TotalIgv + "|" + _documento.TotalVenta + "|" + fecha[2] + "-" + fecha[1] + "-" + fecha[0] + "|"
                                   + _documento.Receptor.TipoDocumento + "|" + _documento.Receptor.NroDocumento;

            CodigoCertificado = datosAdicionales_CDB + "|" + resumenfirmadig;




            BarcodePDF417 codigobarras = new BarcodePDF417();
            codigobarras.Options = BarcodePDF417.PDF417_USE_ASPECT_RATIO;
            codigobarras.ErrorLevel = 5;
            codigobarras.YHeight = 6f;
            codigobarras.SetText(CodigoCertificado);
            System.Drawing.Bitmap bm = new System.Drawing.Bitmap(codigobarras.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White));
            bm.Save(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\CERTIFIK\\QR\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);

            LogoEmp = CargarImagen(@"C:\DOCUMENTOS-" + empresa.Ruc + "\\CERTIFIK\\QR\\" + _documento.Emisor.NroDocumento + "-" + _documento.TipoDocumento + "-" + _documento.IdDocumento + ".jpeg");

            frmRptNotaDebito form = new frmRptNotaDebito();
            CRNotaDebitoVenta rpt = new CRNotaDebitoVenta();
            rpt.Load("CRNotaDebitoVenta.rpt");
            //clsNotasCreditoDebitoVenta ds2 = new clsNotasCreditoDebitoVenta();
            jes = ds1.ReportNotaDebitoVenta(Convert.ToInt32(codigo), frmLogin.iCodAlmacen);

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
            form.crvNotaDebito.ReportSource = rpt;
            form.ShowDialog();
            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, RutaArch.Replace(".xml", ".pdf"));
            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, RutaXML.Replace(".xml", ".pdf"));


            rpt.Close();
            rpt.Dispose();
            */
        }
        #endregion
        #region CargaImagen
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
        #endregion
    }
}
