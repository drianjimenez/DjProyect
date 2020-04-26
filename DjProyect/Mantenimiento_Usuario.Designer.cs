namespace DjProyect
{
    partial class Mantenimiento_Usuario
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
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.txtsucursal = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.sucursalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sucursalDataSet = new DjProyect.sucursalDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.activado = new DevComponents.Editors.ComboItem();
            this.desactivado = new DevComponents.Editors.ComboItem();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrepetir = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtcontrasena = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtnombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtusuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.chconfiguracion = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chcxc = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chinventario = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chreporte = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chcompra = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chfacturacion = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.sucursalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sucursalTableAdapter = new DjProyect.sucursalDataSetTableAdapters.sucursalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalDataSet)).BeginInit();
            this.tabControlPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(287, 381);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 381);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 381);
            this.button2.SymbolColor = System.Drawing.Color.Navy;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(414, 381);
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.White;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.ForeColor = System.Drawing.Color.Black;
            this.tabControl1.Location = new System.Drawing.Point(27, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(518, 290);
            this.tabControl1.TabIndex = 25;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Text = "Nuevo";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.txtsucursal);
            this.tabControlPanel1.Controls.Add(this.label6);
            this.tabControlPanel1.Controls.Add(this.comboBoxEx1);
            this.tabControlPanel1.Controls.Add(this.label5);
            this.tabControlPanel1.Controls.Add(this.txtrepetir);
            this.tabControlPanel1.Controls.Add(this.txtcontrasena);
            this.tabControlPanel1.Controls.Add(this.txtnombre);
            this.tabControlPanel1.Controls.Add(this.txtusuario);
            this.tabControlPanel1.Controls.Add(this.label4);
            this.tabControlPanel1.Controls.Add(this.label3);
            this.tabControlPanel1.Controls.Add(this.label2);
            this.tabControlPanel1.Controls.Add(this.label1);
            this.tabControlPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(518, 264);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 0;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // txtsucursal
            // 
            this.txtsucursal.DataSource = this.sucursalBindingSource1;
            this.txtsucursal.DisplayMember = "nombre";
            this.txtsucursal.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtsucursal.FormattingEnabled = true;
            this.txtsucursal.ItemHeight = 14;
            this.txtsucursal.Location = new System.Drawing.Point(104, 223);
            this.txtsucursal.Name = "txtsucursal";
            this.txtsucursal.Size = new System.Drawing.Size(153, 20);
            this.txtsucursal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtsucursal.TabIndex = 20;
            this.txtsucursal.ValueMember = "codigo";
            // 
            // sucursalBindingSource1
            // 
            this.sucursalBindingSource1.DataMember = "sucursal";
            this.sucursalBindingSource1.DataSource = this.sucursalDataSet;
            // 
            // sucursalDataSet
            // 
            this.sucursalDataSet.DataSetName = "sucursalDataSet";
            this.sucursalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Sucursal";
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DisplayMember = "Text";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.ForeColor = System.Drawing.Color.Black;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Items.AddRange(new object[] {
            this.activado,
            this.desactivado});
            this.comboBoxEx1.Location = new System.Drawing.Point(104, 182);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(153, 20);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 4;
            // 
            // activado
            // 
            this.activado.Text = "Activado";
            this.activado.Value = "activado";
            // 
            // desactivado
            // 
            this.desactivado.Text = "Desactivado";
            this.desactivado.Value = "desactivado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Estado";
            // 
            // txtrepetir
            // 
            this.txtrepetir.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtrepetir.Border.Class = "TextBoxBorder";
            this.txtrepetir.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtrepetir.DisabledBackColor = System.Drawing.Color.White;
            this.txtrepetir.ForeColor = System.Drawing.Color.Black;
            this.txtrepetir.Location = new System.Drawing.Point(104, 137);
            this.txtrepetir.Name = "txtrepetir";
            this.txtrepetir.PasswordChar = '*';
            this.txtrepetir.PreventEnterBeep = true;
            this.txtrepetir.Size = new System.Drawing.Size(212, 20);
            this.txtrepetir.TabIndex = 3;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcontrasena.Border.Class = "TextBoxBorder";
            this.txtcontrasena.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcontrasena.DisabledBackColor = System.Drawing.Color.White;
            this.txtcontrasena.ForeColor = System.Drawing.Color.Black;
            this.txtcontrasena.Location = new System.Drawing.Point(104, 99);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.PasswordChar = '*';
            this.txtcontrasena.PreventEnterBeep = true;
            this.txtcontrasena.Size = new System.Drawing.Size(212, 20);
            this.txtcontrasena.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtnombre.Border.Class = "TextBoxBorder";
            this.txtnombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtnombre.DisabledBackColor = System.Drawing.Color.White;
            this.txtnombre.ForeColor = System.Drawing.Color.Black;
            this.txtnombre.Location = new System.Drawing.Point(104, 25);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PreventEnterBeep = true;
            this.txtnombre.Size = new System.Drawing.Size(212, 20);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
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
            this.txtusuario.Location = new System.Drawing.Point(104, 60);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PreventEnterBeep = true;
            this.txtusuario.Size = new System.Drawing.Size(212, 20);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.TextChanged += new System.EventHandler(this.txtusuario_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Repetir \r\nContraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Nuevo";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.chconfiguracion);
            this.tabControlPanel2.Controls.Add(this.chcxc);
            this.tabControlPanel2.Controls.Add(this.chinventario);
            this.tabControlPanel2.Controls.Add(this.chreporte);
            this.tabControlPanel2.Controls.Add(this.chcompra);
            this.tabControlPanel2.Controls.Add(this.chfacturacion);
            this.tabControlPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(518, 264);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 5;
            this.tabControlPanel2.TabItem = this.tabItem2;
            this.tabControlPanel2.Text = " ";
            // 
            // chconfiguracion
            // 
            // 
            // 
            // 
            this.chconfiguracion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chconfiguracion.Location = new System.Drawing.Point(223, 115);
            this.chconfiguracion.Name = "chconfiguracion";
            this.chconfiguracion.Size = new System.Drawing.Size(139, 23);
            this.chconfiguracion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chconfiguracion.TabIndex = 4;
            this.chconfiguracion.Text = "CONFIGURACION";
            // 
            // chcxc
            // 
            // 
            // 
            // 
            this.chcxc.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chcxc.Location = new System.Drawing.Point(223, 72);
            this.chcxc.Name = "chcxc";
            this.chcxc.Size = new System.Drawing.Size(139, 23);
            this.chcxc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chcxc.TabIndex = 3;
            this.chcxc.Text = "CUENTAS X COBRAR";
            // 
            // chinventario
            // 
            // 
            // 
            // 
            this.chinventario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chinventario.Location = new System.Drawing.Point(223, 27);
            this.chinventario.Name = "chinventario";
            this.chinventario.Size = new System.Drawing.Size(94, 23);
            this.chinventario.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chinventario.TabIndex = 2;
            this.chinventario.Text = "INVENTARIO";
            this.chinventario.CheckedChanged += new System.EventHandler(this.checkBoxX4_CheckedChanged);
            // 
            // chreporte
            // 
            // 
            // 
            // 
            this.chreporte.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chreporte.Location = new System.Drawing.Point(27, 115);
            this.chreporte.Name = "chreporte";
            this.chreporte.Size = new System.Drawing.Size(104, 23);
            this.chreporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chreporte.TabIndex = 1;
            this.chreporte.Text = "REPORTES";
            this.chreporte.CheckedChanged += new System.EventHandler(this.checkBoxX3_CheckedChanged);
            // 
            // chcompra
            // 
            // 
            // 
            // 
            this.chcompra.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chcompra.Location = new System.Drawing.Point(27, 72);
            this.chcompra.Name = "chcompra";
            this.chcompra.Size = new System.Drawing.Size(104, 23);
            this.chcompra.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chcompra.TabIndex = 0;
            this.chcompra.Text = "COMPRA";
            // 
            // chfacturacion
            // 
            // 
            // 
            // 
            this.chfacturacion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chfacturacion.Location = new System.Drawing.Point(27, 27);
            this.chfacturacion.Name = "chfacturacion";
            this.chfacturacion.Size = new System.Drawing.Size(104, 23);
            this.chfacturacion.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chfacturacion.TabIndex = 18;
            this.chfacturacion.Text = "FACTURACION";
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Permisos";
            // 
            // sucursalBindingSource
            // 
            this.sucursalBindingSource.DataMember = "sucursal";
            this.sucursalBindingSource.DataSource = this.sucursalDataSet;
            // 
            // sucursalTableAdapter
            // 
            this.sucursalTableAdapter.ClearBeforeFill = true;
            // 
            // Mantenimiento_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 448);
            this.Controls.Add(this.tabControl1);
            this.Name = "Mantenimiento_Usuario";
            this.Text = "Mantenimiento Usuario";
            this.Load += new System.EventHandler(this.Mantenimiento_Usuario_Load);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel1.ResumeLayout(false);
            this.tabControlPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucursalDataSet)).EndInit();
            this.tabControlPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sucursalBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.Controls.CheckBoxX chreporte;
        private DevComponents.DotNetBar.Controls.CheckBoxX chcompra;
        private DevComponents.DotNetBar.Controls.CheckBoxX chfacturacion;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtrepetir;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcontrasena;
        private DevComponents.DotNetBar.Controls.TextBoxX txtnombre;
        private DevComponents.DotNetBar.Controls.TextBoxX txtusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.Controls.CheckBoxX chinventario;
        private DevComponents.DotNetBar.Controls.CheckBoxX chconfiguracion;
        private DevComponents.DotNetBar.Controls.CheckBoxX chcxc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private DevComponents.Editors.ComboItem activado;
        private DevComponents.Editors.ComboItem desactivado;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtsucursal;
        private System.Windows.Forms.Label label6;
        private sucursalDataSet sucursalDataSet;
        private System.Windows.Forms.BindingSource sucursalBindingSource;
        private sucursalDataSetTableAdapters.sucursalTableAdapter sucursalTableAdapter;
        private System.Windows.Forms.BindingSource sucursalBindingSource1;
    }
}