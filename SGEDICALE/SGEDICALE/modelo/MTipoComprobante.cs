using System;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MTipoComprobante
    {


        public static DataTable cargarTipoComprobanteCredito()
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("cargacombotipocomprobantecredito", cn);

                    cmd.CommandType = CommandType.StoredProcedure;

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

        public static DataTable cargarTipoComprobante()
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("cargacombotipocomprobante", cn);

                    cmd.CommandType = CommandType.StoredProcedure;

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


        public static TipoComprobate CargaTipoDocumento(Int32 Codigo)
        {
            TipoComprobate doc = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    cmd = new MySqlCommand("MuestraTipoDocumento", cn);
                    cmd.Parameters.AddWithValue("coddoc", Codigo);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            doc = new TipoComprobate();
                            doc.Codtipocomprobante = Convert.ToInt32(dr.GetDecimal(0));
                            doc.Sigla = dr.GetString(1);
                            doc.Nombre = dr.GetString(2);
                            doc.Estado = dr.GetBoolean(3);
                            //doc.CodUser = Convert.ToInt32(dr.GetDecimal(4));
                            //doc.FechaRegistro = dr.GetDateTime(5);// capturo la fecha 
                            doc.Codsunat = dr.GetString(4);
                        }
                    }
                }
                return doc;
            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;
            }
        }


    }
}
