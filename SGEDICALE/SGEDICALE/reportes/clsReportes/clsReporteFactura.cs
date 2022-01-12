using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using SGEDICALE.modelo;

namespace SGEDICALE.reportes.clsReportes
{
    public class clsReporteFactura
    {



        public static DataSet ReportNotaCreditoVenta(Int32 cod, Int32 codAlmacen)
        {

            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            DataSet set = null;
            MySqlDataAdapter adap = null;


            try
            {
                set = new DataSet();
                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    cmd = new MySqlCommand("ReporteNotaCreditoVenta", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 150000;
                    cmd.Parameters.AddWithValue("codnota", cod);
                    cmd.Parameters.AddWithValue("codalma", codAlmacen);
                    adap = new MySqlDataAdapter(cmd);
                    adap.Fill(set, "dt_NotaCreditoVenta");



                    set.WriteXml("C:\\XML\\NotaCreditoVentaDicaleRPT.xml", XmlWriteMode.WriteSchema);
                }
                return set;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
      
        }

        public static DataSet ReporteVentaxNumeroPedido(string numPedido)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            DataSet set = null;
            MySqlDataAdapter adap = null;


            try
            {
                set = new DataSet();

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    using (cmd = new MySqlCommand("ReporteVentasxPedido", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 250000;
                        cmd.Parameters.AddWithValue("numpedido_", numPedido);
                        adap = new MySqlDataAdapter(cmd);
                        adap.Fill(set, "dtVenta");
                        set.WriteXml("C:\\XML\\ReporteVentaPedidoRPT.xml", XmlWriteMode.WriteSchema);

                    }
                }
                return set;
            }
            catch (MySqlException ex)
            {

                throw ex;
            }
        }

        public static DataSet ReporteFactura2(Int32 codVenta)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            DataSet set = null;
            MySqlDataAdapter adap = null;


            try
            {
                set = new DataSet();

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    using (cmd = new MySqlCommand("ReporteFactura2", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 250000;
                        cmd.Parameters.AddWithValue("codcomprobante_", codVenta);
                        adap = new MySqlDataAdapter(cmd);
                        adap.Fill(set, "dtFactura");
                        set.WriteXml("C:\\XML\\FacturaDicaleRPT2.xml", XmlWriteMode.WriteSchema);

                    }
                }
                return set;
            }
            catch (MySqlException ex)
            {
              
                throw ex;
            }
        }


        public static DataSet ReporteTicket(Int32 codticket)
        {
            MySqlConnection cn = null;
            MySqlCommand cmd = null;
            DataSet set = null;
            MySqlDataAdapter adap = null;


            try
            {
                set = new DataSet();

                using (cn = new MySqlConnection(Conexion.cadenaConexion))
                {
                    cn.Open();

                    using (cmd = new MySqlCommand("ReporteTicket", cn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 1500000;
                        cmd.Parameters.AddWithValue("codticket_", codticket);
                        adap = new MySqlDataAdapter(cmd);
                        adap.Fill(set, "dtTicket");
                        set.WriteXml("C:\\XML\\TicketDicaleRPT.xml", XmlWriteMode.WriteSchema);

                    }
                }
                return set;
            }
            catch (MySqlException ex)
            {

                throw ex;
            }
        }




    }
}
