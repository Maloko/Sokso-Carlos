
using System.Collections.Generic;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;
using System;

namespace SGEDICALE.controlador
{
    public class CMetodoPago
    {

        public static Boolean insert(MetodoPago pago)
        {
           return MMetodoPago.Insert(pago);
        }


        public static Boolean update(MetodoPago pago)
        {
           return MMetodoPago.Update(pago);
        }

        public static Boolean delete(Int32 Codpago)
        {
           return MMetodoPago.Delete(Codpago);
        }


        public  static DataTable CargaMetodoPagos()
        {
           return MMetodoPago.CargaMetodoPagos();
        }


        public static DataTable ListaMetodoPagos()
        {
            return MMetodoPago.ListaMetodoPagos();
        }

        public static MetodoPago BuscaMetodoPago(int Codigo)
        {
            return MMetodoPago.BuscaMetodoPago(Codigo);
        }



    }
}
