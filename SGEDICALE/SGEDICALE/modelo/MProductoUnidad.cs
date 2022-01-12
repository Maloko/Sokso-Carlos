using System;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MProductoUnidad
    {

        public static bool insertar(ProductoUnidad pro)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            bool listo = true;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("GuardaProductoUnidad", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("codproducto_", pro.CodProducto);
                        cmd.Parameters.AddWithValue("codunidad_", pro.CodUnidad);
                        cmd.Parameters.AddWithValue("precioventa_", pro.Precioventa);
                        cmd.Parameters.AddWithValue("preciocompra_", pro.Preciocompra);
                        cmd.Parameters.AddWithValue("codusuario_", pro.Codusuario);

                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        pro.CodProductoUnidad = Convert.ToInt32(cmd.Parameters["newid"].Value);

                        if (pro.CodProducto <= 0)
                        {
                            listo = false;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {

                throw ex;
            }

            return listo;
        }

        public static bool actualizar(ProductoUnidad pro)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            bool listo = true;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("ActualizaProductoUnidad", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("codproductounidad_", pro.CodProductoUnidad);
                        cmd.Parameters.AddWithValue("codunidad_", pro.CodUnidad);
                        cmd.Parameters.AddWithValue("precioventa_", pro.Precioventa);
                        cmd.Parameters.AddWithValue("preciocompra_", pro.Preciocompra);
                        cmd.Parameters.AddWithValue("codusuario_", pro.Codusuario);

                        int x=cmd.ExecuteNonQuery();

                        if (x != 0)
                        {
                            listo = true;
                        }
                        else
                        {
                            return listo = false;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {

                throw ex;
            }

            return listo;
        }



        public static DataTable listado()
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listadoproductosunidad", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }


        public static ProductoUnidad precioventaxunidad(int codproducto, int codunidadmedida)
        {
            ProductoUnidad pro = null;

            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    cmd = new MySqlCommand("precioventaxunidad", cn);
                    cmd.Parameters.AddWithValue("codproducto_", codproducto);
                    cmd.Parameters.AddWithValue("codunidadmedida_", codunidadmedida);

                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            pro = new ProductoUnidad();
                            pro.CodProductoUnidad = dr.GetInt32(0);
                            pro.CodProducto = dr.GetInt32(1);
                            pro.CodUnidad = dr.GetInt32(2);
                            pro.Precioventa = dr.GetDecimal(3);

                        }
                    }
                }

                return pro;

            }
            catch (MySqlException ex)
            {
                return null;
                throw ex;

            }
        }

        public static DataTable listadoxcodProducto(int codproducto)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listadoproductosunidadxcod", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codproducto_", codproducto);
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }


    }
}
