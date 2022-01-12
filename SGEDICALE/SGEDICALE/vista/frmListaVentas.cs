using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;
using SGEDICALE.reportes;

namespace SGEDICALE.vista
{
    public partial class frmListaVentas : DevComponents.DotNetBar.Office2007Form
    {

        private Comprobantee comprobantee = null;
        private Usuario usuario = null;
        public frmListaVentas()
        {
            InitializeComponent();
        }

        private void frmListaVentas_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dtpFechaI.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;

            usuario = new Usuario();
            usuario.Usuarioid = Session.CodUsuario;

            txtpromotor.Focus();
            ActiveControl = txtpromotor;


            this.Cursor = Cursors.Default;
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listar_ventas_xestado_xfecha();
        }

        public void listar_ventas_xestado_xfecha()
        {

            int estado = 0;

            try
            {

                dg_venta.AutoGenerateColumns = false;
                dg_venta.DataSource = null;
                dg_venta.DataSource = CComprobante.listar_ventas_xestado_xfecha(
                        dtpFechaI.Value,
                        dtpFechaFin.Value
                    );


                lbregistro.Text = dg_venta.Rows.Count + " registros.";


                if (dg_venta.DataSource != null)
                {
                    total_venta();
                }

               
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void total_venta()
        {

            try
            {
                if (dg_venta.Rows.Count > 0)
                {

                    lb_total_soles.Text = (dg_venta.Rows.Cast<DataGridViewRow>().Where(
                                                                        x => int.Parse(x.Cells["codmoneda"].Value.ToString()) == 1

                                                                      ).Select(x => decimal.Parse(x.Cells["total"].Value.ToString())).Sum()).ToString();
                    lb_total_dolares.Text = (dg_venta.Rows.Cast<DataGridViewRow>().Where(
                                                                        x => int.Parse(x.Cells["codmoneda"].Value.ToString()) == 2

                                                                      ).Select(x => decimal.Parse(x.Cells["total"].Value.ToString())).Sum()).ToString();

                }
                else
                {

                    lb_total_soles.Text = "0.00";
                    lb_total_dolares.Text = "0.00";
                }
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                            comprobantee = new Comprobantee();

                            comprobantee.CodComprobante = Convert.ToInt32(dg_venta.Rows[dg_venta.CurrentCell.RowIndex].Cells["codcomprobante"].Value.ToString());
                     

                            if (Application.OpenForms["frmVenta"] != null)
                            {
                                Application.OpenForms["frmVenta"].Activate();
                            }
                            else
                            {
                                frmVenta frm_venta = new frmVenta();
                                //frm_venta.empresa = empresa;
                                frm_venta.comprobante = comprobantee;
                                //frm_venta.usureg = usureg;
                                frm_venta.Show();
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

        private void btn_anular_Click(object sender, EventArgs e)
        {
            string fechaactual = "";
            int _filas_afectadas = -1;
            string estado="";

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
                                MessageBox.Show("Comprobante ya fue anulado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            fechaactual = CComprobante.listar_fecha_actual().ToShortDateString();

                            if (DateTime.Parse(dg_venta.Rows[dg_venta.CurrentCell.RowIndex].Cells[fechaemision.Index].Value.ToString()).ToShortDateString() == fechaactual)
                            {


                                comprobantee = new Comprobantee();
                                comprobantee.CodComprobante = Convert.ToInt32(dg_venta.Rows[dg_venta.CurrentCell.RowIndex].Cells["codcomprobante"].Value.ToString());



                                _filas_afectadas = CComprobante.anular_comprobante(comprobantee, usuario);

                                if (_filas_afectadas > 0)
                                {
                                    MessageBox.Show("Comprobante anulado correctamente", "Información");
                                    btnBuscar.PerformClick();
                                }
                                else
                                {
                                    if (_filas_afectadas == -2)
                                    {
                                        MessageBox.Show("El comprobante se encuentra registrado en sunat...", "Información");
                                    }
                                    else if (_filas_afectadas == -3)
                                    {
                                        MessageBox.Show("Caja que contiene el documento esta cerrada...", "Información");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Problemas para anular comprobante", "Advertencia");
                                    }
                                }
                            }
                            else
                            {

                                MessageBox.Show("No se puede anular comprobantes de fechas anteriores...", "Advertencia");
                            }
                        }
                    }

                }
                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;

            }
        }

        private void frmListaVentas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Cursor = Cursors.Default;
                this.Close();
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
                    dt.Columns.Add("dni", typeof(string));
                    dt.Columns.Add("nombre", typeof(string));
                    dt.Columns.Add("fechaemision", typeof(DateTime));

                    dt.Columns.Add("comprobante", typeof(string));
                    dt.Columns.Add("descripcion", typeof(string));
                    dt.Columns.Add("total", typeof(decimal));
                    dt.Columns.Add("estado", typeof(string));

                    dt.Columns.Add("fecha1", typeof(DateTime));
                    dt.Columns.Add("fecha2", typeof(DateTime));
                    dt.Columns.Add("promotor", typeof(string));
                



                    foreach (DataGridViewRow dgv in dg_venta.Rows)
                    {
                        dt.Rows.Add(dgv.Cells["dni"].Value,
                        dgv.Cells["nombre"].Value,
                        Convert.ToDateTime(dgv.Cells["fechaemision"].Value),
                        dgv.Cells["comprobante"].Value,
                        dgv.Cells["descripcion"].Value,
                        dgv.Cells["total"].Value,
                        dgv.Cells["estado"].Value,
                        dtpFechaI.Text,
                        dtpFechaFin.Text,
                        txtpromotor.Text);
                    }

                    ds.Tables.Add(dt);
                    ds.WriteXml("C:\\XML\\ListaVentasDicaleRPT.xml", XmlWriteMode.WriteSchema);

                    CRListaVentas rpt = new CRListaVentas();
                    frmRptListaVentas frm = new frmRptListaVentas();
                    rpt.SetDataSource(ds);
                    frm.crvListaGuias.ReportSource = rpt;
                    frm.Show();
                }

         

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;

            }

        }

        private void txtpromotor_TextChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string nombre = "";

            nombre = txtpromotor.Text;

            if (nombre != "")
            {
                dg_venta.DataSource = null;
                dg_venta.DataSource = CComprobante.listar_ventas_xestado_xfecha_xpromotor(dtpFechaI.Value,dtpFechaFin.Value,nombre);
                lbregistro.Text = dg_venta.Rows.Count.ToString() + " registros.";
                dg_venta.Refresh();
            }
            

            this.Cursor = Cursors.Default;
        }
    }
}

  