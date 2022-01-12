namespace SGEDICALE.vista
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_descripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.cboMoneda = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ch_notacredito = new DevComponents.DotNetBar.Controls.CheckBoxX();
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
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbregistro = new DevComponents.DotNetBar.LabelX();
            this.dgvdetalle = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            this.txttotal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtsubtotal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblsubtotal = new DevComponents.DotNetBar.LabelX();
            this.lbltotal = new DevComponents.DotNetBar.LabelX();
            this.lbligv = new DevComponents.DotNetBar.LabelX();
            this.txtIgv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnPago = new DevComponents.DotNetBar.ButtonX();
            this.btnImprimir = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
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
            this.groupPanel1.Controls.Add(this.txt_descripcion);
            this.groupPanel1.Controls.Add(this.labelX11);
            this.groupPanel1.Controls.Add(this.cboMoneda);
            this.groupPanel1.Controls.Add(this.ch_notacredito);
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
            this.groupPanel1.Location = new System.Drawing.Point(5, 15);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1360, 213);
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
            this.groupPanel1.Text = "     Venta      .";
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
            this.txt_descripcion.Location = new System.Drawing.Point(716, 146);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_descripcion.MaxLength = 1000;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.PreventEnterBeep = true;
            this.txt_descripcion.Size = new System.Drawing.Size(305, 23);
            this.txt_descripcion.TabIndex = 292;
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(616, 143);
            this.labelX11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(92, 28);
            this.labelX11.TabIndex = 291;
            this.labelX11.Text = "Descripción : ";
            // 
            // cboMoneda
            // 
            this.cboMoneda.DisplayMember = "Text";
            this.cboMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMoneda.ForeColor = System.Drawing.Color.Black;
            this.cboMoneda.FormattingEnabled = true;
            this.cboMoneda.ItemHeight = 17;
            this.cboMoneda.Location = new System.Drawing.Point(716, 39);
            this.cboMoneda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMoneda.Name = "cboMoneda";
            this.cboMoneda.Size = new System.Drawing.Size(192, 23);
            this.cboMoneda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboMoneda.TabIndex = 290;
            this.cboMoneda.SelectionChangeCommitted += new System.EventHandler(this.cboMoneda_SelectionChangeCommitted);
            // 
            // ch_notacredito
            // 
            // 
            // 
            // 
            this.ch_notacredito.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ch_notacredito.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_notacredito.Location = new System.Drawing.Point(84, 4);
            this.ch_notacredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ch_notacredito.Name = "ch_notacredito";
            this.ch_notacredito.Size = new System.Drawing.Size(133, 28);
            this.ch_notacredito.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ch_notacredito.TabIndex = 289;
            this.ch_notacredito.Text = "Nota de Crédito";
            this.ch_notacredito.Visible = false;
            this.ch_notacredito.CheckedChanged += new System.EventHandler(this.ch_notacredito_CheckedChanged);
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.DisplayMember = "Text";
            this.cbFormaPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFormaPago.ForeColor = System.Drawing.Color.Black;
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.ItemHeight = 17;
            this.cbFormaPago.Location = new System.Drawing.Point(1017, 114);
            this.cbFormaPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(192, 23);
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
            this.labelX5.Location = new System.Drawing.Point(944, 111);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(64, 28);
            this.labelX5.TabIndex = 34;
            this.labelX5.Text = "F. Pago:";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // cboTiempoIMpuesto
            // 
            this.cboTiempoIMpuesto.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.cboTiempoIMpuesto.DisabledForeColor = System.Drawing.SystemColors.Window;
            this.cboTiempoIMpuesto.DisplayMember = "Text";
            this.cboTiempoIMpuesto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTiempoIMpuesto.ForeColor = System.Drawing.Color.Black;
            this.cboTiempoIMpuesto.FormattingEnabled = true;
            this.cboTiempoIMpuesto.ItemHeight = 17;
            this.cboTiempoIMpuesto.Location = new System.Drawing.Point(716, 114);
            this.cboTiempoIMpuesto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTiempoIMpuesto.Name = "cboTiempoIMpuesto";
            this.cboTiempoIMpuesto.Size = new System.Drawing.Size(192, 23);
            this.cboTiempoIMpuesto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTiempoIMpuesto.TabIndex = 33;
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
            this.lblTipo.Location = new System.Drawing.Point(589, 111);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(119, 28);
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
            this.labelX4.Location = new System.Drawing.Point(917, 43);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(91, 28);
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
            this.txttipocambio.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txttipocambio.ForeColor = System.Drawing.Color.Black;
            this.txttipocambio.Location = new System.Drawing.Point(1016, 43);
            this.txttipocambio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttipocambio.Name = "txttipocambio";
            this.txttipocambio.PreventEnterBeep = true;
            this.txttipocambio.Size = new System.Drawing.Size(141, 23);
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
            this.txtcliente.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txtcliente.ForeColor = System.Drawing.Color.Black;
            this.txtcliente.Location = new System.Drawing.Point(155, 114);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.PreventEnterBeep = true;
            this.txtcliente.Size = new System.Drawing.Size(415, 23);
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
            this.txtCorrelativo.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txtCorrelativo.ForeColor = System.Drawing.Color.Black;
            this.txtCorrelativo.Location = new System.Drawing.Point(1016, 79);
            this.txtCorrelativo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.PreventEnterBeep = true;
            this.txtCorrelativo.Size = new System.Drawing.Size(141, 23);
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
            this.labelX3.Location = new System.Drawing.Point(917, 75);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(91, 28);
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
            this.cbSerie.Location = new System.Drawing.Point(716, 79);
            this.cbSerie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSerie.Name = "cbSerie";
            this.cbSerie.Size = new System.Drawing.Size(192, 23);
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
            this.labelX2.Location = new System.Drawing.Point(656, 75);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(52, 28);
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
            this.lblMoneda.Location = new System.Drawing.Point(621, 39);
            this.lblMoneda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(87, 28);
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
            this.txtDireccion.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(104, 146);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PreventEnterBeep = true;
            this.txtDireccion.Size = new System.Drawing.Size(465, 23);
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
            this.lblDireccion.Location = new System.Drawing.Point(15, 146);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(81, 28);
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
            this.dtpFecha.IsPopupCalendarOpen = false;
            this.dtpFecha.Location = new System.Drawing.Point(104, 39);
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
            this.dtpFecha.Size = new System.Drawing.Size(136, 23);
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
            this.lblFecha.Location = new System.Drawing.Point(44, 39);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(52, 28);
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
            this.txtcodcliente.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txtcodcliente.ForeColor = System.Drawing.Color.Black;
            this.txtcodcliente.Location = new System.Drawing.Point(104, 114);
            this.txtcodcliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodcliente.Name = "txtcodcliente";
            this.txtcodcliente.PreventEnterBeep = true;
            this.txtcodcliente.Size = new System.Drawing.Size(43, 23);
            this.txtcodcliente.TabIndex = 17;
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
            this.labelX1.Location = new System.Drawing.Point(29, 111);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(67, 28);
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
            this.cbTDocumento.Location = new System.Drawing.Point(104, 79);
            this.cbTDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTDocumento.Name = "cbTDocumento";
            this.cbTDocumento.Size = new System.Drawing.Size(296, 23);
            this.cbTDocumento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTDocumento.TabIndex = 8;
            this.cbTDocumento.SelectedIndexChanged += new System.EventHandler(this.cbTDocumento_SelectedIndexChanged);
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
            this.lblTipoDocumento.Location = new System.Drawing.Point(17, 75);
            this.lblTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(79, 28);
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
            this.groupPanel2.Location = new System.Drawing.Point(5, 247);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1360, 396);
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
            // lbregistro
            // 
            this.lbregistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbregistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            // 
            // 
            // 
            this.lbregistro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbregistro.ForeColor = System.Drawing.Color.Black;
            this.lbregistro.Location = new System.Drawing.Point(15, 335);
            this.lbregistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbregistro.Name = "lbregistro";
            this.lbregistro.Size = new System.Drawing.Size(349, 22);
            this.lbregistro.TabIndex = 42;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdetalle.EnableHeadersVisualStyles = false;
            this.dgvdetalle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvdetalle.Location = new System.Drawing.Point(4, 4);
            this.dgvdetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dgvdetalle.Size = new System.Drawing.Size(1336, 319);
            this.dgvdetalle.TabIndex = 40;
            // 
            // coddetallecomprobante
            // 
            this.coddetallecomprobante.DataPropertyName = "coddetallecomprobante";
            this.coddetallecomprobante.HeaderText = "CODIGO";
            this.coddetallecomprobante.Name = "coddetallecomprobante";
            this.coddetallecomprobante.ReadOnly = true;
            this.coddetallecomprobante.Width = 92;
            // 
            // codcomprobante
            // 
            this.codcomprobante.DataPropertyName = "codcomprobante";
            this.codcomprobante.HeaderText = "CodPedido";
            this.codcomprobante.Name = "codcomprobante";
            this.codcomprobante.ReadOnly = true;
            this.codcomprobante.Visible = false;
            this.codcomprobante.Width = 84;
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
            // preciounitario
            // 
            this.preciounitario.DataPropertyName = "preciounitario";
            this.preciounitario.HeaderText = "PRECIO UNITARIO";
            this.preciounitario.Name = "preciounitario";
            this.preciounitario.ReadOnly = true;
            this.preciounitario.Width = 144;
            // 
            // valorventa
            // 
            this.valorventa.DataPropertyName = "valorventa";
            this.valorventa.HeaderText = "SUB TOTAL";
            this.valorventa.Name = "valorventa";
            this.valorventa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.valorventa.Width = 106;
            // 
            // igv
            // 
            this.igv.DataPropertyName = "igv";
            this.igv.HeaderText = "IGV";
            this.igv.Name = "igv";
            this.igv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.igv.Width = 60;
            // 
            // precioventa
            // 
            this.precioventa.DataPropertyName = "precioventa";
            this.precioventa.HeaderText = "IMPORTE";
            this.precioventa.Name = "precioventa";
            this.precioventa.ReadOnly = true;
            this.precioventa.Width = 99;
            // 
            // unidadmedida
            // 
            this.unidadmedida.DataPropertyName = "unidadmedida";
            this.unidadmedida.HeaderText = "UNIDAD";
            this.unidadmedida.Name = "unidadmedida";
            this.unidadmedida.Width = 89;
            // 
            // tipoimpuesto
            // 
            this.tipoimpuesto.DataPropertyName = "tipoimpuesto";
            this.tipoimpuesto.HeaderText = "TIPO IMPUESTO";
            this.tipoimpuesto.Name = "tipoimpuesto";
            this.tipoimpuesto.Width = 132;
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
            this.codUnidadMedida.Visible = false;
            this.codUnidadMedida.Width = 85;
            // 
            // codtipoimpuesto
            // 
            this.codtipoimpuesto.DataPropertyName = "codtipoimpuesto";
            this.codtipoimpuesto.HeaderText = "CodTipoImpuesto";
            this.codtipoimpuesto.Name = "codtipoimpuesto";
            this.codtipoimpuesto.Visible = false;
            this.codtipoimpuesto.Width = 115;
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txttotal.Border.Class = "TextBoxBorder";
            this.txttotal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttotal.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txttotal.Enabled = false;
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txttotal.Location = new System.Drawing.Point(1207, 336);
            this.txttotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttotal.Name = "txttotal";
            this.txttotal.PreventEnterBeep = true;
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(133, 23);
            this.txttotal.TabIndex = 37;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsubtotal.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtsubtotal.Border.Class = "TextBoxBorder";
            this.txtsubtotal.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsubtotal.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txtsubtotal.Enabled = false;
            this.txtsubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtsubtotal.Location = new System.Drawing.Point(795, 335);
            this.txtsubtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.PreventEnterBeep = true;
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(133, 23);
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
            this.lblsubtotal.Location = new System.Drawing.Point(716, 332);
            this.lblsubtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(83, 25);
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
            this.lbltotal.Location = new System.Drawing.Point(1152, 335);
            this.lbltotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(45, 25);
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
            this.lbligv.Location = new System.Drawing.Point(960, 332);
            this.lbligv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbligv.Name = "lbligv";
            this.lbligv.Size = new System.Drawing.Size(33, 25);
            this.lbligv.TabIndex = 34;
            this.lbligv.Text = "Igv: ";
            // 
            // txtIgv
            // 
            this.txtIgv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIgv.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.txtIgv.Border.Class = "TextBoxBorder";
            this.txtIgv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIgv.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.txtIgv.Enabled = false;
            this.txtIgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgv.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtIgv.Location = new System.Drawing.Point(1003, 334);
            this.txtIgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIgv.Name = "txtIgv";
            this.txtIgv.PreventEnterBeep = true;
            this.txtIgv.ReadOnly = true;
            this.txtIgv.Size = new System.Drawing.Size(133, 23);
            this.txtIgv.TabIndex = 35;
            // 
            // btnPago
            // 
            this.btnPago.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPago.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPago.Image = ((System.Drawing.Image)(resources.GetObject("btnPago.Image")));
            this.btnPago.Location = new System.Drawing.Point(216, 666);
            this.btnPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(119, 43);
            this.btnPago.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPago.TabIndex = 44;
            this.btnPago.Text = "Cobro";
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(357, 666);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(119, 43);
            this.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImprimir.TabIndex = 45;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(64, 666);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 43);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.TabIndex = 46;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(1368, 724);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTA";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmVenta_KeyUp);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpFecha)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbFormaPago;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTiempoIMpuesto;
        private DevComponents.DotNetBar.LabelX lblTipo;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txttipocambio;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcliente;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCorrelativo;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSerie;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblMoneda;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDireccion;
        private DevComponents.DotNetBar.LabelX lblDireccion;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFecha;
        private DevComponents.DotNetBar.LabelX lblFecha;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcodcliente;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTDocumento;
        private DevComponents.DotNetBar.LabelX lblTipoDocumento;
        private DevComponents.DotNetBar.Controls.CheckBoxX ch_notacredito;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvdetalle;
        private DevComponents.DotNetBar.Controls.TextBoxX txttotal;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsubtotal;
        private DevComponents.DotNetBar.LabelX lblsubtotal;
        private DevComponents.DotNetBar.LabelX lbltotal;
        private DevComponents.DotNetBar.LabelX lbligv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIgv;
        private DevComponents.DotNetBar.ButtonX btnPago;
        private DevComponents.DotNetBar.ButtonX btnImprimir;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboMoneda;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_descripcion;
        private DevComponents.DotNetBar.LabelX labelX11;
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
        private DevComponents.DotNetBar.LabelX lbregistro;
    }
}