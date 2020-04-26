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
    public partial class Mantenimiento_Cliente : base_mantenimiento
    {
        public Mantenimiento_Cliente()
        {
            InitializeComponent();
        }

        private void superTabControl1_SelectedTabChanged(object sender, DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void salvar()
        {
            DataSet dss;
            int codcli = 0;
            string cmd = string.Format("Exec actualizacliente '{0}','{1}','{2}','{3}','{4}','{5}','{6}'", txtcodigo.Text.Trim(), txtnombre.Text.Trim(), txtcedula.Text.Trim(), txttelefono.Text.Trim(), txtcelular.Text.Trim(), txtdireccion.Text.Trim(), txtsexo.Text.Trim());
            dss = utilidades.utility.conectarsupermercado(cmd);


            if (dss.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL GUARDAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
               // MessageBox.Show("GUARDADO CORRECTAMENTE");
                codcli=Convert.ToInt16(dss.Tables[0].Rows[0]["codigo"].ToString().Trim());
            
            }

            DataSet dsd;

            string cmdd = string.Format("Exec actualizaclientecredito '{0}','{1}','{2}'", codcli, txtaprovacion.Checked, txtlimite.Text.Trim());
            dsd = utilidades.utility.conectarsupermercado(cmdd);


            if (dsd.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL GUARDAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show("GUARDADO CORRECTAMENTE");
                limpiar();

            }
        }

        private void textBoxX8_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodigo.Text.Trim())) return;
            DataSet ds = utilidades.utility.conectarsupermercado("Select *from  cliente where codigo='" + txtcodigo.Text.Trim() + "'");
            DataSet dss = utilidades.utility.conectarsupermercado("Select *from  cliente_credito where cliente='" + txtcodigo.Text.Trim() + "'");
            if (ds.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                return;
            }

            //llenar los datos
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtnombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
                txtcedula.Text = ds.Tables[0].Rows[0]["cedula"].ToString().Trim();
                txttelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString().Trim();
                txtcelular.Text = ds.Tables[0].Rows[0]["celular"].ToString().Trim();
                txtdireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString().Trim();
                txtsexo.Text = ds.Tables[0].Rows[0]["sexo"].ToString().Trim();
              
            }
            if (Convert.ToBoolean(dss.Tables[0].Rows[0]["aprovacion"].ToString().Trim()) == true)
            {
                  txtaprovacion.Checked =Convert.ToBoolean(dss.Tables[0].Rows[0]["aprovacion"]);
                txtlimite.Text = dss.Tables[0].Rows[0]["limite_credito"].ToString().Trim();
            }
            else
            {
                txtaprovacion.Checked = false;
                txtlimite.Text = "";
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            this.txtnombre.CharacterCasing = CharacterCasing.Upper;
            
        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {
            this.txtdireccion.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtsexo_TextChanged(object sender, EventArgs e)
        {
            this.txtsexo.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validartexto(e);
        }

        private void txtsexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validartexto(e);
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }

        private void txtcelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consulta_Cliente doForm = new Consulta_Cliente();
            if (doForm.ShowDialog() == DialogResult.OK)
            {
                txtcodigo.Text = doForm.codigo.Text;
                txtnombre.Focus();
                SendKeys.Send("{enter}");
            }
        }

        public void limpiar()
        {
            txtaprovacion.Checked = false;
            txtcedula.Text = "";
            txtcelular.Text = "";
            txtcodigo.Text = "0";
            txtdireccion.Text = "";
            txtnombre.Text = "";
            txtsexo.Text = "";
            txttelefono.Text = "";
            txtlimite.Text = "";

        }
    }
}
