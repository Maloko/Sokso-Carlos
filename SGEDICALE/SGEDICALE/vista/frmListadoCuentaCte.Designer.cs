namespace SGEDICALE.vista
{
    partial class frmListadoCuentaCte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListadoCuentaCte));
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
            this.dgvCuenta = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codCuentaCorriente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaCorriente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estsado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuenta)).BeginInit();
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
            this.ribbonBar1.BackgroundMouseOverStyle.BorderRightWidth = 1;
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
            this.ribbonBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(1189, 92);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 15;
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
            // 
            // btnactualizar
            // 
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.SubItemsExpandWidth = 14;
            this.btnactualizar.Text = "Actualizar";
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
            // 
            // panelEx1
            // 
            this.panelEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.lbregistro);
            this.panelEx1.Controls.Add(this.lblnumero);
            this.panelEx1.Controls.Add(this.dgvCuenta);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Location = new System.Drawing.Point(0, 100);
            this.panelEx1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1177, 386);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 28;
            // 
            // lbregistro
            // 
            // 
            // 
            // 
            this.lbregistro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbregistro.ForeColor = System.Drawing.Color.Black;
            this.lbregistro.Location = new System.Drawing.Point(4, 345);
            this.lbregistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbregistro.Name = "lbregistro";
            this.lbregistro.Size = new System.Drawing.Size(539, 28);
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
            this.lblnumero.Location = new System.Drawing.Point(4, 345);
            this.lblnumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(492, 28);
            this.lblnumero.TabIndex = 1;
            // 
            // dgvCuenta
            // 
            this.dgvCuenta.AllowUserToAddRows = false;
            this.dgvCuenta.AllowUserToDeleteRows = false;
            this.dgvCuenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCuenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCuentaCorriente,
            this.banco,
            this.cuentaCorriente,
            this.tipoCuenta,
            this.moneda,
            this.responsable,
            this.fechaRegistro,
            this.estsado,
            this.codAlmacen});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuenta.EnableHeadersVisualStyles = false;
            this.dgvCuenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvCuenta.Location = new System.Drawing.Point(0, 0);
            this.dgvCuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCuenta.Name = "dgvCuenta";
            this.dgvCuenta.ReadOnly = true;
            this.dgvCuenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCuenta.RowHeadersVisible = false;
            this.dgvCuenta.RowTemplate.Height = 30;
            this.dgvCuenta.Size = new System.Drawing.Size(1177, 327);
            this.dgvCuenta.TabIndex = 0;
            // 
            // codCuentaCorriente
            // 
            this.codCuentaCorriente.DataPropertyName = "codCuentaCorriente";
            this.codCuentaCorriente.HeaderText = "CODIGO";
            this.codCuentaCorriente.Name = "codCuentaCorriente";
            this.codCuentaCorriente.ReadOnly = true;
            this.codCuentaCorriente.Width = 92;
            // 
            // banco
            // 
            this.banco.DataPropertyName = "banco";
            this.banco.HeaderText = "BANCO";
            this.banco.Name = "banco";
            this.banco.ReadOnly = true;
            this.banco.Width = 85;
            // 
            // cuentaCorriente
            // 
            this.cuentaCorriente.DataPropertyName = "cuentaCorriente";
            this.cuentaCorriente.HeaderText = "CUENTA";
            this.cuentaCorriente.Name = "cuentaCorriente";
            this.cuentaCorriente.ReadOnly = true;
            this.cuentaCorriente.Width = 93;
            // 
            // tipoCuenta
            // 
            this.tipoCuenta.DataPropertyName = "tipoCuenta";
            this.tipoCuenta.HeaderText = "TIPO CUENTA";
            this.tipoCuenta.Name = "tipoCuenta";
            this.tipoCuenta.ReadOnly = true;
            this.tipoCuenta.Width = 129;
            // 
            // moneda
            // 
            this.moneda.DataPropertyName = "moneda";
            this.moneda.HeaderText = "MONEDA";
            this.moneda.Name = "moneda";
            this.moneda.ReadOnly = true;
            this.moneda.Width = 97;
            // 
            // responsable
            // 
            this.responsable.DataPropertyName = "responsable";
            this.responsable.HeaderText = "RESPONSABLE";
            this.responsable.Name = "responsable";
            this.responsable.ReadOnly = true;
            this.responsable.Width = 139;
            // 
            // fechaRegistro
            // 
            this.fechaRegistro.DataPropertyName = "fechaRegistro";
            this.fechaRegistro.HeaderText = "F. REGISTRO";
            this.fechaRegistro.Name = "fechaRegistro";
            this.fechaRegistro.ReadOnly = true;
            this.fechaRegistro.Width = 125;
            // 
            // estsado
            // 
            this.estsado.DataPropertyName = "estado";
            this.estsado.HeaderText = "ESTADO";
            this.estsado.Name = "estsado";
            this.estsado.ReadOnly = true;
            this.estsado.Width = 94;
            // 
            // codAlmacen
            // 
            this.codAlmacen.DataPropertyName = "codAlmacen";
            this.codAlmacen.HeaderText = "Almacen";
            this.codAlmacen.Name = "codAlmacen";
            this.codAlmacen.ReadOnly = true;
            this.codAlmacen.Visible = false;
            this.codAlmacen.Width = 73;
            // 
            // frmListadoCuentaCte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(1189, 526);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.ribbonBar1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListadoCuentaCte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta Cte";
            this.Load += new System.EventHandler(this.frmCuentaCte_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmListadoCuentaCte_KeyUp);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnNuevo;
        private DevComponents.DotNetBar.ButtonItem btnmodificar;
        private DevComponents.DotNetBar.ButtonItem btneliminar;
        private DevComponents.DotNetBar.ButtonItem btnactualizar;
        private DevComponents.DotNetBar.ButtonItem Buscar;
        private DevComponents.DotNetBar.ButtonItem Imprimir;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX lbregistro;
        private DevComponents.DotNetBar.LabelX lblnumero;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCuentaCorriente;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaCorriente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn estsado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAlmacen;
    }
}