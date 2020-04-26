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
    public partial class Pagar_Factura : Form1
    {
        public Pagar_Factura()
        {
            InitializeComponent();
        }

        private void Pagar_Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vista_pagar_compraDataSet.vista_pagar_compra' Puede moverla o quitarla según sea necesario.
            this.vista_pagar_compraTableAdapter.Fill(this.vista_pagar_compraDataSet.vista_pagar_compra);
            // TODO: esta línea de código carga datos en la tabla 'vista_pagar_compraDataSet.vista_pagar_compra' Puede moverla o quitarla según sea necesario.
           // this.vista_pagar_compraTableAdapter.Fill(this.vista_pagar_compraDataSet.vista_pagar_compra);
            // TODO: esta línea de código carga datos en la tabla 'compraDataSet.vista_compra' Puede moverla o quitarla según sea necesario.
           // this.vista_compraTableAdapter.Fill(this.compraDataSet.vista_compra);
            // TODO: esta línea de código carga datos en la tabla 'vista_compra_detalladaDataSet.vista_compra_detallada' Puede moverla o quitarla según sea necesario.
            //this.vista_compra_detalladaTableAdapter.Fill(this.vista_compra_detalladaDataSet.vista_compra_detallada);
            rellenar();
        }


        public string usuario = "";
        int cxp = 0;
        double montopendiente = 0.00, montoaplicado = 0.00, montoapagar = 0.00, pordescuento = 0.00, descuento, montosinaplicar = 0.00;
        public void rellenar()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {


                if (row.Cells["montoaplicar"].Value == null)
                {

                    row.Cells["montoaplicar"].Value = Convert.ToDouble(montoaplicado);
                }

                //if (row.Cells["des"].Value == null)
                //{
                //    row.Cells["des"].Value = Convert.ToDouble(montopendiente);
                //}



            }

           
        }

        public void sumatotal()
        {
            double totalpagado = 0;
            double montopendiente = 0;
            //double descuento = 0;
            
            double montosinaplicar = 0;
            rellenar();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {


                //double impotar = 0, itbis = 0;
                montopendiente = montopendiente + Convert.ToDouble(row.Cells["montoDataGridViewTextBoxColumn"].Value.ToString());
                //montoaplicado = montoaplicado + Convert.ToDouble(row.Cells["montoaplicar"].Value.ToString());
               // totalpagado = totalpagado + Convert.ToDouble(row.Cells["monto"].Value.ToString());
                if (Convert.ToBoolean(row.Cells["Monto"].Value) == true)
                {
                    totalpagado = totalpagado + Convert.ToDouble(row.Cells["montoaplicar"].Value);
                }

                if (Convert.ToBoolean(row.Cells["Monto"].Value) == false)
                {
                    montosinaplicar = montosinaplicar + Convert.ToDouble(row.Cells["montoDataGridViewTextBoxColumn"].Value);
                }
                //total = total;
                //total= total;


            }
            txttotalpendiente.Text = Convert.ToString(montopendiente);
            //txttotalaplicado.Text = Convert.ToString(montoaplicado);
            txtpagoaplicado.Text = Convert.ToString(totalpagado);
            txtsinaplicar.Text = Convert.ToString(montosinaplicar);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            aplicar();
            sumatotal();
            if (Convert.ToDouble(txtpagoaplicado.Text) > 0.00)
            {
                salvar();
                agregarpago();
                //imprimir();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR ANTES DE GUARDAR", "DIALOGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void reimprimir()
        {
            DataSet tabla = new DataSet();
            string comandos = " SELECT   vista_pagar_compra";
            //int pas = dataGridView1.CurrentCell.RowIndex;
            //textBox1.Text = Convert.ToString(dataGridView1.Rows[pas].Cells[0].Value);

            comandos += " where dbo.factura.numero='" + cxp + "'";

            tabla = utilidades.utility.conectarsupermercado(comandos);

            //otro
            Mostrar_Factura mostrar = new Mostrar_Factura();

            ReportDataSource st = new ReportDataSource("DataSet1", tabla.Tables[0]);
            mostrar.reportViewer1.LocalReport.DataSources.Clear();
            mostrar.reportViewer1.LocalReport.DataSources.Add(st);
            mostrar.reportViewer1.RefreshReport();
            mostrar.ShowDialog();
            mostrar.reportViewer1.Reset();
        }
        public void salvar()
        {
            try
            {

                string cmd3 = "";
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    string concepto = "Pagada";
                    int codigo = 0;
                    codigo = Convert.ToInt16(row.Cells["codigoDataGridViewTextBoxColumn"].Value.ToString());
                    cmd3 = string.Format("exec actualizacxp '" + codigo + "','" + txtpagoaplicado.Text.Trim() + "','" + txtusuario.Text.Trim() + "','" + concepto + "'");
                    utilidades.utility.conectarsupermercado(cmd3);
                    cmd3 = "";
                }
                MessageBox.Show("PAGO REALIZADO CORRECTAMENTE");
            }
            catch
            {
                MessageBox.Show("ERROR AL REALIZAR EL PAGO","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        } 

        public void agregarpago()
        {
            //try
            //{

                string cmd3 = "";
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["monto"].Value) ==true)
                    {


                        
                        int codigo = 0;

                        codigo = Convert.ToInt16(row.Cells["codigoDataGridViewTextBoxColumn"].Value.ToString());
                        cmd3 = string.Format("update compra set estado='PAGADA' WHERE  codigo='" + codigo + "'");
                        utilidades.utility.conectarsupermercado(cmd3);
                        cmd3 = "";
                        
                    }
                }
                MessageBox.Show("NUEVOS REGISTRO ACTUALIZADOS");


            //}
            //catch
            //{
            //    MessageBox.Show("ERROR AL REALIZAR EL COBRO");
            //}
        }
        

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            aplicar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           aplicar();
        }


        public void aplicar()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {


                if (Convert.ToBoolean(row.Cells["Monto"].Value) == true)
                {
                    row.Cells["montoaplicar"].Value = row.Cells["montoDataGridViewTextBoxColumn"].Value;
                    //row.Cells["montoaplicar"].Value = row.Cells["Monto"].Value;
                }
                else
                {
                    row.Cells["montoaplicar"].Value = "0.00";
                }
               

            }
            sumatotal();
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            sumatotal();
        }

        private void codsup_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codsup.Text.Trim())) return;
            //try
            //{
                DataSet ds = utilidades.utility.conectarsupermercado("Select *from  suplidor where codigo='" + codsup.Text.Trim() + "'");
                DataSet dss = utilidades.utility.conectarsupermercado("select *from vista_pagar_compra WHERE estado='activa' and suplidor =" + codsup.Text.Trim());
                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                    return;
                }

                //llenar los datos
                if (ds.Tables[0].Rows.Count > 0)
                {
                    suplidor.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();


                }
                else
                {
                    suplidor.Text = "";
                }

                if (dss.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = dss.Tables[0];
                    rellenar();
                    sumatotal();

                }
                else
                {
                    MessageBox.Show("ESTE SUPLIDOR NO TIENE CUENTAS PENDIENTES");
                    //dataGridView1.Rows.Clear();
                }

            //}



            //catch
            //{
            //    MessageBox.Show("ERROR AL PROCESAR LA INFORMACION", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btntodo_Click(object sender, EventArgs e)
        {
            seleccionartodo();
        }

        public void seleccionartodo()
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                row.Cells["monto"].Value = true;
                aplicar();
                
                sumatotal();
            }
            

        }

        private void btnnada_Click(object sender, EventArgs e)
        {
            seleccionarnada();
        }

        public void seleccionarnada()
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                row.Cells["monto"].Value = false;
                aplicar();
                sumatotal();

            }
            

        }
    }
}
