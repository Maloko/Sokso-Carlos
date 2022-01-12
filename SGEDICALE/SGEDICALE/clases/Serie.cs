using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Serie
    {

        private int codSerie;
        private int codtipocomprobante;
        private string sserie;
        private int inicio;
        private int fin;
        private int correlativo;
        private string nombreimpresora;
        private string papersize;
        private string serieimpresora;
        private Boolean estado;
        private int codusuario;
        private DateTime fecharegistro;

        public int CodSerie
        {
            get
            {
                return codSerie;
            }

            set
            {
                codSerie = value;
            }
        }

        public int Codtipocomprobante
        {
            get
            {
                return codtipocomprobante;
            }

            set
            {
                codtipocomprobante = value;
            }
        }

        public string Sserie
        {
            get
            {
                return sserie;
            }

            set
            {
                sserie = value;
            }
        }

        public int Inicio
        {
            get
            {
                return inicio;
            }

            set
            {
                inicio = value;
            }
        }

        public int Fin
        {
            get
            {
                return fin;
            }

            set
            {
                fin = value;
            }
        }

        public int Correlativo
        {
            get
            {
                return correlativo;
            }

            set
            {
                correlativo = value;
            }
        }

        public string Nombreimpresora
        {
            get
            {
                return nombreimpresora;
            }

            set
            {
                nombreimpresora = value;
            }
        }

        public string Papersize
        {
            get
            {
                return papersize;
            }

            set
            {
                papersize = value;
            }
        }

        public string Serieimpresora
        {
            get
            {
                return serieimpresora;
            }

            set
            {
                serieimpresora = value;
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

        public int Codusuario
        {
            get
            {
                return codusuario;
            }

            set
            {
                codusuario = value;
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
    }
}
