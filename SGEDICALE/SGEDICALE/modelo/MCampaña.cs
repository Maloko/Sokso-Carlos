using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MCampaña
    {


        public static Boolean Insert(Campaña tar)
        {

            MySqlCommand cmd = null;

            MySqlConnection cn = null;


            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("guardacampaña", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlParameter oParam;
                    oParam = cmd.Parameters.AddWithValue("codcategoria_", tar.Categoria.CodCategoria);
                    oParam = cmd.Parameters.AddWithValue("descripcion", tar.Descripcion);
                    oParam = cmd.Parameters.AddWithValue("ano_", tar.Año);
                    oParam = cmd.Parameters.AddWithValue("finicio_", tar.Fechainicio);
                    oParam = cmd.Parameters.AddWithValue("ffin_", tar.Fechafin);
                    oParam = cmd.Parameters.AddWithValue("codUsu", tar.CodUsuario);

                    oParam = cmd.Parameters.AddWithValue("newid", 0);
                    oParam.Direction = ParameterDirection.Output;
                    int x = cmd.ExecuteNonQuery();

                    tar.CodCampaña = Convert.ToInt32(cmd.Parameters["newid"].Value);

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

        public static Boolean Update(Campaña tar)
        {

            MySqlCommand cmd = null;
        
            MySqlConnection cn = null;


            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("actualizacampaña", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codtar", tar.CodCampaña);
                    cmd.Parameters.AddWithValue("codcategoria_", tar.Categoria.CodCategoria);
                    cmd.Parameters.AddWithValue("descrip", tar.Descripcion);
                    cmd.Parameters.AddWithValue("ano_", tar.Año);
                    cmd.Parameters.AddWithValue("finicio_", tar.Fechainicio);
                    cmd.Parameters.AddWithValue("ffin_", tar.Fechafin);
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

        public static Boolean Delete(Int32 CodTarjeta)
        {

            MySqlCommand cmd = null;
            MySqlConnection cn = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    cmd = new MySqlCommand("eliminarcampaña", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codtar", CodTarjeta);

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

        public static Campaña buscar(Int32 CodTarjeta)
        {
            Campaña tar = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr;
            MySqlConnection cn = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    cmd = new MySqlCommand("buscarcampaña", cn);
                    cmd.Parameters.AddWithValue("codtar", CodTarjeta);

                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            tar = new Campaña();
                            tar.Categoria = new Categoria();
                            tar.CodCampaña =dr.GetInt32(0);
                            tar.Categoria.CodCategoria =dr.GetInt32(1);
                            tar.Descripcion = dr.GetString(2);
                            tar.Año = dr.GetString(3);
                            tar.Fechainicio = dr.GetDateTime(4);
                            tar.Fechafin = dr.GetDateTime(5);
                            tar.CodUsuario = dr.GetInt32(6);
                            tar.FechaRegistro = dr.GetDateTime(7);
                            tar.Estado = dr.GetInt32(8);
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

        public static Campaña buscarExiste(string campana, int codcategoria, string ano)
        {
            Campaña tar = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr;
            MySqlConnection cn = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    cmd = new MySqlCommand("buscarcampanaexiste", cn);
                    cmd.Parameters.AddWithValue("campana_", campana);
                    cmd.Parameters.AddWithValue("codcategoria_", codcategoria);
                    cmd.Parameters.AddWithValue("ano_", ano);

                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            tar = new Campaña();
                            tar.Categoria = new Categoria();
                            tar.CodCampaña = dr.GetInt32(0);
                            tar.Categoria.CodCategoria = dr.GetInt32(1);
                            tar.Descripcion = dr.GetString(2);
                            tar.Año = dr.GetString(3);
                            tar.Fechainicio = dr.GetDateTime(4);
                            tar.Fechafin = dr.GetDateTime(5);
                            tar.CodUsuario = dr.GetInt32(6);
                            tar.FechaRegistro = dr.GetDateTime(7);
                            tar.Estado = dr.GetInt32(8);
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


        public static DataTable CargaCampañaActivas()
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

                    MySqlCommand cmd = new MySqlCommand("cargacombocampanactivas", cn);
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
                    cmd.Parameters.AddWithValue("ano_", año);
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



        public static DataTable ListadoCampaña()
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

                    MySqlCommand cmd = new MySqlCommand("listarcampaña", cn);
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
