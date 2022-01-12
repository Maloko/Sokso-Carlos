using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Campaña
    {



        private int codCampaña;
        private Categoria categoria;
        private string descripcion;
        private string año;
        private DateTime fechainicio;
        private DateTime fechafin;
        private DateTime fechaRegistro;
        private int codUsuario;
        private int estado;

    
        public int CodCampaña { get => codCampaña; set => codCampaña = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public int CodUsuario { get => codUsuario; set => codUsuario = value; }
        public int Estado { get => estado; set => estado = value; }
        public DateTime Fechainicio { get => fechainicio; set => fechainicio = value; }
        public DateTime Fechafin { get => fechafin; set => fechafin = value; }
        public Categoria Categoria { get => categoria; set => categoria = value; }
        public string Año { get => año; set => año = value; }
    }
}
