namespace SGEDICALE.vista
{
    partial class frm_MuestraPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MuestraPagos));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtpendiente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttotal = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblsubtotal = new DevComponents.DotNetBar.LabelX();
            this.lbltotal = new DevComponents.DotNetBar.LabelX();
            this.lbligv = new DevComponents.DotNetBar.LabelX();
            this.txtcobrado = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbregistro = new DevComponents.DotNetBar.LabelX();
            this.dgvListaCobros = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codcobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechacobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuentaCorriente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noperacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCobros)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(912, 361);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 12;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.txtpendiente);
            this.groupPanel2.Controls.Add(this.txttotal);
            this.groupPanel2.Controls.Add(this.lblsubtotal);
            this.groupPanel2.Controls.Add(this.lbltotal);
            this.groupPanel2.Controls.Add(this.lbligv);
            this.groupPanel2.Controls.Add(this.txtcobrado);
            this.groupPanel2.Controls.Add(this.lbregistro);
            this.groupPanel2.Controls.Add(this.dgvListaCobros);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(10, 6);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(892, 343);
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
            this.groupPanel2.TabIndex = 43;
            this.groupPanel2.Text = "    Pagos      .";
            // 
            // txtpendiente
            // 
            this.txtpendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpendiente.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtpendiente.Border.Class = "TextBoxBorder";
            this.txtpendiente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpendiente.DisabledBackColor = System.Drawing.Color.White;
            this.txtpendiente.Enabled = false;
            this.txtpendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpendiente.ForeColor = System.Drawing.Color.Red;
            this.txtpendiente.Location = new System.Drawing.Point(762, 278);
            this.txtpendiente.Name = "txtpendiente";
            this.txtpendiente.PreventEnterBeep = true;
            this.txtpendiente.ReadOnly = true;
            this.txtpendiente.Size = new System.Drawing.Size(100, 20);
            this.txtpendiente.TabIndex = 48;
            this.txtpendiente.Text = "0.00";
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
            this.txttotal.Location = new System.Drawing.Point(762, 228);
            this.txttotal.Name = "txttotal";
            this.txttotal.PreventEnterBeep = true;
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 44;
            this.txttotal.Text = "0.00";
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
            this.lblsubtotal.Location = new System.Drawing.Point(685, 228);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(70, 20);
            this.lblsubtotal.TabIndex = 43;
            this.lblsubtotal.Text = "Deuda Total: ";
            // 
            // lbltotal
            // 
            this.lbltotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbltotal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.Red;
            this.lbltotal.Location = new System.Drawing.Point(690, 278);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(66, 20);
            this.lbltotal.TabIndex = 47;
            this.lbltotal.Text = "Pendiente: ";
            // 
            // lbligv
            // 
            this.lbligv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbligv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbligv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbligv.ForeColor = System.Drawing.Color.Blue;
            this.lbligv.Location = new System.Drawing.Point(700, 252);
            this.lbligv.Name = "lbligv";
            this.lbligv.Size = new System.Drawing.Size(55, 20);
            this.lbligv.TabIndex = 45;
            this.lbligv.Text = "Cobrado: ";
            // 
            // txtcobrado
            // 
            this.txtcobrado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcobrado.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtcobrado.Border.Class = "TextBoxBorder";
            this.txtcobrado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcobrado.DisabledBackColor = System.Drawing.Color.White;
            this.txtcobrado.Enabled = false;
            this.txtcobrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcobrado.ForeColor = System.Drawing.Color.Blue;
            this.txtcobrado.Location = new System.Drawing.Point(762, 253);
            this.txtcobrado.Name = "txtcobrado";
            this.txtcobrado.PreventEnterBeep = true;
            this.txtcobrado.ReadOnly = true;
            this.txtcobrado.Size = new System.Drawing.Size(100, 20);
            this.txtcobrado.TabIndex = 46;
            this.txtcobrado.Text = "0.00";
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
            this.lbregistro.Location = new System.Drawing.Point(3, 221);
            this.lbregistro.Name = "lbregistro";
            this.lbregistro.Size = new System.Drawing.Size(450, 18);
            this.lbregistro.TabIndex = 41;
            // 
            // dgvListaCobros
            // 
            this.dgvListaCobros.AllowUserToAddRows = false;
            this.dgvListaCobros.AllowUserToDeleteRows = false;
            this.dgvListaCobros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaCobros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaCobros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaCobros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcobro,
            this.fechacobro,
            this.moneda,
            this.monto,
            this.metodo,
            this.banco,
            this.cuentaCorriente,
            this.noperacion,
            this.estado,
            this.cuenta});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaCobros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaCobros.EnableHeadersVisualStyles = false;
            this.dgvListaCobros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvListaCobros.Location = new System.Drawing.Point(3, 2);
            this.dgvListaCobros.Name = "dgvListaCobros";
            this.dgvListaCobros.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaCobros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaCobros.RowHeadersVisible = false;
            this.dgvListaCobros.RowTemplate.Height = 25;
            this.dgvListaCobros.Size = new System.Drawing.Size(869, 213);
            this.dgvListaCobros.TabIndex = 40;
            // 
            // codcobro
            // 
            this.codcobro.DataPropertyName = "codcobro";
            this.codcobro.HeaderText = "Codigo";
            this.codcobro.Name = "codcobro";
            this.codcobro.ReadOnly = true;
            this.codcobro.Visible = false;
            this.codcobro.Width = 46;
            // 
            // fechacobro
            // 
            this.fechacobro.DataPropertyName = "fechacobro";
            this.fechacobro.HeaderText = "F. PAGO";
            this.fechacobro.Name = "fechacobro";
            this.fechacobro.ReadOnly = true;
            this.fechacobro.Width = 74;
            // 
            // moneda
            // 
            this.moneda.DataPropertyName = "moneda";
            this.moneda.HeaderText = "MONEDA";
            this.moneda.Name = "moneda";
            this.moneda.ReadOnly = true;
            this.moneda.Width = 79;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            this.monto.HeaderText = "MONTO";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.monto.Width = 72;
            // 
            // metodo
            // 
            this.metodo.DataPropertyName = "metodo";
            this.metodo.HeaderText = "METODO PAGO";
            this.metodo.Name = "metodo";
            this.metodo.ReadOnly = true;
            this.metodo.Width = 103;
            // 
            // banco
            // 
            this.banco.DataPropertyName = "banco";
            this.banco.HeaderText = "BANCO";
            this.banco.Name = "banco";
            this.banco.ReadOnly = true;
            this.banco.Width = 69;
            // 
            // cuentaCorriente
            // 
            this.cuentaCorriente.DataPropertyName = "cuentaCorriente";
            this.cuentaCorriente.HeaderText = "CUENTA";
            this.cuentaCorriente.Name = "cuentaCorriente";
            this.cuentaCorriente.ReadOnly = true;
            this.cuentaCorriente.Width = 76;
            // 
            // noperacion
            // 
            this.noperacion.DataPropertyName = "noperacion";
            this.noperacion.HeaderText = "N° OPERACION";
            this.noperacion.Name = "noperacion";
            this.noperacion.ReadOnly = true;
            this.noperacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.noperacion.Width = 101;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "ESTADO";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 76;
            // 
            // cuenta
            // 
            this.cuenta.DataPropertyName = "cuenta";
            this.cuenta.HeaderText = "RESPONSABLE";
            this.cuenta.Name = "cuenta";
            this.cuenta.ReadOnly = true;
            this.cuenta.Width = 111;
            // 
            // frm_MuestraPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold);
            this.ClientSize = new System.Drawing.Size(912, 361);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_MuestraPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MUESTRA PAGOS";
            this.Load += new System.EventHandler(this.frm_MuestraPagos_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_MuestraPagos_KeyUp);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaCobros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX lbregistro;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvListaCobros;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpendiente;
        private DevComponents.DotNetBar.Controls.TextBoxX txttotal;
        private DevComponents.DotNetBar.LabelX lblsubtotal;
        private DevComponents.DotNetBar.LabelX lbltotal;
        private DevComponents.DotNetBar.LabelX lbligv;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcobrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechacobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuentaCorriente;
        private System.Windows.Forms.DataGridViewTextBoxColumn noperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
    }
}