namespace DjProyect
{
    partial class Facturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.desart = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.canart = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.agregar = new DevComponents.DotNetBar.ButtonX();
            this.cliente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.codcli = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX3 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX4 = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.impo = new System.Windows.Forms.TextBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.credito = new DevComponents.DotNetBar.LabelX();
            this.RNC = new DevComponents.DotNetBar.LabelX();
            this.CONSUMIDOR_FINAL = new DevComponents.DotNetBar.LabelX();
            this.VALIDO = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.ncf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtusuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttipo = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.txtitbis = new System.Windows.Forms.TextBox();
            this.codart = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtunidad = new System.Windows.Forms.ComboBox();
            this.unidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadDataSet = new DjProyect.unidadDataSet();
            this.txtprecio = new System.Windows.Forms.ComboBox();
            this.unidadTableAdapter = new DjProyect.unidadDataSetTableAdapters.unidadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(691, 490);
            this.salir.TabIndex = 8;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.cantidad,
            this.precio,
            this.tbis,
            this.importe,
            this.unidad2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView1.Location = new System.Drawing.Point(23, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(793, 229);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewX1_RowEnter);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
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
            this.descripcion.Width = 250;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // tbis
            // 
            this.tbis.HeaderText = "Itbis";
            this.tbis.Name = "tbis";
            this.tbis.ReadOnly = true;
            this.tbis.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // unidad2
            // 
            this.unidad2.HeaderText = "unidad2";
            this.unidad2.Name = "unidad2";
            this.unidad2.ReadOnly = true;
            this.unidad2.Visible = false;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(260, 490);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(84, 36);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "57674";
            this.buttonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX1.TabIndex = 6;
            this.buttonX1.Text = "Eliminar";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
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
            this.desart.Location = new System.Drawing.Point(169, 124);
            this.desart.Name = "desart";
            this.desart.PreventEnterBeep = true;
            this.desart.Size = new System.Drawing.Size(281, 20);
            this.desart.TabIndex = 25;
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
            this.canart.Location = new System.Drawing.Point(716, 125);
            this.canart.Name = "canart";
            this.canart.PreventEnterBeep = true;
            this.canart.Size = new System.Drawing.Size(100, 20);
            this.canart.TabIndex = 3;
            this.canart.TextChanged += new System.EventHandler(this.canart_TextChanged);
            this.canart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.canart_KeyDown);
            this.canart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.canart_KeyPress);
            // 
            // agregar
            // 
            this.agregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.agregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.agregar.Location = new System.Drawing.Point(724, 92);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(84, 26);
            this.agregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.agregar.Symbol = "";
            this.agregar.TabIndex = 4;
            this.agregar.Text = "Agregar";
            this.agregar.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // cliente
            // 
            this.cliente.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cliente.Border.Class = "TextBoxBorder";
            this.cliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cliente.DisabledBackColor = System.Drawing.Color.White;
            this.cliente.Enabled = false;
            this.cliente.ForeColor = System.Drawing.Color.Black;
            this.cliente.Location = new System.Drawing.Point(171, 19);
            this.cliente.Name = "cliente";
            this.cliente.PreventEnterBeep = true;
            this.cliente.Size = new System.Drawing.Size(281, 20);
            this.cliente.TabIndex = 30;
            // 
            // codcli
            // 
            this.codcli.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.codcli.Border.Class = "TextBoxBorder";
            this.codcli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.codcli.DisabledBackColor = System.Drawing.Color.White;
            this.codcli.Enabled = false;
            this.codcli.ForeColor = System.Drawing.Color.Black;
            this.codcli.Location = new System.Drawing.Point(104, 19);
            this.codcli.Name = "codcli";
            this.codcli.PreventEnterBeep = true;
            this.codcli.Size = new System.Drawing.Size(61, 20);
            this.codcli.TabIndex = 9;
            this.codcli.TextChanged += new System.EventHandler(this.codcli_TextChanged);
            // 
            // buttonX3
            // 
            this.buttonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX3.Location = new System.Drawing.Point(444, 19);
            this.buttonX3.Name = "buttonX3";
            this.buttonX3.Size = new System.Drawing.Size(84, 26);
            this.buttonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX3.Symbol = "";
            this.buttonX3.TabIndex = 10;
            this.buttonX3.Text = "Cliente";
            this.buttonX3.Click += new System.EventHandler(this.buttonX3_Click);
            // 
            // buttonX4
            // 
            this.buttonX4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX4.Location = new System.Drawing.Point(39, 490);
            this.buttonX4.Name = "buttonX4";
            this.buttonX4.Size = new System.Drawing.Size(84, 36);
            this.buttonX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX4.Symbol = "";
            this.buttonX4.TabIndex = 5;
            this.buttonX4.Text = "Facturar";
            this.buttonX4.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // impo
            // 
            this.impo.Enabled = false;
            this.impo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impo.Location = new System.Drawing.Point(669, 421);
            this.impo.Multiline = true;
            this.impo.Name = "impo";
            this.impo.Size = new System.Drawing.Size(150, 37);
            this.impo.TabIndex = 33;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Red;
            this.labelX1.Location = new System.Drawing.Point(563, 421);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 37);
            this.labelX1.TabIndex = 34;
            this.labelX1.Text = "TOTAL";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(129, 124);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(34, 26);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.TabIndex = 35;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click_1);
            // 
            // credito
            // 
            // 
            // 
            // 
            this.credito.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.credito.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credito.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.credito.Location = new System.Drawing.Point(534, 15);
            this.credito.Name = "credito";
            this.credito.Size = new System.Drawing.Size(153, 99);
            this.credito.TabIndex = 36;
            this.credito.Text = "FACTURA\r\nA CREDITO";
            this.credito.Visible = false;
            // 
            // RNC
            // 
            // 
            // 
            // 
            this.RNC.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RNC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RNC.Location = new System.Drawing.Point(23, 395);
            this.RNC.Name = "RNC";
            this.RNC.Size = new System.Drawing.Size(348, 23);
            this.RNC.TabIndex = 37;
            this.RNC.Text = "CEDULA";
            this.RNC.Visible = false;
            // 
            // CONSUMIDOR_FINAL
            // 
            // 
            // 
            // 
            this.CONSUMIDOR_FINAL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.CONSUMIDOR_FINAL.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONSUMIDOR_FINAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CONSUMIDOR_FINAL.Location = new System.Drawing.Point(23, 418);
            this.CONSUMIDOR_FINAL.Name = "CONSUMIDOR_FINAL";
            this.CONSUMIDOR_FINAL.Size = new System.Drawing.Size(348, 23);
            this.CONSUMIDOR_FINAL.TabIndex = 38;
            this.CONSUMIDOR_FINAL.Visible = false;
            // 
            // VALIDO
            // 
            // 
            // 
            // 
            this.VALIDO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.VALIDO.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VALIDO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.VALIDO.Location = new System.Drawing.Point(23, 447);
            this.VALIDO.Name = "VALIDO";
            this.VALIDO.Size = new System.Drawing.Size(348, 23);
            this.VALIDO.TabIndex = 39;
            this.VALIDO.Text = "VALIDO";
            this.VALIDO.Visible = false;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Red;
            this.labelX3.Location = new System.Drawing.Point(563, 396);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(91, 23);
            this.labelX3.TabIndex = 40;
            this.labelX3.Text = "TOTAL ITBIS";
            // 
            // ncf
            // 
            this.ncf.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.ncf.Border.Class = "TextBoxBorder";
            this.ncf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ncf.DisabledBackColor = System.Drawing.Color.White;
            this.ncf.Enabled = false;
            this.ncf.ForeColor = System.Drawing.Color.Black;
            this.ncf.Location = new System.Drawing.Point(104, 57);
            this.ncf.Name = "ncf";
            this.ncf.PreventEnterBeep = true;
            this.ncf.Size = new System.Drawing.Size(143, 20);
            this.ncf.TabIndex = 43;
            this.ncf.Visible = false;
            this.ncf.TextChanged += new System.EventHandler(this.ncf_TextChanged);
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
            this.txtusuario.ForeColor = System.Drawing.Color.Black;
            this.txtusuario.Location = new System.Drawing.Point(352, 409);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PreventEnterBeep = true;
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 44;
            this.txtusuario.Visible = false;
            // 
            // txttipo
            // 
            // 
            // 
            // 
            this.txttipo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttipo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txttipo.Location = new System.Drawing.Point(23, 95);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(67, 23);
            this.txttipo.TabIndex = 45;
            this.txttipo.Text = "02";
            this.txttipo.Visible = false;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(23, 19);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 46;
            this.labelX5.Text = "Cliente";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(23, 54);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 47;
            this.labelX6.Text = "NCF";
            this.labelX6.Visible = false;
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX5.Location = new System.Drawing.Point(465, 490);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(84, 36);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.Symbol = "";
            this.buttonX5.TabIndex = 7;
            this.buttonX5.Text = "Cancelar";
            this.buttonX5.Click += new System.EventHandler(this.buttonX5_Click);
            // 
            // txtitbis
            // 
            this.txtitbis.Enabled = false;
            this.txtitbis.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitbis.ForeColor = System.Drawing.Color.Black;
            this.txtitbis.Location = new System.Drawing.Point(669, 391);
            this.txtitbis.Multiline = true;
            this.txtitbis.Name = "txtitbis";
            this.txtitbis.Size = new System.Drawing.Size(150, 23);
            this.txtitbis.TabIndex = 49;
            // 
            // codart
            // 
            this.codart.AccessibleDescription = "";
            this.codart.AccessibleName = "";
            this.codart.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.codart.Border.Class = "TextBoxBorder";
            this.codart.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.codart.DisabledBackColor = System.Drawing.Color.White;
            this.codart.ForeColor = System.Drawing.Color.Black;
            this.codart.Location = new System.Drawing.Point(23, 124);
            this.codart.Name = "codart";
            this.codart.PreventEnterBeep = true;
            this.codart.Size = new System.Drawing.Size(100, 20);
            this.codart.TabIndex = 0;
            this.codart.TextChanged += new System.EventHandler(this.art_TextChanged);
            this.codart.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codart_KeyDown);
            // 
            // txtunidad
            // 
            this.txtunidad.DataSource = this.unidadBindingSource;
            this.txtunidad.DisplayMember = "nombre";
            this.txtunidad.FormattingEnabled = true;
            this.txtunidad.Location = new System.Drawing.Point(465, 124);
            this.txtunidad.Name = "txtunidad";
            this.txtunidad.Size = new System.Drawing.Size(121, 21);
            this.txtunidad.TabIndex = 1;
            this.txtunidad.ValueMember = "codigo";
            this.txtunidad.SelectedIndexChanged += new System.EventHandler(this.txtunidad_SelectedIndexChanged);
            this.txtunidad.Click += new System.EventHandler(this.txtunidad_Click);
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
            // txtprecio
            // 
            this.txtprecio.FormattingEnabled = true;
            this.txtprecio.Location = new System.Drawing.Point(591, 124);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(121, 21);
            this.txtprecio.TabIndex = 2;
            // 
            // unidadTableAdapter
            // 
            this.unidadTableAdapter.ClearBeforeFill = true;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 550);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtunidad);
            this.Controls.Add(this.txtitbis);
            this.Controls.Add(this.buttonX5);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txttipo);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.ncf);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.VALIDO);
            this.Controls.Add(this.CONSUMIDOR_FINAL);
            this.Controls.Add(this.RNC);
            this.Controls.Add(this.credito);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.impo);
            this.Controls.Add(this.buttonX4);
            this.Controls.Add(this.buttonX3);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.codcli);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.canart);
            this.Controls.Add(this.desart);
            this.Controls.Add(this.codart);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.dataGridView1);
            this.KeyPreview = true;
            this.Name = "Facturacion";
            this.Text = "";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Facturacion_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Facturacion_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Facturacion_KeyUp);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.codart, 0);
            this.Controls.SetChildIndex(this.desart, 0);
            this.Controls.SetChildIndex(this.canart, 0);
            this.Controls.SetChildIndex(this.agregar, 0);
            this.Controls.SetChildIndex(this.codcli, 0);
            this.Controls.SetChildIndex(this.cliente, 0);
            this.Controls.SetChildIndex(this.buttonX3, 0);
            this.Controls.SetChildIndex(this.buttonX4, 0);
            this.Controls.SetChildIndex(this.impo, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.buttonX2, 0);
            this.Controls.SetChildIndex(this.credito, 0);
            this.Controls.SetChildIndex(this.RNC, 0);
            this.Controls.SetChildIndex(this.CONSUMIDOR_FINAL, 0);
            this.Controls.SetChildIndex(this.VALIDO, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.ncf, 0);
            this.Controls.SetChildIndex(this.txtusuario, 0);
            this.Controls.SetChildIndex(this.txttipo, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.labelX6, 0);
            this.Controls.SetChildIndex(this.buttonX5, 0);
            this.Controls.SetChildIndex(this.txtitbis, 0);
            this.Controls.SetChildIndex(this.txtunidad, 0);
            this.Controls.SetChildIndex(this.txtprecio, 0);
            this.Controls.SetChildIndex(this.salir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView1;
        private DevComponents.DotNetBar.Controls.TextBoxX desart;
        private DevComponents.DotNetBar.Controls.TextBoxX canart;
        private DevComponents.DotNetBar.ButtonX agregar;
        private DevComponents.DotNetBar.Controls.TextBoxX cliente;
        private DevComponents.DotNetBar.Controls.TextBoxX codcli;
        private DevComponents.DotNetBar.ButtonX buttonX3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX credito;
        public System.Windows.Forms.TextBox impo;
        public DevComponents.DotNetBar.ButtonX buttonX1;
        public DevComponents.DotNetBar.ButtonX buttonX4;
        public DevComponents.DotNetBar.LabelX VALIDO;
        public DevComponents.DotNetBar.LabelX CONSUMIDOR_FINAL;
        public DevComponents.DotNetBar.LabelX RNC;
        private DevComponents.DotNetBar.Controls.TextBoxX ncf;
        public DevComponents.DotNetBar.LabelX labelX3;
        public DevComponents.DotNetBar.LabelX txttipo;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        public DevComponents.DotNetBar.ButtonX buttonX5;
        public System.Windows.Forms.TextBox txtitbis;
        public DevComponents.DotNetBar.Controls.TextBoxX txtusuario;
        private DevComponents.DotNetBar.Controls.TextBoxX codart;
        private System.Windows.Forms.ComboBox txtunidad;
        private System.Windows.Forms.ComboBox txtprecio;
        private System.Windows.Forms.BindingSource unidadDataSetBindingSource;
        private unidadDataSet unidadDataSet;
        private System.Windows.Forms.BindingSource unidadBindingSource;
        private unidadDataSetTableAdapters.unidadTableAdapter unidadTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad2;
    }
}