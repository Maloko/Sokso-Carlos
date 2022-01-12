using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;
using SGEDICALE.clases;

namespace SGEDICALE.modelo
{
    public class MTipoTarjeta
    {



        public static Boolean Insert(TipoTarjeta tar)
        {

            MySqlCommand cmd = null;

            MySqlConnection cn = null;


            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("guardatipotarjeta", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlParameter oParam;
                    oParam = cmd.Parameters.AddWithValue("descripcion", tar.Descripcion);
                    oParam = cmd.Parameters.AddWithValue("codUsu", tar.Codusuario);

                    oParam = cmd.Parameters.AddWithValue("newid", 0);
                    oParam.Direction = ParameterDirection.Output;
                    int x = cmd.ExecuteNonQuery();

                    tar.Codtipotarjeta = Convert.ToInt32(cmd.Parameters["newid"].Value);

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

        public static  Boolean Update(TipoTarjeta tar)
        {

            MySqlCommand cmd = null;
            MySqlDataAdapter da;
            MySqlConnection cn = null;
   

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("actualizatipotarjeta", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codtar", tar.Codtipotarjeta);
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

        public static Boolean Delete(Int32 CodTarjeta)
        {

            MySqlCommand cmd = null;
            MySqlDataAdapter da;
            MySqlConnection cn = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    cmd = new MySqlCommand("eliminartipotarjeta", cn);
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

        public static TipoTarjeta buscar(Int32 CodTarjeta)
        {
            TipoTarjeta tar = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr;
            MySqlConnection cn = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    cmd = new MySqlCommand("buscartipotarjeta", cn);
                    cmd.Parameters.AddWithValue("codtar", CodTarjeta);
               
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            tar = new TipoTarjeta();
                            tar.Codtipotarjeta = Convert.ToInt32(dr.GetDecimal(0));
                            tar.Descripcion = dr.GetString(1);
                            tar.Estado = dr.GetInt32(2);
                            tar.Codusuario = dr.GetInt32(3);
                            tar.Fecharegistro = dr.GetDateTime(4);
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





        public static DataTable CargaTipoTarjeta()
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

        public static DataTable ListadoTipoTarjeta()
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

                    MySqlCommand cmd = new MySqlCommand("listartipotarjeta", cn);
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
