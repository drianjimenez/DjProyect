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
    public partial class cuadre_detallado : base_reporte
    {
        public cuadre_detallado()
        {
            InitializeComponent();
        }

        private void cuadre_detallado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuarioDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.usuarioDataSet.usuario);

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataSet dss,d;

            string cmd = string.Format("Exec reporteventas '{0}','{1}','{2}'", txtusuario.SelectedValue, inicial.Value.ToShortDateString(), final.Value.ToShortDateString());
            dss = utilidades.utility.conectarsupermercado(cmd);


            string cmd2 = string.Format("Exec reporteventascredito '{0}','{1}','{2}'", txtusuario.SelectedValue, inicial.Value.ToShortDateString(), final.Value.ToShortDateString());
            d = utilidades.utility.conectarsupermercado(cmd2);


            if (dss.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL GUARDAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                Mostrar_ventas_diarias mostrar = new Mostrar_ventas_diarias();

                ReportDataSource st = new ReportDataSource("DataSet1", dss.Tables[0]);
                ReportDataSource stt = new ReportDataSource("DataSet2", d.Tables[0]);
                mostrar.reportViewer1.LocalReport.DataSources.Clear();
                mostrar.reportViewer1.LocalReport.DataSources.Add(st);
                mostrar.reportViewer1.LocalReport.DataSources.Add(stt);
                mostrar.reportViewer1.RefreshReport();
                mostrar.ShowDialog();
                mostrar.reportViewer1.Reset();
            }


            //comandos += "and  dbo.caja.fecha >= '" + dateTimePicker1.Value.ToShortDateString() + "'";

            //comandos += "or  dbo.caja.fecha <= '" + dateTimePicker2.Value.ToShortDateString() + "'";

            //tabla = utilidades.utility.conectarrencar(comandos);
            
        }
    }
}
