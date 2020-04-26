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
    public partial class Reporte_Compra : base_reporte
    {
        public Reporte_Compra()
        {
            InitializeComponent();
        }

        private void Reporte_Compra_Load(object sender, EventArgs e)
        {

        }

        private void textBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            reimprimir();
        }

        public void reimprimir()
        {
            DataSet tabla = new DataSet();
            string comandos = " select *from vista_compra_detallada";
            //int pas = dataGridView1.CurrentCell.RowIndex;
            //textBox1.Text = Convert.ToString(dataGridView1.Rows[pas].Cells[0].Value);

            comandos += " where codigo='" + txtcodigo.Text.Trim() + "'";

            tabla = utilidades.utility.conectarsupermercado(comandos);

            if (tabla.Tables[0].Rows.Count > 0)
            {
             Mostrar_Compra mostrar = new Mostrar_Compra();

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
            //otro
           
        }
    }
}
