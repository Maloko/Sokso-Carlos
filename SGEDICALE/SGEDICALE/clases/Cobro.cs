using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Cobro
    {
        private int codcobro;
        private DateTime fechacobro;
        private int codcomprobante;
        private int codmetodopago;
        private int codtipotarjeta;
        private int codbanco;
        private int codcuenta;

        private string noperacion;
        private int codnotacredito;
        private int codcaja;
        private decimal monto;
        private string observacion;
        private int estado;
        private int codusuario;

        private Comprobantee notacredito;


        public Comprobantee Notacredito
        {
            get
            {
                return notacredito;
            }

            set
            {
                notacredito = value;
            }
        }

        public int Codcobro
        {
            get
            {
                return codcobro;
            }

            set
            {
                codcobro = value;
            }
        }

        public DateTime Fechacobro
        {
            get
            {
                return fechacobro;
            }

            set
            {
                fechacobro = value;
            }
        }

        public int Codcomprobante
        {
            get
            {
                return codcomprobante;
            }

            set
            {
                codcomprobante = value;
            }
        }

        public int Codmetodopago
        {
            get
            {
                return codmetodopago;
            }

            set
            {
                codmetodopago = value;
            }
        }

        public int Codtipotarjeta
        {
            get
            {
                return codtipotarjeta;
            }

            set
            {
                codtipotarjeta = value;
            }
        }

        public int Codbanco
        {
            get
            {
                return codbanco;
            }

            set
            {
                codbanco = value;
            }
        }

        public int Codcuenta
        {
            get
            {
                return codcuenta;
            }

            set
            {
                codcuenta = value;
            }
        }

        public string Noperacion
        {
            get
            {
                return noperacion;
            }

            set
            {
                noperacion = value;
            }
        }

        public int Codnotacredito
        {
            get
            {
                return codnotacredito;
            }

            set
            {
                codnotacredito = value;
            }
        }

        public int Codcaja
        {
            get
            {
                return codcaja;
            }

            set
            {
                codcaja = value;
            }
        }

        public decimal Monto
        {
            get
            {
                return monto;
            }

            set
            {
                monto = value;
            }
        }

        public string Observacion
        {
            get
            {
                return observacion;
            }

            set
            {
                observacion = value;
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

        public int Codusuario { get => codusuario; set => codusuario = value; }
    }
}
