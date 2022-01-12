using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGEDICALE.clases;
using SGEDICALE.controlador;
using SGEDICALE.modelo;

namespace SGEDICALE.controlador
{
    public class CTipoUsuario
    {

        public static List<TipoUsuario> listar_tipousuario()
        {

            return MTipoUsuario.listar_tipousuario();
        }

    }
}
