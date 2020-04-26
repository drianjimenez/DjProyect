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
    public partial class Desglose : Form1
    {
        public Desglose()
        {
            InitializeComponent();
        }

        private void Desglose_Load(object sender, EventArgs e)
        {
            //Facturacion obj=new Facturacion();
           // impo.Text = obj.impo.Text.Trim();
            
        }

        private void impo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(txtdevuelta.Text.Trim())>=0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("MONTO INCORRECTO","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumerodecimal(e);
        }

        private void textBoxX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumerodecimal(e);
        }

        private void textBoxX3_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumerodecimal(e);
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            evaluar();
        }

        private void txttarjeta_TextChanged(object sender, EventArgs e)
        {
            evaluar();
        }

        private void txtcheque_TextChanged(object sender, EventArgs e)
        {
            evaluar();
        }

        public void evaluar()
        {
            double rec = 0;
            double dev = 0;
            double mon = 0;

            //if (string.IsNullOrEmpty(txtefectivo.Text.Trim())) return;
            if (string.IsNullOrEmpty(impo.Text.Trim())) return;
            mon = Convert.ToDouble(impo.Text.Trim());
            if (string.IsNullOrEmpty(txtefectivo.Text.Trim())) return;
            else { rec = Convert.ToDouble(txtefectivo.Text.Trim()); }
            if (string.IsNullOrEmpty(txtcheque.Text.Trim())) return;
            else
            {
                rec = rec + Convert.ToDouble(txtcheque.Text.Trim());
            }
            if (string.IsNullOrEmpty(txttarjeta.Text.Trim())) return;
            else
            {
                rec = rec + Convert.ToDouble(txttarjeta.Text.Trim());
            }


            dev = rec - mon;
            dev = Math.Round(dev, 2);
            txtdevuelta.Text = Convert.ToString(dev);
        }
    }
}
