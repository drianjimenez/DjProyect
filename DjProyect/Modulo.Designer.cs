namespace DjProyect
{
    partial class Modulo
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
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.btnfacturacion = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btninventario = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btnconfiguracion = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btncompra = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.btncxc = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtusuario = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.SuspendLayout();
            // 
            // metroTilePanel1
            // 
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.DragDropSupport = true;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.metroTilePanel1.Location = new System.Drawing.Point(38, 26);
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.Size = new System.Drawing.Size(600, 233);
            this.metroTilePanel1.TabIndex = 3;
            this.metroTilePanel1.Text = "metroTilePanel1";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnfacturacion,
            this.btninventario,
            this.btnconfiguracion,
            this.btncompra,
            this.btncxc,
            this.metroTileItem1});
            this.itemContainer1.Text = "CUENTA POR PAGAR";
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnfacturacion
            // 
            this.btnfacturacion.Name = "btnfacturacion";
            this.btnfacturacion.Symbol = "";
            this.btnfacturacion.SymbolColor = System.Drawing.Color.White;
            this.btnfacturacion.SymbolSize = 50F;
            this.btnfacturacion.Text = "FACTURACION";
            this.btnfacturacion.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.btnfacturacion.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnfacturacion.Click += new System.EventHandler(this.btnfacturacion_Click);
            // 
            // btninventario
            // 
            this.btninventario.Name = "btninventario";
            this.btninventario.Symbol = "";
            this.btninventario.SymbolColor = System.Drawing.Color.Yellow;
            this.btninventario.SymbolSize = 50F;
            this.btninventario.Text = "INVENTARIO";
            this.btninventario.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.btninventario.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btninventario.Click += new System.EventHandler(this.metroTileItem2_Click);
            // 
            // btnconfiguracion
            // 
            this.btnconfiguracion.Name = "btnconfiguracion";
            this.btnconfiguracion.Symbol = "";
            this.btnconfiguracion.SymbolColor = System.Drawing.Color.Empty;
            this.btnconfiguracion.SymbolSize = 50F;
            this.btnconfiguracion.Text = "CONFIGURACION";
            this.btnconfiguracion.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.btnconfiguracion.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnconfiguracion.Click += new System.EventHandler(this.btnconfiguracion_Click);
            // 
            // btncompra
            // 
            this.btncompra.Name = "btncompra";
            this.btncompra.Symbol = "";
            this.btncompra.SymbolColor = System.Drawing.Color.Red;
            this.btncompra.SymbolSize = 50F;
            this.btncompra.Text = "COMPRA";
            this.btncompra.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.btncompra.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btncompra.Click += new System.EventHandler(this.btncompra_Click);
            // 
            // btncxc
            // 
            this.btncxc.Name = "btncxc";
            this.btncxc.Symbol = "";
            this.btncxc.SymbolColor = System.Drawing.Color.Lime;
            this.btncxc.SymbolSize = 50F;
            this.btncxc.Text = "CUENTA POR COBRAR";
            this.btncxc.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.btncxc.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btncxc.Click += new System.EventHandler(this.btncxc_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(55, 256);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(106, 21);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "BIENVENIDO:";
            // 
            // txtusuario
            // 
            // 
            // 
            // 
            this.txtusuario.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Location = new System.Drawing.Point(167, 256);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(93, 21);
            this.txtusuario.TabIndex = 2;
            this.txtusuario.Text = "USUARIO";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(301, 265);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(96, 30);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 0;
            this.buttonX1.Text = "SALIR";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // itemPanel1
            // 
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.DragDropSupport = true;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem1});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(495, 258);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(8, 8);
            this.itemPanel1.TabIndex = 4;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = true;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.Symbol = "";
            this.metroTileItem1.SymbolColor = System.Drawing.Color.Black;
            this.metroTileItem1.SymbolSize = 50F;
            this.metroTileItem1.Text = "CUENTA POR PAGAR";
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem1.Click += new System.EventHandler(this.metroTileItem1_Click);
            // 
            // Modulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 318);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.metroTilePanel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Modulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MODULOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modulo_FormClosing);
            this.Load += new System.EventHandler(this.Modulo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem btnfacturacion;
        private DevComponents.DotNetBar.Metro.MetroTileItem btninventario;
        private DevComponents.DotNetBar.Metro.MetroTileItem btncxc;
        private DevComponents.DotNetBar.Metro.MetroTileItem btncompra;
        private DevComponents.DotNetBar.LabelX labelX1;
        public DevComponents.DotNetBar.LabelX txtusuario;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        public DevComponents.DotNetBar.Metro.MetroTileItem btnconfiguracion;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem1;
    }
}