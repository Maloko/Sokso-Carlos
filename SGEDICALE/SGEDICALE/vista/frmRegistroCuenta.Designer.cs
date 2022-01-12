namespace SGEDICALE.vista
{
    partial class frmRegistroCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroCuenta));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cboEstado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txttipocuenta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbMoneda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbBanco = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblSigla = new DevComponents.DotNetBar.LabelX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.lblBanco = new DevComponents.DotNetBar.LabelX();
            this.txtcuenta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cboEstado);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txttipocuenta);
            this.groupPanel1.Controls.Add(this.cbMoneda);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.cbBanco);
            this.groupPanel1.Controls.Add(this.lblSigla);
            this.groupPanel1.Controls.Add(this.btnGuardar);
            this.groupPanel1.Controls.Add(this.lblBanco);
            this.groupPanel1.Controls.Add(this.txtcuenta);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(16, 15);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(511, 270);
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
            this.groupPanel1.TabIndex = 2;
            this.groupPanel1.Text = "     Registro       .";
            // 
            // cboEstado
            // 
            this.cboEstado.DisplayMember = "Text";
            this.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEstado.ForeColor = System.Drawing.Color.Black;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 14;
            this.cboEstado.Location = new System.Drawing.Point(140, 148);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(179, 20);
            this.cboEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboEstado.TabIndex = 12;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(49, 148);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(60, 28);
            this.labelX3.TabIndex = 11;
            this.labelX3.Text = "Estado:";
            // 
            // txttipocuenta
            // 
            this.txttipocuenta.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txttipocuenta.Border.Class = "TextBoxBorder";
            this.txttipocuenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttipocuenta.DisabledBackColor = System.Drawing.Color.White;
            this.txttipocuenta.ForeColor = System.Drawing.Color.Black;
            this.txttipocuenta.Location = new System.Drawing.Point(140, 84);
            this.txttipocuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttipocuenta.Name = "txttipocuenta";
            this.txttipocuenta.PreventEnterBeep = true;
            this.txttipocuenta.Size = new System.Drawing.Size(324, 22);
            this.txttipocuenta.TabIndex = 10;
            // 
            // cbMoneda
            // 
            this.cbMoneda.DisplayMember = "Text";
            this.cbMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMoneda.ForeColor = System.Drawing.Color.Black;
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.ItemHeight = 14;
            this.cbMoneda.Location = new System.Drawing.Point(140, 116);
            this.cbMoneda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(323, 20);
            this.cbMoneda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMoneda.TabIndex = 9;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(19, 112);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(91, 28);
            this.labelX2.TabIndex = 8;
            this.labelX2.Text = "Moneda:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(19, 80);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(91, 28);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "Tipo Cuenta:";
            // 
            // cbBanco
            // 
            this.cbBanco.DisplayMember = "Text";
            this.cbBanco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBanco.ForeColor = System.Drawing.Color.Black;
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.ItemHeight = 14;
            this.cbBanco.Location = new System.Drawing.Point(140, 20);
            this.cbBanco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(323, 20);
            this.cbBanco.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbBanco.TabIndex = 5;
            // 
            // lblSigla
            // 
            // 
            // 
            // 
            this.lblSigla.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSigla.Location = new System.Drawing.Point(49, 16);
            this.lblSigla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(60, 28);
            this.lblSigla.TabIndex = 4;
            this.lblSigla.Text = "Banco:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(201, 191);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 34);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblBanco
            // 
            // 
            // 
            // 
            this.lblBanco.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBanco.Location = new System.Drawing.Point(19, 48);
            this.lblBanco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(91, 28);
            this.lblBanco.TabIndex = 1;
            this.lblBanco.Text = "Cuenta Cte:";
            // 
            // txtcuenta
            // 
            this.txtcuenta.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcuenta.Border.Class = "TextBoxBorder";
            this.txtcuenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcuenta.DisabledBackColor = System.Drawing.Color.White;
            this.txtcuenta.ForeColor = System.Drawing.Color.Black;
            this.txtcuenta.Location = new System.Drawing.Point(140, 52);
            this.txtcuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.PreventEnterBeep = true;
            this.txtcuenta.Size = new System.Drawing.Size(324, 22);
            this.txtcuenta.TabIndex = 2;
            // 
            // frmRegistroCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(549, 319);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmRegistroCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO CUENTA";
            this.Load += new System.EventHandler(this.frmRegistroCuenta_Load);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txttipocuenta;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMoneda;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbBanco;
        private DevComponents.DotNetBar.LabelX lblSigla;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.LabelX lblBanco;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcuenta;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboEstado;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}