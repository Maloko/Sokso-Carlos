using System;
using System.Collections.Generic;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;

namespace SGEDICALE.controlador
{
    public class CComprobante
    {
        public static bool insertar(Comprobantee comprobante)
        {
            return MComprobante.insertar(comprobante);
        }


        public static int insert_nota(Comprobantee comprobante, Usuario usureg)
        {

            return MComprobante.insertar_nota(comprobante, usureg);
        }

        public static bool insertarNuevaventa(Comprobantee comprobante)
        {
            return MComprobante.insertarNuevaventa(comprobante);
        }



        public static DataTable listar_notas_xestado_xfecha(DateTime fechaincio, DateTime fechafin, int estado)
        {

            return MComprobante.listar_notas_xestado_xfecha(fechaincio, fechafin, estado);
        }

     


        public static Comprobantee buscarComprobanteCredito(Comprobantee comprobante)
        {

            return MComprobante.buscarComprobanteCredito(comprobante);
        }

        public static Comprobantee buscarNotaCredito(string correlativo)
        {

            return MComprobante.buscarNotaCredito(correlativo);

        }

        /*
        public static Comprobantee buscarNotaCredito(Comprobantee comprobante)
        {

            return MComprobante.buscarNotaCredito(comprobante);

        }*/



        public static DateTime listar_fecha_actual()
        {
            return MComprobante.listar_fecha_actual();
        }

        public static int anular_comprobante(Comprobantee comprobante, Usuario usureg)
        {
            return MComprobante.anular_comprobante(comprobante, usureg);
        }

        public static Comprobantee buscacomprobante(int codcomprobante)
        {
            return MComprobante.buscacomprobante(codcomprobante);
        }

        public static Comprobantee buscacomprobantexcodPedido(int codcomprobante)
        {
            return MComprobante.buscacomprobantexcodPedido(codcomprobante);
        }

        public static DataTable listar_ventas_xestado_xfecha(DateTime fechai, DateTime fechaf)
        {
            return MComprobante.listar_ventas_xestado_xfecha(fechai, fechaf);

        }

        public static DataTable listar_ventas_xestado_xfecha_xpromotor(DateTime fechaincio, DateTime fechafin, string promotor)
        {

            return MComprobante.listar_ventas_xestado_xfecha_xpromotor(fechaincio, fechafin, promotor);
        }



        public static DataTable listar_detalle_comprobante_xidcomprobante(Comprobantee comprobante)
        {
            return MComprobante.listar_detalle_comprobante_xidcomprobante(comprobante);
        }


        public static List<DetalleComprobante> traer_detalle_comprobante_xidcomprobante(Comprobantee comprobante)
        {
            return MComprobante.traer_detalle_comprobante_xidcomprobante(comprobante);
        }


        public static DataTable MuestraCobros(int estado, DateTime fecha1, DateTime fecha2,int codpromotor)
        {
            return MComprobante.MuestraCobros(estado,fecha1,fecha2,codpromotor);
        }

        public static DataTable MuestraDepositos(int estado, DateTime fecha1, DateTime fecha2, int codpromotor)
        {
            return MComprobante.MuestraDepositos(estado, fecha1, fecha2, codpromotor);
        }


        public static Boolean anular(Int32 codventa)
        {
           return MComprobante.anular(codventa);
        }

        public static Boolean ActualizaBoletaSunat(Int32 codventa)
        {
           return MComprobante.ActualizaBoletaSunat(codventa);
        }

        public static Boolean ActualizaPago(PagoComprobante pc)
        {
            return MComprobante.ActualizaPago(pc);
        }

        public static DataTable listar_notas_xestado_xcliente(Promotor cliente)
        {

            return MComprobante.listar_notas_xestado_xcliente(cliente);
        }

        public static DataTable listar_comprobantes_xestado_xcliente(Promotor cliente)
        {

            return MComprobante.listar_comprobantes_xestado_xcliente(cliente);
        }


    }
}
