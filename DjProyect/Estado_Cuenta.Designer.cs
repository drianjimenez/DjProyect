namespace DjProyect
{
    partial class Estado_Cuenta
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
            this.cliente = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.codcli = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(70, 142);
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(400, 142);
            this.salir.TabIndex = 2;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(95, 84);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 55;
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
            this.cliente.Location = new System.Drawing.Point(243, 84);
            this.cliente.Name = "cliente";
            this.cliente.PreventEnterBeep = true;
            this.cliente.Size = new System.Drawing.Size(227, 20);
            this.cliente.TabIndex = 54;
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
            this.codcli.ForeColor = System.Drawing.Color.Black;
            this.codcli.Location = new System.Drawing.Point(176, 84);
            this.codcli.Name = "codcli";
            this.codcli.PreventEnterBeep = true;
            this.codcli.Size = new System.Drawing.Size(61, 20);
            this.codcli.TabIndex = 0;
            this.codcli.TextChanged += new System.EventHandler(this.codcli_TextChanged);
            this.codcli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codcli_KeyPress);
            // 
            // Estado_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 222);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.codcli);
            this.Name = "Estado_Cuenta";
            this.Text = "Estado de Cuenta";
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.codcli, 0);
            this.Controls.SetChildIndex(this.cliente, 0);
            this.Controls.SetChildIndex(this.labelX5, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX cliente;
        private DevComponents.DotNetBar.Controls.TextBoxX codcli;
    }
}