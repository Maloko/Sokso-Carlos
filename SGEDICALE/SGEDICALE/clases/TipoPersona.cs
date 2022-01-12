using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class TipoPersona
    {

        private int codtipopersona;
        private string descripcion;
        private int estado;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Codtipopersona { get => codtipopersona; set => codtipopersona = value; }
    }
}
