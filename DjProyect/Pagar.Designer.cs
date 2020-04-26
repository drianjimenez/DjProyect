namespace DjProyect
{
    partial class Pagar
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
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.suplidor = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.codsup = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtusuario = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(384, 146);
            this.salir.TabIndex = 2;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(57, 83);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 61;
            this.labelX5.Text = "SUPLIDOR";
            // 
            // suplidor
            // 
            this.suplidor.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.suplidor.Border.Class = "TextBoxBorder";
            this.suplidor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.suplidor.DisabledBackColor = System.Drawing.Color.White;
            this.suplidor.ForeColor = System.Drawing.Color.Black;
            this.suplidor.Location = new System.Drawing.Point(205, 83);
            this.suplidor.Name = "suplidor";
            this.suplidor.PreventEnterBeep = true;
            this.suplidor.Size = new System.Drawing.Size(281, 20);
            this.suplidor.TabIndex = 60;
            // 
            // codsup
            // 
            this.codsup.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.codsup.Border.Class = "TextBoxBorder";
            this.codsup.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.codsup.DisabledBackColor = System.Drawing.Color.White;
            this.codsup.ForeColor = System.Drawing.Color.Black;
            this.codsup.Location = new System.Drawing.Point(138, 83);
            this.codsup.Name = "codsup";
            this.codsup.PreventEnterBeep = true;
            this.codsup.Size = new System.Drawing.Size(61, 20);
            this.codsup.TabIndex = 0;
            this.codsup.TextChanged += new System.EventHandler(this.codsup_TextChanged);
            this.codsup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codsup_KeyPress);
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
            this.txtusuario.Enabled = false;
            this.txtusuario.ForeColor = System.Drawing.Color.Black;
            this.txtusuario.Location = new System.Drawing.Point(252, 37);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PreventEnterBeep = true;
            this.txtusuario.Size = new System.Drawing.Size(61, 20);
            this.txtusuario.TabIndex = 62;
            this.txtusuario.Visible = false;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(45, 146);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(87, 36);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Text = "SELECCIONAR";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // Pagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 207);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.suplidor);
            this.Controls.Add(this.codsup);
            this.Name = "Pagar";
            this.Text = "Pagar Factura";
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.codsup, 0);
            this.Controls.SetChildIndex(this.suplidor, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.txtusuario, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX suplidor;
        public DevComponents.DotNetBar.Controls.TextBoxX codsup;
        public DevComponents.DotNetBar.Controls.TextBoxX txtusuario;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}