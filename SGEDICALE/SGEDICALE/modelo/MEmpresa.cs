using System;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MEmpresa
    {

        public static Boolean Insert(Empresa emp)
        {

            MySqlConnection cn = null;
            MySqlCommand cmd = null;
         
            int x;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("GuardaEmpresa", cn))
                    {


                        cmd.CommandType = CommandType.StoredProcedure;
                        MySqlParameter oParam;
                        oParam = cmd.Parameters.AddWithValue("razonsocial", emp.RazonSocial);
                        oParam = cmd.Parameters.AddWithValue("ruc", emp.Ruc);
                        oParam = cmd.Parameters.AddWithValue("direccion", emp.Direccion);
                        oParam = cmd.Parameters.AddWithValue("telefono", emp.Telefono);
                        oParam = cmd.Parameters.AddWithValue("fax", emp.Fax);
                        oParam = cmd.Parameters.AddWithValue("representante", emp.Representante);
                        oParam = cmd.Parameters.AddWithValue("estado", emp.Estado);
                        oParam = cmd.Parameters.AddWithValue("codusu", emp.CodUser);
                        if (Imagen.ImagenAbyte(emp.Fotografia).Length != 0)
                        {
                            oParam = cmd.Parameters.AddWithValue("log", Imagen.ImagenAbyte(emp.Fotografia));
                        }
                        else
                        {
                            oParam = cmd.Parameters.AddWithValue("log", 0);
                        }
                        oParam = cmd.Parameters.AddWithValue("newid", 0);
                        oParam.Direction = ParameterDirection.Output;
                        x = cmd.ExecuteNonQuery();

                        emp.CodEmpresaNuevo = Convert.ToInt32(cmd.Parameters["newid"].Value);
                    }

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


        public static  Empresa CargaEmpresa()
        {
            Empresa emp = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    cmd = new MySqlCommand("MuestraEmpresa", cn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            emp = new Empresa();
                            emp.CodEmpresa = Convert.ToInt32(dr.GetDecimal(0));
                            emp.RazonSocial = dr.GetString(1);
                            emp.Ruc = dr.GetString(2);
                            emp.Direccion = dr.GetString(3);
                            emp.Telefono = dr.GetString(4);
                            emp.Fax = dr.GetString(5);
                            emp.Representante = dr.GetString(6);
                            emp.Estado = dr.GetBoolean(7);
                            emp.FechaRegistro = dr.GetDateTime(8);// capturo la fecha 
                            emp.Certificado = dr.GetString(9);
                            emp.Contrasena = dr.GetString(10);
                            emp.UsuarioSunat = dr.GetString(11);
                            emp.ClaveSunat = dr.GetString(12);
                            emp.UrlSunat = dr.GetString(13);
                            if (!dr.IsDBNull(14)) 
                                emp.Email = dr.GetString(14);
                            if (!dr.IsDBNull(15))
                                emp.Claveemail = dr.GetString(15);
                        }

                    }
                }
                return emp;

            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;

            }
        }


        public static Boolean Update(Empresa emp)
        {

            MySqlCommand cmd = null;

            MySqlConnection cn = null;


            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("actualizaempresa", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codempresa_", emp.CodEmpresa);
                    cmd.Parameters.AddWithValue("razon_", emp.RazonSocial);
                    cmd.Parameters.AddWithValue("ruc_", emp.Ruc);
                    cmd.Parameters.AddWithValue("direccion_", emp.Direccion);
                    cmd.Parameters.AddWithValue("telefono_", emp.Telefono);
                    cmd.Parameters.AddWithValue("contrasena_", emp.Contrasena);
                    cmd.Parameters.AddWithValue("usuariosunat_", emp.UsuarioSunat);
                    cmd.Parameters.AddWithValue("clavesunat_", emp.ClaveSunat);




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





    }
}
