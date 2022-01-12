using System;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MPunto
    {



        public static int guardar(Puntos punto)
        {

            MySqlCommand cmd = null;
            MySqlConnection cn = null;

            int x = 0;

            try
            {


                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("guardapunto", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("codpromotor_", punto.Promotor.CodPromotor);
                    cmd.Parameters.AddWithValue("puntaje_", punto.Puntaje);
                    cmd.Parameters.AddWithValue("codusuario_", punto.CodUsuario);


                    cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    if (x != 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }

            }
            catch (Exception ex)
            {

                return -1;
                throw ex;
            }
        }


        public static DataTable listado()
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listadopuntos", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    cn.Dispose();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

            return dt;
        }

        public static bool borrar(int codpunto)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;


            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    using (cmd = new MySqlCommand("borrarpunto", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("codpunto_", codpunto);

                        int x = cmd.ExecuteNonQuery();

                        if (x > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }


        public static DataTable busqueda(string nombre)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("busquedapunto", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("nombre_", nombre);

                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    cn.Dispose();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

            return dt;
        }


        public static bool update(Puntos punto)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;


            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    using (cmd = new MySqlCommand("actualizapunto", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("codpunto_", punto.Codpunto);
                        cmd.Parameters.AddWithValue("puntaje_", punto.Puntaje);

                        int x = cmd.ExecuteNonQuery();

                        if (x > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }
    }
}
