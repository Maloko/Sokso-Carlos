using System;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;


namespace SGEDICALE.modelo
{
    public class MCuenta
    {

        public static bool Insert(Cuenta cta)
        {

            MySqlConnection cn = null;
            MySqlCommand cmd = null;
         
            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("guardacuenta", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("codban", cta.CodBanco);
                        cmd.Parameters.AddWithValue("ctacte", cta.CuentaCorriente);
                        cmd.Parameters.AddWithValue("tipo", cta.TipoCuenta);
                        cmd.Parameters.AddWithValue("mone", cta.Moneda);
                        cmd.Parameters.AddWithValue("codusu", cta.CodUsuario);
                        cmd.Parameters.AddWithValue("codalma", cta.CodAlmacen);

                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        int x = cmd.ExecuteNonQuery();
                        cta.CodCuentaCorriente = Convert.ToInt32(cmd.Parameters["newid"].Value);

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


        public static Cuenta buscar(int codigobanco)
        {
         
            Cuenta cuenta = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("buscarcuenta", cn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("cod_", codigobanco);

                        dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                cuenta = new Cuenta();

                                cuenta.CodCuentaCorriente = dr.GetInt32(0);
                                cuenta.CodBanco= dr.GetInt32(1); 
                                    
                                cuenta.CuentaCorriente = dr.GetString(2);
                                cuenta.TipoCuenta = dr.GetString(3);
                                cuenta.Moneda = dr.GetInt32(4);
                                cuenta.Estado= dr.GetInt32(5);
                                cuenta.CodUsuario = dr.GetInt32(6);
                                cuenta.FechaRegistro = dr.GetDateTime(7);

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
            return cuenta;
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
                    MySqlCommand cmd = new MySqlCommand("listadocuentas", cn);

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


        public static DataTable buscarxcodbanco(int codbanco)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("buscarcuentaxcodbanco", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codban", codbanco);

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


        public static  bool Update(Cuenta cta)
        {

            MySqlConnection cn = null;
            MySqlCommand cmd = null;


            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("actualizacuenta", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codctacte", cta.CodCuentaCorriente);
                    cmd.Parameters.AddWithValue("ctacte", cta.CuentaCorriente);
                    cmd.Parameters.AddWithValue("tipo", cta.TipoCuenta);
                    cmd.Parameters.AddWithValue("mone", cta.Moneda);
                    cmd.Parameters.AddWithValue("estado", cta.Estado);
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

        public static bool Delete(int codCtaCte)
        {

            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("eliminacuenta", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codctacte", codCtaCte);

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




    }
}
