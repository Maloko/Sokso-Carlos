namespace SGEDICALE.vista
{
    partial class frmBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanco));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.cboEstado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblSigla = new DevComponents.DotNetBar.LabelX();
            this.txtsigla = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblBanco = new DevComponents.DotNetBar.LabelX();
            this.txtdescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnGuardar);
            this.groupPanel1.Controls.Add(this.cboEstado);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.lblSigla);
            this.groupPanel1.Controls.Add(this.txtsigla);
            this.groupPanel1.Controls.Add(this.lblBanco);
            this.groupPanel1.Controls.Add(this.txtdescripcion);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(32, 15);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(488, 226);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "     Registro      .";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(189, 134);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 34);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // cboEstado
            // 
            this.cboEstado.DisplayMember = "Text";
            this.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEstado.ForeColor = System.Drawing.Color.Black;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 14;
            this.cboEstado.Location = new System.Drawing.Point(109, 87);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(179, 20);
            this.cboEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboEstado.TabIndex = 6;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(41, 84);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(60, 28);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Estado:";
            // 
            // lblSigla
            // 
            // 
            // 
            // 
            this.lblSigla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSigla.Location = new System.Drawing.Point(60, 16);
            this.lblSigla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(41, 28);
            this.lblSigla.TabIndex = 4;
            this.lblSigla.Text = "Sigla:";
            // 
            // txtsigla
            // 
            this.txtsigla.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtsigla.Border.Class = "TextBoxBorder";
            this.txtsigla.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsigla.DisabledBackColor = System.Drawing.Color.White;
            this.txtsigla.ForeColor = System.Drawing.Color.Black;
            this.txtsigla.Location = new System.Drawing.Point(109, 20);
            this.txtsigla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsigla.Name = "txtsigla";
            this.txtsigla.PreventEnterBeep = true;
            this.txtsigla.Size = new System.Drawing.Size(349, 22);
            this.txtsigla.TabIndex = 1;
            // 
            // lblBanco
            // 
            // 
            // 
            // 
            this.lblBanco.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBanco.Location = new System.Drawing.Point(41, 48);
            this.lblBanco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(60, 28);
            this.lblBanco.TabIndex = 1;
            this.lblBanco.Text = "Nombre:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtdescripcion.Border.Class = "TextBoxBorder";
            this.txtdescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdescripcion.DisabledBackColor = System.Drawing.Color.White;
            this.txtdescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtdescripcion.Location = new System.Drawing.Point(109, 52);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.PreventEnterBeep = true;
            this.txtdescripcion.Size = new System.Drawing.Size(349, 22);
            this.txtdescripcion.TabIndex = 2;
            // 
            // frmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(560, 265);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANCO";
            this.Load += new System.EventHandler(this.frmBanco_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmBanco_KeyUp);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX lblBanco;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdescripcion;
        private DevComponents.DotNetBar.LabelX lblSigla;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsigla;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboEstado;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
    }
}