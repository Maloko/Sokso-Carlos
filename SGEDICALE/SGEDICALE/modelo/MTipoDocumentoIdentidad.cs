using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using SGEDICALE.clases;


namespace SGEDICALE.modelo
{
    public class MTipoDocumentoIdentidad
    {

       
        private MySqlCommand cmd = null;
        private static MySqlDataReader dr = null;
        private static  MySqlDataAdapter adap = null;
        private static MySqlTransaction tra = null;
        private static DataTable tabla = null;
        public static List<TipoDocumentoIdentidad> listar_tipo_documento_identidad()
        {

            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            List<TipoDocumentoIdentidad> lista_tipodociden = null;
            TipoDocumentoIdentidad tipodociden = null;
            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("listar_tipo_documento_identidad", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_tipodociden = new List<TipoDocumentoIdentidad>();

                        while (dr.Read())
                        {
                            tipodociden = new TipoDocumentoIdentidad()
                            {
                                Idtipodocumentoidentidad = (int)dr["idtipodocumentoidentidad"],
                                Descripcion = (string)dr["descripcion"],
                                Codsunat = (string)dr["codsunat"]
                            };

                            lista_tipodociden.Add(tipodociden);
                        }
                    }
                }
                return lista_tipodociden;
            }
            catch (MySqlException ex)
            {
                return lista_tipodociden;
                throw ex;
            }
         
        }
    }
}
