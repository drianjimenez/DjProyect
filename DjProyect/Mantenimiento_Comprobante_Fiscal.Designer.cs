namespace DjProyect
{
    partial class Mantenimiento_Comprobante_Fiscal
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
            this.inicial = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tipo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.codigo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.final = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(424, 42);
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 253);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(23, 86);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 25;
            this.labelX1.Text = "Tipo";
            // 
            // inicial
            // 
            // 
            // 
            // 
            this.inicial.Border.Class = "TextBoxBorder";
            this.inicial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.inicial.Location = new System.Drawing.Point(125, 137);
            this.inicial.MaxLength = 99999999;
            this.inicial.Name = "inicial";
            this.inicial.PreventEnterBeep = true;
            this.inicial.Size = new System.Drawing.Size(115, 20);
            this.inicial.TabIndex = 26;
            this.inicial.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            this.inicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX1_KeyPress);
            // 
            // tipo
            // 
            this.tipo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tipo.Border.Class = "TextBoxBorder";
            this.tipo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tipo.DisabledBackColor = System.Drawing.Color.White;
            this.tipo.ForeColor = System.Drawing.Color.Black;
            this.tipo.Location = new System.Drawing.Point(191, 89);
            this.tipo.Name = "tipo";
            this.tipo.PreventEnterBeep = true;
            this.tipo.Size = new System.Drawing.Size(202, 20);
            this.tipo.TabIndex = 47;
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
            this.codigo.Location = new System.Drawing.Point(123, 89);
            this.codigo.Name = "codigo";
            this.codigo.PreventEnterBeep = true;
            this.codigo.Size = new System.Drawing.Size(53, 20);
            this.codigo.TabIndex = 46;
            this.codigo.TextChanged += new System.EventHandler(this.txtsuplidor_TextChanged);
            this.codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_KeyPress);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(23, 134);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(96, 23);
            this.labelX2.TabIndex = 49;
            this.labelX2.Text = "Secuencia Inicial";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(23, 184);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(96, 23);
            this.labelX3.TabIndex = 50;
            this.labelX3.Text = "Secuencia Final";
            // 
            // final
            // 
            // 
            // 
            // 
            this.final.Border.Class = "TextBoxBorder";
            this.final.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.final.Location = new System.Drawing.Point(125, 187);
            this.final.MaxLength = 99999999;
            this.final.Name = "final";
            this.final.PreventEnterBeep = true;
            this.final.Size = new System.Drawing.Size(115, 20);
            this.final.TabIndex = 51;
            this.final.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX2_KeyPress);
            // 
            // Mantenimiento_Comprobante_Fiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 321);
            this.Controls.Add(this.final);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.inicial);
            this.Controls.Add(this.labelX1);
            this.Name = "Mantenimiento_Comprobante_Fiscal";
            this.Text = "Mantenimiento_Comprobante_Fiscal";
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.inicial, 0);
            this.Controls.SetChildIndex(this.codigo, 0);
            this.Controls.SetChildIndex(this.tipo, 0);
            this.Controls.SetChildIndex(this.labelX2, 0);
            this.Controls.SetChildIndex(this.labelX3, 0);
            this.Controls.SetChildIndex(this.final, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX inicial;
        private DevComponents.DotNetBar.Controls.TextBoxX tipo;
        private DevComponents.DotNetBar.Controls.TextBoxX codigo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX final;
    }
}