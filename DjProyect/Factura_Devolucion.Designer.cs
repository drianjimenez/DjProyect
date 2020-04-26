namespace DjProyect
{
    partial class Factura_Devolucion
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
            this.numero = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // codigo
            // 
            // 
            // 
            // 
            this.codigo.Border.Class = "TextBoxBorder";
            this.codigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.codigo.Enabled = false;
            this.codigo.Location = new System.Drawing.Point(297, 23);
            this.codigo.Size = new System.Drawing.Size(55, 20);
            this.codigo.Visible = false;
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(46, 138);
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(265, 138);
            this.salir.TabIndex = 2;
            // 
            // numero
            // 
            this.numero.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.numero.Border.Class = "TextBoxBorder";
            this.numero.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.numero.DisabledBackColor = System.Drawing.Color.White;
            this.numero.ForeColor = System.Drawing.Color.Black;
            this.numero.Location = new System.Drawing.Point(164, 78);
            this.numero.Name = "numero";
            this.numero.PreventEnterBeep = true;
            this.numero.Size = new System.Drawing.Size(100, 20);
            this.numero.TabIndex = 0;
            this.numero.TextChanged += new System.EventHandler(this.numero_TextChanged);
            this.numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_KeyPress);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(83, 78);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 27;
            this.labelX1.Text = "FACTURA#";
            // 
            // Factura_Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 206);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.labelX1);
            this.Name = "Factura_Devolucion";
            this.Text = "DEVOLUCION";
            this.Load += new System.EventHandler(this.Factura_Devolucion_Load);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.codigo, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.numero, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX numero;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}