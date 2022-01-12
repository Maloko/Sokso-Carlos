using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;
using SGEDICALE.reportes;
using SGEDICALE.reportes.clsReportes;
using System.IO;
using System.Drawing.Printing;
using SGEDICALE.vista;

namespace SGEDICALE.vista
{
    public partial class frmNuevaVenta : DevComponents.DotNetBar.Office2007Form
    {

        public Byte[] LogoEmp { get; set; }

        private List<Serie> listaseries = null;
        public Pedido pedido1;
        Promotor promo = null;
        Pedido pedido = null;
        public Comprobantee comprobante = null;

        List<dynamic> listatipoimpuesto;
        private DataTable ticketfacturar = null;

        Caja caja = null;
        private bool lectura = false;

        private List<DiscrepanciaNotaCredito> lista_discrepancia_ncc = null;
        private Comprobantee notacredito = null;
        private List<Serie> lista_serie = null;
        private Usuario usuario = null;

        SGEDICALE.SunatFacElec.Facturacion facturacion = new SunatFacElec.Facturacion();

        public int respuesta = 0;

        public Byte[] firmadigital { get; set; }

        public frmNuevaVenta()
        {
            InitializeComponent();
        }

        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            cbTDocumento.Enabled = true;
            btnPago.Enabled = true;

            dtpFecha.Value = DateTime.Now.Date;


            usuario = new Usuario();
            usuario.Usuarioid = Session.CodUsuario;
            cargarmoneda();
            cargartipoimpuesto();
            cargarformapago();
            cargartipocomprobante();
            listar_discrepancia_ncc();
            lectura = true;

            cbTDocumento.Enabled = false;

            dtpFecha.Enabled = false;
            txtDireccion.ReadOnly = true;
            txtcliente.ReadOnly = true;
            txttipocambio.ReadOnly = true;
            txtCorrelativo.ReadOnly = true;

            cboMoneda.Enabled = false;
            cboTiempoIMpuesto.Enabled = false;
            cbFormaPago.Enabled = false;
            txtcodcliente.ReadOnly = true;

            if (comprobante != null)
            {

                btnGuardar.Enabled = false;
                btnAñadir.Enabled = false;
                btnEliminar.Enabled = false;
                txtcodcliente.Enabled = false;
                txtcliente.Enabled = false;
                txtDireccion.Enabled = false;

                //MONEDA
                if (comprobante.Codmoneda != 0)
                {
                    cboMoneda.SelectedValue = comprobante.Codmoneda;
                }

                cboMoneda_SelectionChangeCommitted(null, null);


                //FORMA DE PAGO
                if (comprobante.Formapago != 0)
                {
                    cbFormaPago.SelectedValue = comprobante.Formapago;
                }

                cbFormaPago.Refresh();


                //TIPOCOMPROBANTE
                if (comprobante.CodTipoComprobante != 0)
                {
                    cbTDocumento.SelectedValue = comprobante.CodTipoComprobante;
                }

                cbTDocumento_SelectionChangeCommitted(null, null);


                listar_detalle_comprobante_xidcomprobante();

            }


            this.Cursor = Cursors.Default;
        }

        public void listar_detalle_comprobante_xidcomprobante()
        {



            try
            {
                dgvdetalle.AutoGenerateColumns = false;

                ticketfacturar = CComprobante.listar_detalle_comprobante_xidcomprobante(comprobante);
                comprobante = CComprobante.buscacomprobante(comprobante.CodComprobante);

                if (comprobante != null && ticketfacturar != null)
                {

                    txtsubtotal.Text = comprobante.Subtotal.ToString();
                    txtIgv.Text = comprobante.Igv.ToString();
                    txttotal.Text = comprobante.Total.ToString();
                    dtpFecha.Value = comprobante.Fechaemision;
                    txtCorrelativo.Text = comprobante.Scomprobante;


                    cargarpromotor(comprobante.Codpromotor);


                    if (ticketfacturar.Rows.Count > 0)
                    {
                        dgvdetalle.DataSource = ticketfacturar;
                        lbregistro.Text = dgvdetalle.Rows.Count + " registros";
                        dgvdetalle.Refresh();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;
                return;
            }

        }


        public void cargarpromotor(int codpromotor)
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {

                promo = CPromotor.buscarxcodigo(codpromotor);

                if (promo != null)
                {

                    txtcodcliente.Text = promo.CodPromotor.ToString();
                    txtcliente.Text = promo.Nombrecompleto;
                    txtDireccion.Text = promo.Direccion;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }





        public void cargarmoneda()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                cboMoneda.DataSource = null;
                cboMoneda.DataSource = CMoneda.CargaMonedasHabiles();
                cboMoneda.ValueMember = "codMoneda";
                cboMoneda.DisplayMember = "descripcion";
                cboMoneda.SelectedIndex = 0;

                cboMoneda_SelectionChangeCommitted(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        public void listar_discrepancia_ncc()
        {
            try
            {
                lista_discrepancia_ncc = CDiscrepanciaNotaCredito.listar_discrepancia_ncc();
            }
            catch (Exception) { }
        }




        public void cargartipoimpuesto()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {

                listatipoimpuesto = new List<dynamic>
                {

                    new {codigo=10,descripcion="GRAVADO"},
                    new {codigo=20,descripcion="EXONERADO"},
                    new {codigo=30,descripcion="INAFECTO"},
                    new {codigo=21,descripcion="GRATUITA"}

                };

                cboTiempoIMpuesto.DataSource = listatipoimpuesto;
                cboTiempoIMpuesto.ValueMember = "codigo";
                cboTiempoIMpuesto.DisplayMember = "descripcion";

                cboTiempoIMpuesto.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        public void cargarformapago()
        {


            this.Cursor = Cursors.WaitCursor;
            try
            {
                cbFormaPago.DataSource = null;
                cbFormaPago.DataSource = CPago.CargaFormaPagos();
                cbFormaPago.ValueMember = "codFormaPago";
                cbFormaPago.DisplayMember = "descripcion";
                cbFormaPago.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        public void cargartipocomprobante()
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {
                cbTDocumento.DataSource = null;
                cbTDocumento.DataSource = CTipoComprobante.cargarTipoComprobante();
                cbTDocumento.ValueMember = "codtipocomprobante";
                cbTDocumento.DisplayMember = "nombre";

                cbTDocumento_SelectionChangeCommitted(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }




        private void cboMoneda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboMoneda != null)
            {
                if (cboMoneda.Items.Count > 0)
                {
                    tipo_cambio();
                }
            }
        }

        public void tipo_cambio()
        {
            TipoCambio tipocambio = CTipoCambio.listartipocambioxmoneda(Convert.ToInt32(cboMoneda.SelectedValue.ToString()), dtpFecha.Value);
            if (tipocambio != null)
            {
                txttipocambio.Text = Math.Round(tipocambio.Compra, 3).ToString();
            }
            else
            {
                txttipocambio.Text = "0.00";
            }
        }


        private void cbTDocumento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbTDocumento != null)
            {
                if (cbTDocumento.Items.Count > 0)
                {
                    cargar_serie_correlativo();
                }
            }
        }

        public void cargar_serie_correlativo()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                listaseries = CSerie.cargarSeriexTipocomprobante(Convert.ToInt32(cbTDocumento.SelectedValue.ToString()));
                cbSerie.DataSource = listaseries;
                cbSerie.ValueMember = "codSerie";
                cbSerie.DisplayMember = "Sserie";

                cbSerie_SelectionChangeCommitted(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }





        public void cargar_correlativo()
        {
            if (cbSerie.SelectedIndex != -1)
            {
                if (listaseries.Count > 0)
                {
                    txtCorrelativo.Text = listaseries[cbSerie.SelectedIndex].Correlativo.ToString().PadLeft(8, '0');
                }
            }
        }


        private void cbSerie_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargar_correlativo();
        }

        private void txtcodcliente_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    if (Application.OpenForms["frmListadoPromotores"] != null)
                    {
                        Application.OpenForms["frmListadoPromotores"].Activate();
                    }
                    else
                    {
                        //pro = null;
                        frmListadoPromotores form = new frmListadoPromotores();
                        form.filtro = -1;
                        form.botonborrar = "";
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            promo = form.promotor;

                            if (promo != null)
                            {
                                txtcodcliente.Text = promo.CodPromotor.ToString();
                                txtcliente.Text = promo.Nombrecompleto.Trim();
                                txtDireccion.Text = promo.Direccion.Trim();

                                if (promo != null)
                                {
                                    switch (promo.DocumentoIdentidad.Idtipodocumentoidentidad)
                                    {
                                        case 1:
                                            cbTDocumento.SelectedIndex = 0;
                                            break;
                                        case 2:
                                            cbTDocumento.SelectedIndex = 1;
                                            break;
                                    }
                                }

                                cbTDocumento_SelectionChangeCommitted(null, null);

                            }
                            else
                            {
                                txtcodcliente.Focus();
                                this.Cursor = Cursors.Default;
                                return;
                            }
                        }
                    }
                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void cboTiempoIMpuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {

                string tipo = "";
                if (cboTiempoIMpuesto.Items.Count > 0)
                {
                    tipo = cboTiempoIMpuesto.Text;
                }
                if (dgvdetalle.Rows.Count > 0)
                {

                    for (int i = 0; i < dgvdetalle.Rows.Count; i++)
                    {
                        dgvdetalle.Rows[i].Cells["timpuesto"].Value = cboTiempoIMpuesto.SelectedValue;
                        dgvdetalle.Refresh();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_Detalle"] != null)
            {
                Application.OpenForms["frm_Detalle"].Activate();
            }
            else
            {
                frm_Detalle frm_detalle = new frm_Detalle();
                frm_detalle.formulario = "NuevaVenta";

                //frm_prosalida.frm_ticket = this;
                frm_detalle.ShowDialog();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            try
            {


                DialogResult respuesta = MessageBox.Show("¿Desea eliminar el producto ?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {

                    if (dgvdetalle.Rows.Count >= 1)
                    {
                        dgvdetalle.Rows.Remove(dgvdetalle.CurrentRow);
                        calculatotales();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;
                return;
            }
            this.Cursor = Cursors.Default;

            /*
            if (dgvdetalle.Rows.Count > 0 & dgvdetalle.SelectedRows.Count > 0)
            {

                dgvdetalle.Rows.Remove(dgvdetalle.CurrentRow);
                calculatotales();
            }*/
        }

        public void calculatotales()
        {

            Double valor = 0;
            Double igvt = 0;
            Double preciot = 0;



            foreach (DataGridViewRow row in dgvdetalle.Rows)
            {

                preciot = preciot + Convert.ToDouble(row.Cells["total"].Value);

            }
            // }
            //}


            valor = Convert.ToDouble(Math.Round((preciot / 1.18), 2));
            igvt = Convert.ToDouble(Math.Round((valor * 0.18), 2));

            txtsubtotal.Text = String.Format("{0:#,##0.00}", valor);
            txtIgv.Text = String.Format("{0:#,##0.00}", igvt);
            txttotal.Text = String.Format("{0:#,##0.00}", preciot);


        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            bool rpta = true;
            try
            {

                respuesta = 0;


                decimal gravadas = 0;

                if (promo == null)
                {
                    MessageBox.Show("Promotor es nulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (dgvdetalle.Rows.Count <= 0)
                {
                    MessageBox.Show("Ingrese productos a vender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (cboMoneda == null || cboMoneda.Items.Count == 0)
                {
                    MessageBox.Show("Escoja moneda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (cbSerie == null || cbSerie.Items.Count == 0)
                {
                    MessageBox.Show("Escoja serie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (promo != null)
                {
                    if (promo.Dni.Length < 8)
                    {
                        MessageBox.Show("Cliente tiene N° Documento Identidad Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                        return;
                    }

                    if (promo.Dni.Length > 11)
                    {
                        MessageBox.Show("Cliente tiene N° Documento Identidad Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }


                if (dgvdetalle.Rows.Count > 0)
                {

                    DetalleComprobante detallecomprobante = null;

                    comprobante = new Comprobantee();

                    comprobante.CodPedido = 0;
                    comprobante.CodTransaccion = 7; //ventainterna
                    comprobante.CodTipoComprobante = Convert.ToInt32(cbTDocumento.SelectedValue);

                    cbSerie_SelectionChangeCommitted(null, null);

                    comprobante.Scomprobante = cbSerie.Text + "-" + txtCorrelativo.Text;


                    comprobante.Codserie = Convert.ToInt32(cbSerie.SelectedValue);
                    comprobante.Serie = cbSerie.Text;
                    comprobante.Codpromotor = promo.CodPromotor;
                    comprobante.Codmoneda = Convert.ToInt32(cboMoneda.SelectedValue);
                    comprobante.Tipocambio = Convert.ToDecimal(txttipocambio.Text);
                    comprobante.Descripcion = "";
                    comprobante.Fechaemision = dtpFecha.Value;
                    comprobante.Descuento = 0;
                    comprobante.Subtotal = Convert.ToDecimal(txtsubtotal.Text);
                    comprobante.Igv = Convert.ToDecimal(txtIgv.Text);
                    comprobante.Total = Convert.ToDecimal(txttotal.Text);
                    comprobante.Formapago = 6; //contado
                    comprobante.Codusuario = Session.CodUsuario;
                    comprobante.Codempresa = 1;
                    comprobante.Abonado = 0;
                    comprobante.Pendiente = comprobante.Total;


                    comprobante.Comprobanterelacionado = new Comprobantee();
                    comprobante.Comprobanterelacionado.CodComprobante = 0;
                    comprobante.Comprobanterelacionado.Scomprobante = "";
                    comprobante.Scomprobante = cbSerie.Text + "-" + txtCorrelativo.Text;




                    for (int i = 0; i < dgvdetalle.Rows.Count; i++)
                    {
                        detallecomprobante = new DetalleComprobante();


                        detallecomprobante.Unidadingresada = Convert.ToInt32(dgvdetalle.Rows[i].Cells["codunidad"].Value.ToString());
                        detallecomprobante.CodProducto = Convert.ToInt32(dgvdetalle.Rows[i].Cells["codproducto"].Value.ToString());
                        detallecomprobante.Descripcion = dgvdetalle.Rows[i].Cells["producto"].Value.ToString();

                        detallecomprobante.Cantidad = Convert.ToInt32(dgvdetalle.Rows[i].Cells["cantidad"].Value.ToString());
                        detallecomprobante.Preciounitario = Convert.ToDecimal(dgvdetalle.Rows[i].Cells["preciounitario"].Value.ToString());
                        detallecomprobante.Total = Convert.ToDecimal(dgvdetalle.Rows[i].Cells["total"].Value.ToString());


                        detallecomprobante.Subtotal = (detallecomprobante.Total / Convert.ToDecimal(1.18));
                        detallecomprobante.Igv = (detallecomprobante.Total - detallecomprobante.Subtotal);

                        gravadas = gravadas + detallecomprobante.Subtotal;

                        detallecomprobante.Descuento1 = 0;
                        detallecomprobante.Tipoimpuesto = Convert.ToInt32(dgvdetalle.Rows[i].Cells["timpuesto"].Value.ToString());


                        detallecomprobante.Anulado = 0;
                        detallecomprobante.Codusuario = Session.CodUsuario;

                        comprobante.ListaDetalleComprobante.Add(detallecomprobante);
                    }

                    comprobante.Gravadas = Math.Round(gravadas, 2);
                    comprobante.Exoneradas = 0;
                    comprobante.Inafectas = 0;
                    comprobante.Gratuitas = 0;

                }


                rpta = CComprobante.insertarNuevaventa(comprobante);

                if (rpta == true)
                {
                    btnGuardar.Enabled = false;
                    btnPago.Enabled = true;
                    MessageBox.Show("Datos guardados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //FACTURACION ELECTRONICA

                    //conex.GeneraXML(promo, comprobante, comprobante.ListaDetalleComprobante);
                    await facturacion.GeneraDocumento(promo, comprobante, comprobante.ListaDetalleComprobante);
                    firmadigital = facturacion.LogoEmp;



                }
                else
                {
                    btnGuardar.Enabled = true;
                    MessageBox.Show("Error al guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Default;
                    return;
                }


                this.Close();





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            int id = -1;
            this.Cursor = Cursors.WaitCursor;

            try
            {

                if (comprobante == null)
                {
                    MessageBox.Show("Primero debe registrar el comprobante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (comprobante.Estado == 0)
                {
                    MessageBox.Show("Comprobante se encuentra Anulado !!!", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }



                id = CCaja.buscar_caja_abierta(Session.CodUsuario);

                if (id > 0)
                {
                    caja = new Caja()
                    {
                        Codcaja = id
                    };

                    if (comprobante.Pendiente > 0)
                    {
                        comprobante = CComprobante.buscacomprobante(comprobante.CodComprobante);
                    }

                    frmCancelarPago frm_cp = new frmCancelarPago(comprobante);
                    frm_cp.caja = caja;
                    frm_cp.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Aperture caja", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;

        }
    }
}
