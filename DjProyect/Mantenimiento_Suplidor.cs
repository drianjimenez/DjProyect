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
    public partial class Mantenimiento_Suplidor : base_mantenimiento
    {
        public Mantenimiento_Suplidor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salvar();
        }

        public void salvar()
        {
            DataSet dss;

            string cmd = string.Format("Exec actualizasuplidor '{0}','{1}','{2}','{3}'", txtcodigo.Text.Trim(), txtnombre.Text.Trim(), txttelefono.Text.Trim(), txtcelular.Text.Trim());
            dss = utilidades.utility.conectarsupermercado(cmd);


            if (dss.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL GUARDAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show("GUARDADO CORRECTAMENTE");

                blanquear();
                txtcodigo.Text = "";
                txtcodigo.Focus();
            }

        }

        public void blanquear()
        {
            txtnombre.Text = "";
            txttelefono.Text = "";
            txtcelular.Text = "";
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

            blanquear();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            this.txtnombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Consulta_Suplidor doForm = new Consulta_Suplidor();
            if (doForm.ShowDialog() == DialogResult.OK)
            {
                txtcodigo.Text = doForm.codigo.Text;
                txtcodigo.Focus();
                SendKeys.Send("{enter}");
            }
        }
    }
}
