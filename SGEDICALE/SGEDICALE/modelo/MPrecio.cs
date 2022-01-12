using System;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;
using System.Transactions;


namespace SGEDICALE.modelo
{
    public class MPrecio
    {


        public static DataTable cargarGrilla(string ruta_excel)
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

            consulta = "select * From [" + nombrehoja + "$]";

            string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta_excel + ";Extended Properties=\"Excel 12.0;HDR=Yes\"";

            //string conexion2 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta_excel + @";Extended Properties=""Excel 12.0 Xml;HDR=No;""";

            //string conexion3 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +ruta_excel+ ";Extended Properties=\"Excel 12.0 Xml;HDR=No\"";

            DataTable dtExcel = new DataTable();
            OleDbConnection origen = new OleDbConnection(conexion);

            OleDbCommand seleccion = new OleDbCommand(consulta, origen);
            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            adaptador.SelectCommand = seleccion;

            adaptador.Fill(dtExcel);
            origen.Close();

            return dtExcel;
        }

   

        public static bool insertar(Precio cat)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            bool listo = true;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("GuardaPrecio", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("codcampana_", cat.Campana.CodCampaña);
                        cmd.Parameters.AddWithValue("codusu_", cat.Codusuario);

                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        cat.CodPrecio = Convert.ToInt32(cmd.Parameters["newid"].Value);

                        if (cat.CodPrecio <= 0)
                        {
                            listo = false;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                listo = false;
                return listo;
                throw ex;
            }

            return listo;
        }

        public static bool insertarDetalle(DetallePrecio cat)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            bool listo = true;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("GuardaDetallePrecio", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("codprecio_", cat.Precio.CodPrecio);
                        cmd.Parameters.AddWithValue("pag_", cat.Pag);
                        cmd.Parameters.AddWithValue("marca_", cat.Marca);
                        cmd.Parameters.AddWithValue("modelo_", cat.Modelo);
                        cmd.Parameters.AddWithValue("color_", cat.Color);
                        cmd.Parameters.AddWithValue("ppromotor_", cat.Ppromotor);
                        cmd.Parameters.AddWithValue("pcliente_", cat.Pcliente);
                        cmd.Parameters.AddWithValue("pdirector_", cat.Pdirector);
                        cmd.Parameters.AddWithValue("fechallegada_", cat.Fechallegada);
                        cmd.Parameters.AddWithValue("tdisponible_", cat.Talladisponible);
                        cmd.Parameters.AddWithValue("tagotada_", cat.Tallasagotadas);
                        cmd.Parameters.AddWithValue("codusu_", cat.Codusuario);

                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        cat.CodDetallePrecio = Convert.ToInt32(cmd.Parameters["newid"].Value);

                        if (cat.CodDetallePrecio <= 0)
                        {
                            listo = false;
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                listo = false;
                return listo;
                throw ex;
            }

            return listo;
        }


        public static Precio buscarxcodcampana(Int32 codcampana)
        {
            Precio tar = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr;
            MySqlConnection cn = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    cmd = new MySqlCommand("buscarprecioxcodcampana", cn);
                    cmd.Parameters.AddWithValue("codcampana_", codcampana);

                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            tar = new Precio();
                            tar.Campana = new Campaña();
                            tar.Campana.CodCampaña = dr.GetInt32(0);
                            tar.Codusuario = dr.GetInt32(1);
                            tar.Estado = dr.GetInt32(2);
                        }

                    }
                }
                return tar;

            }
            catch (MySqlException ex)
            {
                throw ex;
            }

        }

        public static DataTable busquedaDetalle(int cod)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("busquedadetalleprecio", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codcampana_", cod);
                

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


        public static DataTable Comparacion(int cod)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("comparacion", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codcampana_", cod);

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
