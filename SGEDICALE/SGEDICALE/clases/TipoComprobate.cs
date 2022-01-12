using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class TipoComprobate
    {

        private int codtipocomprobante;
        private string nombre;
        private string sigla;
        private string codsunat;
        private bool estado;

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

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Sigla
        {
            get
            {
                return sigla;
            }

            set
            {
                sigla = value;
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
