using System;
using System.Data;
using SGEDICALE.clases;
using SGEDICALE.modelo;

namespace SGEDICALE.controlador
{
    public class CTipoCambio
    {

        public static TipoCambio listartipocambioxmoneda(int codmoneda, DateTime fecha)
        {
            return MTipoCambio.listartipocambioxmoneda(codmoneda, fecha);
        }

        public static Boolean insert(TipoCambio tc)
        {
            return MTipoCambio.Insert(tc);
        }

        public static Boolean update(TipoCambio tc)
        {
           return MTipoCambio.Update(tc);
        }

        public static Boolean delete(Int32 Codtc)
        {
           return MTipoCambio.Delete(Codtc);
        }

        public static TipoCambio buscar(DateTime Fecha, Int32 codMoneda)
        {
            return MTipoCambio.buscar(Fecha, codMoneda);
        }

        public static TipoCambio buscarxcodigo(int codtipocambio)
        {
            return MTipoCambio.buscarxcodigo(codtipocambio);
        }

        public  static TipoCambio ultimo_tipocambio()
        {
            return MTipoCambio.ultimo_tipocambio();
        }

        public static DataTable listadotipocambio(Int32 Mes, Int32 Año)
        {
            return MTipoCambio.listadotipocambio(Mes, Año);
        }

    }
}
