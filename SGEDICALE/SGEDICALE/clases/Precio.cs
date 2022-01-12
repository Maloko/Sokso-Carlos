using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Precio
    {

        private int codPrecio;
        private Campaña campana;
        private int codusuario;
        private DateTime fechaRegistro;
        private int estado;

        public int CodPrecio { get => codPrecio; set => codPrecio = value; }
        public Campaña Campana { get => campana; set => campana = value; }
        public int Codusuario { get => codusuario; set => codusuario = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
