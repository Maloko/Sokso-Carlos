using System;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;
using System.Transactions;
using System.Diagnostics;


namespace SGEDICALE.modelo
{
    public class MPedido
    {

        public static DataTable cargarGrilla(string ruta_excel, string nombre_excel)
        {
            try
            {

                string conexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ruta_excel + ";Extended Properties=\"Excel 12.0;HDR=No\"";
                string consulta = "";
                string nombrehoja = "";


                int idproc = iGetIDProcces("EXCEL", nombre_excel);

                if (idproc != -1)
                {
                    Process.GetProcessById(idproc).Kill();
                }

                var excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook librodetrabajo = excel.Workbooks.Open(ruta_excel);



                foreach (Microsoft.Office.Interop.Excel.Worksheet Hojas in librodetrabajo.Sheets)
                {
                    nombrehoja = Hojas.Name;
                    break;
                }

                Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = librodetrabajo.Worksheets[nombrehoja];

                /*
                excelWorksheet.Cells[2, 5] = "no tocar";
                librodetrabajo.Save();*/

                librodetrabajo.Close();
                excel.Quit();


                consulta = "select * From ["+nombrehoja+"$]";


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
                return null;
            }
        }

        public static int iGetIDProcces(string nameProcces, string nombre_excel)
        {


            Process[] asProccess = Process.GetProcessesByName(nameProcces);

            foreach (Process pProccess in asProccess)
            {
                if (pProccess.MainWindowTitle.Contains(nombre_excel))
                {
                    return pProccess.Id;
                }
            }

            return -1;


        }



        /*
        public static  void update(string conexion,string nombrehoja,string consulta, string ruta_excel)
        {
            consulta = "UPDATE [" + nombrehoja + "$] SET F6=" + "";
            OleDbConnection origen = new OleDbConnection(conexion);
            OleDbCommand seleccion = new OleDbCommand(consulta, origen);
       
            seleccion.ExecuteNonQuery();

           // origen.Close();

        }*/


        public static bool borrar(int codpedido)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("borrarpedido", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("codpedido_", codpedido);


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


        public static bool borrarTodo(int numeropedido)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("borrarpedidos", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("numeropedido_", numeropedido);


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



        public static Pedido buscar(int codigopedido)
        {
            Pedido pedi = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    using (cmd = new MySqlCommand("buscarpedido", cn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("codigo_", codigopedido);

                        dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                pedi = new Pedido();

                                pedi.CodPedido = dr.GetInt32(0);
                                pedi.CodPromotor = dr.GetInt32(1);
                                pedi.Promotor = dr.GetString(2);
                                pedi.Numeropedido = dr.GetString(3);
                                pedi.Subtotal = dr.GetDecimal(4);
                                pedi.Igv = dr.GetDecimal(5);
                                pedi.Total = dr.GetDecimal(6);
                                pedi.Fechapedido = dr.GetDateTime(7);
                                pedi.Codusuario = dr.GetInt32(8);
                                pedi.Estado = dr.GetInt32(9);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               
                throw ex;
            }

            return pedi;
        }


        public static bool insertar(Pedido ped)
        {
            bool rpta = true;
            MySqlCommand cmd = null;
            MySqlConnection cn = null;
            int cantidad = 0;

            try
            {

                using (var Scope = new TransactionScope())
                {

                    using (cn = new MySqlConnection(Conexion.cadenaConexion))
                    {
                        cn.Open();

                        cmd = new MySqlCommand("GuardaPedido", cn);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("numpedido_", ped.Numeropedido);
                        cmd.Parameters.AddWithValue("numdoc_", ped.Numerodocumento);
                        cmd.Parameters.AddWithValue("promotor_", ped.Promotor);
                        cmd.Parameters.AddWithValue("subtotal_", ped.Subtotal);
                        cmd.Parameters.AddWithValue("igv_", ped.Igv);
                        cmd.Parameters.AddWithValue("total_", ped.Total);
                        cmd.Parameters.AddWithValue("fechapedido_", ped.Fechapedido);
                        cmd.Parameters.AddWithValue("fechaenvio_", ped.Fechaenvio);
                        cmd.Parameters.AddWithValue("codusu_", ped.Codusuario);
                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        ped.CodPedido = Convert.ToInt32(cmd.Parameters["newid"].Value);

                        if (ped.CodPedido <= 0)
                        {
                            rpta = false;
                            Transaction.Current.Rollback();
                            Scope.Dispose();
                            return rpta;
                        }

                        for (int i = 0; i < ped.ListaDetallePedido.Count; i++)
                        {


                            DetallePedido detPed = ped.ListaDetallePedido[i];

                            if (detPed.Preciost > 0 && detPed.Cantidad>0)
                            {

                                detPed.CodPedido = ped.CodPedido;

                                cmd = new MySqlCommand("GuardaDetallePedido", cn);
                                cmd.CommandType = CommandType.StoredProcedure;

                                cmd.CommandTimeout = 250000000;

                                cmd.Parameters.AddWithValue("codpedido_", detPed.CodPedido);
                                cmd.Parameters.AddWithValue("producto_", detPed.Producto.Trim());
                                cmd.Parameters.AddWithValue("catalogo_", detPed.Catalogo.Trim());
                                cmd.Parameters.AddWithValue("devolucion_", detPed.Devolucion);
                                cmd.Parameters.AddWithValue("talla_", detPed.Talla.Trim());
                                cmd.Parameters.AddWithValue("cantidad_", detPed.Cantidad);
                                cmd.Parameters.AddWithValue("precio_", detPed.Precio);
                                cmd.Parameters.AddWithValue("preciost_", detPed.Preciost);
                                cmd.Parameters.AddWithValue("codusu_", detPed.Codusuario);
                                cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                                cmd.ExecuteNonQuery();
                                detPed.CodDetallePedido = Convert.ToInt32(cmd.Parameters["newid"].Value);

                                if (detPed.CodDetallePedido <= 0)
                                {
                                    rpta = false;
                                    Transaction.Current.Rollback();
                                    Scope.Dispose();
                                    return rpta;
                                }

                                cantidad = cantidad + 1;
                            }
                        }

                        if (cantidad == 0)
                        {
                            rpta = false;
                            Transaction.Current.Rollback();
                            Scope.Dispose();
                            return rpta;
                        }
                        else
                        {
                            Scope.Complete();
                            Scope.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex)
            {   
                throw ex;
            }

            return rpta;
        }


        public static DataTable cargarComboPedido(DateTime fechapedido)
        {
           
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("cargacomboPedido", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("fecha", fechapedido);

                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                }

                return dt;
            }
            catch (Exception ex)
            { 
                throw ex;
            }          
        }

        public static DataTable cargarComboPedidoxMes(DateTime fechapedido)
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("cargacomboPedidoxMes", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("fecha", fechapedido);

                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                }

                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static DataTable listarPedidos()
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {


                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listarpedidos", cn);

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

        public static DataTable listarPedidosxPromotor_Fecha_Filtro(int codpromotor, string filtro)
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {


                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listarpedidosxpromotor_fecha_filtro", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codpromotor_", codpromotor);
                    cmd.Parameters.AddWithValue("filtro_", filtro);

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

        public static DataTable listarPedidosxCodigo(int codpedido)
        {

            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {


                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listarpedidosxcodigo", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("codpedido_", codpedido);

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

        


        public static DataTable listarPedidosFiltroDiferencia(string numeropedido, int filtro)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();
            string consulta = "";

            try
            {

                switch (filtro)
                {
                    case 0:
                        //consulta = "listarpedidosfiltrodiferenciaambos";
                        consulta = "listarpedidosfiltrodiferenciaambos";
                        break;
                    case 1:
                        consulta = "listarpedidosfiltrodiferenciapendientes";
                        break;
                    case 2:
                        consulta = "listarpedidosfiltrodiferenciafacturados";
                        break;

                }
                

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand(consulta, cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("numpedido_", numeropedido);

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


        public static DataTable listarPedidosFiltroTodos(string numeropedido, int filtro)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listarpedidosfiltrotodos", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("numpedido_", numeropedido);
                    cmd.Parameters.AddWithValue("filtro_", filtro);
                    

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


        
        public static DataTable listarPedidosFiltro(string numeropedido, int filtro)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listarpedidosfiltro", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("numpedido_", numeropedido);
                    cmd.Parameters.AddWithValue("filtro_", filtro);

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

        public static DataTable listarPedidosFiltroCorrecto(string numeropedido, int filtro)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();
            string consulta = "";

            try
            {

                switch (filtro)
                {
                    case 0:
                        consulta = "listarpedidosfiltrocorrectoambos";
                        break;
                    case 1:
                        consulta = "listarpedidosfiltrocorrectopendientes";
                        break;
                    case 2:
                        consulta = "listarpedidosfiltrocorrectofacturados";
                        break;

                }


                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand(consulta, cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("numpedido_", numeropedido);
                 

                    da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                }

            }
            catch(Exception ex)
            {

                throw ex;
            }

            return dt;
        }

    }
}

