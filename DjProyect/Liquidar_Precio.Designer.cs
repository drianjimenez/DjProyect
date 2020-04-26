namespace DjProyect
{
    partial class Liquidar_Precio
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
            this.txtdes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtcosto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtprecio = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coduni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ganancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porciento_ganancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadDataSet = new DjProyect.unidadDataSet();
            this.unidadTableAdapter = new DjProyect.unidadDataSetTableAdapters.unidadTableAdapter();
            this.codart = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.agregar = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtunidad = new System.Windows.Forms.ComboBox();
            this.unidadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtadicional = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtporciento = new System.Windows.Forms.ComboBox();
            this.porcientogananciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porciento_gananciaDataSet = new DjProyect.porciento_gananciaDataSet();
            this.porciento_gananciaTableAdapter = new DjProyect.porciento_gananciaDataSetTableAdapters.porciento_gananciaTableAdapter();
            this.txtitbis = new System.Windows.Forms.ComboBox();
            this.itbisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itbisDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itbisDataSet = new DjProyect.itbisDataSet();
            this.itbisTableAdapter = new DjProyect.itbisDataSetTableAdapters.itbisTableAdapter();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcientogananciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porciento_gananciaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itbisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itbisDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itbisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(357, 469);
            this.button4.Symbol = "57674";
            this.button4.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.button4.Text = "Eliminar";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 469);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 469);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(484, 469);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(40, 82);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 27;
            this.labelX1.Text = "CODIGO";
            // 
            // txtdes
            // 
            this.txtdes.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtdes.Border.Class = "TextBoxBorder";
            this.txtdes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdes.DisabledBackColor = System.Drawing.Color.White;
            this.txtdes.Enabled = false;
            this.txtdes.ForeColor = System.Drawing.Color.Black;
            this.txtdes.Location = new System.Drawing.Point(220, 102);
            this.txtdes.Name = "txtdes";
            this.txtdes.PreventEnterBeep = true;
            this.txtdes.Size = new System.Drawing.Size(267, 20);
            this.txtdes.TabIndex = 28;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(220, 82);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(87, 23);
            this.labelX2.TabIndex = 29;
            this.labelX2.Text = "DESCRIPCION";
            // 
            // txtcosto
            // 
            this.txtcosto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcosto.Border.Class = "TextBoxBorder";
            this.txtcosto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcosto.DisabledBackColor = System.Drawing.Color.White;
            this.txtcosto.ForeColor = System.Drawing.Color.Black;
            this.txtcosto.Location = new System.Drawing.Point(357, 159);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.PreventEnterBeep = true;
            this.txtcosto.Size = new System.Drawing.Size(132, 20);
            this.txtcosto.TabIndex = 30;
            this.txtcosto.Text = "0.00";
            this.txtcosto.TextChanged += new System.EventHandler(this.txtcosto_TextChanged);
            this.txtcosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcosto_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(357, 139);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 31;
            this.labelX3.Text = "COSTO";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(180, 138);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(151, 23);
            this.labelX4.TabIndex = 33;
            this.labelX4.Text = "PORCIENTO DE GANANCIA";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(40, 139);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 35;
            this.labelX5.Text = "ITBIS";
            // 
            // txtprecio
            // 
            this.txtprecio.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtprecio.Border.Class = "TextBoxBorder";
            this.txtprecio.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtprecio.DisabledBackColor = System.Drawing.Color.White;
            this.txtprecio.Enabled = false;
            this.txtprecio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.ForeColor = System.Drawing.Color.Black;
            this.txtprecio.Location = new System.Drawing.Point(40, 224);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.PreventEnterBeep = true;
            this.txtprecio.Size = new System.Drawing.Size(132, 27);
            this.txtprecio.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.id_itbis,
            this.itbis,
            this.coduni,
            this.unidad,
            this.id_ganancia,
            this.porciento_ganancia,
            this.costo,
            this.precio});
            this.dataGridView1.Location = new System.Drawing.Point(14, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(743, 205);
            this.dataGridView1.TabIndex = 38;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 150;
            // 
            // id_itbis
            // 
            this.id_itbis.HeaderText = "id_itbis";
            this.id_itbis.Name = "id_itbis";
            this.id_itbis.ReadOnly = true;
            this.id_itbis.Visible = false;
            // 
            // itbis
            // 
            this.itbis.HeaderText = "Itbis";
            this.itbis.Name = "itbis";
            this.itbis.ReadOnly = true;
            this.itbis.Width = 50;
            // 
            // coduni
            // 
            this.coduni.HeaderText = "coduni";
            this.coduni.Name = "coduni";
            this.coduni.ReadOnly = true;
            this.coduni.Visible = false;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // id_ganancia
            // 
            this.id_ganancia.HeaderText = "id_ganancia";
            this.id_ganancia.Name = "id_ganancia";
            this.id_ganancia.ReadOnly = true;
            this.id_ganancia.Visible = false;
            // 
            // porciento_ganancia
            // 
            this.porciento_ganancia.HeaderText = "Ganancia";
            this.porciento_ganancia.Name = "porciento_ganancia";
            this.porciento_ganancia.ReadOnly = true;
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio_Venta";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // unidadBindingSource
            // 
            this.unidadBindingSource.DataMember = "unidad";
            this.unidadBindingSource.DataSource = this.unidadDataSetBindingSource;
            // 
            // unidadDataSetBindingSource
            // 
            this.unidadDataSetBindingSource.DataSource = this.unidadDataSet;
            this.unidadDataSetBindingSource.Position = 0;
            // 
            // unidadDataSet
            // 
            this.unidadDataSet.DataSetName = "unidadDataSet";
            this.unidadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unidadTableAdapter
            // 
            this.unidadTableAdapter.ClearBeforeFill = true;
            // 
            // codart
            // 
            this.codart.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.codart.Border.Class = "TextBoxBorder";
            this.codart.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.codart.DisabledBackColor = System.Drawing.Color.White;
            this.codart.ForeColor = System.Drawing.Color.Black;
            this.codart.Location = new System.Drawing.Point(40, 102);
            this.codart.Name = "codart";
            this.codart.PreventEnterBeep = true;
            this.codart.Size = new System.Drawing.Size(132, 20);
            this.codart.TabIndex = 40;
            this.codart.TextChanged += new System.EventHandler(this.codart_TextChanged);
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(174, 98);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(34, 26);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.TabIndex = 41;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(40, 204);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(116, 23);
            this.labelX7.TabIndex = 43;
            this.labelX7.Text = "PRECIO DE VENTA";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(496, 82);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 44;
            this.labelX6.Text = "UNIDAD";
            // 
            // agregar
            // 
            this.agregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.agregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.agregar.Location = new System.Drawing.Point(673, 225);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(84, 26);
            this.agregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.agregar.Symbol = "";
            this.agregar.TabIndex = 45;
            this.agregar.Text = "Agregar";
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtunidad
            // 
            this.txtunidad.DataSource = this.unidadBindingSource1;
            this.txtunidad.DisplayMember = "nombre";
            this.txtunidad.FormattingEnabled = true;
            this.txtunidad.Location = new System.Drawing.Point(496, 101);
            this.txtunidad.Name = "txtunidad";
            this.txtunidad.Size = new System.Drawing.Size(121, 21);
            this.txtunidad.TabIndex = 46;
            this.txtunidad.ValueMember = "codigo";
            // 
            // unidadBindingSource1
            // 
            this.unidadBindingSource1.DataMember = "unidad";
            this.unidadBindingSource1.DataSource = this.unidadDataSetBindingSource;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(521, 139);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(116, 23);
            this.labelX8.TabIndex = 48;
            this.labelX8.Text = "PRECIO ADICIONAL";
            // 
            // txtadicional
            // 
            this.txtadicional.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtadicional.Border.Class = "TextBoxBorder";
            this.txtadicional.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtadicional.DisabledBackColor = System.Drawing.Color.White;
            this.txtadicional.ForeColor = System.Drawing.Color.Black;
            this.txtadicional.Location = new System.Drawing.Point(521, 159);
            this.txtadicional.Name = "txtadicional";
            this.txtadicional.PreventEnterBeep = true;
            this.txtadicional.Size = new System.Drawing.Size(132, 20);
            this.txtadicional.TabIndex = 47;
            this.txtadicional.Text = "0.00";
            this.txtadicional.TextChanged += new System.EventHandler(this.txtadicional_TextChanged);
            this.txtadicional.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadicional_KeyPress);
            // 
            // txtporciento
            // 
            this.txtporciento.DataSource = this.porcientogananciaBindingSource;
            this.txtporciento.DisplayMember = "valor";
            this.txtporciento.FormattingEnabled = true;
            this.txtporciento.Location = new System.Drawing.Point(180, 159);
            this.txtporciento.Name = "txtporciento";
            this.txtporciento.Size = new System.Drawing.Size(121, 21);
            this.txtporciento.TabIndex = 49;
            this.txtporciento.ValueMember = "codigo";
            // 
            // porcientogananciaBindingSource
            // 
            this.porcientogananciaBindingSource.DataMember = "porciento_ganancia";
            this.porcientogananciaBindingSource.DataSource = this.porciento_gananciaDataSet;
            // 
            // porciento_gananciaDataSet
            // 
            this.porciento_gananciaDataSet.DataSetName = "porciento_gananciaDataSet";
            this.porciento_gananciaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // porciento_gananciaTableAdapter
            // 
            this.porciento_gananciaTableAdapter.ClearBeforeFill = true;
            // 
            // txtitbis
            // 
            this.txtitbis.DataSource = this.itbisBindingSource;
            this.txtitbis.DisplayMember = "valor";
            this.txtitbis.FormattingEnabled = true;
            this.txtitbis.Location = new System.Drawing.Point(40, 158);
            this.txtitbis.Name = "txtitbis";
            this.txtitbis.Size = new System.Drawing.Size(121, 21);
            this.txtitbis.TabIndex = 50;
            this.txtitbis.ValueMember = "codigo";
            // 
            // itbisBindingSource
            // 
            this.itbisBindingSource.DataMember = "itbis";
            this.itbisBindingSource.DataSource = this.itbisDataSetBindingSource;
            // 
            // itbisDataSetBindingSource
            // 
            this.itbisDataSetBindingSource.DataSource = this.itbisDataSet;
            this.itbisDataSetBindingSource.Position = 0;
            // 
            // itbisDataSet
            // 
            this.itbisDataSet.DataSetName = "itbisDataSet";
            this.itbisDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itbisTableAdapter
            // 
            this.itbisTableAdapter.ClearBeforeFill = true;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(180, 224);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(84, 26);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 51;
            this.buttonX1.Text = "Calcular";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Liquidar_Precio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 522);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txtitbis);
            this.Controls.Add(this.txtporciento);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtadicional);
            this.Controls.Add(this.txtunidad);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.codart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtcosto);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "Liquidar_Precio";
            this.Text = "Liquidar_Precio";
            this.Load += new System.EventHandler(this.Liquidar_Precio_Load);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.txtdes, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.txtcosto, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.txtprecio, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.codart, 0);
            this.Controls.SetChildIndex(this.buttonX2, 0);
            this.Controls.SetChildIndex(this.labelX7, 0);
            this.Controls.SetChildIndex(this.labelX6, 0);
            this.Controls.SetChildIndex(this.agregar, 0);
            this.Controls.SetChildIndex(this.txtunidad, 0);
            this.Controls.SetChildIndex(this.txtadicional, 0);
            this.Controls.SetChildIndex(this.labelX8, 0);
            this.Controls.SetChildIndex(this.txtporciento, 0);
            this.Controls.SetChildIndex(this.txtitbis, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcientogananciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porciento_gananciaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itbisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itbisDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itbisDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdes;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcosto;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtprecio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource unidadDataSetBindingSource;
        private unidadDataSet unidadDataSet;
        private System.Windows.Forms.BindingSource unidadBindingSource;
        private unidadDataSetTableAdapters.unidadTableAdapter unidadTableAdapter;
        private DevComponents.DotNetBar.Controls.TextBoxX codart;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX agregar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox txtunidad;
        private System.Windows.Forms.BindingSource unidadBindingSource1;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtadicional;
        private System.Windows.Forms.ComboBox txtporciento;
        private porciento_gananciaDataSet porciento_gananciaDataSet;
        private System.Windows.Forms.BindingSource porcientogananciaBindingSource;
        private porciento_gananciaDataSetTableAdapters.porciento_gananciaTableAdapter porciento_gananciaTableAdapter;
        private System.Windows.Forms.ComboBox txtitbis;
        private System.Windows.Forms.BindingSource itbisDataSetBindingSource;
        private itbisDataSet itbisDataSet;
        private System.Windows.Forms.BindingSource itbisBindingSource;
        private itbisDataSetTableAdapters.itbisTableAdapter itbisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn coduni;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ganancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn porciento_ganancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}