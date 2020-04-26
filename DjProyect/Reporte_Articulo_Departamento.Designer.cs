namespace DjProyect
{
    partial class Reporte_Articulo_Departamento
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.departamentoDataSet = new DjProyect.departamentoDataSet();
            this.departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentoTableAdapter = new DjProyect.departamentoDataSetTableAdapters.departamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(58, 162);
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(388, 162);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(138, 101);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 23;
            this.labelX1.Text = "Departamento";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.departamentoBindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(219, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.ValueMember = "codigo";
            // 
            // departamentoDataSet
            // 
            this.departamentoDataSet.DataSetName = "departamentoDataSet";
            this.departamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentoBindingSource
            // 
            this.departamentoBindingSource.DataMember = "departamento";
            this.departamentoBindingSource.DataSource = this.departamentoDataSet;
            // 
            // departamentoTableAdapter
            // 
            this.departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Articulo_Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 240);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelX1);
            this.Name = "Reporte_Articulo_Departamento";
            this.Text = "Reporte_Articulo_Departamento";
            this.Load += new System.EventHandler(this.Reporte_Articulo_Departamento_Load);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.departamentoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox comboBox1;
        private departamentoDataSet departamentoDataSet;
        private System.Windows.Forms.BindingSource departamentoBindingSource;
        private departamentoDataSetTableAdapters.departamentoTableAdapter departamentoTableAdapter;
    }
}