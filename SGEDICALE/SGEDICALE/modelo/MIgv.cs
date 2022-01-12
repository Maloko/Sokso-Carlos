using System;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MIgv
    {
        public static Igv listar_igv_anual()
        {
            Igv igv = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    using (cmd = new MySqlCommand("listar_igv_anual", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                igv = new Igv()
                                {
                                    Igvid = dr.GetInt32(0),
                                    Valor = dr.GetDecimal(1),
                                    Valorinverso = dr.GetDecimal(2),
                                    Anho = dr.GetInt32(3),
                                    Estado = dr.GetInt32(4)

                                };
                            }
                        }
                    }
                }
                return igv;
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }

        public static int registar_igv(Igv igv)
        {
            int id = -1;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("registar_igv", cn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add(new MySqlParameter("@_valor", MySqlDbType.Decimal));
                    cmd.Parameters.Add(new MySqlParameter("@_valorinverso", MySqlDbType.Decimal));
                    cmd.Parameters.Add(new MySqlParameter("@_anho", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = igv.Valor;
                    cmd.Parameters[1].Value = igv.Valorinverso;
                    cmd.Parameters[2].Value = igv.Anho;
                    cmd.Parameters[3].Value = igv.Estado;

                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            id = Convert.ToInt32(dr["_id"]);
                        }
                        dr.Close();
                    }
                    cn.Close();

                }

                return id;
            }
            catch (Exception ex)
            {
                return id;
                throw ex;
            }

        }

        public static int actualizar_igv(Igv igv)
        {
            int filasafectadas = -1;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("actualizar_igv", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new MySqlParameter("@_igvid", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_valor", MySqlDbType.Decimal));
                    cmd.Parameters.Add(new MySqlParameter("@_valorinverso", MySqlDbType.Decimal));
                    cmd.Parameters.Add(new MySqlParameter("@_anho", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = igv.Igvid;
                    cmd.Parameters[1].Value = igv.Valor;
                    cmd.Parameters[2].Value = igv.Valorinverso;
                    cmd.Parameters[3].Value = igv.Anho;
                    cmd.Parameters[4].Value = igv.Estado;

                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            filasafectadas = Convert.ToInt32(dr["_filas_afectadas"]);
                        }
                        dr.Close();
                    }

                    cn.Close();
                }
               
                return filasafectadas;
            }
            catch (Exception ex)
            {           
                return filasafectadas;
                throw ex;
            }
        }

        public static DataTable listar_igv()
        {
            MySqlDataAdapter da = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            DataTable tabla = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    tabla = new DataTable();
                    cmd = new MySqlCommand("listar_igv", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(tabla);

                    if (tabla.Rows.Count == 0) tabla = null;

                }

                return tabla;
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }


    }
}
