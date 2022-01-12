namespace SGEDICALE.reportes
{
    partial class frmRptFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptFactura));
            this.crvReporteFactura = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporteFactura
            // 
            this.crvReporteFactura.ActiveViewIndex = -1;
            this.crvReporteFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporteFactura.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporteFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporteFactura.Location = new System.Drawing.Point(0, 0);
            this.crvReporteFactura.Name = "crvReporteFactura";
            this.crvReporteFactura.SelectionFormula = "";
            this.crvReporteFactura.Size = new System.Drawing.Size(527, 438);
            this.crvReporteFactura.TabIndex = 1;
            this.crvReporteFactura.ViewTimeSelectionFormula = "";
            // 
            // frmRptFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(527, 438);
            this.Controls.Add(this.crvReporteFactura);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmRptFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Factura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRptFactura_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmRptFactura_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporteFactura;
    }
}