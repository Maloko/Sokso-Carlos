using System;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MTipoCambio
    {

        public static Boolean Insert(TipoCambio tc)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("guardatipocambio", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlParameter oParam;
                    oParam = cmd.Parameters.AddWithValue("compra", tc.Compra);
                    oParam = cmd.Parameters.AddWithValue("venta", tc.Venta);
                    oParam = cmd.Parameters.AddWithValue("fecha", tc.Fecha);
                    oParam = cmd.Parameters.AddWithValue("codusu", tc.Codusuario);
                    oParam = cmd.Parameters.AddWithValue("codmon", tc.Codmoneda);
                    oParam = cmd.Parameters.AddWithValue("newid", 0);
                    oParam.Direction = ParameterDirection.Output;
                    int x = cmd.ExecuteNonQuery();

                    tc.Codtipocambio = Convert.ToInt32(cmd.Parameters["newid"].Value);

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
                return false;
                throw ex;
            }
        }


        public static  Boolean Update(TipoCambio tc)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("actualizatipocambio", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codtc", tc.Codtipocambio);
                    cmd.Parameters.AddWithValue("compra", tc.Compra);
                    cmd.Parameters.AddWithValue("venta", tc.Venta);
                    cmd.Parameters.AddWithValue("codMon", tc.Codmoneda);
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
                return false;
                throw ex;

            }
    
        }

        public static  Boolean Delete(Int32 CodTipoCambio)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("eliminartipocambio", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codtc", CodTipoCambio);
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
                return false;
                throw ex;
            }
      
        }



        public static TipoCambio listartipocambioxmoneda(int codigomoneda , DateTime fecha)
        {
            TipoCambio tipoc = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    using (cmd = new MySqlCommand("listartipocambioxmoneda", cn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("cod_", codigomoneda);
                        cmd.Parameters.AddWithValue("fecha_", fecha);

                        dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                tipoc = new TipoCambio();

                                tipoc.Codtipocambio = dr.GetInt32(0);
                                tipoc.Compra = dr.GetDecimal(1);
                                tipoc.Venta = dr.GetDecimal(2); ;
                                tipoc.Fecha = dr.GetDateTime(3);
                                tipoc.Estado = dr.GetInt32(4);
                                tipoc.Codusuario = dr.GetInt32(5);
                                tipoc.Fecharegistro = dr.GetDateTime(6);
                                tipoc.Codmoneda = dr.GetInt32(7);
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

            return tipoc;
        }


        public static TipoCambio buscar(DateTime Fecha, Int32 codMoneda)
        {
            TipoCambio tc = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("buscartipocambio", cn);
                    cmd.Parameters.AddWithValue("fechab", Fecha);
                    cmd.Parameters.AddWithValue("codM", codMoneda);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            tc = new TipoCambio();
                            tc.Codtipocambio = dr.GetInt32(0);
                            tc.Compra = dr.GetDecimal(1);
                            tc.Venta = dr.GetDecimal(2);
                            tc.Fecha = dr.GetDateTime(3);
                            tc.Estado = dr.GetInt32(4);
                            tc.Codusuario = dr.GetInt32(5);
                            tc.Fecharegistro = dr.GetDateTime(6);
                            tc.Codmoneda = dr.GetInt32(7);
                        }
                    }
                }
                return tc;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public static TipoCambio buscarxcodigo(int codtipocambio)
        {
            TipoCambio tc = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("buscartipocambioxcodigo", cn);
                    cmd.Parameters.AddWithValue("cod_", codtipocambio);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            tc = new TipoCambio();
                            tc.Codtipocambio = dr.GetInt32(0);
                            tc.Compra = dr.GetDecimal(1);
                            tc.Venta = dr.GetDecimal(2);
                            tc.Fecha = dr.GetDateTime(3);
                            tc.Estado = dr.GetInt32(4);
                            tc.Codusuario = dr.GetInt32(5);
                            tc.Fecharegistro = dr.GetDateTime(6);
                            tc.Codmoneda = dr.GetInt32(7);
                        }
                    }
                }
                return tc;
            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;
            }
        }


        public static TipoCambio ultimo_tipocambio()
        {
            TipoCambio tc = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                TipoCambio tipocambio = null;

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    cmd = new MySqlCommand("listar_ultimo_tipo_cambio", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {

                        while (dr.Read())
                        {

                            tipocambio = new TipoCambio();
                            tipocambio.Codtipocambio = dr.GetInt32(0);
                            tipocambio.Compra = dr.GetDecimal(1);
                            tipocambio.Venta = dr.GetDecimal(2);

                        }
                        dr.Close();
                    }
                    dr.Close();
                }

                return tc;
            }
            catch (Exception ex)
            {

                return null;
                throw ex;

            }
        }


        public static DataTable listadotipocambio(Int32 Mes, Int32 Año)
        {
          
            MySqlDataAdapter adap = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            DataTable tabla = new DataTable();

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {

                    cmd = new MySqlCommand("ListaTipoCambios", cn);
                    cmd.Parameters.AddWithValue("mes", Mes);
                    cmd.Parameters.AddWithValue("año", Año);
                    cmd.CommandType = CommandType.StoredProcedure;
                    adap = new MySqlDataAdapter(cmd);
                    adap.Fill(tabla);
                  

                }
                return tabla;

            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;
            }
        }
    }
}
