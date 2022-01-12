using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;
using SGEDICALE.reportes;


namespace SGEDICALE.vista
{
    public partial class frmListaNotaCredito : DevComponents.DotNetBar.Office2007Form
    {
        public Usuario usureg { get; set; }
        public Empresa empresa { get; set; }
        private DataTable notas_ncc_ndb = null;
        private Comprobantee comprobante = null;

        public frmListaNotaCredito()
        {
            InitializeComponent();
        }

        private void frmListaNotaCredito_Load(object sender, EventArgs e)
        {
            try
            {
                dg_nota.AutoGenerateColumns = false;
                dt_fechainicio.Value = CComprobante.listar_fecha_actual();
                dt_fecha_fin.Value = CComprobante.listar_fecha_actual();
                cb_estado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_nota.Rows.Count > 0)
                {
                    dg_nota.MultiSelect = true;
                    dg_nota.SelectAll();
                    dg_nota.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                    DataObject dataObj = dg_nota.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);

                    dg_nota.MultiSelect = false;

                    MessageBox.Show("Puede copiarlo a cualquier editor de texto...", "Información");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_ver_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_nota.Rows.Count > 0)
                {
                    if (dg_nota.CurrentCell != null)
                    {
                        if (dg_nota.CurrentCell.RowIndex != -1)
                        {
                            comprobante = new Comprobantee()
                            {
                                CodComprobante = int.Parse(dg_nota.Rows[dg_nota.CurrentCell.RowIndex].Cells[codcomprobante.Index].Value.ToString())
                            };

                            if (Application.OpenForms["frm_NotadeCredito"] != null)
                            {
                                Application.OpenForms["frm_NotadeCredito"].Activate();
                            }
                            else
                            {
                                frm_NotadeCredito frm_venta = new frm_NotadeCredito();
                                frm_venta.comprobantee = comprobante;
                                frm_venta.Show();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "NotadeCredito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_anular_Click(object sender, EventArgs e)
        {
            string fechaactual = "";
            int _filas_afectadas = -1;

            try
            {
                if (dg_nota.Rows.Count > 0)
                {

                    if (dg_nota.CurrentCell != null)
                    {

                        if (dg_nota.CurrentCell.RowIndex != -1)
                        {

                            DialogResult respuesta = MessageBox.Show("¿Desea anular comprobante?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (respuesta == DialogResult.Yes)
                            {

                                fechaactual = CComprobante.listar_fecha_actual().ToShortDateString();

                                if (DateTime.Parse(dg_nota.Rows[dg_nota.CurrentCell.RowIndex].Cells[fechaemision.Index].Value.ToString()).ToShortDateString() == fechaactual)
                                {
                                    comprobante = new Comprobantee()
                                    {

                                        CodComprobante = int.Parse(dg_nota.Rows[dg_nota.CurrentCell.RowIndex].Cells[codcomprobante.Index].Value.ToString())
                                    };

                                    _filas_afectadas = CComprobante.anular_comprobante(comprobante, usureg);

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

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                listar_notas_xestado_xfecha();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }


        public void listar_notas_xestado_xfecha()
        {

            int estado = 0;

            try
            {
                switch (cb_estado.SelectedItem.ToString())
                {

                    case "REGISTRADO": estado = 1; break;
                    case "ANULADO": estado = 0; break;
                    case "APLICADA": estado = 2; break;
                }

                dg_nota.DataSource = null;
                notas_ncc_ndb = CComprobante.listar_notas_xestado_xfecha(
                        dt_fechainicio.Value,
                        dt_fecha_fin.Value,
                        estado
                    );

                if (notas_ncc_ndb != null)
                {
                    if (notas_ncc_ndb.Rows.Count > 0)
                    {
                        dg_nota.DataSource = notas_ncc_ndb;
                        dg_nota.Refresh();
                        total_venta();
                    }
                }
            }
            catch (Exception) { }
        }

        public void total_venta()
        {
            try
            {
                if (dg_nota.Rows.Count > 0)
                {

                    lb_total_soles.Text = (dg_nota.Rows.Cast<DataGridViewRow>().Where(
                                                                        x => int.Parse(x.Cells["codmoneda"].Value.ToString()) == 1

                                                                      ).Select(x => decimal.Parse(x.Cells["total"].Value.ToString())).Sum()).ToString();
                    lb_total_dolares.Text = (dg_nota.Rows.Cast<DataGridViewRow>().Where(
                                                                        x => int.Parse(x.Cells["codmoneda"].Value.ToString()) == 2

                                                                      ).Select(x => decimal.Parse(x.Cells["total"].Value.ToString())).Sum()).ToString();

                }
                else
                {

                    lb_total_soles.Text = "0.00";
                    lb_total_dolares.Text = "0.00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_total_soles.Text = "0.00";
            lb_total_dolares.Text = "0.00";
            dg_nota.DataSource = null;
            notas_ncc_ndb = null;
        }

        private void frmListaNotaCredito_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            try
            {
                listar_notas_xestado_xfecha();

                lbregistro.Text = dg_nota.Rows.Count + " registros";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_anular_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_ver_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            string fechaactual = "";
            int _filas_afectadas = -1;

            try
            {
                if (dg_nota.Rows.Count > 0)
                {

                    if (dg_nota.CurrentCell != null)
                    {

                        if (dg_nota.CurrentCell.RowIndex != -1)
                        {

                            DialogResult respuesta = MessageBox.Show("¿Desea anular comprobante?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (respuesta == DialogResult.Yes)
                            {

                                fechaactual = CComprobante.listar_fecha_actual().ToShortDateString();

                                if (DateTime.Parse(dg_nota.Rows[dg_nota.CurrentCell.RowIndex].Cells[fechaemision.Index].Value.ToString()).ToShortDateString() == fechaactual)
                                {
                                    comprobante = new Comprobantee()
                                    {

                                        CodComprobante = int.Parse(dg_nota.Rows[dg_nota.CurrentCell.RowIndex].Cells[codcomprobante.Index].Value.ToString())
                                    };

                                    _filas_afectadas = CComprobante.anular_comprobante(comprobante, usureg);

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

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_nota.Rows.Count > 0)
                {
                    if (dg_nota.CurrentCell != null)
                    {
                        if (dg_nota.CurrentCell.RowIndex != -1)
                        {
                            comprobante = new Comprobantee()
                            {
                                CodComprobante = int.Parse(dg_nota.Rows[dg_nota.CurrentCell.RowIndex].Cells[codcomprobante.Index].Value.ToString())
                            };

                            if (Application.OpenForms["frm_NotadeCredito"] != null)
                            {
                                Application.OpenForms["frm_NotadeCredito"].Activate();
                            }
                            else
                            {
                                frm_NotadeCredito frm_venta = new frm_NotadeCredito();
                                frm_venta.comprobantee = comprobante;
                                frm_venta.Show();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "NotadeCredito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {

                if (dg_nota.Rows.Count > 0)
                {

                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();

                    dt.Columns.Add("nombre", typeof(string));
                    dt.Columns.Add("fechaemision", typeof(DateTime));

                    dt.Columns.Add("numero", typeof(string));
                    dt.Columns.Add("descripcion", typeof(string));
                    dt.Columns.Add("total", typeof(decimal));
                    dt.Columns.Add("estado", typeof(string));
                    dt.Columns.Add("documentoreferencia", typeof(string));
                    dt.Columns.Add("fecha1", typeof(DateTime));
                    dt.Columns.Add("fecha2", typeof(DateTime));

                    foreach (DataGridViewRow dgv in dg_nota.Rows)
                    {
                        dt.Rows.Add(dgv.Cells["nombre"].Value,
                        Convert.ToDateTime(dgv.Cells["fechaemision"].Value),
                        dgv.Cells["numero"].Value,
                        dgv.Cells["descripcion"].Value,
                        dgv.Cells["total"].Value,
                        dgv.Cells["estado"].Value,
                        dgv.Cells["documentoreferencia"].Value,
                        dt_fechainicio.Text,
                        dt_fechainicio.Text);
                    }

                    ds.Tables.Add(dt);
                    ds.WriteXml("C:\\XML\\ListaNotasCreditoDicaleRPT.xml", XmlWriteMode.WriteSchema);

                    CRListaNotasCredito rpt = new CRListaNotasCredito();
                    frmRptListaNotasCredito frm = new frmRptListaNotasCredito();
                    rpt.SetDataSource(ds);
                    frm.crvListaNotas.ReportSource = rpt;
                    frm.Show();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;

            }
        }

        private void dg_nota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                string accion = "";
                int codcomprobante = 0;
                Comprobantee comprobante = null;

                if (dg_nota.Rows.Count >= 1 && e.RowIndex != -1)
                {
                    accion = dg_nota.CurrentCell.Value.ToString();

                    if (accion.ToString() == "Ver uso de nota")
                    {
                        codcomprobante = Convert.ToInt32(dg_nota.Rows[e.RowIndex].Cells["codcomprobante"].Value.ToString());
                    }

                    if (codcomprobante != 0)
                    {
                        frmMuestraPagosNotas frm_cpe = new frmMuestraPagosNotas(codcomprobante);
                        frm_cpe.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("No ha seleccionado un fila", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }
}
}
