using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace SGEDICALE.modelo
{
    public class Conexion
    {
        public Conexion() { }

        public static String cadenaConexion
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnNegocio"].ConnectionString;
            }
        }

        public void GeneraraBackup(String file)
        {
            try
            {

                using (MySqlConnection conn = new MySqlConnection(cadenaConexion))
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(file);
                            conn.Close();
                        }
                    }
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
