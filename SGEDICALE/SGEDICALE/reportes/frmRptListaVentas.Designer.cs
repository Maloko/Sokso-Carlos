namespace SGEDICALE.reportes
{
    partial class frmRptListaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRptListaVentas));
            this.crvListaGuias = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvListaGuias
            // 
            this.crvListaGuias.ActiveViewIndex = -1;
            this.crvListaGuias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvListaGuias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvListaGuias.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvListaGuias.Location = new System.Drawing.Point(-1, 12);
            this.crvListaGuias.Name = "crvListaGuias";
            this.crvListaGuias.SelectionFormula = "";
            this.crvListaGuias.Size = new System.Drawing.Size(284, 222);
            this.crvListaGuias.TabIndex = 1;
            this.crvListaGuias.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvListaGuias.ViewTimeSelectionFormula = "";
            // 
            // frmRptListaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.crvListaGuias);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRptListaVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Ventas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRptListaVentas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvListaGuias;
    }
}