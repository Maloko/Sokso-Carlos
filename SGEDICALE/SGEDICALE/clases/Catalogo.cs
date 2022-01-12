using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Catalogo
    {

        private int codCatalogo;
        private string nombre;
        private string categoria;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int codusuario;
        private DateTime fechaRegistro;
        private Boolean estado;

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

        public string Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public DateTime FechaInicio
        {
            get
            {
                return fechaInicio;
            }

            set
            {
                fechaInicio = value;
            }
        }

        public DateTime FechaFin
        {
            get
            {
                return fechaFin;
            }

            set
            {
                fechaFin = value;
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
