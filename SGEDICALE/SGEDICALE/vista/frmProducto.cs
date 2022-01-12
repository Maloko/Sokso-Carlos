using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using System.Text.RegularExpressions;
using System.IO;

namespace SGEDICALE.vista
{
    public partial class frmProducto : DevComponents.DotNetBar.Office2007Form
    {

        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
          
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            List<DataGridViewRow> temp = new List<DataGridViewRow>();

            try
            {

                dgvProducto.DataSource = null;
                string nombrearchivo = "";

                openFileDialog1.Filter = "Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx";
                openFileDialog1.Title = "Seleccione el archivo de Excel";
                openFileDialog1.FileName = String.Empty;

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtRuta.Text = openFileDialog1.FileName;
                    nombrearchivo = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);

                    this.Cursor = Cursors.Default;

                    if (txtRuta.Text == "")
                    {
                        MessageBox.Show("Escoja la ruta del archivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                        return;
                    }

                    dgvProducto.DataSource = CProducto.cargarGrilla(txtRuta.Text, nombrearchivo);
                    listBox1.Items.Clear();

                    if (dgvProducto.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow row in dgvProducto.Rows)
                        {
                            if (Convert.ToString(row.Cells["coD_PROM"].Value) == "")
                            {
                                temp.Add(row);
                            }
                        }

                        foreach (DataGridViewRow row in temp)
                        {
                            dgvProducto.Rows.Remove(row);
                        }
                    }

                    dgvProducto.Refresh();
                    lbregistro.Text = dgvProducto.Rows.Count + " registros.";

                    this.Cursor = Cursors.Default;

                }
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool rpta = true;
            this.Cursor = Cursors.WaitCursor;
            int cantidad = 0;
            int contador = 0;
      
            try
            {
                if (txtRuta.Text == "")
                {
                    MessageBox.Show("Ingrese ruta de archivo excel", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (dgvProducto.Rows.Count == 0)
                {
                    MessageBox.Show("Primero carge grilla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                contador = dgvProducto.Rows.Count;

                Producto pro = new Producto();

                foreach (DataGridViewRow row in dgvProducto.Rows)
                {
                    pro.Codigosap = Convert.ToInt32(row.Cells[0].Value.ToString().Trim());
                    pro.Nombrepromotor = row.Cells[2].Value.ToString().Trim();
                    pro.Campaña = row.Cells[3].Value.ToString().Trim();
                    pro.Pag = 0;
                    pro.Cod_Producto = row.Cells[4].Value.ToString().Trim();

                  
                    pro.Descripcion = row.Cells[5].Value.ToString().Trim();
                    pro.Descripcion = Regex.Replace(pro.Descripcion, @"\s+", " ");
                    pro.Marca = row.Cells[6].Value.ToString().Trim();
                    pro.Modelo = row.Cells[7].Value.ToString().Trim();
                    pro.Color = row.Cells[8].Value.ToString().Trim();
                    pro.Descripcion2 = pro.Descripcion.Trim()+" - "+ pro.Color.Trim();
                    pro.Descripcion2= Regex.Replace(pro.Descripcion2, @"\s+", " ");
                    pro.Genero = row.Cells[9].Value.ToString().Trim();
                    pro.Familia = row.Cells[10].Value.ToString().Trim();
                    pro.Categoria = row.Cells[11].Value.ToString().Trim();
                    pro.Tipomarca = row.Cells[12].Value.ToString().Trim();
                    pro.Subcat = row.Cells[13].Value.ToString().Trim();
                    pro.Nivel6 = string.Empty;
                    pro.Talla = row.Cells[14].Value.ToString().Trim();
                    pro.Cantidad =Convert.ToInt32(row.Cells[15].Value.ToString().Trim());
                    pro.Fecha = Convert.ToDateTime(row.Cells[16].Value.ToString().Trim());
                    pro.Precd = Convert.ToDecimal(row.Cells[17].Value.ToString().Trim());
                    pro.Subtotal = Convert.ToDecimal(row.Cells[18].Value.ToString().Trim());
                    pro.Igv = Convert.ToDecimal(row.Cells[19].Value.ToString().Trim());
                    pro.Total = Convert.ToDecimal(row.Cells[20].Value.ToString().Trim());
                    pro.Preprom = Convert.ToDecimal(row.Cells[21].Value.ToString().Trim());
                    pro.Subtotalpreprom = Convert.ToDecimal(row.Cells[22].Value.ToString().Trim());
                    pro.Igvpreprom = Convert.ToDecimal(row.Cells[23].Value.ToString().Trim());
                    pro.Totalpreprom = Convert.ToDecimal(row.Cells[24].Value.ToString().Trim());

                    pro.Totalpreprom2 =0;


                        switch (pro.Marca)
                        {

                            case "AMADEO ASTO":
                            case "JACK & JACKIE":
                            case "ROUTT":
                            case "URBAN CREEDS":
                            case "NINA SIMIK":
                            case "ESTELA SOKSO":
                            case "SOKSO":
                                pro.Totalprepromdescuento = Math.Round(Convert.ToDecimal(pro.Totalpreprom - (pro.Totalpreprom * Convert.ToDecimal(0.10))),2);
                                break;
                            default:
                                pro.Totalprepromdescuento =Math.Round(Convert.ToDecimal(pro.Totalpreprom - (pro.Totalpreprom * Convert.ToDecimal(0.07))),2);
                                break;
                        }
                    

                    pro.Ndoc = Convert.ToInt32(row.Cells[26].Value.ToString().Trim());
                    pro.Origen = row.Cells[27].Value.ToString().Trim();
                    pro.Tdoc = row.Cells[28].Value.ToString().Trim();
                    pro.Tnumero = row.Cells[29].Value.ToString().Trim();
                    pro.Codusuario = Session.CodUsuario;

                    rpta = CProducto.insertar(pro);

                    if (rpta == true)
                    {
                        cantidad = cantidad + 1;
                    }
                    else
                    {
                        listBox1.Items.Add(pro.Nombrepromotor + "   "+ pro.Descripcion2+ "   Talla: "+pro.Talla+ "\n");
                    }
                 
                }

                dgvProducto.Refresh();


                MessageBox.Show("Se guardaron los productos correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbregistro.Text =dgvProducto.Rows.Count + " registros.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void frmProducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
