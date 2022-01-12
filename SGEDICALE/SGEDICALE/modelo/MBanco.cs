using System;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MBanco
    {
        public static bool insertar(Banco ban)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            bool listo = true;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("guardabanco", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("descripcion", ban.Descripcion);
                        cmd.Parameters.AddWithValue("sig", ban.Sigla);
                        cmd.Parameters.AddWithValue("codusu", ban.Codusuario);

                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        ban.Codusuario = Convert.ToInt32(cmd.Parameters["newid"].Value);

                        if (ban.Codusuario <= 0)
                        {
                            listo = false;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                listo = false;
                return listo;
                throw ex;
            }
            

             return listo;
        }

        public static Banco buscar(int codigobanco)
        {
            Banco banco = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("buscarbanco", cn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("cod_", codigobanco);

                        dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                banco = new Banco();

                                banco.Codbanco = dr.GetInt32(0);
                                banco.Sigla = dr.GetString(1);
                                banco.Descripcion = dr.GetString(2);
                                banco.Estado = dr.GetInt32(3).ToString() == "1" ? true : false;
                                banco.Codusuario = dr.GetInt32(4);
                                banco.Fecharegistro = dr.GetDateTime(5);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
            return banco;
        }



        public static Boolean update(Banco ban)
        {
    
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("actualizabanco", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("codban", ban.Codbanco);
                        cmd.Parameters.AddWithValue("descripcion", ban.Descripcion);
                        cmd.Parameters.AddWithValue("sig", ban.Sigla);
                        cmd.Parameters.AddWithValue("estado_", ban.Estado);
                        int x = cmd.ExecuteNonQuery();
                        if (x != 0)
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
                return false;
                throw ex;

            }
        }

        public static Boolean eliminar(int codbanco)
        {

            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("eliminarbanco", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("codban", codbanco);
                        int x = cmd.ExecuteNonQuery();
                        if (x != 0)
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
                return false;
                throw ex;

            }
        }

        public static DataTable listar()
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listadobancos", cn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    cn.Dispose();
                    cn.Close();
                }

                return dt;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }

        public static DataTable cargacombobancos()
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("cargacombobancos", cn);

                    cmd.CommandType = CommandType.StoredProcedure;

                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    cn.Dispose();
                    cn.Close();
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
