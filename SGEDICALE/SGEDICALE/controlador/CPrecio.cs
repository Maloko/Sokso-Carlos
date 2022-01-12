using System;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;
namespace SGEDICALE.controlador
{
    public class CPrecio
    {

        public static DataTable cargarGrilla(string ruta_excel)
        {
            return MPrecio.cargarGrilla(ruta_excel);
        }

        public static bool insertar(Precio precio)
        {
            return MPrecio.insertar(precio);
        }

        public static bool insertarDetalle(DetallePrecio detcat)
        {
            return MPrecio.insertarDetalle(detcat);
        }

        public static Precio buscarxcodcampana(Int32 Codigo)
        {
            return MPrecio.buscarxcodcampana(Codigo);

        }

        public static DataTable busquedaDetalle(int codcampana)
        {
            return MPrecio.busquedaDetalle(codcampana);
        }

        public static DataTable Comparacion(int codcampana)
        {
            return MPrecio.Comparacion(codcampana);
        }

    }
}
