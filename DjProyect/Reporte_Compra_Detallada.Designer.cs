namespace DjProyect
{
    partial class Reporte_Compra_Detallada
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.nombresuplidor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtsuplidor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioDataSet = new DjProyect.usuarioDataSet();
            this.usuarioTableAdapter = new DjProyect.usuarioDataSetTableAdapters.usuarioTableAdapter();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(86, 265);
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(416, 265);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(50, 85);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(64, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Suplidor";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 141);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(50, 138);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 25;
            this.labelX2.Text = "Fecha Desde";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(50, 224);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 26;
            this.labelX3.Text = "Usuario";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(181, 85);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(27, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolColor = System.Drawing.Color.Black;
            this.buttonX2.SymbolSize = 15F;
            this.buttonX2.TabIndex = 51;
            this.buttonX2.Text = " ";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
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
            this.nombresuplidor.Location = new System.Drawing.Point(214, 88);
            this.nombresuplidor.Name = "nombresuplidor";
            this.nombresuplidor.PreventEnterBeep = true;
            this.nombresuplidor.Size = new System.Drawing.Size(298, 20);
            this.nombresuplidor.TabIndex = 50;
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
            this.txtsuplidor.Location = new System.Drawing.Point(131, 88);
            this.txtsuplidor.Name = "txtsuplidor";
            this.txtsuplidor.PreventEnterBeep = true;
            this.txtsuplidor.Size = new System.Drawing.Size(44, 20);
            this.txtsuplidor.TabIndex = 49;
            this.txtsuplidor.TextChanged += new System.EventHandler(this.txtsuplidor_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.usuarioBindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(131, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.ValueMember = "usuario";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.usuarioDataSet;
            // 
            // usuarioDataSet
            // 
            this.usuarioDataSet.DataSetName = "usuarioDataSet";
            this.usuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(50, 179);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 54;
            this.labelX4.Text = "Fecha Hasta";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(131, 182);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 53;
            // 
            // Reporte_Compra_Detallada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 324);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.nombresuplidor);
            this.Controls.Add(this.txtsuplidor);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Reporte_Compra_Detallada";
            this.Text = "Reporte_Compra_Detallada";
            this.Load += new System.EventHandler(this.Reporte_Compra_Detallada_Load);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.txtsuplidor, 0);
            this.Controls.SetChildIndex(this.nombresuplidor, 0);
            this.Controls.SetChildIndex(this.buttonX2, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.Controls.TextBoxX nombresuplidor;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsuplidor;
        private System.Windows.Forms.ComboBox comboBox1;
        private usuarioDataSet usuarioDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private usuarioDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}