namespace DjProyect
{
    partial class consulta_factura_sinpagar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.codsupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecharegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistacxpsinpagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cxpfacturasinpagarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cxp_facturasinpagarDataSet = new DjProyect.cxp_facturasinpagarDataSet();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.vista_cxp_sinpagarTableAdapter = new DjProyect.cxp_facturasinpagarDataSetTableAdapters.vista_cxp_sinpagarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistacxpsinpagarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxpfacturasinpagarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxp_facturasinpagarDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo
            // 
            // 
            // 
            // 
            this.codigo.Border.Class = "TextBoxBorder";
            this.codigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.codigo.Location = new System.Drawing.Point(49, 63);
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(77, 265);
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(567, 265);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codsupDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.fecharegistroDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.montoDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.rncDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.vistacxpsinpagarBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridView.Location = new System.Drawing.Point(49, 89);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(646, 150);
            this.dataGridView.TabIndex = 24;
            // 
            // codsupDataGridViewTextBoxColumn
            // 
            this.codsupDataGridViewTextBoxColumn.DataPropertyName = "codsup";
            this.codsupDataGridViewTextBoxColumn.HeaderText = "codsup";
            this.codsupDataGridViewTextBoxColumn.Name = "codsupDataGridViewTextBoxColumn";
            this.codsupDataGridViewTextBoxColumn.ReadOnly = true;
            this.codsupDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fecharegistroDataGridViewTextBoxColumn
            // 
            this.fecharegistroDataGridViewTextBoxColumn.DataPropertyName = "fecha_registro";
            this.fecharegistroDataGridViewTextBoxColumn.HeaderText = "fecha_registro";
            this.fecharegistroDataGridViewTextBoxColumn.Name = "fecharegistroDataGridViewTextBoxColumn";
            this.fecharegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "suplidor";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // vistacxpsinpagarBindingSource
            // 
            this.vistacxpsinpagarBindingSource.DataMember = "vista_cxp_sinpagar";
            this.vistacxpsinpagarBindingSource.DataSource = this.cxpfacturasinpagarDataSetBindingSource;
            // 
            // cxpfacturasinpagarDataSetBindingSource
            // 
            this.cxpfacturasinpagarDataSetBindingSource.DataSource = this.cxp_facturasinpagarDataSet;
            this.cxpfacturasinpagarDataSetBindingSource.Position = 0;
            // 
            // cxp_facturasinpagarDataSet
            // 
            this.cxp_facturasinpagarDataSet.DataSetName = "cxp_facturasinpagarDataSet";
            this.cxp_facturasinpagarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(313, 265);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(87, 36);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 25;
            this.buttonX2.Text = "Imprimir";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // vista_cxp_sinpagarTableAdapter
            // 
            this.vista_cxp_sinpagarTableAdapter.ClearBeforeFill = true;
            // 
            // consulta_factura_sinpagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 339);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.dataGridView);
            this.Name = "consulta_factura_sinpagar";
            this.Text = "CONSULTA DE FACTURA SIN PAGAR";
            this.Load += new System.EventHandler(this.consulta_factura_sinpagar_Load);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.codigo, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.dataGridView, 0);
            this.Controls.SetChildIndex(this.buttonX2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistacxpsinpagarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxpfacturasinpagarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cxp_facturasinpagarDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridView;
        private System.Windows.Forms.BindingSource cxpfacturasinpagarDataSetBindingSource;
        private cxp_facturasinpagarDataSet cxp_facturasinpagarDataSet;
        private System.Windows.Forms.BindingSource vistacxpsinpagarBindingSource;
        private cxp_facturasinpagarDataSetTableAdapters.vista_cxp_sinpagarTableAdapter vista_cxp_sinpagarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codsupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecharegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private DevComponents.DotNetBar.ButtonX buttonX2;
    }
}