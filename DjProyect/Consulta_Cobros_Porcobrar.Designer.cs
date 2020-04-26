namespace DjProyect
{
    partial class Consulta_Cobros_Porcobrar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoreciboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montooriginalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montopendienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistacobrosporcobrarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cobros_porcobrarDataSet = new DjProyect.cobros_porcobrarDataSet();
            this.vista_cobros_porcobrarTableAdapter = new DjProyect.cobros_porcobrarDataSetTableAdapters.vista_cobros_porcobrarTableAdapter();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistacobrosporcobrarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobros_porcobrarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo
            // 
            // 
            // 
            // 
            this.codigo.Border.Class = "TextBoxBorder";
            this.codigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(73, 265);
            this.buttonX1.Size = new System.Drawing.Size(115, 36);
            this.buttonX1.Symbol = "";
            this.buttonX1.Text = "Realizar Cobro";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(506, 265);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.codigoreciboDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.montooriginalDataGridViewTextBoxColumn,
            this.montopendienteDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.rncDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.vistacobrosporcobrarBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView.Location = new System.Drawing.Point(23, 89);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(650, 150);
            this.dataGridView.TabIndex = 24;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoreciboDataGridViewTextBoxColumn
            // 
            this.codigoreciboDataGridViewTextBoxColumn.DataPropertyName = "codigo_recibo";
            this.codigoreciboDataGridViewTextBoxColumn.HeaderText = "Recibo #";
            this.codigoreciboDataGridViewTextBoxColumn.Name = "codigoreciboDataGridViewTextBoxColumn";
            this.codigoreciboDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montooriginalDataGridViewTextBoxColumn
            // 
            this.montooriginalDataGridViewTextBoxColumn.DataPropertyName = "monto_original";
            this.montooriginalDataGridViewTextBoxColumn.HeaderText = "Monto_Original";
            this.montooriginalDataGridViewTextBoxColumn.Name = "montooriginalDataGridViewTextBoxColumn";
            this.montooriginalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montopendienteDataGridViewTextBoxColumn
            // 
            this.montopendienteDataGridViewTextBoxColumn.DataPropertyName = "monto_pendiente";
            this.montopendienteDataGridViewTextBoxColumn.HeaderText = "Monto_Pendiente";
            this.montopendienteDataGridViewTextBoxColumn.Name = "montopendienteDataGridViewTextBoxColumn";
            this.montopendienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            this.empresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // rncDataGridViewTextBoxColumn
            // 
            this.rncDataGridViewTextBoxColumn.DataPropertyName = "rnc";
            this.rncDataGridViewTextBoxColumn.HeaderText = "rnc";
            this.rncDataGridViewTextBoxColumn.Name = "rncDataGridViewTextBoxColumn";
            this.rncDataGridViewTextBoxColumn.ReadOnly = true;
            this.rncDataGridViewTextBoxColumn.Visible = false;
            // 
            // sucursalDataGridViewTextBoxColumn
            // 
            this.sucursalDataGridViewTextBoxColumn.DataPropertyName = "sucursal";
            this.sucursalDataGridViewTextBoxColumn.HeaderText = "sucursal";
            this.sucursalDataGridViewTextBoxColumn.Name = "sucursalDataGridViewTextBoxColumn";
            this.sucursalDataGridViewTextBoxColumn.ReadOnly = true;
            this.sucursalDataGridViewTextBoxColumn.Visible = false;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Visible = false;
            // 
            // vistacobrosporcobrarBindingSource
            // 
            this.vistacobrosporcobrarBindingSource.DataMember = "vista_cobros_porcobrar";
            this.vistacobrosporcobrarBindingSource.DataSource = this.cobros_porcobrarDataSet;
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
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(289, 265);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(90, 36);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "59565";
            this.buttonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX2.TabIndex = 25;
            this.buttonX2.Text = "Imprimir";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // Consulta_Cobros_Porcobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 324);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.dataGridView);
            this.Name = "Consulta_Cobros_Porcobrar";
            this.Text = "Consulta_Cobros_Porcobrar";
            this.Load += new System.EventHandler(this.Consulta_Cobros_Porcobrar_Load);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.codigo, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.dataGridView, 0);
            this.Controls.SetChildIndex(this.buttonX2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistacobrosporcobrarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cobros_porcobrarDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView;
        private cobros_porcobrarDataSet cobros_porcobrarDataSet;
        private System.Windows.Forms.BindingSource vistacobrosporcobrarBindingSource;
        private cobros_porcobrarDataSetTableAdapters.vista_cobros_porcobrarTableAdapter vista_cobros_porcobrarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoreciboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montooriginalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montopendienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ButtonX buttonX2;
    }
}