using System;
using System.Collections.Generic;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MTipoUsuario
    {

        public static  List<TipoUsuario> listar_tipousuario()
        {
            List<TipoUsuario> lista_tipousuario = null;
            TipoUsuario tipousuario = null;

            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("listar_tipousuario", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_tipousuario = new List<TipoUsuario>();

                        while (dr.Read())
                        {
                            tipousuario = new TipoUsuario()
                            {
                                Tipousuarioid = (int)dr["tipousuarioid"],
                                Descripcion = (string)dr["descripciontipo"]
                            };

                            lista_tipousuario.Add(tipousuario);

                        }
                    }


                }
                return lista_tipousuario;
            }
            catch (MySqlException ex)
            {
                return lista_tipousuario;
                throw ex;
            }
       
        }
    }
}
