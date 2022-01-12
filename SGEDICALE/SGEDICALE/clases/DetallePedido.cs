using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class DetallePedido
    {

        private int codDetallePedido;
        private int codPedido;
        private int codProducto;
        private string producto;
        private string catalogo;
        private int devolucion;
        private string talla;
        private int cantidad;
        private Decimal precio;
        private Decimal preciost;

        private int codusuario;
        private DateTime fecharegistro;
        private int estado;

        public int CodDetallePedido
        {
            get
            {
                return codDetallePedido;
            }

            set
            {
                codDetallePedido = value;
            }
        }

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

        public string Producto
        {
            get
            {
                return producto;
            }

            set
            {
                producto = value;
            }
        }

        public string Catalogo
        {
            get
            {
                return catalogo;
            }

            set
            {
                catalogo = value;
            }
        }

        public int Devolucion
        {
            get
            {
                return devolucion;
            }

            set
            {
                devolucion = value;
            }
        }

        public string Talla
        {
            get
            {
                return talla;
            }

            set
            {
                talla = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public decimal Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public decimal Preciost
        {
            get
            {
                return preciost;
            }

            set
            {
                preciost = value;
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

        public int CodProducto { get => codProducto; set => codProducto = value; }
    }
}
