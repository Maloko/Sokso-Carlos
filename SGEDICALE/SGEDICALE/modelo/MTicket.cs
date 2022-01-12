using System;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;
using System.Transactions;

namespace SGEDICALE.modelo
{
    public class MTicket
    {

        private static MySqlTransaction tra = null;

        public static bool insertar(Ticket t)
        {
            bool rpta = true;
            MySqlCommand cmd = null;
            MySqlConnection cn = null;

            try
            {
                using (var Scope = new TransactionScope())
                {

                    using (cn = new MySqlConnection(Conexion.cadenaConexion))
                    {
                        cn.Open();

                        cmd = new MySqlCommand("guardaticket", cn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("codcliente_", t.CodCliente);
                        cmd.Parameters.AddWithValue("codtipocomprobante_", t.Codtipocomprobante);
                        cmd.Parameters.AddWithValue("subtotal_", t.Subtotal);
                        cmd.Parameters.AddWithValue("igv_", t.Igv);
                        cmd.Parameters.AddWithValue("total_", t.Total);
                        cmd.Parameters.AddWithValue("fecha_", t.Fecha);
                        cmd.Parameters.AddWithValue("codempresa_", t.Codempresa);
                        cmd.Parameters.AddWithValue("codusuario_", t.Codusuario);
                      
                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        t.CodTicket = Convert.ToInt32(cmd.Parameters["newid"].Value);

                        if (t.CodTicket <= 0)
                        {
                            rpta = false;
                            Transaction.Current.Rollback();
                            Scope.Dispose();
                            return rpta;
                        }

                        for (int i = 0; i < t.ListaDetalleTicket.Count; i++)
                        {
                            DetalleTicket detCom = t.ListaDetalleTicket[i];

                            detCom.CodTicket = t.CodTicket;

                            cmd = new MySqlCommand("guardadetalleticket", cn);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("codticket_", detCom.CodTicket);
                            cmd.Parameters.AddWithValue("codproducto_", detCom.CodProducto);
                            cmd.Parameters.AddWithValue("codunidadmedida_", detCom.CodUnidad);
                            cmd.Parameters.AddWithValue("cantidad_", detCom.Cantidad);
                            cmd.Parameters.AddWithValue("precio_", detCom.Precio);
                            cmd.Parameters.AddWithValue("total_", detCom.Total);
                            cmd.Parameters.AddWithValue("codusuario_", detCom.Codusuario);
                            cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                            cmd.ExecuteNonQuery();
                            detCom.CodDetalleTicket = Convert.ToInt32(cmd.Parameters["newid"].Value);

                            if (detCom.CodDetalleTicket <= 0)
                            {
                                rpta = false;
                                Transaction.Current.Rollback();
                                Scope.Dispose();
                                return rpta;
                            }
                        }

                        Scope.Complete();
                        Scope.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                rpta = false;
                return rpta;
                throw ex;
            }


            return rpta;
        }



        public static int anular_ticket(Ticket ticket, Usuario usureg)
        {

            MySqlCommand cmd = null;
            MySqlConnection cn = null;
            MySqlDataReader dr = null;
            int filas_afectadas = -1;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    tra = cn.BeginTransaction();
                    cmd = new MySqlCommand("anular_ticket", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = tra;
                    cmd.Parameters.Add(new MySqlParameter("@_idticket", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_codusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = ticket.CodTicket;
                    cmd.Parameters[1].Value = Session.CodUsuario;

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


        public static Ticket buscaticket(int codticket)
        {

            Ticket ticket = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("buscaticketxcodigo", cn);
                    cmd.Parameters.AddWithValue("codticket_", codticket);
                    //cmd.Parameters.AddWithValue("codalma", codAlmacen);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            ticket = new Ticket();
                            ticket.CodTicket = dr.GetInt32(0);
                            ticket.Codtipocomprobante = dr.GetInt32(1);
                            ticket.Codserie = dr.GetInt32(2);
                            ticket.Correlativo = dr.GetString(3);
                            
                            ticket.CodCliente = dr.GetInt32(4);
                            ticket.Documento = dr.GetString(5);

                            ticket.Nombres= dr.GetString(6);
                            ticket.Direccion = dr.GetString(7);

                            
                            //ticket.Codmoneda = dr.GetInt32(13);
                          

                            ticket.Fecha = dr.GetDateTime(8);
                            ticket.Subtotal = dr.GetDecimal(9);
                            ticket.Igv = dr.GetDecimal(10);
                            ticket.Total = dr.GetDecimal(11);
           
                            ticket.Codusuario = dr.GetInt32(12);
                            ticket.Fecharegistro = dr.GetDateTime(13);
                            ticket.Estado = dr.GetInt32(14);

                        }
                    }
                }
                return ticket;

            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;

            }
        }



        public static DataTable listar_ticket_xestado_xfecha_xcliente(DateTime fechai, DateTime fechaf, string promotor)
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listar_ticket_xestado_xfecha_xcliente", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("fechainicio_", fechai);
                    cmd.Parameters.AddWithValue("fechafin_", fechaf);
                    cmd.Parameters.AddWithValue("cliente_", promotor);

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


        public static DataTable listar_ticket_xestado_xfecha(DateTime fechai, DateTime fechaf)
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listar_ticket_xestado_xfecha", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("fechainicio_", fechai);
                    cmd.Parameters.AddWithValue("fechafin_", fechaf);

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

        public static DataTable listar_detalle_ticket_xidticket(Ticket ticket)
        {

            MySqlDataAdapter adap;
            MySqlConnection cn = null;
            DataTable tabla = null; ;

            try
            {

                tabla = new DataTable();

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    MySqlCommand cmd = new MySqlCommand("listar_detalle_ticket_xidticket", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@_idticket", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = ticket.CodTicket;
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
