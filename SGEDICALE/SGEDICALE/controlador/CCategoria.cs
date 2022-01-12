using System;
using System.Collections.Generic;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;

namespace SGEDICALE.controlador
{
    public class CCategoria
    {

        public static DataTable CargaCategoria()
        {
            return MCategoria.CargaCategoria();

        }



        public static DataTable ListadoCategoriaxCampaña(int codcampaña)
        {
            return MCategoria.ListadoCategoriaxCampaña(codcampaña);

        }

        public static DataTable buscarxaño(string año)
        {
            return MCategoria.buscarxaño(año);

        }

        public static DataTable ListadoCategoria()
        {
            return MCategoria.ListadoCategoria();

        }

        public static bool Insert(Categoria tar)
        {

            return MCategoria.Insert(tar);

        }

        public static Boolean Update(Categoria tar)
        {

            return MCategoria.Update(tar);

        }

        public static Boolean Delete(Int32 Codtar)
        {

            return MCategoria.Delete(Codtar);

        }

        public static Categoria buscar(Int32 Codigo)
        {
            return MCategoria.buscar(Codigo);

        }
    }
}
