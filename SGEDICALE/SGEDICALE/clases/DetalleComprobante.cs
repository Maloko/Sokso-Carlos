using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class DetalleComprobante
    {

        private int codDetalleComprobante;
        private int codComprobante;
        private string descripcion;
        private int codProducto;
        private int unidadingresada;
        private int cantidad;
        private decimal preciounitario;
        private decimal subtotal;
        private decimal igv;
        private decimal total;
        private decimal descuento1;
        private int tipoimpuesto;
        private int anulado;
        private int codusuario;
        private DateTime fecharegistro;
        private int estado;

        public int CodDetalleComprobante
        {
            get
            {
                return codDetalleComprobante;
            }

            set
            {
                codDetalleComprobante = value;
            }
        }

        public int CodComprobante
        {
            get
            {
                return codComprobante;
            }

            set
            {
                codComprobante = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int CodProducto
        {
            get
            {
                return codProducto;
            }

            set
            {
                codProducto = value;
            }
        }

        public int Unidadingresada
        {
            get
            {
                return unidadingresada;
            }

            set
            {
                unidadingresada = value;
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

        public decimal Preciounitario
        {
            get
            {
                return preciounitario;
            }

            set
            {
                preciounitario = value;
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

        public decimal Descuento1
        {
            get
            {
                return descuento1;
            }

            set
            {
                descuento1 = value;
            }
        }

        public int Tipoimpuesto
        {
            get
            {
                return tipoimpuesto;
            }

            set
            {
                tipoimpuesto = value;
            }
        }

        public int Anulado
        {
            get
            {
                return anulado;
            }

            set
            {
                anulado = value;
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
    }
}
