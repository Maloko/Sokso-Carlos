namespace SGEDICALE.vista
{
    partial class frm_NotadeCredito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NotadeCredito));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txt_descripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboMoneda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblMoneda = new DevComponents.DotNetBar.LabelX();
            this.txtcodComprobante = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbMotivo = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtpromotor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCorrelativo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbSerie = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtdocref = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDireccion = new DevComponents.DotNetBar.LabelX();
            this.dtpFecha = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblFecha = new DevComponents.DotNetBar.LabelX();
            this.txtCod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbTDocumento = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblTipoDocumento = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvdetalle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lbregistro = new DevComponents.DotNetBar.LabelX();
            this.txttotal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtsubtotal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblsubtotal = new DevComponents.DotNetBar.LabelX();
            this.lbltotal = new DevComponents.DotNetBar.LabelX();
            this.lbligv = new DevComponents.DotNetBar.LabelX();
            this.txtIgv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnImprimir = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btnnuevo = new DevComponents.DotNetBar.ButtonX();
            this.btnClean = new DevComponents.DotNetBar.ButtonX();
            this.coddetallecomprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codcomprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciounitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadmedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoimpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codtipoimpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.txt_descripcion);
            this.groupPanel1.Controls.Add(this.cboMoneda);
            this.groupPanel1.Controls.Add(this.lblMoneda);
            this.groupPanel1.Controls.Add(this.txtcodComprobante);
            this.groupPanel1.Controls.Add(this.cbMotivo);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txtpromotor);
            this.groupPanel1.Controls.Add(this.txtCorrelativo);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.cbSerie);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtdocref);
            this.groupPanel1.Controls.Add(this.lblDireccion);
            this.groupPanel1.Controls.Add(this.dtpFecha);
            this.groupPanel1.Controls.Add(this.lblFecha);
            this.groupPanel1.Controls.Add(this.txtCod);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.cbTDocumento);
            this.groupPanel1.Controls.Add(this.lblTipoDocumento);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1133, 157);
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
            this.groupPanel1.TabIndex = 6;
            this.groupPanel1.Text = "     Nota de Crédito     .";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX5.Location = new System.Drawing.Point(477, 69);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(65, 23);
            this.labelX5.TabIndex = 295;
            this.labelX5.Text = "Descripción:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_descripcion.Border.Class = "TextBoxBorder";
            this.txt_descripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_descripcion.DisabledBackColor = System.Drawing.Color.White;
            this.txt_descripcion.ForeColor = System.Drawing.Color.Black;
            this.txt_descripcion.Location = new System.Drawing.Point(548, 72);
            this.txt_descripcion.MaxLength = 1000;
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.PreventEnterBeep = true;
            this.txt_descripcion.Size = new System.Drawing.Size(341, 32);
            this.txt_descripcion.TabIndex = 294;
            // 
            // cboMoneda
            // 
            this.cboMoneda.DisplayMember = "Text";
            this.cboMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMoneda.ForeColor = System.Drawing.Color.Black;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.ItemHeight = 17;
            this.cboMoneda.Location = new System.Drawing.Point(548, 46);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(145, 23);
            this.cboMoneda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMoneda.TabIndex = 292;
            // 
            // lblMoneda
            // 
            this.lblMoneda.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblMoneda.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMoneda.Location = new System.Drawing.Point(477, 43);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(65, 23);
            this.lblMoneda.TabIndex = 291;
            this.lblMoneda.Text = "Moneda:";
            this.lblMoneda.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtcodComprobante
            // 
            this.txtcodComprobante.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcodComprobante.Border.Class = "TextBoxBorder";
            this.txtcodComprobante.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcodComprobante.DisabledBackColor = System.Drawing.Color.White;
            this.txtcodComprobante.ForeColor = System.Drawing.Color.Black;
            this.txtcodComprobante.Location = new System.Drawing.Point(238, 72);
            this.txtcodComprobante.Name = "txtcodComprobante";
            this.txtcodComprobante.PreventEnterBeep = true;
            this.txtcodComprobante.ReadOnly = true;
            this.txtcodComprobante.Size = new System.Drawing.Size(159, 20);
            this.txtcodComprobante.TabIndex = 32;
            this.txtcodComprobante.Visible = false;
            this.txtcodComprobante.WatermarkText = "F1";
            // 
            // cbMotivo
            // 
            this.cbMotivo.DisplayMember = "Text";
            this.cbMotivo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMotivo.ForeColor = System.Drawing.Color.Black;
            this.cbMotivo.FormattingEnabled = true;
            this.cbMotivo.ItemHeight = 17;
            this.cbMotivo.Location = new System.Drawing.Point(73, 98);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Size = new System.Drawing.Size(223, 23);
            this.cbMotivo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMotivo.TabIndex = 31;
            this.cbMotivo.SelectedIndexChanged += new System.EventHandler(this.cbMotivo_SelectedIndexChanged);
            this.cbMotivo.SelectionChangeCommitted += new System.EventHandler(this.cbMotivo_SelectionChangeCommitted);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX4.Location = new System.Drawing.Point(6, 95);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(61, 23);
            this.labelX4.TabIndex = 30;
            this.labelX4.Text = "Motivo:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtpromotor
            // 
            this.txtpromotor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtpromotor.Border.Class = "TextBoxBorder";
            this.txtpromotor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpromotor.DisabledBackColor = System.Drawing.Color.White;
            this.txtpromotor.ForeColor = System.Drawing.Color.Black;
            this.txtpromotor.Location = new System.Drawing.Point(110, 46);
            this.txtpromotor.Name = "txtpromotor";
            this.txtpromotor.PreventEnterBeep = true;
            this.txtpromotor.ReadOnly = true;
            this.txtpromotor.Size = new System.Drawing.Size(311, 20);
            this.txtpromotor.TabIndex = 29;
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCorrelativo.Border.Class = "TextBoxBorder";
            this.txtCorrelativo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCorrelativo.DisabledBackColor = System.Drawing.Color.White;
            this.txtCorrelativo.ForeColor = System.Drawing.Color.Black;
            this.txtCorrelativo.Location = new System.Drawing.Point(783, 20);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.PreventEnterBeep = true;
            this.txtCorrelativo.ReadOnly = true;
            this.txtCorrelativo.Size = new System.Drawing.Size(106, 20);
            this.txtCorrelativo.TabIndex = 28;
            this.txtCorrelativo.WatermarkColor = System.Drawing.SystemColors.Control;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX3.Location = new System.Drawing.Point(709, 17);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(68, 23);
            this.labelX3.TabIndex = 27;
            this.labelX3.Text = "Correlativo:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbSerie
            // 
            this.cbSerie.DisplayMember = "Text";
            this.cbSerie.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSerie.ForeColor = System.Drawing.Color.Black;
            this.cbSerie.FormattingEnabled = true;
            this.cbSerie.ItemHeight = 17;
            this.cbSerie.Location = new System.Drawing.Point(548, 20);
            this.cbSerie.Name = "cbSerie";
            this.cbSerie.Size = new System.Drawing.Size(145, 23);
            this.cbSerie.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbSerie.TabIndex = 26;
            this.cbSerie.SelectionChangeCommitted += new System.EventHandler(this.cbSerie_SelectionChangeCommitted);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX2.Location = new System.Drawing.Point(503, 17);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(39, 23);
            this.labelX2.TabIndex = 24;
            this.labelX2.Text = "Serie:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtdocref
            // 
            this.txtdocref.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtdocref.Border.Class = "TextBoxBorder";
            this.txtdocref.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdocref.DisabledBackColor = System.Drawing.Color.White;
            this.txtdocref.ForeColor = System.Drawing.Color.Black;
            this.txtdocref.Location = new System.Drawing.Point(73, 72);
            this.txtdocref.Name = "txtdocref";
            this.txtdocref.PreventEnterBeep = true;
            this.txtdocref.ReadOnly = true;
            this.txtdocref.Size = new System.Drawing.Size(159, 20);
            this.txtdocref.TabIndex = 22;
            this.txtdocref.WatermarkText = "F1";
            this.txtdocref.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtdocref_KeyDown);
            // 
            // lblDireccion
            // 
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblDireccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDireccion.Location = new System.Drawing.Point(6, 72);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(61, 23);
            this.lblDireccion.TabIndex = 21;
            this.lblDireccion.Text = "Doc. Ref.:";
            this.lblDireccion.TextAlignment = System.Drawing.StringAlignment.Far;
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
            this.dtpFecha.Location = new System.Drawing.Point(73, 17);
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
            this.dtpFecha.MonthCalendar.DisplayMonth = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFecha.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpFecha.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFecha.MonthCalendar.TodayButtonVisible = true;
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(102, 20);
            this.dtpFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFecha.TabIndex = 20;
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
            this.lblFecha.Location = new System.Drawing.Point(28, 17);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(39, 23);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCod.Border.Class = "TextBoxBorder";
            this.txtCod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCod.DisabledBackColor = System.Drawing.Color.White;
            this.txtCod.ForeColor = System.Drawing.Color.Black;
            this.txtCod.Location = new System.Drawing.Point(72, 46);
            this.txtCod.Name = "txtCod";
            this.txtCod.PreventEnterBeep = true;
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(32, 20);
            this.txtCod.TabIndex = 17;
            this.txtCod.WatermarkText = "F1";
            this.txtCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodcliente_KeyDown);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX1.Location = new System.Drawing.Point(16, 43);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(50, 23);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "Cliente:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cbTDocumento
            // 
            this.cbTDocumento.DisplayMember = "Text";
            this.cbTDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTDocumento.ForeColor = System.Drawing.Color.Black;
            this.cbTDocumento.FormattingEnabled = true;
            this.cbTDocumento.ItemHeight = 17;
            this.cbTDocumento.Location = new System.Drawing.Point(264, 17);
            this.cbTDocumento.Name = "cbTDocumento";
            this.cbTDocumento.Size = new System.Drawing.Size(223, 23);
            this.cbTDocumento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTDocumento.TabIndex = 8;
            this.cbTDocumento.SelectionChangeCommitted += new System.EventHandler(this.cbTDocumento_SelectionChangeCommitted);
            this.cbTDocumento.SelectedValueChanged += new System.EventHandler(this.cbTDocumento_SelectedValueChanged);
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTipoDocumento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDocumento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTipoDocumento.Location = new System.Drawing.Point(199, 14);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(59, 23);
            this.lblTipoDocumento.TabIndex = 5;
            this.lblTipoDocumento.Text = "Tipo Doc.:";
            this.lblTipoDocumento.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dgvdetalle);
            this.groupPanel2.Controls.Add(this.lbregistro);
            this.groupPanel2.Controls.Add(this.txttotal);
            this.groupPanel2.Controls.Add(this.txtsubtotal);
            this.groupPanel2.Controls.Add(this.lblsubtotal);
            this.groupPanel2.Controls.Add(this.lbltotal);
            this.groupPanel2.Controls.Add(this.lbligv);
            this.groupPanel2.Controls.Add(this.txtIgv);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(12, 217);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1133, 291);
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
            this.groupPanel2.TabIndex = 43;
            this.groupPanel2.Text = "Detalle Venta";
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.AllowUserToAddRows = false;
            this.dgvdetalle.AllowUserToDeleteRows = false;
            this.dgvdetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetalle.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coddetallecomprobante,
            this.codcomprobante,
            this.codproducto,
            this.producto,
            this.catalogo,
            this.talla,
            this.cantidad,
            this.preciounitario,
            this.valorventa,
            this.igv,
            this.precioventa,
            this.unidadmedida,
            this.tipoimpuesto,
            this.codusuario,
            this.estado,
            this.fecharegistro,
            this.codUnidadMedida,
            this.codtipoimpuesto});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdetalle.EnableHeadersVisualStyles = false;
            this.dgvdetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvdetalle.Location = new System.Drawing.Point(3, 3);
            this.dgvdetalle.Name = "dgvdetalle";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdetalle.RowHeadersVisible = false;
            this.dgvdetalle.RowTemplate.Height = 25;
            this.dgvdetalle.Size = new System.Drawing.Size(1121, 234);
            this.dgvdetalle.TabIndex = 40;
            this.dgvdetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetalle_CellClick);
            this.dgvdetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetalle_CellEndEdit);
            this.dgvdetalle.CurrentCellChanged += new System.EventHandler(this.dgvdetalle_CurrentCellChanged);
            this.dgvdetalle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvdetalle_EditingControlShowing);
            this.dgvdetalle.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvdetalle_RowsRemoved);
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
            this.lbregistro.Location = new System.Drawing.Point(3, 242);
            this.lbregistro.Name = "lbregistro";
            this.lbregistro.Size = new System.Drawing.Size(196, 23);
            this.lbregistro.TabIndex = 41;
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txttotal.Border.Class = "TextBoxBorder";
            this.txttotal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttotal.DisabledBackColor = System.Drawing.Color.White;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.Black;
            this.txttotal.Location = new System.Drawing.Point(1018, 245);
            this.txttotal.Name = "txttotal";
            this.txttotal.PreventEnterBeep = true;
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 37;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsubtotal.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtsubtotal.Border.Class = "TextBoxBorder";
            this.txtsubtotal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsubtotal.DisabledBackColor = System.Drawing.Color.White;
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.ForeColor = System.Drawing.Color.Black;
            this.txtsubtotal.Location = new System.Drawing.Point(718, 245);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.PreventEnterBeep = true;
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtsubtotal.TabIndex = 33;
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblsubtotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.ForeColor = System.Drawing.Color.Black;
            this.lblsubtotal.Location = new System.Drawing.Point(659, 243);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(62, 20);
            this.lblsubtotal.TabIndex = 32;
            this.lblsubtotal.Text = "SubTotal: ";
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbltotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.Black;
            this.lbltotal.Location = new System.Drawing.Point(977, 244);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(34, 20);
            this.lbltotal.TabIndex = 36;
            this.lbltotal.Text = "Total: ";
            // 
            // lbligv
            // 
            this.lbligv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbligv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbligv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbligv.ForeColor = System.Drawing.Color.Black;
            this.lbligv.Location = new System.Drawing.Point(833, 244);
            this.lbligv.Name = "lbligv";
            this.lbligv.Size = new System.Drawing.Size(25, 20);
            this.lbligv.TabIndex = 34;
            this.lbligv.Text = "Igv: ";
            // 
            // txtIgv
            // 
            this.txtIgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIgv.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtIgv.Border.Class = "TextBoxBorder";
            this.txtIgv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIgv.DisabledBackColor = System.Drawing.Color.White;
            this.txtIgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgv.ForeColor = System.Drawing.Color.Black;
            this.txtIgv.Location = new System.Drawing.Point(865, 245);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.PreventEnterBeep = true;
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(100, 20);
            this.txtIgv.TabIndex = 35;
            // 
            // btnImprimir
            // 
            this.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(318, 525);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(82, 30);
            this.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImprimir.TabIndex = 49;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(221, 525);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 30);
            this.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEliminar.TabIndex = 48;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(125, 525);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 30);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnnuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(31, 525);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(82, 30);
            this.btnnuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnuevo.TabIndex = 51;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnClean
            // 
            this.btnClean.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClean.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.Image")));
            this.btnClean.Location = new System.Drawing.Point(1044, 181);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(89, 30);
            this.btnClean.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClean.TabIndex = 52;
            this.btnClean.Text = "Limpiar";
            this.btnClean.Visible = false;
            this.btnClean.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // coddetallecomprobante
            // 
            this.coddetallecomprobante.DataPropertyName = "coddetallecomprobante";
            this.coddetallecomprobante.HeaderText = "CODIGO";
            this.coddetallecomprobante.Name = "coddetallecomprobante";
            this.coddetallecomprobante.ReadOnly = true;
            this.coddetallecomprobante.Visible = false;
            this.coddetallecomprobante.Width = 55;
            // 
            // codcomprobante
            // 
            this.codcomprobante.DataPropertyName = "codcomprobante";
            this.codcomprobante.HeaderText = "CodPedido";
            this.codcomprobante.Name = "codcomprobante";
            this.codcomprobante.ReadOnly = true;
            this.codcomprobante.Visible = false;
            this.codcomprobante.Width = 65;
            // 
            // codproducto
            // 
            this.codproducto.DataPropertyName = "codproducto";
            this.codproducto.HeaderText = "CodProducto";
            this.codproducto.Name = "codproducto";
            this.codproducto.ReadOnly = true;
            this.codproducto.Visible = false;
            this.codproducto.Width = 75;
            // 
            // producto
            // 
            this.producto.DataPropertyName = "producto";
            this.producto.HeaderText = "PRODUCTO";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 600;
            // 
            // catalogo
            // 
            this.catalogo.DataPropertyName = "catalogo";
            this.catalogo.HeaderText = "CATALOGO";
            this.catalogo.Name = "catalogo";
            this.catalogo.ReadOnly = true;
            this.catalogo.Visible = false;
            this.catalogo.Width = 90;
            // 
            // talla
            // 
            this.talla.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.talla.DataPropertyName = "talla";
            this.talla.HeaderText = "TALLA";
            this.talla.Name = "talla";
            this.talla.ReadOnly = true;
            this.talla.Width = 65;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 87;
            // 
            // preciounitario
            // 
            this.preciounitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.preciounitario.DataPropertyName = "preciounitario";
            this.preciounitario.HeaderText = "PRECIO UNITARIO";
            this.preciounitario.Name = "preciounitario";
            this.preciounitario.ReadOnly = true;
            this.preciounitario.Width = 116;
            // 
            // valorventa
            // 
            this.valorventa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valorventa.DataPropertyName = "valorventa";
            this.valorventa.HeaderText = "SUB TOTAL";
            this.valorventa.Name = "valorventa";
            this.valorventa.ReadOnly = true;
            this.valorventa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.valorventa.Width = 85;
            // 
            // igv
            // 
            this.igv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.igv.DataPropertyName = "igv";
            this.igv.HeaderText = "IGV";
            this.igv.Name = "igv";
            this.igv.ReadOnly = true;
            this.igv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.igv.Width = 50;
            // 
            // precioventa
            // 
            this.precioventa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.precioventa.DataPropertyName = "precioventa";
            this.precioventa.HeaderText = "IMPORTE";
            this.precioventa.Name = "precioventa";
            this.precioventa.Width = 81;
            // 
            // unidadmedida
            // 
            this.unidadmedida.DataPropertyName = "unidadmedida";
            this.unidadmedida.HeaderText = "UNIDAD";
            this.unidadmedida.Name = "unidadmedida";
            this.unidadmedida.ReadOnly = true;
            this.unidadmedida.Visible = false;
            this.unidadmedida.Width = 74;
            // 
            // tipoimpuesto
            // 
            this.tipoimpuesto.DataPropertyName = "tipoimpuesto";
            this.tipoimpuesto.HeaderText = "TIPO IMPUESTO";
            this.tipoimpuesto.Name = "tipoimpuesto";
            this.tipoimpuesto.ReadOnly = true;
            this.tipoimpuesto.Visible = false;
            this.tipoimpuesto.Width = 106;
            // 
            // codusuario
            // 
            this.codusuario.DataPropertyName = "codusuario";
            this.codusuario.HeaderText = "CodUsuario";
            this.codusuario.Name = "codusuario";
            this.codusuario.ReadOnly = true;
            this.codusuario.Visible = false;
            this.codusuario.Width = 87;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Visible = false;
            this.estado.Width = 65;
            // 
            // fecharegistro
            // 
            this.fecharegistro.DataPropertyName = "fecharegistro";
            this.fecharegistro.HeaderText = "Fecha";
            this.fecharegistro.Name = "fecharegistro";
            this.fecharegistro.ReadOnly = true;
            this.fecharegistro.Visible = false;
            this.fecharegistro.Width = 62;
            // 
            // codUnidadMedida
            // 
            this.codUnidadMedida.DataPropertyName = "codUnidadMedida";
            this.codUnidadMedida.HeaderText = "CodUnidad";
            this.codUnidadMedida.Name = "codUnidadMedida";
            this.codUnidadMedida.ReadOnly = true;
            this.codUnidadMedida.Visible = false;
            this.codUnidadMedida.Width = 85;
            // 
            // codtipoimpuesto
            // 
            this.codtipoimpuesto.DataPropertyName = "codtipoimpuesto";
            this.codtipoimpuesto.HeaderText = "CodTipoImpuesto";
            this.codtipoimpuesto.Name = "codtipoimpuesto";
            this.codtipoimpuesto.ReadOnly = true;
            this.codtipoimpuesto.Visible = false;
            this.codtipoimpuesto.Width = 115;
            // 
            // frm_NotadeCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(1157, 557);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_NotadeCredito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOTA DE CRÉDITO";
            this.Load += new System.EventHandler(this.frm_NotadeCredito_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_NotadeCredito_KeyUp);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpromotor;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCorrelativo;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSerie;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdocref;
        private DevComponents.DotNetBar.LabelX lblDireccion;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFecha;
        private DevComponents.DotNetBar.LabelX lblFecha;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCod;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTDocumento;
        private DevComponents.DotNetBar.LabelX lblTipoDocumento;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMotivo;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX lbregistro;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvdetalle;
        private DevComponents.DotNetBar.Controls.TextBoxX txttotal;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsubtotal;
        private DevComponents.DotNetBar.LabelX lblsubtotal;
        private DevComponents.DotNetBar.LabelX lbltotal;
        private DevComponents.DotNetBar.LabelX lbligv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIgv;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.ButtonX btnEliminar;
        private DevComponents.DotNetBar.ButtonX btnImprimir;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcodComprobante;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMoneda;
        private DevComponents.DotNetBar.LabelX lblMoneda;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_descripcion;
        private DevComponents.DotNetBar.ButtonX btnnuevo;
        private DevComponents.DotNetBar.ButtonX btnClean;
        private System.Windows.Forms.DataGridViewTextBoxColumn coddetallecomprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcomprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn codproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn talla;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadmedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoimpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn codtipoimpuesto;
    }
}