using System;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MPagoComprobante
    {

        public static bool insertar(PagoComprobante pro)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("guardapagocomprobante", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("codpago_", pro.Codpago);
                        cmd.Parameters.AddWithValue("codcomprobante_", pro.Codcomprobante);
                        cmd.Parameters.AddWithValue("fechapago_", pro.Fechapago);
                        cmd.Parameters.AddWithValue("pago_", pro.Pago);
                        cmd.Parameters.AddWithValue("montopagado_", pro.Montopagado);
                        cmd.Parameters.AddWithValue("montopendiente_", pro.Montopendiente);
                        cmd.Parameters.AddWithValue("montofavor_", pro.Montofavor);
                        cmd.Parameters.AddWithValue("codusuario_", pro.Codusuario);


                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        int x = cmd.ExecuteNonQuery();
                        pro.Codpagocomprobante = Convert.ToInt32(cmd.Parameters["newid"].Value);

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

        public static DataTable muestra_UsoDepositosxNumeroOperacion(string numeroOperacion)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("UsoDeposito", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("numerooperacion_", numeroOperacion);

                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

            return dt;
        }



    }
}
