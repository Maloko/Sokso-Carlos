namespace SGEDICALE.vista
{
    partial class frmListadoBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoBanco));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnNuevo = new DevComponents.DotNetBar.ButtonItem();
            this.btnmodificar = new DevComponents.DotNetBar.ButtonItem();
            this.btneliminar = new DevComponents.DotNetBar.ButtonItem();
            this.btnactualizar = new DevComponents.DotNetBar.ButtonItem();
            this.Buscar = new DevComponents.DotNetBar.ButtonItem();
            this.Imprimir = new DevComponents.DotNetBar.ButtonItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.lbregistro = new DevComponents.DotNetBar.LabelX();
            this.lblnumero = new DevComponents.DotNetBar.LabelX();
            this.dgvBanco = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.ribbonBar1.BackgroundMouseOverStyle.BorderBottomWidth = 1;
            this.ribbonBar1.BackgroundMouseOverStyle.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.ribbonBar1.BackgroundMouseOverStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.ribbonBar1.BackgroundMouseOverStyle.BorderLeftWidth = 1;
            this.ribbonBar1.BackgroundMouseOverStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.ribbonBar1.BackgroundMouseOverStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.ribbonBar1.BackgroundMouseOverStyle.BorderTopWidth = 1;
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.ribbonBar1.BackgroundStyle.BorderBottomColor = System.Drawing.Color.Black;
            this.ribbonBar1.BackgroundStyle.BorderBottomWidth = 1;
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.BackgroundStyle.TextShadowColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonBar1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNuevo,
            this.btnmodificar,
            this.btneliminar,
            this.btnactualizar,
            this.Buscar,
            this.Imprimir});
            this.ribbonBar1.Location = new System.Drawing.Point(0, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(883, 75);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 14;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.SubItemsExpandWidth = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
            this.btnmodificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.SubItemsExpandWidth = 14;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.SubItemsExpandWidth = 14;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.SubItemsExpandWidth = 14;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.Buscar.Name = "Buscar";
            this.Buscar.SubItemsExpandWidth = 14;
            this.Buscar.Text = "Buscar";
            // 
            // Imprimir
            // 
            this.Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Imprimir.Image")));
            this.Imprimir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.SubItemsExpandWidth = 14;
            this.Imprimir.Text = "Imprimir";
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lbregistro);
            this.panelEx1.Controls.Add(this.lblnumero);
            this.panelEx1.Controls.Add(this.dgvBanco);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 81);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(883, 314);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 24;
            // 
            // lbregistro
            // 
            // 
            // 
            // 
            this.lbregistro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbregistro.ForeColor = System.Drawing.Color.Black;
            this.lbregistro.Location = new System.Drawing.Point(3, 280);
            this.lbregistro.Name = "lbregistro";
            this.lbregistro.Size = new System.Drawing.Size(404, 23);
            this.lbregistro.TabIndex = 2;
            // 
            // lblnumero
            // 
            // 
            // 
            // 
            this.lblnumero.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.ForeColor = System.Drawing.Color.Black;
            this.lblnumero.Location = new System.Drawing.Point(3, 280);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(369, 23);
            this.lblnumero.TabIndex = 1;
            // 
            // dgvBanco
            // 
            this.dgvBanco.AllowUserToAddRows = false;
            this.dgvBanco.AllowUserToDeleteRows = false;
            this.dgvBanco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBanco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBanco.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codBanco,
            this.sigla,
            this.descripcion,
            this.codUser,
            this.fecharegistro,
            this.estado});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBanco.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBanco.EnableHeadersVisualStyles = false;
            this.dgvBanco.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvBanco.Location = new System.Drawing.Point(0, 0);
            this.dgvBanco.Name = "dgvBanco";
            this.dgvBanco.ReadOnly = true;
            this.dgvBanco.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBanco.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBanco.RowHeadersVisible = false;
            this.dgvBanco.RowTemplate.Height = 30;
            this.dgvBanco.Size = new System.Drawing.Size(883, 266);
            this.dgvBanco.TabIndex = 0;
            this.dgvBanco.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanco_CellDoubleClick);
            // 
            // codBanco
            // 
            this.codBanco.DataPropertyName = "codBanco";
            this.codBanco.HeaderText = "CODIGO";
            this.codBanco.Name = "codBanco";
            this.codBanco.ReadOnly = true;
            this.codBanco.Width = 92;
            // 
            // sigla
            // 
            this.sigla.DataPropertyName = "sigla";
            this.sigla.HeaderText = "SIGLA";
            this.sigla.Name = "sigla";
            this.sigla.ReadOnly = true;
            this.sigla.Width = 77;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 129;
            // 
            // codUser
            // 
            this.codUser.DataPropertyName = "codUser";
            this.codUser.HeaderText = "RESPONSABLE";
            this.codUser.Name = "codUser";
            this.codUser.ReadOnly = true;
            this.codUser.Width = 139;
            // 
            // fecharegistro
            // 
            this.fecharegistro.DataPropertyName = "fecharegistro";
            this.fecharegistro.HeaderText = "FECHA REGISTRO";
            this.fecharegistro.Name = "fecharegistro";
            this.fecharegistro.ReadOnly = true;
            this.fecharegistro.Width = 145;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 94;
            // 
            // frmListadoBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(883, 400);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.ribbonBar1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmListadoBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Bancos";
            this.Load += new System.EventHandler(this.FrmBanco_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmListadoBanco_KeyUp);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lbregistro;
        private DevComponents.DotNetBar.LabelX lblnumero;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBanco;
        private DevComponents.DotNetBar.ButtonItem btnmodificar;
        private DevComponents.DotNetBar.ButtonItem btneliminar;
        private DevComponents.DotNetBar.ButtonItem btnactualizar;
        private DevComponents.DotNetBar.ButtonItem Buscar;
        private DevComponents.DotNetBar.ButtonItem Imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn codBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn sigla;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn codUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}