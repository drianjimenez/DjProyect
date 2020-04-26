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
    public partial class Consulta_Articulo : base_consulta
    {
        public Consulta_Articulo()
        {
            InitializeComponent();
        }

        private void Consulta_Articulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistaarticulo._vistaarticulo' Puede moverla o quitarla según sea necesario.
           // this.vistaarticuloTableAdapter.Fill(this.vistaarticulo._vistaarticulo);
            // TODO: esta línea de código carga datos en la tabla 'vistaarticulo._vistaarticulo' Puede moverla o quitarla según sea necesario.
            //this.vistaarticuloTableAdapter.Fill(this.vistaarticulo._vistaarticulo);
            
            //try
            //{
          //  DataSet ds = utilidades.utility.conectarsupermercado("Select *from  suplidor where codigo='" + codsup.Text.Trim() + "'");
            DataSet dss = utilidades.utility.conectarsupermercado("select *from vistaarticulo ");
            

            if (dss.Tables[0].Rows.Count > 0)
            {
                dataGridView.DataSource = dss.Tables[0];
                

            }
            else
            {
             
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
            this.DialogResult = DialogResult.OK;
            Close();
        }
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void codigo_TextChanged(object sender, EventArgs e)
        {
            DataSet dss = utilidades.utility.conectarsupermercado("select *from vistaarticulo where codigo like  '%"+codigo.Text.Trim() + "%' or descripcion like  '%"+codigo.Text.Trim()+"%'");

            //if (string.IsNullOrEmpty(nombre.Text.Trim()) == false)
            //{
            //    comandos += "where dbo.persona.nombre like '%" + nombre.Text.Trim() + "%'" +
            //    "or dbo.lista_negra.ficha like '%" + nombre.Text.Trim() + "%'"; ;
            //}
            if (dss.Tables[0].Rows.Count > 0)
            {
                dataGridView.DataSource = dss.Tables[0];


            }
           
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            DataSet dss = utilidades.utility.conectarsupermercado("select *from vistaarticulo where codigo like  '%" + codigo.Text.Trim() + "%' or descripcion like  '%" + codigo.Text.Trim() + "%'");

            //if (string.IsNullOrEmpty(nombre.Text.Trim()) == false)
            //{
            //    comandos += "where dbo.persona.nombre like '%" + nombre.Text.Trim() + "%'" +
            //    "or dbo.lista_negra.ficha like '%" + nombre.Text.Trim() + "%'"; ;
            //}
            if (dss.Tables[0].Rows.Count > 0)
            {
                dataGridView.DataSource = dss.Tables[0];

                Mostrar_articulo mostrar = new Mostrar_articulo();

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
