namespace SGEDICALE.reportes
{
    partial class frmRptEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptEntrega));
            this.crvEntrega = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvEntrega
            // 
            this.crvEntrega.ActiveViewIndex = -1;
            this.crvEntrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvEntrega.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvEntrega.Location = new System.Drawing.Point(0, 0);
            this.crvEntrega.Name = "crvEntrega";
            this.crvEntrega.SelectionFormula = "";
            this.crvEntrega.Size = new System.Drawing.Size(800, 450);
            this.crvEntrega.TabIndex = 2;
            this.crvEntrega.ViewTimeSelectionFormula = "";
            // 
            // frmRptEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvEntrega);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRptEntrega";
            this.Text = "Entrega";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRptEntrega_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvEntrega;
    }
}