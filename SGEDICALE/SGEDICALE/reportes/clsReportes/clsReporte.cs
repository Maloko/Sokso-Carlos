using System;
using MySql.Data.MySqlClient;
using System.Data;
using SGEDICALE.modelo;


namespace SGEDICALE.reportes.clsReportes
{
    public class clsReporte
    {
        public DataSet DocumentosEnviados(DateTime fechaInicio, DateTime fechaFin, Int32 codDocumento, Int32 estado)
        {

            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            DataSet set = null;
            MySqlDataAdapter adap = null;

            try
            {
                set = new DataSet();
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    cmd = new MySqlCommand("ReporteDocumentosElectronicosEnviados", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 400000;
                    cmd.Parameters.AddWithValue("fechainicio_", fechaInicio);
                    cmd.Parameters.AddWithValue("fechafin_", fechaFin);
                    cmd.Parameters.AddWithValue("codigo_documento", codDocumento);
                    cmd.Parameters.AddWithValue("estado", estado);
                    adap = new MySqlDataAdapter(cmd);
                    adap.Fill(set, "dt_enviado");
                    set.WriteXml("C:\\XML\\DocumentosEnviadosRPT.xml", XmlWriteMode.WriteSchema);
                }
                return set;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }

        public DataSet ReportePrecio()
        {

            DataSet set = new DataSet();
            MySqlCommand cmd = null;
            MySqlConnection cn = null;
            MySqlDataAdapter adap = null;

            try
            {

                if (cn == null)
                {
                    cn = new MySqlConnection(Conexion.cadenaConexion);
                    cn.Open();
                }

                cmd = new MySqlCommand("reporteprecio", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = Int32.MaxValue;
                adap = new MySqlDataAdapter(cmd);
                adap.Fill(set, "dt_reportprecio");
                set.WriteXml("C:\\XML\\precioRPT.xml", XmlWriteMode.WriteSchema);
                return set;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                cn.Dispose();
                cn.Close();
            }
        }

        public static DataSet ReporteSaldoFavor(int cod)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            DataSet set = null;
            MySqlDataAdapter adap = null;

            try
            {
                set = new DataSet();

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    using (cmd = new MySqlCommand("reportesaldofavor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 15;
                        cmd.Parameters.AddWithValue("cod_", cod);
                        adap = new MySqlDataAdapter(cmd);
                        adap.Fill(set, "dtSaldo");
                        set.WriteXml("C:\\XML\\SaldoaFavorDicale.xml", XmlWriteMode.WriteSchema);

                    }
                }
                return set;
            }
            catch (MySqlException ex)
            {
             
                throw ex;
            }

        }


    }
}
