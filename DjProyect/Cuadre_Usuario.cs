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
    public partial class Cuadre_Usuario : Form1
    {
        public Cuadre_Usuario()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataSet dss;

            string cmd = string.Format("Exec reporteusuario '{0}','{1}','{2}','{3}'", txtusuario.SelectedValue, inicial.Value.ToShortDateString(), final.Value.ToShortDateString() , tipo.Text);
            dss = utilidades.utility.conectarsupermercado(cmd);


            if (dss.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL GUARDAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
               Mostrar_Cuadre_Usuario mostrar = new Mostrar_Cuadre_Usuario();

            ReportDataSource st = new ReportDataSource("DataSet1", dss.Tables[0]);
            mostrar.reportViewer1.LocalReport.DataSources.Clear();
            mostrar.reportViewer1.LocalReport.DataSources.Add(st);
            mostrar.reportViewer1.RefreshReport();
            mostrar.ShowDialog();
            mostrar.reportViewer1.Reset();
            }


            //comandos += "and  dbo.caja.fecha >= '" + dateTimePicker1.Value.ToShortDateString() + "'";

            //comandos += "or  dbo.caja.fecha <= '" + dateTimePicker2.Value.ToShortDateString() + "'";

            //tabla = utilidades.utility.conectarrencar(comandos);
            
        }

        private void Cuadre_Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuarioDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.usuarioDataSet.usuario);

        }
    }
}
