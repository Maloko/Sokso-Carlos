using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class TipoUsuario
    {
        private int tipousuarioid;
        private string descripcion;
        private int estado;
        private List<Usuario> lista_usuario;

        public int Tipousuarioid
        {
            get
            {
                return tipousuarioid;
            }

            set
            {
                tipousuarioid = value;
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

        public List<Usuario> Lista_usuario
        {
            get
            {
                return lista_usuario;
            }

            set
            {
                lista_usuario = value;
            }
        }
    }
}
