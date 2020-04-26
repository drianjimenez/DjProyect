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
    public partial class Consulta_Cobros_Porcobrar : base_consulta
    {
        public Consulta_Cobros_Porcobrar()
        {
            InitializeComponent();
        }

        private void Consulta_Cobros_Porcobrar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cobros_porcobrarDataSet.vista_cobros_porcobrar' Puede moverla o quitarla según sea necesario.
            this.vista_cobros_porcobrarTableAdapter.Fill(this.cobros_porcobrarDataSet.vista_cobros_porcobrar);
            // TODO: esta línea de código carga datos en la tabla 'cobros_porcobrarDataSet.vista_cobros_porcobrar' Puede moverla o quitarla según sea necesario.
            //this.vista_cobros_porcobrarTableAdapter.Fill(this.cobros_porcobrarDataSet.vista_cobros_porcobrar);

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            selecionar();
        }

        public void selecionar()
        {
            int pas = dataGridView.CurrentCell.RowIndex;
            codigo.Text = Convert.ToString(dataGridView.Rows[pas].Cells[0].Value);
            //this.DialogResult = DialogResult.OK;
            Cobros obj = new Cobros();
            obj.codcli.Text = codigo.Text;
            obj.Show();
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DataSet dss = utilidades.utility.conectarsupermercado("select *from vista_cobros_porcobrar ");

            //if (string.IsNullOrEmpty(nombre.Text.Trim()) == false)
            //{
            //    comandos += "where dbo.persona.nombre like '%" + nombre.Text.Trim() + "%'" +
            //    "or dbo.lista_negra.ficha like '%" + nombre.Text.Trim() + "%'"; ;
            //}
            if (dss.Tables[0].Rows.Count > 0)
            {
                dataGridView.DataSource = dss.Tables[0];

                mostrar_cuentas_pendiente mostrar = new mostrar_cuentas_pendiente();

                ReportDataSource st = new ReportDataSource("DataSet1", dss.Tables[0]);
                mostrar.reportViewer1.LocalReport.DataSources.Clear();
                mostrar.reportViewer1.LocalReport.DataSources.Add(st);
                mostrar.reportViewer1.RefreshReport();
                mostrar.ShowDialog();
                mostrar.reportViewer1.Reset();

            }
            else
            {
                MessageBox.Show("NO TIENE INFORMACION QUE MOSTRAR");
            }
            
        }
    }
}
