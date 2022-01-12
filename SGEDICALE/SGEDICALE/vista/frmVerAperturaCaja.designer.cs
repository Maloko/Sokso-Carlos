namespace FinalXML.vista.cajero
{
    partial class frmVerAperturaCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerAperturaCaja));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.context_menu = new DevComponents.DotNetBar.ContextMenuBar();
            this.btn_menu = new DevComponents.DotNetBar.ButtonItem();
            this.btn_item_ver = new DevComponents.DotNetBar.ButtonItem();
            this.dg_resultado = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoapertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montocierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cargar = new DevComponents.DotNetBar.ButtonX();
            this.btn_salir = new DevComponents.DotNetBar.ButtonX();
            this.btn_ver = new DevComponents.DotNetBar.ButtonX();
            this.btn_copiar = new DevComponents.DotNetBar.ButtonX();
            this.btn_anular = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.context_menu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_resultado)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.context_menu);
            this.panelEx1.Controls.Add(this.btn_cargar);
            this.panelEx1.Controls.Add(this.btn_salir);
            this.panelEx1.Controls.Add(this.btn_ver);
            this.panelEx1.Controls.Add(this.btn_copiar);
            this.panelEx1.Controls.Add(this.btn_anular);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(883, 591);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // context_menu
            // 
            this.context_menu.AntiAlias = true;
            this.context_menu.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.context_menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.context_menu.IsMaximized = false;
            this.context_menu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_menu});
            this.context_menu.Location = new System.Drawing.Point(977, 138);
            this.context_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.context_menu.Name = "context_menu";
            this.context_menu.Size = new System.Drawing.Size(100, 27);
            this.context_menu.Stretch = true;
            this.context_menu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.context_menu.TabIndex = 296;
            this.context_menu.TabStop = false;
            this.context_menu.Text = "contextMenuBar1";
            // 
            // btn_menu
            // 
            this.btn_menu.AutoExpandOnClick = true;
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_item_ver});
            // 
            // btn_item_ver
            // 
            this.btn_item_ver.Name = "btn_item_ver";
            this.btn_item_ver.Text = "Ver";
            this.btn_item_ver.Click += new System.EventHandler(this.btn_item_ver_Click);
            // 
            // dg_resultado
            // 
            this.dg_resultado.AllowUserToAddRows = false;
            this.dg_resultado.AllowUserToDeleteRows = false;
            this.dg_resultado.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_resultado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_resultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.numero,
            this.montoapertura,
            this.montocierre,
            this.usuario,
            this.idusuario});
            this.context_menu.SetContextMenuEx(this.dg_resultado, this.btn_menu);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_resultado.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_resultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_resultado.EnableHeadersVisualStyles = false;
            this.dg_resultado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dg_resultado.Location = new System.Drawing.Point(0, 0);
            this.dg_resultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_resultado.Name = "dg_resultado";
            this.dg_resultado.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_resultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_resultado.Size = new System.Drawing.Size(837, 471);
            this.dg_resultado.TabIndex = 0;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fechaapertura";
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "NÚMERO";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // montoapertura
            // 
            this.montoapertura.DataPropertyName = "montoapertura";
            this.montoapertura.HeaderText = "MONTO APERTURA";
            this.montoapertura.Name = "montoapertura";
            this.montoapertura.ReadOnly = true;
            // 
            // montocierre
            // 
            this.montocierre.DataPropertyName = "montocierre";
            this.montocierre.HeaderText = "MONTO CIERRE";
            this.montocierre.Name = "montocierre";
            this.montocierre.ReadOnly = true;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "nombresapellidos";
            this.usuario.HeaderText = "USUARIO";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // idusuario
            // 
            this.idusuario.DataPropertyName = "usuarioid";
            this.idusuario.HeaderText = "COD USUARIO";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            this.idusuario.Visible = false;
            // 
            // btn_cargar
            // 
            this.btn_cargar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cargar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cargar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cargar.Image")));
            this.btn_cargar.Location = new System.Drawing.Point(520, 522);
            this.btn_cargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cargar.Name = "btn_cargar";
            this.btn_cargar.Size = new System.Drawing.Size(121, 44);
            this.btn_cargar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cargar.TabIndex = 295;
            this.btn_cargar.Text = "Cargar";
            this.btn_cargar.Click += new System.EventHandler(this.btn_cargar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_salir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(663, 522);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(121, 44);
            this.btn_salir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_salir.TabIndex = 294;
            this.btn_salir.Text = "Salir";
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_ver
            // 
            this.btn_ver.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ver.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ver.Image = ((System.Drawing.Image)(resources.GetObject("btn_ver.Image")));
            this.btn_ver.Location = new System.Drawing.Point(72, 522);
            this.btn_ver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.Size = new System.Drawing.Size(121, 44);
            this.btn_ver.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ver.TabIndex = 293;
            this.btn_ver.Text = "Ver";
            this.btn_ver.Click += new System.EventHandler(this.btn_ver_Click);
            // 
            // btn_copiar
            // 
            this.btn_copiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_copiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_copiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_copiar.Image")));
            this.btn_copiar.Location = new System.Drawing.Point(377, 522);
            this.btn_copiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_copiar.Name = "btn_copiar";
            this.btn_copiar.Size = new System.Drawing.Size(121, 44);
            this.btn_copiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_copiar.TabIndex = 292;
            this.btn_copiar.Text = "Copiar";
            this.btn_copiar.Click += new System.EventHandler(this.btn_copiar_Click);
            // 
            // btn_anular
            // 
            this.btn_anular.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_anular.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_anular.Image = ((System.Drawing.Image)(resources.GetObject("btn_anular.Image")));
            this.btn_anular.Location = new System.Drawing.Point(224, 522);
            this.btn_anular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_anular.Name = "btn_anular";
            this.btn_anular.Size = new System.Drawing.Size(121, 44);
            this.btn_anular.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_anular.TabIndex = 291;
            this.btn_anular.Text = "Anular";
            this.btn_anular.Click += new System.EventHandler(this.btn_anular_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dg_resultado);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(16, 15);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(843, 494);
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
            this.groupPanel1.TabIndex = 43;
            this.groupPanel1.Text = "     Caja      .";
            // 
            // frmVerAperturaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(883, 591);
            this.Controls.Add(this.panelEx1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmVerAperturaCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAJAS APERTURADAS";
            this.Load += new System.EventHandler(this.frmVerAperturaCaja_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmVerAperturaCaja_KeyUp);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.context_menu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_resultado)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dg_resultado;
        private DevComponents.DotNetBar.ButtonX btn_ver;
        private DevComponents.DotNetBar.ButtonX btn_copiar;
        private DevComponents.DotNetBar.ButtonX btn_anular;
        private DevComponents.DotNetBar.ButtonX btn_cargar;
        private DevComponents.DotNetBar.ButtonX btn_salir;
        private DevComponents.DotNetBar.ContextMenuBar context_menu;
        private DevComponents.DotNetBar.ButtonItem btn_menu;
        private DevComponents.DotNetBar.ButtonItem btn_item_ver;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoapertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn montocierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
    }
}