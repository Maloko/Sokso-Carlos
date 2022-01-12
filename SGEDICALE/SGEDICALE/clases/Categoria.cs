using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Categoria
    {

        private int codCategoria;
        private string descripcion;
        private DateTime fechaRegistro;
        private int codUsuario;
        private int estado;

        public int CodCategoria { get => codCategoria; set => codCategoria = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public int CodUsuario { get => codUsuario; set => codUsuario = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
