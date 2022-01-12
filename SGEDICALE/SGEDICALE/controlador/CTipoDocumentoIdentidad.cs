using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGEDICALE.modelo;
using SGEDICALE.clases;


namespace SGEDICALE.controlador
{
    public class CTipoDocumentoIdentidad
    {

        public static List<TipoDocumentoIdentidad> listar_tipo_documento_identidad()
        {

            return MTipoDocumentoIdentidad.listar_tipo_documento_identidad();
        }

    }
}
