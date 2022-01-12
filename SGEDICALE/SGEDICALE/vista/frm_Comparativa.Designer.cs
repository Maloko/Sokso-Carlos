namespace SGEDICALE.vista
{
    partial class frm_Comparativa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Comparativa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnImprimir = new DevComponents.DotNetBar.ButtonX();
            this.lblAño = new DevComponents.DotNetBar.LabelX();
            this.cboAño = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cboCampaña = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbCategoria = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblfiltro = new DevComponents.DotNetBar.LabelX();
            this.btnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.dgvComparacion = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.nombrepromotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.talla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppromotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpreprom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbregistro = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnImprimir);
            this.groupPanel1.Controls.Add(this.lblAño);
            this.groupPanel1.Controls.Add(this.cboAño);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.cboCampaña);
            this.groupPanel1.Controls.Add(this.cbCategoria);
            this.groupPanel1.Controls.Add(this.lblfiltro);
            this.groupPanel1.Controls.Add(this.btnBuscar);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(16, 15);
            this.groupPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1285, 140);
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
            this.groupPanel1.Text = "     Comparación      .";
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(483, 15);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(56, 38);
            this.btnImprimir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // lblAño
            // 
            // 
            // 
            // 
            this.lblAño.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.Location = new System.Drawing.Point(60, 15);
            this.lblAño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(73, 28);
            this.lblAño.TabIndex = 17;
            this.lblAño.Text = "Año: ";
            // 
            // cboAño
            // 
            this.cboAño.DisplayMember = "Text";
            this.cboAño.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAño.ForeColor = System.Drawing.Color.Black;
            this.cboAño.FormattingEnabled = true;
            this.cboAño.ItemHeight = 14;
            this.cboAño.Location = new System.Drawing.Point(153, 15);
            this.cboAño.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(195, 20);
            this.cboAño.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboAño.TabIndex = 16;
            this.cboAño.SelectedIndexChanged += new System.EventHandler(this.cboAño_SelectedIndexChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(60, 47);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(73, 28);
            this.labelX1.TabIndex = 15;
            this.labelX1.Text = "Campaña: ";
            // 
            // cboCampaña
            // 
            this.cboCampaña.DisplayMember = "Text";
            this.cboCampaña.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCampaña.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampaña.ForeColor = System.Drawing.Color.Black;
            this.cboCampaña.FormattingEnabled = true;
            this.cboCampaña.ItemHeight = 14;
            this.cboCampaña.Location = new System.Drawing.Point(153, 47);
            this.cboCampaña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCampaña.Name = "cboCampaña";
            this.cboCampaña.Size = new System.Drawing.Size(195, 20);
            this.cboCampaña.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboCampaña.TabIndex = 14;
            // 
            // cbCategoria
            // 
            this.cbCategoria.DisplayMember = "Text";
            this.cbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategoria.Enabled = false;
            this.cbCategoria.ForeColor = System.Drawing.Color.Black;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.ItemHeight = 14;
            this.cbCategoria.Location = new System.Drawing.Point(153, 79);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(195, 20);
            this.cbCategoria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbCategoria.TabIndex = 8;
            // 
            // lblfiltro
            // 
            // 
            // 
            // 
            this.lblfiltro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltro.Location = new System.Drawing.Point(53, 79);
            this.lblfiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(80, 28);
            this.lblfiltro.TabIndex = 7;
            this.lblfiltro.Text = "Categoria: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(408, 15);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(56, 38);
            this.btnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.dgvComparacion);
            this.panelEx1.Controls.Add(this.lbregistro);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(16, 162);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1285, 444);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 24;
            // 
            // dgvComparacion
            // 
            this.dgvComparacion.AllowUserToAddRows = false;
            this.dgvComparacion.AllowUserToDeleteRows = false;
            this.dgvComparacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComparacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComparacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrepromotor,
            this.campana,
            this.pag,
            this.producto,
            this.marca,
            this.modelo,
            this.color,
            this.categoria,
            this.talla,
            this.ppromotor,
            this.totalpreprom2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComparacion.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComparacion.EnableHeadersVisualStyles = false;
            this.dgvComparacion.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvComparacion.Location = new System.Drawing.Point(4, 4);
            this.dgvComparacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvComparacion.Name = "dgvComparacion";
            this.dgvComparacion.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComparacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvComparacion.RowHeadersVisible = false;
            this.dgvComparacion.RowTemplate.Height = 30;
            this.dgvComparacion.Size = new System.Drawing.Size(1277, 389);
            this.dgvComparacion.TabIndex = 300;
            // 
            // nombrepromotor
            // 
            this.nombrepromotor.DataPropertyName = "nombrepromotor";
            this.nombrepromotor.HeaderText = "PROMOTOR";
            this.nombrepromotor.Name = "nombrepromotor";
            this.nombrepromotor.ReadOnly = true;
            // 
            // campana
            // 
            this.campana.DataPropertyName = "campana";
            this.campana.HeaderText = "CAMPAÑA";
            this.campana.Name = "campana";
            this.campana.ReadOnly = true;
            // 
            // pag
            // 
            this.pag.DataPropertyName = "pag";
            this.pag.HeaderText = "PAG";
            this.pag.Name = "pag";
            this.pag.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.producto.DataPropertyName = "producto";
            this.producto.HeaderText = "PRODUCTO";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 111;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "MARCA";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "MODELO";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // color
            // 
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "COLOR";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.HeaderText = "CATEGORIA";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // talla
            // 
            this.talla.DataPropertyName = "talla";
            this.talla.HeaderText = "TALLA";
            this.talla.Name = "talla";
            this.talla.ReadOnly = true;
            // 
            // ppromotor
            // 
            this.ppromotor.DataPropertyName = "ppromotor";
            this.ppromotor.HeaderText = "P. LISTA";
            this.ppromotor.Name = "ppromotor";
            this.ppromotor.ReadOnly = true;
            // 
            // totalpreprom2
            // 
            this.totalpreprom2.DataPropertyName = "totalpreprom2";
            this.totalpreprom2.HeaderText = "P. PRODUCTO";
            this.totalpreprom2.Name = "totalpreprom2";
            this.totalpreprom2.ReadOnly = true;
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
            this.lbregistro.Location = new System.Drawing.Point(4, 400);
            this.lbregistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbregistro.Name = "lbregistro";
            this.lbregistro.Size = new System.Drawing.Size(539, 28);
            this.lbregistro.TabIndex = 2;
            // 
            // frm_Comparativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(1317, 622);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Comparativa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPARATIVA";
            this.Load += new System.EventHandler(this.frm_Comparativa_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_Comparativa_KeyUp);
            this.groupPanel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboCampaña;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbCategoria;
        private DevComponents.DotNetBar.LabelX lblfiltro;
        private DevComponents.DotNetBar.ButtonX btnBuscar;
        private DevComponents.DotNetBar.LabelX lblAño;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboAño;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lbregistro;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvComparacion;
        private DevComponents.DotNetBar.ButtonX btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrepromotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn campana;
        private System.Windows.Forms.DataGridViewTextBoxColumn pag;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn talla;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppromotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpreprom2;
    }
}