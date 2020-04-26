using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DjProyect
{
    public partial class login : Form1
    {
        public login()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusuario.Text.Trim())) return;
            DataSet ds = utilidades.utility.conectarsupermercado("Select *from  usuario where usuario='" + txtusuario.Text.Trim() + "'" + "and contrasena='" + txtcontrasena.Text.Trim() + "'");

            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("USUARIO INCORRECTO");
                return;

            }
            else
            {
                Modulo obj = new Modulo();
              
                obj.txtusuario.Text = Convert.ToString(txtusuario.Text.Trim());
                Program.user = txtusuario.Text;
                obj.Show();
                this.Hide();



            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            this.txtusuario.CharacterCasing = CharacterCasing.Upper;
           
        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    base.ProcessDialogKey(Keys.Tab);
                    break;
            }
        }

        private void txtcontrasena_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcontrasena_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    base.ProcessDialogKey(Keys.Tab);
                    break;
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}