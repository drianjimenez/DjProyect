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
    public partial class consulta_factura_sinpagar : base_consulta
    {
        public consulta_factura_sinpagar()
        {
            InitializeComponent();
        }

        private void consulta_factura_sinpagar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cxp_facturasinpagarDataSet.vista_cxp_sinpagar' Puede moverla o quitarla según sea necesario.
            this.vista_cxp_sinpagarTableAdapter.Fill(this.cxp_facturasinpagarDataSet.vista_cxp_sinpagar);
            // TODO: esta línea de código carga datos en la tabla 'cxp_facturasinpagarDataSet.vista_cxp_sinpagar' Puede moverla o quitarla según sea necesario.
            this.vista_cxp_sinpagarTableAdapter.Fill(this.cxp_facturasinpagarDataSet.vista_cxp_sinpagar);

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DataSet dss = utilidades.utility.conectarsupermercado("select *from vista_cxp_sinpagar");

            //if (string.IsNullOrEmpty(nombre.Text.Trim()) == false)
            //{
            //    comandos += "where dbo.persona.nombre like '%" + nombre.Text.Trim() + "%'" +
            //    "or dbo.lista_negra.ficha like '%" + nombre.Text.Trim() + "%'"; ;
            //}
            if (dss.Tables[0].Rows.Count > 0)
            {
                dataGridView.DataSource = dss.Tables[0];

                Mostrar_cxp_sinpagar mostrar = new Mostrar_cxp_sinpagar();

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

        private void buttonX1_Click(object sender, EventArgs e)
        {
            selecionar();
        }

        public void selecionar()
        {
            int pas = dataGridView.CurrentCell.RowIndex;
            codigo.Text = Convert.ToString(dataGridView.Rows[pas].Cells[0].Value);
            //this.DialogResult = DialogResult.OK;
            Pagar_Factura obj = new Pagar_Factura();
            obj.codsup.Text = codigo.Text;
            obj.Show();
            this.Close();
        }
    }
}
