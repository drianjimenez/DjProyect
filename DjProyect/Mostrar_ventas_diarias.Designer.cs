namespace DjProyect
{
    partial class Mostrar_ventas_diarias
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ventas_diariasDataSet = new DjProyect.ventas_diariasDataSet();
            this.reporteventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteventasTableAdapter = new DjProyect.ventas_diariasDataSetTableAdapters.reporteventasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventas_diariasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteventasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.reporteventasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DjProyect.Informe_ventas_diadias.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(924, 684);
            // 
            // ventas_diariasDataSet
            // 
            this.ventas_diariasDataSet.DataSetName = "ventas_diariasDataSet";
            this.ventas_diariasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteventasBindingSource
            // 
            this.reporteventasBindingSource.DataMember = "reporteventas";
            this.reporteventasBindingSource.DataSource = this.ventas_diariasDataSet;
            // 
            // reporteventasTableAdapter
            // 
            this.reporteventasTableAdapter.ClearBeforeFill = true;
            // 
            // Mostrar_ventas_diarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 684);
            this.Name = "Mostrar_ventas_diarias";
            this.Text = "Mostrar_ventas_diarias";
            this.Load += new System.EventHandler(this.Mostrar_ventas_diarias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventas_diariasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteventasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource reporteventasBindingSource;
        private ventas_diariasDataSet ventas_diariasDataSet;
        private ventas_diariasDataSetTableAdapters.reporteventasTableAdapter reporteventasTableAdapter;
    }
}