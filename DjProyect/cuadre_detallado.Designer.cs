namespace DjProyect
{
    partial class cuadre_detallado
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
            this.txtusuario = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioDataSet = new DjProyect.usuarioDataSet();
            this.final = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inicial = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.usuarioTableAdapter = new DjProyect.usuarioDataSetTableAdapters.usuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(59, 234);
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(360, 234);
            // 
            // txtusuario
            // 
            this.txtusuario.DataSource = this.usuarioBindingSource;
            this.txtusuario.DisplayMember = "usuario";
            this.txtusuario.FormattingEnabled = true;
            this.txtusuario.Location = new System.Drawing.Point(144, 73);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(121, 21);
            this.txtusuario.TabIndex = 39;
            this.txtusuario.ValueMember = "usuario";
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
            // final
            // 
            this.final.Location = new System.Drawing.Point(144, 174);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(200, 20);
            this.final.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "FECHA FINAL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "FECHA INICIAL";
            // 
            // inicial
            // 
            this.inicial.Location = new System.Drawing.Point(144, 123);
            this.inicial.Name = "inicial";
            this.inicial.Size = new System.Drawing.Size(200, 20);
            this.inicial.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "USUARIO";
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // cuadre_detallado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 305);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.final);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inicial);
            this.Controls.Add(this.label4);
            this.Name = "cuadre_detallado";
            this.Text = "cuadre_detallado";
            this.Load += new System.EventHandler(this.cuadre_detallado_Load);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.inicial, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.final, 0);
            this.Controls.SetChildIndex(this.txtusuario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtusuario;
        private System.Windows.Forms.DateTimePicker final;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker inicial;
        private System.Windows.Forms.Label label4;
        private usuarioDataSet usuarioDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private usuarioDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
    }
}