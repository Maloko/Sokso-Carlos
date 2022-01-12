using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;


namespace SGEDICALE.modelo
{
    public class MCliente
    {
      
        private static MySqlCommand cmd = null;
        private static MySqlDataReader dr = null;
        private static MySqlDataAdapter adap = null;
        private static MySqlTransaction tra = null;
        private static DataTable tabla = null;
        public static  int actualizar_cliente(Cliente cliente)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            int filas_afectadas = -1;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    tra = cn.BeginTransaction();
                    cmd = new MySqlCommand("actualizar_cliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = tra;
                    cmd.Parameters.Add(new MySqlParameter("@_idcliente", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipodocumentoidentidad", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_nombreyapellido", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_documento", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_direccion", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));


                    cmd.Parameters[0].Value = cliente.Idcliente;
                    cmd.Parameters[1].Value = cliente.Tipodocumentoidentidad.Idtipodocumentoidentidad;
                    cmd.Parameters[2].Value = cliente.Nombreyapellido;
                    cmd.Parameters[3].Value = cliente.Documento;
                    cmd.Parameters[4].Value = cliente.Direccion;
                    cmd.Parameters[5].Value = cliente.Estado;

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
                    return filas_afectadas;
                }
            }
            catch (MySqlException ex)
            {
                filas_afectadas = -1;
                tra.Rollback();
                return filas_afectadas;
                throw ex;
            }
       
        }

        public static DataTable buscar_clientexnombreyapellido(Cliente cliente)
        {
            tabla = new DataTable();

            MySqlConnection cn = null;
            MySqlCommand cmd = null;


            using (cn = new MySqlConnection(Conexion.cadenaConexion))
            {
                cn.Open();
                cmd = new MySqlCommand("buscar_clientexnombreyapellido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("@_nombreyapellido", MySqlDbType.VarChar));
                cmd.Parameters[0].Value = cliente.Nombreyapellido;
                adap = new MySqlDataAdapter(cmd);
                adap.Fill(tabla);
            }

            return tabla;
        }


        public static Cliente buscar_clientexcodigo(int codcliente)
        {
            Cliente cli = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("buscar_clientexcodigo", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@codcliente_", MySqlDbType.VarChar));
                    cmd.Parameters[0].Value = codcliente;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            cli = new Cliente()
                            {

                                Idcliente = (int)dr["idcliente"],
                                Tipodocumentoidentidad = new TipoDocumentoIdentidad()
                                {
                                    Idtipodocumentoidentidad = (int)dr["idtipodocumentoidentidad"],
                                    Descripcion = (string)dr["descripcion"],
                                    Codsunat = (string)dr["codsunat"]
                                },

                                Nombreyapellido = (string)dr["nombreyapellido"],
                                Documento = (string)dr["documento"],
                                Direccion = (string)dr["direccion"]
                            };
                        }
                    }
                }
                return cli;
            }
            catch (MySqlException ex)
            {
                return cli;
                throw ex;
            }

        }

        public static Cliente buscar_clientexnumerodocumento(Cliente cliente)
        {
            Cliente cli = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("buscar_clientexnumerodocumento", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@_numero", MySqlDbType.VarChar));
                    cmd.Parameters[0].Value = cliente.Documento;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            cli = new Cliente()
                            {

                                Idcliente = (int)dr["idcliente"],
                                Tipodocumentoidentidad = new TipoDocumentoIdentidad()
                                {
                                    Idtipodocumentoidentidad = (int)dr["idtipodocumentoidentidad"],
                                    Descripcion = (string)dr["descripcion"],
                                    Codsunat = (string)dr["codsunat"]
                                },

                                Nombreyapellido = (string)dr["nombreyapellido"],
                                Documento = (string)dr["documento"],
                                Direccion = (string)dr["direccion"]
                            };
                        }
                    }
                }
                return cli;
            }
            catch (MySqlException ex)
            {
                return cli;
                throw ex;
            }
       
        }

        public static DataTable listar_cliente()
        {
            tabla = new DataTable();
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            using (cn = new MySqlConnection(Conexion.cadenaConexion))
            {
                cn.Open();
                cmd = new MySqlCommand("listar_cliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                adap = new MySqlDataAdapter(cmd);
                adap.Fill(tabla);
            }

            return tabla;
        }


        public static int registrar_cliente(Cliente cliente)
        {
            int id = -1;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    tra = cn.BeginTransaction();
                    cmd = new MySqlCommand("registrar_cliente", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = tra;
                    cmd.Parameters.Add(new MySqlParameter("@_idtipodocumentoidentidad", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_nombreyapellido", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_documento", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_direccion", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));


                    cmd.Parameters[0].Value = cliente.Tipodocumentoidentidad.Idtipodocumentoidentidad;
                    cmd.Parameters[1].Value = cliente.Nombreyapellido;
                    cmd.Parameters[2].Value = cliente.Documento;
                    cmd.Parameters[3].Value = cliente.Direccion;
                    cmd.Parameters[4].Value = cliente.Estado;

                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            id = Convert.ToInt32(dr["_id"]);
                        }
                        dr.Close();
                    }
                    tra.Commit();
                }
                return id;
            }
            catch (MySqlException ex)
            {
                id = -1;
                tra.Rollback();
                return id;
                throw ex;
            }
     
        }

    }
}
