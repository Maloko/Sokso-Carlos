namespace SGEDICALE.reportes
{
    partial class frmRptDocumentosEnviados
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
            this.crvReporteEnviados = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReporteEnviados
            // 
            this.crvReporteEnviados.ActiveViewIndex = -1;
            this.crvReporteEnviados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReporteEnviados.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReporteEnviados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReporteEnviados.Location = new System.Drawing.Point(0, 0);
            this.crvReporteEnviados.Margin = new System.Windows.Forms.Padding(4);
            this.crvReporteEnviados.Name = "crvReporteEnviados";
            this.crvReporteEnviados.SelectionFormula = "";
            this.crvReporteEnviados.Size = new System.Drawing.Size(800, 450);
            this.crvReporteEnviados.TabIndex = 2;
            this.crvReporteEnviados.ToolPanelWidth = 267;
            this.crvReporteEnviados.ViewTimeSelectionFormula = "";
            // 
            // frmRptDocumentosEnviados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvReporteEnviados);
            this.Name = "frmRptDocumentosEnviados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos Enviados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crvReporteEnviados;
    }
}