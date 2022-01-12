using System;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MPremio
    {

        public static DataTable cargarGrilla(string ruta_excel)
        {

            try
            {
                string consulta = "";

                string nombrehoja = "";

                var excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook librodetrabajo = excel.Workbooks.Open(ruta_excel);

                foreach (Microsoft.Office.Interop.Excel.Worksheet Hojas in librodetrabajo.Sheets)
                {
                    nombrehoja = Hojas.Name;
                    break;
                }
                librodetrabajo.Close();

                consulta = "select * From ["+nombrehoja+"$]";
                string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta_excel + ";Extended Properties=\"Excel 12.0;HDR=Yes\"";

                DataTable dtExcel = new DataTable();
                OleDbConnection origen = new OleDbConnection(conexion);

                OleDbCommand seleccion = new OleDbCommand(consulta, origen);
                OleDbDataAdapter adaptador = new OleDbDataAdapter();
                adaptador.SelectCommand = seleccion;

                adaptador.Fill(dtExcel);
                origen.Close();

                return dtExcel;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static bool insertar(Premio pro)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
          

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("guardapremio", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("codcampaña_", pro.CodCampaña);
                        cmd.Parameters.AddWithValue("dni_", pro.Dni);
                        cmd.Parameters.AddWithValue("compra_", pro.CompraFacturada);
                        cmd.Parameters.AddWithValue("fecha_", pro.FechaValidacion1);
                        cmd.Parameters.AddWithValue("premioregular_", pro.PremioRegular);
                        cmd.Parameters.AddWithValue("envioregular_", pro.EnvioPremioRegular);
                        cmd.Parameters.AddWithValue("premioafi_", pro.PremioAfi);
                        cmd.Parameters.AddWithValue("valido_", pro.Valido);
                        cmd.Parameters.AddWithValue("codusuario_", pro.Codusuario);


                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        int x = cmd.ExecuteNonQuery();
                        pro.CodPremio = Convert.ToInt32(cmd.Parameters["newid"].Value);

                        if (x > 0)
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
               
                throw ex;
            }

        }

        public static bool entregar(Premio pro)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            bool listo = true;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    using (cmd = new MySqlCommand("entregarpremio", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("codpremio_", pro.CodPremio);

                        int x = cmd.ExecuteNonQuery();
  

                        if (x > 0)
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
                return listo;
                throw ex;
            }

        }


        public static bool borrar(int codcampana)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
          

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("borrarpremio", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("codcampaña_", codcampana);

                        int x = cmd.ExecuteNonQuery();

                        if (x > 0)
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
               
                throw ex;
            }


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
                    MySqlCommand cmd = new MySqlCommand("listadopremios", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    cn.Dispose();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

            return dt;
        }

        public static DataTable listadoxcodcampana(int codcampana, int filtro)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listadopremiosxcodcampana", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codcampana_", codcampana);
                    cmd.Parameters.AddWithValue("filtro_", filtro);
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    cn.Dispose();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

            return dt;
        }


        public static DataTable busqueda(string nombre, int codcampana)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("busquedapremio", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("nombre_", nombre);
                    cmd.Parameters.AddWithValue("codcampana_", codcampana);

                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    cn.Dispose();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dt;
        }

        public static DataTable listarpremiosxcodcampana_codpromotor(int codpromotor, int codcampana)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listarpremiosxcodcampana_codpromotor", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codpromotor_", codpromotor);
                    cmd.Parameters.AddWithValue("codcampana_", codcampana);

                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    cn.Dispose();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

            return dt;
        }
    }
}
