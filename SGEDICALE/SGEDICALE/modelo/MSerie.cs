using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MSerie
    {
        public static List<Serie> cargarSeriexTipocomprobante(int codtipocomprobante)
        {
            Serie serie = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            List<Serie> lista = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    using (cmd = new MySqlCommand("cargaseriextipocomprobante", cn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("codtipo_", codtipocomprobante);

                        dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            lista = new List<Serie>();
                            while (dr.Read())
                            {
                                serie = new Serie();
                                serie.CodSerie = dr.GetInt32(0);
                                serie.Codtipocomprobante = dr.GetInt32(1);
                                serie.Sserie = dr.GetString(2);
                                serie.Correlativo = dr.GetInt32(5);
                                serie.Nombreimpresora = dr.GetString(6);
                                serie.Papersize = dr.GetString(7);
                                serie.Serieimpresora = dr.GetString(8);

                                lista.Add(serie);
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

            return lista;

        }

        public static Serie cargarCorrelativo(int codtipocomprobante,int codserie)
        {
            Serie serie = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
          

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("cargacorrelativo", cn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("codtipo_", codtipocomprobante);
                        cmd.Parameters.AddWithValue("serie_", codserie);

                        dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                         
                            while (dr.Read())
                            {
                                serie = new Serie();
                                serie.CodSerie = dr.GetInt32(0);
                                serie.Codtipocomprobante = dr.GetInt32(1);
                                serie.Sserie = dr.GetString(2);
                                serie.Correlativo = dr.GetInt32(5);
                                serie.Nombreimpresora = dr.GetString(6);
                                serie.Papersize = dr.GetString(7);
                                serie.Serieimpresora = dr.GetString(8);

                            }
                        }
                    }

                    return serie;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }


        public static List<Serie> listarseries()
        {
            Serie serie = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            List<Serie> lista = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("listarseriesfacturacion", cn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        

                        dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            lista = new List<Serie>();
                            while (dr.Read())
                            {
                                serie = new Serie();
                                serie.CodSerie = dr.GetInt32(0);
                                serie.Codtipocomprobante = dr.GetInt32(1);
                                serie.Sserie = dr.GetString(2);
                                serie.Correlativo = dr.GetInt32(5);
                                serie.Nombreimpresora = dr.GetString(6);
                                serie.Papersize = dr.GetString(7);
                                serie.Serieimpresora = dr.GetString(8);

                                lista.Add(serie);
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

            return lista;

        }


    }
}
