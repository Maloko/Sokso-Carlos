
using System.Data;
using SGEDICALE.modelo;
using SGEDICALE.clases;
namespace SGEDICALE.controlador
{
    public class CUnidadMedida
    {

        public static DataTable MuestraUnidades()
        {
           return MUnidadMedida.ListaUnidades();
        }

        public static DataTable MuestraUnidadesxProducto(int codproducto)
        {

            return MUnidadMedida.MuestraUnidadesxProducto(codproducto);

        }
    }
}
