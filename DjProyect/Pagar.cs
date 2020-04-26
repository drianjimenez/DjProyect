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
    public partial class Pagar : Form1
    {
        public Pagar()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataSet dss = utilidades.utility.conectarsupermercado("select *from vista_pagar_compra WHERE estado='activa' and suplidor =" + codsup.Text.Trim());
            if (dss.Tables[0].Rows.Count > 0)
            {
                Pagar_Factura obj = new Pagar_Factura();
                obj.Show();
                obj.codsup.Text = codsup.Text;
                obj.txtusuario.Text = txtusuario.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("ESTE SUPLIDOR NO TIENE CUENTA PENDIENTE");

            }
        }

        private void codsup_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codsup.Text.Trim())) return;
            try
            {
                DataSet ds = utilidades.utility.conectarsupermercado("Select *from  suplidor where codigo='" + codsup.Text.Trim() + "'");
                DataSet dss = utilidades.utility.conectarsupermercado("select *from vista_cobro WHERE cliente =" + codsup.Text.Trim());
                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                    return;
                }

                //llenar los datos
                if (ds.Tables[0].Rows.Count > 0)
                {
                    suplidor.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();


                }
                else
                {
                    suplidor.Text = "";
                }

            }



            catch
            {

            }
        }

        private void codsup_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }
    }
}
