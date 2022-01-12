using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;
using SGEDICALE.reportes;
using SGEDICALE.reportes.clsReportes;

namespace SGEDICALE.vista
{
    public partial class frmCajaMovimiento : DevComponents.DotNetBar.Office2007Form
    {

        public int _Cajaid { get; set; }
        public int Estado { get; set; }
        Caja caja = null;
        private DataTable cajamovimientos = null;
        public Usuario usureg { get; set; }
        private DataSet data = null;
        public bool autorizado { get; set; }
     
        public frmCajaMovimiento()
        {
            InitializeComponent();
        }

        private void frmCajaMovimiento_Load(object sender, EventArgs e)
        {
            try
            {

              
               
                dg_resultado.DefaultCellStyle.Font = new Font("Segoe UI", 10);
                dg_resultado.AutoGenerateColumns = false;
                dg_resultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                if (Estado == 2)
                {
                    btn_cerrar_caja.Enabled = false;
                    caja = new Caja() { Codcaja = _Cajaid, Estado = Estado };
                    cargar_caja_movimiento();
                    total_caja();
                }
                else
                {
                    _Cajaid = -1;
                    _Cajaid = CCaja.buscar_caja_abierta(usureg.Usuarioid);

                    if (_Cajaid > 0)
                    {

                        caja = new Caja() { Codcaja = _Cajaid, Estado = Estado };
                        cargar_caja_movimiento();
                        total_caja();
                    }
                }
            }
            catch (Exception) { }
        }

        private void frmCajaMovimiento_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public void total_caja()
        {
            try
            {
                caja = CCaja.total_caja(caja);

                if (caja != null)
                {

                    txt_apertura.Text = caja.Montoapertura.ToString();
                    txt_t_efectivo.Text = caja.Totalefectivo.ToString();
                    txt_t_deposito.Text = caja.Totaldeposito.ToString();
                    txt_t_transferencia.Text = caja.Totaltransferencia.ToString();
                    txt_t_tarjeta.Text = caja.Totaltarjeta.ToString();
                    txt_cierre.Text = caja.Montocierre.ToString();
                    txt_total_nota.Text = caja.Totalnota.ToString();
                    txt_saldo.Text = caja.Totaldisponible.ToString();

                }
            }
            catch (Exception) { }
        }


        public void cargar_caja_movimiento()
        {
            try
            {

                dg_resultado.DataSource = null;
                cajamovimientos = CCaja.listar_caja_movimiento(caja);

                if (cajamovimientos != null)
                {

                    if (cajamovimientos.Rows.Count > 0)
                    {

                        dg_resultado.DataSource = cajamovimientos;
                    }

                }
            }
            catch (Exception) { }
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_resultado.Rows.Count > 0)
                {
                    dg_resultado.MultiSelect = true;
                    dg_resultado.SelectAll();
                    dg_resultado.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
                    DataObject dataObj = dg_resultado.GetClipboardContent();
                    if (dataObj != null)
                        Clipboard.SetDataObject(dataObj);

                    dg_resultado.MultiSelect = false;

                    MessageBox.Show("Puede copiarlo a cualquier editor de texto...", "Información");
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btn_cerrar_caja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_resultado.Rows.Count > 0)
                {
                    caja = new Caja() { Codcaja = _Cajaid, Estado = Estado };

                    if (caja != null)
                    {
                        DialogResult respuesta = MessageBox.Show("¿Desea cerra caja?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (respuesta == DialogResult.Yes)
                        {
                            if (CCaja.cerrar_caja(caja, usureg) > 0)
                            {
                                MessageBox.Show("Caja cerrada correctamente...", "Información");
                                btn_cerrar_caja.Enabled = false;

                                data = CCaja.reporte_caja_movimiento(caja);

                                if (data != null)
                                {
                                    
                                    frmCierreCaja _frm = new frmCierreCaja();
                                    CRCierreCaja _rpt = new CRCierreCaja();
                                    _rpt.SetDataSource(data);
                                    _frm.crystal_cierrecaja.ReportSource = _rpt;
                                    _frm.ShowDialog(this);
                                    _rpt.Close();
                                    _rpt.Dispose();
                                    

                                }
                            }
                            else
                            {
                                MessageBox.Show("Problemas para cerrar caja...", "Advertencia");
                            }
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void btn_detalle_Click(object sender, EventArgs e)
        {
            try
            {

                caja = new Caja() { Codcaja = _Cajaid, Estado = Estado };

                if (caja != null)
                {
                    data = CCaja.reporte_caja_movimiento(caja);
                }

                if (dg_resultado.Rows.Count > 0 && data != null)
                {

                    
                    frmCierreCaja _frm = new frmCierreCaja();
                    CRCierreCaja _rpt = new CRCierreCaja();
                    _rpt.SetDataSource(data);
                    _frm.crystal_cierrecaja.ReportSource = _rpt;
                    _frm.ShowDialog(this);
                    _rpt.Close();
                    _rpt.Dispose();

                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_comprobante_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txt_comprobante.CharacterCasing = CharacterCasing.Upper;

                if (txt_comprobante.Text.Length > 0)
                {

                    if (_Cajaid != 0)
                    {
                        listar_movimiento_caja_xcomprobante();
                    }
                }
            }
            catch (Exception) { }
        }


        public void listar_movimiento_caja_xcomprobante()
        {

            try
            {
                dg_resultado.DataSource = null;
                cajamovimientos = CCaja.listar_movimiento_caja_xcomprobante(
                                                                                new Caja() { Codcaja = _Cajaid, Estado = Estado },
                                                                                new Comprobantee()
                                                                                {
                                                                                    Scomprobante = txt_comprobante.Text
                                                                                }

                                                                             );

                if (cajamovimientos != null)
                {
                    if (cajamovimientos.Rows.Count > 1)
                    {
                        dg_resultado.DataSource = cajamovimientos;
                    }
                    else
                    {

                        if (Estado == 2)
                        {
                            btn_cerrar_caja.Enabled = false;
                            caja = new Caja() { Codcaja = _Cajaid, Estado = Estado };
                            cargar_caja_movimiento();
                            total_caja();
                        }
                        else
                        {
                            _Cajaid = -1;
                            _Cajaid = CCaja.buscar_caja_abierta(usureg.Usuarioid);

                            if (_Cajaid > 0)
                            {

                                caja = new Caja() { Codcaja = _Cajaid, Estado = Estado };
                                cargar_caja_movimiento();
                                total_caja();
                            }
                        }

                    }

                }
            }
            catch (Exception) { }
        }

        private void btn_anular_tipo_cobro_Click(object sender, EventArgs e)
        {
            int filas_afectadas = -1;

            try
            {
                if (dg_resultado.Rows.Count > 0)
                {
                    if (dg_resultado.CurrentCell != null)
                    {
                        if (dg_resultado.CurrentCell.RowIndex != -1)
                        {

                            if (int.Parse(dg_resultado.Rows[dg_resultado.CurrentCell.RowIndex].Cells[cobroid.Index].Value.ToString()) > 0)
                            {

                                DialogResult dlgResult = MessageBox.Show("Esta seguro que desea anular el cobro", "Anular Cobro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dlgResult == DialogResult.No)
                                {
                                    return;
                                }
                                else
                                { 


                                    filas_afectadas = CCobro.anular_cobro(
                                                            new Cobro()
                                                            {
                                                                Codcobro = int.Parse(dg_resultado.Rows[dg_resultado.CurrentCell.RowIndex].Cells[cobroid.Index].Value.ToString())
                                                            },
                                                            usureg
                                                        );
                                if (filas_afectadas > 0)
                                {
                                    if (Estado == 2)
                                    {
                                        btn_cerrar_caja.Enabled = false;
                                        caja = new Caja() { Codcaja = _Cajaid, Estado = Estado };
                                        cargar_caja_movimiento();
                                        total_caja();
                                    }
                                    else
                                    {
                                        _Cajaid = -1;
                                        _Cajaid = CCaja.buscar_caja_abierta(usureg.Usuarioid);

                                        if (_Cajaid > 0)
                                        {

                                            caja = new Caja() { Codcaja = _Cajaid, Estado = Estado };
                                            cargar_caja_movimiento();
                                            total_caja();
                                        }
                                    }

                                }
                                else
                                {

                                    MessageBox.Show("Problemas para anular el cobro...", "Advertencia");
                                }
                            }

                            }
                        }
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
