namespace SGEDICALE.reportes
{
    partial class frmRptDepositos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptDepositos));
            this.crvDepositos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvDepositos
            // 
            this.crvDepositos.ActiveViewIndex = -1;
            this.crvDepositos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDepositos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDepositos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDepositos.Location = new System.Drawing.Point(0, 0);
            this.crvDepositos.Name = "crvDepositos";
            this.crvDepositos.SelectionFormula = "";
            this.crvDepositos.Size = new System.Drawing.Size(794, 345);
            this.crvDepositos.TabIndex = 3;
            this.crvDepositos.ViewTimeSelectionFormula = "";
            // 
            // frmRptDepositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(794, 345);
            this.Controls.Add(this.crvDepositos);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRptDepositos";
            this.Text = "Reporte Depositos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRptDepositos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvDepositos;
    }
}