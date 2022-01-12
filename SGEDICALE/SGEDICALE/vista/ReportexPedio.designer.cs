namespace SGEDICALE.vista
{
    partial class ReportexPedio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportexPedio));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbAño = new System.Windows.Forms.DateTimePicker();
            this.lblAño = new DevComponents.DotNetBar.LabelX();
            this.cbMes = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnAceptar = new DevComponents.DotNetBar.ButtonX();
            this.cbPedido = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lblfiltro = new DevComponents.DotNetBar.LabelX();
            this.lblHasta = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cbAño);
            this.groupPanel1.Controls.Add(this.lblAño);
            this.groupPanel1.Controls.Add(this.cbMes);
            this.groupPanel1.Controls.Add(this.btnAceptar);
            this.groupPanel1.Controls.Add(this.cbPedido);
            this.groupPanel1.Controls.Add(this.lblfiltro);
            this.groupPanel1.Controls.Add(this.lblHasta);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(30, 22);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(338, 208);
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
            this.groupPanel1.TabIndex = 17;
            this.groupPanel1.Text = "     Reporte de Venta x Pedido      .";
            // 
            // cbAño
            // 
            this.cbAño.CustomFormat = "yyyy";
            this.cbAño.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cbAño.Location = new System.Drawing.Point(87, 12);
            this.cbAño.Name = "cbAño";
            this.cbAño.ShowUpDown = true;
            this.cbAño.Size = new System.Drawing.Size(147, 20);
            this.cbAño.TabIndex = 297;
            this.cbAño.ValueChanged += new System.EventHandler(this.cbAño_ValueChanged);
            // 
            // lblAño
            // 
            // 
            // 
            // 
            this.lblAño.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblAño.FontBold = true;
            this.lblAño.Location = new System.Drawing.Point(20, 12);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(45, 20);
            this.lblAño.TabIndex = 295;
            this.lblAño.Text = "Año:";
            // 
            // cbMes
            // 
            this.cbMes.DisplayMember = "Text";
            this.cbMes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMes.ForeColor = System.Drawing.Color.Black;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.ItemHeight = 14;
            this.cbMes.Location = new System.Drawing.Point(87, 52);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(147, 20);
            this.cbMes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbMes.TabIndex = 294;
            this.cbMes.SelectionChangeCommitted += new System.EventHandler(this.cbMes_SelectionChangeCommitted);
            // 
            // btnAceptar
            // 
            this.btnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
            this.btnAceptar.Location = new System.Drawing.Point(108, 132);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(89, 35);
            this.btnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAceptar.TabIndex = 293;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbPedido
            // 
            this.cbPedido.DisplayMember = "Text";
            this.cbPedido.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPedido.ForeColor = System.Drawing.Color.Black;
            this.cbPedido.FormattingEnabled = true;
            this.cbPedido.ItemHeight = 14;
            this.cbPedido.Location = new System.Drawing.Point(87, 90);
            this.cbPedido.Name = "cbPedido";
            this.cbPedido.Size = new System.Drawing.Size(147, 20);
            this.cbPedido.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbPedido.TabIndex = 24;
            this.cbPedido.SelectedIndexChanged += new System.EventHandler(this.cbPedido_SelectedIndexChanged);
            // 
            // lblfiltro
            // 
            // 
            // 
            // 
            this.lblfiltro.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltro.Location = new System.Drawing.Point(7, 87);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(61, 23);
            this.lblfiltro.TabIndex = 23;
            this.lblfiltro.Text = "N° Pedido: ";
            // 
            // lblHasta
            // 
            // 
            // 
            // 
            this.lblHasta.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(20, 49);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(48, 23);
            this.lblHasta.TabIndex = 21;
            this.lblHasta.Text = "Mes:  ";
            // 
            // ReportexPedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 262);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportexPedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte por Numero Pedido";
            this.Load += new System.EventHandler(this.ReportexPedio_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ReportexPedio_KeyUp);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbPedido;
        private DevComponents.DotNetBar.LabelX lblfiltro;
        private DevComponents.DotNetBar.LabelX lblHasta;
        private DevComponents.DotNetBar.ButtonX btnAceptar;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMes;
        private DevComponents.DotNetBar.LabelX lblAño;
        private System.Windows.Forms.DateTimePicker cbAño;
    }
}