namespace DjProyect
{
    partial class base_mantenimiento
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
            this.button4 = new DevComponents.DotNetBar.ButtonX();
            this.button3 = new DevComponents.DotNetBar.ButtonX();
            this.button2 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button4.Location = new System.Drawing.Point(286, 253);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 36);
            this.button4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button4.Symbol = "";
            this.button4.TabIndex = 22;
            this.button4.Text = "Consultar";
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button3.Location = new System.Drawing.Point(173, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 36);
            this.button3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button3.Symbol = "";
            this.button3.TabIndex = 23;
            this.button3.Text = "Cancelar";
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button2.Location = new System.Drawing.Point(53, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 36);
            this.button2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button2.Symbol = "";
            this.button2.TabIndex = 24;
            this.button2.Text = "Guardar";
            this.button2.Click += new System.EventHandler(this.buttonX4_Click);
            // 
            // base_mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 321);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Name = "base_mantenimiento";
            this.Text = "base_mantenimiento";
            this.Load += new System.EventHandler(this.base_mantenimiento_Load);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.ButtonX button4;
        public DevComponents.DotNetBar.ButtonX button3;
        public DevComponents.DotNetBar.ButtonX button2;

    }
}