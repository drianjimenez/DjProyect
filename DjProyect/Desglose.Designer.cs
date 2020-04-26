namespace DjProyect
{
    partial class Desglose
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtefectivo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txttarjeta = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtcheque = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.impo = new System.Windows.Forms.TextBox();
            this.txtdevuelta = new System.Windows.Forms.TextBox();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(386, 308);
            this.salir.TabIndex = 4;
            this.salir.Text = "Cancelar";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Red;
            this.labelX1.Location = new System.Drawing.Point(373, 18);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 37);
            this.labelX1.TabIndex = 35;
            this.labelX1.Text = "TOTAL";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(89, 308);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(87, 36);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "";
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "Guardar";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(38, 95);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 37;
            this.labelX2.Text = "AFECTIVO";
            // 
            // txtefectivo
            // 
            this.txtefectivo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtefectivo.Border.Class = "TextBoxBorder";
            this.txtefectivo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtefectivo.DisabledBackColor = System.Drawing.Color.White;
            this.txtefectivo.ForeColor = System.Drawing.Color.Black;
            this.txtefectivo.Location = new System.Drawing.Point(104, 98);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.PreventEnterBeep = true;
            this.txtefectivo.Size = new System.Drawing.Size(121, 20);
            this.txtefectivo.TabIndex = 0;
            this.txtefectivo.Text = "0.00";
            this.txtefectivo.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            this.txtefectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX1_KeyPress);
            // 
            // txttarjeta
            // 
            this.txttarjeta.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txttarjeta.Border.Class = "TextBoxBorder";
            this.txttarjeta.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txttarjeta.DisabledBackColor = System.Drawing.Color.White;
            this.txttarjeta.ForeColor = System.Drawing.Color.Black;
            this.txttarjeta.Location = new System.Drawing.Point(104, 166);
            this.txttarjeta.Name = "txttarjeta";
            this.txttarjeta.PreventEnterBeep = true;
            this.txttarjeta.Size = new System.Drawing.Size(121, 20);
            this.txttarjeta.TabIndex = 1;
            this.txttarjeta.Text = "0.00";
            this.txttarjeta.TextChanged += new System.EventHandler(this.txttarjeta_TextChanged);
            this.txttarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX2_KeyPress);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(38, 163);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 39;
            this.labelX3.Text = "TARJETA";
            // 
            // txtcheque
            // 
            this.txtcheque.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtcheque.Border.Class = "TextBoxBorder";
            this.txtcheque.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcheque.DisabledBackColor = System.Drawing.Color.White;
            this.txtcheque.ForeColor = System.Drawing.Color.Black;
            this.txtcheque.Location = new System.Drawing.Point(104, 232);
            this.txtcheque.Name = "txtcheque";
            this.txtcheque.PreventEnterBeep = true;
            this.txtcheque.Size = new System.Drawing.Size(121, 20);
            this.txtcheque.TabIndex = 2;
            this.txtcheque.Text = "0.00";
            this.txtcheque.TextChanged += new System.EventHandler(this.txtcheque_TextChanged);
            this.txtcheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX3_KeyPress);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(38, 229);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 41;
            this.labelX4.Text = "CHEQUE";
            // 
            // impo
            // 
            this.impo.Enabled = false;
            this.impo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.impo.Location = new System.Drawing.Point(479, 18);
            this.impo.Multiline = true;
            this.impo.Name = "impo";
            this.impo.Size = new System.Drawing.Size(163, 37);
            this.impo.TabIndex = 43;
            this.impo.TextChanged += new System.EventHandler(this.impo_TextChanged);
            // 
            // txtdevuelta
            // 
            this.txtdevuelta.Enabled = false;
            this.txtdevuelta.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdevuelta.Location = new System.Drawing.Point(478, 241);
            this.txtdevuelta.Multiline = true;
            this.txtdevuelta.Name = "txtdevuelta";
            this.txtdevuelta.Size = new System.Drawing.Size(163, 37);
            this.txtdevuelta.TabIndex = 45;
            this.txtdevuelta.Text = "0.00";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Red;
            this.labelX5.Location = new System.Drawing.Point(312, 241);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(160, 37);
            this.labelX5.TabIndex = 44;
            this.labelX5.Text = "DEVUELTA";
            // 
            // Desglose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 389);
            this.Controls.Add(this.txtdevuelta);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.impo);
            this.Controls.Add(this.txtcheque);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txttarjeta);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtefectivo);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.labelX1);
            this.Name = "Desglose";
            this.Text = "Desglose";
            this.Load += new System.EventHandler(this.Desglose_Load);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.txtefectivo, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.txttarjeta, 0);
            this.Controls.SetChildIndex(this.labelX4, 0);
            this.Controls.SetChildIndex(this.txtcheque, 0);
            this.Controls.SetChildIndex(this.impo, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.Controls.SetChildIndex(this.txtdevuelta, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        public System.Windows.Forms.TextBox impo;
        public System.Windows.Forms.TextBox txtdevuelta;
        private DevComponents.DotNetBar.LabelX labelX5;
        public DevComponents.DotNetBar.Controls.TextBoxX txtefectivo;
        public DevComponents.DotNetBar.Controls.TextBoxX txttarjeta;
        public DevComponents.DotNetBar.Controls.TextBoxX txtcheque;
    }
}