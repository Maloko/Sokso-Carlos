
using System.Collections.Generic;
using SGEDICALE.modelo;
using SGEDICALE.clases;


namespace SGEDICALE.controlador
{
    public class CSerie
    {
        public static List<Serie> cargarSeriexTipocomprobante(int codtipocomprobante)
        {
            return MSerie.cargarSeriexTipocomprobante(codtipocomprobante);
        }

        public static Serie cargarCorrelativo(int codtipocomprobante, int codserie)
        {
            return MSerie.cargarCorrelativo(codtipocomprobante,codserie);
        }


        public static List<Serie> listarseries()
        {
            return MSerie.listarseries();
        }

    }
}
