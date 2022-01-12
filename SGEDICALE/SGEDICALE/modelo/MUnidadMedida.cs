using System;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MUnidadMedida
    {

        public static DataTable ListaUnidades()
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();
            MySqlCommand cmd = null;
            try
            {

                dt = new DataTable();

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cmd = new MySqlCommand("ListaUnidades", cn);

                 
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                return dt;

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }


        public static DataTable MuestraUnidadesxProducto(int codProducto)
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();
            MySqlCommand cmd = null;
            try
            {

                dt = new DataTable();

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cmd = new MySqlCommand("listaunidadesxcodproducto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codproducto_",codProducto);

                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                return dt;

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }



    }
}
