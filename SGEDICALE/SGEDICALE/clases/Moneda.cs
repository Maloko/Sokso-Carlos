using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Moneda
    {
        private int codmoneda;
        private int codpais;
        private string descripcion;
        private DateTime fecharegistro;
        private int codusuario;
        private bool estado;
        private string codsunat;

        public int Codmoneda
        {
            get
            {
                return codmoneda;
            }

            set
            {
                codmoneda = value;
            }
        }

        public int Codpais
        {
            get
            {
                return codpais;
            }

            set
            {
                codpais = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
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

        public string Codsunat
        {
            get
            {
                return codsunat;
            }

            set
            {
                codsunat = value;
            }
        }
    }
}
