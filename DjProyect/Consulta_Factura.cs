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
using Microsoft.Office.Interop.Excel;
using System.Globalization;

namespace DjProyect
{
    public partial class Consulta_Factura : base_consulta
    {
        public Consulta_Factura()
        {
            InitializeComponent();
             DataSet tabla = new DataSet();
        }
        DataSet tabla = new DataSet();
        private void Consulta_Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'factura_sin_detalleDataSet.vista_facturasindetalle' Puede moverla o quitarla según sea necesario.
            this.vista_facturasindetalleTableAdapter.Fill(this.factura_sin_detalleDataSet.vista_facturasindetalle);
            // TODO: esta línea de código carga datos en la tabla 'factura_sin_detalleDataSet.vista_facturasindetalle' Puede moverla o quitarla según sea necesario.
            //this.vista_facturasindetalleTableAdapter.Fill(this.factura_sin_detalleDataSet.vista_facturasindetalle);
           // txtdesde.Format.ToString('yyyy-MM-dd');
            //txthasta.Format.ToString("yyyy-MM-dd");
            total_registro();
        }

        public void total_registro()
        {
            int registro = 0;
            double monto=0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                monto += Convert.ToDouble(row.Cells["dataGridViewTextBoxColumn2"].Value.ToString());
                registro++;
            }
            lbmonto.Text =Convert.ToDecimal( monto).ToString("N",CultureInfo.InvariantCulture);
            lbtotalregistro.Text = Convert.ToString(registro);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
          

            if(ckexcel.Checked==true)
            {
                exportaraexcel(dataGridView1);
            }

            if (ckpresentar.Checked == true)
            {
                reimprimir();
            }

            if (ckpdf.Checked == true)
            {
                reimprimir();
            }

       
            
        }

        public void reimprimir()
        {
           
            string comandos = " SELECT        dbo.factura.numero, dbo.articulo.descripcion, dbo.desglose.efectivo, dbo.desglose.tarjeta, dbo.desglose.cheque, dbo.desglose.devuelta, dbo.cliente.nombre, dbo.detalle_factura.cantidad,      dbo.detalle_factura.precio, dbo.detalle_factura.itbis, dbo.detalle_factura.importe, dbo.factura.fecha, dbo.factura.monto, dbo.factura.ncf, dbo.factura.usuario, dbo.factura.estado,   dbo.factura_vs_comprobante.nombre AS nombre_de, dbo.tipo_comprobante.tipo, dbo.empresa.nombre AS empresa, dbo.empresa.rnc, dbo.sucursal.nombre AS sucursal, dbo.sucursal.telefono FROM            dbo.articulo INNER JOIN  dbo.detalle_factura ON dbo.articulo.codigo = dbo.detalle_factura.articulo INNER JOIN  dbo.factura ON dbo.detalle_factura.factura_numero = dbo.factura.numero INNER JOIN   dbo.desglose ON dbo.factura.numero = dbo.desglose.numero INNER JOIN   dbo.usuario ON dbo.factura.usuario = dbo.usuario.usuario INNER JOIN    dbo.cliente ON dbo.factura.cliente = dbo.cliente.codigo INNER JOIN   dbo.factura_vs_comprobante ON dbo.factura.numero = dbo.factura_vs_comprobante.numero INNER JOIN  dbo.tipo_comprobante ON dbo.factura.comprobante = dbo.tipo_comprobante.cod_tipo INNER JOIN  dbo.sucursal ON dbo.usuario.sucursal = dbo.sucursal.codigo INNER JOIN  dbo.empresa ON dbo.sucursal.empresa = dbo.empresa.codigo";
            //int pas = dataGridView1.CurrentCell.RowIndex;
            //textBox1.Text = Convert.ToString(dataGridView1.Rows[pas].Cells[0].Value);
            int pas = dataGridView1.CurrentCell.RowIndex;
            txtimprimir.Text = Convert.ToString(dataGridView1.Rows[pas].Cells[0].Value);
           
            if (string.IsNullOrEmpty(txtimprimir.Text.Trim()) == false)
            {
                 comandos += " where dbo.factura.numero='" + txtimprimir.Text.Trim() + "'";
            }
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

        private void codigo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public void exportaraexcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 1,i=0;

            //ENCABEZADO
            excel.Range["A1:G1"].Merge();
            excel.Range["A1:G1"].Value = "REPORTE DE FACTURA";
            excel.Range["A1:G1"].Font.Size = 18; 
            excel.Range["A1:G1"].Font.Bold = true;


            excel.Range["A2:G2"].Font.Bold = true;
            excel.Range["A2:G2"].Font.Size = 14;
            excel.Range["A2:G2"].Merge();


            excel.Range["A3:G3"].Font.Bold = true;
            excel.Range["A3:G3"].Font.Size = 12;


            //Excel.Range Rango = excel.Range["A3:D" + (i - 1).ToString()];
            excel.Selection();
            excel.Columns.AutoFit();
           
            //HojaExcel.Range["A2:E2"].Value = "ENCUESTA DE SATISFACCIÓN AL CLIENTE EXTERNO";
            //xcel.Cells[1, 1] = "REPORTE DE FACTURAS";
       
            excel.Cells[2, 1] = "DESDE LA FECHA " + txtdesde.Value.ToShortDateString()+ " HASTA " + txthasta.Value.ToShortDateString();
            foreach (DataGridViewColumn col in tabla.Columns) // Columnas
            {
                if(IndiceColumna<8)
                {
                    IndiceColumna++;

                    excel.Cells[3, IndiceColumna-1] = col.HeaderText ;
                }
               

            }

            int IndeceFila = 1;

            foreach (DataGridViewRow row in tabla.Rows) // Filas
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    if (IndiceColumna < 7)
                    {
                        IndiceColumna++;

                        excel.Cells[IndeceFila + 2, IndiceColumna] = row.Cells[col.Name].Value;
                    }
                }

            }

            excel.Visible = true;

            
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
             DataSet tabla = new DataSet();
            //string comandos = " SELECT        dbo.factura.numero, dbo.articulo.descripcion, dbo.desglose.efectivo, dbo.desglose.tarjeta, dbo.desglose.cheque, dbo.desglose.devuelta, dbo.cliente.nombre, dbo.detalle_factura.cantidad,      dbo.detalle_factura.precio, dbo.detalle_factura.itbis, dbo.detalle_factura.importe, dbo.factura.fecha, dbo.factura.monto, dbo.factura.ncf, dbo.factura.usuario, dbo.factura.estado,   dbo.factura_vs_comprobante.nombre AS nombre_de, dbo.tipo_comprobante.tipo, dbo.empresa.nombre AS empresa, dbo.empresa.rnc, dbo.sucursal.nombre AS sucursal, dbo.sucursal.telefono FROM            dbo.articulo INNER JOIN  dbo.detalle_factura ON dbo.articulo.codigo = dbo.detalle_factura.articulo INNER JOIN  dbo.factura ON dbo.detalle_factura.factura_numero = dbo.factura.numero INNER JOIN   dbo.desglose ON dbo.factura.numero = dbo.desglose.numero INNER JOIN   dbo.usuario ON dbo.factura.usuario = dbo.usuario.usuario INNER JOIN    dbo.cliente ON dbo.factura.cliente = dbo.cliente.codigo INNER JOIN   dbo.factura_vs_comprobante ON dbo.factura.numero = dbo.factura_vs_comprobante.numero INNER JOIN  dbo.tipo_comprobante ON dbo.factura.comprobante = dbo.tipo_comprobante.cod_tipo INNER JOIN  dbo.sucursal ON dbo.usuario.sucursal = dbo.sucursal.codigo INNER JOIN  dbo.empresa ON dbo.sucursal.empresa = dbo.empresa.codigo";
            string comandos = "select *from vista_facturasindetalle ";
            
           // int pas = dataGridView1.CurrentCell.RowIndex;
            //codigo.Text = Convert.ToString(dataGridView1.Rows[pas].Cells[0].Value);

            comandos += "  where fecha>= '" + Convert.ToDateTime(txtdesde.Text).ToString("dd-MM-yyyy") + "' and fecha<='" +  Convert.ToDateTime(txthasta.Text).ToString("dd-MM-yyyy") + "' ";
            
            //txthasta.Format.ToString("yyyy-MM-dd");
            if (string.IsNullOrEmpty(codigo.Text.Trim()) == false)
            {
                comandos += " and numero like '" + codigo.Text.Trim() + "%'";
            }
            tabla = utilidades.utility.conectarsupermercado(comandos);

            if (tabla.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = tabla.Tables[0];


            }
            if(tabla.Tables[0].Rows.Count==0)
            {
                dataGridView1.DataSource = "";
            }
            total_registro();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
