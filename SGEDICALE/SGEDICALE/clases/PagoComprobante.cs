using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.clases
{
    public class PagoComprobante
    {

        private int codpagocomprobante;
        private int codpago;
        private int codcomprobante;
        private DateTime fechapago;
        private decimal pago;
        private decimal montopagado;
        private decimal montopendiente;
        private decimal montofavor;
        private decimal pendiente;
        private int codusuario;
        private bool estado;
        private DateTime fecharegistro;

        public int Codpagocomprobante
        {
            get
            {
                return codpagocomprobante;
            }

            set
            {
                codpagocomprobante = value;
            }
        }

        public int Codpago
        {
            get
            {
                return codpago;
            }

            set
            {
                codpago = value;
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

        public decimal Pago
        {
            get
            {
                return pago;
            }

            set
            {
                pago = value;
            }
        }

        public decimal Montopagado
        {
            get
            {
                return montopagado;
            }

            set
            {
                montopagado = value;
            }
        }

        public decimal Montopendiente
        {
            get
            {
                return montopendiente;
            }

            set
            {
                montopendiente = value;
            }
        }

        public decimal Montofavor
        {
            get
            {
                return montofavor;
            }

            set
            {
                montofavor = value;
            }
        }

        public decimal Pendiente
        {
            get
            {
                return pendiente;
            }

            set
            {
                pendiente = value;
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

        public DateTime Fechapago
        {
            get
            {
                return fechapago;
            }

            set
            {
                fechapago = value;
            }
        }
    }
}
