namespace SGEDICALE.reportes
{
    partial class frmRptListaNotasCredito
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
            this.crvListaNotas = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvListaNotas
            // 
            this.crvListaNotas.ActiveViewIndex = -1;
            this.crvListaNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvListaNotas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvListaNotas.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvListaNotas.Location = new System.Drawing.Point(45, 19);
            this.crvListaNotas.Name = "crvListaNotas";
            this.crvListaNotas.SelectionFormula = "";
            this.crvListaNotas.Size = new System.Drawing.Size(284, 222);
            this.crvListaNotas.TabIndex = 2;
            this.crvListaNotas.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crvListaNotas.ViewTimeSelectionFormula = "";
            // 
            // frmRptListaNotasCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 261);
            this.Controls.Add(this.crvListaNotas);
            this.Name = "frmRptListaNotasCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Notas Crédito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvListaNotas;
    }
}