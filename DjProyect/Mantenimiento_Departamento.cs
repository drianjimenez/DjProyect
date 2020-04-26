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
    public partial class Mantenimiento_Departamento : base_mantenimiento
    {
        public Mantenimiento_Departamento()
        {
            InitializeComponent();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            this.txtnombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodigo.Text.Trim())) return;
            DataSet ds = utilidades.utility.conectarsupermercado("Select *from  departamento where codigo='" + txtcodigo.Text.Trim() + "'");

            if (ds.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                return;
            }

            //llenar los datos
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtnombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();

            }

            else
            {

                txtnombre.Text = "";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salvar();
        }

        public void salvar()
        {
            DataSet dss;

            string cmd = string.Format("Exec actualizadepartamento '{0}','{1}'", txtcodigo.Text.Trim(), txtnombre.Text.Trim());
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
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            blanquear();
            txtcodigo.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consulta_Departamento doForm = new Consulta_Departamento();
            if (doForm.ShowDialog() == DialogResult.OK)
            {
                txtcodigo.Text = doForm.codigo.Text;
                txtcodigo.Focus();
                SendKeys.Send("{enter}");
            }
        }
    }
}
