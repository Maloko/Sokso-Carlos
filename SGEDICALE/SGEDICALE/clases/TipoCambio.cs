using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class TipoCambio
    {

        private int codtipocambio;
        private int codmoneda;
        private decimal compra;
        private decimal venta;
        private DateTime fecha;
        private int estado;
        private int codusuario;
        private DateTime fecharegistro;
        private Moneda moneda;

        public int Codtipocambio
        {
            get
            {
                return codtipocambio;
            }

            set
            {
                codtipocambio = value;
            }
        }

        public int Codmoneda
        {
            get
            {
                return codmoneda;
            }

            set
            {
                codmoneda = value;
            }
        }

        public decimal Compra
        {
            get
            {
                return compra;
            }

            set
            {
                compra = value;
            }
        }

        public decimal Venta
        {
            get
            {
                return venta;
            }

            set
            {
                venta = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
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

        public Moneda Moneda
        {
            get
            {
                return moneda;
            }

            set
            {
                moneda = value;
            }
        }
    }
}
