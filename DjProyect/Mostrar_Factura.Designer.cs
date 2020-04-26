namespace DjProyect
{
    partial class Mostrar_Factura
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
            this.vista_facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_factura_DataSet = new DjProyect.vista_factura_DataSet();
            this.vista_facturaTableAdapter = new DjProyect.vista_factura_DataSetTableAdapters.vista_facturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vista_facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_factura_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vista_facturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DjProyect.Reporte_factura.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(943, 588);
            // 
            // vista_facturaBindingSource
            // 
            this.vista_facturaBindingSource.DataMember = "vista_factura";
            this.vista_facturaBindingSource.DataSource = this.vista_factura_DataSet;
            // 
            // vista_factura_DataSet
            // 
            this.vista_factura_DataSet.DataSetName = "vista_factura_DataSet";
            this.vista_factura_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_facturaTableAdapter
            // 
            this.vista_facturaTableAdapter.ClearBeforeFill = true;
            // 
            // Mostrar_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 588);
            this.Name = "Mostrar_Factura";
            this.Text = "Mostrar_Factura";
            this.Load += new System.EventHandler(this.Mostrar_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vista_facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_factura_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vista_facturaBindingSource;
        private vista_factura_DataSet vista_factura_DataSet;
        private vista_factura_DataSetTableAdapters.vista_facturaTableAdapter vista_facturaTableAdapter;
    }
}