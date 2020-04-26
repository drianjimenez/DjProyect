namespace DjProyect
{
    partial class Mostrar_Compra_Detallada
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
            this.compraDataSet = new DjProyect.compraDataSet();
            this.vista_compraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_compraTableAdapter = new DjProyect.compraDataSetTableAdapters.vista_compraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.compraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_compraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vista_compraBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DjProyect.Informe_Compra_Detallada.rdlc";
            // 
            // compraDataSet
            // 
            this.compraDataSet.DataSetName = "compraDataSet";
            this.compraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_compraBindingSource
            // 
            this.vista_compraBindingSource.DataMember = "vista_compra";
            this.vista_compraBindingSource.DataSource = this.compraDataSet;
            // 
            // vista_compraTableAdapter
            // 
            this.vista_compraTableAdapter.ClearBeforeFill = true;
            // 
            // Mostrar_Compra_Detallada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 684);
            this.Name = "Mostrar_Compra_Detallada";
            this.Text = "Mostrar_Compra_Detallada";
            this.Load += new System.EventHandler(this.Mostrar_Compra_Detallada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_compraBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vista_compraBindingSource;
        private compraDataSet compraDataSet;
        private compraDataSetTableAdapters.vista_compraTableAdapter vista_compraTableAdapter;
    }
}