namespace SGEDICALE.reportes
{
    partial class frmBancoRP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBancoRP));
            this.crReporteBanco = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crReporteBanco
            // 
            this.crReporteBanco.ActiveViewIndex = -1;
            this.crReporteBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crReporteBanco.Cursor = System.Windows.Forms.Cursors.Default;
            this.crReporteBanco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crReporteBanco.Location = new System.Drawing.Point(0, 0);
            this.crReporteBanco.Name = "crReporteBanco";
            this.crReporteBanco.Size = new System.Drawing.Size(601, 356);
            this.crReporteBanco.TabIndex = 1;
            // 
            // frmBancoRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(601, 356);
            this.Controls.Add(this.crReporteBanco);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBancoRP";
            this.Text = "Reporte Banco";
            this.Load += new System.EventHandler(this.frmBancoRP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crReporteBanco;
    }
}