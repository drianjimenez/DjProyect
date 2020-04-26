namespace DjProyect
{
    partial class Devolucion_Venta
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.numero = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.monto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.comprobante = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.articuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturanumeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coduniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistadetallefacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistadetallefacturaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_detalle_facturaDataSet = new DjProyect.vista_detalle_facturaDataSet();
            this.txtusuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.impo = new System.Windows.Forms.TextBox();
            this.btntodo = new DevComponents.DotNetBar.ButtonX();
            this.btnnada = new DevComponents.DotNetBar.ButtonX();
            this.txttipo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtsecuencia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.vista_detalle_facturaTableAdapter = new DjProyect.vista_detalle_facturaDataSetTableAdapters.vista_detalle_facturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistadetallefacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistadetallefacturaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_detalle_facturaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(494, 20);
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(280, 411);
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 411);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(461, 411);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(23, 80);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 25;
            this.labelX1.Text = "FACTURA#";
            // 
            // numero
            // 
            this.numero.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.numero.Border.Class = "TextBoxBorder";
            this.numero.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.numero.DisabledBackColor = System.Drawing.Color.White;
            this.numero.Enabled = false;
            this.numero.ForeColor = System.Drawing.Color.Black;
            this.numero.Location = new System.Drawing.Point(88, 80);
            this.numero.Name = "numero";
            this.numero.PreventEnterBeep = true;
            this.numero.Size = new System.Drawing.Size(100, 20);
            this.numero.TabIndex = 26;
            this.numero.TextChanged += new System.EventHandler(this.numero_TextChanged);
            this.numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_KeyPress);
            // 
            // monto
            // 
            this.monto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.monto.Border.Class = "TextBoxBorder";
            this.monto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.monto.DisabledBackColor = System.Drawing.Color.White;
            this.monto.Enabled = false;
            this.monto.ForeColor = System.Drawing.Color.Black;
            this.monto.Location = new System.Drawing.Point(494, 77);
            this.monto.Name = "monto";
            this.monto.PreventEnterBeep = true;
            this.monto.Size = new System.Drawing.Size(100, 20);
            this.monto.TabIndex = 28;
            this.monto.TextChanged += new System.EventHandler(this.monto_TextChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(444, 74);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(44, 23);
            this.labelX2.TabIndex = 27;
            this.labelX2.Text = "MONTO";
            // 
            // comprobante
            // 
            this.comprobante.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.comprobante.Border.Class = "TextBoxBorder";
            this.comprobante.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.comprobante.DisabledBackColor = System.Drawing.Color.White;
            this.comprobante.Enabled = false;
            this.comprobante.ForeColor = System.Drawing.Color.Black;
            this.comprobante.Location = new System.Drawing.Point(222, 77);
            this.comprobante.Name = "comprobante";
            this.comprobante.PreventEnterBeep = true;
            this.comprobante.Size = new System.Drawing.Size(188, 20);
            this.comprobante.TabIndex = 30;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(194, 77);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(39, 23);
            this.labelX3.TabIndex = 29;
            this.labelX3.Text = "NCF";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.estado,
            this.articuloDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.importeDataGridViewTextBoxColumn,
            this.facturanumeroDataGridViewTextBoxColumn,
            this.coduniDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vistadetallefacturaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(589, 196);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridView1_CurrentCellDirtyStateChanged);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.Width = 75;
            // 
            // articuloDataGridViewTextBoxColumn
            // 
            this.articuloDataGridViewTextBoxColumn.DataPropertyName = "articulo";
            this.articuloDataGridViewTextBoxColumn.HeaderText = "articulo";
            this.articuloDataGridViewTextBoxColumn.Name = "articuloDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 170;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // importeDataGridViewTextBoxColumn
            // 
            this.importeDataGridViewTextBoxColumn.DataPropertyName = "importe";
            this.importeDataGridViewTextBoxColumn.HeaderText = "importe";
            this.importeDataGridViewTextBoxColumn.Name = "importeDataGridViewTextBoxColumn";
            // 
            // facturanumeroDataGridViewTextBoxColumn
            // 
            this.facturanumeroDataGridViewTextBoxColumn.DataPropertyName = "factura_numero";
            this.facturanumeroDataGridViewTextBoxColumn.HeaderText = "factura_numero";
            this.facturanumeroDataGridViewTextBoxColumn.Name = "facturanumeroDataGridViewTextBoxColumn";
            this.facturanumeroDataGridViewTextBoxColumn.Visible = false;
            // 
            // coduniDataGridViewTextBoxColumn
            // 
            this.coduniDataGridViewTextBoxColumn.DataPropertyName = "coduni";
            this.coduniDataGridViewTextBoxColumn.HeaderText = "coduni";
            this.coduniDataGridViewTextBoxColumn.Name = "coduniDataGridViewTextBoxColumn";
            this.coduniDataGridViewTextBoxColumn.Visible = false;
            // 
            // vistadetallefacturaBindingSource
            // 
            this.vistadetallefacturaBindingSource.DataMember = "vista_detalle_factura";
            this.vistadetallefacturaBindingSource.DataSource = this.vistadetallefacturaDataSetBindingSource;
            // 
            // vistadetallefacturaDataSetBindingSource
            // 
            this.vistadetallefacturaDataSetBindingSource.DataSource = this.vista_detalle_facturaDataSet;
            this.vistadetallefacturaDataSetBindingSource.Position = 0;
            // 
            // vista_detalle_facturaDataSet
            // 
            this.vista_detalle_facturaDataSet.DataSetName = "vista_detalle_facturaDataSet";
            this.vista_detalle_facturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.txtusuario.Location = new System.Drawing.Point(217, 20);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PreventEnterBeep = true;
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 37;
            this.txtusuario.Visible = false;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Red;
            this.labelX4.Location = new System.Drawing.Point(344, 343);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(100, 37);
            this.labelX4.TabIndex = 39;
            this.labelX4.Text = "TOTAL";
            // 
            // impo
            // 
            this.impo.Enabled = false;
            this.impo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impo.Location = new System.Drawing.Point(450, 343);
            this.impo.Multiline = true;
            this.impo.Name = "impo";
            this.impo.Size = new System.Drawing.Size(163, 37);
            this.impo.TabIndex = 38;
            // 
            // btntodo
            // 
            this.btntodo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btntodo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btntodo.Location = new System.Drawing.Point(23, 109);
            this.btntodo.Name = "btntodo";
            this.btntodo.Size = new System.Drawing.Size(131, 26);
            this.btntodo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btntodo.Symbol = "";
            this.btntodo.TabIndex = 40;
            this.btntodo.Text = "Devolver Factura Completa";
            this.btntodo.Click += new System.EventHandler(this.btntodo_Click);
            // 
            // btnnada
            // 
            this.btnnada.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnnada.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnnada.Location = new System.Drawing.Point(160, 109);
            this.btnnada.Name = "btnnada";
            this.btnnada.Size = new System.Drawing.Size(126, 26);
            this.btnnada.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnnada.Symbol = "";
            this.btnnada.TabIndex = 41;
            this.btnnada.Text = "Seleccionar Los Productos";
            this.btnnada.Click += new System.EventHandler(this.btnnada_Click);
            // 
            // txttipo
            // 
            this.txttipo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txttipo.Border.Class = "TextBoxBorder";
            this.txttipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttipo.DisabledBackColor = System.Drawing.Color.White;
            this.txttipo.Enabled = false;
            this.txttipo.ForeColor = System.Drawing.Color.Black;
            this.txttipo.Location = new System.Drawing.Point(336, 20);
            this.txttipo.Name = "txttipo";
            this.txttipo.PreventEnterBeep = true;
            this.txttipo.Size = new System.Drawing.Size(100, 20);
            this.txttipo.TabIndex = 42;
            this.txttipo.Text = "04";
            this.txttipo.Visible = false;
            // 
            // txtsecuencia
            // 
            this.txtsecuencia.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtsecuencia.Border.Class = "TextBoxBorder";
            this.txtsecuencia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsecuencia.DisabledBackColor = System.Drawing.Color.White;
            this.txtsecuencia.Enabled = false;
            this.txtsecuencia.ForeColor = System.Drawing.Color.Black;
            this.txtsecuencia.Location = new System.Drawing.Point(336, 46);
            this.txtsecuencia.Name = "txtsecuencia";
            this.txtsecuencia.PreventEnterBeep = true;
            this.txtsecuencia.Size = new System.Drawing.Size(100, 20);
            this.txtsecuencia.TabIndex = 43;
            this.txtsecuencia.Visible = false;
            // 
            // vista_detalle_facturaTableAdapter
            // 
            this.vista_detalle_facturaTableAdapter.ClearBeforeFill = true;
            // 
            // Devolucion_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 467);
            this.Controls.Add(this.txtsecuencia);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.btnnada);
            this.Controls.Add(this.btntodo);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.impo);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comprobante);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.monto);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.labelX1);
            this.Name = "Devolucion_Venta";
            this.Text = "Devolucion Venta";
            this.Load += new System.EventHandler(this.Devolucion_Venta_Load);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.numero, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.monto, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.comprobante, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.txtusuario, 0);
            this.Controls.SetChildIndex(this.impo, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.Controls.SetChildIndex(this.btntodo, 0);
            this.Controls.SetChildIndex(this.btnnada, 0);
            this.Controls.SetChildIndex(this.txttipo, 0);
            this.Controls.SetChildIndex(this.txtsecuencia, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistadetallefacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistadetallefacturaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_detalle_facturaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX monto;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX comprobante;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DataGridView dataGridView1;
        public DevComponents.DotNetBar.Controls.TextBoxX txtusuario;
        private DevComponents.DotNetBar.LabelX labelX4;
        public System.Windows.Forms.TextBox impo;
        private DevComponents.DotNetBar.ButtonX btntodo;
        private DevComponents.DotNetBar.ButtonX btnnada;
        public DevComponents.DotNetBar.Controls.TextBoxX numero;
        public DevComponents.DotNetBar.Controls.TextBoxX txttipo;
        public DevComponents.DotNetBar.Controls.TextBoxX txtsecuencia;
        private System.Windows.Forms.BindingSource vistadetallefacturaDataSetBindingSource;
        private vista_detalle_facturaDataSet vista_detalle_facturaDataSet;
        private System.Windows.Forms.BindingSource vistadetallefacturaBindingSource;
        private vista_detalle_facturaDataSetTableAdapters.vista_detalle_facturaTableAdapter vista_detalle_facturaTableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn articuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturanumeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coduniDataGridViewTextBoxColumn;
    }
}