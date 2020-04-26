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
    public partial class Consulta_Departamento : base_consulta
    {
        public Consulta_Departamento()
        {
            InitializeComponent();
        }

        private void Consulta_Departamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'departamentoDataSet.departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.departamentoDataSet.departamento);

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            int pas = dataGridViewX1.CurrentCell.RowIndex;
            codigo.Text = Convert.ToString(dataGridViewX1.Rows[pas].Cells[0].Value);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
