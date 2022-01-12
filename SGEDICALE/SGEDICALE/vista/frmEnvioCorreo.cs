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
using System.Net.Mail;
using System.Net;
using System.IO;

namespace SGEDICALE.vista
{
    public partial class frmEnvioCorreo : DevComponents.DotNetBar.Office2007Form
    {

        string asunto = "";
        string mensaje = "";

        private Empresa empresa = null;
        private Promotor promotor = null;

        private Repositorio docElectronico;

        public frmEnvioCorreo()
        {
            InitializeComponent();
        }

        public frmEnvioCorreo(Repositorio doc, string asunt)
        {
            InitializeComponent();
            docElectronico = doc;
            asunto = asunt;
        }

        private void frmEnvioCorreo_Load(object sender, EventArgs e)
        {

            try
            {
                empresa = CEmpresa.CargaEmpresa();


                if (docElectronico != null)
                {
                    promotor = CPromotor.buscarxcodigocomprobante(docElectronico.CodFacturaVenta);
                }

                txtAsunto.Text = asunto;
                txtPara.Text = "";

                if (empresa != null)
                {
                    txtDe.Text = empresa.Email;
                }

                if (promotor != null)
                {
                    txtPara.Text = promotor.Email;
                }

                StringBuilder sb = new StringBuilder();
                sb.Append($"ESTIMADO CLIENTE: {promotor.Nombrecompleto}");
                sb.AppendLine();
                sb.Append($"SE ENVIA ADJUNTO EL DOCUMENTO ELECTRONICO: {asunto}");
                sb.AppendLine();
                sb.Append("POR FAVOR NO RESPONDER ESTE MENSAJE");
                mensaje = sb.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }


        }

        private void btnEnviarporCorreo_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                Attachment attXML = null;
                Attachment attPDF = null;

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



                var fromAddress = new MailAddress(empresa.Email, empresa.Claveemail);
                var toAddress = new MailAddress(txtPara.Text, promotor.Nombrecompleto.Trim());

                string fromPassword = empresa.Claveemail;

                string subject = txtAsunto.Text;
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

                MessageBox.Show("Email enviado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

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
