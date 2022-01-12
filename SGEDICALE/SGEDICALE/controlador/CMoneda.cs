
using System.Collections.Generic;
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;

namespace SGEDICALE.controlador
{
    public class CMoneda
    {
        public static DataTable CargaMonedasHabiles()
        {
            
           return MMoneda.CargaMonedasHabiles();

        }

        public static List<Moneda> listar_Moneda()
        {

            return MMoneda.listar_Moneda();
        }

    }
}
