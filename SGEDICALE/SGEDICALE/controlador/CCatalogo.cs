using System;
using System.Collections.Generic;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;


namespace SGEDICALE.controlador
{
    public class CCatalogo
    {
        public static DataTable cargarGrilla(string ruta_excel)
        {
            return MCatalogo.cargarGrilla(ruta_excel);
        }

        public static bool insertar(Catalogo catalogo)
        {
            return MCatalogo.insertar(catalogo);
        }

        public static bool insertarDetalle(DetalleCatalogo detcat)
        {
            return MCatalogo.insertarDetalle(detcat);
        }

        public static DataTable busqueda(int codcatalogo,string categoria)
        {
            return MCatalogo.busqueda(codcatalogo,categoria);
        }

        public static DataTable cargarCampaña()
        {
            return MCatalogo.cargaCampaña();
        }

    }
}
