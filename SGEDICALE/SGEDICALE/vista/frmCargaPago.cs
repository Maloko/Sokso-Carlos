using System;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text;
using System.IO;

namespace SGEDICALE.vista
{
    public partial class frmCargaPago : DevComponents.DotNetBar.Office2007Form
    {
        public frmCargaPago()
        {
            InitializeComponent();
        }

        private void frmCargaPago_Load(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            dtpFecha.Value = DateTime.Now.Date;

            CargaBancos();
            cbBanco_SelectionChangeCommitted(null, null);

            this.Cursor = Cursors.Default;

        }


        private void CargaBancos()
        {
            cbBanco.DataSource = CBanco.listar();
            cbBanco.DisplayMember = "descripcion";
            cbBanco.ValueMember = "codBanco";

        }



        private void btnRuta_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                dgvPagos.DataSource = null;


                openFileDialog1.Filter = "Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx";
                openFileDialog1.Title = "Seleccione el archivo de Excel";
                openFileDialog1.FileName = String.Empty;


                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    this.Cursor = Cursors.Default;

                    txtRuta.Text = openFileDialog1.FileName;

                    if (txtRuta.Text == "")
                    {
                        MessageBox.Show("Escoja la ruta del archivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                        return;
                    }


                    dgvPagos.DataSource = CPago.cargarGrilla(txtRuta.Text);
                    lblregistros.Text = dgvPagos.Rows.Count + " registros.";
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            bool rpta = true;
            int cantidad = 0;
            int contador = 0;
            string fecha = "";
            int posicion = 0;
            string cadena = "";

            try
            {
                if (txtRuta.Text == "")
                {
                    MessageBox.Show("Ingrese ruta de archivo excel", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (dgvPagos.Rows.Count == 0)
                {
                    MessageBox.Show("Primero carge grilla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }


                if (cbBanco.Items.Count == 0)
                {
                    MessageBox.Show("Seleccione un banco", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (cbCuenta.Items.Count == 0)
                {
                    MessageBox.Show("Seleccione una cuenta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                contador = dgvPagos.Rows.Count;

                Pago pa = new Pago();

                pa.Codbanco = Convert.ToInt32(cbBanco.SelectedValue.ToString());
                pa.Codcuenta = Convert.ToInt32(cbCuenta.SelectedValue.ToString());


                if (cbBanco.Text == "BANCO PICHINCHA")
                {
                    fecha = dgvPagos.Rows[9].Cells[0].Value.ToString().Trim();

                    for (int i = 9; i < dgvPagos.Rows.Count; i++)
                    {
                        posicion = 0;
                        cadena = "";


                        if (dgvPagos.Rows[i].Cells[0].Value.ToString().Trim() != "")
                        {
                            pa.Fecha = Convert.ToDateTime(dgvPagos.Rows[i].Cells[0].Value.ToString().Trim());

                            if (pa.Fecha.Date == dtpFecha.Value.Date && Convert.ToDecimal(dgvPagos.Rows[i].Cells[3].Value.ToString().Trim()) > 0)
                            {
                                pa.Fechavaluta = pa.Fecha;
                                pa.Operacionhora = dgvPagos.Rows[i].Cells[1].Value.ToString().Trim();
                                pa.Descripcion = dgvPagos.Rows[i].Cells[2].Value.ToString().Trim();
                                pa.Monto = Convert.ToDecimal(dgvPagos.Rows[i].Cells[3].Value.ToString().Trim());
                                pa.Saldo = 0;
                                pa.Sucursal = "";

                                cadena = pa.Descripcion;
                                posicion = cadena.LastIndexOf(" ");
                                posicion = posicion + 1;

                                if (pa.Descripcion != "DEP. EFECTIVO")
                                {
                                    pa.Operacionnumero = pa.Descripcion.Substring(posicion, cadena.Length - posicion);
                                }
                                else
                                {
                                    pa.Operacionnumero = "00000000" + pa.Codbanco;
                                }

                                pa.Usuario = "";
                                pa.Utc = "";
                                pa.Codusuario = Session.CodUsuario;

                                rpta = CPago.insertar(pa);

                                if (rpta == true)
                                {
                                    cantidad = cantidad + 1;
                                }
                            }
                        }

                    }
                }

                if (cbBanco.Text == "BANCO DE CREDITO DEL PERU")
                {


                    fecha = dgvPagos.Rows[6].Cells[0].Value.ToString().Trim();

                    if (fecha == "Fecha")
                    {
                        for (int i = 7; i < dgvPagos.Rows.Count; i++)
                        {

                            //string fecha1 = dgvPagos.Rows[i].Cells[0].Value.ToString().Trim();
                            //string fecha2 = dgvPagos.Rows[7].Cells[0].Value.ToString().Trim();
                            // string fecha3 = dgvPagos.Rows[8].Cells[0].Value.ToString().Trim();

                            if (dgvPagos.Rows[i].Cells[0].Value.ToString().Trim() != "")
                            {

                                pa.Fecha = Convert.ToDateTime(dgvPagos.Rows[i].Cells[0].Value.ToString().Trim());

                                if (pa.Fecha.Date == dtpFecha.Value.Date && Convert.ToDecimal(dgvPagos.Rows[i].Cells[3].Value.ToString().Trim()) > 0)
                                {
                                    pa.Descripcion = dgvPagos.Rows[i].Cells[2].Value.ToString().Trim();
                                    pa.Monto = Convert.ToDecimal(dgvPagos.Rows[i].Cells[3].Value.ToString().Trim());
                                    pa.Sucursal = dgvPagos.Rows[i].Cells[4].Value.ToString().Trim();
                                    pa.Operacionnumero = dgvPagos.Rows[i].Cells[5].Value.ToString().Trim();
                                    pa.Usuario = dgvPagos.Rows[i].Cells[6].Value.ToString().Trim();
                                    pa.Codusuario = Session.CodUsuario;

                                    rpta = CPago.insertar(pa);

                                    if (rpta == true)
                                    {
                                        cantidad = cantidad + 1;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = 4; i < dgvPagos.Rows.Count; i++)
                        {

                            if (dgvPagos.Rows[i].Cells[0].Value.ToString().Trim() != "")
                            {

                                pa.Fecha = Convert.ToDateTime(dgvPagos.Rows[i].Cells[0].Value.ToString().Trim());

                                if (pa.Fecha.Date == dtpFecha.Value.Date && Convert.ToDecimal(dgvPagos.Rows[i].Cells[3].Value.ToString().Trim()) > 0)
                                {
                                    pa.Fechavaluta = Convert.ToDateTime(dgvPagos.Rows[i].Cells[1].Value.ToString().Trim());
                                    pa.Descripcion = dgvPagos.Rows[i].Cells[2].Value.ToString().Trim();
                                    pa.Monto = Convert.ToDecimal(dgvPagos.Rows[i].Cells[3].Value.ToString().Trim());
                                    pa.Saldo = Convert.ToDecimal(dgvPagos.Rows[i].Cells[4].Value.ToString().Trim());
                                    pa.Sucursal = dgvPagos.Rows[i].Cells[5].Value.ToString().Trim();
                                    pa.Operacionnumero = dgvPagos.Rows[i].Cells[6].Value.ToString().Trim();
                                    pa.Operacionhora = dgvPagos.Rows[i].Cells[7].Value.ToString().Trim();
                                    pa.Usuario = dgvPagos.Rows[i].Cells[8].Value.ToString().Trim();
                                    pa.Utc = dgvPagos.Rows[i].Cells[9].Value.ToString().Trim();
                                    pa.Codusuario = Session.CodUsuario;

                                    rpta = CPago.insertar(pa);

                                    if (rpta == true)
                                    {
                                        cantidad = cantidad + 1;
                                    }
                                }
                            }

                        }
                    }
                }

                if (cbBanco.Text == "CAJA PIURA")
                {
                    fecha = dgvPagos.Rows[10].Cells[0].Value.ToString().Trim();

                    if (dgvPagos.Rows[10].Cells[0].Value.ToString().Trim() != "")
                    {

                        for (int i = 10; i < dgvPagos.Rows.Count; i++)
                        {

                            pa.Fecha = Convert.ToDateTime(dgvPagos.Rows[i].Cells[0].Value.ToString().Trim());

                            if (pa.Fecha.Date == dtpFecha.Value.Date && Convert.ToDecimal(dgvPagos.Rows[i].Cells[3].Value.ToString().Replace(" ", "").Trim()) > 0)
                            {
                                pa.Fechavaluta = pa.Fecha;
                                pa.Operacionhora = dgvPagos.Rows[i].Cells[1].Value.ToString().Trim();
                                pa.Descripcion = dgvPagos.Rows[i].Cells[2].Value.ToString().Trim();
                                pa.Monto = Convert.ToDecimal(dgvPagos.Rows[i].Cells[3].Value.ToString().Trim());
                                pa.Saldo = 0;
                                pa.Sucursal = "";

                                pa.Operacionnumero = "00000000" + pa.Codbanco;

                                pa.Usuario = "";
                                pa.Utc = "";
                                pa.Codusuario = Session.CodUsuario;


                                if (pa.Descripcion != "PAGO DE INTERESES")
                                {
                                    rpta = CPago.insertar(pa);
                                }
                                else
                                {
                                    rpta = false;
                                }



                                if (rpta == true)
                                {
                                    cantidad = cantidad + 1;
                                }
                            }

                        }
                    }
                }



                MessageBox.Show(cantidad + " pagos guardados.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblregistros.Text = (dgvPagos.Rows.Count - 4) + " registros.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }




        private void cbBanco_SelectionChangeCommitted(object sender, EventArgs e)
        {

            int codban = 0;
            cbCuenta.DataSource = null;

            if (cbBanco != null)
            {

                if (cbBanco.Items.Count > 0)
                {

                    codban = Convert.ToInt32(cbBanco.SelectedValue.ToString());

                    cbCuenta.DataSource = CCuenta.buscarxcodbanco(codban);
                    cbCuenta.DisplayMember = "cuentaCorriente";
                    cbCuenta.ValueMember = "codCuentaCorriente";


                }
            }


        }

        private void frmCargaPago_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
