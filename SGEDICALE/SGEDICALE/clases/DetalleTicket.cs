using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class DetalleTicket
    {

        private int codDetalleTicket;
        private int codTicket;
        private int codProducto;
        private int codUnidad;
        private int cantidad;
        private Decimal precio;
        private Decimal total;
        private int codusuario;
        private DateTime fecharegistro;
        private int estado;

        public int CodDetalleTicket { get => codDetalleTicket; set => codDetalleTicket = value; }
        public int CodTicket { get => codTicket; set => codTicket = value; }
        public int CodProducto { get => codProducto; set => codProducto = value; }
        public int CodUnidad { get => codUnidad; set => codUnidad = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public decimal Total { get => total; set => total = value; }
        public int Codusuario { get => codusuario; set => codusuario = value; }
        public DateTime Fecharegistro { get => fecharegistro; set => fecharegistro = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
