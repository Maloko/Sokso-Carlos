using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using Microsoft.Win32;
using Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;
using System.IO;

namespace SGEDICALE.vista
{
    public partial class frmPromotor : DevComponents.DotNetBar.Office2007Form
    {
        public frmPromotor()
        {
            InitializeComponent();
        }

        private void frmPromotor_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            List<DataGridViewRow> temp = new List<DataGridViewRow>();

            try
            {
                string nombrearchivo = "";
                dgvPromotores.DataSource = null;

                openFileDialog1.Filter = "Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx";
                // openFileDialog1.DefaultExt = ".xlsx";

                openFileDialog1.Title = "Seleccione el archivo de Excel";
                openFileDialog1.FileName = String.Empty;

                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtRuta.Text = openFileDialog1.FileName;
                    nombrearchivo = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);

                    if (txtRuta.Text == "")
                    {
                        MessageBox.Show("Escoja la ruta del archivo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                        return;
                    }

                    dgvPromotores.DataSource = CPromotor.cargarGrilla(txtRuta.Text, nombrearchivo);
                    dgvPromotores.Refresh();

                    lblregistros.Text = dgvPromotores.Rows.Count + " registros.";
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
    
        

        private void frmPromotor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            bool rpta = false;
            this.Cursor = Cursors.WaitCursor;
            string fecha;
            bool bandera = false;
            /*
            int espaciosblanco = 0;
            string[] separados;
            bool bandera2 = false;        
            int posicion = 0;*/

            try
            {
                if (txtRuta.Text == "")
                {
                    MessageBox.Show("Ingrese ruta de archivo excel", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (dgvPromotores.Rows.Count == 0)
                {
                    MessageBox.Show("Primero carge grilla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                Promotor promo = new Promotor();


                foreach (DataGridViewRow row in dgvPromotores.Rows)
                {

                    if (row.Cells[0].Value.ToString().Trim() != "")
                    {

                        promo.CodSap = row.Cells[1].Value.ToString().Trim();
                        promo.Nombrecompleto = row.Cells[3].Value.ToString().Trim().ToUpper();
                        promo.Nombrecompleto = Regex.Replace(promo.Nombrecompleto, @"\s+", " ");

                        promo.Departamento = row.Cells[7].Value.ToString().Trim();
                        promo.Provincia = row.Cells[8].Value.ToString().Trim();
                        promo.Distrito = row.Cells[9].Value.ToString().Trim();
                        promo.Direccion = row.Cells[10].Value.ToString().Trim();
                        promo.Dni = row.Cells[0].Value.ToString().Trim();
                        promo.Telefono1 = string.Empty;
                        promo.Telefono2 = string.Empty;
                        promo.Celular1 = row.Cells[4].Value.ToString().Trim();
                        promo.Celular2 = string.Empty;
                        promo.Email = row.Cells[5].Value.ToString().Trim();

                        if (row.Cells[6].Value.ToString().Trim() != "")
                        {
                            fecha = row.Cells[6].Value.ToString().Trim();

                            if (fecha.Contains("a.m"))
                            {
                                fecha = row.Cells[6].Value.ToString().Trim().Replace(" a.m.", "");
                                bandera = true;
                            }

                            if (fecha.Contains("p.m"))
                            {
                                fecha = row.Cells[6].Value.ToString().Replace(" p.m.", "");
                                bandera = true;
                            }

                            if (bandera == false)
                            {
                                promo.Fechanac = Convert.ToDateTime(row.Cells[6].Value.ToString().Trim());
                            }
                            else
                            {
                                promo.Fechanac = Convert.ToDateTime(fecha);
                            }

                        }

                        promo.Razonsocial = string.Empty;
                        promo.Genero = string.Empty;
                        promo.Estadocivil = string.Empty;
                        promo.Regimen = string.Empty;
                        promo.Cliprospecto = string.Empty;

                        promo.TipoPersona = new TipoPersona();
                        promo.TipoPersona.Codtipopersona = 1;

                        rpta = CPromotor.insertar(promo);
                    }

                }

                MessageBox.Show("Se guardo correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }
    }
}
