using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MDiscrepanciaNotaCredito
    {


        public static List<DiscrepanciaNotaCredito> listar_discrepancia_ncc()
        {
            List<DiscrepanciaNotaCredito> lista_discrepancia_ncc = null;
            DiscrepanciaNotaCredito discrepancia = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("listar_discrepancia_notacredito", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_discrepancia_ncc = new List<DiscrepanciaNotaCredito>();

                        while (dr.Read())
                        {
                            discrepancia = new DiscrepanciaNotaCredito
                            {

                                Iddiscrepancia = (int)dr["iddiscrepancianc"],
                                Codsunat = (string)dr["codsunat"],
                                Descripcion = (string)dr["descripcion"],
                                Estado = (int)dr["estado"]
                            };

                            lista_discrepancia_ncc.Add(discrepancia);
                        }
                    }
                }
                return lista_discrepancia_ncc;
            }
            catch (MySqlException ex)
            {
                return lista_discrepancia_ncc;
                throw ex;
            }
        }
    }
}
