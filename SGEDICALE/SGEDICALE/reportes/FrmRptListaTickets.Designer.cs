namespace SGEDICALE.reportes
{
    partial class FrmRptListaTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRptListaTickets));
            this.crvListaTickets = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvListaTickets
            // 
            this.crvListaTickets.ActiveViewIndex = -1;
            this.crvListaTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvListaTickets.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvListaTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvListaTickets.Location = new System.Drawing.Point(0, 0);
            this.crvListaTickets.Name = "crvListaTickets";
            this.crvListaTickets.SelectionFormula = "";
            this.crvListaTickets.Size = new System.Drawing.Size(800, 450);
            this.crvListaTickets.TabIndex = 3;
            this.crvListaTickets.ViewTimeSelectionFormula = "";
            // 
            // FrmRptListaTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvListaTickets);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRptListaTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRptListaTickets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRptListaTickets_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvListaTickets;
    }
}