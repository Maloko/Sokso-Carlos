namespace SGEDICALE.vista
{
    partial class frmEnvioSunat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnvioSunat));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnenviartodos = new DevComponents.DotNetBar.ButtonX();
            this.btnEnviarporCorreo = new DevComponents.DotNetBar.ButtonX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.dtpFechaFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblHasta = new DevComponents.DotNetBar.LabelX();
            this.cb_estado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblEstado = new DevComponents.DotNetBar.LabelX();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblFecha = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dg_documentos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.repoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipodoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechaemision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correlativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadosunat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensajesunat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xml = new System.Windows.Forms.DataGridViewImageColumn();
            this.Nombredoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codfacturaventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbregistro = new DevComponents.DotNetBar.LabelX();
            this.btn_envio = new DevComponents.DotNetBar.ButtonX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicio)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_documentos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnenviartodos);
            this.groupPanel1.Controls.Add(this.btnEnviarporCorreo);
            this.groupPanel1.Controls.Add(this.btnBuscar);
            this.groupPanel1.Controls.Add(this.dtpFechaFin);
            this.groupPanel1.Controls.Add(this.lblHasta);
            this.groupPanel1.Controls.Add(this.cb_estado);
            this.groupPanel1.Controls.Add(this.lblEstado);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.dtpFechaInicio);
            this.groupPanel1.Controls.Add(this.lblFecha);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(31, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1222, 86);
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
            this.groupPanel1.TabIndex = 4;
            this.groupPanel1.Text = "     Búsqueda     .";
            // 
            // btnenviartodos
            // 
            this.btnenviartodos.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnenviartodos.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnenviartodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnenviartodos.Image = ((System.Drawing.Image)(resources.GetObject("btnenviartodos.Image")));
            this.btnenviartodos.Location = new System.Drawing.Point(1078, 26);
            this.btnenviartodos.Name = "btnenviartodos";
            this.btnenviartodos.Size = new System.Drawing.Size(89, 26);
            this.btnenviartodos.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnenviartodos.TabIndex = 298;
            this.btnenviartodos.Text = "Enviar";
            this.btnenviartodos.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnenviartodos.Click += new System.EventHandler(this.btnenviartodos_Click);
            // 
            // btnEnviarporCorreo
            // 
            this.btnEnviarporCorreo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEnviarporCorreo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEnviarporCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnEnviarporCorreo.Image = ((System.Drawing.Image)(resources.GetObject("btnEnviarporCorreo.Image")));
            this.btnEnviarporCorreo.Location = new System.Drawing.Point(998, 24);
            this.btnEnviarporCorreo.Name = "btnEnviarporCorreo";
            this.btnEnviarporCorreo.Size = new System.Drawing.Size(74, 26);
            this.btnEnviarporCorreo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEnviarporCorreo.TabIndex = 295;
            this.btnEnviarporCorreo.Text = "Email";
            this.btnEnviarporCorreo.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnEnviarporCorreo.Click += new System.EventHandler(this.btnEnviarporCorreo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(892, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 26);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 293;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpFechaFin
            // 
            // 
            // 
            // 
            this.dtpFechaFin.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpFechaFin.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaFin.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpFechaFin.ButtonDropDown.Visible = true;
            this.dtpFechaFin.IsPopupCalendarOpen = false;
            this.dtpFechaFin.Location = new System.Drawing.Point(245, 29);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpFechaFin.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaFin.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpFechaFin.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFechaFin.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpFechaFin.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpFechaFin.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaFin.MonthCalendar.DisplayMonth = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFechaFin.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpFechaFin.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaFin.MonthCalendar.TodayButtonVisible = true;
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(130, 20);
            this.dtpFechaFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFechaFin.TabIndex = 31;
            // 
            // lblHasta
            // 
            this.lblHasta.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHasta.Location = new System.Drawing.Point(200, 29);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(39, 23);
            this.lblHasta.TabIndex = 30;
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cb_estado
            // 
            this.cb_estado.DisplayMember = "Text";
            this.cb_estado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_estado.ForeColor = System.Drawing.Color.Black;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.ItemHeight = 14;
            this.cb_estado.Location = new System.Drawing.Point(748, 29);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(127, 20);
            this.cb_estado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_estado.TabIndex = 25;
            this.cb_estado.SelectedIndexChanged += new System.EventHandler(this.cb_estado_SelectedIndexChanged);
            // 
            // lblEstado
            // 
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblEstado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEstado.Location = new System.Drawing.Point(689, 29);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(53, 20);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = "Estado: ";
            this.lblEstado.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(482, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "DOCUMENTOS A ENVIAR A SUNAT";
            // 
            // dtpFechaInicio
            // 
            // 
            // 
            // 
            this.dtpFechaInicio.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpFechaInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaInicio.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpFechaInicio.ButtonDropDown.Visible = true;
            this.dtpFechaInicio.IsPopupCalendarOpen = false;
            this.dtpFechaInicio.Location = new System.Drawing.Point(48, 29);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpFechaInicio.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaInicio.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpFechaInicio.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFechaInicio.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpFechaInicio.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpFechaInicio.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaInicio.MonthCalendar.DisplayMonth = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFechaInicio.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpFechaInicio.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaInicio.MonthCalendar.TodayButtonVisible = true;
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(130, 20);
            this.dtpFechaInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFechaInicio.TabIndex = 22;
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFecha.Location = new System.Drawing.Point(3, 29);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(39, 23);
            this.lblFecha.TabIndex = 21;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dg_documentos);
            this.groupPanel2.Controls.Add(this.lbregistro);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(31, 115);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1222, 322);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 42;
            this.groupPanel2.Text = "     Detalle Venta      .";
            // 
            // dg_documentos
            // 
            this.dg_documentos.AllowUserToAddRows = false;
            this.dg_documentos.AllowUserToDeleteRows = false;
            this.dg_documentos.AllowUserToOrderColumns = true;
            this.dg_documentos.AllowUserToResizeRows = false;
            this.dg_documentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_documentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dg_documentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_documentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repoid,
            this.Tipodoc,
            this.Fechaemision,
            this.Serie,
            this.correlativo,
            this.monto,
            this.estadosunat,
            this.mensajesunat,
            this.xml,
            this.Nombredoc,
            this.codfacturaventa});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_documentos.DefaultCellStyle = dataGridViewCellStyle9;
            this.dg_documentos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dg_documentos.Location = new System.Drawing.Point(3, 3);
            this.dg_documentos.MultiSelect = false;
            this.dg_documentos.Name = "dg_documentos";
            this.dg_documentos.ReadOnly = true;
            this.dg_documentos.RowHeadersVisible = false;
            this.dg_documentos.RowTemplate.Height = 25;
            this.dg_documentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_documentos.Size = new System.Drawing.Size(1206, 266);
            this.dg_documentos.TabIndex = 42;
            // 
            // repoid
            // 
            this.repoid.DataPropertyName = "Repoid";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.repoid.DefaultCellStyle = dataGridViewCellStyle1;
            this.repoid.HeaderText = "ID";
            this.repoid.Name = "repoid";
            this.repoid.ReadOnly = true;
            this.repoid.Visible = false;
            this.repoid.Width = 40;
            // 
            // Tipodoc
            // 
            this.Tipodoc.DataPropertyName = "Tipodoc";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Tipodoc.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tipodoc.HeaderText = "T. DOC";
            this.Tipodoc.Name = "Tipodoc";
            this.Tipodoc.ReadOnly = true;
            this.Tipodoc.Visible = false;
            this.Tipodoc.Width = 50;
            // 
            // Fechaemision
            // 
            this.Fechaemision.DataPropertyName = "Fechaemision";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Fechaemision.DefaultCellStyle = dataGridViewCellStyle3;
            this.Fechaemision.HeaderText = "F. EMISION";
            this.Fechaemision.Name = "Fechaemision";
            this.Fechaemision.ReadOnly = true;
            this.Fechaemision.Width = 90;
            // 
            // Serie
            // 
            this.Serie.DataPropertyName = "Serie";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Serie.DefaultCellStyle = dataGridViewCellStyle4;
            this.Serie.HeaderText = "SERIE";
            this.Serie.Name = "Serie";
            this.Serie.ReadOnly = true;
            this.Serie.Width = 50;
            // 
            // correlativo
            // 
            this.correlativo.DataPropertyName = "correlativo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.correlativo.DefaultCellStyle = dataGridViewCellStyle5;
            this.correlativo.HeaderText = "CORRELATIVO";
            this.correlativo.Name = "correlativo";
            this.correlativo.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "Monto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.monto.DefaultCellStyle = dataGridViewCellStyle6;
            this.monto.HeaderText = "MONTO";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 70;
            // 
            // estadosunat
            // 
            this.estadosunat.DataPropertyName = "Estadosunat";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.estadosunat.DefaultCellStyle = dataGridViewCellStyle7;
            this.estadosunat.HeaderText = "EST. SUNAT";
            this.estadosunat.Name = "estadosunat";
            this.estadosunat.ReadOnly = true;
            // 
            // mensajesunat
            // 
            this.mensajesunat.DataPropertyName = "Mensajesunat";
            this.mensajesunat.HeaderText = "MENSAJE SUNAT";
            this.mensajesunat.Name = "mensajesunat";
            this.mensajesunat.ReadOnly = true;
            this.mensajesunat.Width = 350;
            // 
            // xml
            // 
            this.xml.DataPropertyName = "Xml";
            this.xml.HeaderText = "XML";
            this.xml.Name = "xml";
            this.xml.ReadOnly = true;
            this.xml.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.xml.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.xml.Width = 70;
            // 
            // Nombredoc
            // 
            this.Nombredoc.DataPropertyName = "Nombredoc";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Nombredoc.DefaultCellStyle = dataGridViewCellStyle8;
            this.Nombredoc.HeaderText = "NOMBRE DOCUMENTO";
            this.Nombredoc.Name = "Nombredoc";
            this.Nombredoc.ReadOnly = true;
            this.Nombredoc.Width = 200;
            // 
            // codfacturaventa
            // 
            this.codfacturaventa.DataPropertyName = "codFacturaVenta";
            this.codfacturaventa.HeaderText = "CodFacturaVenta";
            this.codfacturaventa.Name = "codfacturaventa";
            this.codfacturaventa.ReadOnly = true;
            this.codfacturaventa.Visible = false;
            // 
            // lbregistro
            // 
            this.lbregistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.lbregistro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbregistro.ForeColor = System.Drawing.Color.Black;
            this.lbregistro.Location = new System.Drawing.Point(3, 275);
            this.lbregistro.Name = "lbregistro";
            this.lbregistro.Size = new System.Drawing.Size(751, 21);
            this.lbregistro.TabIndex = 41;
            // 
            // btn_envio
            // 
            this.btn_envio.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_envio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_envio.Enabled = false;
            this.btn_envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_envio.Image = ((System.Drawing.Image)(resources.GetObject("btn_envio.Image")));
            this.btn_envio.Location = new System.Drawing.Point(519, 444);
            this.btn_envio.Name = "btn_envio";
            this.btn_envio.Size = new System.Drawing.Size(160, 23);
            this.btn_envio.TabIndex = 43;
            this.btn_envio.Text = "ENVIAR";
            this.btn_envio.Click += new System.EventHandler(this.btn_envio_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
            this.buttonX1.Location = new System.Drawing.Point(723, 444);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(160, 23);
            this.buttonX1.TabIndex = 44;
            this.buttonX1.Text = "Volver a Firmar";
            this.buttonX1.Visible = false;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // frmEnvioSunat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 479);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.btn_envio);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmEnvioSunat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENVIÓ SUNAT";
            this.Load += new System.EventHandler(this.frmEnvioSunat_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmEnvioSunat_KeyUp);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicio)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_documentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFechaInicio;
        private DevComponents.DotNetBar.LabelX lblFecha;
        private DevComponents.DotNetBar.LabelX lblEstado;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_estado;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dg_documentos;
        private DevComponents.DotNetBar.LabelX lbregistro;
        private DevComponents.DotNetBar.ButtonX btn_envio;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFechaFin;
        private DevComponents.DotNetBar.LabelX lblHasta;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.ButtonX btnEnviarporCorreo;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn repoid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipodoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechaemision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn correlativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadosunat;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensajesunat;
        private System.Windows.Forms.DataGridViewImageColumn xml;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombredoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn codfacturaventa;
        private DevComponents.DotNetBar.ButtonX btnenviartodos;
    }
}