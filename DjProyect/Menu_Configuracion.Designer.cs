namespace DjProyect
{
    partial class Menu_Configuracion
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mANTENIMIENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cREARUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPROBANTEFISCALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANZACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTAUSUARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGREGARRNCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANTENIMIENTOToolStripMenuItem,
            this.tRANZACIONESToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mANTENIMIENTOToolStripMenuItem
            // 
            this.mANTENIMIENTOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSUARIOToolStripMenuItem,
            this.cOMPROBANTEFISCALToolStripMenuItem,
            this.aGREGARRNCToolStripMenuItem});
            this.mANTENIMIENTOToolStripMenuItem.Name = "mANTENIMIENTOToolStripMenuItem";
            this.mANTENIMIENTOToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.mANTENIMIENTOToolStripMenuItem.Text = "MANTENIMIENTO";
            // 
            // uSUARIOToolStripMenuItem
            // 
            this.uSUARIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cREARUSUARIOToolStripMenuItem});
            this.uSUARIOToolStripMenuItem.Name = "uSUARIOToolStripMenuItem";
            this.uSUARIOToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.uSUARIOToolStripMenuItem.Text = "USUARIO";
            // 
            // cREARUSUARIOToolStripMenuItem
            // 
            this.cREARUSUARIOToolStripMenuItem.Name = "cREARUSUARIOToolStripMenuItem";
            this.cREARUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cREARUSUARIOToolStripMenuItem.Text = "CREAR USUARIO";
            this.cREARUSUARIOToolStripMenuItem.Click += new System.EventHandler(this.cREARUSUARIOToolStripMenuItem_Click);
            // 
            // cOMPROBANTEFISCALToolStripMenuItem
            // 
            this.cOMPROBANTEFISCALToolStripMenuItem.Name = "cOMPROBANTEFISCALToolStripMenuItem";
            this.cOMPROBANTEFISCALToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.cOMPROBANTEFISCALToolStripMenuItem.Text = "COMPROBANTE FISCAL";
            this.cOMPROBANTEFISCALToolStripMenuItem.Click += new System.EventHandler(this.cOMPROBANTEFISCALToolStripMenuItem_Click);
            // 
            // tRANZACIONESToolStripMenuItem
            // 
            this.tRANZACIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONSULTAUSUARIOToolStripMenuItem});
            this.tRANZACIONESToolStripMenuItem.Name = "tRANZACIONESToolStripMenuItem";
            this.tRANZACIONESToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.tRANZACIONESToolStripMenuItem.Text = "TRANZACIONES";
            // 
            // cONSULTAUSUARIOToolStripMenuItem
            // 
            this.cONSULTAUSUARIOToolStripMenuItem.Name = "cONSULTAUSUARIOToolStripMenuItem";
            this.cONSULTAUSUARIOToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cONSULTAUSUARIOToolStripMenuItem.Text = "CONSULTA USUARIO";
            this.cONSULTAUSUARIOToolStripMenuItem.Click += new System.EventHandler(this.cONSULTAUSUARIOToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // aGREGARRNCToolStripMenuItem
            // 
            this.aGREGARRNCToolStripMenuItem.Name = "aGREGARRNCToolStripMenuItem";
            this.aGREGARRNCToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.aGREGARRNCToolStripMenuItem.Text = "AGREGAR RNC";
            this.aGREGARRNCToolStripMenuItem.Click += new System.EventHandler(this.aGREGARRNCToolStripMenuItem_Click);
            // 
            // Menu_Configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "Menu_Configuracion";
            this.Text = "Menu_Configuracion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_Configuracion_FormClosing);
            this.Controls.SetChildIndex(this.menuStrip, 0);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mANTENIMIENTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cREARUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRANZACIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPROBANTEFISCALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTAUSUARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aGREGARRNCToolStripMenuItem;
    }
}



