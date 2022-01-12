using System;
using System.Collections.Generic;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;


namespace SGEDICALE.controlador
{
    public class CCampaña
    {

        public static DataTable CargaCampañaActivas()
        {
            return MCampaña.CargaCampañaActivas();

        }

        public static DataTable buscarxaño(string año)
        {
            return MCampaña.buscarxaño(año);

        }

        public static DataTable ListadoCampaña()
        {
            return MCampaña.ListadoCampaña();

        }

        public static bool Insert(Campaña tar)
        {

            return MCampaña.Insert(tar);

        }

        public static Boolean Update(Campaña tar)
        {

            return MCampaña.Update(tar);

        }

        public static Boolean Delete(Int32 Codtar)
        {

            return MCampaña.Delete(Codtar);

        }

        public static Campaña buscar(Int32 Codigo)
        {
            return MCampaña.buscar(Codigo);

        }

        public static Campaña buscarExiste(string nombre,int codcategoria, string ano)
        {
            return MCampaña.buscarExiste(nombre,codcategoria,ano);

        }
    }
}
