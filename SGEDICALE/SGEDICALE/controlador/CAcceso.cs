using SGEDICALE.clases;
using SGEDICALE.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGEDICALE.controlador
{
    public class CAcceso
    {
       
        public CAcceso()
        {

        }

        public static List<Acceso> listar_acceso_aformulario()
        {

            return MAcceso.listar_acceso_aformulario();
        }

        public static int registar_acceso_aformulario(Acceso acceso)
        {

            return MAcceso.registar_acceso_aformulario(acceso);
        }

    

        public static int actualizar_acceso_aformulario(Acceso acceso)
        {

            return MAcceso.actualizar_acceso_aformulario(acceso);
        }

        public static  bool existe_acceso_aformulario(Acceso acceso)
        {

            return MAcceso.existe_acceso_aformulario(acceso);
        }

        public static  List<Acceso> listar_acceso_aformulario_xusuario(Acceso acceso)
        {

            return MAcceso.listar_acceso_aformulario_xusuario(acceso);
        }

    }
}
