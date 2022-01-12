using System;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;

namespace SGEDICALE.controlador
{
    public class CPremio
    {
        public static DataTable cargarGrilla(string ruta_excel)
        {
            return MPremio.cargarGrilla(ruta_excel);
        }

        public static bool insertar(Premio premio)
        {
            return MPremio.insertar(premio);
        }

        public static bool entregar(Premio premio)
        {
            return MPremio.entregar(premio);
        }

        public static DataTable listado()
        {
            return MPremio.listado();
        }

        public static DataTable listadoxcodcampana(int codcampana, int filtro)
        {
            return MPremio.listadoxcodcampana(codcampana,filtro);
        }

        public static DataTable busqueda(string nombre,int codcampana)
        {
            return MPremio.busqueda(nombre,codcampana);
        }

        public static DataTable listarpremiosxcodcampana_codpromotor(int codpromotor, int codcampana)
        {
            return MPremio.listarpremiosxcodcampana_codpromotor(codpromotor, codcampana);
        }



        public static bool borrar(int codcampana)
        {
            return MPremio.borrar(codcampana);
        }

    }
}
