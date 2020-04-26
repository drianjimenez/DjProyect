namespace DjProyect
{
    partial class base_consulta
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
            this.codigo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(416, 265);
            // 
            // codigo
            // 
            this.codigo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.codigo.Border.Class = "TextBoxBorder";
            this.codigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.codigo.DisabledBackColor = System.Drawing.Color.White;
            this.codigo.ForeColor = System.Drawing.Color.Black;
            this.codigo.Location = new System.Drawing.Point(23, 63);
            this.codigo.Name = "codigo";
            this.codigo.PreventEnterBeep = true;
            this.codigo.Size = new System.Drawing.Size(409, 20);
            this.codigo.TabIndex = 22;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(49, 265);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(87, 36);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 23;
            this.buttonX1.Text = "Seleccionar";
            // 
            // base_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 324);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.codigo);
            this.Name = "base_consulta";
            this.Text = "base_consulta";
            this.Load += new System.EventHandler(this.base_consulta_Load);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.codigo, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.Controls.TextBoxX codigo;
        public DevComponents.DotNetBar.ButtonX buttonX1;

    }
}