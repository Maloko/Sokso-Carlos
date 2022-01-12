using SGEDICALE.clases;
using SGEDICALE.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.controlador
{
    public class CPunto
    {

        public static DataTable listado()
        {
            return MPunto.listado();
        }

        public static bool borrar(int codpunto)
        {
            return MPunto.borrar(codpunto);
        }


        public static bool update(Puntos punto)
        {
            return MPunto.update(punto);
        }

        public static int guardar(Puntos punto)
        {
            return MPunto.guardar(punto);
        }


        public static DataTable busqueda(string nombre)
        {
            return MPunto.busqueda(nombre);
        }

    }
}
