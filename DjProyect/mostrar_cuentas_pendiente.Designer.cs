namespace DjProyect
{
    partial class mostrar_cuentas_pendiente
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
            this.vista_cobros_porcobrarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobros_porcobrarDataSet = new DjProyect.cobros_porcobrarDataSet();
            this.vista_cobros_porcobrarTableAdapter = new DjProyect.cobros_porcobrarDataSetTableAdapters.vista_cobros_porcobrarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vista_cobros_porcobrarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobros_porcobrarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vista_cobros_porcobrarBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DjProyect.Informe_cuentaspendiente.rdlc";
            this.reportViewer1.Size = new System.Drawing.Size(991, 684);
            // 
            // vista_cobros_porcobrarBindingSource
            // 
            this.vista_cobros_porcobrarBindingSource.DataMember = "vista_cobros_porcobrar";
            this.vista_cobros_porcobrarBindingSource.DataSource = this.cobros_porcobrarDataSet;
            // 
            // cobros_porcobrarDataSet
            // 
            this.cobros_porcobrarDataSet.DataSetName = "cobros_porcobrarDataSet";
            this.cobros_porcobrarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_cobros_porcobrarTableAdapter
            // 
            this.vista_cobros_porcobrarTableAdapter.ClearBeforeFill = true;
            // 
            // mostrar_cuentas_pendiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 684);
            this.Name = "mostrar_cuentas_pendiente";
            this.Text = "mostrar_cuentas_pendiente";
            this.Load += new System.EventHandler(this.mostrar_cuentas_pendiente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vista_cobros_porcobrarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobros_porcobrarDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource vista_cobros_porcobrarBindingSource;
        private cobros_porcobrarDataSet cobros_porcobrarDataSet;
        private cobros_porcobrarDataSetTableAdapters.vista_cobros_porcobrarTableAdapter vista_cobros_porcobrarTableAdapter;
    }
}