namespace FinalXML.vista
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btn_limpiar = new DevComponents.DotNetBar.ButtonX();
            this.btn_cargar = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dg_usuario = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipousuarioid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreyapellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoidentidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipousuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btn_salir = new DevComponents.DotNetBar.ButtonX();
            this.btn_buscar = new DevComponents.DotNetBar.ButtonX();
            this.btn_guardar = new DevComponents.DotNetBar.ButtonX();
            this.cb_estado = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txt_clave = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txt_cuenta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txt_telefono = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txt_documento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txt_nombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cb_tipousu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txt_cod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_usuario)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.btn_limpiar);
            this.panelEx1.Controls.Add(this.btn_cargar);
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(720, 639);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_limpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_limpiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_limpiar.Image")));
            this.btn_limpiar.Location = new System.Drawing.Point(571, 586);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(121, 44);
            this.btn_limpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_limpiar.TabIndex = 18;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_cargar
            // 
            this.btn_cargar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cargar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cargar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cargar.Image")));
            this.btn_cargar.Location = new System.Drawing.Point(440, 586);
            this.btn_cargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(121, 44);
            this.btn_cargar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cargar.TabIndex = 17;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dg_usuario);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(16, 330);
            this.groupPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(687, 249);
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
            this.groupPanel2.Text = "     Lista de Usuarios      .";
            // 
            // dg_usuario
            // 
            this.dg_usuario.AllowUserToAddRows = false;
            this.dg_usuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_usuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuario,
            this.tipousuarioid,
            this.nombreyapellido,
            this.documentoidentidad,
            this.telefono,
            this.cuenta,
            this.clave,
            this.estado,
            this.tipousuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_usuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_usuario.EnableHeadersVisualStyles = false;
            this.dg_usuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dg_usuario.Location = new System.Drawing.Point(0, 0);
            this.dg_usuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_usuario.Name = "dg_usuario";
            this.dg_usuario.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_usuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_usuario.Size = new System.Drawing.Size(681, 226);
            this.dg_usuario.TabIndex = 0;
            this.dg_usuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_usuario_CellClick);
            // 
            // idusuario
            // 
            this.idusuario.DataPropertyName = "usuarioid";
            this.idusuario.HeaderText = "COD";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            // 
            // tipousuarioid
            // 
            this.tipousuarioid.DataPropertyName = "idtipousuario";
            this.tipousuarioid.HeaderText = "COD TIPO";
            this.tipousuarioid.Name = "tipousuarioid";
            this.tipousuarioid.ReadOnly = true;
            this.tipousuarioid.Visible = false;
            // 
            // nombreyapellido
            // 
            this.nombreyapellido.DataPropertyName = "nombresapellidos";
            this.nombreyapellido.HeaderText = "NOMBRES ";
            this.nombreyapellido.Name = "nombreyapellido";
            this.nombreyapellido.ReadOnly = true;
            // 
            // documentoidentidad
            // 
            this.documentoidentidad.DataPropertyName = "documento";
            this.documentoidentidad.HeaderText = "DOCUMENTO";
            this.documentoidentidad.Name = "documentoidentidad";
            this.documentoidentidad.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // cuenta
            // 
            this.cuenta.DataPropertyName = "cuenta";
            this.cuenta.HeaderText = "CUENTA";
            this.cuenta.Name = "cuenta";
            this.cuenta.ReadOnly = true;
            // 
            // clave
            // 
            this.clave.DataPropertyName = "clave";
            this.clave.HeaderText = "CLAVE";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // tipousuario
            // 
            this.tipousuario.DataPropertyName = "tipousuario";
            this.tipousuario.HeaderText = "TIPO";
            this.tipousuario.Name = "tipousuario";
            this.tipousuario.ReadOnly = true;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btn_salir);
            this.groupPanel1.Controls.Add(this.btn_buscar);
            this.groupPanel1.Controls.Add(this.btn_guardar);
            this.groupPanel1.Controls.Add(this.cb_estado);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.txt_clave);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.txt_cuenta);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.txt_telefono);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.txt_documento);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txt_nombre);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.cb_tipousu);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txt_cod);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(16, 15);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(687, 308);
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
            this.groupPanel1.Text = "     Datos de Usuario      .";
            // 
            // btn_salir
            // 
            this.btn_salir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_salir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(545, 226);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(121, 44);
            this.btn_salir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_buscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(416, 226);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(121, 44);
            this.btn_buscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_buscar.TabIndex = 17;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_guardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(284, 226);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(121, 44);
            this.btn_guardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_guardar.TabIndex = 16;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cb_estado
            // 
            this.cb_estado.DisplayMember = "Text";
            this.cb_estado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estado.ForeColor = System.Drawing.Color.Black;
            this.cb_estado.FormattingEnabled = true;
            this.cb_estado.ItemHeight = 16;
            this.cb_estado.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.cb_estado.Location = new System.Drawing.Point(201, 188);
            this.cb_estado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_estado.Name = "cb_estado";
            this.cb_estado.Size = new System.Drawing.Size(177, 22);
            this.cb_estado.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_estado.TabIndex = 15;
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "ACTIVO";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "NO ACTIVO";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(65, 187);
            this.labelX8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(87, 28);
            this.labelX8.TabIndex = 14;
            this.labelX8.Text = "Estado :";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txt_clave
            // 
            this.txt_clave.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_clave.Border.Class = "TextBoxBorder";
            this.txt_clave.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_clave.DisabledBackColor = System.Drawing.Color.White;
            this.txt_clave.ForeColor = System.Drawing.Color.Black;
            this.txt_clave.Location = new System.Drawing.Point(436, 151);
            this.txt_clave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_clave.Name = "txt_clave";
            this.txt_clave.PreventEnterBeep = true;
            this.txt_clave.Size = new System.Drawing.Size(201, 22);
            this.txt_clave.TabIndex = 13;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(385, 153);
            this.labelX7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(52, 28);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "Clave :";
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_cuenta.Border.Class = "TextBoxBorder";
            this.txt_cuenta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_cuenta.DisabledBackColor = System.Drawing.Color.White;
            this.txt_cuenta.ForeColor = System.Drawing.Color.Black;
            this.txt_cuenta.Location = new System.Drawing.Point(201, 153);
            this.txt_cuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.PreventEnterBeep = true;
            this.txt_cuenta.Size = new System.Drawing.Size(177, 22);
            this.txt_cuenta.TabIndex = 11;
            this.txt_cuenta.TextChanged += new System.EventHandler(this.txt_cuenta_TextChanged);
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(25, 151);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(169, 28);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "Cuenta :";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txt_telefono
            // 
            this.txt_telefono.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_telefono.Border.Class = "TextBoxBorder";
            this.txt_telefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_telefono.DisabledBackColor = System.Drawing.Color.White;
            this.txt_telefono.ForeColor = System.Drawing.Color.Black;
            this.txt_telefono.Location = new System.Drawing.Point(436, 111);
            this.txt_telefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PreventEnterBeep = true;
            this.txt_telefono.Size = new System.Drawing.Size(201, 22);
            this.txt_telefono.TabIndex = 9;
            this.txt_telefono.TextChanged += new System.EventHandler(this.txt_telefono_TextChanged);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(388, 112);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(40, 28);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Tel :";
            // 
            // txt_documento
            // 
            this.txt_documento.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_documento.Border.Class = "TextBoxBorder";
            this.txt_documento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_documento.DisabledBackColor = System.Drawing.Color.White;
            this.txt_documento.ForeColor = System.Drawing.Color.Black;
            this.txt_documento.Location = new System.Drawing.Point(203, 111);
            this.txt_documento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_documento.MaxLength = 8;
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.PreventEnterBeep = true;
            this.txt_documento.Size = new System.Drawing.Size(177, 22);
            this.txt_documento.TabIndex = 7;
            this.txt_documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_documento_KeyPress);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(25, 111);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(169, 28);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Documento Identidad :";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_nombre.Border.Class = "TextBoxBorder";
            this.txt_nombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_nombre.DisabledBackColor = System.Drawing.Color.White;
            this.txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre.Location = new System.Drawing.Point(201, 73);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PreventEnterBeep = true;
            this.txt_nombre.Size = new System.Drawing.Size(436, 22);
            this.txt_nombre.TabIndex = 5;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(25, 71);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(155, 28);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "Nombres y Apellidos :";
            // 
            // cb_tipousu
            // 
            this.cb_tipousu.DisplayMember = "Text";
            this.cb_tipousu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_tipousu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipousu.ForeColor = System.Drawing.Color.Black;
            this.cb_tipousu.FormattingEnabled = true;
            this.cb_tipousu.ItemHeight = 16;
            this.cb_tipousu.Location = new System.Drawing.Point(420, 25);
            this.cb_tipousu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_tipousu.Name = "cb_tipousu";
            this.cb_tipousu.Size = new System.Drawing.Size(216, 22);
            this.cb_tipousu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cb_tipousu.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(371, 23);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(40, 28);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Tipo :";
            // 
            // txt_cod
            // 
            this.txt_cod.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txt_cod.Border.Class = "TextBoxBorder";
            this.txt_cod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_cod.DisabledBackColor = System.Drawing.Color.White;
            this.txt_cod.ForeColor = System.Drawing.Color.Black;
            this.txt_cod.Location = new System.Drawing.Point(105, 23);
            this.txt_cod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.PreventEnterBeep = true;
            this.txt_cod.ReadOnly = true;
            this.txt_cod.Size = new System.Drawing.Size(89, 22);
            this.txt_cod.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(57, 23);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(40, 28);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Cod :";
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 639);
            this.Controls.Add(this.panelEx1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USUARIOS";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmUsuario_KeyUp);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_usuario)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dg_usuario;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX btn_salir;
        private DevComponents.DotNetBar.ButtonX btn_buscar;
        private DevComponents.DotNetBar.ButtonX btn_guardar;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_estado;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_clave;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_cuenta;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_telefono;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_documento;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_nombre;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cb_tipousu;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_cod;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_cargar;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.ButtonX btn_limpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipousuarioid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreyapellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoidentidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipousuario;
    }
}