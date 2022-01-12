using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;

namespace SGEDICALE.vista
{
    public partial class frmRegistroPromotor : DevComponents.DotNetBar.Office2007Form
    {

        public static BindingSource data = new BindingSource();
        String filtro = String.Empty;

        private List<TipoDocumentoIdentidad> lista_tipodoc = null;
        private List<TipoPersona> lista_tipopro = null;
        public int codp = 0;

        public frmRegistroPromotor()
        {
            InitializeComponent();
        }

        private void frmRegistroPromotores_Load(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            cargarestado();
            listar_tipodoc_identidad();
            cargarTipoPromotor();

            cboEstado.SelectedIndex = 0;
            dgvPromotores.AutoGenerateColumns = false;
            txtnombre.Focus();

            dtpFechaNac.Value = DateTime.Now;

            label7.Text = "NOMBRE";
            label6.Text = "nombre";

            this.Cursor = Cursors.Default;

        }

        public void listar_tipodoc_identidad()
        {

            try
            {
                lista_tipodoc = CTipoDocumentoIdentidad.listar_tipo_documento_identidad();

                if (lista_tipodoc != null)
                {

                    if (lista_tipodoc.Count > 0)
                    {

                        cboTipoDocumento.DataSource = lista_tipodoc;
                        cboTipoDocumento.DisplayMember = "Descripcion";
                        cboTipoDocumento.ValueMember = "Idtipodocumentoidentidad";
                        cboTipoDocumento.SelectedIndex = 0;
                    }

                }
            }
            catch (Exception) { }
        }

        public void cargarTipoPromotor()
        {

            try
            {
                lista_tipopro = CPromotor.listar_tipo_promotor();

                if (lista_tipopro != null)
                {

                    if (lista_tipopro.Count > 0)
                    {

                        cboTipoPromotor.DataSource = lista_tipopro;
                        cboTipoPromotor.DisplayMember = "Descripcion";
                        cboTipoPromotor.ValueMember = "Codtipopersona";
                        cboTipoPromotor.SelectedIndex = 0;
                    }

                }
            }
            catch (Exception) { }
        }


        public void cargarestado()
        {

            List<dynamic> listadinamica = new List<dynamic>()
            {

                new {codigo=1,descripcion = "ACTIVO" },
                new {codigo=0,descripcion="INACTIVO" }
            };

            cboEstado.DataSource = listadinamica;
            cboEstado.ValueMember = "codigo";
            cboEstado.DisplayMember = "descripcion";

        }


        private void frmRegistroPromotores_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }


        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltro.Text.Length >= 2)
                {
                    //data.Filter = String.Format("Convert([codProducto], System.String) LIKE '%{0}%' OR [codUniversal] LIKE '%{0}%' OR [ubicacion] LIKE '%{0}%' OR [descripcion] LIKE '%{0}%' OR [modelo] LIKE '%{0}%' OR [nmarca] LIKE '%{0}%' OR [unidad] LIKE '%{0}%'", txtFiltro.Text.Trim());
                    data.Filter = String.Format("Convert([{0}], System.String) like '*{1}*'", label6.Text.Trim(), txtFiltro.Text.Trim());
                    //data.Filter = String.Format("[{0}] like '*{1}*'", label6.Text.Trim(), txtFiltro.Text.Trim());
                }
                else
                {
                    data.Filter = String.Empty;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            expandablePanel1.Expanded = false;
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                expandablePanel1.Expanded = false;
            }
        }


        private void dgvDoctores_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label7.Text = dgvPromotores.Columns[e.ColumnIndex].HeaderText;
            label6.Text = dgvPromotores.Columns[e.ColumnIndex].DataPropertyName;
            if (expandablePanel1.Expanded)
            {
                txtFiltro.Focus();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            try
            {
                dgvPromotores.DataSource = null;
                dgvPromotores.AutoGenerateColumns = false;


                dgvPromotores.DataSource = data;
                data.DataSource = CPromotor.listado2();
                data.Filter = String.Empty;
                filtro = String.Empty;
                dgvPromotores.ClearSelection();

                lbregistro.Text = dgvPromotores.Rows.Count + " registros.";

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            limpiar();

            this.Cursor = Cursors.Default;
        }

        public void LimpiarSoloCajas()
        {
            btnListar_Click(null, null);
            txtcod.Clear();
            txtnombre.Clear();
            txtDireccion.Clear();
            txtdocumento.Clear();
            txtcorreo.Clear();
            txtTelefono.Clear();
            txtCodigoSap.Clear();
            dtpFechaNac.Value = DateTime.Now;
            txtcod.ReadOnly = true;
            txtnombre.Focus();
        }

        public void limpiar()
        {
            btnListar_Click(null, null);
            txtcod.Clear();
            txtnombre.Clear();
            txtDireccion.Clear();
            txtdocumento.Clear();
            txtcorreo.Clear();
            txtTelefono.Clear();
            txtCodigoSap.Clear();
            dtpFechaNac.Value = DateTime.Now;
            txtcod.ReadOnly = true;
            txtnombre.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            bool rpta = false;
            string mensaje = "";
            int numerodocumento = 0;

            try
            {

                Promotor prom = new Promotor();
                prom.DocumentoIdentidad = new TipoDocumentoIdentidad();
                prom.TipoPersona = new TipoPersona();

                prom.CodSap = txtCodigoSap.Text.Trim();
                prom.Nombrecompleto = txtnombre.Text.Trim();
                prom.Direccion = txtDireccion.Text.Trim();
                prom.Dni = txtdocumento.Text.Trim();
                prom.Telefono1 = txtTelefono.Text;
                prom.Fechanac = dtpFechaNac.Value;
                prom.Estado = Convert.ToBoolean(cboEstado.SelectedValue);
                prom.DocumentoIdentidad.Idtipodocumentoidentidad = Convert.ToInt32(cboTipoDocumento.SelectedValue);
                prom.Email = txtcorreo.Text;
                prom.TipoPersona.Codtipopersona = Convert.ToInt32(cboTipoPromotor.SelectedValue);
                prom.Razonsocial = txtRazonSocial.Text;

                if (prom.Direccion == "")
                {
                    MessageBox.Show("Complete todos los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                    return;
                }


                numerodocumento = Convert.ToInt32(cboTipoDocumento.SelectedValue);
                switch (numerodocumento)
                {

                    case 1:
                        if (txtdocumento.Text.Length != 8)
                        {

                            MessageBox.Show("N° Documento no válido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Cursor = Cursors.Default;
                            return;
                        }
                        break;
                    case 2:
                        if (txtdocumento.Text.Length != 11)
                        {

                            MessageBox.Show("N° Documento no válido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Cursor = Cursors.Default;
                            return;
                        }

                        break;
                }

                //valida ruc
                if (prom.DocumentoIdentidad.Idtipodocumentoidentidad == 2)
                {

                    if (txtRazonSocial.Text == "")
                    {
                        MessageBox.Show("Ingrese Razòn Social", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Cursor = Cursors.Default;
                        return;
                    }
                }

                if (txtcod.Text != "")
                {
                    codp = Convert.ToInt32(txtcod.Text);
                }

                if (codp == 0)
                {
                    rpta = CPromotor.insertar2(prom);
                    LimpiarSoloCajas();
                    mensaje = "Promotor guardado correctamente";

                }
                else
                {
                    prom.CodPromotor = codp;
                    rpta = CPromotor.update(prom);
                    mensaje = "Promotor actualizado correctamente";

                }

                if (rpta == true)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;

                }

                btnListar_Click(null, null);

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void dgvPromotores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (dgvPromotores.Rows.Count > 0)
                {
                    if (e.RowIndex != -1)
                    {
                        txtcod.Text = dgvPromotores.Rows[e.RowIndex].Cells[codpromotor.Index].Value.ToString();
                        txtCodigoSap.Text = dgvPromotores.Rows[e.RowIndex].Cells[codigosap.Index].Value.ToString();
                        txtnombre.Text = dgvPromotores.Rows[e.RowIndex].Cells[nombre.Index].Value.ToString();
                        txtdocumento.Text = dgvPromotores.Rows[e.RowIndex].Cells[dni.Index].Value.ToString();
                        txtDireccion.Text = dgvPromotores.Rows[e.RowIndex].Cells[direccion.Index].Value.ToString();
                        txtTelefono.Text = dgvPromotores.Rows[e.RowIndex].Cells[telefono1.Index].Value.ToString();
                        dtpFechaNac.Value = Convert.ToDateTime(dgvPromotores.Rows[e.RowIndex].Cells[fechanacimiento.Index].Value);
                        txtcorreo.Text = dgvPromotores.Rows[e.RowIndex].Cells[email.Index].Value.ToString();

                        txtRazonSocial.Text = dgvPromotores.Rows[e.RowIndex].Cells[razonsocial.Index].Value.ToString();


                        cboTipoDocumento.SelectedValue = Convert.ToInt32(dgvPromotores.Rows[e.RowIndex].Cells[codtipodocumento.Index].Value);
                        cboTipoPromotor.SelectedValue = Convert.ToInt32(dgvPromotores.Rows[e.RowIndex].Cells[codtipopersona.Index].Value);

                        cboEstado.SelectedIndex = (dgvPromotores.Rows[e.RowIndex].Cells[estado.Index].Value.ToString() == "ACTIVO") ? 0 : 1;

                    }
                }

                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
        }

        private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (!expandablePanel1.Expanded)
            {
                expandablePanel1.Expanded = true;
                txtFiltro.Focus();
            }
            else
            {
                expandablePanel1.Expanded = false;
            }
        }

        private void txtCodigoSap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
