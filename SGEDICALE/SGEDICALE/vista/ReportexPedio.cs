using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using SGEDICALE.reportes;
using SGEDICALE.reportes.clsReportes;
using System.Linq;

namespace SGEDICALE.vista
{
    public partial class ReportexPedio : DevComponents.DotNetBar.Office2007Form
    {
        public ReportexPedio()
        {
            InitializeComponent();
        }

        private void ReportexPedio_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            llenacombos();
            cbMes.SelectedValue = DateTime.Now.Month;

            this.Cursor = Cursors.Default;
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;


                string numeroPedido = string.Empty;
                numeroPedido = cbPedido.SelectedValue.ToString();


                DataSet jes = new DataSet();
                frmRptVentaxPedido frm = new frmRptVentaxPedido();
                CRReporteVentasxPedido rpt = new CRReporteVentasxPedido();

                rpt.Load("CRReporteVentasxPedido.rpt");
                jes = clsReporteFactura.ReporteVentaxNumeroPedido(numeroPedido);


                rpt.SetDataSource(jes);
                frm.crvReporteVentaxPedido.ReportSource = rpt;
                frm.ShowDialog();



                rpt.Close();
                rpt.Dispose();


                this.Cursor = Cursors.Default;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se encontro el siguiente problema" + ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }

        }

        private void llenacombos()
        {
            DataTable dt;
            dt = new DataTable("Tabla");

            dt.Columns.Add("Codigo");
            dt.Columns.Add("Descripcion");

            DataRow dr;

            dr = dt.NewRow(); dr[0] = "1"; dr[1] = "ENERO"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr[0] = "2"; dr[1] = "FEBRERO"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr[0] = "3"; dr[1] = "MARZO"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr[0] = "4"; dr[1] = "ABRIL"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr[0] = "5"; dr[1] = "MAYO"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr[0] = "6"; dr[1] = "JUNIO"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr[0] = "7"; dr[1] = "JULIO"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr[0] = "8"; dr[1] = "AGOSTO"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr[0] = "9"; dr[1] = "SETIEMBRE"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr[0] = "10"; dr[1] = "OCTUBRE"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr[0] = "11"; dr[1] = "NOVIEMBRE"; dt.Rows.Add(dr);
            dr = dt.NewRow(); dr[0] = "12"; dr[1] = "DICIEMBRE"; dt.Rows.Add(dr);

            cbMes.DataSource = dt;
            cbMes.ValueMember = "Codigo";
            cbMes.DisplayMember = "Descripcion";

            cbMes_SelectionChangeCommitted(null,null);

            DataTable dt1 = new DataTable("Tabla1");

            dt1.Columns.Add("Codigo");
            dt1.Columns.Add("Descripcion");

            DataRow dr1;

            dr1 = dt1.NewRow(); dr1[0] = "2020"; dr1[1] = "2020"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2021"; dr1[1] = "2021"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2022"; dr1[1] = "2022"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2023"; dr1[1] = "2023"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2024"; dr1[1] = "2024"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2025"; dr1[1] = "2025"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2026"; dr1[1] = "2026"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2027"; dr1[1] = "2027"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2028"; dr1[1] = "2028"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2029"; dr1[1] = "2029"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2030"; dr1[1] = "2030"; dt1.Rows.Add(dr1);


        }

        private void cbMes_SelectionChangeCommitted(object sender, EventArgs e)
        {

            TraerPedido();


        }


        public void TraerPedido()
        {

            try
            {
                string mes = cbMes.SelectedValue.ToString();

                DateTime fecha = Convert.ToDateTime(("01" + "/" + mes + "/" + cbAño.Value.Year).ToString());

                cbPedido.DataSource = CPedido.cargarComboPedidoxMes(fecha.Date);
                cbPedido.ValueMember = "numeropedido";
                cbPedido.DisplayMember = "numeropedido";
                cbPedido.Refresh();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbAño_ValueChanged(object sender, EventArgs e)
        {
            TraerPedido();
        }

        private void ReportexPedio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
