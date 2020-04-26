namespace DjProyect
{
    partial class Mostrar_Cuadre_Usuario
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
            this.cuadre_usuarioDataSet = new DjProyect.cuadre_usuarioDataSet();
            this.reporteusuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteusuarioTableAdapter = new DjProyect.cuadre_usuarioDataSetTableAdapters.reporteusuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cuadre_usuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteusuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteusuarioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DjProyect.informe_cuadre_usuario.rdlc";
            // 
            // cuadre_usuarioDataSet
            // 
            this.cuadre_usuarioDataSet.DataSetName = "cuadre_usuarioDataSet";
            this.cuadre_usuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteusuarioBindingSource
            // 
            this.reporteusuarioBindingSource.DataMember = "reporteusuario";
            this.reporteusuarioBindingSource.DataSource = this.cuadre_usuarioDataSet;
            // 
            // reporteusuarioTableAdapter
            // 
            this.reporteusuarioTableAdapter.ClearBeforeFill = true;
            // 
            // Mostrar_Cuadre_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 684);
            this.Name = "Mostrar_Cuadre_Usuario";
            this.Text = "Mostrar_Cuadre_Usuario";
            this.Load += new System.EventHandler(this.Mostrar_Cuadre_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuadre_usuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteusuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource reporteusuarioBindingSource;
        private cuadre_usuarioDataSet cuadre_usuarioDataSet;
        private cuadre_usuarioDataSetTableAdapters.reporteusuarioTableAdapter reporteusuarioTableAdapter;
    }
}