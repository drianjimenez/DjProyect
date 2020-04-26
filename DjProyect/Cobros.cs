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
    public partial class Cobros : Form1
    {
        public Cobros()
        {
            InitializeComponent();
        }
         
        private void Cobros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vista_cobroDataSet.vista_cobro' Puede moverla o quitarla según sea necesario.
            this.vista_cobroTableAdapter.Fill(this.vista_cobroDataSet.vista_cobro);
            // TODO: esta línea de código carga datos en la tabla 'vista_cobroDataSet.vista_cobro' Puede moverla o quitarla según sea necesario.
            this.vista_cobroTableAdapter.Fill(this.vista_cobroDataSet.vista_cobro);
            
        }


        public string usuario = "";
        double montopendiente = 0.00, montoaplicado = 0.00,montoapagar=0.00,pordescuento=0.00,descuento,montosinaplicar=0.00;


        public void rellenar()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {




                row.Cells["conceptoDataGridViewTextBoxColumn"].Value = "";
                if (row.Cells["monto"].Value == null)
                {
                    //MessageBox.Show("montoaplicar");
                    row.Cells["monto"].Value = Convert.ToDouble(montopendiente);
                    row.Cells["des"].Value = Convert.ToDouble(montoaplicado);
                }
                    
                if (row.Cells["montoaplicar"].Value == null)
                {
                    
                    row.Cells["montoaplicar"].Value = Convert.ToDouble(montoaplicado);
                }

                if (row.Cells["des"].Value == null)
                {
                    row.Cells["des"].Value = Convert.ToDouble(montopendiente);
                }
              


            }
            sumatotal();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }
       


        public void sumatotal()
        {
           double totalpagado = 0;
           double montopendiente = 0;
           //double descuento = 0;
           double montoaplicado = 0;
           double montosinaplicar = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {


                //double impotar = 0, itbis = 0;
                montopendiente =montopendiente+ Convert.ToDouble(row.Cells["montopendienteDataGridViewTextBoxColumn"].Value.ToString());
                montoaplicado =montoaplicado+ Convert.ToDouble(row.Cells["montoaplicar"].Value.ToString());
                totalpagado =totalpagado+ Convert.ToDouble(row.Cells["monto"].Value.ToString());
                 if (Convert.ToDouble(row.Cells["Monto"].Value)==0.00)
               {
                   montosinaplicar =montosinaplicar+Convert.ToDouble(row.Cells["montopendienteDataGridViewTextBoxColumn"].Value);
               }
                //total = total;
                //total= total;


            }
            txttotalpendiente.Text = Convert.ToString(montopendiente);
            txttotalaplicado.Text = Convert.ToString(montoaplicado);
            txtpagoaplicado.Text = Convert.ToString(totalpagado);
            txtsinaplicar.Text = Convert.ToString(montosinaplicar);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            
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

                if (dss.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = dss.Tables[0];
                    rellenar();
                    //sumatotal();

                }
                else
                {
                    MessageBox.Show("ESTE CLIENTE NO TIENE CUENTA PENDIENTE");
                    dataGridView1.Rows.Clear();
                }
            }
            catch
            {

            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if(Convert.ToDouble(txttotalaplicado.Text)>0.00 )
            {
                salvar();
                
                //imprimir();
                this.Close();
            }
            else
            {
                MessageBox.Show("DEBE APLICAR UN MONTO ANTES DE GUARDAR", "DIALOGO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }


        public void salvar()
        {
            try
            {

                string cmd3 = "";
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToString(row.Cells["conceptoDataGridViewTextBoxColumn"].Value.ToString()) == "Abono" || row.Cells["conceptoDataGridViewTextBoxColumn"].Value.ToString() == "Saldo")
                    {
                        string concepto = "";
                        double pendiente = 0;
                        double monto = 0;
                        //double pordes = 0;
                        int codigo = 0;
                        double desc = 0;
                        concepto = Convert.ToString(row.Cells["conceptoDataGridViewTextBoxColumn"].Value.ToString());
                        monto = Convert.ToDouble(row.Cells["Monto"].Value.ToString());
                        pendiente = Convert.ToDouble(row.Cells["montopendienteDataGridViewTextBoxColumn"].Value.ToString()) - monto;
                        pendiente = Math.Round(pendiente, 2);
                        codigo = Convert.ToInt16(row.Cells["codigoreciboDataGridViewTextBoxColumn"].Value.ToString());
                        desc = Convert.ToDouble(row.Cells["descuentoDataGridViewTextBoxColumn"].Value.ToString());
                        //MessageBox.Show(Convert.ToString(monto));
                        cmd3 = string.Format("exec realizarcobro '" + codigo + "','" + pendiente + "','" + desc + "','" + concepto + "'");
                        utilidades.utility.conectarsupermercado(cmd3);
                        cmd3 = "";
                    }
                }
               // MessageBox.Show("COBRO REALIZADO CORRECTAMENTE");
                agregarpago();

            }
            catch
            {
                MessageBox.Show("ERROR AL REALIZAR EL COBRO");
            }

        } 

        public void agregarpago()
        {
            try
            {

                string cmd3 = "";
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToDouble(row.Cells["montoaplicar"].Value.ToString()) > 0)
                    {


                        string concepto = "";
                        double pendiente = 0;
                        double monto = 0;
                        //double pordes = 0;
                        int codigo = 0;
                        double desc = 0;
                        concepto = Convert.ToString(row.Cells["conceptoDataGridViewTextBoxColumn"].Value.ToString());
                        monto = Convert.ToDouble(row.Cells["montoaplicar"].Value.ToString());
                        pendiente = Convert.ToDouble(row.Cells["montopendienteDataGridViewTextBoxColumn"].Value.ToString()) - monto;
                        codigo = Convert.ToInt16(row.Cells["codigoreciboDataGridViewTextBoxColumn"].Value.ToString());
                        desc = Convert.ToDouble(row.Cells["descuentoDataGridViewTextBoxColumn"].Value.ToString());

                        cmd3 = string.Format("exec actualizacobro '" + codigo + "','" + codcli.Text.Trim() + "','" + monto + "','" + txtusuario.Text.Trim() + "'");
                        utilidades.utility.conectarsupermercado(cmd3);
                        cmd3 = "";
                        //MessageBox.Show("paso");
                    }
                }
                MessageBox.Show("COBRO REALIZADO CORRECTAMENTE");


            }
            catch
            {
                MessageBox.Show("ERROR AL REALIZAR EL COBRO");
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {


                if (Convert.ToDouble(row.Cells["Monto"].Value) ==Convert.ToDouble(row.Cells["montopendienteDataGridViewTextBoxColumn"].Value))
                {
                    row.Cells["conceptoDataGridViewTextBoxColumn"].Value = "Saldo";
                    row.Cells["montoaplicar"].Value = row.Cells["Monto"].Value;
                }
                if (Convert.ToDouble(row.Cells["Monto"].Value) < Convert.ToDouble(row.Cells["montopendienteDataGridViewTextBoxColumn"].Value))
                {
                    row.Cells["conceptoDataGridViewTextBoxColumn"].Value = "Abono";
                    row.Cells["montoaplicar"].Value = row.Cells["Monto"].Value;
                }
                if (Convert.ToDouble(row.Cells["Monto"].Value) >Convert.ToDouble(row.Cells["montopendienteDataGridViewTextBoxColumn"].Value))
                {
                    MessageBox.Show("EL MONTO A PAGAR DEBE SER MENOR AL MONTO PENDIENTE","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    row.Cells["conceptoDataGridViewTextBoxColumn"].Value = "";
                    row.Cells["Monto"].Value="0.00";
                }
                if (Convert.ToDouble(row.Cells["Monto"].Value) ==0.00)
                {
                   
                    row.Cells["conceptoDataGridViewTextBoxColumn"].Value = "";
                    
                }

                if (Convert.ToDouble(row.Cells["descuentoDataGridViewTextBoxColumn"].Value)>0)
                {
                    pordescuento =( Convert.ToDouble(row.Cells["descuentoDataGridViewTextBoxColumn"].Value) / 100) * Convert.ToDouble(row.Cells["Monto"].Value);
                    //MessageBox.Show("porciento",Convert.ToString(pordescuento));
                    descuento = Convert.ToDouble(row.Cells["Monto"].Value)-pordescuento;
                   // MessageBox.Show("antes", Convert.ToString(pordescuento));
                    descuento = Math.Round(descuento, 2);
                    pordescuento = Math.Round(pordescuento, 2);
                    row.Cells["des"].Value = pordescuento;
                   // MessageBox.Show("des", Convert.ToString(pordescuento));
                    row.Cells["montoaplicar"].Value =Convert.ToDouble(row.Cells["Monto"].Value)-pordescuento;
                }
              
            }
            sumatotal();
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumerodecimal(e);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            
        }

        private void salir_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            object dss;
            dss = dataGridView1.DataSource;
            dataGridView1.DataSource = dss;
            
         
                Mostrar_estado_cuenta mostrar = new Mostrar_estado_cuenta();

                ReportDataSource st = new ReportDataSource("DataSet1", dss);
                mostrar.reportViewer1.LocalReport.DataSources.Clear();
                mostrar.reportViewer1.LocalReport.DataSources.Add(st);
                mostrar.reportViewer1.RefreshReport();
                mostrar.ShowDialog();
                mostrar.reportViewer1.Reset();

            
           
        }
    }
}
