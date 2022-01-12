namespace SGEDICALE.reportes
{
    partial class frmRptTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptTicket));
            this.crvReporteTicket = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporteTicket
            // 
            this.crvReporteTicket.ActiveViewIndex = -1;
            this.crvReporteTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporteTicket.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporteTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporteTicket.Location = new System.Drawing.Point(0, 0);
            this.crvReporteTicket.Name = "crvReporteTicket";
            this.crvReporteTicket.SelectionFormula = "";
            this.crvReporteTicket.Size = new System.Drawing.Size(800, 450);
            this.crvReporteTicket.TabIndex = 2;
            this.crvReporteTicket.ViewTimeSelectionFormula = "";
            // 
            // frmRptTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvReporteTicket);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRptTicket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.frmRptTicket_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporteTicket;
    }
}