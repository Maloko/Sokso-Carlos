using System;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;


namespace SGEDICALE.controlador
{
    public class CPago
    {
        public static DataTable cargarGrilla(string ruta_excel)
        {
            return MPago.cargarGrilla(ruta_excel);
        }

  
        public static bool insertar(Pago pago)
        {
            return MPago.insertar(pago);
        }

        public static void cambiarestado(int codpago, int estado,string observacion)
        {
            MPago.cambiarestado(codpago, estado,observacion);
        }

        public static Pago buscarSaldoPago(int codpago)
        {
            return MPago.buscarSaldoPago(codpago);
        }



        public static DataTable listarPagosFiltro(int codbanco, int codcuenta,DateTime fechai,DateTime fechaf)
        {
            return MPago.listarPagosFiltro(codbanco, codcuenta, fechai, fechaf);
        }


        public static DataTable listarpagoxfechaoperacion(string numerooperacion,int codbanco,int codcuenta,DateTime fechai, DateTime fechaf)
        {
            return MPago.listarpagoxfechaoperacion(numerooperacion,codbanco,codcuenta,fechai, fechaf);
        }


        public static DataTable CargaFormaPagos()
        {

            return MPago.CargaFormaPagos();

        }


    }
}
