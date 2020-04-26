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
    public partial class Estado_Cuenta : base_reporte
    {
        public Estado_Cuenta()
        {
            InitializeComponent();
        }

        private void codcli_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codcli.Text.Trim())) return;
            try
            {
                DataSet ds = utilidades.utility.conectarsupermercado("Select *from  cliente where codigo='" + codcli.Text.Trim() + "'");
                DataSet dss = utilidades.utility.conectarsupermercado("select *from vista_cobro WHERE cliente =" + codcli.Text.Trim());
                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                    return;
                }

                //llenar los datos
                if (ds.Tables[0].Rows.Count > 0)
                {
                    cliente.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();


                }
                else
                {
                    cliente.Text = "";
                }

            }



            catch
            {

            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataSet dss = utilidades.utility.conectarsupermercado("select *from vista_estado_cuenta WHERE codigo=" + codcli.Text.Trim());
            if (dss.Tables[0].Rows.Count > 0)
            {
                reimprimir();
                //obj.txtusuario.Text = txtusuario.Text;
                //this.Close();
            }
            else
            {
                MessageBox.Show("ESTE CLIENTE NO TIENE CUENTA PENDIENTE");

            }
        }
        public void reimprimir()
        {
            DataSet tabla = new DataSet();
            string comandos = " select *from vista_estado_cuenta";
            //int pas = dataGridView1.CurrentCell.RowIndex;
            //textBox1.Text = Convert.ToString(dataGridView1.Rows[pas].Cells[0].Value);

            comandos += " where  codigo='" + codcli.Text.Trim() + "'";

            tabla = utilidades.utility.conectarsupermercado(comandos);

            //otro
            Mostrar_estado_cuenta mostrar = new Mostrar_estado_cuenta();

            ReportDataSource st = new ReportDataSource("DataSet1", tabla.Tables[0]);
            mostrar.reportViewer1.LocalReport.DataSources.Clear();
            mostrar.reportViewer1.LocalReport.DataSources.Add(st);
            mostrar.reportViewer1.RefreshReport();
            mostrar.ShowDialog();
            mostrar.reportViewer1.Reset();
        }

        private void codcli_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }
    }
}
