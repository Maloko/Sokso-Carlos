using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGEDICALE.clases;
using SGEDICALE.modelo;
using System.Data;

namespace SGEDICALE.controlador
{
    public class CCliente
    {
        public static int actualizar_cliente(Cliente cliente)
        {

            return MCliente.actualizar_cliente(cliente);
        }

        public static  DataTable buscar_clientexnombreyapellido(Cliente cliente)
        {

            return MCliente.buscar_clientexnombreyapellido(cliente);
        }

        public static Cliente buscar_clientexnumerodocumento(Cliente cliente)
        {

            return MCliente.buscar_clientexnumerodocumento(cliente);
        }


        public static Cliente buscar_clientexcodigo(int codigo)
        {
            return MCliente.buscar_clientexcodigo(codigo);
        }

        public  static DataTable listar_cliente()
        {

            return MCliente.listar_cliente();
        }

        public static int registrar_cliente(Cliente cliente)
        {

            return MCliente.registrar_cliente(cliente);
        }

    

    }
}
