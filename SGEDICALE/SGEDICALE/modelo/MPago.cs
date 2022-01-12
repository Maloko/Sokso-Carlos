using System;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;

namespace SGEDICALE.modelo
{
    public class MPago
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




        public static bool insertar(Pago pro)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
         

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                { 
                    cn.Open();


                    using (cmd = new MySqlCommand("guardapago", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("codbanco_", pro.Codbanco);
                        cmd.Parameters.AddWithValue("codcuenta_", pro.Codcuenta);
                        cmd.Parameters.AddWithValue("fecha_", pro.Fecha);
                        cmd.Parameters.AddWithValue("fechavaluta_", pro.Fechavaluta);
                        cmd.Parameters.AddWithValue("descripcion_", pro.Descripcion);
                        cmd.Parameters.AddWithValue("monto_", pro.Monto);
                        cmd.Parameters.AddWithValue("saldo_", pro.Saldo);
                        cmd.Parameters.AddWithValue("sucursal_", pro.Sucursal);
                        cmd.Parameters.AddWithValue("operacionnumero_", pro.Operacionnumero);
                        cmd.Parameters.AddWithValue("operacionhora_", pro.Operacionhora);
                        cmd.Parameters.AddWithValue("usuario_", pro.Usuario);
                        cmd.Parameters.AddWithValue("utc_", pro.Utc);
                        cmd.Parameters.AddWithValue("codusuario_", pro.Codusuario);


                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        int x = cmd.ExecuteNonQuery();
                        pro.CodPago = Convert.ToInt32(cmd.Parameters["newid"].Value);

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

        public static void cambiarestado(int codpago, int estado,string observacion)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;


            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("cambiarestadopago", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("codpago_", codpago);
                        cmd.Parameters.AddWithValue("estado_", estado);
                        cmd.Parameters.AddWithValue("observacion_", observacion);

                        int x = cmd.ExecuteNonQuery();


                    }

                }
            }
            catch (MySqlException ex)
            {

                throw ex;
            }

        }


        public static DataTable listarPagosFiltro(int codbanco, int codcuenta, DateTime fechai, DateTime fechaf)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();


            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listarpagofiltro", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codbanco_", codbanco);
                    cmd.Parameters.AddWithValue("codcuenta_", codcuenta);
                    cmd.Parameters.AddWithValue("fechai_", fechai);
                    cmd.Parameters.AddWithValue("fechaf_", fechaf);

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


        public static DataTable listarpagoxfechaoperacion(string numoperacion,int codbanco,int codcuenta, DateTime fechai, DateTime fechaf)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();


            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listarpagofechaoperacion", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("numerooperacion_", numoperacion);
                    cmd.Parameters.AddWithValue("codbanco_", codbanco);
                    cmd.Parameters.AddWithValue("codcuenta_", codcuenta);
                    cmd.Parameters.AddWithValue("fechai_", fechai);
                    cmd.Parameters.AddWithValue("fechaf_", fechaf);

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



        public static DataTable CargaFormaPagos()
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();
            MySqlCommand cmd = null;

            try
            {
                dt = new DataTable();

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    cmd = new MySqlCommand("ListaFormaPagos", cn);
        
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                return dt;

            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }
        }


        public static Pago buscarSaldoPago(int codpago)
        {
            Pago pago = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {

                    cn.Open();


                    using (cmd = new MySqlCommand("buscarsaldopago", cn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("codpago_", codpago);

                        dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                pago = new Pago();

                                pago.Monto = dr.GetDecimal(0);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;            
            }

            return pago;
        }




    }
}
