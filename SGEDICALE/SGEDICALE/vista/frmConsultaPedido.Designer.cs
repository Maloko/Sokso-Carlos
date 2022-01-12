namespace SGEDICALE.vista
{
    partial class frmConsultaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaPedido));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtPromotor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblPromotor = new DevComponents.DotNetBar.LabelX();
            this.dtpFecha = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblFecha = new DevComponents.DotNetBar.LabelX();
            this.txtnumeropedido = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblnumero = new DevComponents.DotNetBar.LabelX();
            this.txtcodigo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblcodigo = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblregistro = new DevComponents.DotNetBar.LabelX();
            this.dgvdetallepedido = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codigodetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigopedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblsubtotal = new DevComponents.DotNetBar.LabelX();
            this.txtsubtotal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtIgv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbligv = new DevComponents.DotNetBar.LabelX();
            this.txttotal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbltotal = new DevComponents.DotNetBar.LabelX();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lbl1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetallepedido)).BeginInit();
            this.groupPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtPromotor);
            this.groupPanel1.Controls.Add(this.lblPromotor);
            this.groupPanel1.Controls.Add(this.dtpFecha);
            this.groupPanel1.Controls.Add(this.lblFecha);
            this.groupPanel1.Controls.Add(this.txtnumeropedido);
            this.groupPanel1.Controls.Add(this.lblnumero);
            this.groupPanel1.Controls.Add(this.txtcodigo);
            this.groupPanel1.Controls.Add(this.lblcodigo);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(16, 15);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(947, 98);
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
            this.groupPanel1.Text = "     Pedido      .";
            // 
            // txtPromotor
            // 
            this.txtPromotor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPromotor.Border.Class = "TextBoxBorder";
            this.txtPromotor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPromotor.DisabledBackColor = System.Drawing.Color.White;
            this.txtPromotor.ForeColor = System.Drawing.Color.Black;
            this.txtPromotor.Location = new System.Drawing.Point(372, 34);
            this.txtPromotor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPromotor.Name = "txtPromotor";
            this.txtPromotor.PreventEnterBeep = true;
            this.txtPromotor.ReadOnly = true;
            this.txtPromotor.Size = new System.Drawing.Size(371, 22);
            this.txtPromotor.TabIndex = 13;
            // 
            // lblPromotor
            // 
            // 
            // 
            // 
            this.lblPromotor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblPromotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromotor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPromotor.Location = new System.Drawing.Point(283, 34);
            this.lblPromotor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblPromotor.Name = "lblPromotor";
            this.lblPromotor.Size = new System.Drawing.Size(81, 25);
            this.lblPromotor.TabIndex = 12;
            this.lblPromotor.Text = "Promotor:";
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
            this.dtpFecha.Location = new System.Drawing.Point(372, 2);
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
            this.dtpFecha.Size = new System.Drawing.Size(196, 22);
            this.dtpFecha.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFecha.TabIndex = 11;
            // 
            // lblFecha
            // 
            // 
            // 
            // 
            this.lblFecha.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(301, 4);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(63, 25);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha: ";
            // 
            // txtnumeropedido
            // 
            this.txtnumeropedido.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtnumeropedido.Border.Class = "TextBoxBorder";
            this.txtnumeropedido.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnumeropedido.DisabledBackColor = System.Drawing.Color.White;
            this.txtnumeropedido.ForeColor = System.Drawing.Color.Black;
            this.txtnumeropedido.Location = new System.Drawing.Point(117, 36);
            this.txtnumeropedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnumeropedido.Name = "txtnumeropedido";
            this.txtnumeropedido.PreventEnterBeep = true;
            this.txtnumeropedido.ReadOnly = true;
            this.txtnumeropedido.Size = new System.Drawing.Size(133, 22);
            this.txtnumeropedido.TabIndex = 9;
            // 
            // lblnumero
            // 
            // 
            // 
            // 
            this.lblnumero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(19, 36);
            this.lblnumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(83, 25);
            this.lblnumero.TabIndex = 8;
            this.lblnumero.Text = "N° Pedido:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcodigo.Border.Class = "TextBoxBorder";
            this.txtcodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcodigo.DisabledBackColor = System.Drawing.Color.White;
            this.txtcodigo.ForeColor = System.Drawing.Color.Black;
            this.txtcodigo.Location = new System.Drawing.Point(117, 4);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PreventEnterBeep = true;
            this.txtcodigo.ReadOnly = true;
            this.txtcodigo.Size = new System.Drawing.Size(133, 22);
            this.txtcodigo.TabIndex = 7;
            // 
            // lblcodigo
            // 
            // 
            // 
            // 
            this.lblcodigo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(37, 4);
            this.lblcodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(64, 25);
            this.lblcodigo.TabIndex = 6;
            this.lblcodigo.Text = "Codigo: ";
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.lblregistro);
            this.groupPanel2.Controls.Add(this.dgvdetallepedido);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(16, 121);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(947, 282);
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
            this.groupPanel2.TabIndex = 1;
            this.groupPanel2.Text = "     Detalle      .";
            // 
            // lblregistro
            // 
            this.lblregistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.lblregistro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistro.ForeColor = System.Drawing.Color.Black;
            this.lblregistro.Location = new System.Drawing.Point(4, 231);
            this.lblregistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblregistro.Name = "lblregistro";
            this.lblregistro.Size = new System.Drawing.Size(456, 25);
            this.lblregistro.TabIndex = 4;
            // 
            // dgvdetallepedido
            // 
            this.dgvdetallepedido.AllowUserToAddRows = false;
            this.dgvdetallepedido.AllowUserToDeleteRows = false;
            this.dgvdetallepedido.AllowUserToResizeRows = false;
            this.dgvdetallepedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetallepedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdetallepedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdetallepedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetallepedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigodetalle,
            this.codigopedido,
            this.producto,
            this.catalogo,
            this.devolucion,
            this.talla,
            this.cantidad,
            this.precio,
            this.preciost,
            this.codusuario,
            this.fecharegistro,
            this.estado,
            this.color});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdetallepedido.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdetallepedido.EnableHeadersVisualStyles = false;
            this.dgvdetallepedido.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvdetallepedido.Location = new System.Drawing.Point(4, 4);
            this.dgvdetallepedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvdetallepedido.Name = "dgvdetallepedido";
            this.dgvdetallepedido.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdetallepedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdetallepedido.RowHeadersVisible = false;
            this.dgvdetallepedido.RowTemplate.Height = 30;
            this.dgvdetallepedido.Size = new System.Drawing.Size(929, 225);
            this.dgvdetallepedido.TabIndex = 0;
            // 
            // codigodetalle
            // 
            this.codigodetalle.DataPropertyName = "coddetallepedido";
            this.codigodetalle.HeaderText = "CODDETALLE";
            this.codigodetalle.Name = "codigodetalle";
            this.codigodetalle.ReadOnly = true;
            this.codigodetalle.Width = 129;
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
            // producto
            // 
            this.producto.DataPropertyName = "producto";
            this.producto.HeaderText = "PRODUCTO";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 116;
            // 
            // catalogo
            // 
            this.catalogo.DataPropertyName = "catalogo";
            this.catalogo.HeaderText = "CATALOGO";
            this.catalogo.Name = "catalogo";
            this.catalogo.ReadOnly = true;
            this.catalogo.Width = 114;
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
            this.talla.Width = 80;
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "cantidad";
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 106;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "P. PROMOTOR";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 125;
            // 
            // preciost
            // 
            this.preciost.DataPropertyName = "preciost";
            this.preciost.HeaderText = "St. PROMOTOR";
            this.preciost.Name = "preciost";
            this.preciost.ReadOnly = true;
            this.preciost.Width = 128;
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
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "Color";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Visible = false;
            this.color.Width = 56;
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lblsubtotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblsubtotal.Location = new System.Drawing.Point(729, 410);
            this.lblsubtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(83, 25);
            this.lblsubtotal.TabIndex = 7;
            this.lblsubtotal.Text = "SubTotal: ";
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
            this.txtsubtotal.Location = new System.Drawing.Point(820, 410);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.PreventEnterBeep = true;
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(133, 23);
            this.txtsubtotal.TabIndex = 8;
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
            this.txtIgv.Location = new System.Drawing.Point(820, 442);
            this.txtIgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.PreventEnterBeep = true;
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(133, 23);
            this.txtIgv.TabIndex = 10;
            // 
            // lbligv
            // 
            this.lbligv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbligv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbligv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbligv.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbligv.Location = new System.Drawing.Point(765, 441);
            this.lbligv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbligv.Name = "lbligv";
            this.lbligv.Size = new System.Drawing.Size(33, 25);
            this.lbligv.TabIndex = 9;
            this.lbligv.Text = "Igv: ";
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
            this.txttotal.Location = new System.Drawing.Point(820, 474);
            this.txttotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttotal.Name = "txttotal";
            this.txttotal.PreventEnterBeep = true;
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(133, 23);
            this.txttotal.TabIndex = 12;
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbltotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbltotal.Location = new System.Drawing.Point(753, 473);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(45, 25);
            this.lbltotal.TabIndex = 11;
            this.lbltotal.Text = "Total: ";
            // 
            // groupPanel3
            // 
            this.groupPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.labelX3);
            this.groupPanel3.Controls.Add(this.labelX2);
            this.groupPanel3.Controls.Add(this.labelX1);
            this.groupPanel3.Controls.Add(this.lbl1);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(16, 410);
            this.groupPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(301, 87);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 21;
            this.groupPanel3.Text = "Leyenda";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX3.Location = new System.Drawing.Point(99, 28);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.SingleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX3.Size = new System.Drawing.Size(169, 30);
            this.labelX3.TabIndex = 3;
            this.labelX3.Text = "Producto no encontrado";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.CornflowerBlue;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(4, 36);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(67, 14);
            this.labelX2.TabIndex = 2;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelX1.Location = new System.Drawing.Point(99, 4);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.SingleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelX1.Size = new System.Drawing.Size(127, 30);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "Diferencia Precio";
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.LightCoral;
            // 
            // 
            // 
            this.lbl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl1.Location = new System.Drawing.Point(4, 14);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(67, 14);
            this.lbl1.TabIndex = 0;
            // 
            // frmConsultaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(973, 506);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txtIgv);
            this.Controls.Add(this.lbligv);
            this.Controls.Add(this.txtsubtotal);
            this.Controls.Add(this.lblsubtotal);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConsultaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA PEDIDO";
            this.Load += new System.EventHandler(this.frmConsultaPedido_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmConsultaPedido_KeyUp);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetallepedido)).EndInit();
            this.groupPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvdetallepedido;
        private DevComponents.DotNetBar.LabelX lblcodigo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcodigo;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnumeropedido;
        private DevComponents.DotNetBar.LabelX lblnumero;
        private DevComponents.DotNetBar.LabelX lblFecha;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFecha;
        private DevComponents.DotNetBar.LabelX lblregistro;
        private DevComponents.DotNetBar.LabelX lblsubtotal;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsubtotal;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIgv;
        private DevComponents.DotNetBar.LabelX lbligv;
        private DevComponents.DotNetBar.Controls.TextBoxX txttotal;
        private DevComponents.DotNetBar.LabelX lbltotal;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPromotor;
        private DevComponents.DotNetBar.LabelX lblPromotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigodetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn talla;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciost;
        private System.Windows.Forms.DataGridViewTextBoxColumn codusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.LabelX lbl1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}