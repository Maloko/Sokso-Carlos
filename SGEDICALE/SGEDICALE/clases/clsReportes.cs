using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using SGEDICALE.modelo;
using System.Threading.Tasks;
using System.Data.OleDb;
using SGEDICALE.clases;

namespace SGEDICALE.clases
{
    public class clsReportes
    {

        public  DataSet ReportePrecio()
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
            finally {
                cn.Dispose();
                cn.Close();
            }
        }
    }
}
