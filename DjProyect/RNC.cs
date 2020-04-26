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
    public partial class RNC : Form1

    {
        public RNC()
        {
            InitializeComponent();
        }

        private void RNC_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'comprobante_venta._comprobante_venta' Puede moverla o quitarla según sea necesario.
            this.comprobante_ventaTableAdapter.Fill(this.comprobante_venta._comprobante_venta);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.comprobante_ventaTableAdapter.FillBy(this.comprobante_venta._comprobante_venta);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            selecionar();
            
        }
        public void selecionar()
        {
            if (this.dataGridView1.CurrentRow.Cells[0].Value.ToString() != "2")
            {
                if (string.IsNullOrEmpty(rn.Text.Trim()) || string.IsNullOrEmpty(nom.Text.Trim()))
                {
                    errorProvider1.SetError(rn, (string.IsNullOrEmpty(rn.Text.Trim())) ? "Campos obligatorios" : "");

                    MessageBox.Show("NO PUEDE DEJAR LOS CAMPOS DEL COMPROBANTE VACIOS", "ATENCCION", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    Close();
                }

            }
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void rn_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rn.Text.Trim())) return;
            DataSet ds = utilidades.utility.conectarsupermercado("Select *from  consultar_rnc where rnc_cedula='" + rn.Text.Trim() + "'");

            if (ds.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                return;
            }

            //llenar los datos
            if (ds.Tables[0].Rows.Count > 0)
            {
                nom.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();
            }
            else
            {
                nom.Text = "";
            }
        }

        private void rn_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
            
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    selecionar();
                    break;
            }
        }

        private void nom_TextChanged(object sender, EventArgs e)
        {
            this.nom.CharacterCasing = CharacterCasing.Upper;
        }

        private void rn_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    
                    break;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
