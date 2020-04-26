namespace DjProyect
{
    partial class Mostrar_Articulo_Departamento
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
            this.Vista_Articulo_DepartamentoDataSet = new DjProyect.Vista_Articulo_DepartamentoDataSet();
            this.vista_articulo_departamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_articulo_departamentoTableAdapter = new DjProyect.Vista_Articulo_DepartamentoDataSetTableAdapters.vista_articulo_departamentoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Vista_Articulo_DepartamentoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_articulo_departamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vista_articulo_departamentoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DjProyect.Informe_Articulo_Departamento.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(861, 684);
            // 
            // Vista_Articulo_DepartamentoDataSet
            // 
            this.Vista_Articulo_DepartamentoDataSet.DataSetName = "Vista_Articulo_DepartamentoDataSet";
            this.Vista_Articulo_DepartamentoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_articulo_departamentoBindingSource
            // 
            this.vista_articulo_departamentoBindingSource.DataMember = "vista_articulo_departamento";
            this.vista_articulo_departamentoBindingSource.DataSource = this.Vista_Articulo_DepartamentoDataSet;
            // 
            // vista_articulo_departamentoTableAdapter
            // 
            this.vista_articulo_departamentoTableAdapter.ClearBeforeFill = true;
            // 
            // Mostrar_Articulo_Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 684);
            this.Name = "Mostrar_Articulo_Departamento";
            this.Text = "Mostrar_Articulo_Departamento";
            this.Load += new System.EventHandler(this.Mostrar_Articulo_Departamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Vista_Articulo_DepartamentoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_articulo_departamentoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vista_articulo_departamentoBindingSource;
        private Vista_Articulo_DepartamentoDataSet Vista_Articulo_DepartamentoDataSet;
        private Vista_Articulo_DepartamentoDataSetTableAdapters.vista_articulo_departamentoTableAdapter vista_articulo_departamentoTableAdapter;
    }
}