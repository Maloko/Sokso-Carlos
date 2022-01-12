
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;

namespace SGEDICALE.controlador
{
    public class CDetallePedido
    {

        public static DataTable listardetallefiltro(int codpedido)
        {
            return MDetallePedido.listardetallefiltro(codpedido);
        }

        public static DataTable listardetalle(int codpedido)
        {
            return MDetallePedido.listardetalle(codpedido);
        }


    }
}
