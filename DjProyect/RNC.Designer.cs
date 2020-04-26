namespace DjProyect
{
    partial class RNC
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.rn = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.nom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codtipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprobanteventaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprobante_venta = new DjProyect.comprobante_venta();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.comprobante_ventaTableAdapter = new DjProyect.comprobante_ventaTableAdapters.comprobante_ventaTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteventaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobante_venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(304, 355);
            this.salir.Size = new System.Drawing.Size(91, 36);
            this.salir.Symbol = "";
            this.salir.TabIndex = 4;
            this.salir.Text = "Cancelar";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(32, 74);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(95, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "RNC O CEDULA";
            // 
            // rn
            // 
            this.rn.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.rn.Border.Class = "TextBoxBorder";
            this.rn.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rn.DisabledBackColor = System.Drawing.Color.White;
            this.rn.ForeColor = System.Drawing.Color.Black;
            this.rn.Location = new System.Drawing.Point(32, 91);
            this.rn.Name = "rn";
            this.rn.PreventEnterBeep = true;
            this.rn.Size = new System.Drawing.Size(221, 20);
            this.rn.TabIndex = 0;
            this.rn.TextChanged += new System.EventHandler(this.rn_TextChanged);
            this.rn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rn_KeyDown);
            this.rn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rn_KeyPress);
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.nom.Border.Class = "TextBoxBorder";
            this.nom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.nom.DisabledBackColor = System.Drawing.Color.White;
            this.nom.ForeColor = System.Drawing.Color.Black;
            this.nom.Location = new System.Drawing.Point(32, 144);
            this.nom.Name = "nom";
            this.nom.PreventEnterBeep = true;
            this.nom.Size = new System.Drawing.Size(394, 20);
            this.nom.TabIndex = 1;
            this.nom.TextChanged += new System.EventHandler(this.nom_TextChanged);
         //   this.nom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nom_KeyDown);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(32, 127);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(95, 23);
            this.labelX2.TabIndex = 23;
            this.labelX2.Text = "A NOMBRE DE:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codtipoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comprobanteventaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(394, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // codtipoDataGridViewTextBoxColumn
            // 
            this.codtipoDataGridViewTextBoxColumn.DataPropertyName = "cod_tipo";
            this.codtipoDataGridViewTextBoxColumn.HeaderText = "cod_tipo";
            this.codtipoDataGridViewTextBoxColumn.Name = "codtipoDataGridViewTextBoxColumn";
            this.codtipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codtipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "SELECCIONE EL TIPO DE COMPROBANTE";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 300;
            // 
            // comprobanteventaBindingSource
            // 
            this.comprobanteventaBindingSource.DataMember = "comprobante_venta";
            this.comprobanteventaBindingSource.DataSource = this.comprobante_venta;
            // 
            // comprobante_venta
            // 
            this.comprobante_venta.DataSetName = "comprobante_venta";
            this.comprobante_venta.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(60, 355);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(98, 36);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "Seleccionar";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // comprobante_ventaTableAdapter
            // 
            this.comprobante_ventaTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 424);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.rn);
            this.Controls.Add(this.labelX1);
            this.Name = "RNC";
            this.Text = "RNC";
            this.Load += new System.EventHandler(this.RNC_Load);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.rn, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.nom, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobanteventaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprobante_venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private comprobante_venta comprobante_venta;
        private System.Windows.Forms.BindingSource comprobanteventaBindingSource;
        private comprobante_ventaTableAdapters.comprobante_ventaTableAdapter comprobante_ventaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codtipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        public DevComponents.DotNetBar.Controls.TextBoxX rn;
        public DevComponents.DotNetBar.Controls.TextBoxX nom;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}