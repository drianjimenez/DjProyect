namespace DjProyect
{
    partial class Mostrar_articulo
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vistaarticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaarticulo = new DjProyect.vistaarticulo();
            this.vistaarticuloTableAdapter = new DjProyect.vistaarticuloTableAdapters.vistaarticuloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vistaarticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaarticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vistaarticuloBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DjProyect.Informe_articulo.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(1029, 684);
            // 
            // vistaarticuloBindingSource
            // 
            this.vistaarticuloBindingSource.DataMember = "vistaarticulo";
            this.vistaarticuloBindingSource.DataSource = this.vistaarticulo;
            // 
            // vistaarticulo
            // 
            this.vistaarticulo.DataSetName = "vistaarticulo";
            this.vistaarticulo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaarticuloTableAdapter
            // 
            this.vistaarticuloTableAdapter.ClearBeforeFill = true;
            // 
            // Mostrar_articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 684);
            this.Name = "Mostrar_articulo";
            this.Text = "Mostrar_articulo";
            this.Load += new System.EventHandler(this.Mostrar_articulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vistaarticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaarticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vistaarticuloBindingSource;
        private vistaarticulo vistaarticulo;
        private vistaarticuloTableAdapters.vistaarticuloTableAdapter vistaarticuloTableAdapter;
    }
}