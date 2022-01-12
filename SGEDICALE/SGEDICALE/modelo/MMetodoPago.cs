using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MMetodoPago
    {



        public static Boolean Insert(MetodoPago pago)
        {

            MySqlCommand cmd = null;

            MySqlConnection cn = null;
  

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("guardametodopago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlParameter oParam;
                    oParam = cmd.Parameters.AddWithValue("descripcion", pago.Descripcion);
                    oParam = cmd.Parameters.AddWithValue("codusu", pago.Codusuario);
                    
                   oParam = cmd.Parameters.AddWithValue("newid", 0);
                    oParam.Direction = ParameterDirection.Output;
                    int x = cmd.ExecuteNonQuery();

                    pago.Codmetodopago = Convert.ToInt32(cmd.Parameters["newid"].Value);

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

        public static Boolean Update(MetodoPago pago)
        {

            MySqlCommand cmd = null;
            MySqlDataAdapter da;
            MySqlConnection cn = null;
       

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("actualizametodopago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codpago", pago.Codmetodopago);
                    cmd.Parameters.AddWithValue("descripcion", pago.Descripcion);
                    cmd.Parameters.AddWithValue("estado", pago.Estado);
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


        public static Boolean Delete(Int32 CodMetodoPago)
        {

            MySqlCommand cmd = null;
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable tabla = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("eliminarmetodopago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codpago", CodMetodoPago);
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





        public static DataTable CargaMetodoPagos()
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

                    MySqlCommand cmd = new MySqlCommand("cargametodopagos", cn);
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

        public static DataTable ListaMetodoPagos()
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

                    MySqlCommand cmd = new MySqlCommand("listametodopagos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(tabla);
                    return tabla;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
   
        }


        public static MetodoPago BuscaMetodoPago(int Codigo)
        {
            MetodoPago pago = null;

            MySqlDataReader dr;
            MySqlCommand cmd = null;
            MySqlConnection cn = null;
            DataTable tabla = new DataTable();

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("buscametodopago", cn);
                    cmd.Parameters.AddWithValue("cod", Codigo);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            pago = new MetodoPago();
                            pago.Codmetodopago = Convert.ToInt32(dr.GetInt32(0));
                            pago.Descripcion = dr.GetString(1);
                            pago.Estado = dr.GetInt32(2);
                        }
                    }
                }
                return pago;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }


    }
}
