using System;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;
using System.Collections.Generic;

namespace SGEDICALE.controlador
{
    public class CPromotor
    {
        public static DataTable cargarGrilla(string ruta_excel, string nombre_excel)
        {
            return MPromotor.cargarGrilla(ruta_excel, nombre_excel);
        }
        public static DataTable listado()
        {
            return MPromotor.listado();
        }

        public static List<TipoPersona> listar_tipo_promotor()
        {

            return MPromotor.listar_tipo_promotor();
        }



        public static DataTable listadoFiltro(int filtro)
        {
            return MPromotor.listadoFiltro(filtro);
        }

        public static DataTable listadorepetidos()
        {
            return MPromotor.listadorepetidos();
        }

        public static DataTable listadorepetidosxEmail()
        {
            return MPromotor.listadorepetidosxEmail();
        }

        public static Promotor buscarxcodigocomprobante(int codigo)
        {
            return MPromotor.buscarxcodigocomprobante(codigo);
        }


        public static DataTable busquedarepetidos(string nombre)
        {
            return MPromotor.busquedarepetidos(nombre);
        }

        public static DataTable busquedarepetidosxEmail(string nombre)
        {
            return MPromotor.busquedarepetidosxEmail(nombre);
        }



        public static bool update(Promotor pro)
        {
            return MPromotor.update(pro);
        }


        public static DataTable busqueda(string nombre)
        {
            return MPromotor.busqueda(nombre);
        }

        public static DataTable busquedafiltro(string nombre, int filtro)
        {
            return MPromotor.busquedafiltro(nombre, filtro);
        }

        public static bool insertar2(Promotor promotor)
        {
            bool rpta = MPromotor.insertar2(promotor);
            return rpta;
        }


        public static DataTable listado2()
        {
            return MPromotor.listado2();
        }

        public static Promotor buscarxcodigo(int codigo)
        {
            return MPromotor.buscarxcodigo(codigo);
        }

        public static bool insertar(Promotor promotor)
        {
            bool rpta = MPromotor.insertar(promotor);
            return rpta;
        }

        public static bool borrarTodo()
        {
            return MPromotor.borrarTodo();
        }

        public static bool borrar(int codpromotor)
        {
            return MPromotor.borrar(codpromotor);
        }


        public static Promotor buscar_promotorxnumerodocumento(Promotor promotor)
        {

            return MPromotor.buscar_promotorxnumerodocumento(promotor);
        }


    }
}

