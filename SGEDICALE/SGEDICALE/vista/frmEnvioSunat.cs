using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using SGEDICALE.SunatFacElec;
using System.IO;
using WinApp.Comun.Dto.Intercambio;
using iTextSharp.text.pdf;
using System.Net.Mail;
using System.Net;

using System.Text;

namespace SGEDICALE.vista
{
    public partial class frmEnvioSunat : DevComponents.DotNetBar.Office2007Form
    {

        private string estado = "-1";
        private List<Repositorio> lista_repositorio = null;
        private Empresa empresa = null;

        //private DataTable data;

        Facturacion facturacion = new Facturacion();

        SGEDICALE.SunatFacElec.Facturacion facturacionn = new SunatFacElec.Facturacion();
        public frmEnvioSunat()
        {
            InitializeComponent();
        }

        private void frmEnvioSunat_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = DateTime.Now.AddDays(-5);
            dtpFechaFin.Value = DateTime.Now;

            btnEnviarporCorreo.Enabled = false;
            btnenviartodos.Enabled = false;
            cargarestado();
        }


        public void cargarestado()
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {

                List<dynamic> listaestado = new List<dynamic>
                {
                    new {codigo=0,descripcion="NO ENVIADO" },
                    new{ codigo=1,descripcion ="ENVIADO"}
                };


                cb_estado.DataSource = listaestado;
                cb_estado.ValueMember = "codigo";
                cb_estado.DisplayMember = "descripcion";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        public void listar_repositorio()
        {

            this.Cursor = Cursors.WaitCursor;

            try
            {

                Herramientas her = new Herramientas();

                Image imagen_pdf = Image.FromFile(@"" + her.GetResourcesPath4() + "\\pdf.png");
                Image imagen_xml = Image.FromFile(@"" + her.GetResourcesPath4() + "\\xml.png");

                lista_repositorio = new List<Repositorio>();
                lista_repositorio = CRepositorio.listar_repositorio_filtrado(estado, 1, 1, dtpFechaInicio.Value, dtpFechaFin.Value);


                if (lista_repositorio != null)
                {
                    if (lista_repositorio.Count > 0)
                    {
                        btnenviartodos.Enabled = true;
                        btnEnviarporCorreo.Enabled = true;
                        dg_documentos.Rows.Clear();
                        foreach (Repositorio rep in lista_repositorio)
                        {
                            dg_documentos.Rows.Add(rep.Repoid, rep.Tipodoc, rep.Fechaemision, rep.Serie,
                                                   rep.Correlativo, rep.Monto, rep.Estadosunat, rep.Mensajesunat,
                                                    imagen_xml, rep.Nombredoc, rep.Usuario, rep.Fechaemision);
                        }
                    }
                    lbregistro.Text = lista_repositorio.Count.ToString() + " registros.";
                }
                else { dg_documentos.Rows.Clear(); }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }


        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            if (cb_estado != null)
            {
                if (cb_estado.Items.Count > 0)
                {

                    if (dtpFechaInicio.Value > dtpFechaFin.Value)
                    {
                        MessageBox.Show("Fecha de Inicio no puede ser mayor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Cursor = Cursors.Default;
                        return;
                    }

                    if (cb_estado.Text == "NO ENVIADO")
                    {
                        btn_envio.Enabled = true;
                        estado = "-1";

                        buttonX1.Visible = false;

                    }

                    if (cb_estado.Text == "ENVIADO")
                    {
                        buttonX1.Visible = false;
                        btn_envio.Enabled = false;
                        estado = "0";

                    }

                    listar_repositorio();
                }
            }

            this.Cursor = Cursors.Default;

        }


        public bool archivo_existe(string archivo)
        {

            try
            {
                return (File.Exists(archivo) ? true : false);
            }
            catch (Exception) { return false; }

        }

        public async void Envio()
        {

            this.Cursor = Cursors.WaitCursor;

            try
            {

                string rutadocumento = "";
                string rutapdf = "";

                //string firmaxml = "";
                string rutacertificado = "";
                string tipodocumento = "";
                string _iddocumento = "";
                string[] iddocumento = null;
                bool todocorrecto = false;

                empresa = CEmpresa.CargaEmpresa();

                string rutaboletas = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\BOLETAS\\";
                string rutafactura = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\FACTURAS\\";
                string rutanotas = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\DOCUMENTOS ENVIAR\\NOTAS CREDITO\\";

                if (lista_repositorio != null)
                {
                    if (lista_repositorio.Count > 0)
                    {

                        rutacertificado = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\CERTIFIK\\" + empresa.Certificado;

                        foreach (Repositorio r in lista_repositorio)
                        {
                            rutadocumento = "";
                            var TramaXmlFirmado = Convert.ToBase64String(r.Xml);

                            switch (r.Tipodoc)
                            {
                                case 1:
                                    rutadocumento = rutaboletas + r.Nombredoc + ".xml";
                                    if (!archivo_existe(rutadocumento))
                                    {
                                        File.WriteAllBytes(rutadocumento, r.Xml);
                                    }


                                    rutapdf = rutaboletas + r.Nombredoc + ".pdf";


                                    if (!archivo_existe(rutapdf))
                                    {
                                        if (r.Pdf != null)
                                        {
                                            File.WriteAllBytes(rutapdf, r.Pdf);
                                        }
                                    }


                                    break;//boleta

                                case 2:
                                    rutadocumento = rutafactura + r.Nombredoc + ".xml";
                                    if (!archivo_existe(rutadocumento))
                                    {
                                        File.WriteAllBytes(rutadocumento, r.Xml);
                                    }


                                    rutapdf = rutafactura + r.Nombredoc + ".pdf";
                                    if (!archivo_existe(rutapdf))
                                    {
                                        if (r.Pdf != null)
                                        {
                                            File.WriteAllBytes(rutapdf, r.Pdf);
                                        }
                                    }

                                    break;//factura

                                case 4:
                                    rutadocumento = rutanotas + r.Nombredoc + ".xml";
                                    if (!archivo_existe(rutadocumento))
                                    {
                                        File.WriteAllBytes(rutadocumento, r.Xml);
                                    }


                                    rutapdf = rutanotas + r.Nombredoc + ".pdf";
                                    if (!archivo_existe(rutapdf))
                                    {
                                        if (r.Pdf != null)
                                        {
                                            File.WriteAllBytes(rutapdf, r.Pdf);
                                        }
                                    }

                                    break;//notas
                            }

                            switch (r.Tipodoc)
                            {
                                case 1:
                                    tipodocumento = "03";
                                    iddocumento = r.Nombredoc.Split('-');
                                    _iddocumento = iddocumento[2] + "-" + r.Correlativo; break;//boleta
                                case 2:
                                    tipodocumento = "01";
                                    iddocumento = r.Nombredoc.Split('-');
                                    _iddocumento = iddocumento[2] + "-" + r.Correlativo; break;//factura
                                case 4:
                                case 29:
                                    tipodocumento = "07";
                                    iddocumento = r.Nombredoc.Split('-');
                                    _iddocumento = iddocumento[2] + "-" + r.Correlativo; break;
                                //_iddocumento = r.TipDocRelacion; break;//nota credito
                                case 6:
                                    tipodocumento = "08";
                                    iddocumento = r.Nombredoc.Split('-'); _iddocumento = iddocumento[2] + "-" + r.Correlativo; break;//nota debito                            
                            }


                            EnviarDocumentoResponse rpta;

                            await facturacion.Enviar(empresa, _iddocumento, tipodocumento, TramaXmlFirmado);

                            rpta = facturacion.rpta;


                            if (rpta != null)
                            {

                                if (rpta.CodigoRespuesta == "0" && rpta.TramaZipCdr != null)
                                {
                                    r.Estadosunat = "0";
                                    r.Mensajesunat = rpta.MensajeRespuesta == null ? "Documento Enviado" : rpta.MensajeRespuesta;
                                    String ruta = @"C:\DOCUMENTOS-" + empresa.Ruc + "\\CDR\\" + "R-" + r.Nombredoc + ".zip";
                                    File.WriteAllBytes(ruta, Convert.FromBase64String(rpta.TramaZipCdr));

                                    File.WriteAllBytes($"{Program.CarpetaCdr}\\{"R-" + r.Nombredoc + ".zip"}",
                                    Convert.FromBase64String(rpta.TramaZipCdr));

                                    //r.CDR = File.ReadAllBytes(ruta);

                                    if (File.Exists(ruta))
                                    {
                                        r.CDR = File.ReadAllBytes(ruta);
                                    }
                                    else
                                    {
                                        r.CDR = null;
                                    }

                                    todocorrecto = CRepositorio.actualiza_repositorio(r);
                                    CRepositorio.actualiza_repositorio_respaldo(r);
                                }
                                else
                                {
                                    r.Mensajesunat = rpta.MensajeRespuesta == null ? " " : rpta.MensajeRespuesta;

                                    if (rpta.CodigoRespuesta == "1033")
                                    {
                                        r.Estadosunat = "0";
                                        todocorrecto = true;
                                        CRepositorio.actualiza_repositorio(r);
                                        CRepositorio.actualiza_repositorio_respaldo(r);


                                    }
                                    else
                                    {

                                        if (rpta.MensajeError != null)
                                        {
                                            if (rpta.MensajeError.Contains("1033"))
                                            {
                                                r.Estadosunat = "0";
                                                todocorrecto = true;
                                                CRepositorio.actualiza_repositorio(r);
                                                CRepositorio.actualiza_repositorio_respaldo(r);
                                            }
                                            else
                                            {
                                                r.Estadosunat = "-1";

                                                if (rpta.MensajeError != null)
                                                {
                                                    if (rpta.MensajeError != "")
                                                    {
                                                        r.Mensajesunat = rpta.MensajeError;
                                                    }
                                                }

                                                CRepositorio.actualiza_repositorio(r);
                                                CRepositorio.actualiza_repositorio_respaldo(r);
                                            }
                                        }
                                        else
                                        {
                                            r.Estadosunat = "-1";

                                            if (rpta.MensajeError != null)
                                            {
                                                if (rpta.MensajeError != "")
                                                {

                                                    r.Mensajesunat = rpta.MensajeError;
                                                }
                                            }

                                            if (rpta.CodigoRespuesta == "2936")
                                            {

                                            }

                                            else
                                            {
                                                CRepositorio.actualiza_repositorio(r);
                                                CRepositorio.actualiza_repositorio_respaldo(r);
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        if (todocorrecto)
                        {

                            MessageBox.Show("Los documentos fueron enviados de forma correcta");

                            listar_repositorio();
                            //Thread.Sleep(5000);
                            //this.Close();
                        }
                        else
                        {

                            MessageBox.Show("No todos los documentos fueron enviados de forma correcta");
                            listar_repositorio();
                        }
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                this.Cursor = Cursors.Default;

            }
            this.Cursor = Cursors.Default;
        }

        private void listar_repositorio_Enviados()
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {
                Herramientas her = new Herramientas();

                Image imagen_pdf = Image.FromFile(@"" + her.GetResourcesPath4() + "\\pdf.png");
                Image imagen_xml = Image.FromFile(@"" + her.GetResourcesPath4() + "\\xml.png");

                lista_repositorio = new List<Repositorio>();
                lista_repositorio = CRepositorio.listar_repositorio_Enviados(estado, 1, 1, dtpFechaInicio.Value);

                if (lista_repositorio != null)
                {
                    if (lista_repositorio.Count > 0)
                    {
                        dg_documentos.Rows.Clear();
                        foreach (Repositorio rep in lista_repositorio)
                        {
                            dg_documentos.Rows.Add(rep.Repoid, rep.Tipodoc, rep.Fechaemision, rep.Serie,
                                                   rep.Correlativo, rep.Monto, rep.Estadosunat, rep.Mensajesunat,
                                                   imagen_xml, rep.Nombredoc, rep.Usuario, rep.Fechaemision);
                        }
                    }
                    lbregistro.Text = lista_repositorio.Count.ToString();
                }
                else
                {
                    dg_documentos.Rows.Clear();
                }
            }
            catch (Exception e)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(e.Message);
            }
            this.Cursor = Cursors.Default;
        }


        private void btn_envio_Click(object sender, EventArgs e)
        {
            Envio();
        }

        private void frmEnvioSunat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            cb_estado_SelectedIndexChanged(null, null);
        }

        private void btnEnviarporCorreo_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            string nombreasunto = "";

            try
            {

                int codrepoid = 0;
                Repositorio doc = null;

                if (dg_documentos.Rows.Count > 0)
                {

                    codrepoid = Convert.ToInt32(dg_documentos.CurrentRow.Cells[0].Value);
                    nombreasunto = dg_documentos.CurrentRow.Cells[3].Value.ToString();
                    nombreasunto = nombreasunto + "-" + dg_documentos.CurrentRow.Cells[4].Value.ToString();

                    nombreasunto = $"DOCUMENTO ELECTRONICO {nombreasunto}";


                    doc = CRepositorio.buscarComprobantexidRepo(codrepoid);

                    if (doc != null)
                    {

                        if (doc.Xml != null && doc.Pdf != null)
                        {

                            frmEnvioCorreo frmEnvio = new frmEnvioCorreo(doc, nombreasunto);
                            frmEnvio.Show();

                        }
                        else
                        {
                            MessageBox.Show("No se encontro el xml", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private async void buttonX1_Click(object sender, EventArgs e)
        {
            string ola = string.Empty;
            int codigo = 0;
            int repoid = 0;

            try
            {
                Comprobantee com = new Comprobantee();
                Promotor pro = new Promotor();
                List<DetalleComprobante> detcom = new List<DetalleComprobante>();

                if (dg_documentos.Rows.Count > 0)
                {
                    if (dg_documentos.CurrentCell != null)
                    {
                        if (dg_documentos.CurrentCell.RowIndex != -1)
                        {
                            estado = dg_documentos.Rows[dg_documentos.CurrentCell.RowIndex].Cells[6].Value.ToString();

                            if (estado == "-1")
                            {
                                codigo = Convert.ToInt32(dg_documentos.Rows[dg_documentos.CurrentCell.RowIndex].Cells[10].Value.ToString());
                                repoid = Convert.ToInt32(dg_documentos.Rows[dg_documentos.CurrentCell.RowIndex].Cells[0].Value.ToString());

                                com = CComprobante.buscacomprobante(codigo);
                                pro = CPromotor.buscarxcodigo(com.Codpromotor);
                                detcom = CComprobante.traer_detalle_comprobante_xidcomprobante(com);

                                if (com.CodTipoComprobante == 03 || com.CodTipoComprobante == 01)
                                {
                                    await facturacionn.GeneraDocumentoFirmado(pro, com, detcom, repoid);
                                }
                                else
                                {
                                    await facturacionn.DatosNCreditoFirma(pro, com, detcom, repoid);
                                }

                            }
                        }
                    }
                }

                /*
                foreach (Repositorio r in lista_repositorio)
                {

                    Comprobantee com = new Comprobantee();
                    Promotor pro = new Promotor();
                    List<DetalleComprobante> detcom = new List<DetalleComprobante>();

                    com = CComprobante.buscacomprobante(r.CodFacturaVenta);
                    pro = CPromotor.buscarxcodigo(com.Codpromotor);
                    detcom = CComprobante.traer_detalle_comprobante_xidcomprobante(com);

                    if (com.CodTipoComprobante == 03 || com.CodTipoComprobante == 01)
                    {
                        await facturacionn.GeneraDocumentoFirmado(pro, com, detcom, r.Repoid);
                    }
                    else
                    {
                        await facturacionn.DatosNCreditoFirma(pro, com, detcom, r.Repoid);
                    }
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;

            }



        }

        private void btnenviartodos_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            string nombreasunto = "";

            try
            {

                int codrepoid = 0;
                Repositorio doc = null;
                Promotor promotor = null;
                string mensaje = "";

                empresa = CEmpresa.CargaEmpresa();

                if (empresa.Email == null)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Registre un correo en el Menù Configuracion de Sistema=>Empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (empresa.Claveemail == null)
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("Registre un contraseña de correo en el Menù Configuracion de Sistema=>Empresa", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dg_documentos.Rows.Count > 0)
                {

                    for (int i = 0; i < dg_documentos.Rows.Count; i++)
                    {
                        mensaje = "";

                        codrepoid = Convert.ToInt32(dg_documentos.Rows[i].Cells[0].Value);
                        nombreasunto = dg_documentos.Rows[i].Cells[3].Value.ToString();
                        nombreasunto = nombreasunto + "-" + dg_documentos.Rows[i].Cells[4].Value.ToString();

                        nombreasunto = $"DOCUMENTO ELECTRONICO {nombreasunto}";

                        doc = CRepositorio.buscarComprobantexidRepo(codrepoid);

                        if (doc != null)
                        {
                            promotor = CPromotor.buscarxcodigocomprobante(doc.CodFacturaVenta);

                            if (doc.Xml != null && doc.Pdf != null)
                            {


                                StringBuilder sb = new StringBuilder();
                                sb.Append($"ESTIMADO CLIENTE: {promotor.Nombrecompleto}");
                                sb.AppendLine();
                                sb.Append($"SE ENVIA ADJUNTO EL DOCUMENTO ELECTRONICO: {nombreasunto}");
                                sb.AppendLine();
                                sb.Append("POR FAVOR NO RESPONDER ESTE MENSAJE");
                                mensaje = sb.ToString();

                                EnviarCorreo(empresa, promotor, doc, nombreasunto, mensaje);


                            }
                            else
                            {
                                MessageBox.Show("No se encontro el xml", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    MessageBox.Show("Correos enviados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnenviartodos.Enabled = false;
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }


        private void EnviarCorreo(Empresa empresa, Promotor promotor, Repositorio docElectronico, string asunto, string mensaje)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Attachment attXML = null;
                Attachment attPDF = null;

                var fromAddress = new MailAddress(empresa.Email, empresa.RazonSocial);
                var toAddress = new MailAddress(promotor.Email, promotor.Nombrecompleto.Trim());

                string fromPassword = empresa.Claveemail;

                string subject = asunto;
                string body = mensaje + ObtenerFirmaCorreo();

                attXML = new Attachment(new MemoryStream(docElectronico.Xml), $"{docElectronico.Serie}-{docElectronico.Correlativo}.xml");

                //MemoryStream str = new MemoryStream();
                // rep.ExportToPdf(str);

                //attPDF = new Attachment(new MemoryStream(str.ToArray()), $"{docElectronico.Serie}-{docElectronico.Correlativo}.pdf");
                attPDF = new Attachment(new MemoryStream(docElectronico.Pdf), $"{docElectronico.Serie}-{docElectronico.Correlativo}.pdf");

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    //Credentials = new NetworkCredential("marlon1428@gmail.com","981355668")
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                })
                {
                    message.Attachments.Add(attPDF);
                    message.Attachments.Add(attXML);
                    smtp.Send(message);

                }

                this.Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }


        }



        private string ObtenerFirmaCorreo()
        {
            return $@"<br/><table width='351' cellspacing='0' cellpadding='0' border='0'>
  <tr>
    <td style='text-align:left;padding-bottom:10px'>

    </td>
  </tr>
  <tr>
    <td style='border-top:solid #000000 2px' height='12'></td>
  </tr>
  <tr>
    <td
      style='vertical-align: top; text-align:left;color:#000000;font-size:12px;font-family:helvetica, arial;; text-align:left'
    >
      <span
        ><span style='margin-right:5px;color:#000000;font-size:15px;font-family:helvetica, arial'
          >{empresa.RazonSocial.Trim()}</span
        >
        <span style='margin-right:5px;color:#000000;font-size:12px;font-family:helvetica, arial'
          >-</span
        ><br /><span
          style='margin-right:5px;color:#000000;font-size:12px;font-family:helvetica, arial'
          >{empresa.Direccion.Trim()}</span
        ></span
      >
      <br /><br />
      <table cellpadding='0' cellpadding='0' border='0'>
        <tr></tr>
      </table>
    </td>
  </tr>
</table>";
        }


    }
}

