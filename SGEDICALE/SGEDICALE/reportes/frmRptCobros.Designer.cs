namespace SGEDICALE.reportes
{
    partial class frmRptCobros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptCobros));
            this.crvCobro = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvCobro
            // 
            this.crvCobro.ActiveViewIndex = -1;
            this.crvCobro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvCobro.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvCobro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvCobro.Location = new System.Drawing.Point(0, 0);
            this.crvCobro.Name = "crvCobro";
            this.crvCobro.SelectionFormula = "";
            this.crvCobro.Size = new System.Drawing.Size(698, 414);
            this.crvCobro.TabIndex = 2;
            this.crvCobro.ViewTimeSelectionFormula = "";
            // 
            // frmRptCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(698, 414);
            this.Controls.Add(this.crvCobro);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRptCobros";
            this.Text = "Cobros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRptCobros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvCobro;
    }
}