namespace DjProyect
{
    partial class Form1
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
            this.salir = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.salir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.salir.Location = new System.Drawing.Point(413, 253);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(87, 36);
            this.salir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.salir.Symbol = "";
            this.salir.TabIndex = 21;
            this.salir.Text = "Salir";
            this.salir.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(571, 324);
            this.Controls.Add(this.salir);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.ButtonX salir;








    }
}

