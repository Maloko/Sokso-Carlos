using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class DetalleCatalogo
    {

        private int codDetalleCatalogo;
        private int codCatalogo;
        private int pag;
        private string marca;
        private string modelo;
        private string color;
        private string tallas;
        private decimal ppromotor;
        private decimal pdirector;
        private string fechallegada;
        private string talladisponible;
        private string tallasagotadas;
        private int codusuario;
        private DateTime fechaRegistro;
        private Boolean estado;

        public int CodDetalleCatalogo
        {
            get
            {
                return codDetalleCatalogo;
            }

            set
            {
                codDetalleCatalogo = value;
            }
        }

        public int CodCatalogo
        {
            get
            {
                return codCatalogo;
            }

            set
            {
                codCatalogo = value;
            }
        }

        public int Pag
        {
            get
            {
                return pag;
            }

            set
            {
                pag = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public string Tallas
        {
            get
            {
                return tallas;
            }

            set
            {
                tallas = value;
            }
        }

        public decimal Ppromotor
        {
            get
            {
                return ppromotor;
            }

            set
            {
                ppromotor = value;
            }
        }

        public decimal Pdirector
        {
            get
            {
                return pdirector;
            }

            set
            {
                pdirector = value;
            }
        }

        public string Fechallegada
        {
            get
            {
                return fechallegada;
            }

            set
            {
                fechallegada = value;
            }
        }

        public string Talladisponible
        {
            get
            {
                return talladisponible;
            }

            set
            {
                talladisponible = value;
            }
        }

        public string Tallasagotadas
        {
            get
            {
                return tallasagotadas;
            }

            set
            {
                tallasagotadas = value;
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

        public DateTime FechaRegistro
        {
            get
            {
                return fechaRegistro;
            }

            set
            {
                fechaRegistro = value;
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
    }
}
