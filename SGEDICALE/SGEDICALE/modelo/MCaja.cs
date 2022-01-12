using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;
using SGEDICALE.SunatFacElec;

namespace SGEDICALE.modelo
{
    public class MCaja
    {

        private static Herramientas her = new Herramientas();
        private  static string ruta = "";
        private static MySqlTransaction tra = null;

        public static int buscar_caja_abierta(int usuario)
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


                    cmd = new MySqlCommand("buscar_caja_abierta", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
     
                    cmd.Parameters.Add(new MySqlParameter("@_usuarioid", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = usuario;


                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {

                        while (dr.Read())
                        {
                            id = Convert.ToInt32(dr["_cajaid"]);
                        }
                        dr.Close();
                    }
                    dr.Close();
                }

                return id;

            }
            catch (Exception ex)
            {
                return id;
                throw ex;
            }
        }


        public static int anular_caja(Caja caja, Usuario usureg)
        {
            int filas_afectadas = -1;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    tra = cn.BeginTransaction();
                    cmd = new MySqlCommand("anular_caja", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = tra;
                    cmd.Parameters.Add(new MySqlParameter("@_cajaid", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = caja.Codcaja;
                    cmd.Parameters[1].Value = usureg.Usuarioid;

                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            filas_afectadas = Convert.ToInt32(dr["_filas_afectadas"]);
                        }
                        dr.Close();
                    }
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
            finally { cn.Dispose(); cmd.Dispose(); }
        }


        public static DataTable listar_caja_apertura()
        {

            DataTable tabla = new DataTable();
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            MySqlDataAdapter adap = null;

            using (cn = new MySqlConnection(Conexion.cadenaConexion))
            {
                cn.Open();

                cmd = new MySqlCommand("listar_caja_aperturada", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                adap = new MySqlDataAdapter(cmd);
                adap.Fill(tabla);
            }

            return tabla;
        }



        public static  DataTable listar_caja_cerrada(DateTime fechaini, DateTime fechafin)
        {
            DataTable tabla = new DataTable();

            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            
            MySqlDataAdapter adap = null;

            using (cn = new MySqlConnection(Conexion.cadenaConexion))
            {
                cn.Open();

                cmd = new MySqlCommand("listar_caja_cerrada", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("@_fechaini", MySqlDbType.Date));
                cmd.Parameters.Add(new MySqlParameter("@_fechafin", MySqlDbType.Date));

                cmd.Parameters[0].Value = fechaini;
                cmd.Parameters[1].Value = fechafin;

                adap = new MySqlDataAdapter(cmd);
                adap.Fill(tabla);
            }
        

            return tabla;
        }

        public static int registrar_caja(Caja caja)
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


                    cmd = new MySqlCommand("registrar_caja", cn);
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add(new MySqlParameter("@_montoapertura", MySqlDbType.Decimal));
                    cmd.Parameters.Add(new MySqlParameter("@_usuarioid", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = caja.Montoapertura;
                    cmd.Parameters[1].Value = caja.Usuario.Usuarioid;
                    cmd.Parameters[2].Value = caja.Estado;

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

        public static DataTable listar_caja_movimiento(Caja caja)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            MySqlDataAdapter adap = null;
            try
            {

                 DataTable tabla = new DataTable();

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("listar_movimiento_caja", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@_cajaid", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = caja.Codcaja;
                    cmd.Parameters[1].Value = caja.Estado;
                    adap = new MySqlDataAdapter(cmd);
                    adap.Fill(tabla);
                }

                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Caja total_caja(Caja caja)
        {
            Caja _caja = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;


            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("totales_caja", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@_cajaid", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = caja.Codcaja;
                    cmd.Parameters[1].Value = caja.Estado;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {

                        while (dr.Read())
                        {
                            _caja = new Caja()
                            {

                                Codcaja = (int)dr["codcaja"],
                                Montoapertura = (decimal)dr["montoapertura"],
                                Montocierre = (decimal)dr["montocierre"],
                                Totalefectivo = (decimal)dr["totalefectivo"],
                                Totaldeposito = (decimal)dr["totaldeposito"],
                                Totaltransferencia = (decimal)dr["totaltransferencia"],
                                Totaltarjeta = (decimal)dr["totaltarjeta"],
                                Totalnota = (decimal)dr["totalnotacredito"],
                                Totaldisponible = (decimal)dr["totaldisponible"]

                            };
                        }
                    }
                }
                return _caja;
            }
            catch (MySqlException ex)
            {
                return _caja;
                throw ex;
            }
   
        }


        public static int cerrar_caja(Caja caja, Usuario usureg)
        {
            int filas_afectadas = -1;

            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;
            MySqlTransaction tra = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    tra = cn.BeginTransaction();
                    cmd = new MySqlCommand("cerrar_caja", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = tra;
                    cmd.Parameters.Add(new MySqlParameter("@_cajaid", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = caja.Codcaja;
                    cmd.Parameters[1].Value = usureg.Usuarioid;

                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            filas_afectadas = Convert.ToInt32(dr["_filas_afectadas"]);
                        }
                        dr.Close();
                    }
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
    
        }


        public static DataSet reporte_caja_movimiento(Caja caja)
        {

            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            DataSet data = null;
            MySqlDataAdapter adap = null;


            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    data = new DataSet();
                    cmd = new MySqlCommand("reporte_movimiento_caja", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@_cajaid", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = caja.Codcaja;

                    adap = new MySqlDataAdapter(cmd);
                    adap.Fill(data, "cierre_caja");

                    ruta = her.GetResourcesPath4() + "\\cajacierre.xml";
                    data.WriteXml(ruta, XmlWriteMode.WriteSchema);
                }

                return data;
            }
            catch (MySqlException ex)
            {
                return data;
                throw ex;
            }
        }


        public static DataTable listar_movimiento_caja_xcomprobante(Caja caja, Comprobantee comprobante)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            MySqlDataAdapter adap = null;

            try
            {

                DataTable tabla = new DataTable();

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("listar_movimiento_caja_xcomprobante", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@_cajaid", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_comprobante", MySqlDbType.VarChar));
                    cmd.Parameters[0].Value = caja.Codcaja;
                    cmd.Parameters[1].Value = caja.Estado;
                    cmd.Parameters[2].Value = comprobante.Scomprobante;
                    adap = new MySqlDataAdapter(cmd);
                    adap.Fill(tabla);
                }

                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
