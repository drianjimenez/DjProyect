namespace DjProyect
{
    partial class Mostrar_estado_cuenta
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
            this.vista_estado_cuentaDataSet = new DjProyect.vista_estado_cuentaDataSet();
            this.vista_estado_cuentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_estado_cuentaTableAdapter = new DjProyect.vista_estado_cuentaDataSetTableAdapters.vista_estado_cuentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vista_estado_cuentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_estado_cuentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.vista_estado_cuentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DjProyect.Informe_estado_cuenta.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(919, 684);
            // 
            // vista_estado_cuentaDataSet
            // 
            this.vista_estado_cuentaDataSet.DataSetName = "vista_estado_cuentaDataSet";
            this.vista_estado_cuentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_estado_cuentaBindingSource
            // 
            this.vista_estado_cuentaBindingSource.DataMember = "vista_estado_cuenta";
            this.vista_estado_cuentaBindingSource.DataSource = this.vista_estado_cuentaDataSet;
            // 
            // vista_estado_cuentaTableAdapter
            // 
            this.vista_estado_cuentaTableAdapter.ClearBeforeFill = true;
            // 
            // Mostrar_estado_cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 684);
            this.Name = "Mostrar_estado_cuenta";
            this.Text = "Mostrar_estado_cuenta";
            this.Load += new System.EventHandler(this.Mostrar_estado_cuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vista_estado_cuentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_estado_cuentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vista_estado_cuentaBindingSource;
        private vista_estado_cuentaDataSet vista_estado_cuentaDataSet;
        private vista_estado_cuentaDataSetTableAdapters.vista_estado_cuentaTableAdapter vista_estado_cuentaTableAdapter;
    }
}