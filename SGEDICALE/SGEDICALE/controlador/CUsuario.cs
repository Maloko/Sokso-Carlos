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
    public class CUsuario
    {

        public static  Usuario validar_ingreso(Usuario usuario)
        {
            return MUsuario.validar_ingreso(usuario);
        }

        public static int registrar_usuario(Usuario usuario, Usuario usureg)
        {

            return MUsuario.registrar_usuario(usuario, usureg);
        }

        public static List<Usuario> listar_usuario_acceso()
        {

            return MUsuario.listar_usuario_acceso();
        }


        public static int actualizar_usuario(Usuario usuario, Usuario usureg)
        {
            return MUsuario.actualizar_usuario(usuario, usureg);
        }

        public static DataTable listar_usuario()
        {

            return MUsuario.listar_usuario();
        }

        public static DataTable buscar_usuarioxnombreapellido(Usuario usuario)
        {

            return MUsuario.buscar_usuarioxnombreapellido(usuario);
        }



    }
}
