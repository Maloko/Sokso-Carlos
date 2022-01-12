using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{

    public partial class frmRegistroCampaña : DevComponents.DotNetBar.Office2007Form
    {

        int codcampaña = 0;

        public frmRegistroCampaña()
        {
            InitializeComponent();
        }

        public frmRegistroCampaña(int cod)
        {
            InitializeComponent();
            codcampaña = cod;
        }

        private void frmRegistroCampaña_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                txtdescripcion.Focus();


                cargarestado();
                cargarcategoria();
                cargaraño();

                dtpInicio.Value = DateTime.Now;
                dtpFin.Value = DateTime.Now.AddDays(31);

                if (codcampaña != 0)
                {
                    cargarcampaña();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;

        }

        public void cargarcampaña()
        {
            Campaña campa = CCampaña.buscar(codcampaña);

            if (campa != null)
            {

                txtdescripcion.Text = campa.Descripcion;
                cboEstado.SelectedValue = campa.Estado;
                cboCategoria.SelectedValue = campa.Categoria.CodCategoria;
                dtpInicio.Value = campa.Fechainicio;
                dtpFin.Value = campa.Fechafin;
                cboAño.Text = campa.Año;
            }
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

        public void cargarcategoria()
        {

          
            cboCategoria.DataSource = CCategoria.ListadoCategoria();
            cboCategoria.ValueMember = "codcategoria";
            cboCategoria.DisplayMember = "descripcion";

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
            cboAño.ValueMember = "Codigo";
            cboAño.DisplayMember = "Descripcion";

        }




        private void frmRegistroCampaña_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool rpta = true;
            string mensaje = "";

            try
            {
                if (txtdescripcion.Text == "" || cboEstado.Text == "")
                {
                    MessageBox.Show("Complete los campos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }

                Campaña campaña = new Campaña();
                campaña.Categoria = new Categoria();

                campaña.Descripcion = txtdescripcion.Text;
                campaña.Categoria.CodCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
                campaña.Fechafin = dtpFin.Value;
                campaña.Fechainicio = dtpInicio.Value;
                campaña.Año = cboAño.Text;

                campaña.Estado = Convert.ToInt32(cboEstado.SelectedValue);
                campaña.CodUsuario = Session.CodUsuario;

                if (codcampaña == 0)
                {

                    Campaña cp= CCampaña.buscarExiste(campaña.Descripcion, campaña.Categoria.CodCategoria,campaña.Año);


                    if (cp != null)
                    {
                        MessageBox.Show("Camapaña ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Cursor = Cursors.Default;
                        return;
                       
                    }


                    rpta = CCampaña.Insert(campaña);
                    mensaje = "Guardado correctamente";
                }
                else
                {
                    campaña.CodCampaña = codcampaña;

                    rpta = CCampaña.Update(campaña);
                    mensaje = "Actualizado correctamente";

                }

                if (rpta == true)
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
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

    

            DataTable dt1 = new DataTable("Tabla1");

            dt1.Columns.Add("Codigo");
            dt1.Columns.Add("Descripcion");

            DataRow dr1;

            dr1 = dt1.NewRow(); dr1[0] = "2018"; dr1[1] = "2018"; dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow(); dr1[0] = "2019"; dr1[1] = "2019"; dt1.Rows.Add(dr1);
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


    }
}
