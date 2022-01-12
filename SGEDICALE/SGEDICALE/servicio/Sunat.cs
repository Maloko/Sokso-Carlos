using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;
using SGEDICALE;
using System.Net.Http;

namespace Ñwinsoft_Ruc
{
    public class Sunat
    {
        #region Variables
        private string _RazonSocial;
        private string _Direcion;
        private string _Ruc;
        private string _EstadoContr;
        private string _TipoContr;
        private string _Telefono;
        private CookieContainer myCookie;
        private Resul state;
        #endregion

        #region contructor
        public Sunat()
        {
            try
            {
                myCookie = null;
                myCookie = new CookieContainer();
                //ServicePointManager.Expect100Continue = true;
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                ReadCapcha();
            }
            catch (Exception)
            {               
              
            }
        }
        #endregion

        #region propiedades
        public enum Resul
        {
            Ok = 0,
            NoResul = 1,
            ErrorCapcha = 2,
            Error = 3,
        }
        public Image GetCapcha
        {
            get { return ReadCapcha(); }
        }

        public string RazonSocial
        {
            get { return _RazonSocial; }
        }
        public string Direcion
        {
            get { return _Direcion; }
        }
        public string Ruc
        {
            get { return _Ruc; }
        }
        public string EstadoContr
        {
            get { return _EstadoContr; }
        }
        public string TipoContr
        {
            get { return _TipoContr; }
        }
        public string Telefono
        {
            get { return _Telefono; }
        }
        public Resul GetResul
        {
            get { return state; }
        }
        #endregion

     
        private CTipoCambio ctipocambio = new CTipoCambio();
        

        #region Metodos
        private Boolean ValidarCertificado(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
        private Image ReadCapcha()
        {
            try
            {
                System.Net.ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(ValidarCertificado);
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("http://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/captcha?accion=image");
                myWebRequest.CookieContainer = myCookie;
                myWebRequest.Proxy = null;
                myWebRequest.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                Stream myImgStream = myWebResponse.GetResponseStream();
                return Image.FromStream(myImgStream);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void GetInfo(string numRuc, string TextoCapcha)
        {
            try
            {
                //A este link le pasamos los datos , RUC y valor del captcha
                string myUrl = String.Format("http://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/jcrS00Alias?accion=consPorRuc&nroRuc={0}&codigo={1}", numRuc, TextoCapcha);
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create(myUrl);
                myWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:23.0) Gecko/20100101 Firefox/23.0";
                myWebRequest.CookieContainer = myCookie;
                myWebRequest.Credentials = CredentialCache.DefaultCredentials;
                myWebRequest.Proxy = null;
                HttpWebResponse myHttpWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                Stream myStream = myHttpWebResponse.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myStream);
                //Leemos los datos
                string xDat = HttpUtility.HtmlDecode(myStreamReader.ReadToEnd());
                string[] _split = xDat.Split(new char[] { '<', '>', '\n', '\r' });
                List<String> _result = new List<String>();
                //quitamos todos los caracteres nul
                for (int i = 0; i < _split.Length; i++)
                {
                    if (!string.IsNullOrEmpty(_split[i].Trim()))
                        _result.Add(_split[i].Trim());
                }
                if (_result.Count == 77)
                    state = Resul.ErrorCapcha;
                if (_result.Count == 147)
                    state = Resul.NoResul;
                if (_result.Count >= 635)
                    state = Resul.Ok;
                switch (state)
                {
                    case Resul.Ok:
                        StateOK(xDat, numRuc);
                        break;
                    case Resul.ErrorCapcha:
                        break;
                    case Resul.NoResul:
                        break;
                    default:
                        break;
                }
                myHttpWebResponse.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void StateOK(string xDat, string numRuc)
        {
            //declarar Variables
            string xRuc = string.Empty;
            string xRazSoc = string.Empty;
            string xDir = string.Empty;
            string xEsCn = string.Empty;
            string xTpCn = string.Empty;
            string xTef = string.Empty;
            string[] tabla;
            //reemplazar o quitar caracteres
            xDat = xDat.Replace("     ", " ");
            xDat = xDat.Replace("    ", " ");
            xDat = xDat.Replace("   ", " ");
            xDat = xDat.Replace("  ", " ");
            xDat = xDat.Replace("( ", "(");
            xDat = xDat.Replace(" )", ")");
            //convertir a tabla en un arreglo de string como se ve declarado arriba
            tabla = Regex.Split(xDat, "<td class");
            //Depende el numero de ruc 1 natural  o 2 empresa               
            if (numRuc.StartsWith("1"))
            {
                //reemplazar o quitar caracteres
                tabla[1] = tabla[1].Replace("=\"bg\" colspan=3>" + numRuc + " - ", "");
                tabla[1] = tabla[1].Replace("</td>\r\n </tr>\r\n <tr>\r\n", "");
                tabla[3] = tabla[3].Replace("=\"bg\" colspan=3>", "");
                tabla[3] = tabla[3].Replace("</td>\r\n </tr>\r\n \r\n <tr>\r\n ", "");
                tabla[8] = tabla[8].Replace("=\"bgn\" colspan=1 >", "");
                tabla[8] = tabla[8].Replace("</td>\r\n ", "");
                String NuevoRUS = tabla[8].Trim();
                //Nuevos RUS
                if (NuevoRUS == "Afecto al Nuevo RUS:")
                {
                    tabla[14] = tabla[14].Replace("=\"bg\" colspan=1>", "");
                    tabla[14] = tabla[14].Replace("</td>\r\n ", "");
                    tabla[19] = tabla[19].Replace("=\"bg\" colspan=3>", "");
                    tabla[19] = tabla[19].Replace("</td>\r\n </tr>\r\n<!-- SE COMENTO POR INDICACION DEL PASE PAS20134EA20000207 -->\r\n<!-- <tr> -->\r\n<!-- ", "");
                    tabla[21] = tabla[21].Replace("=\"bg\" colspan=1>", "");
                    tabla[21] = tabla[21].Replace("</td> -->\r\n<!-- ", "");
                    xEsCn = (string)tabla[14];
                    xDir = (string)tabla[19];
                    xTef = (string)tabla[21];
                }
                else
                {
                    tabla[12] = tabla[12].Replace("=\"bg\" colspan=1>", "");
                    tabla[12] = tabla[12].Replace("</td>\r\n ", "");
                    tabla[17] = tabla[17].Replace("=\"bg\" colspan=3>", "");
                    tabla[17] = tabla[17].Replace("</td>\r\n </tr>\r\n<!-- SE COMENTO POR INDICACION DEL PASE PAS20134EA20000207 -->\r\n<!-- <tr> -->\r\n<!-- ", "");
                    tabla[19] = tabla[19].Replace("=\"bg\" colspan=1>", "");
                    tabla[19] = tabla[19].Replace("</td> -->\r\n<!-- ", "");
                    xEsCn = (string)tabla[12];
                    xDir = (string)tabla[17];
                    xTef = (string)tabla[19];
                }
                xRuc = numRuc;
                xRazSoc = (string)tabla[1];
                xTpCn = (string)tabla[3];
            }
            else if (numRuc.StartsWith("2"))
            {
                //reemplazar o quitar caracteres
                tabla[1] = tabla[1].Replace("=\"bg\" colspan=3>" + numRuc + " - ", "");
                tabla[1] = tabla[1].Replace("</td>\r\n </tr>\r\n <tr>\r\n", "");
                tabla[3] = tabla[3].Replace("=\"bg\" colspan=3>", "");
                tabla[3] = tabla[3].Replace("</td>\r\n </tr>\r\n \r\n <tr>\r\n ", "");
                tabla[10] = tabla[10].Replace("=\"bg\" colspan=1>", "");
                tabla[10] = tabla[10].Replace("</td>\r\n", "");
                tabla[15] = tabla[15].Replace("=\"bg\" colspan=3>", "");
                tabla[15] = tabla[15].Replace("</td>\r\n </tr>\r\n<!-- SE COMENTO POR INDICACION DEL PASE PAS20134EA20000207 -->\r\n<!-- <tr> -->\r\n<!-- ", "");
                tabla[17] = tabla[17].Replace("=\"bg\" colspan=1>", "");
                tabla[17] = tabla[17].Replace("</td> -->\r\n<!-- ", "");
                xRuc = numRuc;
                xRazSoc = (string)tabla[1];
                xTpCn = (string)tabla[3];
                xEsCn = (string)tabla[10];
                xDir = (string)tabla[15];
                xTef = (string)tabla[17];
            }
            //los resultados
            _Ruc = xRuc;
            _TipoContr = xTpCn;
            _RazonSocial = xRazSoc;
            _Direcion = xDir;
            _EstadoContr = xEsCn;
            _Telefono = xTef;
        }


        public TipoCambio obtener_Tipo_Cambio()
        {

            TipoCambio tipocambio = null;

            try
            {
                
                HttpClient cliente = new HttpClient();
                cliente.BaseAddress = new Uri("http://www.sunat.gob.pe/");
                HttpResponseMessage rpta = cliente.GetAsync("cl-at-ittipcam/tcS01Alias").Result;

                if (rpta != null && rpta.IsSuccessStatusCode)
                {
                    string contenido = "";
                    using (MemoryStream ms = (MemoryStream)rpta.Content.ReadAsStreamAsync().Result)
                    {
                        byte[] buffer = ms.ToArray();
                        contenido = Encoding.UTF8.GetString(buffer);
                        contenido = contenido.ToLower();
                    }
                    if (contenido.Length > 0)
                    {
                        File.WriteAllText("Sunat.txt", contenido);
                        int posInicioT1 = contenido.IndexOf("<table");
                        int posFinT1 = contenido.IndexOf("</table");
                        if (posInicioT1 > -1 && posFinT1 > -1)
                        {
                            int posInicioT2 = contenido.IndexOf("<table", posInicioT1 + 1);
                            int posFinT2 = contenido.IndexOf("</table", posFinT1 + 1);
                            string tabla = contenido.Substring(posInicioT2, posFinT2 - posInicioT2 + 8);
                            File.WriteAllText("Tabla.txt", tabla);
                            posInicioT1 = 0;
                            tabla = tabla.Replace("</strong>", "");
                            List<string> valores = new List<string>();
                            for (int i = 1; i < 4; i++)
                            {
                                posInicioT1 = tabla.LastIndexOf("</td");
                                if (posInicioT1 > -1)
                                {
                                    tabla = tabla.Substring(0, posInicioT1).Trim();
                                    posFinT1 = tabla.LastIndexOf(">");
                                    if (posFinT1 > -1)
                                    {
                                        valores.Add(tabla.Substring(posFinT1 + 1, tabla.Length - posFinT1 - 1).Trim());
                                    }
                                }
                            }
                            if (valores.Count > 0)
                            {
                                if (valores[1] != "" && valores[0] != "")
                                {
                                    tipocambio = new TipoCambio();
                                    tipocambio.Compra = decimal.Parse(valores[1]);
                                    tipocambio.Venta = decimal.Parse(valores[0]);
                                    tipocambio.Codusuario = Session.CodUsuario;
                                    tipocambio.Fecha = DateTime.Now;
                                    tipocambio.Estado = 1;
                                }
                                else
                                {
                                    tipocambio = CTipoCambio.ultimo_tipocambio();
                                    if (tipocambio != null) {

                                        tipocambio.Fecha =DateTime.Now;
                                        tipocambio.Estado = 1;
                                    }
                                }

                            }


                        }


                    }


                }

                return tipocambio;

            }
            catch (Exception ex) {

                return tipocambio;
                throw ex;
            }
        }


    }
   
        #endregion

}