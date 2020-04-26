namespace DjProyect
{
    partial class Mostrar_factura_Resumida
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
            this.factura_sin_detalleDataSet = new DjProyect.factura_sin_detalleDataSet();
            this.vista_facturasindetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_facturasindetalleTableAdapter = new DjProyect.factura_sin_detalleDataSetTableAdapters.vista_facturasindetalleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.factura_sin_detalleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_facturasindetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vista_facturasindetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DjProyect.Informe_Factura_Resumen.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(1074, 684);
            // 
            // factura_sin_detalleDataSet
            // 
            this.factura_sin_detalleDataSet.DataSetName = "factura_sin_detalleDataSet";
            this.factura_sin_detalleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_facturasindetalleBindingSource
            // 
            this.vista_facturasindetalleBindingSource.DataMember = "vista_facturasindetalle";
            this.vista_facturasindetalleBindingSource.DataSource = this.factura_sin_detalleDataSet;
            // 
            // vista_facturasindetalleTableAdapter
            // 
            this.vista_facturasindetalleTableAdapter.ClearBeforeFill = true;
            // 
            // Mostrar_factura_Resumida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 684);
            this.Name = "Mostrar_factura_Resumida";
            this.Text = "Mostrar_factura_Resumida";
            this.Load += new System.EventHandler(this.Mostrar_factura_Resumida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.factura_sin_detalleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_facturasindetalleBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vista_facturasindetalleBindingSource;
        private factura_sin_detalleDataSet factura_sin_detalleDataSet;
        private factura_sin_detalleDataSetTableAdapters.vista_facturasindetalleTableAdapter vista_facturasindetalleTableAdapter;


    }
}