using System;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using SGEDICALE.clases;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;

namespace SGEDICALE.modelo
{
    public class MPromotor
    {

        private static MySqlCommand cmd = null;
        private static MySqlDataReader dr = null;
        private static MySqlDataAdapter adap = null;
        private static MySqlTransaction tra = null;
        private static DataTable tabla = null;

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


        public static Promotor buscarxcodigocomprobante(int codigopedido)
        {
            Promotor pro = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {

                    cn.Open();


                    using (cmd = new MySqlCommand("buscarpromotorxcodcomprobante", cn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("codigo_", codigopedido);

                        dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                pro = new Promotor();
                                pro.DocumentoIdentidad = new TipoDocumentoIdentidad();

                                pro.CodPromotor = dr.GetInt32(0);
                                pro.Nombrecompleto = dr.GetString(1);
                                pro.Dni = dr.GetString(2);
                                pro.Email = dr.GetString(3);


                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

            return pro;
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


        public static bool insertar(Promotor pro)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            bool listo = true;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("GuardaPromotor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("codsap_", pro.CodSap);
                        cmd.Parameters.AddWithValue("nombre_", pro.Nombrecompleto);
                        cmd.Parameters.AddWithValue("depa_", pro.Departamento);
                        cmd.Parameters.AddWithValue("pro_", pro.Provincia);
                        cmd.Parameters.AddWithValue("dis_", pro.Distrito);
                        cmd.Parameters.AddWithValue("direc_", pro.Direccion);
                        cmd.Parameters.AddWithValue("dni_", pro.Dni);
                        cmd.Parameters.AddWithValue("telefono1_", pro.Telefono1);
                        cmd.Parameters.AddWithValue("telefono2_", pro.Telefono2);
                        cmd.Parameters.AddWithValue("celular1_", pro.Celular1);
                        cmd.Parameters.AddWithValue("celular2_", pro.Celular2);
                        cmd.Parameters.AddWithValue("email_", pro.Email);
                        cmd.Parameters.AddWithValue("fechanac_", pro.Fechanac);
                        cmd.Parameters.AddWithValue("razon_", pro.Razonsocial);
                        cmd.Parameters.AddWithValue("genero_", pro.Genero);
                        cmd.Parameters.AddWithValue("estadocivil_", pro.Estadocivil);
                        cmd.Parameters.AddWithValue("regimen_", pro.Regimen);
                        cmd.Parameters.AddWithValue("prospecto_", pro.Cliprospecto);
                        cmd.Parameters.AddWithValue("espacios_", pro.Espaciosblanco);
                        cmd.Parameters.AddWithValue("codtipopersona_", pro.TipoPersona.Codtipopersona);

                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        pro.CodPromotor = Convert.ToInt32(cmd.Parameters["newid"].Value);


                        if (pro.CodPromotor <= 0)
                        {
                            listo = true;
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
                    MySqlCommand cmd = new MySqlCommand("listadopromotores", cn);

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


        public static List<TipoPersona> listar_tipo_promotor()
        {

            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            List<TipoPersona> lista_tipodociden = null;
            TipoPersona tipodociden = null;
            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("listar_tipo_persona", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        lista_tipodociden = new List<TipoPersona>();

                        while (dr.Read())
                        {
                            tipodociden = new TipoPersona()
                            {
                                Codtipopersona = (int)dr["codtipopersona"],
                                Descripcion = (string)dr["descripcion"]
                            };

                            lista_tipodociden.Add(tipodociden);
                        }
                    }
                }
                return lista_tipodociden;
            }
            catch (MySqlException ex)
            {
                return lista_tipodociden;
                throw ex;
            }

        }



        public static DataTable listadoFiltro(int filtro)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listadopromotoresfiltro", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new MySqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("filtro_", filtro);
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



        public static DataTable listadorepetidos()
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listadopromotoresrepetidos", cn);

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

        public static DataTable listadorepetidosxEmail()
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listadopromotoresrepetidosxEmail", cn);

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


        public static DataTable busquedarepetidos(string nombre)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("busquedapromotorrepetidos", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("nombre_", nombre);

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

        public static DataTable busquedarepetidosxEmail(string nombre)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("busquedapromotorrepetidosxEmail", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("nombre_", nombre);

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


        public static Boolean update(Promotor pro)
        {

            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("actualizapromotor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("codpro_", pro.CodPromotor);
                        cmd.Parameters.AddWithValue("nombre_", pro.Nombrecompleto);
                        cmd.Parameters.AddWithValue("direc_", pro.Direccion);
                        cmd.Parameters.AddWithValue("codtipodocumento_", pro.DocumentoIdentidad.Idtipodocumentoidentidad);
                        cmd.Parameters.AddWithValue("dni_", pro.Dni);
                        cmd.Parameters.AddWithValue("telefono1_", pro.Telefono1);
                        cmd.Parameters.AddWithValue("fechanac_", pro.Fechanac);
                        cmd.Parameters.AddWithValue("estado_", pro.Estado);
                        cmd.Parameters.AddWithValue("email_", pro.Email);
                        cmd.Parameters.AddWithValue("codtipopersona_", pro.TipoPersona.Codtipopersona);
                        cmd.Parameters.AddWithValue("razonsocial_", pro.Razonsocial);
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
            }
            catch (MySqlException ex)
            {
                return false;
                throw ex;

            }
        }


        public static DataTable listado2()
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("listadopromotores2", cn);

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
                    MySqlCommand cmd = new MySqlCommand("busquedapromotor", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("nombre_", nombre);

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

        public static DataTable busquedafiltro(string nombre, int filtro)
        {
            MySqlDataAdapter da;
            MySqlConnection cn = null;
            DataTable dt = new DataTable();

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();
                    MySqlCommand cmd = new MySqlCommand("busquedapromotorfiltro", cn);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("nombre_", nombre);
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



        public static bool insertar2(Promotor pro)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            bool listo = true;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();


                    using (cmd = new MySqlCommand("GuardaPromotor2", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("codsap_", pro.CodSap);
                        cmd.Parameters.AddWithValue("nombre_", pro.Nombrecompleto);
                        cmd.Parameters.AddWithValue("direc_", pro.Direccion);
                        cmd.Parameters.AddWithValue("codtipodocumento_", pro.DocumentoIdentidad.Idtipodocumentoidentidad);
                        cmd.Parameters.AddWithValue("dni_", pro.Dni);
                        cmd.Parameters.AddWithValue("telefono1_", pro.Telefono1);
                        cmd.Parameters.AddWithValue("fechanac_", pro.Fechanac);
                        cmd.Parameters.AddWithValue("estado_", pro.Estado);
                        cmd.Parameters.AddWithValue("email_", pro.Email);
                        cmd.Parameters.AddWithValue("codtipopersona_", pro.TipoPersona.Codtipopersona);
                        cmd.Parameters.AddWithValue("razonsocial_", pro.Razonsocial);


                        cmd.Parameters.AddWithValue("newid", 0).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();
                        pro.CodPromotor = Convert.ToInt32(cmd.Parameters["newid"].Value);


                        if (pro.CodPromotor <= 0)
                        {
                            listo = true;
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



        public static Promotor buscarxcodigo(int codigopedido)
        {
            Promotor pro = null;
            MySqlDataReader dr = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;

            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                { 
                    
                    cn.Open();


                    using (cmd = new MySqlCommand("buscarpromotorxcodigo", cn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("codigo_", codigopedido);

                        dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {

                                pro = new Promotor();
                                pro.DocumentoIdentidad = new TipoDocumentoIdentidad();

                                pro.CodPromotor = dr.GetInt32(0);

                                if (!dr.IsDBNull(1))
                                {

                                    pro.CodSap = dr.GetString(1);
                                }

                                pro.Nombrecompleto = dr.GetString(2);
                                pro.Direccion = dr.GetString(6);
                                pro.Dni = dr.GetString(7);


                                if (!dr.IsDBNull(15))
                                {

                                    pro.Razonsocial = dr.GetString(15);
                                }



                                pro.DocumentoIdentidad.Idtipodocumentoidentidad = dr.GetInt32(21);
                                pro.DocumentoIdentidad.Descripcion = dr.GetString(22);
                                pro.DocumentoIdentidad.Codsunat = dr.GetString(23);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
                throw ex;
            }

            return pro;
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


                    using (cmd = new MySqlCommand("borrarpromotores", cn))
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

        public static bool borrar(int codpromotor)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;


            try
            {

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    using (cmd = new MySqlCommand("borrarpromotor", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("codpromotor_", codpromotor);

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

        public static Promotor buscar_promotorxnumerodocumento(Promotor cliente)
        {
            Promotor cli = null;
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            try
            {
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("buscar_promotorxnumerodocumento", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new MySqlParameter("@_numero", MySqlDbType.VarChar));
                    cmd.Parameters[0].Value = cliente.Dni;
                    dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            cli = new Promotor()
                            {

                                CodPromotor = (int)dr["codPromotor"],
                                DocumentoIdentidad = new TipoDocumentoIdentidad()
                                {
                                    Idtipodocumentoidentidad = (int)dr["coddocumentoidentidad"],
                                    Descripcion = (string)dr["descripcion"],
                                    Codsunat = (string)dr["codsunat"]
                                },

                                Nombrecompleto = (string)dr["nombre"],
                                Dni = (string)dr["dni"],
                                Direccion = (string)dr["direccion"]
                            };
                        }
                    }
                }
                return cli;
            }
            catch (MySqlException ex)
            {
                return cli;
                throw ex;
            }
        }
    }
}
