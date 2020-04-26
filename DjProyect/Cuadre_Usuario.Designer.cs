namespace DjProyect
{
    partial class Cuadre_Usuario
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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this.inicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.final = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.txtusuario = new System.Windows.Forms.ComboBox();
            this.usuarioDataSet = new DjProyect.usuarioDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new DjProyect.usuarioDataSetTableAdapters.usuarioTableAdapter();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(353, 305);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(73, 305);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(87, 36);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "58709";
            this.buttonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX1.TabIndex = 22;
            this.buttonX1.Text = "Imprimir";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "USUARIO";
            // 
            // inicial
            // 
            this.inicial.Location = new System.Drawing.Point(148, 146);
            this.inicial.Name = "inicial";
            this.inicial.Size = new System.Drawing.Size(200, 20);
            this.inicial.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "FECHA INICIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "FECHA FINAL";
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(148, 197);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(200, 20);
            this.final.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "TIPO";
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "DE CONTADO",
            "CREDITO"});
            this.tipo.Location = new System.Drawing.Point(148, 247);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(121, 21);
            this.tipo.TabIndex = 30;
            // 
            // txtusuario
            // 
            this.txtusuario.DataSource = this.usuarioBindingSource1;
            this.txtusuario.DisplayMember = "usuario";
            this.txtusuario.FormattingEnabled = true;
            this.txtusuario.Location = new System.Drawing.Point(148, 96);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(121, 21);
            this.txtusuario.TabIndex = 31;
            this.txtusuario.ValueMember = "usuario";
            // 
            // usuarioDataSet
            // 
            this.usuarioDataSet.DataSetName = "usuarioDataSet";
            this.usuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.usuarioDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "usuario";
            this.usuarioBindingSource1.DataSource = this.usuarioDataSet;
            // 
            // Cuadre_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 391);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.final);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonX1);
            this.Name = "Cuadre_Usuario";
            this.Text = "Cuadre_Usuario";
            this.Load += new System.EventHandler(this.Cuadre_Usuario_Load);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.inicial, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.final, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.tipo, 0);
            this.Controls.SetChildIndex(this.txtusuario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX buttonX1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker inicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker final;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.ComboBox txtusuario;
        private usuarioDataSet usuarioDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private usuarioDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
    }
}