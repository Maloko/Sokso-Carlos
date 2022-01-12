using System;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;
using System.Diagnostics;

namespace SGEDICALE.modelo
{
    public class MProducto
    {

        public static DataTable cargarGrilla(string ruta_excel, string nombre_excel)
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
            excel.Quit();

            consulta = "select * From [" + nombrehoja + "$]";

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


        public static bool actualizarProductoNuevo(Producto pro)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            bool listo = true;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("ActualizaProductoNuevo", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("codproducto_", pro.CodProducto);
                        cmd.Parameters.AddWithValue("descripcion2_", pro.Descripcion2);
                        cmd.Parameters.AddWithValue("color_", pro.Color);
                        cmd.Parameters.AddWithValue("talla_", pro.Talla);
                        cmd.Parameters.AddWithValue("totalpreprom2_", pro.Totalpreprom2);
                        cmd.Parameters.AddWithValue("codusuario_", pro.Codusuario);

                        int x = cmd.ExecuteNonQuery();
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


        public static bool actualizar(Producto pro)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            bool listo = true;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("ActualizaProducto", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("codproducto_", pro.CodProducto);
                        cmd.Parameters.AddWithValue("descripcion_", pro.Descripcion2);
                        cmd.Parameters.AddWithValue("codusuario_", pro.Codusuario);

                        int x = cmd.ExecuteNonQuery();
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

        public static bool insertar(Producto pro)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            bool listo = true;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("GuardaProducto", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("codsap_", pro.Codigosap);
                        cmd.Parameters.AddWithValue("nombre_", pro.Nombrepromotor);
                        cmd.Parameters.AddWithValue("camp_", pro.Campaña);
                        cmd.Parameters.AddWithValue("pag_", pro.Pag);
                        cmd.Parameters.AddWithValue("cod_p", pro.Cod_Producto);
                        cmd.Parameters.AddWithValue("desc_", pro.Descripcion);
                        cmd.Parameters.AddWithValue("desc2_", pro.Descripcion2);
                        cmd.Parameters.AddWithValue("marca_", pro.Marca);
                        cmd.Parameters.AddWithValue("modelo_", pro.Modelo);
                        cmd.Parameters.AddWithValue("color_", pro.Color);
                        cmd.Parameters.AddWithValue("genero_", pro.Genero);
                        cmd.Parameters.AddWithValue("familia_", pro.Familia);
                        cmd.Parameters.AddWithValue("categoria_", pro.Categoria);
                        cmd.Parameters.AddWithValue("tipomarca_", pro.Tipomarca);
                        cmd.Parameters.AddWithValue("subcat_", pro.Subcat);
                        cmd.Parameters.AddWithValue("nivel6_", pro.Nivel6);
                        cmd.Parameters.AddWithValue("talla_", pro.Talla);
                        cmd.Parameters.AddWithValue("cantidad_", pro.Cantidad);
                        cmd.Parameters.AddWithValue("fecha_", pro.Fecha);
                        cmd.Parameters.AddWithValue("precd_", pro.Precd);
                        cmd.Parameters.AddWithValue("subtotal_", pro.Subtotal);
                        cmd.Parameters.AddWithValue("igv_", pro.Igv);
                        cmd.Parameters.AddWithValue("total_", pro.Total);
                        cmd.Parameters.AddWithValue("preprom_", pro.Preprom);
                        cmd.Parameters.AddWithValue("subtotalpreprom_", pro.Subtotalpreprom);
                        cmd.Parameters.AddWithValue("igvpreprom_", pro.Igvpreprom);
                        cmd.Parameters.AddWithValue("totalpreprom_", pro.Totalpreprom);
                        cmd.Parameters.AddWithValue("totalpreprom2_", pro.Totalpreprom2);
                        cmd.Parameters.AddWithValue("totalprepromdescuento_", pro.Totalprepromdescuento);
                        cmd.Parameters.AddWithValue("ndoc_", pro.Ndoc);
                        cmd.Parameters.AddWithValue("origen_", pro.Origen);
                        cmd.Parameters.AddWithValue("tdoc_", pro.Tdoc);
                        cmd.Parameters.AddWithValue("tnumero_", pro.Tnumero);
                        cmd.Parameters.AddWithValue("codusuario_", pro.Codusuario);

                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        pro.CodProducto = Convert.ToInt32(cmd.Parameters["newid"].Value);

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


        public static bool insertarProductoNuevo(Producto pro)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            bool listo = true;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("GuardaProductoNuevo", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
;
                        cmd.Parameters.AddWithValue("desc_", pro.Descripcion);
                        cmd.Parameters.AddWithValue("desc2_", pro.Descripcion2);
                        cmd.Parameters.AddWithValue("color_", pro.Color);
                        cmd.Parameters.AddWithValue("talla_", pro.Talla);
                        cmd.Parameters.AddWithValue("totalpreprom2_", pro.Totalpreprom2);
                        cmd.Parameters.AddWithValue("codusuario_", pro.Codusuario);

                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        pro.CodProducto = Convert.ToInt32(cmd.Parameters["newid"].Value);

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
                    MySqlCommand cmd = new MySqlCommand("listadoproductos", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
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

        public static String SiglaUnidadBase(Int32 codUnd)
        {
            String uni = "";
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            MySqlDataReader dr = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    cmd = new MySqlCommand("SiglaUnidadBase", cn);
                    cmd.Parameters.AddWithValue("codUnd", codUnd);

                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            uni = dr.GetString(0);
                        }
                    }
                }
                return uni;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
        }



        public static DataTable listadoNuevos()
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listadoproductosnuevos", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
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


        public static DataTable busqueda(string nombre)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {


                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("busquedaproducto", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("nombre_", nombre);

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

        public static DataTable busquedaxfiltro(string nombre, string filtro)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {


                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("busquedaproductoxfiltro", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("nombre_", nombre);

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


        public static Producto CargaProducto(Int32 CodPro)
        {
            Producto pro = null;

            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    cmd = new MySqlCommand("MuestraProducto", cn);
                    cmd.Parameters.AddWithValue("codpro", CodPro);

                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            pro = new Producto();
                            pro.CodProducto = dr.GetInt32(0);

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


        public static Producto busquedaxnombre(string nombre)
        {
            Producto pro = null;

            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    cmd = new MySqlCommand("busquedaproductoxnombre", cn);
                    cmd.Parameters.AddWithValue("nombre_", nombre);

                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            pro = new Producto();
                            pro.CodProducto = dr.GetInt32(0);

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

        public static Producto busquedaxcod(int cod)
        {
            Producto pro = null;

            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    cmd = new MySqlCommand("busquedaproductoxcod", cn);
                    cmd.Parameters.AddWithValue("codproducto_", cod);

                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            pro = new Producto();
                            pro.CodProducto = dr.GetInt32(0);
                            pro.Descripcion = dr.GetString(7);
                            pro.Descripcion2 = dr.GetString(7);

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



        public static bool borrarTodo()
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("borrarproductos", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

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


        public static bool borrar(int codProducto)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("borrarproducto", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("codproducto_", codProducto);

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







    }
}
