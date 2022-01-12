using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class FormaPago
    {


        private int codFormaPago;
        private string descripcion;
        private Int32 iDias;
        private Boolean bTipo;
        private int estado;
        private int codUsuario;
        private DateTime fecharegistro;
        private Boolean btipoaccion;

        public int CodFormaPago { get => codFormaPago; set => codFormaPago = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IDias { get => iDias; set => iDias = value; }
        public bool BTipo { get => bTipo; set => bTipo = value; }
        public int Estado { get => estado; set => estado = value; }
        public int CodUsuario { get => codUsuario; set => codUsuario = value; }
        public DateTime Fecharegistro { get => fecharegistro; set => fecharegistro = value; }
        public bool Btipoaccion { get => btipoaccion; set => btipoaccion = value; }
    }
}
