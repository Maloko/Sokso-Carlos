using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Pedido
    {
        public  Pedido()
        { 
       
           ListaDetallePedido = new List<DetallePedido>();
        }

        private int codPedido;
        private int codPromotor;
        private string numeropedido;
        private int numerodocumento;
        private string promotor;
        private decimal subtotal;
        private decimal igv;
        private decimal total;
        private DateTime fechapedido;
        private DateTime fechaenvio;
        private DateTime fecharegistro;

        private int codusuario;
        private int estado;

        private List<DetallePedido> listaDetallePedido;

        public int CodPedido
        {
            get
            {
                return codPedido;
            }

            set
            {
                codPedido = value;
            }
        }

        public int CodPromotor
        {
            get
            {
                return codPromotor;
            }

            set
            {
                codPromotor = value;
            }
        }

 

        public int Numerodocumento
        {
            get
            {
                return numerodocumento;
            }

            set
            {
                numerodocumento = value;
            }
        }

        public string Promotor
        {
            get
            {
                return promotor;
            }

            set
            {
                promotor = value;
            }
        }

        public decimal Subtotal
        {
            get
            {
                return subtotal;
            }

            set
            {
                subtotal = value;
            }
        }

        public decimal Igv
        {
            get
            {
                return igv;
            }

            set
            {
                igv = value;
            }
        }

        public decimal Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public DateTime Fechapedido
        {
            get
            {
                return fechapedido;
            }

            set
            {
                fechapedido = value;
            }
        }

        public DateTime Fechaenvio
        {
            get
            {
                return fechaenvio;
            }

            set
            {
                fechaenvio = value;
            }
        }

        public DateTime Fecharegistro
        {
            get
            {
                return fecharegistro;
            }

            set
            {
                fecharegistro = value;
            }
        }

        public int Codusuario
        {
            get
            {
                return codusuario;
            }

            set
            {
                codusuario = value;
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

        public List<DetallePedido> ListaDetallePedido
        {
            get
            {
                return listaDetallePedido;
            }

            set
            {
                listaDetallePedido = value;
            }
        }

        public string Numeropedido { get => numeropedido; set => numeropedido = value; }
    }
}
