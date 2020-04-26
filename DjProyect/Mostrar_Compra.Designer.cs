namespace DjProyect
{
    partial class Mostrar_Compra
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
            this.vista_compra_detalladaDataSet = new DjProyect.vista_compra_detalladaDataSet();
            this.vista_compra_detalladaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_compra_detalladaTableAdapter = new DjProyect.vista_compra_detalladaDataSetTableAdapters.vista_compra_detalladaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vista_compra_detalladaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_compra_detalladaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vista_compra_detalladaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DjProyect.informe_compra.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(965, 684);
            // 
            // vista_compra_detalladaDataSet
            // 
            this.vista_compra_detalladaDataSet.DataSetName = "vista_compra_detalladaDataSet";
            this.vista_compra_detalladaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_compra_detalladaBindingSource
            // 
            this.vista_compra_detalladaBindingSource.DataMember = "vista_compra_detallada";
            this.vista_compra_detalladaBindingSource.DataSource = this.vista_compra_detalladaDataSet;
            // 
            // vista_compra_detalladaTableAdapter
            // 
            this.vista_compra_detalladaTableAdapter.ClearBeforeFill = true;
            // 
            // Mostrar_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 684);
            this.Name = "Mostrar_Compra";
            this.Text = "Mostrar_Compra";
            this.Load += new System.EventHandler(this.Mostrar_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vista_compra_detalladaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_compra_detalladaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vista_compra_detalladaBindingSource;
        private vista_compra_detalladaDataSet vista_compra_detalladaDataSet;
        private vista_compra_detalladaDataSetTableAdapters.vista_compra_detalladaTableAdapter vista_compra_detalladaTableAdapter;

    }
}