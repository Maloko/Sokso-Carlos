using SGEDICALE.reportes;
using SGEDICALE.reportes.clsReportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SGEDICALE.vista
{
    public partial class frmReporteElectronico : DevComponents.DotNetBar.Office2007Form
    {

        clsReporte ds = new clsReporte();
        public static BindingSource data = new BindingSource();
        String filtro = String.Empty;


        public frmReporteElectronico()
        {
            InitializeComponent();
        }

        private void frmReporteElectronico_Load(object sender, EventArgs e)
        {
            cargartipodocumento();
            cargarestado();

            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now;
        }

        public void cargarestado()
        {
            List<dynamic> listaEstados = new List<dynamic>()
            {
                new {Codigo=0,Descripcion="ENVIADO" },
                new {Codigo=-1,Descripcion="NO ENVIADO" }
            };

            cboEstado.DataSource = listaEstados;
            cboEstado.ValueMember = "Codigo";
            cboEstado.DisplayMember = "Descripcion";
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarVentas();
        }

        public void cargartipodocumento()
        {
            List<dynamic> listadocumentos = new List<dynamic>()
            {
                new {Codigo=1,Descripcion="BOLETA" },
                new {Codigo=2,Descripcion="FACTURA" },
                new {Codigo=3,Descripcion="NOTA DE CREDITO" }
            };

            cboTipo.DataSource = listadocumentos;
            cboTipo.ValueMember = "Codigo";
            cboTipo.DisplayMember = "Descripcion";
        }




        private void BuscarVentas()
        {
            CRDocumentosSunat rpt = new CRDocumentosSunat();
            frmRptDocumentosEnviados frm = new frmRptDocumentosEnviados();

            DataTable dt = ds.DocumentosEnviados(dtpDesde.Value, dtpHasta.Value,
                                                   Convert.ToInt32(cboTipo.SelectedValue), Convert.ToInt32(cboEstado.SelectedValue)).Tables[0];
            if (dt.Rows.Count > 0)
            {
                rpt.SetDataSource(dt);
                frm.crvReporteEnviados.ReportSource = rpt;
                frm.Show();
            }
            else
            {
                MessageBox.Show("No se ha encontrado resultados con los filtros seleccionados",
                                "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      
    }
}
