using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class TipoTarjeta
    {

        private int codtipotarjeta;
        private string descripcion;
        private int estado;
        private int codusuario;
        private DateTime fecharegistro;

        public int Codtipotarjeta
        {
            get
            {
                return codtipotarjeta;
            }

            set
            {
                codtipotarjeta = value;
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
