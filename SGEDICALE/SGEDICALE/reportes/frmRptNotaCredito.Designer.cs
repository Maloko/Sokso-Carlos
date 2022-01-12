namespace SGEDICALE.reportes
{
    partial class frmRptNotaCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptNotaCredito));
            this.crvNotaCredito = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvNotaCredito
            // 
            this.crvNotaCredito.ActiveViewIndex = -1;
            this.crvNotaCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNotaCredito.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvNotaCredito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvNotaCredito.Location = new System.Drawing.Point(0, 0);
            this.crvNotaCredito.Name = "crvNotaCredito";
            this.crvNotaCredito.SelectionFormula = "";
            this.crvNotaCredito.Size = new System.Drawing.Size(505, 356);
            this.crvNotaCredito.TabIndex = 1;
            this.crvNotaCredito.ViewTimeSelectionFormula = "";
            // 
            // frmRptNotaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(505, 356);
            this.Controls.Add(this.crvNotaCredito);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmRptNotaCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nota Credito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRptNotaCredito_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmRptNotaCredito_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvNotaCredito;
    }
}