using System;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;
using System.Collections.Generic;

namespace SGEDICALE.modelo
{
    public class MAcceso
    {

        public static List<Acceso> listar_acceso_aformulario()
        {

            MySqlConnection cn = null;
            MySqlCommand mysqlcomm = null;
            List<Acceso> lista = null;
            string consulta = "";
            MySqlDataReader mysqldatare = null;
            Acceso acceso = null;

            try
            {
                lista = null;

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    if (cn != null)
                    {
                        consulta = "listar_formulario";
                        mysqlcomm = new MySqlCommand(consulta, cn);
                        mysqlcomm.CommandType = CommandType.StoredProcedure;
                        mysqldatare = mysqlcomm.ExecuteReader();

                        if (mysqldatare.HasRows)
                        {
                            lista = new List<Acceso>();

                            while (mysqldatare.Read())
                            {
                                acceso = new Acceso();
                                acceso.Formularioid = (int)mysqldatare["formularioid"];
                                acceso.Nombre = (string)mysqldatare["nombre"];

                                lista.Add(acceso);
                            }
                            mysqldatare.Close();
                        }
                        
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
        public static  int registar_acceso_aformulario(Acceso acceso)
        {

            int id = -1;
            MySqlConnection cn = null;
            MySqlCommand mysqlcomm = null;
            string consulta = "";
            MySqlDataReader mysqldatare = null;
            MySqlTransaction mysqltransaccion= null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    if (cn != null)
                    {
                        mysqltransaccion = cn.BeginTransaction();
                        consulta = "registar_usuario_formulario";
                        mysqlcomm = new MySqlCommand(consulta, cn);
                        mysqlcomm.CommandType = CommandType.StoredProcedure;
                        mysqlcomm.Transaction = mysqltransaccion;

                        mysqlcomm.Parameters.Add(new MySqlParameter("@_usuarioid", MySqlDbType.Int32));
                        mysqlcomm.Parameters.Add(new MySqlParameter("@_formularioid", MySqlDbType.Int32));
                        mysqlcomm.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));

                        mysqlcomm.Parameters[0].Value = acceso.Usuario.Usuarioid;
                        mysqlcomm.Parameters[1].Value = acceso.Formularioid;
                        mysqlcomm.Parameters[2].Value = acceso.Estado;

                        mysqldatare = mysqlcomm.ExecuteReader();

                        if (mysqldatare.HasRows)
                        {
                            while (mysqldatare.Read())
                            {
                                id = Convert.ToInt32(mysqldatare["_id"]);
                            }
                            mysqldatare.Close();
                        }

                        mysqltransaccion.Commit();
                   
                    }
                }
                return id;
            }            
            catch (Exception ex)
            {
                mysqltransaccion.Rollback();
                return id;
                throw ex;

            }
        }
        public static int actualizar_acceso_aformulario(Acceso acceso)
        {

            int id = -1;
            MySqlConnection cn = null;
            MySqlCommand mysqlcomm = null;
            string consulta = "";
            MySqlDataReader mysqldatare = null;
            MySqlTransaction mysqltransaccion = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    if (cn != null)
                    {
                        mysqltransaccion = cn.BeginTransaction();
                        consulta = "actualizar_usuario_formulario";
                        mysqlcomm = new MySqlCommand(consulta, cn);
                        mysqlcomm.CommandType = CommandType.StoredProcedure;
                        mysqlcomm.Transaction = mysqltransaccion;

                        mysqlcomm.Parameters.Add(new MySqlParameter("@_usuarioid", MySqlDbType.Int32));
                        mysqlcomm.Parameters.Add(new MySqlParameter("@_formularioid", MySqlDbType.Int32));
                        mysqlcomm.Parameters.Add(new MySqlParameter("@_estado", MySqlDbType.Int32));

                        mysqlcomm.Parameters[0].Value = acceso.Usuario.Usuarioid;
                        mysqlcomm.Parameters[1].Value = acceso.Formularioid;
                        mysqlcomm.Parameters[2].Value = acceso.Estado;

                        mysqldatare = mysqlcomm.ExecuteReader();

                        if (mysqldatare.HasRows)
                        {
                            while (mysqldatare.Read())
                            {
                                id = Convert.ToInt32(mysqldatare["_id"]);
                            }
                            mysqldatare.Close();
                        }

                        mysqltransaccion.Commit();
                  

                    }
                }

                return id;

            }
            catch (Exception ex)
            {
                mysqltransaccion.Rollback();
                return id;
                throw ex;

            }
        }
        public static bool existe_acceso_aformulario(Acceso acceso)
        {

            bool existe = false;
            MySqlConnection cn = null;
            MySqlCommand mysqlcomm = null;
            string consulta = "";
            MySqlDataReader mysqldatare = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    if (cn != null)
                    {
                        consulta = "existe_usuario_formulario";
                        mysqlcomm = new MySqlCommand(consulta, cn);
                        mysqlcomm.CommandType = CommandType.StoredProcedure;
                        mysqlcomm.Parameters.Add(new MySqlParameter("@_usuarioid", MySqlDbType.Int32));
                        mysqlcomm.Parameters.Add(new MySqlParameter("@_formularioid", MySqlDbType.Int32));
                        mysqlcomm.Parameters[0].Value = acceso.Usuario.Usuarioid;
                        mysqlcomm.Parameters[1].Value = acceso.Formularioid;
                        mysqldatare = mysqlcomm.ExecuteReader();
                        existe = mysqldatare.HasRows;
                   
                    }

                }

                return existe;

            }
            catch (Exception ex)
            {

                return existe;
                throw ex;

            }

        }
        public static List<Acceso> listar_acceso_aformulario_xusuario(Acceso acceso)
        {
            MySqlConnection cn = null;
            MySqlCommand mysqlcomm = null;
            string consulta = "";
            MySqlDataReader mysqldatare = null;
            List<Acceso> lista = null;

            try
            {
                lista = null;

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open(); 

                    if (cn != null)
                    {
                        consulta = "listar_formulario_xusuario";
                        mysqlcomm = new MySqlCommand(consulta, cn);
                        mysqlcomm.CommandType = CommandType.StoredProcedure;
                        mysqlcomm.Parameters.Add(new MySqlParameter("@_usuarioid", MySqlDbType.Int32));
                        mysqlcomm.Parameters[0].Value = acceso.Usuario.Usuarioid;
                        mysqldatare = mysqlcomm.ExecuteReader();

                        if (mysqldatare.HasRows)
                        {
                            lista = new List<Acceso>();

                            while (mysqldatare.Read())
                            {
                                acceso = new Acceso();
                                acceso.Formularioid = (int)mysqldatare["formularioid"];
                                acceso.Nombre = (string)mysqldatare["nombre"];

                                lista.Add(acceso);
                            }
                            mysqldatare.Close();
                        }
                  
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

    }
}
