using System;
using System.Data;
using SGEDICALE.clases;
using SGEDICALE.modelo;

namespace SGEDICALE.controlador
{
    public class CTipoComprobante
    {

        public static DataTable cargarTipoComprobante()
        {
            return MTipoComprobante.cargarTipoComprobante();
        }

        public static DataTable cargarTipoComprobanteCredito()
        {
            return MTipoComprobante.cargarTipoComprobanteCredito();
        }

        public static TipoComprobate CargaTipoDocumento(Int32 cod)
        {
              return MTipoComprobante.CargaTipoDocumento(cod);
        }



    }
}
