using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;
using SGEDICALE.reportes;

namespace SGEDICALE.vista
{
    public partial class frm_listadoTicket : DevComponents.DotNetBar.Office2007Form
    {

        private Ticket ticket = null;
        private Usuario usuario = null;

        public frm_listadoTicket()
        {
            InitializeComponent();
        }

        private void frm_listadoTicket_Load(object sender, EventArgs e)
        {
            txtcliente.Focus();

            dtpFechaI.Value = DateTime.Now.AddDays(-1);
            dtpFechaFin.Value = DateTime.Now;

            usuario = new Usuario();
            usuario.Usuarioid = Session.CodUsuario;

            ActiveControl = txtcliente;

        }

        private void txtcliente_TextChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string nombre = "";

            nombre = txtcliente.Text;

            if (nombre != "")
            {
                dg_venta.DataSource = null;
                dg_venta.DataSource = CComprobante.listar_ventas_xestado_xfecha_xpromotor(dtpFechaI.Value, dtpFechaFin.Value, nombre);
                lbregistro.Text = dg_venta.Rows.Count.ToString() + " registros.";
                dg_venta.Refresh();
            }


            this.Cursor = Cursors.Default;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar_ticket_xestado_xfecha();
        }


        public void listar_ticket_xestado_xfecha()
        {

            int estado = 0;

            try
            {

                dg_venta.AutoGenerateColumns = false;
                dg_venta.DataSource = null;
                dg_venta.DataSource = CTicket.listar_ticket_xestado_xfecha(
                        dtpFechaI.Value,
                        dtpFechaFin.Value
                    );


                lbregistro.Text = dg_venta.Rows.Count + " registros.";


                if (dg_venta.DataSource != null)
                {
                    total_venta();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }



        public void total_venta()
        {

            try
            {
                if (dg_venta.Rows.Count > 0)
                {

                    lb_total_soles.Text = (dg_venta.Rows.Cast<DataGridViewRow>().Select(x => decimal.Parse(x.Cells["total"].Value.ToString())).Sum()).ToString();
                }
                else
                {

                    lb_total_soles.Text = "0.00";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void frm_listadoTicket_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_venta.Rows.Count > 0)
                {
                    if (dg_venta.CurrentCell != null)
                    {
                        if (dg_venta.CurrentCell.RowIndex != -1)
                        {
                            ticket = new Ticket();

                            ticket.CodTicket = Convert.ToInt32(dg_venta.Rows[dg_venta.CurrentCell.RowIndex].Cells["codticket"].Value.ToString());


                            if (Application.OpenForms["frm_Ticket"] != null)
                            {
                                Application.OpenForms["frm_Ticket"].Activate();
                            }
                            else
                            {
                                frm_Ticket frm_t = new frm_Ticket();
                                //frm_venta.empresa = empresa;
                                frm_t.ticket = ticket;
                                //frm_venta.usureg = usureg;
                                frm_t.Show();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {

                if (dg_venta.Rows.Count > 0)
                {

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("docidentidad", typeof(string));
                    dt.Columns.Add("nombreyapellido", typeof(string));
                    dt.Columns.Add("fecha", typeof(DateTime));

                    dt.Columns.Add("documento", typeof(string));
                    dt.Columns.Add("total", typeof(decimal));
                    dt.Columns.Add("cuenta", typeof(string));
                    dt.Columns.Add("estado", typeof(string));
                    dt.Columns.Add("fecha1", typeof(DateTime));
                    dt.Columns.Add("fecha2", typeof(DateTime));
                    dt.Columns.Add("cliente", typeof(string));


                    foreach (DataGridViewRow dgv in dg_venta.Rows)
                    {
                        dt.Rows.Add(dgv.Cells["docidentidad"].Value,
                        dgv.Cells["nombreyapellido"].Value,
                        Convert.ToDateTime(dgv.Cells["fecha"].Value),
                        dgv.Cells["documento"].Value,
                        dgv.Cells["total"].Value,
                        dgv.Cells["cuenta"].Value,
                        dgv.Cells["estado"].Value,
                        dtpFechaI.Text,
                        dtpFechaFin.Text,
                        txtcliente.Text);
                    }

                    ds.Tables.Add(dt);
                    ds.WriteXml("C:\\XML\\ListaTicketsDicaleRPT.xml", XmlWriteMode.WriteSchema);

                    CRListaTicket rpt = new CRListaTicket();
                    FrmRptListaTickets frm = new FrmRptListaTickets();
                    rpt.SetDataSource(ds);
                    frm.crvListaTickets.ReportSource = rpt;
                    frm.Show();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;

            }
        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            string fechaactual = "";
            int _filas_afectadas = -1;
            string estado = "";

            try
            {
                if (dg_venta.Rows.Count > 0)
                {

                    if (dg_venta.CurrentCell != null)
                    {

                        if (dg_venta.CurrentCell.RowIndex != -1)
                        {

                            estado = dg_venta.Rows[dg_venta.CurrentCell.RowIndex].Cells["estado"].Value.ToString();

                            if (estado == "ANULADO")
                            {
                                MessageBox.Show("Ticket ya fue anulado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            ticket = new Ticket();
                            ticket.CodTicket = Convert.ToInt32(dg_venta.Rows[dg_venta.CurrentCell.RowIndex].Cells["codticket"].Value.ToString());



                            _filas_afectadas = CTicket.anular_ticket(ticket, usuario);

                            if (_filas_afectadas > 0)
                            {
                                MessageBox.Show("Ticket anulado correctamente", "Información");
                                btnBuscar.PerformClick();
                            }
                            else
                            {

                                MessageBox.Show("Problemas para anular ticket", "Advertencia");

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;

            }
        }
    }
}
