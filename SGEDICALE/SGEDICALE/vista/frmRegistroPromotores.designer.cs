namespace SGEDICALE.vista
{
    partial class frmRegistroPromotor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroPromotor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cboTipoPromotor = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtcorreo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtCodigoSap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.cboTipoDocumento = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblTipoDocumento = new DevComponents.DotNetBar.LabelX();
            this.btnListar = new DevComponents.DotNetBar.ButtonX();
            this.btnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.btnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.cboEstado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lblDocumento = new DevComponents.DotNetBar.LabelX();
            this.txtdocumento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblDireccion = new DevComponents.DotNetBar.LabelX();
            this.txtDireccion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblCod = new DevComponents.DotNetBar.LabelX();
            this.txtcod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblNombre = new DevComponents.DotNetBar.LabelX();
            this.txtnombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbregistro = new DevComponents.DotNetBar.LabelX();
            this.dgvPromotores = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lblTelefono = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dtpFechaNac = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.txtTelefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtRazonSocial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.codpromotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codtipodocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigosap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codtipopersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipopersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonsocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNac)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtRazonSocial);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.cboTipoPromotor);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txtcorreo);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtCodigoSap);
            this.groupPanel1.Controls.Add(this.btnBuscar);
            this.groupPanel1.Controls.Add(this.cboTipoDocumento);
            this.groupPanel1.Controls.Add(this.lblTipoDocumento);
            this.groupPanel1.Controls.Add(this.dtpFechaNac);
            this.groupPanel1.Controls.Add(this.btnListar);
            this.groupPanel1.Controls.Add(this.btnGuardar);
            this.groupPanel1.Controls.Add(this.btnLimpiar);
            this.groupPanel1.Controls.Add(this.cboEstado);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.lblTelefono);
            this.groupPanel1.Controls.Add(this.txtTelefono);
            this.groupPanel1.Controls.Add(this.lblDocumento);
            this.groupPanel1.Controls.Add(this.txtdocumento);
            this.groupPanel1.Controls.Add(this.lblDireccion);
            this.groupPanel1.Controls.Add(this.txtDireccion);
            this.groupPanel1.Controls.Add(this.lblCod);
            this.groupPanel1.Controls.Add(this.txtcod);
            this.groupPanel1.Controls.Add(this.lblNombre);
            this.groupPanel1.Controls.Add(this.txtnombre);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(10, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1095, 332);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupPanel1.TabIndex = 15;
            this.groupPanel1.Text = "     LISTADO      .";
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelX3.Location = new System.Drawing.Point(66, 206);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(45, 23);
            this.labelX3.TabIndex = 309;
            this.labelX3.Text = "Tipo:";
            // 
            // cboTipoPromotor
            // 
            this.cboTipoPromotor.DisplayMember = "Text";
            this.cboTipoPromotor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoPromotor.ForeColor = System.Drawing.Color.Black;
            this.cboTipoPromotor.FormattingEnabled = true;
            this.cboTipoPromotor.ItemHeight = 14;
            this.cboTipoPromotor.Location = new System.Drawing.Point(162, 206);
            this.cboTipoPromotor.Name = "cboTipoPromotor";
            this.cboTipoPromotor.Size = new System.Drawing.Size(135, 20);
            this.cboTipoPromotor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoPromotor.TabIndex = 308;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelX2.Location = new System.Drawing.Point(66, 162);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(61, 23);
            this.labelX2.TabIndex = 306;
            this.labelX2.Text = "Correo:";
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcorreo.Border.Class = "TextBoxBorder";
            this.txtcorreo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcorreo.DisabledBackColor = System.Drawing.Color.White;
            this.txtcorreo.ForeColor = System.Drawing.Color.Black;
            this.txtcorreo.Location = new System.Drawing.Point(162, 165);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.PreventEnterBeep = true;
            this.txtcorreo.Size = new System.Drawing.Size(297, 20);
            this.txtcorreo.TabIndex = 307;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelX1.Location = new System.Drawing.Point(525, 30);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(73, 23);
            this.labelX1.TabIndex = 302;
            this.labelX1.Text = "Codigó Sap:";
            // 
            // txtCodigoSap
            // 
            this.txtCodigoSap.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtCodigoSap.Border.Class = "TextBoxBorder";
            this.txtCodigoSap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCodigoSap.DisabledBackColor = System.Drawing.Color.White;
            this.txtCodigoSap.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoSap.Location = new System.Drawing.Point(604, 33);
            this.txtCodigoSap.Name = "txtCodigoSap";
            this.txtCodigoSap.PreventEnterBeep = true;
            this.txtCodigoSap.Size = new System.Drawing.Size(297, 20);
            this.txtCodigoSap.TabIndex = 303;
            this.txtCodigoSap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoSap_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(621, 260);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 29);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 301;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DisplayMember = "Text";
            this.cboTipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTipoDocumento.ForeColor = System.Drawing.Color.Black;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.ItemHeight = 14;
            this.cboTipoDocumento.Location = new System.Drawing.Point(162, 71);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(297, 20);
            this.cboTipoDocumento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboTipoDocumento.TabIndex = 299;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTipoDocumento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTipoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTipoDocumento.Location = new System.Drawing.Point(66, 71);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(95, 23);
            this.lblTipoDocumento.TabIndex = 298;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // btnListar
            // 
            this.btnListar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnListar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.Location = new System.Drawing.Point(520, 260);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(86, 29);
            this.btnListar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnListar.TabIndex = 296;
            this.btnListar.Text = "Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(321, 260);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(77, 29);
            this.btnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGuardar.TabIndex = 295;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(417, 260);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 29);
            this.btnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLimpiar.TabIndex = 294;
            this.btnLimpiar.Text = "Nuevo";
            this.btnLimpiar.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cboEstado
            // 
            this.cboEstado.DisplayMember = "Text";
            this.cboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEstado.ForeColor = System.Drawing.Color.Black;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.ItemHeight = 14;
            this.cboEstado.Location = new System.Drawing.Point(604, 209);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(135, 20);
            this.cboEstado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboEstado.TabIndex = 34;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelX5.Location = new System.Drawing.Point(525, 203);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(45, 23);
            this.labelX5.TabIndex = 33;
            this.labelX5.Text = "Estado:";
            // 
            // lblDocumento
            // 
            this.lblDocumento.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblDocumento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDocumento.Location = new System.Drawing.Point(525, 65);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(73, 23);
            this.lblDocumento.TabIndex = 28;
            this.lblDocumento.Text = "Documento:";
            // 
            // txtdocumento
            // 
            this.txtdocumento.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtdocumento.Border.Class = "TextBoxBorder";
            this.txtdocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdocumento.DisabledBackColor = System.Drawing.Color.White;
            this.txtdocumento.ForeColor = System.Drawing.Color.Black;
            this.txtdocumento.Location = new System.Drawing.Point(604, 71);
            this.txtdocumento.MaxLength = 11;
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.PreventEnterBeep = true;
            this.txtdocumento.Size = new System.Drawing.Size(297, 20);
            this.txtdocumento.TabIndex = 25;
            this.txtdocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdocumento_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblDireccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.Location = new System.Drawing.Point(525, 106);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(61, 23);
            this.lblDireccion.TabIndex = 26;
            this.lblDireccion.Text = "Dirección:";
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
            this.txtDireccion.ForeColor = System.Drawing.Color.Black;
            this.txtDireccion.Location = new System.Drawing.Point(604, 109);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PreventEnterBeep = true;
            this.txtDireccion.Size = new System.Drawing.Size(297, 41);
            this.txtDireccion.TabIndex = 27;
            // 
            // lblCod
            // 
            this.lblCod.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCod.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCod.Location = new System.Drawing.Point(66, 3);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(31, 23);
            this.lblCod.TabIndex = 24;
            this.lblCod.Text = "Cod:";
            // 
            // txtcod
            // 
            this.txtcod.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcod.Border.Class = "TextBoxBorder";
            this.txtcod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcod.DisabledBackColor = System.Drawing.Color.White;
            this.txtcod.ForeColor = System.Drawing.Color.Black;
            this.txtcod.Location = new System.Drawing.Point(162, 6);
            this.txtcod.Name = "txtcod";
            this.txtcod.PreventEnterBeep = true;
            this.txtcod.ReadOnly = true;
            this.txtcod.Size = new System.Drawing.Size(47, 20);
            this.txtcod.TabIndex = 21;
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblNombre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNombre.Location = new System.Drawing.Point(66, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 23);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtnombre.Border.Class = "TextBoxBorder";
            this.txtnombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnombre.DisabledBackColor = System.Drawing.Color.White;
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(162, 36);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PreventEnterBeep = true;
            this.txtnombre.Size = new System.Drawing.Size(297, 20);
            this.txtnombre.TabIndex = 23;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expandablePanel1.AnimationTime = 200;
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.expandablePanel1.Controls.Add(this.label4);
            this.expandablePanel1.Controls.Add(this.label5);
            this.expandablePanel1.Controls.Add(this.label6);
            this.expandablePanel1.Controls.Add(this.label7);
            this.expandablePanel1.Controls.Add(this.txtFiltro);
            this.expandablePanel1.Controls.Add(this.btnSalir);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.ExpandButtonVisible = false;
            this.expandablePanel1.Expanded = false;
            this.expandablePanel1.ExpandedBounds = new System.Drawing.Rectangle(603, 0, 231, 93);
            this.expandablePanel1.Location = new System.Drawing.Point(831, 0);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.ShowFocusRectangle = true;
            this.expandablePanel1.Size = new System.Drawing.Size(231, 0);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.Color = System.Drawing.SystemColors.GradientActiveCaption;
            this.expandablePanel1.Style.BackColor2.Color = System.Drawing.SystemColors.GradientActiveCaption;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 18;
            this.expandablePanel1.TitleHeight = 0;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Title Bar";
            this.expandablePanel1.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, -59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Por :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, -89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Búsqueda";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightBlue;
            this.label6.Location = new System.Drawing.Point(186, -59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "x";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, -59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "X";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Location = new System.Drawing.Point(13, -38);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(207, 20);
            this.txtFiltro.TabIndex = 5;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(213, -93);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(1);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(18, 22);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "x";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.groupPanel2.Controls.Add(this.dgvPromotores);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(10, 373);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1095, 352);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupPanel2.TabIndex = 44;
            this.groupPanel2.Text = "PROMOTORES";
            // 
            // lbregistro
            // 
            this.lbregistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.lbregistro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbregistro.ForeColor = System.Drawing.Color.Black;
            this.lbregistro.Location = new System.Drawing.Point(3, 310);
            this.lbregistro.Name = "lbregistro";
            this.lbregistro.Size = new System.Drawing.Size(233, 18);
            this.lbregistro.TabIndex = 41;
            // 
            // dgvPromotores
            // 
            this.dgvPromotores.AllowUserToAddRows = false;
            this.dgvPromotores.AllowUserToDeleteRows = false;
            this.dgvPromotores.AllowUserToResizeRows = false;
            this.dgvPromotores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPromotores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPromotores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromotores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPromotores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPromotores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codpromotor,
            this.nombre,
            this.tipodocumento,
            this.codtipodocumento,
            this.dni,
            this.direccion,
            this.telefono1,
            this.fechanacimiento,
            this.estado,
            this.codigosap,
            this.email,
            this.codtipopersona,
            this.tipopersona,
            this.razonsocial});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPromotores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPromotores.EnableHeadersVisualStyles = false;
            this.dgvPromotores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvPromotores.Location = new System.Drawing.Point(3, 3);
            this.dgvPromotores.Name = "dgvPromotores";
            this.dgvPromotores.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromotores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPromotores.RowHeadersVisible = false;
            this.dgvPromotores.RowTemplate.Height = 27;
            this.dgvPromotores.Size = new System.Drawing.Size(1083, 295);
            this.dgvPromotores.TabIndex = 40;
            this.dgvPromotores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPromotores_CellClick);
            this.dgvPromotores.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDoctores_ColumnHeaderMouseClick);
            // 
            // lblTelefono
            // 
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTelefono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.Location = new System.Drawing.Point(525, 165);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 23);
            this.lblTelefono.TabIndex = 29;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelX4.Location = new System.Drawing.Point(850, 266);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(73, 23);
            this.labelX4.TabIndex = 31;
            this.labelX4.Text = "Fecha Nac.:";
            this.labelX4.Visible = false;
            this.labelX4.Click += new System.EventHandler(this.labelX4_Click);
            // 
            // dtpFechaNac
            // 
            // 
            // 
            // 
            this.dtpFechaNac.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpFechaNac.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaNac.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpFechaNac.ButtonDropDown.Visible = true;
            this.dtpFechaNac.IsPopupCalendarOpen = false;
            this.dtpFechaNac.Location = new System.Drawing.Point(929, 269);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpFechaNac.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaNac.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpFechaNac.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpFechaNac.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpFechaNac.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFechaNac.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpFechaNac.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpFechaNac.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpFechaNac.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpFechaNac.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaNac.MonthCalendar.DisplayMonth = new System.DateTime(2018, 6, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpFechaNac.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpFechaNac.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpFechaNac.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpFechaNac.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpFechaNac.MonthCalendar.TodayButtonVisible = true;
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(135, 20);
            this.dtpFechaNac.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpFechaNac.TabIndex = 297;
            this.dtpFechaNac.Visible = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtTelefono.Border.Class = "TextBoxBorder";
            this.txtTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTelefono.DisabledBackColor = System.Drawing.Color.White;
            this.txtTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtTelefono.Location = new System.Drawing.Point(604, 165);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PreventEnterBeep = true;
            this.txtTelefono.Size = new System.Drawing.Size(297, 20);
            this.txtTelefono.TabIndex = 30;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelX6.Location = new System.Drawing.Point(66, 109);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 310;
            this.labelX6.Text = "Razòn Social:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtRazonSocial.Border.Class = "TextBoxBorder";
            this.txtRazonSocial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRazonSocial.DisabledBackColor = System.Drawing.Color.White;
            this.txtRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.txtRazonSocial.Location = new System.Drawing.Point(162, 112);
            this.txtRazonSocial.Multiline = true;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PreventEnterBeep = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(297, 38);
            this.txtRazonSocial.TabIndex = 311;
            // 
            // codpromotor
            // 
            this.codpromotor.DataPropertyName = "codpromotor";
            this.codpromotor.HeaderText = "CODIGO";
            this.codpromotor.Name = "codpromotor";
            this.codpromotor.ReadOnly = true;
            this.codpromotor.Width = 74;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 79;
            // 
            // tipodocumento
            // 
            this.tipodocumento.DataPropertyName = "tipodocumento";
            this.tipodocumento.HeaderText = "TIPO DOCUMENTO";
            this.tipodocumento.Name = "tipodocumento";
            this.tipodocumento.ReadOnly = true;
            this.tipodocumento.Width = 119;
            // 
            // codtipodocumento
            // 
            this.codtipodocumento.DataPropertyName = "coddocumentoidentidad";
            this.codtipodocumento.HeaderText = "COD DOCUMENTO";
            this.codtipodocumento.Name = "codtipodocumento";
            this.codtipodocumento.ReadOnly = true;
            this.codtipodocumento.Visible = false;
            this.codtipodocumento.Width = 117;
            // 
            // dni
            // 
            this.dni.DataPropertyName = "dni";
            this.dni.HeaderText = "N° DOCUMENTO";
            this.dni.Name = "dni";
            this.dni.ReadOnly = true;
            this.dni.Width = 107;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 91;
            // 
            // telefono1
            // 
            this.telefono1.DataPropertyName = "telefono1";
            this.telefono1.HeaderText = "TELEFONO";
            this.telefono1.Name = "telefono1";
            this.telefono1.ReadOnly = true;
            this.telefono1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.telefono1.Visible = false;
            this.telefono1.Width = 89;
            // 
            // fechanacimiento
            // 
            this.fechanacimiento.DataPropertyName = "fechanacimiento";
            this.fechanacimiento.HeaderText = "FECHA NAC.";
            this.fechanacimiento.Name = "fechanacimiento";
            this.fechanacimiento.ReadOnly = true;
            this.fechanacimiento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fechanacimiento.Visible = false;
            this.fechanacimiento.Width = 87;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 76;
            // 
            // codigosap
            // 
            this.codigosap.DataPropertyName = "codigosap";
            this.codigosap.HeaderText = "codigosap";
            this.codigosap.Name = "codigosap";
            this.codigosap.ReadOnly = true;
            this.codigosap.Visible = false;
            this.codigosap.Width = 81;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            this.email.Width = 57;
            // 
            // codtipopersona
            // 
            this.codtipopersona.DataPropertyName = "codtipopersona";
            this.codtipopersona.HeaderText = "COD TIPO PERSONA";
            this.codtipopersona.Name = "codtipopersona";
            this.codtipopersona.ReadOnly = true;
            this.codtipopersona.Visible = false;
            this.codtipopersona.Width = 126;
            // 
            // tipopersona
            // 
            this.tipopersona.DataPropertyName = "tipopersona";
            this.tipopersona.HeaderText = "TIPO PERSONA";
            this.tipopersona.Name = "tipopersona";
            this.tipopersona.ReadOnly = true;
            this.tipopersona.Width = 103;
            // 
            // razonsocial
            // 
            this.razonsocial.DataPropertyName = "razonsocial";
            this.razonsocial.HeaderText = "Razon Social";
            this.razonsocial.Name = "razonsocial";
            this.razonsocial.ReadOnly = true;
            this.razonsocial.Width = 87;
            // 
            // frmRegistroPromotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(1127, 757);
            this.Controls.Add(this.expandablePanel1);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmRegistroPromotor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO PROMOTORES";
            this.Load += new System.EventHandler(this.frmRegistroPromotores_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmRegistroPromotores_KeyUp);
            this.groupPanel1.ResumeLayout(false);
            this.expandablePanel1.ResumeLayout(false);
            this.expandablePanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaNac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboEstado;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lblDireccion;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDireccion;
        private DevComponents.DotNetBar.LabelX lblCod;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcod;
        private DevComponents.DotNetBar.LabelX lblNombre;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnombre;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX lbregistro;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPromotores;
        private DevComponents.DotNetBar.ButtonX btnLimpiar;
        private DevComponents.DotNetBar.ButtonX btnGuardar;
        private DevComponents.DotNetBar.ButtonX btnListar;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFiltro;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;

        private System.Windows.Forms.Button btnSalir;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTipoPromotor;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcorreo;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCodigoSap;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboTipoDocumento;
        private DevComponents.DotNetBar.LabelX lblTipoDocumento;
        private DevComponents.DotNetBar.LabelX lblDocumento;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdocumento;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRazonSocial;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpFechaNac;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX lblTelefono;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpromotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn codtipodocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigosap;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn codtipopersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipopersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonsocial;
    }
}