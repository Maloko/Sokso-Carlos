namespace SGEDICALE.reportes
{
    partial class frmRptListaPuntos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptListaPuntos));
            this.crvListaPuntos = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvListaPuntos
            // 
            this.crvListaPuntos.ActiveViewIndex = -1;
            this.crvListaPuntos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvListaPuntos.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvListaPuntos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvListaPuntos.Location = new System.Drawing.Point(0, 0);
            this.crvListaPuntos.Name = "crvListaPuntos";
            this.crvListaPuntos.SelectionFormula = "";
            this.crvListaPuntos.Size = new System.Drawing.Size(614, 357);
            this.crvListaPuntos.TabIndex = 5;
            this.crvListaPuntos.ViewTimeSelectionFormula = "";
            // 
            // frmRptListaPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 357);
            this.Controls.Add(this.crvListaPuntos);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRptListaPuntos";
            this.Text = "REPORTE PUNTOS";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvListaPuntos;
    }
}