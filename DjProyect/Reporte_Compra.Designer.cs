namespace DjProyect
{
    partial class Reporte_Compra
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
            this.txtcodigo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // buttonX1
            // 
            this.buttonX1.Location = new System.Drawing.Point(63, 164);
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(393, 164);
            this.salir.TabIndex = 2;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(147, 94);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 23;
            this.labelX1.Text = "Documento #";
            // 
            // txtcodigo
            // 
            // 
            // 
            // 
            this.txtcodigo.Border.Class = "TextBoxBorder";
            this.txtcodigo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtcodigo.Location = new System.Drawing.Point(228, 94);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PreventEnterBeep = true;
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 0;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxX1_KeyPress);
            // 
            // Reporte_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 234);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.labelX1);
            this.Name = "Reporte_Compra";
            this.Text = "Reporte_Compra";
            this.Load += new System.EventHandler(this.Reporte_Compra_Load);
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.buttonX1, 0);
            this.Controls.SetChildIndex(this.labelX1, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtcodigo;

    }
}