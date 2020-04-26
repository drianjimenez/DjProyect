namespace DjProyect
{
    partial class Mantenimiento_Articulo
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
            this.txtcodigo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescripcion = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.txtreorden = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsuplidor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtnomsuplidor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtdepartamento = new MetroFramework.Controls.MetroComboBox();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoDataSet = new DjProyect.departamentoDataSet();
            this.departamentoTableAdapter = new DjProyect.departamentoDataSetTableAdapters.departamentoTableAdapter();
            this.unidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidadDataSet = new DjProyect.unidadDataSet();
            this.unidadTableAdapter = new DjProyect.unidadDataSetTableAdapters.unidadTableAdapter();
            this.itbisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itbisDataSet = new DjProyect.itbisDataSet();
            this.itbisTableAdapter = new DjProyect.itbisDataSetTableAdapters.itbisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itbisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itbisDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(292, 399);
            this.button4.TabIndex = 8;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 399);
            this.button3.TabIndex = 7;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 399);
            this.button2.TabIndex = 6;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(419, 399);
            this.salir.TabIndex = 9;
            this.salir.Click += new System.EventHandler(this.salir_Click);
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
            this.txtcodigo.Location = new System.Drawing.Point(116, 96);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PreventEnterBeep = true;
            this.txtcodigo.Size = new System.Drawing.Size(141, 20);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "CODIGO";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtdescripcion.Border.Class = "TextBoxBorder";
            this.txtdescripcion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdescripcion.DisabledBackColor = System.Drawing.Color.White;
            this.txtdescripcion.ForeColor = System.Drawing.Color.Black;
            this.txtdescripcion.Location = new System.Drawing.Point(116, 142);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.PreventEnterBeep = true;
            this.txtdescripcion.Size = new System.Drawing.Size(276, 20);
            this.txtdescripcion.TabIndex = 1;
            this.txtdescripcion.TextChanged += new System.EventHandler(this.txtdescripcion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "DESCRIPCION";
            // 
            // txtreorden
            // 
            this.txtreorden.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtreorden.Border.Class = "TextBoxBorder";
            this.txtreorden.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtreorden.DisabledBackColor = System.Drawing.Color.White;
            this.txtreorden.ForeColor = System.Drawing.Color.Black;
            this.txtreorden.Location = new System.Drawing.Point(116, 248);
            this.txtreorden.Name = "txtreorden";
            this.txtreorden.PreventEnterBeep = true;
            this.txtreorden.Size = new System.Drawing.Size(141, 20);
            this.txtreorden.TabIndex = 3;
            this.txtreorden.TextChanged += new System.EventHandler(this.txtreorden_TextChanged);
            this.txtreorden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtreorden_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "FECHA \r\nINGRESO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 26);
            this.label5.TabIndex = 33;
            this.label5.Text = "PUNTO \r\nREORDEN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "DEPARTAMENTO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "SUPLIDOR";
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
            this.txtsuplidor.Location = new System.Drawing.Point(116, 194);
            this.txtsuplidor.Name = "txtsuplidor";
            this.txtsuplidor.PreventEnterBeep = true;
            this.txtsuplidor.Size = new System.Drawing.Size(44, 20);
            this.txtsuplidor.TabIndex = 2;
            this.txtsuplidor.TextChanged += new System.EventHandler(this.txtsuplidor_TextChanged);
            this.txtsuplidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsuplidor_KeyPress);
            // 
            // txtnomsuplidor
            // 
            this.txtnomsuplidor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtnomsuplidor.Border.Class = "TextBoxBorder";
            this.txtnomsuplidor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnomsuplidor.DisabledBackColor = System.Drawing.Color.White;
            this.txtnomsuplidor.ForeColor = System.Drawing.Color.Black;
            this.txtnomsuplidor.Location = new System.Drawing.Point(199, 194);
            this.txtnomsuplidor.Name = "txtnomsuplidor";
            this.txtnomsuplidor.PreventEnterBeep = true;
            this.txtnomsuplidor.Size = new System.Drawing.Size(193, 20);
            this.txtnomsuplidor.TabIndex = 44;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(166, 191);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(27, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.SymbolColor = System.Drawing.Color.Black;
            this.buttonX1.SymbolSize = 15F;
            this.buttonX1.TabIndex = 45;
            this.buttonX1.Text = " ";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // txtfecha
            // 
            this.txtfecha.Enabled = false;
            this.txtfecha.Location = new System.Drawing.Point(116, 307);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(200, 20);
            this.txtfecha.TabIndex = 4;
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.DataSource = this.departamentoBindingSource;
            this.txtdepartamento.DisplayMember = "nombre";
            this.txtdepartamento.FormattingEnabled = true;
            this.txtdepartamento.ItemHeight = 23;
            this.txtdepartamento.Location = new System.Drawing.Point(139, 344);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(181, 29);
            this.txtdepartamento.TabIndex = 5;
            this.txtdepartamento.ValueMember = "codigo";
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "departamento";
            this.departamentoBindingSource.DataSource = this.departamentoDataSet;
            // 
            // departamentoDataSet
            // 
            this.departamentoDataSet.DataSetName = "departamentoDataSet";
            this.departamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
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
            // itbisBindingSource
            // 
            this.itbisBindingSource.DataMember = "itbis";
            this.itbisBindingSource.DataSource = this.itbisDataSet;
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
            // Mantenimiento_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 464);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdepartamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txtreorden);
            this.Controls.Add(this.txtnomsuplidor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsuplidor);
            this.Name = "Mantenimiento_Articulo";
            this.Text = "Mantenimiento Articulo";
            this.Load += new System.EventHandler(this.Mantenimiento_Articulo_Load);
            this.Controls.SetChildIndex(this.txtsuplidor, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txtfecha, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtnomsuplidor, 0);
            this.Controls.SetChildIndex(this.txtreorden, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.txtdescripcion, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtdepartamento, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itbisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itbisDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtcodigo;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdescripcion;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtreorden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsuplidor;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnomsuplidor;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private MetroFramework.Controls.MetroComboBox txtdepartamento;
        private departamentoDataSet departamentoDataSet;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private departamentoDataSetTableAdapters.departamentoTableAdapter departamentoTableAdapter;
        private unidadDataSet unidadDataSet;
        private System.Windows.Forms.BindingSource unidadBindingSource;
        private unidadDataSetTableAdapters.unidadTableAdapter unidadTableAdapter;
        private itbisDataSet itbisDataSet;
        private System.Windows.Forms.BindingSource itbisBindingSource;
        private itbisDataSetTableAdapters.itbisTableAdapter itbisTableAdapter;
    }
}