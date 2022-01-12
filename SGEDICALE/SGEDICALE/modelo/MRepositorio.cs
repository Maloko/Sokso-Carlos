using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MRepositorio
    {
        public static bool registra_repositorio(Repositorio repo)
        {
            MySqlConnection cn = null;
            MySqlTransaction mysqltransaccion = null;
            string consulta = "";
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    mysqltransaccion = cn.BeginTransaction();
                    consulta = "registrar_repositorio";
                    cmd = new MySqlCommand(consulta, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlParameter oParam;
                    oParam = cmd.Parameters.AddWithValue("_tipdoc", repo.Tipodoc);
                    oParam = cmd.Parameters.AddWithValue("_fechaemision", repo.Fechaemision.ToString("yyyy/MM/dd"));
                    oParam = cmd.Parameters.AddWithValue("_serie", repo.Serie);
                    oParam = cmd.Parameters.AddWithValue("_correlativo", repo.Correlativo);
                    oParam = cmd.Parameters.AddWithValue("_monto", repo.Monto);
                    oParam = cmd.Parameters.AddWithValue("_estadosunat", repo.Estadosunat);
                    oParam = cmd.Parameters.AddWithValue("_mensajesunat", repo.Mensajesunat);
                    oParam = cmd.Parameters.AddWithValue("_docpdf", repo.Pdf);
                    oParam = cmd.Parameters.AddWithValue("_docxml", repo.Xml);
                    oParam = cmd.Parameters.AddWithValue("_nombredoc", repo.Nombredoc);
                    oParam = cmd.Parameters.AddWithValue("_usuario", repo.Usuario);
                    oParam = cmd.Parameters.AddWithValue("_codEmpresa", repo.CodEmpresa);
                    oParam = cmd.Parameters.AddWithValue("_codSucursal", repo.CodSucursal);
                    oParam = cmd.Parameters.AddWithValue("_codAlmacen", repo.CodAlmacen);
                    oParam = cmd.Parameters.AddWithValue("_codFacturaVenta", repo.CodFacturaVenta);

                    oParam = cmd.Parameters.AddWithValue("_resultado", 0);
                    oParam.Direction = ParameterDirection.Output;
                    int x = cmd.ExecuteNonQuery();
                    x = Convert.ToInt32(cmd.Parameters["_resultado"].Value);
                    mysqltransaccion.Commit();

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
                if (mysqltransaccion != null)
                {
                    mysqltransaccion.Rollback();
                }
                throw ex;
            }
        }


        public static bool registra_repositorioRespaldo(Repositorio repo)
        {
            MySqlConnection cn = null;
            MySqlTransaction mysqltransaccion = null;
            string consulta = "";
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    mysqltransaccion = cn.BeginTransaction();
                    consulta = "registrar_repositorio_respaldo";
                    cmd = new MySqlCommand(consulta, cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    MySqlParameter oParam;
                    oParam = cmd.Parameters.AddWithValue("_tipdoc", repo.Tipodoc);
                    oParam = cmd.Parameters.AddWithValue("_fechaemision", repo.Fechaemision.ToString("yyyy/MM/dd"));
                    oParam = cmd.Parameters.AddWithValue("_serie", repo.Serie);
                    oParam = cmd.Parameters.AddWithValue("_correlativo", repo.Correlativo);
                    oParam = cmd.Parameters.AddWithValue("_monto", repo.Monto);
                    oParam = cmd.Parameters.AddWithValue("_estadosunat", repo.Estadosunat);
                    oParam = cmd.Parameters.AddWithValue("_mensajesunat", repo.Mensajesunat);
                    oParam = cmd.Parameters.AddWithValue("_nombredoc", repo.Nombredoc);
                    oParam = cmd.Parameters.AddWithValue("_usuario", repo.Usuario);
                    oParam = cmd.Parameters.AddWithValue("_codEmpresa", repo.CodEmpresa);
                    oParam = cmd.Parameters.AddWithValue("_codSucursal", repo.CodSucursal);
                    oParam = cmd.Parameters.AddWithValue("_codAlmacen", repo.CodAlmacen);
                    oParam = cmd.Parameters.AddWithValue("_codFacturaVenta", repo.CodFacturaVenta);

                    oParam = cmd.Parameters.AddWithValue("_resultado", 0);
                    oParam.Direction = ParameterDirection.Output;
                    int x = cmd.ExecuteNonQuery();
                    x = Convert.ToInt32(cmd.Parameters["_resultado"].Value);
                    mysqltransaccion.Commit();

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
                if (mysqltransaccion != null)
                {
                    mysqltransaccion.Rollback();
                }
                throw ex;
            }
        }


        public static Repositorio buscarComprobante(Comprobantee comprobantee)
        {

            Repositorio repo = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("buscarepositorio_comprobante", cn);
                    cmd.Parameters.AddWithValue("_tipdoc", comprobantee.CodTipoComprobante);
                    cmd.Parameters.AddWithValue("_serie", comprobantee.Serie);
                    cmd.Parameters.AddWithValue("_correlativo", comprobantee.Scomprobante);

                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            repo = new Repositorio();

                            repo.Repoid = dr.GetInt32(0);
                            repo.Tipodoc = dr.GetInt32(1);
                            repo.Fechaemision = dr.GetDateTime(2);
                            repo.Serie = dr.GetString(3);
                            repo.Correlativo = dr.GetString(4);
                            repo.Monto = dr.GetDecimal(5);
                            repo.Estadosunat = dr.GetString(6);
                            repo.Mensajesunat = dr.GetString(7);
                            repo.Pdf = (byte[])dr["docpdf"];
                            repo.Xml = (byte[])dr["docxml"];
                            repo.Nombredoc = dr.GetString(10);
                            repo.Usuario = dr.GetInt32(11);
                            repo.Fechaemision = dr.GetDateTime(12);

                        }
                    }
                }
                return repo;

            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;
            }
        }

        public static Repositorio buscarComprobante2(Comprobantee comprobantee)
        {

            Repositorio repo = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            string core = "";

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();



                    cmd = new MySqlCommand("buscarepositorio_comprobante", cn);
                    cmd.Parameters.AddWithValue("_tipdoc", comprobantee.CodTipoComprobante);
                    cmd.Parameters.AddWithValue("_serie", comprobantee.Serie);
                    cmd.Parameters.AddWithValue("_correlativo", comprobantee.Scomprobante.Substring(5, 8));

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 25000;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            repo = new Repositorio();

                            repo.Repoid = dr.GetInt32(0);
                            repo.Tipodoc = dr.GetInt32(1);
                            repo.Fechaemision = dr.GetDateTime(2);
                            repo.Serie = dr.GetString(3);
                            repo.Correlativo = dr.GetString(4);
                            repo.Monto = dr.GetDecimal(5);
                            repo.Estadosunat = dr.GetString(6);
                            repo.Mensajesunat = dr.GetString(7);
                            repo.Pdf = (byte[])dr["docpdf"];
                            repo.Xml = (byte[])dr["docxml"];
                            repo.Nombredoc = dr.GetString(10);
                            repo.Usuario = dr.GetInt32(11);
                            repo.Fechaemision = dr.GetDateTime(12);

                        }
                    }
                }
                return repo;

            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;
            }
        }

        public static Repositorio buscarComprobanteNotaCredito(Comprobantee comprobantee)
        {

            Repositorio repo = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            string core = "";

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();



                    cmd = new MySqlCommand("buscarepositorio_comprobanteNota", cn);
                    cmd.Parameters.AddWithValue("_tipdoc", comprobantee.CodTipoComprobante);
                    cmd.Parameters.AddWithValue("_serie", comprobantee.Serie);
                    cmd.Parameters.AddWithValue("_correlativo", comprobantee.Scomprobante.Substring(5, 8));

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 25000;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            repo = new Repositorio();

                            repo.Repoid = dr.GetInt32(0);
                            repo.Tipodoc = dr.GetInt32(1);
                            repo.Fechaemision = dr.GetDateTime(2);
                            repo.Serie = dr.GetString(3);
                            repo.Correlativo = dr.GetString(4);
                            repo.Monto = dr.GetDecimal(5);
                            repo.Estadosunat = dr.GetString(6);
                            repo.Mensajesunat = dr.GetString(7);
                            repo.Nombredoc = dr.GetString(8);
                            repo.Usuario = dr.GetInt32(9);
                            repo.Fechaemision = dr.GetDateTime(10);

                        }
                    }
                }
                return repo;

            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;
            }
        }





        public static List<Repositorio> listar_repositorio_filtrado(String estado, Int32 codsucu, Int32 codalma, DateTime fecha1, DateTime fecha2)
        {

            MySqlConnection cn = null;
            string consulta = "";
            MySqlDataReader dr = null;
            List<Repositorio> lista = null;
            Repositorio clsrepo = null;
            MySqlCommand cmd = null;

            try
            {
                lista = null;

                if (cn == null)
                {
                    cn = new MySqlConnection(Conexion.cadenaConexion);
                    cn.Open();
                }

                consulta = "listar_repositorio_filtrado";
                cmd = new MySqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 25000;
                MySqlParameter oParam;
                oParam = cmd.Parameters.AddWithValue("_estadosunat", estado);
                oParam = cmd.Parameters.AddWithValue("_codSucursal", codsucu);
                oParam = cmd.Parameters.AddWithValue("_codAlmacen", codalma);
                oParam = cmd.Parameters.AddWithValue("_fecha1", fecha1);
                oParam = cmd.Parameters.AddWithValue("_fecha2", fecha2);
                //oParam = cmd.Parameters.AddWithValue("codFacturaVenta_ex", codfac);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    lista = new List<Repositorio>();

                    while (dr.Read())
                    {
                        clsrepo = new Repositorio();
                        clsrepo.Repoid = (int)dr["repositorioid"];
                        clsrepo.Tipodoc = (int)dr["tipdoc"];
                        clsrepo.Fechaemision = DateTime.Parse(dr["fechaemision"].ToString());
                        clsrepo.Serie = (string)dr["serie"];
                        clsrepo.Correlativo = (string)dr["correlativo"];
                        clsrepo.Monto = (decimal)dr["monto"];
                        clsrepo.Estadosunat = (string)dr["estadosunat"];
                        clsrepo.Mensajesunat = (string)dr["mensajesunat"];
                        //clsrepo.Pdf = (byte[])dr["docpdf"];
                        clsrepo.Xml = (byte[])dr["docxml"];
                        clsrepo.Nombredoc = (string)dr["nombredoc"];
                        clsrepo.Usuario = (int)dr["usuario"];
                        clsrepo.CodFacturaVenta = (int)dr["codFacturaVenta"];


                        lista.Add(clsrepo);
                    }

                }
                return lista;
            }
            catch (MySqlException ex)
            {
                return lista;
            }
            finally { cn.Dispose(); cmd.Dispose(); cn.Close(); }
        }

        public static List<Repositorio> buscar_repositorio(Repositorio repo)
        {

            MySqlConnection cn = null;
            string consulta = "";
            MySqlDataReader dr = null;
            List<Repositorio> lista = null;
            Repositorio clsrepo = null;
            MySqlCommand cmd = null;

            try
            {
                if (cn == null)
                {
                    cn = new MySqlConnection(Conexion.cadenaConexion);
                    cn.Open();
                }

                consulta = "buscar_repositorio";
                cmd = new MySqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter oParam;
                oParam = cmd.Parameters.AddWithValue("_tipdoc", repo.Tipodoc);
                oParam = cmd.Parameters.AddWithValue("_serie", repo.Serie);
                oParam = cmd.Parameters.AddWithValue("_correlativo", repo.Correlativo);
                oParam = cmd.Parameters.AddWithValue("_fechaemision", repo.Fechaemision.ToString("yyyy/MM/dd"));
                oParam = cmd.Parameters.AddWithValue("_monto", repo.Monto);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    lista = new List<Repositorio>();

                    while (dr.Read())
                    {
                        clsrepo = new Repositorio();
                        clsrepo.Repoid = (int)dr["repositorioid"];
                        clsrepo.Tipodoc = (int)dr["tipdoc"];
                        clsrepo.Fechaemision = DateTime.Parse(dr["fechaemision"].ToString()).Date;
                        clsrepo.Serie = (string)dr["serie"];
                        clsrepo.Correlativo = (string)dr["correlativo"];
                        clsrepo.Monto = (decimal)dr["monto"];
                        clsrepo.Estadosunat = (string)dr["estadosunat"];
                        clsrepo.Mensajesunat = (string)dr["mensajesunat"];
                        clsrepo.Pdf = (byte[])dr["docpdf"];
                        clsrepo.Xml = (byte[])dr["docxml"];
                        clsrepo.Nombredoc = (string)dr["nombredoc"];
                        clsrepo.Usuario = (int)dr["usuario"];
                        clsrepo.Fechaemision = DateTime.Parse(dr["fecharegistro"].ToString());
                        lista.Add(clsrepo);
                    }

                }

                return lista;


            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally { cn.Dispose(); cmd.Dispose(); cn.Close(); }
        }

        public static Repositorio buscarComprobantexidRepo(int id)
        {

            Repositorio repo = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("buscarepositorioxid", cn);
                    cmd.Parameters.AddWithValue("_id", id);


                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {

                            repo = new Repositorio();

                            repo.Repoid = dr.GetInt32(0);
                            repo.CodFacturaVenta = dr.GetInt32(1);
                            repo.Serie = dr.GetString(2);
                            repo.Correlativo = dr.GetString(3);
                            repo.Pdf = (byte[])dr["docpdf"];
                            repo.Xml = (byte[])dr["docxml"];


                        }
                    }
                }
                return repo;

            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;
            }
        }

        public static int ContadorNoEnviados()
        {


            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            int i = 0;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("contar_noenviados", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            i = dr.GetInt32(0);
                        }
                    }
                }
                return i;

            }
            catch (MySqlException ex)
            {
                return -1;
                throw ex;
            }
        }

        public static int ValidarEnviosPendientes()
        {


            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            int i = 0;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("repositorio_validarpendienteenvio", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            i = dr.GetInt32(0);
                        }
                    }
                }
                return i;

            }
            catch (MySqlException ex)
            {
                return -1;
                throw ex;
            }
        }

        public static Boolean update(string valor)
        {

            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("actualiza_variable", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("val", valor);
                        cmd.Parameters.AddWithValue("codusu", Session.CodUsuario);

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
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;

            }
        }






        public static List<Repositorio> listar_repositorio(String estado, Int32 codsucu, Int32 codalma, DateTime fecha)
        {

            MySqlConnection cn = null;
            string consulta = "";
            MySqlDataReader dr = null;
            List<Repositorio> lista = null;
            Repositorio clsrepo = null;
            MySqlCommand cmd = null;

            try
            {
                lista = null;

                if (cn == null)
                {
                    cn = new MySqlConnection(Conexion.cadenaConexion);
                    cn.Open();
                }

                consulta = "listar_repositorio";
                cmd = new MySqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 25000;
                MySqlParameter oParam;
                oParam = cmd.Parameters.AddWithValue("_estadosunat", estado);
                oParam = cmd.Parameters.AddWithValue("_codSucursal", codsucu);
                oParam = cmd.Parameters.AddWithValue("_codAlmacen", codalma);
                oParam = cmd.Parameters.AddWithValue("_fecharegistro", fecha);
                //oParam = cmd.Parameters.AddWithValue("codFacturaVenta_ex", codfac);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    lista = new List<Repositorio>();

                    while (dr.Read())
                    {
                        clsrepo = new Repositorio();
                        clsrepo.Repoid = (int)dr["repositorioid"];
                        clsrepo.Tipodoc = (int)dr["tipdoc"];
                        clsrepo.Fechaemision = DateTime.Parse(dr["fechaemision"].ToString());
                        clsrepo.Serie = (string)dr["serie"];
                        clsrepo.Correlativo = (string)dr["correlativo"];
                        clsrepo.Monto = (decimal)dr["monto"];
                        clsrepo.Estadosunat = (string)dr["estadosunat"];
                        clsrepo.Mensajesunat = (string)dr["mensajesunat"];
                        clsrepo.Pdf = (byte[])dr["docpdf"];
                        clsrepo.Xml = (byte[])dr["docxml"];
                        clsrepo.Nombredoc = (string)dr["nombredoc"];
                        clsrepo.Usuario = (int)dr["usuario"];
                        clsrepo.Fechaemision = DateTime.Parse(dr["fecharegistro"].ToString());
                        lista.Add(clsrepo);
                    }

                }
                return lista;
            }
            catch (MySqlException ex)
            {
                return lista;
            }
            finally { cn.Dispose(); cmd.Dispose(); cn.Close(); }
        }

        public static List<Repositorio> listar_repositorio_Enviados(String estado, Int32 codsucu, Int32 codalma, DateTime fecha)
        {

            MySqlConnection cn = null;
            string consulta = "";
            MySqlDataReader dr = null;
            List<Repositorio> lista = null;
            Repositorio clsrepo = null;
            MySqlCommand cmd = null;

            try
            {
                lista = null;

                if (cn == null)
                {
                    cn = new MySqlConnection(Conexion.cadenaConexion);
                    cn.Open();
                }

                consulta = "listar_repositorio_Enviados";
                cmd = new MySqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter oParam;
                oParam = cmd.Parameters.AddWithValue("_estadosunat", estado);
                oParam = cmd.Parameters.AddWithValue("_codSucursal", codsucu);
                oParam = cmd.Parameters.AddWithValue("_codAlmacen", codalma);
                oParam = cmd.Parameters.AddWithValue("_fecharegistro", fecha);
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    lista = new List<Repositorio>();

                    while (dr.Read())
                    {
                        clsrepo = new Repositorio();
                        clsrepo.Repoid = (int)dr["repositorioid"];
                        clsrepo.Tipodoc = (int)dr["tipdoc"];
                        clsrepo.Fechaemision = DateTime.Parse(dr["fechaemision"].ToString());
                        clsrepo.Serie = (string)dr["serie"];
                        clsrepo.Correlativo = (string)dr["correlativo"];
                        clsrepo.Monto = (decimal)dr["monto"];
                        clsrepo.Estadosunat = (string)dr["estadosunat"];
                        clsrepo.Mensajesunat = (string)dr["mensajesunat"];
                        //clsrepo.Pdf = (byte[])dr["docpdf"];
                        clsrepo.Xml = (byte[])dr["docxml"];
                        clsrepo.Nombredoc = (string)dr["nombredoc"];
                        clsrepo.Usuario = (int)dr["usuario"];
                        clsrepo.Fechaemision = DateTime.Parse(dr["fecharegistro"].ToString());
                        lista.Add(clsrepo);
                    }

                }
                return lista;
            }
            catch (MySqlException ex)
            {
                return lista;
            }
            finally { cn.Dispose(); cmd.Dispose(); cn.Close(); }
        }
        public static bool actualiza_repositorio(Repositorio repo)
        {

            MySqlConnection cn = null;
            string consulta = "";
            MySqlTransaction mysqltransaccion = null;
            MySqlCommand cmd = null;

            try
            {
                if (cn == null)
                {
                    cn = new MySqlConnection(Conexion.cadenaConexion);
                    cn.Open();
                }

                mysqltransaccion = cn.BeginTransaction();
                consulta = "actualiza_estadosunat_repositorio";
                cmd = new MySqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter oParam;
                oParam = cmd.Parameters.AddWithValue("_repositorioid", repo.Repoid);
                oParam = cmd.Parameters.AddWithValue("_estadosunat", repo.Estadosunat);
                oParam = cmd.Parameters.AddWithValue("_mensajesunat", repo.Mensajesunat);
                oParam = cmd.Parameters.AddWithValue("_cdrzip", repo.CDR);
                oParam = cmd.Parameters.AddWithValue("_resultado", 0);
                oParam.Direction = ParameterDirection.Output;
                int x = cmd.ExecuteNonQuery();
                x = Convert.ToInt32(cmd.Parameters["_resultado"].Value);
                mysqltransaccion.Commit();

                if (x != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (MySqlException ex)
            {
                if (mysqltransaccion != null)
                {
                    mysqltransaccion.Rollback();
                }
                throw ex;
            }
            finally { cn.Dispose(); cmd.Dispose(); cn.Close(); }
        }


        public static bool actualiza_repositorio_respaldo(Repositorio repo)
        {

            MySqlConnection cn = null;
            string consulta = "";
            MySqlTransaction mysqltransaccion = null;
            MySqlCommand cmd = null;

            try
            {
                if (cn == null)
                {
                    cn = new MySqlConnection(Conexion.cadenaConexion);
                    cn.Open();
                }

                mysqltransaccion = cn.BeginTransaction();
                consulta = "actualiza_estadosunat_repositorio_respaldo";
                cmd = new MySqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter oParam;
                oParam = cmd.Parameters.AddWithValue("_tipdoc", repo.Tipodoc);
                oParam = cmd.Parameters.AddWithValue("_estadosunat", repo.Estadosunat);
                oParam = cmd.Parameters.AddWithValue("_mensajesunat", repo.Mensajesunat);
                oParam = cmd.Parameters.AddWithValue("_serie", repo.Serie);
                oParam = cmd.Parameters.AddWithValue("_correlativo", repo.Correlativo);
                oParam = cmd.Parameters.AddWithValue("_resultado", 0);
                oParam.Direction = ParameterDirection.Output;
                int x = cmd.ExecuteNonQuery();
                x = Convert.ToInt32(cmd.Parameters["_resultado"].Value);
                mysqltransaccion.Commit();

                if (x != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (MySqlException ex)
            {
                if (mysqltransaccion != null)
                {
                    mysqltransaccion.Rollback();
                }
                throw ex;
            }
            finally { cn.Dispose(); cmd.Dispose(); cn.Close(); }
        }



        public static bool actualiza_repositorio_xml(Repositorio repo)
        {

            MySqlConnection cn = null;
            string consulta = "";
            MySqlTransaction mysqltransaccion = null;
            MySqlCommand cmd = null;

            try
            {
                if (cn == null)
                {
                    cn = new MySqlConnection(Conexion.cadenaConexion);
                    cn.Open();
                }

                mysqltransaccion = cn.BeginTransaction();
                consulta = "actualiza_repositorio_xml";
                cmd = new MySqlCommand(consulta, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter oParam;
                oParam = cmd.Parameters.AddWithValue("_repositorioid", repo.Repoid);
                oParam = cmd.Parameters.AddWithValue("_docxml", repo.Xml);
                oParam = cmd.Parameters.AddWithValue("_resultado", 0);

                oParam.Direction = ParameterDirection.Output;
                int x = cmd.ExecuteNonQuery();
                x = Convert.ToInt32(cmd.Parameters["_resultado"].Value);
                mysqltransaccion.Commit();

                if (x != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (MySqlException ex)
            {
                if (mysqltransaccion != null)
                {
                    mysqltransaccion.Rollback();
                }
                throw ex;
            }
            finally { cn.Dispose(); cmd.Dispose(); cn.Close(); }
        }





        public static Boolean ActualizaCorrelativoDocResp(Int32 codtipodoc, Int32 codalma)
        {

            MySqlConnection cn = null;
            MySqlTransaction mysqltransaccion = null;
            MySqlCommand cmd = null;

            try
            {
                if (cn == null)
                {
                    cn = new MySqlConnection(Conexion.cadenaConexion);
                    cn.Open();
                }

                cmd = new MySqlCommand("ActualizaCorrelativoDocResp", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter oParam;
                oParam = cmd.Parameters.AddWithValue("codDocumento_ex", codtipodoc);
                oParam = cmd.Parameters.AddWithValue("codAlmacen_ex", codalma);
                int x = cmd.ExecuteNonQuery();
                if (x != 0) { return true; }
                else { return false; }
            }
            catch (MySqlException ex)
            {
                if (mysqltransaccion != null)
                {
                    mysqltransaccion.Rollback();
                }
                throw ex;
            }
            finally { cn.Dispose(); cmd.Dispose(); cn.Close(); }
        }

        public static DataTable Lista_Ventas_Diarias(Int32 CodSuc, Int32 CodAlma, DateTime fecha)
        {

            MySqlConnection cn = null;
            MySqlDataAdapter adap = null;
            DataTable tabla = null;
            MySqlCommand cmd = null;

            try
            {
                tabla = new DataTable();
                if (cn == null)
                {
                    cn = new MySqlConnection(Conexion.cadenaConexion);
                    cn.Open();
                }

                cmd = new MySqlCommand("Lista_Ventas_Diarias", cn);
                cmd.Parameters.AddWithValue("codSucursal_ex", CodSuc);
                cmd.Parameters.AddWithValue("codAlmacen_ex", CodAlma);
                cmd.Parameters.AddWithValue("fecha", fecha);
                cmd.CommandType = CommandType.StoredProcedure;
                adap = new MySqlDataAdapter(cmd);
                adap.Fill(tabla);
                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { cn.Dispose(); cmd.Dispose(); cn.Close(); }
        }

    }
}
