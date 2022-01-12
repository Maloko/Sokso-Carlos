using System;
using SGEDICALE.clases;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SGEDICALE.modelo
{
    public class MUsuario
    {

        private static Encriptacion encrip = new Encriptacion();
        private static MySqlTransaction tra = null;

        public static Usuario validar_ingreso(Usuario usuario)
        {
            string consulta = "validar_ingreso";
            MySqlConnection cn = null;
            MySqlDataReader dr = null;
            MySqlCommand cmd;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    cmd = new MySqlCommand(consulta, cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new MySqlParameter("@_cuenta", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_clave", MySqlDbType.VarChar));

                    cmd.Parameters[0].Value = usuario.Cuenta;
                    cmd.Parameters[1].Value = encrip.encriptar(usuario.Clave);

                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            usuario.Usuarioid = dr.GetInt32(0);
                            usuario.Nombreapellidos = dr.GetString(1);
                            usuario.Dni = dr.GetString(2);
                            usuario.Direccion = dr.GetString(3);
                            usuario.Telefono = dr.GetString(4);
                            usuario.Tipousuario = new TipoUsuario();
                            usuario.Tipousuario.Tipousuarioid = dr.GetInt32(5);
                            usuario.Tipousuario.Descripcion = dr.GetString(6);
                            // usuario.codempresa = dr.GetInt32(7);
                            //usuario.codalmacen = dr.GetInt32(8);                     
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

            return usuario;
        }


        public static int registrar_usuario(Usuario usuario, Usuario usureg)
        {
            int id = -1;
            MySqlConnection cn = null;
            MySqlDataReader dr = null;
            MySqlCommand cmd;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    tra = cn.BeginTransaction();
                    cmd = new MySqlCommand("registrar_usuario", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = tra;
                    cmd.Parameters.Add(new MySqlParameter("@_idtipousuario", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_nombreyapellido", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_documentoidentidad", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_telefono", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_cuenta", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_clave", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = usuario.Tipousuario.Tipousuarioid;
                    cmd.Parameters[1].Value = usuario.Nombreapellidos;
                    cmd.Parameters[2].Value = usuario.Dni;
                    cmd.Parameters[3].Value = usuario.Telefono;
                    cmd.Parameters[4].Value = usuario.Cuenta;
                    cmd.Parameters[5].Value = usuario.Clave;
                    cmd.Parameters[6].Value = usuario.Estado;
                    cmd.Parameters[7].Value = usureg.Usuarioid;


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


        public static int actualizar_usuario(Usuario usuario, Usuario usureg)
        {
            int filas_afectadas = -1;
            MySqlConnection cn = null;
            MySqlDataReader dr = null;
            MySqlCommand cmd;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    tra = cn.BeginTransaction();
                    cmd = new MySqlCommand("actualizar_usuario", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Transaction = tra;
                    cmd.Parameters.Add(new MySqlParameter("@_idusuariomod", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idtipousuario", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_nombreyapellido", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_documentoidentidad", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_telefono", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_cuenta", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_clave", MySqlDbType.VarChar));
                    cmd.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));
                    cmd.Parameters.Add(new MySqlParameter("@_idusuario", MySqlDbType.Int32));

                    cmd.Parameters[0].Value = usuario.Usuarioid;
                    cmd.Parameters[1].Value = usuario.Tipousuario.Tipousuarioid;
                    cmd.Parameters[2].Value = usuario.Nombreapellidos;
                    cmd.Parameters[3].Value = usuario.Dni;
                    cmd.Parameters[4].Value = usuario.Telefono;
                    cmd.Parameters[5].Value = usuario.Cuenta;
                    cmd.Parameters[6].Value = usuario.Clave;
                    cmd.Parameters[7].Value = usuario.Estado;
                    cmd.Parameters[8].Value = usureg.Usuarioid;


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

        public static DataTable listar_usuario()
        {
            DataTable tabla = new DataTable();

            MySqlConnection cn = null;
            MySqlCommand cmd;
            MySqlDataAdapter adap = null;

            using (cn = new MySqlConnection(Conexion.cadenaConexion))
            {
                cn.Open();

                cmd = new MySqlCommand("listar_usuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                adap = new MySqlDataAdapter(cmd);
                adap.Fill(tabla);
            }

            return tabla;
        }


        public static List<Usuario> listar_usuario_acceso()
        {
            List<Usuario> lista = null;

            MySqlConnection cn = null;
            MySqlCommand mysqlcomm;
            MySqlDataReader mysqldatare = null;
            string consulta = "";
            Usuario usuario = null;

            try
            {
                lista = null;

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    consulta = "listar_usuario";
                    mysqlcomm = new MySqlCommand(consulta, cn);
                    mysqlcomm.CommandType = CommandType.StoredProcedure;
                    mysqldatare = mysqlcomm.ExecuteReader();

                    if (mysqldatare.HasRows)
                    {
                        lista = new List<Usuario>();

                        while (mysqldatare.Read())
                        {
                            usuario = new Usuario();
                            usuario.Usuarioid = (int)mysqldatare["usuarioid"];
                            usuario.Cuenta = (string)mysqldatare["cuenta"];
                            lista.Add(usuario);
                        }
                        mysqldatare.Close();
                    }
                }

                return lista;

            }
            catch (Exception ex)
            {

                return lista;
                throw ex;

            }
        }


        public static DataTable buscar_usuarioxnombreapellido(Usuario usuario)
        {

            MySqlConnection cn = null;
            MySqlCommand cmd;
            MySqlDataAdapter adap = null;

            DataTable tabla = new DataTable();

            using (cn = new MySqlConnection(Conexion.cadenaConexion))
            {
                cn.Open();

                cmd = new MySqlCommand("buscar_usuarioxnombreyapellido", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new MySqlParameter("@_nombreapellido", MySqlDbType.VarChar));
                cmd.Parameters[0].Value = usuario.Nombreapellidos;
                adap = new MySqlDataAdapter(cmd);
                adap.Fill(tabla);
            }

            return tabla;
        }



    }

}
