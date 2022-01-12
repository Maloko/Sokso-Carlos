using System;
using System.Windows.Forms;
using SGEDICALE.clases;
using SGEDICALE.controlador;

namespace SGEDICALE.vista
{
    public partial class frmF1Premios : DevComponents.DotNetBar.Office2007Form
    {

        frmEntregar formEntregar = (frmEntregar)Application.OpenForms["frmEntregar"];

        public int codcampana=0;
        public int codpromotor = 0;
        public Premio premio = null;

        public frmF1Premios()
        {
            InitializeComponent();
        }

        private void frmF1Premios_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            listar();

            this.Cursor = Cursors.Default;
        }


        public void listar()
        {

            this.Cursor = Cursors.WaitCursor;
            dgvPremios.DataSource = null;
            dgvPremios.DataSource = CPremio.listarpremiosxcodcampana_codpromotor(codpromotor, codcampana);
            lbregistro.Text = dgvPremios.Rows.Count.ToString() + " registros.";
            dgvPremios.Refresh();


            this.Cursor = Cursors.Default;

        }


        private void frmF1Premios_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {

                this.Close();
            }
        }

        private void dgvPremios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string entregado,estado = "";
            try
            {

                int index = 0;
                if (dgvPremios.Rows.Count > 0 )
                {
                    premio = new Premio();


                    DataGridViewRow Row = dgvPremios.Rows[e.RowIndex];
                    index = e.RowIndex;
                    premio.CodPremio = Convert.ToInt32(Row.Cells[0].Value);
                    premio.Promotor = Row.Cells[1].Value.ToString();
                    premio.Campaña = Row.Cells[2].Value.ToString();
                    premio.CompraFacturada = Row.Cells[3].Value.ToString();
                    premio.FechaValidacion1 = Row.Cells[4].Value.ToString();
                    premio.PremioRegular = Row.Cells[5].Value.ToString();
                    premio.EnvioPremioRegular = Row.Cells[6].Value.ToString();
                    premio.PremioAfi = Row.Cells[7].Value.ToString();
                    premio.Valido = Row.Cells[8].Value.ToString();


                    entregado= Row.Cells[9].Value.ToString();

                    if (entregado == "ENTREGADO")
                    {
                        premio.Entregado = 1;
                    }
                    else
                    {
                        premio.Entregado = 0;
                    }

                    estado = Row.Cells[10].Value.ToString();

                    if (entregado == "ACTIVO")
                    {
                        premio.Estado = 1;
                    }
                    else
                    {
                        premio.Estado = 0;
                    }

                    premio.Fechaentrega= Convert.ToDateTime(Row.Cells[11].Value.ToString());


                    formEntregar.dgvPremios.Rows.Add(premio.CodPremio, premio.Promotor,premio.Fechaentrega,premio.Campaña, premio.CompraFacturada, premio.FechaValidacion1, premio.PremioRegular, premio.EnvioPremioRegular, premio.PremioAfi, premio.Valido, entregado, estado);

                    dgvPremios.Rows.RemoveAt(index);
                    dgvPremios.Refresh();

                    /*
                    DataTable dt = (DataTable)formEntregar.dgvPremios.DataSource;
                    dt.Rows.Add(premio.CodPremio, premio.Campaña, premio.CompraFacturada, premio.FechaValidacion1, premio.PremioRegular, premio.EnvioPremioRegular, premio.PremioAfi, premio.Valido,entregado,estado);
                    formEntregar.dgvPremios.DataSource = dt;*/
              

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
