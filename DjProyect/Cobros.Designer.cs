namespace DjProyect
{
    partial class Cobros
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
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cliente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.codcli = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoreciboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montooriginalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montopendienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoaplicar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistacobroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_cobroDataSet = new DjProyect.vista_cobroDataSet();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtsinaplicar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txttotalaplicado = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtpagoaplicado = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtdescuento = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txttotalpendiente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.vista_cobroTableAdapter = new DjProyect.vista_cobroDataSetTableAdapters.vista_cobroTableAdapter();
            this.txtusuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistacobroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_cobroDataSet)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(646, 444);
            this.salir.Text = "SALIR";
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(32, 63);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 49;
            this.labelX5.Text = "CLIENTE";
            // 
            // cliente
            // 
            this.cliente.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.cliente.Border.Class = "TextBoxBorder";
            this.cliente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cliente.DisabledBackColor = System.Drawing.Color.White;
            this.cliente.Enabled = false;
            this.cliente.ForeColor = System.Drawing.Color.Black;
            this.cliente.Location = new System.Drawing.Point(180, 63);
            this.cliente.Name = "cliente";
            this.cliente.PreventEnterBeep = true;
            this.cliente.Size = new System.Drawing.Size(281, 20);
            this.cliente.TabIndex = 48;
            // 
            // codcli
            // 
            this.codcli.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.codcli.Border.Class = "TextBoxBorder";
            this.codcli.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.codcli.DisabledBackColor = System.Drawing.Color.White;
            this.codcli.Enabled = false;
            this.codcli.ForeColor = System.Drawing.Color.Black;
            this.codcli.Location = new System.Drawing.Point(113, 63);
            this.codcli.Name = "codcli";
            this.codcli.PreventEnterBeep = true;
            this.codcli.Size = new System.Drawing.Size(61, 20);
            this.codcli.TabIndex = 47;
            this.codcli.TextChanged += new System.EventHandler(this.codcli_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoreciboDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.montooriginalDataGridViewTextBoxColumn,
            this.montopendienteDataGridViewTextBoxColumn,
            this.Monto,
            this.descuentoDataGridViewTextBoxColumn,
            this.des,
            this.montoaplicar,
            this.conceptoDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vistacobroBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(896, 250);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // codigoreciboDataGridViewTextBoxColumn
            // 
            this.codigoreciboDataGridViewTextBoxColumn.DataPropertyName = "codigo_recibo";
            this.codigoreciboDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.codigoreciboDataGridViewTextBoxColumn.Name = "codigoreciboDataGridViewTextBoxColumn";
            this.codigoreciboDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.montooriginalDataGridViewTextBoxColumn.HeaderText = "Monto Original";
            this.montooriginalDataGridViewTextBoxColumn.Name = "montooriginalDataGridViewTextBoxColumn";
            this.montooriginalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montopendienteDataGridViewTextBoxColumn
            // 
            this.montopendienteDataGridViewTextBoxColumn.DataPropertyName = "monto_pendiente";
            this.montopendienteDataGridViewTextBoxColumn.HeaderText = "Monto Pendiente";
            this.montopendienteDataGridViewTextBoxColumn.Name = "montopendienteDataGridViewTextBoxColumn";
            this.montopendienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto a Pagar";
            this.Monto.Name = "Monto";
            // 
            // descuentoDataGridViewTextBoxColumn
            // 
            this.descuentoDataGridViewTextBoxColumn.DataPropertyName = "descuento";
            this.descuentoDataGridViewTextBoxColumn.HeaderText = "%Desc";
            this.descuentoDataGridViewTextBoxColumn.Name = "descuentoDataGridViewTextBoxColumn";
            this.descuentoDataGridViewTextBoxColumn.Width = 50;
            // 
            // des
            // 
            this.des.HeaderText = "Descuento";
            this.des.Name = "des";
            this.des.ReadOnly = true;
            // 
            // montoaplicar
            // 
            this.montoaplicar.HeaderText = "Montos Aplicar";
            this.montoaplicar.Name = "montoaplicar";
            this.montoaplicar.ReadOnly = true;
            // 
            // conceptoDataGridViewTextBoxColumn
            // 
            this.conceptoDataGridViewTextBoxColumn.DataPropertyName = "concepto";
            this.conceptoDataGridViewTextBoxColumn.HeaderText = "Concepto";
            this.conceptoDataGridViewTextBoxColumn.Name = "conceptoDataGridViewTextBoxColumn";
            this.conceptoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            this.clienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // vistacobroBindingSource
            // 
            this.vistacobroBindingSource.DataMember = "vista_cobro";
            this.vistacobroBindingSource.DataSource = this.vista_cobroDataSet;
            // 
            // vista_cobroDataSet
            // 
            this.vista_cobroDataSet.DataSetName = "vista_cobroDataSet";
            this.vista_cobroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtsinaplicar);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.txttotalaplicado);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.txtpagoaplicado);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.txtdescuento);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txttotalpendiente);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(152, 359);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(645, 75);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 51;
            // 
            // txtsinaplicar
            // 
            this.txtsinaplicar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtsinaplicar.Border.Class = "TextBoxBorder";
            this.txtsinaplicar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtsinaplicar.DisabledBackColor = System.Drawing.Color.White;
            this.txtsinaplicar.Enabled = false;
            this.txtsinaplicar.ForeColor = System.Drawing.Color.Black;
            this.txtsinaplicar.Location = new System.Drawing.Point(491, 32);
            this.txtsinaplicar.Name = "txtsinaplicar";
            this.txtsinaplicar.PreventEnterBeep = true;
            this.txtsinaplicar.Size = new System.Drawing.Size(117, 20);
            this.txtsinaplicar.TabIndex = 9;
            this.txtsinaplicar.Text = "0.00";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(491, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(117, 23);
            this.labelX6.TabIndex = 8;
            this.labelX6.Text = "TOTAL SIN APLICAR";
            // 
            // txttotalaplicado
            // 
            this.txttotalaplicado.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txttotalaplicado.Border.Class = "TextBoxBorder";
            this.txttotalaplicado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttotalaplicado.DisabledBackColor = System.Drawing.Color.White;
            this.txttotalaplicado.Enabled = false;
            this.txttotalaplicado.ForeColor = System.Drawing.Color.Black;
            this.txttotalaplicado.Location = new System.Drawing.Point(383, 32);
            this.txttotalaplicado.Name = "txttotalaplicado";
            this.txttotalaplicado.PreventEnterBeep = true;
            this.txttotalaplicado.Size = new System.Drawing.Size(100, 20);
            this.txttotalaplicado.TabIndex = 7;
            this.txttotalaplicado.Text = "0.00";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(383, 3);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(100, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "TOTAL APLICADO";
            // 
            // txtpagoaplicado
            // 
            this.txtpagoaplicado.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtpagoaplicado.Border.Class = "TextBoxBorder";
            this.txtpagoaplicado.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtpagoaplicado.DisabledBackColor = System.Drawing.Color.White;
            this.txtpagoaplicado.Enabled = false;
            this.txtpagoaplicado.ForeColor = System.Drawing.Color.Black;
            this.txtpagoaplicado.Location = new System.Drawing.Point(242, 32);
            this.txtpagoaplicado.Name = "txtpagoaplicado";
            this.txtpagoaplicado.PreventEnterBeep = true;
            this.txtpagoaplicado.Size = new System.Drawing.Size(135, 20);
            this.txtpagoaplicado.TabIndex = 5;
            this.txtpagoaplicado.Text = "0.00";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(245, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(132, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "TOTAL PAGO APLICADO";
            // 
            // txtdescuento
            // 
            this.txtdescuento.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtdescuento.Border.Class = "TextBoxBorder";
            this.txtdescuento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtdescuento.DisabledBackColor = System.Drawing.Color.White;
            this.txtdescuento.Enabled = false;
            this.txtdescuento.ForeColor = System.Drawing.Color.Black;
            this.txtdescuento.Location = new System.Drawing.Point(132, 32);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.PreventEnterBeep = true;
            this.txtdescuento.Size = new System.Drawing.Size(100, 20);
            this.txtdescuento.TabIndex = 3;
            this.txtdescuento.Text = "0.00";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(132, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "DESCUENTO";
            // 
            // txttotalpendiente
            // 
            this.txttotalpendiente.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txttotalpendiente.Border.Class = "TextBoxBorder";
            this.txttotalpendiente.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttotalpendiente.DisabledBackColor = System.Drawing.Color.White;
            this.txttotalpendiente.Enabled = false;
            this.txttotalpendiente.ForeColor = System.Drawing.Color.Black;
            this.txttotalpendiente.Location = new System.Drawing.Point(22, 32);
            this.txttotalpendiente.Name = "txttotalpendiente";
            this.txttotalpendiente.PreventEnterBeep = true;
            this.txttotalpendiente.Size = new System.Drawing.Size(100, 20);
            this.txttotalpendiente.TabIndex = 1;
            this.txttotalpendiente.Text = "0.00";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(22, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(104, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "TOTAL PENDIENTE";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(177, 444);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(87, 36);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 52;
            this.buttonX1.Text = "GUARDAR";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // vista_cobroTableAdapter
            // 
            this.vista_cobroTableAdapter.ClearBeforeFill = true;
            // 
            // txtusuario
            // 
            this.txtusuario.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtusuario.Border.Class = "TextBoxBorder";
            this.txtusuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtusuario.DisabledBackColor = System.Drawing.Color.White;
            this.txtusuario.ForeColor = System.Drawing.Color.Black;
            this.txtusuario.Location = new System.Drawing.Point(620, 33);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PreventEnterBeep = true;
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 53;
            this.txtusuario.Visible = false;
            // 
            // Cobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 503);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.codcli);
            this.Name = "Cobros";
            this.Text = "Cobros";
            this.Load += new System.EventHandler(this.Cobros_Load);
            this.Controls.SetChildIndex(this.codcli, 0);
            this.Controls.SetChildIndex(this.cliente, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.groupPanel1, 0);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.txtusuario, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistacobroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vista_cobroDataSet)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX cliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtsinaplicar;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txttotalaplicado;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtpagoaplicado;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtdescuento;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txttotalpendiente;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private vista_cobroDataSet vista_cobroDataSet;
        private System.Windows.Forms.BindingSource vistacobroBindingSource;
        private vista_cobroDataSetTableAdapters.vista_cobroTableAdapter vista_cobroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn montosaplicar;
        public DevComponents.DotNetBar.Controls.TextBoxX codcli;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoreciboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montooriginalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montopendienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn des;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoaplicar;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceptoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        public DevComponents.DotNetBar.Controls.TextBoxX txtusuario;
    }
}