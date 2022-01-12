using System;
using System.Collections.Generic;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;

namespace SGEDICALE.controlador
{
    public class CBanco
    {
        public static bool insertar(Banco banco)
        {
            return MBanco.insertar(banco);
        }

        public static bool update(Banco banco)
        {
            return MBanco.update(banco);
        }

        public static bool eliminar(int codbanco)
        {
            return MBanco.eliminar(codbanco);
        }

        public static DataTable listar()
        {
            return MBanco.listar();
        }

        public static DataTable cargacombobancos()
        {
            return MBanco.cargacombobancos();
        }

        public static Banco buscar(int cod)
        {
            return MBanco.buscar(cod);
        }

    }
}
