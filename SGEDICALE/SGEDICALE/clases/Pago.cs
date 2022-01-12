using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Pago
    {
        private int codPago;
        private int codbanco;
        private int codcuenta;
        private DateTime fecha;
        private DateTime fechavaluta;
        private string descripcion;
        private decimal monto;
        private decimal cobrado;
        private decimal saldofavor;
        private decimal saldo;

        private string sucursal;
        private string operacionnumero;
        private string operacionhora;
        private string usuario;
        private string utc;
        private int situacionpago;
        private DateTime fecharegistro;
        private int codusuario;
        private bool estado;

        public int CodPago
        {
            get
            {
                return codPago;
            }

            set
            {
                codPago = value;
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

        public DateTime Fechavaluta
        {
            get
            {
                return fechavaluta;
            }

            set
            {
                fechavaluta = value;
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

        public decimal Cobrado
        {
            get
            {
                return cobrado;
            }

            set
            {
                cobrado = value;
            }
        }

        public decimal Saldofavor
        {
            get
            {
                return saldofavor;
            }

            set
            {
                saldofavor = value;
            }
        }

        public decimal Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }

        public string Sucursal
        {
            get
            {
                return sucursal;
            }

            set
            {
                sucursal = value;
            }
        }

        public string Operacionnumero
        {
            get
            {
                return operacionnumero;
            }

            set
            {
                operacionnumero = value;
            }
        }

        public string Operacionhora
        {
            get
            {
                return operacionhora;
            }

            set
            {
                operacionhora = value;
            }
        }

        public string Usuario
        {
            get
            {
                return usuario;
            }

            set
            {
                usuario = value;
            }
        }

        public string Utc
        {
            get
            {
                return utc;
            }

            set
            {
                utc = value;
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

        public bool Estado
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

        public int Situacionpago
        {
            get
            {
                return situacionpago;
            }

            set
            {
                situacionpago = value;
            }
        }
    }
}
