using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Cliente
    {

        private int idcliente;
        private TipoDocumentoIdentidad tipodocumentoidentidad;
        private string nombreyapellido;
        private string documento;
        private string direccion;
        private int estado;

        public int Idcliente
        {
            get
            {
                return idcliente;
            }

            set
            {
                idcliente = value;
            }
        }

        public TipoDocumentoIdentidad Tipodocumentoidentidad
        {
            get
            {
                return tipodocumentoidentidad;
            }

            set
            {
                tipodocumentoidentidad = value;
            }
        }

        public string Nombreyapellido
        {
            get
            {
                return nombreyapellido;
            }

            set
            {
                nombreyapellido = value;
            }
        }

        public string Documento
        {
            get
            {
                return documento;
            }

            set
            {
                documento = value;
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
