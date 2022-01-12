namespace SGEDICALE.reportes.clsReportes
{
    partial class frmCierreCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCierreCaja));
            this.crystal_cierrecaja = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystal_cierrecaja
            // 
            this.crystal_cierrecaja.ActiveViewIndex = -1;
            this.crystal_cierrecaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystal_cierrecaja.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystal_cierrecaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystal_cierrecaja.Location = new System.Drawing.Point(0, 0);
            this.crystal_cierrecaja.Name = "crystal_cierrecaja";
            this.crystal_cierrecaja.Size = new System.Drawing.Size(284, 261);
            this.crystal_cierrecaja.TabIndex = 1;
            this.crystal_cierrecaja.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.crystal_cierrecaja);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCierreCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Cierre Caja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCierreCaja_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystal_cierrecaja;
    }
}