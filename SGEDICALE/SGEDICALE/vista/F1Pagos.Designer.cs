namespace SGEDICALE.vista
{
    partial class F1Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F1Pagos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtnumerooperacion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.dtpFechaFin = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblHasta = new DevComponents.DotNetBar.LabelX();
            this.dtpFechaI = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblDesde = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lblregistros = new DevComponents.DotNetBar.LabelX();
            this.dgvPagos = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codpago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codbanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaCorriente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldofavor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacionnumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechavaluta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operacionhora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaI)).BeginInit();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtnumerooperacion);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.btnBuscar);
            this.groupPanel1.Controls.Add(this.dtpFechaFin);
            this.groupPanel1.Controls.Add(this.lblHasta);
            this.groupPanel1.Controls.Add(this.dtpFechaI);
            this.groupPanel1.Controls.Add(this.lblDesde);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(16, 15);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1097, 121);
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
            this.groupPanel1.TabIndex = 3;
            this.groupPanel1.Text = "Busqueda";
            // 
            // txtnumerooperacion
            // 
            this.txtnumerooperacion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtnumerooperacion.Border.Class = "TextBoxBorder";
            this.txtnumerooperacion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnumerooperacion.DisabledBackColor = System.Drawing.Color.White;
            this.txtnumerooperacion.ForeColor = System.Drawing.Color.Black;
            this.txtnumerooperacion.Location = new System.Drawing.Point(139, 49);
            this.txtnumerooperacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnumerooperacion.Name = "txtnumerooperacion";
            this.txtnumerooperacion.PreventEnterBeep = true;
            this.txtnumerooperacion.Size = new System.Drawing.Size(244, 22);
            this.txtnumerooperacion.TabIndex = 60;
            this.txtnumerooperacion.TextChanged += new System.EventHandler(this.txtnumerooperacion_TextChanged);
            this.txtnumerooperacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumerooperacion_KeyPress);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(19, 46);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(112, 28);
            this.labelX1.TabIndex = 16;
            this.labelX1.Text = "N° Operacion: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(645, 14);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 60);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 15;
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
            this.dtpFechaFin.Location = new System.Drawing.Point(385, 14);
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
            this.dtpFechaFin.Size = new System.Drawing.Size(196, 22);
            this.dtpFechaFin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFechaFin.TabIndex = 14;
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // lblHasta
            // 
            // 
            // 
            // 
            this.lblHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(313, 10);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(64, 28);
            this.lblHasta.TabIndex = 13;
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
            this.dtpFechaI.Location = new System.Drawing.Point(139, 14);
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
            this.dtpFechaI.Size = new System.Drawing.Size(144, 22);
            this.dtpFechaI.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFechaI.TabIndex = 12;
            this.dtpFechaI.ValueChanged += new System.EventHandler(this.dtpFechaI_ValueChanged);
            // 
            // lblDesde
            // 
            // 
            // 
            // 
            this.lblDesde.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(67, 10);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(64, 28);
            this.lblDesde.TabIndex = 4;
            this.lblDesde.Text = "Desde: ";
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lblregistros);
            this.panelEx1.Controls.Add(this.dgvPagos);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(19, 154);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1095, 379);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 13;
            // 
            // lblregistros
            // 
            this.lblregistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.lblregistros.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblregistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistros.ForeColor = System.Drawing.Color.Black;
            this.lblregistros.Location = new System.Drawing.Point(16, 335);
            this.lblregistros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblregistros.Name = "lblregistros";
            this.lblregistros.Size = new System.Drawing.Size(456, 28);
            this.lblregistros.TabIndex = 13;
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.AllowUserToResizeColumns = false;
            this.dgvPagos.AllowUserToResizeRows = false;
            this.dgvPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codpago,
            this.banco,
            this.codbanco,
            this.codcuenta,
            this.cuentaCorriente,
            this.monto,
            this.cobrado,
            this.saldofavor,
            this.operacionnumero,
            this.fecha,
            this.fechavaluta,
            this.descripcion,
            this.saldo,
            this.sucursal,
            this.operacionhora,
            this.usuario,
            this.utc,
            this.responsable,
            this.estado,
            this.fecharegistro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPagos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPagos.EnableHeadersVisualStyles = false;
            this.dgvPagos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvPagos.Location = new System.Drawing.Point(4, 15);
            this.dgvPagos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPagos.RowHeadersVisible = false;
            this.dgvPagos.RowTemplate.Height = 30;
            this.dgvPagos.Size = new System.Drawing.Size(1087, 313);
            this.dgvPagos.TabIndex = 4;
            this.dgvPagos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagos_CellDoubleClick);
            // 
            // codpago
            // 
            this.codpago.DataPropertyName = "codpago";
            this.codpago.HeaderText = "CODIGO";
            this.codpago.Name = "codpago";
            this.codpago.ReadOnly = true;
            this.codpago.Width = 92;
            // 
            // banco
            // 
            this.banco.DataPropertyName = "banco";
            this.banco.HeaderText = "BANCO";
            this.banco.Name = "banco";
            this.banco.ReadOnly = true;
            this.banco.Width = 85;
            // 
            // codbanco
            // 
            this.codbanco.DataPropertyName = "codbanco";
            this.codbanco.HeaderText = "CodigoBanco";
            this.codbanco.Name = "codbanco";
            this.codbanco.ReadOnly = true;
            this.codbanco.Visible = false;
            this.codbanco.Width = 96;
            // 
            // codcuenta
            // 
            this.codcuenta.DataPropertyName = "codcuenta";
            this.codcuenta.HeaderText = "CodigoCuenta";
            this.codcuenta.Name = "codcuenta";
            this.codcuenta.ReadOnly = true;
            this.codcuenta.Visible = false;
            this.codcuenta.Width = 99;
            // 
            // cuentaCorriente
            // 
            this.cuentaCorriente.DataPropertyName = "cuentaCorriente";
            this.cuentaCorriente.HeaderText = "CUENTA";
            this.cuentaCorriente.Name = "cuentaCorriente";
            this.cuentaCorriente.ReadOnly = true;
            this.cuentaCorriente.Width = 93;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            this.monto.HeaderText = "MONTO";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 89;
            // 
            // cobrado
            // 
            this.cobrado.DataPropertyName = "cobrado";
            this.cobrado.HeaderText = "COBRADO";
            this.cobrado.Name = "cobrado";
            this.cobrado.ReadOnly = true;
            this.cobrado.Visible = false;
            this.cobrado.Width = 85;
            // 
            // saldofavor
            // 
            this.saldofavor.DataPropertyName = "saldofavor";
            this.saldofavor.HeaderText = "SALDO A FAVOR";
            this.saldofavor.Name = "saldofavor";
            this.saldofavor.ReadOnly = true;
            this.saldofavor.Visible = false;
            this.saldofavor.Width = 117;
            // 
            // operacionnumero
            // 
            this.operacionnumero.DataPropertyName = "operacionnumero";
            this.operacionnumero.HeaderText = "N° OPERACION";
            this.operacionnumero.Name = "operacionnumero";
            this.operacionnumero.ReadOnly = true;
            this.operacionnumero.Width = 127;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "FECHA PAGO";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 116;
            // 
            // fechavaluta
            // 
            this.fechavaluta.DataPropertyName = "fechavaluta";
            this.fechavaluta.HeaderText = "F. VALUTA";
            this.fechavaluta.Name = "fechavaluta";
            this.fechavaluta.ReadOnly = true;
            this.fechavaluta.Width = 99;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "DESCRIPCIÓN";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 129;
            // 
            // saldo
            // 
            this.saldo.DataPropertyName = "saldo";
            this.saldo.HeaderText = "SALDO";
            this.saldo.Name = "saldo";
            this.saldo.ReadOnly = true;
            this.saldo.Visible = false;
            this.saldo.Width = 68;
            // 
            // sucursal
            // 
            this.sucursal.DataPropertyName = "sucursal";
            this.sucursal.HeaderText = "SUCURSAL";
            this.sucursal.Name = "sucursal";
            this.sucursal.ReadOnly = true;
            this.sucursal.Width = 111;
            // 
            // operacionhora
            // 
            this.operacionhora.DataPropertyName = "operacionhora";
            this.operacionhora.HeaderText = "O. HORA";
            this.operacionhora.Name = "operacionhora";
            this.operacionhora.ReadOnly = true;
            this.operacionhora.Width = 89;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "USUARIO";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 99;
            // 
            // utc
            // 
            this.utc.DataPropertyName = "utc";
            this.utc.HeaderText = "UTC";
            this.utc.Name = "utc";
            this.utc.ReadOnly = true;
            this.utc.Width = 65;
            // 
            // responsable
            // 
            this.responsable.DataPropertyName = "responsable";
            this.responsable.HeaderText = "RESPONSABLE";
            this.responsable.Name = "responsable";
            this.responsable.ReadOnly = true;
            this.responsable.Width = 139;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 94;
            // 
            // fecharegistro
            // 
            this.fecharegistro.DataPropertyName = "fecharegistro";
            this.fecharegistro.HeaderText = "F. REGISTRO";
            this.fecharegistro.Name = "fecharegistro";
            this.fecharegistro.ReadOnly = true;
            this.fecharegistro.Width = 115;
            // 
            // F1Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(1148, 553);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "F1Pagos";
            this.Text = "F1Pagos";
            this.Load += new System.EventHandler(this.F1Pagos_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.F1Pagos_KeyUp);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaI)).EndInit();
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFechaFin;
        private DevComponents.DotNetBar.LabelX lblHasta;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFechaI;
        private DevComponents.DotNetBar.LabelX lblDesde;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnumerooperacion;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lblregistros;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPagos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpago;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn codbanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaCorriente;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldofavor;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacionnumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechavaluta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn operacionhora;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn utc;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistro;
    }
}