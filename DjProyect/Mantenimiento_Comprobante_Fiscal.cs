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
    public partial class Mantenimiento_Comprobante_Fiscal : base_mantenimiento
    {
        public Mantenimiento_Comprobante_Fiscal()
        {
            InitializeComponent();
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }

        private void textBoxX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }

        private void txtsuplidor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codigo.Text.Trim())) return;
            DataSet ds = utilidades.utility.conectarsupermercado("Select *from  tipo_comprobante where cod_tipo='" + codigo.Text.Trim() + "'");
            if (ds.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                return;
            }

            //llenar los datos
            if (ds.Tables[0].Rows.Count > 0)
            {
                tipo.Text = ds.Tables[0].Rows[0]["tipo"].ToString().Trim();
                inicial.Text = ds.Tables[0].Rows[0]["secuencia"].ToString().Trim();
                final.Text = ds.Tables[0].Rows[0]["final"].ToString().Trim();
                

            }
            else
            {
                tipo.Text = "";
                inicial.Text = "";
                final.Text = "";
            }
            
        }

        private void codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            codigo.Text = "";
            tipo.Text = "";
            inicial.Text = "";
            final.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt64(final.Text.Trim())>Convert.ToInt64(inicial.Text.Trim()))
            {
                salvar();
            }
            else
            {
                MessageBox.Show("EL VALOR FINAL NO PUEDE SER MENOR QUE EL INICIAL","ERROR AL GUARDAR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        public void salvar()
        {
            DataSet ds = utilidades.utility.conectarsupermercado("update tipo_comprobante set secuencia='" + inicial.Text.Trim() + "', final='" + final.Text.Trim() + "' where cod_tipo='"+codigo.Text.Trim()+"'");
            MessageBox.Show("GUARDADO CORREACTAMENTE");
        }
    }
}
