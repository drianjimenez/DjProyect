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
    public partial class Mantenimiento_Usuario : base_mantenimiento
    {
        public Mantenimiento_Usuario()
        {
            InitializeComponent();
        }

        private void Mantenimiento_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sucursalDataSet.sucursal' Puede moverla o quitarla según sea necesario.
            this.sucursalTableAdapter.Fill(this.sucursalDataSet.sucursal);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxX3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxX4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            salvar();
        }

        public void salvar()
        {
            DataSet dss;

            string cmd = string.Format("Exec actualizausuario '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'", txtusuario.Text.Trim(), txtcontrasena.Text.Trim(), txtnombre.Text.Trim(), comboBoxEx1.Text, chfacturacion.Checked, chcompra.Checked, chinventario.Checked, chcxc.Checked, chconfiguracion.Checked, txtsucursal.SelectedValue);
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
                txtusuario.Text = "";
                txtusuario.Focus();
            }

          }

        
        public void blanquear()
        {
            
            txtusuario.Text = "";
            txtcontrasena.Text = "";
            txtrepetir.Text = "";
            txtnombre.Text = "";
            comboBoxEx1.Text = "";
            chcompra.Checked = false;
            chfacturacion.Checked = false;
            chreporte.Checked = false;
            chconfiguracion.Checked = false;
            chcxc.Checked = false;
            chinventario.Checked = false;
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            this.txtusuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {
            this.txtusuario.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
