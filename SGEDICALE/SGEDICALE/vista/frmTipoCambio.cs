using System;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmTipoCambio : DevComponents.DotNetBar.Office2007Form
    {

        public frmTipoCambio()
        {
            InitializeComponent();
        }

 

        private void frmTipoCambio_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
       
            llenacombos();
            cbMes.SelectedValue = DateTime.Now.Month;
            cbAño.SelectedValue = DateTime.Now.Year;
         
         
            CargaLista();

            this.Cursor = Cursors.Default;     
        }

        private void CargaLista()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                dgvTipoCambio.DataSource = CTipoCambio.listadotipocambio(Convert.ToInt32(cbMes.SelectedValue), Convert.ToInt32(cbAño.SelectedValue));
                dgvTipoCambio.ClearSelection();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            cbMes.DataSource = dt;
            cbMes.ValueMember = "Codigo";
            cbMes.DisplayMember = "Descripcion";

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

            cbAño.DataSource = dt1;
            cbAño.ValueMember = "Codigo";
            cbAño.DisplayMember = "Descripcion";
        }


        private void frmTipoCambio_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

    
        private void cbMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargaLista();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRegistroTipoCambio frmregistro = new frmRegistroTipoCambio();
            frmregistro.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int codtipocambio;
            if (dgvTipoCambio.Rows.Count >= 1)
            {
                if (dgvTipoCambio.CurrentRow.Index != -1)
                {

                    codtipocambio = Convert.ToInt32(dgvTipoCambio.CurrentRow.Cells["codigo"].Value);

                    frmRegistroTipoCambio frmregistro = new frmRegistroTipoCambio(codtipocambio);
                    frmregistro.Show();

                }
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int cod;

            if (dgvTipoCambio.Rows.Count >= 1 )
            {
                if (dgvTipoCambio.CurrentRow.Index!=-1)
                {

                    cod = Convert.ToInt32(dgvTipoCambio.CurrentRow.Cells["codigo"].Value);

                    DialogResult dlgResult = MessageBox.Show("Esta seguro que desea eliminar los datos definitivamente", "Tipo de cambio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlgResult == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        if (CTipoCambio.delete(cod))
                        {
                            MessageBox.Show("El Tipo de Cambio ha sido eliminado", "Tipo de Cambio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargaLista();
                        }
                    }
                }
            }
        }

        private void cbAño_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargaLista();
        }

        private void dgvTipoCambio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int codtipo = 0;

                if (dgvTipoCambio.Rows.Count > 0)
                {

                    codtipo = Convert.ToInt32(dgvTipoCambio.Rows[e.RowIndex].Cells[0].Value);

                    if (codtipo > 0)
                    {

                        frmRegistroTipoCambio frm_tc = new frmRegistroTipoCambio(codtipo);
                        frm_tc.ShowDialog();
                        CargaLista();
                    }

                }
            
        }
    }
}
