namespace SGEDICALE.reportes
{
    partial class frmRptVentaxPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptVentaxPedido));
            this.crvReporteVentaxPedido = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporteVentaxPedido
            // 
            this.crvReporteVentaxPedido.ActiveViewIndex = -1;
            this.crvReporteVentaxPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporteVentaxPedido.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporteVentaxPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporteVentaxPedido.Location = new System.Drawing.Point(0, 0);
            this.crvReporteVentaxPedido.Name = "crvReporteVentaxPedido";
            this.crvReporteVentaxPedido.SelectionFormula = "";
            this.crvReporteVentaxPedido.Size = new System.Drawing.Size(800, 450);
            this.crvReporteVentaxPedido.TabIndex = 2;
            this.crvReporteVentaxPedido.ViewTimeSelectionFormula = "";
            // 
            // frmRptVentaxPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvReporteVentaxPedido);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRptVentaxPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte de Venta x Pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRptVentaxPedido_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmRptVentaxPedido_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporteVentaxPedido;
    }
}