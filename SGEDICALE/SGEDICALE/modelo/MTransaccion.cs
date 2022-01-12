using System;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MTransaccion
    {
        public static  Transaccion CargaTransaccion(Int32 Codigo)
        {
            Transaccion tran = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    cmd = new MySqlCommand("MuestraTransaccion", cn);
                    cmd.Parameters.AddWithValue("codtran", Codigo);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            tran = new Transaccion();
                            tran.CodTransaccion = Convert.ToInt32(dr.GetDecimal(0));
                            tran.Descripcion = dr.GetString(1);
                            tran.Sigla = dr.GetString(2);
                            tran.Codsunat = dr.GetString(3);
                            tran.Tipo = Convert.ToInt32(dr.GetDecimal(4));
                            tran.Estado = dr.GetBoolean(5);
                            tran.CodUser = Convert.ToInt32(dr.GetDecimal(6));
                            tran.FechaRegistro = dr.GetDateTime(7);// capturo la fecha 
                        }
                    }
                }
                return tran;

            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;

            }
        }
    }
}
