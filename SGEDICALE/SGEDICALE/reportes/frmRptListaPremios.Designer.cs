namespace SGEDICALE.reportes
{
    partial class frmRptListaPremios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptListaPremios));
            this.crvLista = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvLista
            // 
            this.crvLista.ActiveViewIndex = -1;
            this.crvLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvLista.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvLista.Location = new System.Drawing.Point(0, 0);
            this.crvLista.Name = "crvLista";
            this.crvLista.SelectionFormula = "";
            this.crvLista.Size = new System.Drawing.Size(800, 450);
            this.crvLista.TabIndex = 3;
            this.crvLista.ViewTimeSelectionFormula = "";
            // 
            // frmRptListaPremios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvLista);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRptListaPremios";
            this.Text = "Lista Premios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRptListaPremios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvLista;
    }
}