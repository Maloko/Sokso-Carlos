using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Ticket
    {
        public Ticket()
        {
            ListaDetalleTicket = new List<DetalleTicket>();
        }

        private int codTicket;
        private int codCliente;
        private int codtipocomprobante;
        private int codserie;
        private string correlativo;
        private decimal subtotal;
        private decimal igv;
        private decimal total;
        private DateTime fecha;
        private DateTime fecharegistro;
        private int codempresa;
        private int codusuario;
        private int estado;
        private List<DetalleTicket> listaDetalleTicket;

        private int codmoneda;
        private string documento;
        private string nombres;
        private string direccion;

        public int CodTicket { get => codTicket; set => codTicket = value; }
        public int CodCliente { get => codCliente; set => codCliente = value; }
        public int Codtipocomprobante { get => codtipocomprobante; set => codtipocomprobante = value; }
        public decimal Subtotal { get => subtotal; set => subtotal = value; }
        public decimal Igv { get => igv; set => igv = value; }
        public decimal Total { get => total; set => total = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Fecharegistro { get => fecharegistro; set => fecharegistro = value; }
        public int Codusuario { get => codusuario; set => codusuario = value; }
        public int Estado { get => estado; set => estado = value; }
        public List<DetalleTicket> ListaDetalleTicket { get => listaDetalleTicket; set => listaDetalleTicket = value; }
        public int Codempresa { get => codempresa; set => codempresa = value; }
        public int Codserie { get => codserie; set => codserie = value; }
        public string Correlativo { get => correlativo; set => correlativo = value; }
        public int Codmoneda { get => codmoneda; set => codmoneda = value; }
        public string Documento { get => documento; set => documento = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Direccion { get => direccion; set => direccion = value; }
    }
}
