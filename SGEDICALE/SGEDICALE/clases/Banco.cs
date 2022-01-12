using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Banco
    {
        private int codbanco;
        private string sigla;
        private string descripcion;
        private DateTime fecharegistro;
        private int codusuario;
        private bool estado;

        public int Codbanco
        {
            get
            {
                return codbanco;
            }

            set
            {
                codbanco = value;
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
    }
}
