namespace DjProyect
{
    partial class Mostrar_cxp_sinpagar
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
            this.cxp_facturasinpagarDataSet = new DjProyect.cxp_facturasinpagarDataSet();
            this.vista_cxp_sinpagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_cxp_sinpagarTableAdapter = new DjProyect.cxp_facturasinpagarDataSetTableAdapters.vista_cxp_sinpagarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cxp_facturasinpagarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_cxp_sinpagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vista_cxp_sinpagarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DjProyect.informe_cxp_sinpagar.rdlc";
            // 
            // cxp_facturasinpagarDataSet
            // 
            this.cxp_facturasinpagarDataSet.DataSetName = "cxp_facturasinpagarDataSet";
            this.cxp_facturasinpagarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_cxp_sinpagarBindingSource
            // 
            this.vista_cxp_sinpagarBindingSource.DataMember = "vista_cxp_sinpagar";
            this.vista_cxp_sinpagarBindingSource.DataSource = this.cxp_facturasinpagarDataSet;
            // 
            // vista_cxp_sinpagarTableAdapter
            // 
            this.vista_cxp_sinpagarTableAdapter.ClearBeforeFill = true;
            // 
            // Mostrar_cxp_sinpagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 684);
            this.Name = "Mostrar_cxp_sinpagar";
            this.Text = "Mostrar_cxp_sinpagar";
            this.Load += new System.EventHandler(this.Mostrar_cxp_sinpagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cxp_facturasinpagarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_cxp_sinpagarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vista_cxp_sinpagarBindingSource;
        private cxp_facturasinpagarDataSet cxp_facturasinpagarDataSet;
        private cxp_facturasinpagarDataSetTableAdapters.vista_cxp_sinpagarTableAdapter vista_cxp_sinpagarTableAdapter;
    }
}