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
    public partial class Consulta_Compra : base_consulta
    {
        public Consulta_Compra()
        {
            InitializeComponent();
        }

        private void Consulta_Compra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'compraDataSet.vista_compra' Puede moverla o quitarla según sea necesario.
            this.vista_compraTableAdapter.Fill(this.compraDataSet.vista_compra);
       

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            selecionar();
        }

        public void selecionar()
        {
            int pas = dataGridView.CurrentCell.RowIndex;
            codigo.Text = Convert.ToString(dataGridView.Rows[pas].Cells[0].Value);
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    selecionar();
                    break;
            }
        }
    }
}
