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
    public partial class Reporte_Compra_Detallada : base_reporte
    {
        public Reporte_Compra_Detallada()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            reimprimir();
        }


        public void reimprimir()
        {
            DataSet tabla = new DataSet();
            string comandos = " select *from vista_compra";
            //int pas = dataGridView1.CurrentCell.RowIndex;
            //textBox1.Text = Convert.ToString(dataGridView1.Rows[pas].Cells[0].Value);
            comandos += " where fecha_registro>='" + dateTimePicker1.Value.ToShortDateString()+ "'";
            comandos += " and fecha_registro<='" + dateTimePicker2.Value.ToShortDateString() + "'";
            comandos += " and usuario='" + comboBox1.SelectedValue + "'";
            if (string.IsNullOrEmpty(txtsuplidor.Text.Trim()))
            {   
            }
            else
            {
                comandos += " and suplidor='" + txtsuplidor.Text.Trim() + "'";
            }
            tabla = utilidades.utility.conectarsupermercado(comandos);
            //otro
            if (tabla.Tables[0].Rows.Count > 0)
            {
                
             Mostrar_Compra_Detallada mostrar = new Mostrar_Compra_Detallada();

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

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Consulta_Suplidor doForm = new Consulta_Suplidor();
            if (doForm.ShowDialog() == DialogResult.OK)
            {
                txtsuplidor.Text = doForm.codigo.Text;
                txtsuplidor.Focus();
                SendKeys.Send("{enter}");
            }
        }

        private void txtsuplidor_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsuplidor.Text.Trim())) return;
            DataSet ds = utilidades.utility.conectarsupermercado("Select *from  suplidor where codigo='" + txtsuplidor.Text.Trim() + "'");

            if (ds.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                return;
            }

            //llenar los datos
            if (ds.Tables[0].Rows.Count > 0)
            {
                nombresuplidor.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();

            }

            else
            {

                nombresuplidor.Text = "";

            }
        }

        private void Reporte_Compra_Detallada_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuarioDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.usuarioDataSet.usuario);

        }
    }
}
