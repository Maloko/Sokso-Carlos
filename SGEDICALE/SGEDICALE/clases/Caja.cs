using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class Caja
    {

        private int codcaja;
        private DateTime fechaapertura;
        private decimal montoapertura;
        private DateTime fechacierre;
        private decimal montocierre;
        private Usuario usuario;
        private decimal totalefectivo;
        private decimal totaldeposito;
        private decimal totaltransferencia;
        private decimal totaldisponible;
        private decimal totaltarjeta;
        private decimal totalnota;
        private int estado;
        private int operacion;

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

        public DateTime Fechaapertura
        {
            get
            {
                return fechaapertura;
            }

            set
            {
                fechaapertura = value;
            }
        }

        public decimal Montoapertura
        {
            get
            {
                return montoapertura;
            }

            set
            {
                montoapertura = value;
            }
        }

        public DateTime Fechacierre
        {
            get
            {
                return fechacierre;
            }

            set
            {
                fechacierre = value;
            }
        }

        public decimal Montocierre
        {
            get
            {
                return montocierre;
            }

            set
            {
                montocierre = value;
            }
        }

        public Usuario Usuario
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

        public decimal Totalefectivo
        {
            get
            {
                return totalefectivo;
            }

            set
            {
                totalefectivo = value;
            }
        }

        public decimal Totaldeposito
        {
            get
            {
                return totaldeposito;
            }

            set
            {
                totaldeposito = value;
            }
        }

        public decimal Totaltransferencia
        {
            get
            {
                return totaltransferencia;
            }

            set
            {
                totaltransferencia = value;
            }
        }

        public decimal Totaldisponible
        {
            get
            {
                return totaldisponible;
            }

            set
            {
                totaldisponible = value;
            }
        }

        public decimal Totaltarjeta
        {
            get
            {
                return totaltarjeta;
            }

            set
            {
                totaltarjeta = value;
            }
        }

        public decimal Totalnota
        {
            get
            {
                return totalnota;
            }

            set
            {
                totalnota = value;
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

        public int Operacion
        {
            get
            {
                return operacion;
            }

            set
            {
                operacion = value;
            }
        }
    }
}
