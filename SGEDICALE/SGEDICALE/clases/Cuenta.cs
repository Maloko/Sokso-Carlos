using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Cuenta
    {


        private int codCuentaCorriente;
        private int codBanco;
        private string cuentaCorriente;
        private string tipoCuenta;
        private int moneda;

        private DateTime fechaRegistro;

        private Int32 codUsuario;
        private int estado;
        private Int32 codAlmacen;

        public int CodCuentaCorriente
        {
            get
            {
                return codCuentaCorriente;
            }

            set
            {
                codCuentaCorriente = value;
            }
        }

        public int CodBanco
        {
            get
            {
                return codBanco;
            }

            set
            {
                codBanco = value;
            }
        }

        public string CuentaCorriente
        {
            get
            {
                return cuentaCorriente;
            }

            set
            {
                cuentaCorriente = value;
            }
        }

        public string TipoCuenta
        {
            get
            {
                return tipoCuenta;
            }

            set
            {
                tipoCuenta = value;
            }
        }

        public int Moneda
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

        public DateTime FechaRegistro
        {
            get
            {
                return fechaRegistro;
            }

            set
            {
                fechaRegistro = value;
            }
        }

        public int CodUsuario
        {
            get
            {
                return codUsuario;
            }

            set
            {
                codUsuario = value;
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

        public int CodAlmacen
        {
            get
            {
                return codAlmacen;
            }

            set
            {
                codAlmacen = value;
            }
        }
    }
}
