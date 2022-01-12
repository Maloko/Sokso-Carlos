using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Promotor
    {

        private int codPromotor;
        private string codSap;
        private string nombrecompleto;
        private string departamento;
        private string provincia;
        private string distrito;
        private string direccion;
        private string dni;
        private string telefono1;
        private string telefono2;
        private string celular1;
        private string celular2;
        private string email;
        private DateTime fechanac;
        private DateTime fecharegistro;
        private string razonsocial;
        private string genero;
        private string estadocivil;
        private string regimen;
        private string cliprospecto;
        private int espaciosblanco;
        private Boolean estado;
        private TipoPersona tipoPersona;

        private TipoDocumentoIdentidad documentoIdentidad;

        public int CodPromotor
        {
            get
            {
                return codPromotor;
            }

            set
            {
                codPromotor = value;
            }
        }

        public string CodSap
        {
            get
            {
                return codSap;
            }

            set
            {
                codSap = value;
            }
        }

        public string Nombrecompleto
        {
            get
            {
                return nombrecompleto;
            }

            set
            {
                nombrecompleto = value;
            }
        }

        public string Departamento
        {
            get
            {
                return departamento;
            }

            set
            {
                departamento = value;
            }
        }

        public string Provincia
        {
            get
            {
                return provincia;
            }

            set
            {
                provincia = value;
            }
        }

        public string Distrito
        {
            get
            {
                return distrito;
            }

            set
            {
                distrito = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Dni
        {
            get
            {
                return dni;
            }

            set
            {
                dni = value;
            }
        }

        public string Telefono1
        {
            get
            {
                return telefono1;
            }

            set
            {
                telefono1 = value;
            }
        }

        public string Telefono2
        {
            get
            {
                return telefono2;
            }

            set
            {
                telefono2 = value;
            }
        }

        public string Celular1
        {
            get
            {
                return celular1;
            }

            set
            {
                celular1 = value;
            }
        }

        public string Celular2
        {
            get
            {
                return celular2;
            }

            set
            {
                celular2 = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime Fechanac
        {
            get
            {
                return fechanac;
            }

            set
            {
                fechanac = value;
            }
        }

        public DateTime Fecharegistro
        {
            get
            {
                return fecharegistro;
            }

            set
            {
                fecharegistro = value;
            }
        }

        public string Razonsocial
        {
            get
            {
                return razonsocial;
            }

            set
            {
                razonsocial = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public string Estadocivil
        {
            get
            {
                return estadocivil;
            }

            set
            {
                estadocivil = value;
            }
        }

        public string Regimen
        {
            get
            {
                return regimen;
            }

            set
            {
                regimen = value;
            }
        }

        public string Cliprospecto
        {
            get
            {
                return cliprospecto;
            }

            set
            {
                cliprospecto = value;
            }
        }

        public int Espaciosblanco
        {
            get
            {
                return espaciosblanco;
            }

            set
            {
                espaciosblanco = value;
            }
        }

        public bool Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public TipoDocumentoIdentidad DocumentoIdentidad { get => documentoIdentidad; set => documentoIdentidad = value; }
        public TipoPersona TipoPersona { get => tipoPersona; set => tipoPersona = value; }
    }
}
