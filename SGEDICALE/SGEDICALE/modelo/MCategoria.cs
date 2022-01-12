using System;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MCategoria
    {




        public static Boolean Insert(Categoria tar)
        {

            MySqlCommand cmd = null;
            MySqlConnection cn = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("guardacategoria", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlParameter oParam;
                    oParam = cmd.Parameters.AddWithValue("descripcion", tar.Descripcion);
                    oParam = cmd.Parameters.AddWithValue("codUsu", tar.CodUsuario);

                    oParam = cmd.Parameters.AddWithValue("newid", 0);
                    oParam.Direction = ParameterDirection.Output;
                    int x = cmd.ExecuteNonQuery();

                    tar.CodCategoria = Convert.ToInt32(cmd.Parameters["newid"].Value);

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
            catch (MySqlException ex)
            {
                throw ex;
            }

        }

        public static Boolean Update(Categoria tar)
        {

            MySqlCommand cmd = null;

            MySqlConnection cn = null;


            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("actualizacategoria", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codcategoria_", tar.CodCategoria);
                    cmd.Parameters.AddWithValue("descrip", tar.Descripcion);
                    cmd.Parameters.AddWithValue("estado", tar.Estado);



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
            catch (MySqlException ex)
            {
                throw ex;

            }

        }

        public static Boolean Delete(Int32 codcategoria)
        {

            MySqlCommand cmd = null;
            MySqlConnection cn = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    cmd = new MySqlCommand("eliminarcategoria", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codcategoria_", codcategoria);

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
            catch (MySqlException ex)
            {
                throw ex;

            }

        }

        public static Categoria buscar(Int32 codcategoria)
        {
            Categoria tar = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr;
            MySqlConnection cn = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    cmd = new MySqlCommand("buscarcategoria", cn);
                    cmd.Parameters.AddWithValue("codcategoria_", codcategoria);

                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            tar = new Categoria();
                            tar.CodCategoria = Convert.ToInt32(dr.GetDecimal(0));
                            tar.Descripcion = dr.GetString(1);
                            tar.CodUsuario = dr.GetInt32(2);
                            tar.FechaRegistro = dr.GetDateTime(3);
                            tar.Estado = dr.GetInt32(4);
                        }

                    }
                }
                return tar;

            }
            catch (MySqlException ex)
            {
                throw ex;
            }

        }


        public static DataTable CargaCategoria()
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable tabla = new DataTable();

            try
            {
                tabla = new DataTable();


                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    MySqlCommand cmd = new MySqlCommand("cargacombotipotarjeta", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
                return tabla;

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

        }


        public static DataTable buscarxaño(string año)
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable tabla = new DataTable();

            try
            {
                tabla = new DataTable();


                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    MySqlCommand cmd = new MySqlCommand("cargacombocampañaxaño", cn);
                    cmd.Parameters.AddWithValue("año", año);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
                return tabla;

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

        }


        public static DataTable ListadoCategoriaxCampaña(int codcampaña)
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable tabla = new DataTable();

            try
            {
                tabla = new DataTable();


                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    MySqlCommand cmd = new MySqlCommand("listarcategoriaxcodcampana", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codcampana_", codcampaña);
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
                return tabla;

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

        }



        public static DataTable ListadoCategoria()
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable tabla = new DataTable();

            try
            {
                tabla = new DataTable();


                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    MySqlCommand cmd = new MySqlCommand("listarcategoria", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(tabla);
                }
                return tabla;

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

        }
    }
}
