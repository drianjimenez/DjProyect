using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DjProyect
{
    public partial class Cobrar : Form1
    {
        public Cobrar()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataSet dss = utilidades.utility.conectarsupermercado("select *from vista_cobro WHERE cliente =" + codcli.Text.Trim());
            if (dss.Tables[0].Rows.Count > 0)
                {
                    Cobros obj = new Cobros();
                     obj.Show();
                     obj.codcli.Text = codcli.Text;
                     obj.txtusuario.Text = txtusuario.Text;
                     this.Close();
                }
                else
                {
                    MessageBox.Show("ESTE CLIENTE NO TIENE CUENTA PENDIENTE");
                    
                }
            
        }

        private void codcli_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codcli.Text.Trim())) return;
            try
            {
                DataSet ds = utilidades.utility.conectarsupermercado("Select *from  cliente where codigo='" + codcli.Text.Trim() + "'");
                DataSet dss = utilidades.utility.conectarsupermercado("select *from vista_cobro WHERE cliente =" + codcli.Text.Trim());
                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                    return;
                }

                //llenar los datos
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
                    

                }
                else
                {
                    cliente.Text = "";
                }
                
            }
                

            
            catch
            {

            }
        }

        private void codcli_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }
    }
}
