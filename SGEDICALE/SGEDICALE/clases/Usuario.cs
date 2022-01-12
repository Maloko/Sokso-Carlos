using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Usuario
    {

        private int usuarioid;
        private string nombreapellidos;
        private string dni;
        private string direccion;
        private string telefono;
        private string correo;
        private string cuenta;
        private string clave;
        private int estado;
        private TipoUsuario tipousuario;
        public Int32 codalmacen { get; set; }
        public Int32 codempresa { get; set; }

        private List<Acceso> lista_acceso;

        internal List<Acceso> Lista_acceso
        {
            get
            {
                return lista_acceso;
            }

            set
            {
                lista_acceso = value;
            }
        }


        public int Usuarioid
        {
            get
            {
                return usuarioid;
            }

            set
            {
                usuarioid = value;
            }
        }

        public string Nombreapellidos
        {
            get
            {
                return nombreapellidos;
            }

            set
            {
                nombreapellidos = value;
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

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Cuenta
        {
            get
            {
                return cuenta;
            }

            set
            {
                cuenta = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
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

        public TipoUsuario Tipousuario
        {
            get
            {
                return tipousuario;
            }

            set
            {
                tipousuario = value;
            }
        }
    }
}
