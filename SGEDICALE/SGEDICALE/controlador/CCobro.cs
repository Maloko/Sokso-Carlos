using System;
using System.Collections.Generic;
using SGEDICALE.modelo;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.controlador
{
    public class CCobro
    {

        public  static int registar_cobro(Cobro cobro)
        {
            return MCobro.registar_cobro(cobro);
        }

        public static int anular_cobro(Cobro cobro, Usuario usureg)
        {
            return MCobro.anular_cobro(cobro, usureg);
        }

        public static DataTable muestra_cobrosxcodComprobante(int codcomprobante)
        {

            return MCobro.muestra_cobrosxcodComprobante(codcomprobante);
        }

        public static DataTable listar_pagos_notas(int codNota)
        {

            return MCobro.listar_pagos_notas(codNota);
        }




    }
}
