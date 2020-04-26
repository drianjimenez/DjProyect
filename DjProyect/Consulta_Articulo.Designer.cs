namespace DjProyect
{
    partial class Consulta_Articulo
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.vistaarticulo = new DjProyect.vistaarticulo();
            this.vistaarticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaarticuloTableAdapter = new DjProyect.vistaarticuloTableAdapters.vistaarticuloTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.almacenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codalmacenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaarticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaarticuloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // codigo
            // 
            // 
            // 
            // 
            this.codigo.Border.Class = "TextBoxBorder";
            this.codigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.codigo.Location = new System.Drawing.Point(31, 63);
            this.codigo.TabIndex = 0;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(64, 322);
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(590, 322);
            this.salir.TabIndex = 2;
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
            this.descripcionDataGridViewTextBoxColumn,
            this.unidadDataGridViewTextBoxColumn,
            this.existenciaDataGridViewTextBoxColumn,
            this.almacenDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn,
            this.rncDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.codalmacenDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.vistaarticuloBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(29, 99);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(707, 217);
            this.dataGridView.TabIndex = 1;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(325, 322);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(87, 36);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "59565";
            this.buttonX2.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX2.TabIndex = 3;
            this.buttonX2.Text = "Imprimir";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // vistaarticulo
            // 
            this.vistaarticulo.DataSetName = "vistaarticulo";
            this.vistaarticulo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaarticuloBindingSource
            // 
            this.vistaarticuloBindingSource.DataMember = "vistaarticulo";
            this.vistaarticuloBindingSource.DataSource = this.vistaarticulo;
            // 
            // vistaarticuloTableAdapter
            // 
            this.vistaarticuloTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 250;
            // 
            // unidadDataGridViewTextBoxColumn
            // 
            this.unidadDataGridViewTextBoxColumn.DataPropertyName = "unidad";
            this.unidadDataGridViewTextBoxColumn.HeaderText = "unidad";
            this.unidadDataGridViewTextBoxColumn.Name = "unidadDataGridViewTextBoxColumn";
            this.unidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // existenciaDataGridViewTextBoxColumn
            // 
            this.existenciaDataGridViewTextBoxColumn.DataPropertyName = "existencia";
            this.existenciaDataGridViewTextBoxColumn.HeaderText = "existencia";
            this.existenciaDataGridViewTextBoxColumn.Name = "existenciaDataGridViewTextBoxColumn";
            this.existenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // almacenDataGridViewTextBoxColumn
            // 
            this.almacenDataGridViewTextBoxColumn.DataPropertyName = "almacen";
            this.almacenDataGridViewTextBoxColumn.HeaderText = "almacen";
            this.almacenDataGridViewTextBoxColumn.Name = "almacenDataGridViewTextBoxColumn";
            this.almacenDataGridViewTextBoxColumn.ReadOnly = true;
            this.almacenDataGridViewTextBoxColumn.Visible = false;
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
            // codalmacenDataGridViewTextBoxColumn
            // 
            this.codalmacenDataGridViewTextBoxColumn.DataPropertyName = "cod_almacen";
            this.codalmacenDataGridViewTextBoxColumn.HeaderText = "cod_almacen";
            this.codalmacenDataGridViewTextBoxColumn.Name = "codalmacenDataGridViewTextBoxColumn";
            this.codalmacenDataGridViewTextBoxColumn.ReadOnly = true;
            this.codalmacenDataGridViewTextBoxColumn.Visible = false;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Consulta_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 381);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.dataGridView);
            this.Name = "Consulta_Articulo";
            this.Text = "Consulta_Articulo";
            this.Load += new System.EventHandler(this.Consulta_Articulo_Load);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.codigo, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.dataGridView, 0);
            this.Controls.SetChildIndex(this.buttonX2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaarticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaarticuloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private vistaarticulo vistaarticulo;
        private System.Windows.Forms.BindingSource vistaarticuloBindingSource;
        private vistaarticuloTableAdapters.vistaarticuloTableAdapter vistaarticuloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn almacenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codalmacenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;

    }
}