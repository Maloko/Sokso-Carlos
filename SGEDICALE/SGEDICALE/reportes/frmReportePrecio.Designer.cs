namespace SGEDICALE.reportes
{
    partial class frmReportePrecio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePrecio));
            this.crReportePrecio = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crReportePrecio
            // 
            this.crReportePrecio.ActiveViewIndex = -1;
            this.crReportePrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crReportePrecio.Cursor = System.Windows.Forms.Cursors.Default;
            this.crReportePrecio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crReportePrecio.Location = new System.Drawing.Point(0, 0);
            this.crReportePrecio.Name = "crReportePrecio";
            this.crReportePrecio.Size = new System.Drawing.Size(592, 308);
            this.crReportePrecio.TabIndex = 0;
            // 
            // frmReportePrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(592, 308);
            this.Controls.Add(this.crReportePrecio);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReportePrecio";
            this.Text = "Reporte Diferencia Precios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportePrecio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crReportePrecio;
    }
}