using System;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;
using System.Transactions;
using System.Collections.Generic;

namespace SGEDICALE.modelo
{
    public class MComprobante
    {
        private static MySqlTransaction tra = null;

        public static bool insertar(Comprobantee com)
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

                        cmd = new MySqlCommand("guardacomprobante", cn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("codpedido_", com.CodPedido);
                        cmd.Parameters.AddWithValue("codtransaccion_", com.CodTransaccion);
                        cmd.Parameters.AddWithValue("codtipocomprobante_", com.CodTipoComprobante);
                        cmd.Parameters.AddWithValue("comprobante_", com.Scomprobante);
                        cmd.Parameters.AddWithValue("codserie_", com.Codserie);
                        cmd.Parameters.AddWithValue("serie_", com.Serie);
                        cmd.Parameters.AddWithValue("codcliente_", com.Codpromotor);
                        cmd.Parameters.AddWithValue("codmoneda_", com.Codmoneda);
                        cmd.Parameters.AddWithValue("tipocambio_", com.Tipocambio);
                        cmd.Parameters.AddWithValue("descripcion_", com.Descripcion);
                        cmd.Parameters.AddWithValue("fechaemision_", com.Fechaemision);
                        cmd.Parameters.AddWithValue("descuento_", com.Descuento);
                        cmd.Parameters.AddWithValue("subtotal_", com.Subtotal);
                        cmd.Parameters.AddWithValue("igv_", com.Igv);
                        cmd.Parameters.AddWithValue("total_", com.Total);
                        cmd.Parameters.AddWithValue("totalgravadas_", com.Gravadas);
                        cmd.Parameters.AddWithValue("totalexoneradas_", com.Exoneradas);
                        cmd.Parameters.AddWithValue("totalinafectas_", com.Inafectas);
                        cmd.Parameters.AddWithValue("totalgratuitas_", com.Gratuitas);
                        cmd.Parameters.AddWithValue("abonado_", com.Abonado);
                        cmd.Parameters.AddWithValue("pendiente_", com.Pendiente);
                        cmd.Parameters.AddWithValue("situacionpago_", com.Situacionpago);
                        cmd.Parameters.AddWithValue("formapago_", com.Formapago);
                        cmd.Parameters.AddWithValue("codusuario_", com.Codusuario);
                        cmd.Parameters.AddWithValue("codnotacredito_", com.Comprobanterelacionado.CodComprobante);
                        cmd.Parameters.AddWithValue("documentoreferencia_", com.Comprobanterelacionado.Scomprobante);
                        cmd.Parameters.AddWithValue("coddiscrepancia_", com.Coddiscrepancia);
                        cmd.Parameters.AddWithValue("estadopedido_", com.Estadopedido);

                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        com.CodComprobante = Convert.ToInt32(cmd.Parameters["newid"].Value);

                        if (com.CodComprobante <= 0)
                        {
                            rpta = false;
                            Transaction.Current.Rollback();
                            Scope.Dispose();
                            return rpta;
                        }

                        for (int i = 0; i < com.ListaDetalleComprobante.Count; i++)
                        {
                            DetalleComprobante detCom = com.ListaDetalleComprobante[i];

                            detCom.CodComprobante = com.CodComprobante;

                            cmd = new MySqlCommand("guardadetallecomprobante", cn);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("codcomprobante_", detCom.CodComprobante);
                            cmd.Parameters.AddWithValue("codproducto_", detCom.CodProducto);
                            cmd.Parameters.AddWithValue("unidadingresada_", detCom.Unidadingresada);
                            cmd.Parameters.AddWithValue("cantidad_", detCom.Cantidad);
                            cmd.Parameters.AddWithValue("preciounitario_", detCom.Preciounitario);
                            cmd.Parameters.AddWithValue("subtotal_", detCom.Subtotal);
                            cmd.Parameters.AddWithValue("igv_", detCom.Igv);
                            cmd.Parameters.AddWithValue("total_", detCom.Total);
                            cmd.Parameters.AddWithValue("descuento1_", detCom.Descuento1);
                            cmd.Parameters.AddWithValue("tipoimpuesto_", detCom.Tipoimpuesto);
                            cmd.Parameters.AddWithValue("anulado_", detCom.Anulado);
                            cmd.Parameters.AddWithValue("codusuario_", detCom.Codusuario);
                            cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                            cmd.ExecuteNonQuery();
                            detCom.CodDetalleComprobante = Convert.ToInt32(cmd.Parameters["newid"].Value);

                            if (detCom.CodDetalleComprobante <= 0)
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

        public static bool insertarNuevaventa(Comprobantee com)
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

                        cmd = new MySqlCommand("guardacomprobanteventa", cn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("codpedido_", com.CodPedido);
                        cmd.Parameters.AddWithValue("codtransaccion_", com.CodTransaccion);
                        cmd.Parameters.AddWithValue("codtipocomprobante_", com.CodTipoComprobante);
                        cmd.Parameters.AddWithValue("comprobante_", com.Scomprobante);
                        cmd.Parameters.AddWithValue("codserie_", com.Codserie);
                        cmd.Parameters.AddWithValue("serie_", com.Serie);
                        cmd.Parameters.AddWithValue("codcliente_", com.Codpromotor);
                        cmd.Parameters.AddWithValue("codmoneda_", com.Codmoneda);
                        cmd.Parameters.AddWithValue("tipocambio_", com.Tipocambio);
                        cmd.Parameters.AddWithValue("descripcion_", com.Descripcion);
                        cmd.Parameters.AddWithValue("fechaemision_", com.Fechaemision);
                        cmd.Parameters.AddWithValue("descuento_", com.Descuento);
                        cmd.Parameters.AddWithValue("subtotal_", com.Subtotal);
                        cmd.Parameters.AddWithValue("igv_", com.Igv);
                        cmd.Parameters.AddWithValue("total_", com.Total);
                        cmd.Parameters.AddWithValue("totalgravadas_", com.Gravadas);
                        cmd.Parameters.AddWithValue("totalexoneradas_", com.Exoneradas);
                        cmd.Parameters.AddWithValue("totalinafectas_", com.Inafectas);
                        cmd.Parameters.AddWithValue("totalgratuitas_", com.Gratuitas);
                        cmd.Parameters.AddWithValue("abonado_", com.Abonado);
                        cmd.Parameters.AddWithValue("pendiente_", com.Pendiente);
                        cmd.Parameters.AddWithValue("situacionpago_", com.Situacionpago);
                        cmd.Parameters.AddWithValue("formapago_", com.Formapago);
                        cmd.Parameters.AddWithValue("codusuario_", com.Codusuario);
                        cmd.Parameters.AddWithValue("codnotacredito_", com.Comprobanterelacionado.CodComprobante);
                        cmd.Parameters.AddWithValue("documentoreferencia_", com.Comprobanterelacionado.Scomprobante);
                        cmd.Parameters.AddWithValue("coddiscrepancia_", com.Coddiscrepancia);
                        cmd.Parameters.AddWithValue("estadopedido_", com.Estadopedido);

                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        com.CodComprobante = Convert.ToInt32(cmd.Parameters["newid"].Value);

                        if (com.CodComprobante <= 0)
                        {
                            rpta = false;
                            Transaction.Current.Rollback();
                            Scope.Dispose();
                            return rpta;
                        }

                        for (int i = 0; i < com.ListaDetalleComprobante.Count; i++)
                        {
                            DetalleComprobante detCom = com.ListaDetalleComprobante[i];

                            detCom.CodComprobante = com.CodComprobante;

                            cmd = new MySqlCommand("guardadetallecomprobante", cn);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("codcomprobante_", detCom.CodComprobante);
                            cmd.Parameters.AddWithValue("codproducto_", detCom.CodProducto);
                            cmd.Parameters.AddWithValue("unidadingresada_", detCom.Unidadingresada);
                            cmd.Parameters.AddWithValue("cantidad_", detCom.Cantidad);
                            cmd.Parameters.AddWithValue("preciounitario_", detCom.Preciounitario);
                            cmd.Parameters.AddWithValue("subtotal_", detCom.Subtotal);
                            cmd.Parameters.AddWithValue("igv_", detCom.Igv);
                            cmd.Parameters.AddWithValue("total_", detCom.Total);
                            cmd.Parameters.AddWithValue("descuento1_", detCom.Descuento1);
                            cmd.Parameters.AddWithValue("tipoimpuesto_", detCom.Tipoimpuesto);
                            cmd.Parameters.AddWithValue("anulado_", detCom.Anulado);
                            cmd.Parameters.AddWithValue("codusuario_", detCom.Codusuario);
                            cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                            cmd.ExecuteNonQuery();
                            detCom.CodDetalleComprobante = Convert.ToInt32(cmd.Parameters["newid"].Value);

                            if (detCom.CodDetalleComprobante <= 0)
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


        public static int insertar_nota(Comprobantee com,Usuario usuario)
        {
            
            MySqlCommand cmd = null;
            MySqlConnection cn = null;

            try
            {
                using (var Scope = new TransactionScope())
                {

                    using (cn = new MySqlConnection(Conexion.cadenaConexion))
                    {
                        cn.Open();

                        cmd = new MySqlCommand("guardacomprobantenota", cn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("codpedido_", com.CodPedido);
                        cmd.Parameters.AddWithValue("codtransaccion_", com.CodTransaccion);
                        cmd.Parameters.AddWithValue("codtipocomprobante_", com.CodTipoComprobante);
                        cmd.Parameters.AddWithValue("comprobante_", com.Scomprobante);
                        cmd.Parameters.AddWithValue("codserie_", com.Codserie);
                        cmd.Parameters.AddWithValue("serie_", com.Serie);
                        cmd.Parameters.AddWithValue("codcliente_", com.Codpromotor);
                        cmd.Parameters.AddWithValue("codmoneda_", com.Codmoneda);
                        cmd.Parameters.AddWithValue("tipocambio_", com.Tipocambio);
                        cmd.Parameters.AddWithValue("descripcion_", com.Descripcion);
                        cmd.Parameters.AddWithValue("fechaemision_", com.Fechaemision);
                        cmd.Parameters.AddWithValue("descuento_", com.Descuento);
                        cmd.Parameters.AddWithValue("subtotal_", com.Subtotal);
                        cmd.Parameters.AddWithValue("igv_", com.Igv);
                        cmd.Parameters.AddWithValue("total_", com.Total);
                        cmd.Parameters.AddWithValue("totalgravadas_", com.Gravadas);
                        cmd.Parameters.AddWithValue("totalexoneradas_", com.Exoneradas);
                        cmd.Parameters.AddWithValue("totalinafectas_", com.Inafectas);
                        cmd.Parameters.AddWithValue("totalgratuitas_", com.Gratuitas);
                        cmd.Parameters.AddWithValue("abonado_", com.Abonado);
                        cmd.Parameters.AddWithValue("pendiente_", com.Pendiente);
                        cmd.Parameters.AddWithValue("situacionpago_", com.Situacionpago);
                        cmd.Parameters.AddWithValue("formapago_", com.Formapago);
                        cmd.Parameters.AddWithValue("codusuario_", com.Codusuario);


                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        com.CodComprobante = Convert.ToInt32(cmd.Parameters["newid"].Value);

                        if (com.CodComprobante <= 0)
                        {
                            
                            Transaction.Current.Rollback();
                            Scope.Dispose();
                            return -1;
                        }

                        for (int i = 0; i < com.ListaDetalleComprobante.Count; i++)
                        {
                            DetalleComprobante detCom = com.ListaDetalleComprobante[i];

                            detCom.CodComprobante = com.CodComprobante;

                            cmd = new MySqlCommand("guardadetallecomprobante", cn);
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("codcomprobante_", detCom.CodComprobante);
                            cmd.Parameters.AddWithValue("codproducto_", detCom.CodProducto);
                            cmd.Parameters.AddWithValue("unidadingresada_", detCom.Unidadingresada);
                            cmd.Parameters.AddWithValue("cantidad_", detCom.Cantidad);
                            cmd.Parameters.AddWithValue("preciounitario_", detCom.Preciounitario);
                            cmd.Parameters.AddWithValue("subtotal_", detCom.Subtotal);
                            cmd.Parameters.AddWithValue("igv_", detCom.Igv);
                            cmd.Parameters.AddWithValue("total_", detCom.Total);
                            cmd.Parameters.AddWithValue("descuento1_", detCom.Descuento1);
                            cmd.Parameters.AddWithValue("tipoimpuesto_", detCom.Tipoimpuesto);
                            cmd.Parameters.AddWithValue("anulado_", detCom.Anulado);
                            cmd.Parameters.AddWithValue("codusuario_", detCom.Codusuario);
                            cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                            cmd.ExecuteNonQuery();
                            detCom.CodDetalleComprobante = Convert.ToInt32(cmd.Parameters["newid"].Value);

                            if (detCom.CodDetalleComprobante <= 0)
                            {
                               
                                Transaction.Current.Rollback();
                                Scope.Dispose();
                                return -1;
                            }
                        }

                        Scope.Complete();
                        Scope.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                
                return -1;
                throw ex;
            }


            return com.CodComprobante;
        }


        public static DataTable listar_notas_xestado_xfecha(DateTime fechaincio, DateTime fechafin, int estado)
        {

            MySqlCommand cmd = null;
            MySqlConnection cn = null;
            MySqlDataAdapter adap = null;
     
            DataTable tabla = new DataTable();

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("listar_notas_xestado_xfecha", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@_fechainicio", MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("@_fechafin", MySqlDbType.Date));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = fechaincio;
                    cmd.Parameters[1].Value = fechafin;
                    cmd.Parameters[2].Value = estado;
                    adap = new MySqlDataAdapter(cmd);
                    adap.Fill(tabla);

                }

                return tabla;
            }
            catch (MySqlException ex)
            {
               
                throw ex;
            }  
        }

 


        public static  int anular_comprobante(Comprobantee comprobante, Usuario usureg)
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
                    cmd = new MySqlCommand("anular_comprobante", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = tra;
                    cmd.Parameters.Add(new MySqlParameter("@_idcomprobante", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = comprobante.CodComprobante;
                    cmd.Parameters[1].Value = Session.CodUsuario;

                    cmd.CommandTimeout = 500;

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


        public static Comprobantee buscarComprobanteCredito(Comprobantee comprobantee)
        {

            Comprobantee comprobante = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("buscarcomprobante_notacredito", cn);
                    cmd.Parameters.AddWithValue("correlativo_", comprobantee.Scomprobante);
                    //cmd.Parameters.AddWithValue("codalma", codAlmacen);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            comprobante = new Comprobantee();
                            comprobante.CodComprobante = dr.GetInt32(0);
                            

                            //factura
                        }
                    }
                }
                return comprobante;

            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;

            }
        }

        public static Comprobantee buscarNotaCredito(string correlativo)
        {

            Comprobantee comprobante = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("buscar_notacredito", cn);
                    cmd.Parameters.AddWithValue("correlativo_", correlativo);
                    //cmd.Parameters.AddWithValue("codtipocomprobante_", codtipo);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            comprobante = new Comprobantee();
                            comprobante.CodComprobante = dr.GetInt32(0);


                            //factura
                        }
                    }
                }
                return comprobante;

            }
            catch (MySqlException ex)
            {
                throw ex;

            }

        }

        public static Comprobantee buscacomprobantexcodPedido(int codpedido)
        {

            Comprobantee comprobante = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("buscacomprobantexcodigopedido", cn);
                    cmd.Parameters.AddWithValue("codpedido_", codpedido);
                    //cmd.Parameters.AddWithValue("codalma", codAlmacen);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            comprobante = new Comprobantee();
                            comprobante.CodComprobante = dr.GetInt32(0);
                            comprobante.CodTransaccion = dr.GetInt32(1);
                            comprobante.SiglaTransaccion1 = dr.GetString(2);
                            comprobante.DescripcionTransaccion1 = dr.GetString(3);
                            comprobante.CodTipoComprobante = dr.GetInt32(4);
                            comprobante.Siglacomprobante = dr.GetString(5);

                            comprobante.Codserie = dr.GetInt32(6);
                            comprobante.Serie = dr.GetString(7);
                            comprobante.Codpromotor = dr.GetInt32(8);
                            comprobante.Numdoc = dr.GetString(9);

                            comprobante.Razonsocialcliente = dr.GetString(10);
                            comprobante.Nombre = dr.GetString(11);

                            comprobante.Direccion = dr.GetString(12);
                            comprobante.Codmoneda = dr.GetInt32(13);
                            comprobante.Tipocambio = dr.GetDecimal(14);

                            comprobante.Fechaemision = dr.GetDateTime(15);
                            comprobante.Descripcion = dr.GetString(16);
                            comprobante.Descuento = dr.GetDecimal(17);
                            comprobante.Subtotal = dr.GetDecimal(18);
                            comprobante.Igv = dr.GetDecimal(19);
                            comprobante.Total = dr.GetDecimal(20);
                            comprobante.Formapago = dr.GetInt32(21);
                            if (!dr.IsDBNull(22))
                            {
                                comprobante.Fechapago = dr.GetDateTime(22);
                            }

                            comprobante.Abonado = dr.GetInt32(23);
                            comprobante.Pendiente = dr.GetInt32(24);

                            comprobante.CodNotaCredito = dr.GetInt32(25);
                            comprobante.Documentoreferencia = dr.GetString(26);

                            comprobante.Gravadas = dr.GetDecimal(27);
                            comprobante.Exoneradas = dr.GetDecimal(28);
                            comprobante.Inafectas = dr.GetDecimal(29);
                            comprobante.Gratuitas = dr.GetDecimal(30);

                            comprobante.Codusuario = dr.GetInt32(31);
                            comprobante.Fecharegistro = dr.GetDateTime(32);
                            comprobante.Estado = dr.GetInt32(33);

                            comprobante.Scomprobante = dr.GetString(34);

                            //factura
                        }
                    }
                }
                return comprobante;

            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;

            }
        }


        public static Comprobantee buscacomprobante(int codcomprobante)
        {

            Comprobantee comprobante = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("buscacomprobantexcodigo", cn);
                    cmd.Parameters.AddWithValue("codcomprobante_", codcomprobante);
                    //cmd.Parameters.AddWithValue("codalma", codAlmacen);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            comprobante = new Comprobantee();
                            comprobante.CodComprobante = dr.GetInt32(0);
                            comprobante.CodTransaccion = dr.GetInt32(1);
                            comprobante.SiglaTransaccion1 = dr.GetString(2);
                            comprobante.DescripcionTransaccion1 = dr.GetString(3);
                            comprobante.CodTipoComprobante = dr.GetInt32(4);
                            comprobante.Siglacomprobante= dr.GetString(5);

                            comprobante.Codserie = dr.GetInt32(6);
                            comprobante.Serie = dr.GetString(7);
                            comprobante.Codpromotor = dr.GetInt32(8);
                            comprobante.Numdoc = dr.GetString(9);

                            comprobante.Razonsocialcliente = dr.GetString(10);
                            comprobante.Nombre = dr.GetString(11);

                            comprobante.Direccion = dr.GetString(12);
                            comprobante.Codmoneda = dr.GetInt32(13);
                            comprobante.Tipocambio = dr.GetDecimal(14);

                            comprobante.Fechaemision = dr.GetDateTime(15);
                            comprobante.Descripcion = dr.GetString(16);
                            comprobante.Descuento= dr.GetDecimal(17);
                            comprobante.Subtotal = dr.GetDecimal(18);
                            comprobante.Igv = dr.GetDecimal(19);
                            comprobante.Total = dr.GetDecimal(20);
                            comprobante.Formapago = dr.GetInt32(21);

                            if (!dr.IsDBNull(22))
                            {
                                comprobante.Fechapago = dr.GetDateTime(22);
                            }

                            comprobante.Abonado = dr.GetInt32(23);
                            comprobante.Pendiente = dr.GetInt32(24);

                            comprobante.CodNotaCredito = dr.GetInt32(25);
                            comprobante.Documentoreferencia = dr.GetString(26);

                            comprobante.Gravadas = dr.GetDecimal(27);
                            comprobante.Exoneradas = dr.GetDecimal(28);
                            comprobante.Inafectas = dr.GetDecimal(29);
                            comprobante.Gratuitas = dr.GetDecimal(30);

                            comprobante.Codusuario = dr.GetInt32(31);
                            comprobante.Fecharegistro = dr.GetDateTime(32);
                            comprobante.Estado =dr.GetInt32(33);

                            comprobante.Scomprobante = dr.GetString(34);
                            comprobante.CodPedido = dr.GetInt32(35);
                            //comprobante.Correlativo = dr.GetString(36);


                            //factura
                        }
                    }
                }
                return comprobante;

            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;

            }
        }

        public static bool anular(int codigoventa)
        {
         
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("AnularFacturaVenta", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codventa", codigoventa);

                    int x = cmd.ExecuteNonQuery();
                    if (x != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;

            }
        }

        public static bool ActualizaBoletaSunat(int codigoventa)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;


            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("ActualizaBoletaSunat", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codventa", codigoventa);
                    int x = cmd.ExecuteNonQuery();
                    if (x != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;

            }
        }

        public static bool ActualizaPago(PagoComprobante pc)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;


            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("actualizapagocomprobante", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codcomprobante_", pc.Codcomprobante);
                    cmd.Parameters.AddWithValue("montopagado_", pc.Montopagado);
                    int x = cmd.ExecuteNonQuery();
                    if (x != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
                

            }
        }

        public static DateTime listar_fecha_actual()
        {

            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;

            DateTime fecha = DateTime.Now;
            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    cmd = new MySqlCommand("listar_fecha_actual", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            fecha = (DateTime)dr["_fecha_actual"];
                        }
                    }
                }
                return fecha;
            }
            catch (MySqlException ex)
            {
                return fecha;
                throw ex;
            }
        }



        public static DataTable listar_ventas_xestado_xfecha(DateTime fechai, DateTime fechaf)
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listar_ventas_xestado_xfecha", cn);

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


        public static DataTable listar_ventas_xestado_xfecha_xpromotor(DateTime fechai, DateTime fechaf,string promotor)
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listar_ventas_xestado_xfecha_xpromotor", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("fechainicio_", fechai);
                    cmd.Parameters.AddWithValue("fechafin_", fechaf);
                    cmd.Parameters.AddWithValue("promotor_", promotor);

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


        public static DataTable listar_detalle_comprobante_xidcomprobante(Comprobantee comprobante)
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

                    MySqlCommand cmd = new MySqlCommand("listar_detalle_comprobante_xidcomprobante", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@_idcomprobante", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = comprobante.CodComprobante;
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

        public static List<DetalleComprobante> traer_detalle_comprobante_xidcomprobante(Comprobantee comprobantee)
        {

            DetalleComprobante detalleComprobante;
            Comprobantee comprobante = new Comprobantee();
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;


            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("listar_detalle_comprobante_xidcomprobante", cn);
                    cmd.Parameters.Add(new MySqlParameter("@_idcomprobante", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = comprobantee.CodComprobante;
                    //cmd.Parameters.AddWithValue("codalma", codAlmacen);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            detalleComprobante = new DetalleComprobante();

                            detalleComprobante.Unidadingresada = dr.GetInt32(19);
                            detalleComprobante.CodProducto = dr.GetInt32(4);
                            detalleComprobante.Descripcion = dr.GetString(5).Trim();

                            detalleComprobante.Cantidad = dr.GetInt32(8);
                            detalleComprobante.Preciounitario = dr.GetInt32(9);



                            detalleComprobante.Subtotal = dr.GetDecimal(11);
                            detalleComprobante.Igv = dr.GetDecimal(12);

                            detalleComprobante.Descuento1 = 0;
                            detalleComprobante.Tipoimpuesto = dr.GetInt32(20);




                            detalleComprobante.Anulado = 0;
                            detalleComprobante.Codusuario = Session.CodUsuario;

                            comprobante.ListaDetalleComprobante.Add(detalleComprobante);
                        }
                    }
                }
                return comprobante.ListaDetalleComprobante;

            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;

            }

      

        }




        public static  DataTable MuestraCobros(int filtro , DateTime fecha1, DateTime fecha2, int codpromotor)
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

                    MySqlCommand cmd = new MySqlCommand("MuestraCobros", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("filtro_", filtro);
                    cmd.Parameters.AddWithValue("fecha1_", fecha1);
                    cmd.Parameters.AddWithValue("fecha2_", fecha2);
                    cmd.Parameters.AddWithValue("codpromotor_", codpromotor);
                    
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

        public static DataTable MuestraDepositos(int filtro, DateTime fecha1, DateTime fecha2, int codpromotor)
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

                    MySqlCommand cmd = new MySqlCommand("MuestraDepositos", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("filtro_", filtro);
                    cmd.Parameters.AddWithValue("fecha1_", fecha1);
                    cmd.Parameters.AddWithValue("fecha2_", fecha2);
                    cmd.Parameters.AddWithValue("codpromotor_", codpromotor);

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

        public static DataTable listar_comprobantes_xestado_xcliente(Promotor cliente)
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

                    cmd = new MySqlCommand("listar_comprobantes_xestado_xcliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@_idcliente", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = cliente.CodPromotor;
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


        public static DataTable listar_notas_xestado_xcliente(Promotor cliente)
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

                    cmd = new MySqlCommand("listar_notas_xestado_xcliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@_idcliente", MySqlDbType.Int32));
                    cmd.Parameters[0].Value = cliente.CodPromotor;
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
