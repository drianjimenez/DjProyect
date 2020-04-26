namespace DjProyect
{
    partial class Pagar_Factura
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
            this.components = new System.ComponentModel.Container();
            this.txtusuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtsinaplicar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtpagoaplicado = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txttotalpendiente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechafacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.montoaplicar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistapagarcompraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_pagar_compraDataSet = new DjProyect.vista_pagar_compraDataSet();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.suplidor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.codsup = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnguardar = new DevComponents.DotNetBar.ButtonX();
            this.vista_pagar_compraTableAdapter = new DjProyect.vista_pagar_compraDataSetTableAdapters.vista_pagar_compraTableAdapter();
            this.btnnada = new DevComponents.DotNetBar.ButtonX();
            this.btntodo = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistapagarcompraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_pagar_compraDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(473, 462);
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtusuario.Border.Class = "TextBoxBorder";
            this.txtusuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtusuario.DisabledBackColor = System.Drawing.Color.White;
            this.txtusuario.Enabled = false;
            this.txtusuario.ForeColor = System.Drawing.Color.Black;
            this.txtusuario.Location = new System.Drawing.Point(292, 29);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PreventEnterBeep = true;
            this.txtusuario.Size = new System.Drawing.Size(61, 20);
            this.txtusuario.TabIndex = 55;
            this.txtusuario.Visible = false;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtsinaplicar);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.txtpagoaplicado);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txttotalpendiente);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(78, 382);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(479, 75);
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
            this.groupPanel1.TabIndex = 60;
            // 
            // txtsinaplicar
            // 
            this.txtsinaplicar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtsinaplicar.Border.Class = "TextBoxBorder";
            this.txtsinaplicar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsinaplicar.DisabledBackColor = System.Drawing.Color.White;
            this.txtsinaplicar.Enabled = false;
            this.txtsinaplicar.ForeColor = System.Drawing.Color.Black;
            this.txtsinaplicar.Location = new System.Drawing.Point(331, 31);
            this.txtsinaplicar.Name = "txtsinaplicar";
            this.txtsinaplicar.PreventEnterBeep = true;
            this.txtsinaplicar.Size = new System.Drawing.Size(117, 20);
            this.txtsinaplicar.TabIndex = 9;
            this.txtsinaplicar.Text = "0.00";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(331, 3);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(117, 23);
            this.labelX6.TabIndex = 8;
            this.labelX6.Text = "TOTAL SIN APLICAR";
            // 
            // txtpagoaplicado
            // 
            this.txtpagoaplicado.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtpagoaplicado.Border.Class = "TextBoxBorder";
            this.txtpagoaplicado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpagoaplicado.DisabledBackColor = System.Drawing.Color.White;
            this.txtpagoaplicado.Enabled = false;
            this.txtpagoaplicado.ForeColor = System.Drawing.Color.Black;
            this.txtpagoaplicado.Location = new System.Drawing.Point(164, 31);
            this.txtpagoaplicado.Name = "txtpagoaplicado";
            this.txtpagoaplicado.PreventEnterBeep = true;
            this.txtpagoaplicado.Size = new System.Drawing.Size(135, 20);
            this.txtpagoaplicado.TabIndex = 5;
            this.txtpagoaplicado.Text = "0.00";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(167, 3);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(132, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "TOTAL PAGO APLICADO";
            // 
            // txttotalpendiente
            // 
            this.txttotalpendiente.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txttotalpendiente.Border.Class = "TextBoxBorder";
            this.txttotalpendiente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttotalpendiente.DisabledBackColor = System.Drawing.Color.White;
            this.txttotalpendiente.Enabled = false;
            this.txttotalpendiente.ForeColor = System.Drawing.Color.Black;
            this.txttotalpendiente.Location = new System.Drawing.Point(34, 32);
            this.txttotalpendiente.Name = "txttotalpendiente";
            this.txttotalpendiente.PreventEnterBeep = true;
            this.txttotalpendiente.Size = new System.Drawing.Size(100, 20);
            this.txttotalpendiente.TabIndex = 1;
            this.txttotalpendiente.Text = "0.00";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(34, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(104, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "TOTAL PENDIENTE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.fecharegistroDataGridViewTextBoxColumn,
            this.fechafacturaDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.des,
            this.Monto,
            this.montoaplicar});
            this.dataGridView1.DataSource = this.vistapagarcompraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 250);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fecharegistroDataGridViewTextBoxColumn
            // 
            this.fecharegistroDataGridViewTextBoxColumn.DataPropertyName = "fecha_registro";
            this.fecharegistroDataGridViewTextBoxColumn.HeaderText = "fecha_registro";
            this.fecharegistroDataGridViewTextBoxColumn.Name = "fecharegistroDataGridViewTextBoxColumn";
            this.fecharegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.fecharegistroDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechafacturaDataGridViewTextBoxColumn
            // 
            this.fechafacturaDataGridViewTextBoxColumn.DataPropertyName = "fecha_factura";
            this.fechafacturaDataGridViewTextBoxColumn.HeaderText = "fecha_factura";
            this.fechafacturaDataGridViewTextBoxColumn.Name = "fechafacturaDataGridViewTextBoxColumn";
            this.fechafacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechafacturaDataGridViewTextBoxColumn.Width = 125;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Pendiente";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // des
            // 
            this.des.HeaderText = "Descuento";
            this.des.Name = "des";
            this.des.ReadOnly = true;
            this.des.Visible = false;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto a Pagar";
            this.Monto.Name = "Monto";
            this.Monto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Monto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // montoaplicar
            // 
            this.montoaplicar.HeaderText = "Montos Aplicar";
            this.montoaplicar.Name = "montoaplicar";
            this.montoaplicar.ReadOnly = true;
            this.montoaplicar.Visible = false;
            // 
            // vistapagarcompraBindingSource
            // 
            this.vistapagarcompraBindingSource.DataMember = "vista_pagar_compra";
            this.vistapagarcompraBindingSource.DataSource = this.vista_pagar_compraDataSet;
            // 
            // vista_pagar_compraDataSet
            // 
            this.vista_pagar_compraDataSet.DataSetName = "vista_pagar_compraDataSet";
            this.vista_pagar_compraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(26, 63);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 58;
            this.labelX5.Text = "SUPLIDOR";
            // 
            // suplidor
            // 
            this.suplidor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.suplidor.Border.Class = "TextBoxBorder";
            this.suplidor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.suplidor.DisabledBackColor = System.Drawing.Color.White;
            this.suplidor.Enabled = false;
            this.suplidor.ForeColor = System.Drawing.Color.Black;
            this.suplidor.Location = new System.Drawing.Point(174, 63);
            this.suplidor.Name = "suplidor";
            this.suplidor.PreventEnterBeep = true;
            this.suplidor.Size = new System.Drawing.Size(281, 20);
            this.suplidor.TabIndex = 57;
            // 
            // codsup
            // 
            this.codsup.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.codsup.Border.Class = "TextBoxBorder";
            this.codsup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.codsup.DisabledBackColor = System.Drawing.Color.White;
            this.codsup.Enabled = false;
            this.codsup.ForeColor = System.Drawing.Color.Black;
            this.codsup.Location = new System.Drawing.Point(107, 63);
            this.codsup.Name = "codsup";
            this.codsup.PreventEnterBeep = true;
            this.codsup.Size = new System.Drawing.Size(61, 20);
            this.codsup.TabIndex = 56;
            this.codsup.TextChanged += new System.EventHandler(this.codsup_TextChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnguardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnguardar.Location = new System.Drawing.Point(81, 462);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(87, 36);
            this.btnguardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnguardar.Symbol = "";
            this.btnguardar.TabIndex = 61;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // vista_pagar_compraTableAdapter
            // 
            this.vista_pagar_compraTableAdapter.ClearBeforeFill = true;
            // 
            // btnnada
            // 
            this.btnnada.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnada.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnnada.Location = new System.Drawing.Point(160, 94);
            this.btnnada.Name = "btnnada";
            this.btnnada.Size = new System.Drawing.Size(126, 26);
            this.btnnada.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnada.Symbol = "";
            this.btnnada.TabIndex = 63;
            this.btnnada.Text = "Seleccionar Todo";
            this.btnnada.Click += new System.EventHandler(this.btnnada_Click);
            // 
            // btntodo
            // 
            this.btntodo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btntodo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btntodo.Location = new System.Drawing.Point(23, 94);
            this.btntodo.Name = "btntodo";
            this.btntodo.Size = new System.Drawing.Size(131, 26);
            this.btntodo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btntodo.Symbol = "";
            this.btntodo.TabIndex = 62;
            this.btntodo.Text = "Seleccionar Todo";
            this.btntodo.Click += new System.EventHandler(this.btntodo_Click);
            // 
            // Pagar_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 529);
            this.Controls.Add(this.btnnada);
            this.Controls.Add(this.btntodo);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.suplidor);
            this.Controls.Add(this.codsup);
            this.Controls.Add(this.txtusuario);
            this.Name = "Pagar_Factura";
            this.Text = "Pagar Factura";
            this.Load += new System.EventHandler(this.Pagar_Factura_Load);
            this.Controls.SetChildIndex(this.txtusuario, 0);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.codsup, 0);
            this.Controls.SetChildIndex(this.suplidor, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.groupPanel1, 0);
            this.Controls.SetChildIndex(this.btnguardar, 0);
            this.Controls.SetChildIndex(this.btntodo, 0);
            this.Controls.SetChildIndex(this.btnnada, 0);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistapagarcompraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_pagar_compraDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Controls.TextBoxX txtusuario;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsinaplicar;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpagoaplicado;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txttotalpendiente;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX suplidor;
        public DevComponents.DotNetBar.Controls.TextBoxX codsup;
        private DevComponents.DotNetBar.ButtonX btnguardar;
        private vista_pagar_compraDataSet vista_pagar_compraDataSet;
        private System.Windows.Forms.BindingSource vistapagarcompraBindingSource;
        private vista_pagar_compraDataSetTableAdapters.vista_pagar_compraTableAdapter vista_pagar_compraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechafacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn des;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoaplicar;
        private DevComponents.DotNetBar.ButtonX btnnada;
        private DevComponents.DotNetBar.ButtonX btntodo;
    }
}