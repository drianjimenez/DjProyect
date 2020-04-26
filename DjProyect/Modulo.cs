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
    public partial class Modulo : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Modulo()
        {
            InitializeComponent();
        }

        private void Modulo_Load(object sender, EventArgs e)
        {
            
            DataSet ds = utilidades.utility.conectarsupermercado("Select *from  permiso where usuario='" + txtusuario.Text.Trim() + "'");

            if (ds.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                return;
            }
            
            //llenar los datos
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (false== Convert.ToBoolean(ds.Tables[0].Rows[0]["inventario"]))
                {
                    btninventario.Enabled = false;
                }

                if (false == Convert.ToBoolean(ds.Tables[0].Rows[0]["facturacion"]))
                {
                    btnfacturacion.Enabled = false;
                }
                if (false == Convert.ToBoolean(ds.Tables[0].Rows[0]["configuracion"]))
                {
                    btnconfiguracion.Enabled = false;
                }
                if (false == Convert.ToBoolean(ds.Tables[0].Rows[0]["cxc"]))
                {
                    btncxc.Enabled = false;
                }
                if (false == Convert.ToBoolean(ds.Tables[0].Rows[0]["compra"]))
                {
                    btncompra.Enabled = false;
                }
               
            }




            
        }

        private void metroTileItem2_Click(object sender, EventArgs e)
        {

            Menu_Inventario obj = new Menu_Inventario();
            obj.txtusu.Text = txtusuario.Text;
            obj.Show();
             this.Hide();
        }

        private void Modulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncompra_Click(object sender, EventArgs e)
        {
            Menu_Compra obj = new Menu_Compra();
            obj.txtusu.Text = txtusuario.Text;
            obj.Show();
            this.Hide();
        }

        private void btnfacturacion_Click(object sender, EventArgs e)
        {
            Menu_Facturacion obj = new Menu_Facturacion();
            obj.txtusu.Text = txtusuario.Text;
            obj.Show();
            this.Hide();
           // Application.Exit();
        }

        private void btnconfiguracion_Click(object sender, EventArgs e)
        {
            Menu_Configuracion obj = new Menu_Configuracion();
            obj.txtusu.Text = txtusuario.Text;
            obj.Show();
            this.Hide();
        }

        private void btncxc_Click(object sender, EventArgs e)
        {
            Menu_CXC obj = new Menu_CXC();
            obj.txtusu.Text = txtusuario.Text;
            obj.Show();
            this.Hide();
        }

        private void metroTileItem1_Click(object sender, EventArgs e)
        {
            Menu_CXP obj = new Menu_CXP();
            obj.txtusu.Text = txtusuario.Text;
            obj.Show();
            this.Hide();
        }
    }
}