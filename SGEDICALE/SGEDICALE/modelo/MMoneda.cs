using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MMoneda
    {
        public static DataTable CargaMonedasHabiles()
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {
                dt = new DataTable();

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("MuestraMonedasHabiles", cn);

                    cmd.CommandType = CommandType.StoredProcedure;

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

        public static List<Moneda> listar_Moneda()
        {

            MySqlDataReader dr=null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            List<Moneda> lista = null;
            Moneda moneda=null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("listar_moneda", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista = new List<Moneda>();

                        while (dr.Read())
                        {

                            moneda = new Moneda();
                            moneda.Codmoneda = dr.GetInt32(0);
                            moneda.Codpais = dr.GetInt32(1);
                            moneda.Descripcion = dr.GetString(2);
                            moneda.Fecharegistro = dr.GetDateTime(3);
                            moneda.Codusuario = dr.GetInt32(4);
                            moneda.Estado = dr.GetBoolean(5);
                            moneda.Codsunat = dr.GetString(6);

                            lista.Add(moneda);
                        }
                       
                    }
              

                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
    }
}
