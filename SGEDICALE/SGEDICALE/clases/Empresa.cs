using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace SGEDICALE.clases
{
    public class Empresa
    {

        private Int32 iCodEmpresa;
        private Int32 iCodEmpresaNueva;
        private String sRazonSocial;
        private String sRuc;
        private String sDireccion;
        private String sTelefono;
        private String sFax;
        private String email;
        private String claveemail;
        private String sRepresentante;
        private Boolean iEstado;
        private Int32 iCodUser;
        private DateTime dtFechaRegistro;
        private Image fotografia;

        public String Certificado { get; set; }
        public String Contrasena { get; set; }
        public String UsuarioSunat { get; set; }
        public String ClaveSunat { get; set; }
        public String UrlSunat { get; set; }



        public Image Fotografia
        {
            get { return fotografia; }
            set { fotografia = value; }
        }
        public Int32 CodEmpresaNuevo
        {
            get { return iCodEmpresaNueva; }
            set { iCodEmpresaNueva = value; }
        }
        public Int32 CodEmpresa
        {
            get { return iCodEmpresa; }
            set { iCodEmpresa = value; }
        }
        public String RazonSocial
        {
            get { return sRazonSocial; }
            set { sRazonSocial = value; }
        }
        public String Ruc
        {
            get { return sRuc; }
            set { sRuc = value; }
        }
        public String Direccion
        {
            get { return sDireccion; }
            set { sDireccion = value; }
        }
        public String Telefono
        {
            get { return sTelefono; }
            set { sTelefono = value; }
        }
        public String Fax
        {
            get { return sFax; }
            set { sFax = value; }
        }
        public String Representante
        {
            get { return sRepresentante; }
            set { sRepresentante = value; }
        }
        public Boolean Estado
        {
            get { return iEstado; }
            set { iEstado = value; }
        }
        public Int32 CodUser
        {
            get { return iCodUser; }
            set { iCodUser = value; }
        }
        public DateTime FechaRegistro
        {
            get { return dtFechaRegistro; }
            set { dtFechaRegistro = value; }
        }

        public string Email { get => email; set => email = value; }
        public string Claveemail { get => claveemail; set => claveemail = value; }

    }
}
