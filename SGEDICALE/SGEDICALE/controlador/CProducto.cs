using System;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;

namespace SGEDICALE.controlador
{
    public class CProducto
    {

        public static DataTable cargarGrilla(string ruta_excel, string nombre_excel)
        {
            return MProducto.cargarGrilla(ruta_excel, nombre_excel);
        }

        public static bool insertar(Producto pro)
        {
            return MProducto.insertar(pro);
        }


        public static bool insertarProductoNuevo(Producto pro)
        {
            return MProducto.insertarProductoNuevo(pro);
        }


        public static bool actualizarProductoNuevo(Producto pro)
        {
            return MProducto.actualizarProductoNuevo(pro);
        }

        public static bool actualizar(Producto pro)
        {
            return MProducto.actualizar(pro);
        }

        public static DataTable listado()
        {
            return MProducto.listado();
        }

        public static String SiglaUnidadBase(Int32 codUnd)
        {
           return MProducto.SiglaUnidadBase(codUnd);      
        }

        public static DataTable listadoNuevos()
        {
            return MProducto.listadoNuevos();
        }


        public static bool borrar(int codProducto)
        {
            return MProducto.borrar(codProducto);
        }

        public static bool borrarTodo()
        {
            return MProducto.borrarTodo();
        }


        public static DataTable busqueda(string nombre)
        {
            return MProducto.busqueda(nombre);
        }


        public static DataTable busquedaxfiltro(string nombre,string filtro)
        {
            return MProducto.busquedaxfiltro(nombre,filtro);
        }

        public static Producto busquedaxnombre(string nombre)
        {
            return MProducto.busquedaxnombre(nombre);
        }


        public static Producto busquedaxcod(int cod)
        {
            return MProducto.busquedaxcod(cod);
        }


        public static Producto CargaProducto(Int32 CodProducto)
        {
          return MProducto.CargaProducto(CodProducto);
        }


    }
}
