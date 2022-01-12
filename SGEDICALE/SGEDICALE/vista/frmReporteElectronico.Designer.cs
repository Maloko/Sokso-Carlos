namespace SGEDICALE.vista
{
    partial class frmReporteElectronico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteElectronico));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.cboTipo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblfiltro = new DevComponents.DotNetBar.LabelX();
            this.dtpHasta = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblHasta = new DevComponents.DotNetBar.LabelX();
            this.dtpDesde = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblDesde = new DevComponents.DotNetBar.LabelX();
            this.cboEstado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblEstado = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDesde)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cboEstado);
            this.groupPanel1.Controls.Add(this.lblEstado);
            this.groupPanel1.Controls.Add(this.btnBuscar);
            this.groupPanel1.Controls.Add(this.cboTipo);
            this.groupPanel1.Controls.Add(this.lblfiltro);
            this.groupPanel1.Controls.Add(this.dtpHasta);
            this.groupPanel1.Controls.Add(this.lblHasta);
            this.groupPanel1.Controls.Add(this.dtpDesde);
            this.groupPanel1.Controls.Add(this.lblDesde);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(8, 22);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(412, 211);
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
            this.groupPanel1.TabIndex = 16;
            this.groupPanel1.Text = "     Listado      .";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(158, 145);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 29);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 292;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboTipo
            // 
            this.cboTipo.DisplayMember = "Text";
            this.cboTipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipo.ForeColor = System.Drawing.Color.Black;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.ItemHeight = 14;
            this.cboTipo.Location = new System.Drawing.Point(67, 93);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(147, 20);
            this.cboTipo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipo.TabIndex = 24;
            // 
            // lblfiltro
            // 
            // 
            // 
            // 
            this.lblfiltro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltro.Location = new System.Drawing.Point(14, 90);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(35, 23);
            this.lblfiltro.TabIndex = 23;
            this.lblfiltro.Text = "Tipo: ";
            // 
            // dtpHasta
            // 
            // 
            // 
            // 
            this.dtpHasta.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpHasta.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpHasta.ButtonDropDown.Visible = true;
            this.dtpHasta.IsPopupCalendarOpen = false;
            this.dtpHasta.Location = new System.Drawing.Point(239, 14);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpHasta.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpHasta.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpHasta.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpHasta.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpHasta.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpHasta.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpHasta.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpHasta.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpHasta.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpHasta.MonthCalendar.DisplayMonth = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpHasta.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpHasta.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpHasta.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpHasta.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpHasta.MonthCalendar.TodayButtonVisible = true;
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(147, 20);
            this.dtpHasta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpHasta.TabIndex = 22;
            this.dtpHasta.Value = new System.DateTime(2019, 6, 14, 22, 9, 49, 0);
            // 
            // lblHasta
            // 
            // 
            // 
            // 
            this.lblHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(196, 14);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(48, 23);
            this.lblHasta.TabIndex = 21;
            this.lblHasta.Text = "Hasta: ";
            // 
            // dtpDesde
            // 
            // 
            // 
            // 
            this.dtpDesde.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDesde.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpDesde.ButtonDropDown.Visible = true;
            this.dtpDesde.IsPopupCalendarOpen = false;
            this.dtpDesde.Location = new System.Drawing.Point(67, 14);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpDesde.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDesde.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpDesde.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpDesde.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpDesde.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpDesde.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpDesde.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpDesde.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpDesde.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDesde.MonthCalendar.DisplayMonth = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpDesde.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpDesde.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpDesde.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpDesde.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDesde.MonthCalendar.TodayButtonVisible = true;
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(108, 20);
            this.dtpDesde.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpDesde.TabIndex = 20;
            this.dtpDesde.Value = new System.DateTime(2019, 6, 14, 22, 9, 44, 0);
            // 
            // lblDesde
            // 
            // 
            // 
            // 
            this.lblDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(14, 11);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 23);
            this.lblDesde.TabIndex = 19;
            this.lblDesde.Text = "Desde: ";
            // 
            // cboEstado
            // 
            this.cboEstado.DisplayMember = "Text";
            this.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEstado.ForeColor = System.Drawing.Color.Black;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 14;
            this.cboEstado.Location = new System.Drawing.Point(67, 54);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(147, 20);
            this.cboEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboEstado.TabIndex = 296;
            // 
            // lblEstado
            // 
            // 
            // 
            // 
            this.lblEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(13, 54);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 23);
            this.lblEstado.TabIndex = 295;
            this.lblEstado.Text = "Estado: ";
            // 
            // frmReporteElectronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 245);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmReporteElectronico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Documentos Sunat";
            this.Load += new System.EventHandler(this.frmReporteElectronico_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDesde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpHasta;
        private DevComponents.DotNetBar.LabelX lblHasta;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpDesde;
        private DevComponents.DotNetBar.LabelX lblDesde;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTipo;
        private DevComponents.DotNetBar.LabelX lblfiltro;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboEstado;
        private DevComponents.DotNetBar.LabelX lblEstado;
    }
}