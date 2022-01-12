using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Puntos
    {


        private int codpunto;
        private Promotor promotor;
        private decimal puntaje;
        private DateTime fechaRegistro;
        private int codUsuario;
        private int estado;

        public int Codpunto { get => codpunto; set => codpunto = value; }
        public Promotor Promotor { get => promotor; set => promotor = value; }
        public decimal Puntaje { get => puntaje; set => puntaje = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public int CodUsuario { get => codUsuario; set => codUsuario = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
