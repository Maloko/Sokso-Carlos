using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;
using SGEDICALE.clases;


namespace SGEDICALE.modelo
{
    public class MFormaPago
    {

        /*
        public static Boolean Insert(FormaPago pago)
        {


            MySqlCommand cmd = null;
            MySqlConnection cn = null;


            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("GuardaFormaPago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlParameter oParam;
                    oParam = cmd.Parameters.AddWithValue("dias", pago.Dias);
                    oParam = cmd.Parameters.AddWithValue("descripcion", pago.Descripcion);
                    oParam = cmd.Parameters.AddWithValue("tipo", pago.Tipo);
                    oParam = cmd.Parameters.AddWithValue("codusu", pago.CodUser);
                    oParam = cmd.Parameters.AddWithValue("tipoa", pago.Tipoaccion);
                    oParam = cmd.Parameters.AddWithValue("newid", 0);
                    oParam.Direction = ParameterDirection.Output;
                    int x = cmd.ExecuteNonQuery();

                    pago.CodFormaPago = Convert.ToInt32(cmd.Parameters["newid"].Value);

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

        public static Boolean Update(FormaPago pago)
        {
            MySqlCommand cmd = null;
            MySqlConnection cn = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("ActualizaFormaPago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codpago", pago.CodFormaPago);
                    cmd.Parameters.AddWithValue("dias", pago.Dias);
                    cmd.Parameters.AddWithValue("descripcion", pago.Descripcion);
                    cmd.Parameters.AddWithValue("tipo", pago.Tipo);
                    cmd.Parameters.AddWithValue("tipoa", pago.Tipoaccion);
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

        public Boolean Delete(Int32 CodFormaPago)
        {

            MySqlCommand cmd = null;
            MySqlConnection cn = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("EliminarFormaPago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codpago", CodFormaPago);
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
        public FormaPago CargaFormaPago(Int32 Codigo)
        {
            MySqlCommand cmd = null;
            MySqlConnection cn = null;
            FormaPago pago = null;
            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("MuestraFormaPago", cn);
                    cmd.Parameters.AddWithValue("codpago", Codigo);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            pago = new FormaPago();
                            pago.CodFormaPago = Convert.ToInt32(dr.GetDecimal(0));
                            pago.IDias = Convert.ToInt32(dr.GetDecimal(1));
                            pago.Descripcion = dr.GetString(2);
                            pago.Estado = dr.GetBoolean(3);
                            pago.CodUsuario = Convert.ToInt32(dr.GetDecimal(4));
                            pago.FechaRegistro = dr.GetDateTime(5);// capturo la fecha 
                            pago.Tipo = dr.GetBoolean(6);
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
        */


    }
}
