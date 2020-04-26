namespace DjProyect
{
    partial class Menu_CXP
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tRANZACIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEALIZARPAGOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAREPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cONSULTAFACTURASINPAGARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tRANZACIONToolStripMenuItem,
            this.cONSULTAREPORTESToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tRANZACIONToolStripMenuItem
            // 
            this.tRANZACIONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEALIZARPAGOToolStripMenuItem});
            this.tRANZACIONToolStripMenuItem.Name = "tRANZACIONToolStripMenuItem";
            this.tRANZACIONToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.tRANZACIONToolStripMenuItem.Text = "TRANZACION";
            // 
            // rEALIZARPAGOToolStripMenuItem
            // 
            this.rEALIZARPAGOToolStripMenuItem.Name = "rEALIZARPAGOToolStripMenuItem";
            this.rEALIZARPAGOToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.rEALIZARPAGOToolStripMenuItem.Text = "REALIZAR PAGO";
            this.rEALIZARPAGOToolStripMenuItem.Click += new System.EventHandler(this.rEALIZARPAGOToolStripMenuItem_Click);
            // 
            // cONSULTAREPORTESToolStripMenuItem
            // 
            this.cONSULTAREPORTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONSULTAFACTURASINPAGARToolStripMenuItem});
            this.cONSULTAREPORTESToolStripMenuItem.Name = "cONSULTAREPORTESToolStripMenuItem";
            this.cONSULTAREPORTESToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.cONSULTAREPORTESToolStripMenuItem.Text = "CONSULTA/REPORTES";
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // cONSULTAFACTURASINPAGARToolStripMenuItem
            // 
            this.cONSULTAFACTURASINPAGARToolStripMenuItem.Name = "cONSULTAFACTURASINPAGARToolStripMenuItem";
            this.cONSULTAFACTURASINPAGARToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
            this.cONSULTAFACTURASINPAGARToolStripMenuItem.Text = "CONSULTA FACTURA SIN PAGAR";
            this.cONSULTAFACTURASINPAGARToolStripMenuItem.Click += new System.EventHandler(this.cONSULTAFACTURASINPAGARToolStripMenuItem_Click);
            // 
            // Menu_CXP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Menu_CXP";
            this.Text = "Menu_CXP";
            this.Controls.SetChildIndex(this.menuStrip, 0);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tRANZACIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAREPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEALIZARPAGOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAFACTURASINPAGARToolStripMenuItem;
    }
}



