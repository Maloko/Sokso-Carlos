using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class ProductoUnidad
    {
        private int codProductoUnidad;
        private int codProducto;
        private int codUnidad;
        private decimal precioventa;
        private decimal preciocompra;
        private int codusuario;
        private DateTime fechaRegistro;
        private Boolean estado;

        public int CodProductoUnidad { get => codProductoUnidad; set => codProductoUnidad = value; }
        public int CodProducto { get => codProducto; set => codProducto = value; }
        public int CodUnidad { get => codUnidad; set => codUnidad = value; }
        public decimal Precioventa { get => precioventa; set => precioventa = value; }
        public decimal Preciocompra { get => preciocompra; set => preciocompra = value; }
        public int Codusuario { get => codusuario; set => codusuario = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
