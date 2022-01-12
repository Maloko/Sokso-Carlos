using System;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MCobro
    {

        public static int registar_cobro(Cobro cobro)
        {
            int id = -1;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("registrar_cobro", cn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add(new MySqlParameter("@_fechacobro", MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("@_comprobanteid", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_tipocobroid", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_tarjetaid", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_bancoid", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_cuentaid", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_noperacion", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_notacreditoid", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_monto", MySqlDbType.Decimal));
                    cmd.Parameters.Add(new MySqlParameter("@_cajaid", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_observacion", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_codusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = cobro.Fechacobro;
                    cmd.Parameters[1].Value = cobro.Codcomprobante;
                    cmd.Parameters[2].Value = cobro.Codmetodopago;
                    cmd.Parameters[3].Value = cobro.Codtipotarjeta;
                    cmd.Parameters[4].Value = cobro.Codbanco;
                    cmd.Parameters[5].Value = cobro.Codcuenta;
                    cmd.Parameters[6].Value = cobro.Noperacion;
                    cmd.Parameters[7].Value = cobro.Codnotacredito;
                    cmd.Parameters[8].Value = cobro.Monto;
                    cmd.Parameters[9].Value = cobro.Codcaja;
                    cmd.Parameters[10].Value = cobro.Observacion;
                    cmd.Parameters[11].Value = cobro.Estado;
                    cmd.Parameters[12].Value = cobro.Codusuario;

                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            id = Convert.ToInt32(dr["_id"]);
                        }
                        dr.Close();
                    }
                }

                return id;
            }
            catch (Exception ex)
            {     
                return id;
                throw ex;
            }
        }


        public static int anular_cobro(Cobro cobro, Usuario usureg)
        {
            int filas_afectadas = -1;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
           MySqlTransaction tra = null;

            try
            {
                cn = new MySqlConnection(Conexion.cadenaConexion);

                if (cn == null)
                {
                    cn.Open();
                }
                
                    
                tra = cn.BeginTransaction();
                cmd = new MySqlCommand("anular_cobro_xid", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Transaction = tra;
                cmd.Parameters.Add(new MySqlParameter("@_idcobro", MySqlDbType.Int32));
                cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                 cmd.Parameters[0].Value = cobro.Codcobro;
                 cmd.Parameters[1].Value = usureg.Usuarioid;

                    dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        filas_afectadas = Convert.ToInt32(dr["_filas_afectadas"]);
                    }
                    dr.Close();

                    tra.Commit();

                }
                return filas_afectadas;
            }
            catch (MySqlException ex)
            {
                filas_afectadas = -1;
                tra.Rollback();
                return filas_afectadas;
                throw ex;
            }
            finally { cn.Dispose(); cmd.Dispose(); cn.Close(); }
        }


        public static DataTable muestra_cobrosxcodComprobante(int codcomprobante)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listacobros", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codcomprobante_", codcomprobante);

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

        public static DataTable listar_pagos_notas(int codNota)
        {

            MySqlDataAdapter adap;
            MySqlConnection cn = null;
            DataTable tabla = null;
            MySqlCommand cmd = null;
            try
            {

                tabla = new DataTable();

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("listar_pagos_notas", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@codnotacredito_", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = codNota;
                    adap = new MySqlDataAdapter(cmd);
                    adap.Fill(tabla);
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
