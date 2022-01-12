using System;
using System.Collections.Generic;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;


namespace SGEDICALE.controlador
{
    public class CCaja
    {

        public static int buscar_caja_abierta(int usuario)
        {

            return MCaja.buscar_caja_abierta(usuario);
        }

        public static DataTable listar_caja_cerrada(DateTime fechaini, DateTime fechafin)
        {

            return MCaja.listar_caja_cerrada(fechaini, fechafin);
        }


        public static DataTable listar_caja_apertura()
        {

            return MCaja.listar_caja_apertura();
        }

        public static  int anular_caja(Caja caja, Usuario usureg)
        {

            return MCaja.anular_caja(caja, usureg);
        }


        public static int registrar_caja(Caja caja)
        {

            return MCaja.registrar_caja(caja);
        }

        public static DataTable listar_caja_movimiento(Caja caja)
        {

            return MCaja.listar_caja_movimiento(caja);
        }


        public static Caja total_caja(Caja caja)
        {

            return MCaja.total_caja(caja);
        }

        public static int cerrar_caja(Caja caja, Usuario usureg)
        {

            return MCaja.cerrar_caja(caja, usureg);
        }

        public static DataSet reporte_caja_movimiento(Caja caja)
        {

            return MCaja.reporte_caja_movimiento(caja);
        }

        public static DataTable listar_movimiento_caja_xcomprobante(Caja caja, Comprobantee comprobante)
        {

            return MCaja.listar_movimiento_caja_xcomprobante(caja, comprobante);
        }


    }
}
