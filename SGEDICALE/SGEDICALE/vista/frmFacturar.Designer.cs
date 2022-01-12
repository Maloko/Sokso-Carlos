namespace SGEDICALE.vista
{
    partial class frmFacturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturar));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbFormaPago = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cboTiempoIMpuesto = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblTipo = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txttipocambio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtcliente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCorrelativo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cbSerie = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbMoneda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblMoneda = new DevComponents.DotNetBar.LabelX();
            this.txtDireccion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDireccion = new DevComponents.DotNetBar.LabelX();
            this.dtpFecha = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblFecha = new DevComponents.DotNetBar.LabelX();
            this.txtcodcliente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cbTDocumento = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblTipoDocumento = new DevComponents.DotNetBar.LabelX();
            this.dgvdetalle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codigodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigopedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codproducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timpuesto = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.precioreal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbregistro = new DevComponents.DotNetBar.LabelX();
            this.txttotal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtsubtotal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblsubtotal = new DevComponents.DotNetBar.LabelX();
            this.lbltotal = new DevComponents.DotNetBar.LabelX();
            this.lbligv = new DevComponents.DotNetBar.LabelX();
            this.txtIgv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnPago = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btnEliminar = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cbFormaPago);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.cboTiempoIMpuesto);
            this.groupPanel1.Controls.Add(this.lblTipo);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txttipocambio);
            this.groupPanel1.Controls.Add(this.txtcliente);
            this.groupPanel1.Controls.Add(this.txtCorrelativo);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.cbSerie);
            this.groupPanel1.Controls.Add(this.cbMoneda);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.lblMoneda);
            this.groupPanel1.Controls.Add(this.txtDireccion);
            this.groupPanel1.Controls.Add(this.lblDireccion);
            this.groupPanel1.Controls.Add(this.dtpFecha);
            this.groupPanel1.Controls.Add(this.lblFecha);
            this.groupPanel1.Controls.Add(this.txtcodcliente);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.cbTDocumento);
            this.groupPanel1.Controls.Add(this.lblTipoDocumento);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(962, 155);
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
            this.groupPanel1.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupPanel1.Text = "     Venta     .";
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.DisplayMember = "Text";
            this.cbFormaPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFormaPago.Enabled = false;
            this.cbFormaPago.ForeColor = System.Drawing.Color.Black;
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.ItemHeight = 17;
            this.cbFormaPago.Location = new System.Drawing.Point(760, 74);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(145, 23);
            this.cbFormaPago.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbFormaPago.TabIndex = 35;
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
            this.labelX5.Location = new System.Drawing.Point(705, 71);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(48, 23);
            this.labelX5.TabIndex = 34;
            this.labelX5.Text = "F. Pago:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboTiempoIMpuesto
            // 
            this.cboTiempoIMpuesto.DisplayMember = "Text";
            this.cboTiempoIMpuesto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTiempoIMpuesto.Enabled = false;
            this.cboTiempoIMpuesto.ForeColor = System.Drawing.Color.Black;
            this.cboTiempoIMpuesto.FormattingEnabled = true;
            this.cboTiempoIMpuesto.ItemHeight = 17;
            this.cboTiempoIMpuesto.Location = new System.Drawing.Point(534, 74);
            this.cboTiempoIMpuesto.Name = "cboTiempoIMpuesto";
            this.cboTiempoIMpuesto.Size = new System.Drawing.Size(145, 23);
            this.cboTiempoIMpuesto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTiempoIMpuesto.TabIndex = 33;
            this.cboTiempoIMpuesto.SelectedIndexChanged += new System.EventHandler(this.cboTiempoIMpuesto_SelectedIndexChanged);
            this.cboTiempoIMpuesto.SelectionChangeCommitted += new System.EventHandler(this.cboTiempoIMpuesto_SelectionChangeCommitted);
            // 
            // lblTipo
            // 
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTipo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTipo.Location = new System.Drawing.Point(439, 71);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(89, 23);
            this.lblTipo.TabIndex = 32;
            this.lblTipo.Text = "Tipo Impuesto:";
            this.lblTipo.TextAlignment = System.Drawing.StringAlignment.Far;
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
            this.labelX4.Location = new System.Drawing.Point(685, 16);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(68, 23);
            this.labelX4.TabIndex = 31;
            this.labelX4.Text = "T. Cambio:";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txttipocambio
            // 
            this.txttipocambio.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txttipocambio.Border.Class = "TextBoxBorder";
            this.txttipocambio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttipocambio.DisabledBackColor = System.Drawing.Color.White;
            this.txttipocambio.Enabled = false;
            this.txttipocambio.ForeColor = System.Drawing.Color.Black;
            this.txttipocambio.Location = new System.Drawing.Point(759, 16);
            this.txttipocambio.Name = "txttipocambio";
            this.txttipocambio.PreventEnterBeep = true;
            this.txttipocambio.Size = new System.Drawing.Size(106, 20);
            this.txttipocambio.TabIndex = 30;
            // 
            // txtcliente
            // 
            this.txtcliente.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcliente.Border.Class = "TextBoxBorder";
            this.txtcliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcliente.DisabledBackColor = System.Drawing.Color.White;
            this.txtcliente.Enabled = false;
            this.txtcliente.ForeColor = System.Drawing.Color.Black;
            this.txtcliente.Location = new System.Drawing.Point(113, 74);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.PreventEnterBeep = true;
            this.txtcliente.Size = new System.Drawing.Size(311, 20);
            this.txtcliente.TabIndex = 29;
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
            this.txtCorrelativo.Enabled = false;
            this.txtCorrelativo.ForeColor = System.Drawing.Color.Black;
            this.txtCorrelativo.Location = new System.Drawing.Point(759, 45);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.PreventEnterBeep = true;
            this.txtCorrelativo.Size = new System.Drawing.Size(106, 20);
            this.txtCorrelativo.TabIndex = 28;
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
            this.labelX3.Location = new System.Drawing.Point(685, 42);
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
            this.cbSerie.Enabled = false;
            this.cbSerie.ForeColor = System.Drawing.Color.Black;
            this.cbSerie.FormattingEnabled = true;
            this.cbSerie.ItemHeight = 17;
            this.cbSerie.Location = new System.Drawing.Point(534, 45);
            this.cbSerie.Name = "cbSerie";
            this.cbSerie.Size = new System.Drawing.Size(145, 23);
            this.cbSerie.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbSerie.TabIndex = 26;
            this.cbSerie.SelectionChangeCommitted += new System.EventHandler(this.cbSerie_SelectionChangeCommitted);
            // 
            // cbMoneda
            // 
            this.cbMoneda.DisplayMember = "Text";
            this.cbMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMoneda.Enabled = false;
            this.cbMoneda.ForeColor = System.Drawing.Color.Black;
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.ItemHeight = 17;
            this.cbMoneda.Location = new System.Drawing.Point(534, 16);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(145, 23);
            this.cbMoneda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMoneda.TabIndex = 25;
            this.cbMoneda.SelectionChangeCommitted += new System.EventHandler(this.cbMoneda_SelectionChangeCommitted);
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
            this.labelX2.Location = new System.Drawing.Point(489, 42);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(39, 23);
            this.labelX2.TabIndex = 24;
            this.labelX2.Text = "Serie:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
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
            this.lblMoneda.Location = new System.Drawing.Point(463, 13);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(65, 23);
            this.lblMoneda.TabIndex = 23;
            this.lblMoneda.Text = "Moneda:";
            this.lblMoneda.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDireccion.Border.Class = "TextBoxBorder";
            this.txtDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDireccion.DisabledBackColor = System.Drawing.Color.White;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(75, 100);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PreventEnterBeep = true;
            this.txtDireccion.Size = new System.Drawing.Size(349, 20);
            this.txtDireccion.TabIndex = 22;
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
            this.lblDireccion.Location = new System.Drawing.Point(8, 100);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(61, 23);
            this.lblDireccion.TabIndex = 21;
            this.lblDireccion.Text = "Dirección:";
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
            this.dtpFecha.Enabled = false;
            this.dtpFecha.IsPopupCalendarOpen = false;
            this.dtpFecha.Location = new System.Drawing.Point(75, 13);
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
            this.lblFecha.Location = new System.Drawing.Point(30, 13);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(39, 23);
            this.lblFecha.TabIndex = 19;
            this.lblFecha.Text = "Fecha:";
            this.lblFecha.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // txtcodcliente
            // 
            this.txtcodcliente.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcodcliente.Border.Class = "TextBoxBorder";
            this.txtcodcliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcodcliente.DisabledBackColor = System.Drawing.Color.White;
            this.txtcodcliente.Enabled = false;
            this.txtcodcliente.ForeColor = System.Drawing.Color.Black;
            this.txtcodcliente.Location = new System.Drawing.Point(75, 74);
            this.txtcodcliente.Name = "txtcodcliente";
            this.txtcodcliente.PreventEnterBeep = true;
            this.txtcodcliente.Size = new System.Drawing.Size(32, 20);
            this.txtcodcliente.TabIndex = 17;
            this.txtcodcliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodcliente_KeyDown);
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
            this.labelX1.Location = new System.Drawing.Point(19, 71);
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
            this.cbTDocumento.Enabled = false;
            this.cbTDocumento.ForeColor = System.Drawing.Color.Black;
            this.cbTDocumento.FormattingEnabled = true;
            this.cbTDocumento.ItemHeight = 17;
            this.cbTDocumento.Location = new System.Drawing.Point(75, 45);
            this.cbTDocumento.Name = "cbTDocumento";
            this.cbTDocumento.Size = new System.Drawing.Size(223, 23);
            this.cbTDocumento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTDocumento.TabIndex = 8;
            this.cbTDocumento.SelectionChangeCommitted += new System.EventHandler(this.cbTDocumento_SelectionChangeCommitted);
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
            this.lblTipoDocumento.Location = new System.Drawing.Point(10, 42);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(59, 23);
            this.lblTipoDocumento.TabIndex = 5;
            this.lblTipoDocumento.Text = "Tipo Doc.:";
            this.lblTipoDocumento.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.AllowUserToAddRows = false;
            this.dgvdetalle.AllowUserToDeleteRows = false;
            this.dgvdetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigodetalle,
            this.codigopedido,
            this.codproducto,
            this.producto,
            this.catalogo,
            this.devolucion,
            this.talla,
            this.cantidad,
            this.precio,
            this.preciost,
            this.timpuesto,
            this.unidad,
            this.precioreal,
            this.codusuario,
            this.fecharegistro,
            this.estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdetalle.EnableHeadersVisualStyles = false;
            this.dgvdetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvdetalle.Location = new System.Drawing.Point(3, 3);
            this.dgvdetalle.Name = "dgvdetalle";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdetalle.RowHeadersVisible = false;
            this.dgvdetalle.RowTemplate.Height = 25;
            this.dgvdetalle.Size = new System.Drawing.Size(950, 248);
            this.dgvdetalle.TabIndex = 40;
            // 
            // codigodetalle
            // 
            this.codigodetalle.DataPropertyName = "coddetallepedido";
            this.codigodetalle.HeaderText = "CODIGO";
            this.codigodetalle.Name = "codigodetalle";
            this.codigodetalle.ReadOnly = true;
            this.codigodetalle.Width = 74;
            // 
            // codigopedido
            // 
            this.codigopedido.DataPropertyName = "codpedido";
            this.codigopedido.HeaderText = "CodPedido";
            this.codigopedido.Name = "codigopedido";
            this.codigopedido.ReadOnly = true;
            this.codigopedido.Visible = false;
            this.codigopedido.Width = 84;
            // 
            // codproducto
            // 
            this.codproducto.DataPropertyName = "codproducto";
            this.codproducto.HeaderText = "CodProducto";
            this.codproducto.Name = "codproducto";
            this.codproducto.ReadOnly = true;
            this.codproducto.Visible = false;
            this.codproducto.Width = 94;
            // 
            // producto
            // 
            this.producto.DataPropertyName = "producto";
            this.producto.HeaderText = "PRODUCTO";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 93;
            // 
            // catalogo
            // 
            this.catalogo.DataPropertyName = "catalogo";
            this.catalogo.HeaderText = "CATALOGO";
            this.catalogo.Name = "catalogo";
            this.catalogo.ReadOnly = true;
            this.catalogo.Width = 90;
            // 
            // devolucion
            // 
            this.devolucion.DataPropertyName = "devolucion";
            this.devolucion.HeaderText = "Devolucion";
            this.devolucion.Name = "devolucion";
            this.devolucion.ReadOnly = true;
            this.devolucion.Visible = false;
            this.devolucion.Width = 86;
            // 
            // talla
            // 
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
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "PRECIO UNITARIO";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 116;
            // 
            // preciost
            // 
            this.preciost.DataPropertyName = "preciost";
            this.preciost.HeaderText = "TOTAL st.";
            this.preciost.Name = "preciost";
            this.preciost.ReadOnly = true;
            this.preciost.Width = 75;
            // 
            // timpuesto
            // 
            this.timpuesto.HeaderText = "TIPO IMPUESTO";
            this.timpuesto.Name = "timpuesto";
            this.timpuesto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.timpuesto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.timpuesto.Width = 106;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "UNIDAD";
            this.unidad.Name = "unidad";
            this.unidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unidad.Width = 74;
            // 
            // precioreal
            // 
            this.precioreal.DataPropertyName = "precioreal";
            this.precioreal.HeaderText = "PRECIO REAL";
            this.precioreal.Name = "precioreal";
            this.precioreal.ReadOnly = true;
            this.precioreal.Width = 95;
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
            // fecharegistro
            // 
            this.fecharegistro.DataPropertyName = "fecharegistro";
            this.fecharegistro.HeaderText = "Fecha";
            this.fecharegistro.Name = "fecharegistro";
            this.fecharegistro.ReadOnly = true;
            this.fecharegistro.Visible = false;
            this.fecharegistro.Width = 62;
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
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.lbregistro);
            this.groupPanel2.Controls.Add(this.dgvdetalle);
            this.groupPanel2.Controls.Add(this.txttotal);
            this.groupPanel2.Controls.Add(this.txtsubtotal);
            this.groupPanel2.Controls.Add(this.lblsubtotal);
            this.groupPanel2.Controls.Add(this.lbltotal);
            this.groupPanel2.Controls.Add(this.lbligv);
            this.groupPanel2.Controls.Add(this.txtIgv);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(12, 175);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(962, 307);
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
            this.groupPanel2.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupPanel2.TabIndex = 41;
            this.groupPanel2.Text = "     Detalle Venta      .";
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
            this.lbregistro.Location = new System.Drawing.Point(3, 254);
            this.lbregistro.Name = "lbregistro";
            this.lbregistro.Size = new System.Drawing.Size(193, 23);
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
            this.txttotal.Enabled = false;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txttotal.Location = new System.Drawing.Point(853, 258);
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
            this.txtsubtotal.Enabled = false;
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtsubtotal.Location = new System.Drawing.Point(489, 258);
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
            this.lblsubtotal.Location = new System.Drawing.Point(430, 256);
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
            this.lbltotal.Location = new System.Drawing.Point(812, 257);
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
            this.lbligv.Location = new System.Drawing.Point(642, 256);
            this.lbligv.Name = "lbligv";
            this.lbligv.Size = new System.Drawing.Size(25, 20);
            this.lbligv.TabIndex = 34;
            this.lbligv.Text = "Igv: ";
            // 
            // txtIgv
            // 
            this.txtIgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIgv.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtIgv.Border.Class = "TextBoxBorder";
            this.txtIgv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIgv.DisabledBackColor = System.Drawing.Color.White;
            this.txtIgv.Enabled = false;
            this.txtIgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgv.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtIgv.Location = new System.Drawing.Point(674, 257);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.PreventEnterBeep = true;
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(100, 20);
            this.txtIgv.TabIndex = 35;
            // 
            // btnPago
            // 
            this.btnPago.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPago.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.Image = ((System.Drawing.Image)(resources.GetObject("btnPago.Image")));
            this.btnPago.Location = new System.Drawing.Point(148, 491);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(89, 35);
            this.btnPago.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPago.TabIndex = 43;
            this.btnPago.Text = "Pago";
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(18, 491);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 35);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.TabIndex = 42;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(256, 491);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(82, 30);
            this.btnEliminar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEliminar.TabIndex = 50;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(988, 538);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmFacturar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURAR";
            this.Load += new System.EventHandler(this.frmFacturar_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmFacturar_KeyUp);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX lblTipoDocumento;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTDocumento;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcodcliente;
        private DevComponents.DotNetBar.LabelX lblFecha;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDireccion;
        private DevComponents.DotNetBar.LabelX lblDireccion;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFecha;
        private DevComponents.DotNetBar.LabelX lblMoneda;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCorrelativo;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSerie;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMoneda;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvdetalle;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX lbregistro;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcliente;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txttipocambio;
        private DevComponents.DotNetBar.Controls.TextBoxX txttotal;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsubtotal;
        private DevComponents.DotNetBar.LabelX lblsubtotal;
        private DevComponents.DotNetBar.LabelX lbltotal;
        private DevComponents.DotNetBar.LabelX lbligv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIgv;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTiempoIMpuesto;
        private DevComponents.DotNetBar.LabelX lblTipo;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFormaPago;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn codproducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn talla;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciost;
        private System.Windows.Forms.DataGridViewComboBoxColumn timpuesto;
        private System.Windows.Forms.DataGridViewComboBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioreal;
        private System.Windows.Forms.DataGridViewTextBoxColumn codusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private DevComponents.DotNetBar.ButtonX btnEliminar;
    }
}