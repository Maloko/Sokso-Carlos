using System;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;


namespace SGEDICALE.controlador
{
    public class CProductoUnidad
    {

        public static bool insertar(ProductoUnidad pro)
        {
            return MProductoUnidad.insertar(pro);
        }

        public static bool actualizar(ProductoUnidad pro)
        {
            return MProductoUnidad.actualizar(pro);

        }

        public static DataTable listado()
        {
            return MProductoUnidad.listado();
        }

        public static DataTable listadoxcodProducto(int cod)
        {
            return MProductoUnidad.listadoxcodProducto(cod);
        }


        public static ProductoUnidad precioventaxunidad(int codproducto, int codunidadmedida)
        {
            return MProductoUnidad.precioventaxunidad(codproducto,codunidadmedida);
        }

    }
}
