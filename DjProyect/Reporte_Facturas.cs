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
    public partial class Reporte_Facturas : base_reporte
    {
        public Reporte_Facturas()
        {
            InitializeComponent();
        }

        private void Reporte_Facturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuarioDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.usuarioDataSet.usuario);

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            reimprimir();
        }

        public void reimprimir()
        {
            DataSet tabla = new DataSet();
            string comandos = " select *from vista_facturasindetalle";
            //int pas = dataGridView1.CurrentCell.RowIndex;
            //textBox1.Text = Convert.ToString(dataGridView1.Rows[pas].Cells[0].Value);
            comandos += " where fecha>='" + dateTimePicker1.Value.ToShortDateString() + "'";
            comandos += " and fecha<='" + dateTimePicker2.Value.ToShortDateString() + "'";
            comandos += " and usuario='" + comboBox1.SelectedValue + "'";
            tabla = utilidades.utility.conectarsupermercado(comandos);

            //otro
            if (tabla.Tables[0].Rows.Count > 0)
            {

                Mostrar_factura_Resumida mostrar = new Mostrar_factura_Resumida();

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
