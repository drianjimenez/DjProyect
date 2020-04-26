namespace DjProyect
{
    partial class Compra
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
            this.txtcodigo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtusuario = new DevComponents.DotNetBar.LabelX();
            this.txtregistro = new System.Windows.Forms.DateTimePicker();
            this.txtfactura = new System.Windows.Forms.DateTimePicker();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.nombresuplidor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtsuplidor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.al = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idunidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.txtmonto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.agregar = new DevComponents.DotNetBar.ButtonX();
            this.canart = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.desart = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.codart = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.preart = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.txtnomalmacen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtalmacen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label9 = new DevComponents.DotNetBar.LabelX();
            this.txtunidad = new System.Windows.Forms.ComboBox();
            this.unidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadDataSet = new DjProyect.unidadDataSet();
            this.unidadTableAdapter = new DjProyect.unidadDataSetTableAdapters.unidadTableAdapter();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(436, 463);
            this.button4.TabIndex = 11;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(284, 514);
            this.button3.TabIndex = 9;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 514);
            this.button2.TabIndex = 8;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(637, 514);
            this.salir.TabIndex = 12;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(23, 65);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 25;
            this.labelX1.Text = "CODIGO";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcodigo.Border.Class = "TextBoxBorder";
            this.txtcodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcodigo.DisabledBackColor = System.Drawing.Color.White;
            this.txtcodigo.ForeColor = System.Drawing.Color.Black;
            this.txtcodigo.Location = new System.Drawing.Point(23, 85);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PreventEnterBeep = true;
            this.txtcodigo.Size = new System.Drawing.Size(139, 20);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.Text = "0";
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(559, 50);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(116, 23);
            this.labelX2.TabIndex = 27;
            this.labelX2.Text = "FECHA_REGISTRO";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(559, 118);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(116, 23);
            this.labelX3.TabIndex = 28;
            this.labelX3.Text = "FECHA_FACTURA";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(23, 121);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 29;
            this.labelX4.Text = "SUPLIDOR";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Red;
            this.labelX5.Location = new System.Drawing.Point(541, 458);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 30;
            this.labelX5.Text = "TOTAL";
            // 
            // txtusuario
            // 
            // 
            // 
            // 
            this.txtusuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtusuario.Location = new System.Drawing.Point(296, 50);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(75, 23);
            this.txtusuario.TabIndex = 32;
            this.txtusuario.Text = "usuario";
            this.txtusuario.Visible = false;
            // 
            // txtregistro
            // 
            this.txtregistro.Location = new System.Drawing.Point(559, 79);
            this.txtregistro.Name = "txtregistro";
            this.txtregistro.Size = new System.Drawing.Size(214, 20);
            this.txtregistro.TabIndex = 37;
            // 
            // txtfactura
            // 
            this.txtfactura.Location = new System.Drawing.Point(559, 147);
            this.txtfactura.Name = "txtfactura";
            this.txtfactura.Size = new System.Drawing.Size(214, 20);
            this.txtfactura.TabIndex = 38;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(73, 147);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(27, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolColor = System.Drawing.Color.Black;
            this.buttonX1.SymbolSize = 15F;
            this.buttonX1.TabIndex = 48;
            this.buttonX1.Text = " ";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // nombresuplidor
            // 
            this.nombresuplidor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.nombresuplidor.Border.Class = "TextBoxBorder";
            this.nombresuplidor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nombresuplidor.DisabledBackColor = System.Drawing.Color.White;
            this.nombresuplidor.Enabled = false;
            this.nombresuplidor.ForeColor = System.Drawing.Color.Black;
            this.nombresuplidor.Location = new System.Drawing.Point(106, 150);
            this.nombresuplidor.Name = "nombresuplidor";
            this.nombresuplidor.PreventEnterBeep = true;
            this.nombresuplidor.Size = new System.Drawing.Size(298, 20);
            this.nombresuplidor.TabIndex = 47;
            // 
            // txtsuplidor
            // 
            this.txtsuplidor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtsuplidor.Border.Class = "TextBoxBorder";
            this.txtsuplidor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsuplidor.DisabledBackColor = System.Drawing.Color.White;
            this.txtsuplidor.ForeColor = System.Drawing.Color.Black;
            this.txtsuplidor.Location = new System.Drawing.Point(23, 150);
            this.txtsuplidor.Name = "txtsuplidor";
            this.txtsuplidor.PreventEnterBeep = true;
            this.txtsuplidor.Size = new System.Drawing.Size(44, 20);
            this.txtsuplidor.TabIndex = 1;
            this.txtsuplidor.TextChanged += new System.EventHandler(this.txtsuplidor_TextChanged);
            this.txtsuplidor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsuplidor_KeyDown);
            this.txtsuplidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsuplidor_KeyPress);
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
            this.al,
            this.idunidad,
            this.unidad,
            this.cantidad,
            this.costo1});
            this.dataGridView1.Location = new System.Drawing.Point(22, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 150);
            this.dataGridView1.TabIndex = 52;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
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
            this.descripcion.Width = 200;
            // 
            // al
            // 
            this.al.HeaderText = "Almacen";
            this.al.Name = "al";
            this.al.ReadOnly = true;
            // 
            // idunidad
            // 
            this.idunidad.HeaderText = "idunidad";
            this.idunidad.Name = "idunidad";
            this.idunidad.ReadOnly = true;
            this.idunidad.Visible = false;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            this.unidad.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // costo1
            // 
            this.costo1.HeaderText = "Costo";
            this.costo1.Name = "costo1";
            this.costo1.ReadOnly = true;
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(474, 514);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(84, 36);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.TabIndex = 10;
            this.buttonX3.Text = "Eliminar";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // txtmonto
            // 
            this.txtmonto.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtmonto.Border.Class = "TextBoxBorder";
            this.txtmonto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtmonto.DisabledBackColor = System.Drawing.Color.White;
            this.txtmonto.Enabled = false;
            this.txtmonto.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonto.ForeColor = System.Drawing.Color.Black;
            this.txtmonto.Location = new System.Drawing.Point(622, 457);
            this.txtmonto.Multiline = true;
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.PreventEnterBeep = true;
            this.txtmonto.Size = new System.Drawing.Size(139, 42);
            this.txtmonto.TabIndex = 54;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(128, 277);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(34, 26);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.TabIndex = 60;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // agregar
            // 
            this.agregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.agregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.agregar.Location = new System.Drawing.Point(685, 271);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(84, 26);
            this.agregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.agregar.Symbol = "";
            this.agregar.TabIndex = 7;
            this.agregar.Text = "Agregar";
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // canart
            // 
            this.canart.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.canart.Border.Class = "TextBoxBorder";
            this.canart.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.canart.DisabledBackColor = System.Drawing.Color.White;
            this.canart.ForeColor = System.Drawing.Color.Black;
            this.canart.Location = new System.Drawing.Point(474, 277);
            this.canart.Name = "canart";
            this.canart.PreventEnterBeep = true;
            this.canart.Size = new System.Drawing.Size(78, 20);
            this.canart.TabIndex = 5;
            this.canart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.canart_KeyPress);
            // 
            // desart
            // 
            this.desart.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.desart.Border.Class = "TextBoxBorder";
            this.desart.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.desart.DisabledBackColor = System.Drawing.Color.White;
            this.desart.Enabled = false;
            this.desart.ForeColor = System.Drawing.Color.Black;
            this.desart.Location = new System.Drawing.Point(168, 277);
            this.desart.Name = "desart";
            this.desart.PreventEnterBeep = true;
            this.desart.Size = new System.Drawing.Size(220, 20);
            this.desart.TabIndex = 58;
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
            this.codart.Location = new System.Drawing.Point(22, 277);
            this.codart.Name = "codart";
            this.codart.PreventEnterBeep = true;
            this.codart.Size = new System.Drawing.Size(100, 20);
            this.codart.TabIndex = 3;
            this.codart.TextChanged += new System.EventHandler(this.codart_TextChanged);
            this.codart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codart_KeyDown);
            // 
            // preart
            // 
            this.preart.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.preart.Border.Class = "TextBoxBorder";
            this.preart.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.preart.DisabledBackColor = System.Drawing.Color.White;
            this.preart.ForeColor = System.Drawing.Color.Black;
            this.preart.Location = new System.Drawing.Point(394, 277);
            this.preart.Name = "preart";
            this.preart.PreventEnterBeep = true;
            this.preart.Size = new System.Drawing.Size(74, 20);
            this.preart.TabIndex = 4;
            this.preart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.preart_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(73, 203);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(27, 23);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.Symbol = "";
            this.buttonX4.SymbolColor = System.Drawing.Color.Black;
            this.buttonX4.SymbolSize = 15F;
            this.buttonX4.TabIndex = 63;
            this.buttonX4.Text = " ";
            // 
            // txtnomalmacen
            // 
            this.txtnomalmacen.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtnomalmacen.Border.Class = "TextBoxBorder";
            this.txtnomalmacen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnomalmacen.DisabledBackColor = System.Drawing.Color.White;
            this.txtnomalmacen.Enabled = false;
            this.txtnomalmacen.ForeColor = System.Drawing.Color.Black;
            this.txtnomalmacen.Location = new System.Drawing.Point(106, 206);
            this.txtnomalmacen.Name = "txtnomalmacen";
            this.txtnomalmacen.PreventEnterBeep = true;
            this.txtnomalmacen.Size = new System.Drawing.Size(298, 20);
            this.txtnomalmacen.TabIndex = 62;
            // 
            // txtalmacen
            // 
            this.txtalmacen.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtalmacen.Border.Class = "TextBoxBorder";
            this.txtalmacen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtalmacen.DisabledBackColor = System.Drawing.Color.White;
            this.txtalmacen.ForeColor = System.Drawing.Color.Black;
            this.txtalmacen.Location = new System.Drawing.Point(23, 206);
            this.txtalmacen.Name = "txtalmacen";
            this.txtalmacen.PreventEnterBeep = true;
            this.txtalmacen.Size = new System.Drawing.Size(44, 20);
            this.txtalmacen.TabIndex = 2;
            this.txtalmacen.TextChanged += new System.EventHandler(this.txtalmacen_TextChanged);
            this.txtalmacen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtalmacen_KeyPress);
            // 
            // label9
            // 
            // 
            // 
            // 
            this.label9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.label9.Location = new System.Drawing.Point(24, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 23);
            this.label9.TabIndex = 64;
            this.label9.Text = "ALMACEN";
            // 
            // txtunidad
            // 
            this.txtunidad.DataSource = this.unidadBindingSource;
            this.txtunidad.DisplayMember = "nombre";
            this.txtunidad.FormattingEnabled = true;
            this.txtunidad.Location = new System.Drawing.Point(558, 277);
            this.txtunidad.Name = "txtunidad";
            this.txtunidad.Size = new System.Drawing.Size(121, 21);
            this.txtunidad.TabIndex = 6;
            this.txtunidad.ValueMember = "codigo";
            // 
            // unidadBindingSource
            // 
            this.unidadBindingSource.DataMember = "unidad";
            this.unidadBindingSource.DataSource = this.unidadDataSet;
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
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(24, 253);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 65;
            this.labelX6.Text = "CODIGO";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(168, 253);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(100, 23);
            this.labelX7.TabIndex = 66;
            this.labelX7.Text = "DESCRIPCION";
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(394, 253);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 67;
            this.labelX8.Text = "COSTO";
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(474, 253);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(75, 23);
            this.labelX9.TabIndex = 68;
            this.labelX9.Text = "CANTIDAD";
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(569, 253);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(75, 23);
            this.labelX10.TabIndex = 69;
            this.labelX10.Text = "UNIDAD";
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 568);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtunidad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.txtnomalmacen);
            this.Controls.Add(this.txtalmacen);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.canart);
            this.Controls.Add(this.preart);
            this.Controls.Add(this.desart);
            this.Controls.Add(this.codart);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.nombresuplidor);
            this.Controls.Add(this.txtsuplidor);
            this.Controls.Add(this.txtfactura);
            this.Controls.Add(this.txtregistro);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.labelX1);
            this.Name = "Compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.txtusuario, 0);
            this.Controls.SetChildIndex(this.txtregistro, 0);
            this.Controls.SetChildIndex(this.txtfactura, 0);
            this.Controls.SetChildIndex(this.txtsuplidor, 0);
            this.Controls.SetChildIndex(this.nombresuplidor, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.buttonX3, 0);
            this.Controls.SetChildIndex(this.txtmonto, 0);
            this.Controls.SetChildIndex(this.codart, 0);
            this.Controls.SetChildIndex(this.desart, 0);
            this.Controls.SetChildIndex(this.preart, 0);
            this.Controls.SetChildIndex(this.canart, 0);
            this.Controls.SetChildIndex(this.agregar, 0);
            this.Controls.SetChildIndex(this.buttonX2, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.txtalmacen, 0);
            this.Controls.SetChildIndex(this.txtnomalmacen, 0);
            this.Controls.SetChildIndex(this.buttonX4, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.txtunidad, 0);
            this.Controls.SetChildIndex(this.labelX6, 0);
            this.Controls.SetChildIndex(this.labelX7, 0);
            this.Controls.SetChildIndex(this.labelX8, 0);
            this.Controls.SetChildIndex(this.labelX9, 0);
            this.Controls.SetChildIndex(this.labelX10, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcodigo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.DateTimePicker txtregistro;
        private System.Windows.Forms.DateTimePicker txtfactura;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.TextBoxX nombresuplidor;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsuplidor;
        private System.Windows.Forms.DataGridView dataGridView1;
        public DevComponents.DotNetBar.ButtonX buttonX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtmonto;
        public DevComponents.DotNetBar.LabelX txtusuario;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.ButtonX agregar;
        private DevComponents.DotNetBar.Controls.TextBoxX canart;
        private DevComponents.DotNetBar.Controls.TextBoxX desart;
        private DevComponents.DotNetBar.Controls.TextBoxX codart;
        private DevComponents.DotNetBar.Controls.TextBoxX preart;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.LabelX label9;
        private DevComponents.DotNetBar.ButtonX buttonX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnomalmacen;
        private DevComponents.DotNetBar.Controls.TextBoxX txtalmacen;
        private System.Windows.Forms.ComboBox txtunidad;
        private unidadDataSet unidadDataSet;
        private System.Windows.Forms.BindingSource unidadBindingSource;
        private unidadDataSetTableAdapters.unidadTableAdapter unidadTableAdapter;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn al;
        private System.Windows.Forms.DataGridViewTextBoxColumn idunidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo1;
    }
}