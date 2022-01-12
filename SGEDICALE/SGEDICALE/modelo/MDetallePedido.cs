using System;
using MySql.Data.MySqlClient;
using System.Data;


namespace SGEDICALE.modelo
{
    public class MDetallePedido
    {

        public static DataTable listardetalle(int codpedido)
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listardetallepedido", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codpedido_", codpedido);

                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

            return dt;
        }


        public static DataTable listardetallefiltro(int codpedido)
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listardetallepedidofiltro", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codpedido_", codpedido);

                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

            return dt;

        }
    }
}
