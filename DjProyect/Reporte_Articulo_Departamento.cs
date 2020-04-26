using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DjProyect
{
    public partial class Reporte_Articulo_Departamento : base_reporte
    {
        public Reporte_Articulo_Departamento()
        {
            InitializeComponent();
        }

        private void Reporte_Articulo_Departamento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'departamentoDataSet.departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.departamentoDataSet.departamento);

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            reimprimir();
        }

        public void reimprimir()
        {
            DataSet tabla = new DataSet();
            string comandos = " select *from vista_articulo_departamento";
            //int pas = dataGridView1.CurrentCell.RowIndex;
            //textBox1.Text = Convert.ToString(dataGridView1.Rows[pas].Cells[0].Value);
            if (string.IsNullOrEmpty(comboBox1.Text.Trim()))
            {

            }
            else
            {
                comandos += "  where nombre='" + comboBox1.Text.Trim() + "'";
            }
            

            tabla = utilidades.utility.conectarsupermercado(comandos);

            if (tabla.Tables[0].Rows.Count > 0)
            {
                Mostrar_Articulo_Departamento mostrar = new Mostrar_Articulo_Departamento();

                ReportDataSource st = new ReportDataSource("DataSet1", tabla.Tables[0]);
                mostrar.reportViewer1.LocalReport.DataSources.Clear();
                mostrar.reportViewer1.LocalReport.DataSources.Add(st);
                mostrar.reportViewer1.RefreshReport();
                mostrar.ShowDialog();
                mostrar.reportViewer1.Reset();

            }
            else
            {
                MessageBox.Show("ESTA CONSULTA NO MUESTRA NINGUNA INFORMACION");
                return;

            }
        }
    }
}
