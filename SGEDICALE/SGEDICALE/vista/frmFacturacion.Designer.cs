namespace SGEDICALE.vista
{
    partial class frmF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmF));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnFacturar = new DevComponents.DotNetBar.ButtonX();
            this.txtcodpedido = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtnumero = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtCod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtpromotor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgvdetalle = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codpedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.igv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechapedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresapellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbregistro = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
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
            this.groupPanel1.Controls.Add(this.btnFacturar);
            this.groupPanel1.Controls.Add(this.txtcodpedido);
            this.groupPanel1.Controls.Add(this.txtnumero);
            this.groupPanel1.Controls.Add(this.txtCod);
            this.groupPanel1.Controls.Add(this.txtpromotor);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 15);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1131, 113);
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
            this.groupPanel1.Text = "     Datos     .";
            // 
            // btnFacturar
            // 
            this.btnFacturar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFacturar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFacturar.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturar.Image")));
            this.btnFacturar.Location = new System.Drawing.Point(596, 4);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(153, 60);
            this.btnFacturar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFacturar.TabIndex = 19;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // txtcodpedido
            // 
            this.txtcodpedido.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcodpedido.Border.Class = "TextBoxBorder";
            this.txtcodpedido.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcodpedido.DisabledBackColor = System.Drawing.Color.White;
            this.txtcodpedido.ForeColor = System.Drawing.Color.Black;
            this.txtcodpedido.Location = new System.Drawing.Point(104, 50);
            this.txtcodpedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodpedido.Name = "txtcodpedido";
            this.txtcodpedido.PreventEnterBeep = true;
            this.txtcodpedido.ReadOnly = true;
            this.txtcodpedido.Size = new System.Drawing.Size(61, 22);
            this.txtcodpedido.TabIndex = 2;
            this.txtcodpedido.WatermarkText = "F1";
            this.txtcodpedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcodpedido_KeyDown);
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtnumero.Border.Class = "TextBoxBorder";
            this.txtnumero.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnumero.DisabledBackColor = System.Drawing.Color.White;
            this.txtnumero.ForeColor = System.Drawing.Color.Black;
            this.txtnumero.Location = new System.Drawing.Point(173, 50);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.PreventEnterBeep = true;
            this.txtnumero.Size = new System.Drawing.Size(349, 22);
            this.txtnumero.TabIndex = 18;
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
            this.txtCod.Location = new System.Drawing.Point(104, 15);
            this.txtCod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCod.Name = "txtCod";
            this.txtCod.PreventEnterBeep = true;
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(61, 22);
            this.txtCod.TabIndex = 1;
            this.txtCod.WatermarkText = "F1";
            this.txtCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCod_KeyDown);
            this.txtCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCod_KeyPress);
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
            this.txtpromotor.Location = new System.Drawing.Point(173, 15);
            this.txtpromotor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpromotor.Name = "txtpromotor";
            this.txtpromotor.PreventEnterBeep = true;
            this.txtpromotor.Size = new System.Drawing.Size(349, 22);
            this.txtpromotor.TabIndex = 16;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(19, 47);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(64, 28);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "Pedido: ";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(4, 15);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(79, 28);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Promotor: ";
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgvdetalle);
            this.panelEx1.Controls.Add(this.lbregistro);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(12, 135);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1131, 374);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 32;
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.AllowUserToAddRows = false;
            this.dgvdetalle.AllowUserToDeleteRows = false;
            this.dgvdetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
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
            this.codpedido,
            this.nombre,
            this.subtotal,
            this.igv,
            this.total,
            this.fechapedido,
            this.fecharegistro,
            this.nombresapellidos,
            this.estado});
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
            this.dgvdetalle.Location = new System.Drawing.Point(4, 15);
            this.dgvdetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdetalle.RowHeadersVisible = false;
            this.dgvdetalle.RowTemplate.Height = 30;
            this.dgvdetalle.Size = new System.Drawing.Size(1123, 308);
            this.dgvdetalle.TabIndex = 3;
            // 
            // codpedido
            // 
            this.codpedido.DataPropertyName = "codpedido";
            this.codpedido.HeaderText = "CODIGO";
            this.codpedido.Name = "codpedido";
            this.codpedido.ReadOnly = true;
            this.codpedido.Width = 92;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "PROMOTOR";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 119;
            // 
            // subtotal
            // 
            this.subtotal.DataPropertyName = "subtotal";
            this.subtotal.HeaderText = "SUBTOTAL";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 111;
            // 
            // igv
            // 
            this.igv.DataPropertyName = "igv";
            this.igv.HeaderText = "IGV";
            this.igv.Name = "igv";
            this.igv.ReadOnly = true;
            this.igv.Width = 60;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 83;
            // 
            // fechapedido
            // 
            this.fechapedido.DataPropertyName = "fechapedido";
            this.fechapedido.HeaderText = "F. PEDIDO";
            this.fechapedido.Name = "fechapedido";
            this.fechapedido.ReadOnly = true;
            this.fechapedido.Width = 105;
            // 
            // fecharegistro
            // 
            this.fecharegistro.DataPropertyName = "fecharegistro";
            this.fecharegistro.HeaderText = "F. REGISTRO";
            this.fecharegistro.Name = "fecharegistro";
            this.fecharegistro.ReadOnly = true;
            this.fecharegistro.Visible = false;
            // 
            // nombresapellidos
            // 
            this.nombresapellidos.DataPropertyName = "nombresapellidos";
            this.nombresapellidos.HeaderText = "RESPONSABLE";
            this.nombresapellidos.Name = "nombresapellidos";
            this.nombresapellidos.ReadOnly = true;
            this.nombresapellidos.Width = 139;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 94;
            // 
            // lbregistro
            // 
            this.lbregistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.lbregistro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbregistro.ForeColor = System.Drawing.Color.Black;
            this.lbregistro.Location = new System.Drawing.Point(8, 330);
            this.lbregistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbregistro.Name = "lbregistro";
            this.lbregistro.Size = new System.Drawing.Size(243, 28);
            this.lbregistro.TabIndex = 2;
            this.lbregistro.Click += new System.EventHandler(this.lbregistro_Click);
            // 
            // frmF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(1159, 524);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmF";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FACTURACIÓN";
            this.Load += new System.EventHandler(this.frmF_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmF_KeyUp);
            this.groupPanel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcodpedido;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnumero;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCod;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpromotor;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lbregistro;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvdetalle;
        private DevComponents.DotNetBar.ButtonX btnFacturar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn igv;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechapedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresapellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}