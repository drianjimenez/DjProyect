namespace DjProyect
{
    partial class Consulta_Factura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rncempresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sucursalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistafacturasindetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factura_sin_detalleDataSet = new DjProyect.factura_sin_detalleDataSet();
            this.vista_facturasindetalleTableAdapter = new DjProyect.factura_sin_detalleDataSetTableAdapters.vista_facturasindetalleTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckpresentar = new System.Windows.Forms.RadioButton();
            this.ckpdf = new System.Windows.Forms.RadioButton();
            this.ckexcel = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdesde = new System.Windows.Forms.DateTimePicker();
            this.txthasta = new System.Windows.Forms.DateTimePicker();
            this.txtimprimir = new System.Windows.Forms.Label();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.lbtotalregistro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbmonto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistafacturasindetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_sin_detalleDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codigo
            // 
            // 
            // 
            // 
            this.codigo.Border.Class = "TextBoxBorder";
            this.codigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.codigo.Location = new System.Drawing.Point(90, 63);
            this.codigo.Size = new System.Drawing.Size(190, 20);
            this.codigo.TabIndex = 0;
            this.codigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(211, 445);
            this.buttonX1.Size = new System.Drawing.Size(96, 50);
            this.buttonX1.Symbol = "59565";
            this.buttonX1.SymbolColor = System.Drawing.Color.Blue;
            this.buttonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "Imprimir";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(602, 453);
            this.salir.Size = new System.Drawing.Size(96, 50);
            this.salir.SymbolColor = System.Drawing.Color.Blue;
            this.salir.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.empresaDataGridViewTextBoxColumn,
            this.rncempresaDataGridViewTextBoxColumn,
            this.sucursalDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vistafacturasindetalleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(944, 255);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "numero";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn7.HeaderText = "Numero_Factura";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 111;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fecha";
            this.dataGridViewTextBoxColumn1.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "monto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "N2";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Monto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ncf";
            this.dataGridViewTextBoxColumn3.HeaderText = "NCF";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 53;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "tipo_comprobante";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo_Comprobante";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 122;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "usuario";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "estado";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // rncempresaDataGridViewTextBoxColumn
            // 
            this.rncempresaDataGridViewTextBoxColumn.DataPropertyName = "rncempresa";
            this.rncempresaDataGridViewTextBoxColumn.HeaderText = "rncempresa";
            this.rncempresaDataGridViewTextBoxColumn.Name = "rncempresaDataGridViewTextBoxColumn";
            this.rncempresaDataGridViewTextBoxColumn.Visible = false;
            // 
            // sucursalDataGridViewTextBoxColumn
            // 
            this.sucursalDataGridViewTextBoxColumn.DataPropertyName = "sucursal";
            this.sucursalDataGridViewTextBoxColumn.HeaderText = "sucursal";
            this.sucursalDataGridViewTextBoxColumn.Name = "sucursalDataGridViewTextBoxColumn";
            this.sucursalDataGridViewTextBoxColumn.Visible = false;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.Visible = false;
            // 
            // vistafacturasindetalleBindingSource
            // 
            this.vistafacturasindetalleBindingSource.DataMember = "vista_facturasindetalle";
            this.vistafacturasindetalleBindingSource.DataSource = this.factura_sin_detalleDataSet;
            // 
            // factura_sin_detalleDataSet
            // 
            this.factura_sin_detalleDataSet.DataSetName = "factura_sin_detalleDataSet";
            this.factura_sin_detalleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vista_facturasindetalleTableAdapter
            // 
            this.vista_facturasindetalleTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckpresentar);
            this.panel1.Controls.Add(this.ckpdf);
            this.panel1.Controls.Add(this.ckexcel);
            this.panel1.Location = new System.Drawing.Point(34, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 102);
            this.panel1.TabIndex = 25;
            // 
            // ckpresentar
            // 
            this.ckpresentar.AutoSize = true;
            this.ckpresentar.Checked = true;
            this.ckpresentar.Location = new System.Drawing.Point(15, 23);
            this.ckpresentar.Name = "ckpresentar";
            this.ckpresentar.Size = new System.Drawing.Size(70, 17);
            this.ckpresentar.TabIndex = 0;
            this.ckpresentar.TabStop = true;
            this.ckpresentar.Text = "Presentar";
            this.ckpresentar.UseVisualStyleBackColor = true;
            // 
            // ckpdf
            // 
            this.ckpdf.AutoSize = true;
            this.ckpdf.Location = new System.Drawing.Point(15, 46);
            this.ckpdf.Name = "ckpdf";
            this.ckpdf.Size = new System.Drawing.Size(46, 17);
            this.ckpdf.TabIndex = 1;
            this.ckpdf.Text = "PDF";
            this.ckpdf.UseVisualStyleBackColor = true;
            // 
            // ckexcel
            // 
            this.ckexcel.AutoSize = true;
            this.ckexcel.Location = new System.Drawing.Point(15, 69);
            this.ckexcel.Name = "ckexcel";
            this.ckexcel.Size = new System.Drawing.Size(51, 17);
            this.ckexcel.TabIndex = 2;
            this.ckexcel.Text = "Excel";
            this.ckexcel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRESENTAR POR: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Hasta";
            // 
            // txtdesde
            // 
            this.txtdesde.CustomFormat = "dd-MM-yyyy";
            this.txtdesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdesde.Location = new System.Drawing.Point(90, 89);
            this.txtdesde.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.txtdesde.Name = "txtdesde";
            this.txtdesde.Size = new System.Drawing.Size(103, 20);
            this.txtdesde.TabIndex = 1;
            this.txtdesde.Value = new System.DateTime(2020, 4, 12, 20, 53, 0, 0);
            // 
            // txthasta
            // 
            this.txthasta.CustomFormat = "dd-MM-yyyy";
            this.txthasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txthasta.Location = new System.Drawing.Point(90, 113);
            this.txthasta.Name = "txthasta";
            this.txthasta.Size = new System.Drawing.Size(103, 20);
            this.txthasta.TabIndex = 2;
            // 
            // txtimprimir
            // 
            this.txtimprimir.AutoSize = true;
            this.txtimprimir.Location = new System.Drawing.Point(163, 522);
            this.txtimprimir.Name = "txtimprimir";
            this.txtimprimir.Size = new System.Drawing.Size(0, 13);
            this.txtimprimir.TabIndex = 31;
            this.txtimprimir.Visible = false;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(199, 89);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(81, 37);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.SymbolColor = System.Drawing.Color.Blue;
            this.buttonX2.TabIndex = 3;
            this.buttonX2.Text = "Buscar";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "TOTAL DE REGISTRO: ";
            // 
            // lbtotalregistro
            // 
            this.lbtotalregistro.AutoSize = true;
            this.lbtotalregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalregistro.Location = new System.Drawing.Point(172, 405);
            this.lbtotalregistro.Name = "lbtotalregistro";
            this.lbtotalregistro.Size = new System.Drawing.Size(56, 18);
            this.lbtotalregistro.TabIndex = 33;
            this.lbtotalregistro.Text = "Codigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "MONTO: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbmonto
            // 
            this.lbmonto.AutoSize = true;
            this.lbmonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmonto.Location = new System.Drawing.Point(374, 406);
            this.lbmonto.Name = "lbmonto";
            this.lbmonto.Size = new System.Drawing.Size(51, 18);
            this.lbmonto.TabIndex = 35;
            this.lbmonto.Text = "Desde";
            // 
            // Consulta_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 570);
            this.Controls.Add(this.lbmonto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbtotalregistro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.txtimprimir);
            this.Controls.Add(this.txthasta);
            this.Controls.Add(this.txtdesde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Consulta_Factura";
            this.Text = "Consulta Factura";
            this.Load += new System.EventHandler(this.Consulta_Factura_Load);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.codigo, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtdesde, 0);
            this.Controls.SetChildIndex(this.txthasta, 0);
            this.Controls.SetChildIndex(this.txtimprimir, 0);
            this.Controls.SetChildIndex(this.buttonX2, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lbtotalregistro, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.lbmonto, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistafacturasindetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura_sin_detalleDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private factura_sin_detalleDataSet factura_sin_detalleDataSet;
        private System.Windows.Forms.BindingSource vistafacturasindetalleBindingSource;
        private factura_sin_detalleDataSetTableAdapters.vista_facturasindetalleTableAdapter vista_facturasindetalleTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ckpresentar;
        private System.Windows.Forms.RadioButton ckpdf;
        private System.Windows.Forms.RadioButton ckexcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocomprobanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtdesde;
        private System.Windows.Forms.DateTimePicker txthasta;
        private System.Windows.Forms.Label txtimprimir;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rncempresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sucursalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbtotalregistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbmonto;
    }
}