
using System.Collections.Generic;
using SGEDICALE.clases;
using SGEDICALE.modelo;
using System.Data;


namespace SGEDICALE.controlador
{
    public class CDiscrepanciaNotaCredito
    {


        public static List<DiscrepanciaNotaCredito> listar_discrepancia_ncc()
        {
            return MDiscrepanciaNotaCredito.listar_discrepancia_ncc();
        }


    }
}
