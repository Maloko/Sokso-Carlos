using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class DiscrepanciaNotaCredito
    {

        private int iddiscrepancia;
        private string codsunat;
        private string descripcion;
        private int estado;

        public int Iddiscrepancia
        {
            get
            {
                return iddiscrepancia;
            }

            set
            {
                iddiscrepancia = value;
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

        public int Estado
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
