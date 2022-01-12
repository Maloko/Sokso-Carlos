namespace SGEDICALE.vista
{
    partial class frm_listadoTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_listadoTicket));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtcliente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCliente = new DevComponents.DotNetBar.LabelX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.dtpFechaFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblHasta = new DevComponents.DotNetBar.LabelX();
            this.dtpFechaI = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblDesde = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dg_venta = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docidentidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreyapellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbregistro = new DevComponents.DotNetBar.LabelX();
            this.lb_total_dolares = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lb_total_soles = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnReporte = new DevComponents.DotNetBar.ButtonX();
            this.btn_ver = new DevComponents.DotNetBar.ButtonX();
            this.btn_anular = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaI)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_venta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtcliente);
            this.groupPanel1.Controls.Add(this.lblCliente);
            this.groupPanel1.Controls.Add(this.btnBuscar);
            this.groupPanel1.Controls.Add(this.dtpFechaFin);
            this.groupPanel1.Controls.Add(this.lblHasta);
            this.groupPanel1.Controls.Add(this.dtpFechaI);
            this.groupPanel1.Controls.Add(this.lblDesde);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(87, 15);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(944, 121);
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
            this.groupPanel1.TabIndex = 5;
            this.groupPanel1.Text = "     Búsqueda     .";
            // 
            // txtcliente
            // 
            this.txtcliente.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtcliente.Border.Class = "TextBoxBorder";
            this.txtcliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcliente.DisabledBackColor = System.Drawing.Color.White;
            this.txtcliente.ForeColor = System.Drawing.Color.Black;
            this.txtcliente.Location = new System.Drawing.Point(311, 59);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.PreventEnterBeep = true;
            this.txtcliente.Size = new System.Drawing.Size(265, 22);
            this.txtcliente.TabIndex = 30;
            this.txtcliente.TextChanged += new System.EventHandler(this.txtcliente_TextChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCliente.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(223, 55);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(80, 28);
            this.lblCliente.TabIndex = 20;
            this.lblCliente.Text = "Cliente: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(660, 16);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 43);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
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
            this.dtpFechaFin.Location = new System.Drawing.Point(484, 20);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dtpFechaFin.Size = new System.Drawing.Size(119, 22);
            this.dtpFechaFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFechaFin.TabIndex = 18;
            // 
            // lblHasta
            // 
            this.lblHasta.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(412, 20);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(64, 28);
            this.lblHasta.TabIndex = 17;
            this.lblHasta.Text = "Hasta: ";
            // 
            // dtpFechaI
            // 
            // 
            // 
            // 
            this.dtpFechaI.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpFechaI.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaI.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpFechaI.ButtonDropDown.Visible = true;
            this.dtpFechaI.IsPopupCalendarOpen = false;
            this.dtpFechaI.Location = new System.Drawing.Point(275, 20);
            this.dtpFechaI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpFechaI.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaI.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpFechaI.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpFechaI.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpFechaI.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFechaI.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpFechaI.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpFechaI.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpFechaI.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpFechaI.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaI.MonthCalendar.DisplayMonth = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpFechaI.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpFechaI.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFechaI.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpFechaI.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaI.MonthCalendar.TodayButtonVisible = true;
            this.dtpFechaI.Name = "dtpFechaI";
            this.dtpFechaI.Size = new System.Drawing.Size(115, 22);
            this.dtpFechaI.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFechaI.TabIndex = 16;
            // 
            // lblDesde
            // 
            this.lblDesde.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(203, 16);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(64, 28);
            this.lblDesde.TabIndex = 15;
            this.lblDesde.Text = "Desde: ";
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dg_venta);
            this.groupPanel2.Controls.Add(this.lbregistro);
            this.groupPanel2.Controls.Add(this.lb_total_dolares);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.Controls.Add(this.lb_total_soles);
            this.groupPanel2.Controls.Add(this.labelX3);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(0, 145);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1180, 394);
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
            this.groupPanel2.TabIndex = 6;
            this.groupPanel2.Text = "Ventas";
            // 
            // dg_venta
            // 
            this.dg_venta.AllowUserToAddRows = false;
            this.dg_venta.AllowUserToDeleteRows = false;
            this.dg_venta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_venta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codticket,
            this.docidentidad,
            this.nombreyapellido,
            this.fecha,
            this.documento,
            this.total,
            this.cuenta,
            this.estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_venta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_venta.EnableHeadersVisualStyles = false;
            this.dg_venta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dg_venta.Location = new System.Drawing.Point(4, 4);
            this.dg_venta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_venta.Name = "dg_venta";
            this.dg_venta.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_venta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_venta.RowHeadersVisible = false;
            this.dg_venta.RowTemplate.Height = 30;
            this.dg_venta.Size = new System.Drawing.Size(1156, 320);
            this.dg_venta.TabIndex = 299;
            // 
            // codticket
            // 
            this.codticket.DataPropertyName = "codticket";
            this.codticket.HeaderText = "COD";
            this.codticket.Name = "codticket";
            this.codticket.ReadOnly = true;
            this.codticket.Visible = false;
            // 
            // docidentidad
            // 
            this.docidentidad.DataPropertyName = "docidentidad";
            this.docidentidad.HeaderText = "DOC. IDENTIDAD";
            this.docidentidad.Name = "docidentidad";
            this.docidentidad.ReadOnly = true;
            // 
            // nombreyapellido
            // 
            this.nombreyapellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nombreyapellido.DataPropertyName = "nombreyapellido";
            this.nombreyapellido.HeaderText = "CLIENTE";
            this.nombreyapellido.Name = "nombreyapellido";
            this.nombreyapellido.ReadOnly = true;
            this.nombreyapellido.Width = 89;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "DOCUMENTO";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.documento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // cuenta
            // 
            this.cuenta.DataPropertyName = "cuenta";
            this.cuenta.HeaderText = "RESPONSABLE";
            this.cuenta.Name = "cuenta";
            this.cuenta.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // lbregistro
            // 
            this.lbregistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            // 
            // 
            // 
            this.lbregistro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbregistro.ForeColor = System.Drawing.Color.Black;
            this.lbregistro.Location = new System.Drawing.Point(5, 331);
            this.lbregistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbregistro.Name = "lbregistro";
            this.lbregistro.Size = new System.Drawing.Size(261, 28);
            this.lbregistro.TabIndex = 298;
            // 
            // lb_total_dolares
            // 
            this.lb_total_dolares.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lb_total_dolares.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_total_dolares.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_dolares.Location = new System.Drawing.Point(752, 329);
            this.lb_total_dolares.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_total_dolares.Name = "lb_total_dolares";
            this.lb_total_dolares.Size = new System.Drawing.Size(143, 28);
            this.lb_total_dolares.TabIndex = 289;
            this.lb_total_dolares.Text = "0.00";
            this.lb_total_dolares.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lb_total_dolares.Visible = false;
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(644, 331);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(100, 28);
            this.labelX5.TabIndex = 288;
            this.labelX5.Text = "Total $ :";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Center;
            this.labelX5.Visible = false;
            // 
            // lb_total_soles
            // 
            this.lb_total_soles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lb_total_soles.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lb_total_soles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_soles.Location = new System.Drawing.Point(1016, 330);
            this.lb_total_soles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_total_soles.Name = "lb_total_soles";
            this.lb_total_soles.Size = new System.Drawing.Size(143, 28);
            this.lb_total_soles.TabIndex = 287;
            this.lb_total_soles.Text = "0.00";
            this.lb_total_soles.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(908, 331);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(100, 28);
            this.labelX3.TabIndex = 286;
            this.labelX3.Text = "Total S/ :";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnReporte
            // 
            this.btnReporte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnReporte.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(267, 550);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(121, 36);
            this.btnReporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnReporte.TabIndex = 297;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btn_ver
            // 
            this.btn_ver.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ver.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ver.Image = ((System.Drawing.Image)(resources.GetObject("btn_ver.Image")));
            this.btn_ver.Location = new System.Drawing.Point(7, 550);
            this.btn_ver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(121, 36);
            this.btn_ver.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ver.TabIndex = 296;
            this.btn_ver.Text = "Ver";
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // btn_anular
            // 
            this.btn_anular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_anular.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_anular.Image = ((System.Drawing.Image)(resources.GetObject("btn_anular.Image")));
            this.btn_anular.Location = new System.Drawing.Point(137, 550);
            this.btn_anular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_anular.Name = "btn_anular";
            this.btn_anular.Size = new System.Drawing.Size(121, 36);
            this.btn_anular.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_anular.TabIndex = 295;
            this.btn_anular.Text = "Anular";
            this.btn_anular.Click += new System.EventHandler(this.btn_anular_Click);
            // 
            // frm_listadoTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(1183, 601);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btn_ver);
            this.Controls.Add(this.btn_anular);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_listadoTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA TICKETS";
            this.Load += new System.EventHandler(this.frm_listadoTicket_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_listadoTicket_KeyUp);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaI)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_venta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcliente;
        private DevComponents.DotNetBar.LabelX lblCliente;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFechaFin;
        private DevComponents.DotNetBar.LabelX lblHasta;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFechaI;
        private DevComponents.DotNetBar.LabelX lblDesde;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dg_venta;
        private DevComponents.DotNetBar.LabelX lbregistro;
        private DevComponents.DotNetBar.LabelX lb_total_dolares;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lb_total_soles;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn docidentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreyapellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private DevComponents.DotNetBar.ButtonX btnReporte;
        private DevComponents.DotNetBar.ButtonX btn_ver;
        private DevComponents.DotNetBar.ButtonX btn_anular;
    }
}