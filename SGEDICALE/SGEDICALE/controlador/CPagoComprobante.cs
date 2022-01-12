using System.Collections.Generic;
using System.Data;
using SGEDICALE.clases;
using SGEDICALE.modelo;


namespace SGEDICALE.controlador
{
    public class CPagoComprobante
    {

        public static bool insertar(PagoComprobante pago)
        {
            return MPagoComprobante.insertar(pago);
        }

        public static DataTable muestra_UsoDepositosxNumeroOperacion(string numeroOperacion)
        {
            return MPagoComprobante.muestra_UsoDepositosxNumeroOperacion(numeroOperacion);
        }
    }
}
