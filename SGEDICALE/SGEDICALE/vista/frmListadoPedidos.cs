using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SGEDICALE.controlador;
using SGEDICALE.clases;
using SGEDICALE.reportes;
using SGEDICALE.reportes.clsReportes;
using System.Linq;

namespace SGEDICALE.vista
{
    public partial class frmListadoPedidos : DevComponents.DotNetBar.Office2007Form
    {
        public frmListadoPedidos()
        {
            InitializeComponent();
        }

        private void ListadoPedidos_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dtpFecha.Value = DateTime.Now.Date;
            cargarcombofiltro();
            cargarestadofiltro();

            this.Cursor = Cursors.Default;
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

            cbPedido.Text = "";

            cbPedido.DataSource = CPedido.cargarComboPedido(dtpFecha.Value.Date);
            cbPedido.ValueMember = "numeropedido";
            cbPedido.DisplayMember = "numeropedido";
            cbPedido.Refresh();
        }

        public void cargarestadofiltro()
        {

            List<dynamic> listafiltro = new List<dynamic>()
            {
                new {codigo=0,descripcion="AMBOS" },
                new {codigo=1,descripcion="PENDIENTES" },
                new {codigo=2,descripcion="FACTURADOS" }
            };

            cbEstado.DataSource = listafiltro;
            cbEstado.ValueMember = "codigo";
            cbEstado.DisplayMember = "descripcion";
            cbEstado.Refresh();
        }

        public void cargarcombofiltro()
        {

            List<dynamic> listafiltro = new List<dynamic>()
            {
                new {codigo=1,descripcion="TODOS" },
                new {codigo=2,descripcion="DIFERENCIA PRECIO" },
                new {codigo=4,descripcion="CORRECTOS" }
            };

            cbFiltro.DataSource = listafiltro;
            cbFiltro.ValueMember = "codigo";
            cbFiltro.DisplayMember = "descripcion";
            cbFiltro.Refresh();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {

                string codpedido = string.Empty;
                int filtro = 0;
                int filtro2 = 0;
                DataTable dt = new DataTable();

                if (cbPedido == null)
                {
                    this.Cursor = Cursors.Default;
                    return;
                }

                if (cbPedido.Text == "")
                {
                    this.Cursor = Cursors.Default;
                    return;
                }

                dgvlistado.DataSource = null;
                dgvlistado.AutoGenerateColumns = false;
                codpedido = cbPedido.SelectedValue.ToString();
                filtro = Convert.ToInt32(cbFiltro.SelectedValue.ToString());
                filtro2 = Convert.ToInt32(cbEstado.SelectedValue.ToString());

                /*
                new { codigo = 1, descripcion = "TODOS" },
                new { codigo = 2, descripcion = "DIFERENCIA PRECIO" },
                new { codigo = 4, descripcion = "CORRECTOS" }
                */

                /*
                new { codigo = 0, descripcion = "AMBOS" },
                new { codigo = 1, descripcion = "PENDIENTES" },
                new { codigo = 2, descripcion = "FACTURADOS" }
                */

                if (filtro == 1)
                {
                  dgvlistado.DataSource = CPedido.listarPedidosFiltroTodos(codpedido, filtro2);
                }

                if (filtro == 2)
                {
                   dgvlistado.DataSource = CPedido.listarPedidosFiltroDiferencia(codpedido,filtro2);   
                }

                if (filtro == 4)
                {
                    dgvlistado.DataSource = CPedido.listarPedidosFiltroCorrecto(codpedido, filtro2);
                }

                if (dgvlistado.DataSource != null)
                {
                    total_venta();
                }



                dgvlistado.Refresh();
                lblregistro.Text = dgvlistado.Rows.Count + " registros.";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        public void total_venta()
        {

            try
            {
                if (dgvlistado.Rows.Count > 0)
                {

                    lb_total_soles.Text = (dgvlistado.Rows.Cast<DataGridViewRow>().Select(x => decimal.Parse(x.Cells["total"].Value.ToString())).Sum()).ToString();


                }
                else
                {

                    lb_total_soles.Text = "0.00";
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void btnComparar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            List<DataGridViewRow> temp = new List<DataGridViewRow>();
            Pedido pedido = null;
            bool rpta = true;

            try
            {

                foreach (DataGridViewRow row in dgvlistado.Rows)
                {
                    pedido = new Pedido();

                    pedido.CodPedido = Convert.ToInt32(row.Cells[0].Value);

                    //rpta = CPedido.comparar(pedido.CodPedido);

                    if (rpta == true)
                    {
                        temp.Add(row);
                    }
                }


                foreach (DataGridViewRow row in temp)
                {
                    dgvlistado.Rows.Remove(row);
                }

                dgvlistado.Refresh();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void dgvlistado_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void frmListadoPedidos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dgvlistado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                int codpedido = 0;
                if (dgvlistado.Rows.Count > 0)
                {
                    if (dgvlistado.CurrentCell != null)
                    {
                        if (dgvlistado.CurrentCell.RowIndex != -1)
                        {
                            codpedido = Convert.ToInt32(dgvlistado.Rows[e.RowIndex].Cells[0].Value);

                            if (codpedido > 0)
                            {
                                frmConsultaPedido frmconsulta = new frmConsultaPedido(codpedido);
                                frmconsulta.ShowDialog();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvlistado.Rows.Count == 0)
                {
                    MessageBox.Show("Lista vacía", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Cursor = Cursors.Default;
                    return;
                }


                DataSet ds = new DataSet();
                DataTable dt = new DataTable("ListaGuias");
                dt.Columns.Add("codpedido", typeof(int));
                dt.Columns.Add("nombre", typeof(string));
                dt.Columns.Add("subtotal", typeof(decimal));
                dt.Columns.Add("igv", typeof(decimal));
                dt.Columns.Add("total", typeof(decimal));
                dt.Columns.Add("fechapedido", typeof(DateTime));
                dt.Columns.Add("nombresapellidos", typeof(string));
                dt.Columns.Add("numeropedido", typeof(string));
                dt.Columns.Add("filtro", typeof(string));
                dt.Columns.Add("estado", typeof(string));

                foreach (DataGridViewRow dgv in dgvlistado.Rows)
                {
                    dt.Rows.Add(dgv.Cells["codpedido"].Value,
                    dgv.Cells["nombre"].Value,
                    dgv.Cells["subtotal"].Value,
                    dgv.Cells["igv"].Value,
                    dgv.Cells["total"].Value,
                    Convert.ToDateTime(dgv.Cells["fechapedido"].Value),
                    dgv.Cells["nombresapellidos"].Value,
                    cbPedido.Text,
                    cbFiltro.Text,
                    cbEstado.Text);
                }
                ds.Tables.Add(dt);
                ds.WriteXml("C:\\XML\\ListaPedidosDicaleRPT.xml", XmlWriteMode.WriteSchema);

                CRListaPedido rpt = new CRListaPedido();
                frmRptListaPedido frm = new frmRptListaPedido();
                rpt.SetDataSource(ds);
                frm.crvLista.ReportSource = rpt;
                frm.Show();



                /*

                DataSet ds = new DataSet();
                DataTable dt = new DataTable("ListaGuias");
                // Columnas
                foreach (DataGridViewColumn column in dgvlistado.Columns)
                {
                    DataColumn dc = new DataColumn(column.Name.ToString());
                    dt.Columns.Add(dc);
                }

                // Datos
                for (int i = 0; i < dgvlistado.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvlistado.Rows[i];
                    DataRow dr = dt.NewRow();

                    for (int j = 0; j < dgvlistado.Columns.Count; j++)
                    {
                        dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                    }
                    dt.Rows.Add(dr);
                }

                ds.Tables.Add(dt);
                ds.WriteXml("C:\\XML\\ListaPedidosDicaleRPT.xml", XmlWriteMode.WriteSchema);


                CRListaPedido rpt = new CRListaPedido();
                frmRptListaPedido frm = new frmRptListaPedido();
                rpt.SetDataSource(ds);
                frm.crvLista.ReportSource = rpt;
                frm.Show();

                */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Cursor = Cursors.Default;

            }

            this.Cursor = Cursors.Default;
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvlistado.Rows.Count > 0)
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar todos los pedidos ?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool rpta = CPedido.borrar(Convert.ToInt32(cbPedido.SelectedValue));
                        dtpFecha_ValueChanged(null,null);
                        btnBuscar_Click(null, null);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {


            this.Cursor = Cursors.WaitCursor;
            try
            {

                if (dgvlistado.Rows.Count > 0)
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar todos los pedidos ?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        bool rpta = CPedido.borrarTodo(Convert.ToInt32(cbPedido.SelectedValue));
                        dtpFecha_ValueChanged(null, null);
                        btnBuscar_Click(null, null);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            int codped = 0;
            try
            {

                if (dgvlistado.Rows.Count > 0)
                {
                    DialogResult respuesta = MessageBox.Show("¿Desea eliminar el pedido ?...", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {

                        codped = Convert.ToInt32(dgvlistado.CurrentRow.Cells["codpedido"].Value);
                        bool rpta = CPedido.borrar(codped);

                        if (rpta == true)
                        {
                            MessageBox.Show("Pedido eliminado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se puede eliminar el pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        dtpFecha_ValueChanged(null, null);
                        btnBuscar_Click(null, null);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Cursor = Cursors.Default;
            }

            this.Cursor = Cursors.Default;
        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }
    }
}
