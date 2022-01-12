using System;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;


namespace SGEDICALE.modelo
{
    public class MCatalogo
    {

        public static DataTable cargarGrilla(string ruta_excel)
        {
            string consulta = "";

            consulta = "select * From [CABALLEROS-OTOÑO-INVIERNO-2018-$]";

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


        public static bool insertar(Catalogo cat)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            bool listo = true;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("GuardaCatalogo", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("nombre_", cat.Nombre);
                        cmd.Parameters.AddWithValue("cate_", cat.Categoria);
                        cmd.Parameters.AddWithValue("fechai_", cat.FechaInicio);
                        cmd.Parameters.AddWithValue("fechaf_", cat.FechaFin);
                        cmd.Parameters.AddWithValue("codusu_", cat.Codusuario);

                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        cat.CodCatalogo = Convert.ToInt32(cmd.Parameters["newid"].Value);

                        if (cat.CodCatalogo <= 0)
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

        public static bool insertarDetalle(DetalleCatalogo cat)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            bool listo = true;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("GuardaDetalleCatalogo", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("cod_", cat.CodCatalogo);
                        cmd.Parameters.AddWithValue("pag_", cat.Pag);
                        cmd.Parameters.AddWithValue("marca_", cat.Marca);
                        cmd.Parameters.AddWithValue("modelo_", cat.Modelo);
                        cmd.Parameters.AddWithValue("color_", cat.Color);
                        cmd.Parameters.AddWithValue("ppromotor_", cat.Ppromotor);
                        cmd.Parameters.AddWithValue("pdirector_", cat.Pdirector);
                        cmd.Parameters.AddWithValue("fechallegada_", cat.Fechallegada);
                        cmd.Parameters.AddWithValue("tdisponible_", cat.Talladisponible);
                        cmd.Parameters.AddWithValue("tagotada_", cat.Tallasagotadas);
                        cmd.Parameters.AddWithValue("codusu_", cat.Codusuario);

                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        cat.CodDetalleCatalogo = Convert.ToInt32(cmd.Parameters["newid"].Value);

                        if (cat.CodCatalogo <= 0)
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

        public static DataTable cargaCampaña()
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("cargacombocampaña", cn);

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


        public static DataTable busqueda(int cod,string categoria)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("busquedacatalogo", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codcatalogo_", cod);
                    cmd.Parameters.AddWithValue("categoria_", categoria);

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
