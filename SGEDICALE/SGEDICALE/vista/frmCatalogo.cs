using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using System.Transactions;
using System.Data;



namespace SGEDICALE.vista
{
    public partial class frmCatalogo : DevComponents.DotNetBar.Office2007Form
    {
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {

            //cargaCampaña();
            //cargaCategoria();
            cargaraño();
          

            this.Cursor = Cursors.Default;
        }

        public void cargaraño()
        {


            DataTable dt1 = new DataTable("Tabla1");

            dt1.Columns.Add("Codigo");
            dt1.Columns.Add("Descripcion");

            DataRow dr1;

            dr1 = dt1.NewRow(); dr1[0] = "2018"; dr1[1] = "2018"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2019"; dr1[1] = "2019"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2020"; dr1[1] = "2020"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2021"; dr1[1] = "2021"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2022"; dr1[1] = "2022"; dt1.Rows.Add(dr1);

            cboAño.DataSource = dt1;
            cboAño.ValueMember = "Descripcion";
            cboAño.DisplayMember = "Descripcion";

            cboAño_SelectedIndexChanged(null, null);

        }

        public void cargaCategoria()
        {

            cboCategoria.DataSource = null;
            if (cboCampaña.SelectedValue != null)
            {

                cboCategoria.DataSource = CCategoria.ListadoCategoriaxCampaña(Convert.ToInt32(cboCampaña.SelectedValue));
                cboCategoria.ValueMember = "codcategoria";
                cboCategoria.DisplayMember = "descripcion";
                cboCategoria.Refresh();
            }

        }

        public void cargaCampaña()
        {

            //cboCampaña.DataSource = CCampaña.CargaCampañaActivas();
            cboCampaña.DataSource = null;
            if (cboAño.SelectedValue != null)
            {
                if (cboAño.Items.Count > 0)
                {
                    cboCampaña.DataSource = CCampaña.buscarxaño(cboAño.SelectedValue.ToString());
                    cboCampaña.ValueMember = "codcampana";
                    cboCampaña.DisplayMember = "descripcion";
                    cboCampaña.Refresh();

                    cargaCategoria();
                }
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool rpta = true;
            string cadena = "";

           // using (var Scope = new TransactionScope())
            //{
                try
                {

                    DetallePrecio detprecio = null;
                    Precio precio = null;

                    if (dgvPrecios.Rows.Count == 0)
                    {
                        //Transaction.Current.Rollback();
                        //Scope.Dispose();
                        this.Cursor = Cursors.Default;
                        return;
                    }

                    if (cboCampaña.Items.Count == 0 || cboCategoria.Items.Count == 0)
                    {
                        //Transaction.Current.Rollback();
                        //Scope.Dispose();
                        this.Cursor = Cursors.Default;
                        return;
                    }


                    precio = new Precio();
                    precio.Campana = new Campaña();

                    precio.Campana.CodCampaña = Convert.ToInt32(cboCampaña.SelectedValue);
                    precio.Codusuario = Session.CodUsuario;


                    Precio p= CPrecio.buscarxcodcampana(precio.Campana.CodCampaña);

                    if (p!= null)
                    {
                        //Transaction.Current.Rollback();
                        //Scope.Dispose();
                        MessageBox.Show("Ya existe una Lista Precio con esa campaña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Cursor = Cursors.Default;
                        return;
                    }

                  
                    rpta = CPrecio.insertar(precio);

                    if (rpta == true)
                    {
                        for (int i = 0; i < dgvPrecios.Rows.Count; i++)
                        {
                            detprecio = new DetallePrecio();
                            detprecio.Precio = new Precio();

                            detprecio.Precio.CodPrecio = precio.CodPrecio;
                            detprecio.Pag = Convert.ToInt32(dgvPrecios.Rows[i].Cells[0].Value.ToString().Trim());
                            detprecio.Marca = dgvPrecios.Rows[i].Cells[1].Value.ToString().Trim();
                            detprecio.Modelo = dgvPrecios.Rows[i].Cells[2].Value.ToString().Trim();
                            detprecio.Color = dgvPrecios.Rows[i].Cells[3].Value.ToString().Trim();
                            detprecio.Tallas = dgvPrecios.Rows[i].Cells[4].Value.ToString().Trim();

                            detprecio.Ppromotor = Convert.ToDecimal(dgvPrecios.Rows[i].Cells[5].Value.ToString().Trim().Replace("S/. ", ""));
                            detprecio.Pcliente = Convert.ToDecimal(dgvPrecios.Rows[i].Cells[6].Value.ToString().Trim().Replace("S/. ", ""));
                            detprecio.Pdirector = Convert.ToDecimal(dgvPrecios.Rows[i].Cells[7].Value.ToString().Trim().Replace("S/. ", ""));
                            detprecio.Fechallegada = dgvPrecios.Rows[i].Cells[8].Value.ToString().Trim();
                            detprecio.Talladisponible = dgvPrecios.Rows[i].Cells[9].Value.ToString().Trim();
                            detprecio.Tallasagotadas = dgvPrecios.Rows[i].Cells[10].Value.ToString().Trim();
                            detprecio.Codusuario = Session.CodUsuario;

                            rpta = CPrecio.insertarDetalle(detprecio);

                            if (rpta == false)
                            {
                                //Transaction.Current.Rollback();
                                //Scope.Dispose();
                                MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Cursor = Cursors.Default;
                                return;
                            }
                        }

                        //Scope.Complete();
                        //Scope.Dispose();

                        MessageBox.Show("Catalogo guardado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                       // Transaction.Current.Rollback();
                        //Scope.Dispose();
                        MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    rpta = false;
                    //Transaction.Current.Rollback();
                    //Scope.Dispose();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Cursor = Cursors.Default;
                }
           // }
            this.Cursor = Cursors.Default;
        }


        private void frmCatalogo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            List<DataGridViewRow> temp = new List<DataGridViewRow>();

            try
            {
                dgvPrecios.DataSource = null;

                openFileDialog1.Filter = "Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx";
                openFileDialog1.Title = "Seleccione el archivo de Excel";
                openFileDialog1.FileName = String.Empty;

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtRuta.Text = openFileDialog1.FileName;

                    if (txtRuta.Text == "")
                    {
                        MessageBox.Show("Escoja la ruta del archivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                        return;
                    }


                    dgvPrecios.DataSource = CPrecio.cargarGrilla(txtRuta.Text);

                    dgvPrecios.Refresh();
                    lbregistro.Text = dgvPrecios.Rows.Count + " registros.";



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

        private void cboCampaña_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cargaCategoria();
        }

    

        private void cboAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargaCampaña();
            txtRuta.Focus();
        }
    }
}
