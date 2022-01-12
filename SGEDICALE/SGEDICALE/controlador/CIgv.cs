
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;

namespace SGEDICALE.controlador
{
    public class CIgv
    {

        public static Igv listar_igv_anual()
        {
            return MIgv.listar_igv_anual();
        }

        public static int registar_igv(Igv igv)
        {
            return MIgv.registar_igv(igv);
        }

        public static int actualizar_igv(Igv igv)
        {
            return MIgv.actualizar_igv(igv);
        }

        public static DataTable listar_igv()
        {

            return MIgv.listar_igv();
        }


    }
}
