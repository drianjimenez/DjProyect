namespace DjProyect
{
    partial class Agregar_RNC_DesdeArchivo
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new DevComponents.DotNetBar.ButtonX();
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nombrearchivo = new System.Windows.Forms.TextBox();
            this.label1 = new utilidades.label(this.components);
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(275, 212);
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button2.Location = new System.Drawing.Point(44, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 36);
            this.button2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.button2.Symbol = "";
            this.button2.TabIndex = 33;
            this.button2.Text = "Generar";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(83, 147);
            this.progreso.Maximum = 800000;
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(248, 23);
            this.progreso.TabIndex = 34;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivo TXT (*txt)|*txt";
            // 
            // nombrearchivo
            // 
            this.nombrearchivo.Location = new System.Drawing.Point(87, 88);
            this.nombrearchivo.Name = "nombrearchivo";
            this.nombrearchivo.Size = new System.Drawing.Size(219, 20);
            this.nombrearchivo.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Archivo";
            this.label1.Validar = false;
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Location = new System.Drawing.Point(307, 84);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(34, 26);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.Symbol = "";
            this.buttonX2.TabIndex = 37;
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // Agregar_RNC_DesdeArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 300);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombrearchivo);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.button2);
            this.Name = "Agregar_RNC_DesdeArchivo";
            this.Text = "AGREGAR RNC DESDE ARCHIVO";
            this.Controls.SetChildIndex(this.salir, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.progreso, 0);
            this.Controls.SetChildIndex(this.nombrearchivo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonX2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevComponents.DotNetBar.ButtonX button2;
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox nombrearchivo;
        private utilidades.label label1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
    }
}