namespace SGEDICALE.vista
{
    partial class frmRegistroTipoCambio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroTipoCambio));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.txtventa = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtcompra = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtpFecha = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.cbMoneda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lblSigla = new DevComponents.DotNetBar.LabelX();
            this.lblBanco = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnGuardar);
            this.groupPanel1.Controls.Add(this.txtventa);
            this.groupPanel1.Controls.Add(this.txtcompra);
            this.groupPanel1.Controls.Add(this.dtpFecha);
            this.groupPanel1.Controls.Add(this.cbMoneda);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.lblSigla);
            this.groupPanel1.Controls.Add(this.lblBanco);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(16, 15);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(420, 249);
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
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "     Registro      .";
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(153, 161);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 34);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtventa
            // 
            this.txtventa.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtventa.Border.Class = "TextBoxBorder";
            this.txtventa.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtventa.DisabledBackColor = System.Drawing.Color.White;
            this.txtventa.ForeColor = System.Drawing.Color.Black;
            this.txtventa.Location = new System.Drawing.Point(140, 116);
            this.txtventa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtventa.Name = "txtventa";
            this.txtventa.PreventEnterBeep = true;
            this.txtventa.Size = new System.Drawing.Size(216, 22);
            this.txtventa.TabIndex = 2;
            this.txtventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtventa_KeyPress);
            // 
            // txtcompra
            // 
            this.txtcompra.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcompra.Border.Class = "TextBoxBorder";
            this.txtcompra.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcompra.DisabledBackColor = System.Drawing.Color.White;
            this.txtcompra.ForeColor = System.Drawing.Color.Black;
            this.txtcompra.Location = new System.Drawing.Point(140, 80);
            this.txtcompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.PreventEnterBeep = true;
            this.txtcompra.Size = new System.Drawing.Size(216, 22);
            this.txtcompra.TabIndex = 1;
            this.txtcompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcompra_KeyPress);
            // 
            // dtpFecha
            // 
            // 
            // 
            // 
            this.dtpFecha.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFecha.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpFecha.ButtonDropDown.Visible = true;
            this.dtpFecha.IsPopupCalendarOpen = false;
            this.dtpFecha.Location = new System.Drawing.Point(140, 48);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpFecha.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFecha.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpFecha.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpFecha.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFecha.MonthCalendar.DisplayMonth = new System.DateTime(2018, 7, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpFecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFecha.MonthCalendar.TodayButtonVisible = true;
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(216, 22);
            this.dtpFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFecha.TabIndex = 18;
            // 
            // cbMoneda
            // 
            this.cbMoneda.DisplayMember = "Text";
            this.cbMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMoneda.ForeColor = System.Drawing.Color.Black;
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.ItemHeight = 14;
            this.cbMoneda.Location = new System.Drawing.Point(140, 16);
            this.cbMoneda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(215, 20);
            this.cbMoneda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMoneda.TabIndex = 17;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(61, 116);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(48, 25);
            this.labelX2.TabIndex = 16;
            this.labelX2.Text = "Venta:";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(49, 80);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(60, 28);
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "Compra:";
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
            this.lblSigla.Size = new System.Drawing.Size(60, 25);
            this.lblSigla.TabIndex = 13;
            this.lblSigla.Text = "Moneda:";
            // 
            // lblBanco
            // 
            // 
            // 
            // 
            this.lblBanco.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBanco.Location = new System.Drawing.Point(56, 48);
            this.lblBanco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(53, 25);
            this.lblBanco.TabIndex = 11;
            this.lblBanco.Text = "Fecha:";
            // 
            // frmRegistroTipoCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(455, 284);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmRegistroTipoCambio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO TIPO CAMBIO";
            this.Load += new System.EventHandler(this.frmRegistroTipoCambio_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmRegistroTipoCambio_KeyUp);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtventa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcompra;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFecha;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMoneda;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblSigla;
        private DevComponents.DotNetBar.LabelX lblBanco;
    }
}