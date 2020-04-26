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
    public partial class Compra : base_mantenimiento
    {
        public Compra()
        {
            InitializeComponent();
        }
        double total = 0.00;
        int numcomp = 0;
        string estado = "ACTIVA";
        private void salir_Click(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DESEA BORRAR PRODUCTO", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);


                sumatotal();
                // double suma = dataGridView1.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToInt32(x.Cells["impor"].Value));

                //total.Text = Convert.ToString(suma);
            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("NO SE BORRO");
            }
        }

        public void reimprimir()
        {
            DataSet tabla = new DataSet();
            string comandos = " select *from vista_compra_detallada";
            //int pas = dataGridView1.CurrentCell.RowIndex;
            //textBox1.Text = Convert.ToString(dataGridView1.Rows[pas].Cells[0].Value);

            comandos += " where codigo='" + numcomp + "'";

            tabla = utilidades.utility.conectarsupermercado(comandos);

            if (tabla.Tables[0].Rows.Count > 0)
            {
                Mostrar_Compra mostrar = new Mostrar_Compra();

                ReportDataSource st = new ReportDataSource("DataSet1", tabla.Tables[0]);
                mostrar.reportViewer1.LocalReport.DataSources.Clear();
                mostrar.reportViewer1.LocalReport.DataSources.Add(st);
                mostrar.reportViewer1.RefreshReport();
                mostrar.ShowDialog();
                mostrar.reportViewer1.Reset();

            }
            else
            {
                MessageBox.Show("ESTA REPORTE NO MUESTRA NINGUNA INFORMACION");
                return;

            }
        }


        public void sumatotal()
        {
            try
            {
                double costo = 0;
                total = 0.00;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {



                    // costo = Convert.ToDouble(row.Cells["costo1"].Value.ToString());
                    costo = Convert.ToDouble(row.Cells["costo1"].Value.ToString());
                    total = total + costo;
                }
                txtmonto.Text = Convert.ToString(total);
            }
            catch
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            salvar();
            agregardetalle();
            agregaralmacen();
        }

        public void salvar()
        {
            try
            {
                DataSet dss;
                string cmd2 = "";
                cmd2 = string.Format(" exec actualizacompra '" + txtcodigo.Text.Trim() + "','" + txtregistro.Value.ToShortDateString() + "','" + txtfactura.Value.ToShortDateString() + "','" + txtsuplidor.Text.Trim() + "','" + txtmonto.Text.Trim() + "','" + txtusuario.Text.Trim() + "','" + estado + "'");
                //dss.Clear();
                dss = utilidades.utility.conectarsupermercado(cmd2);
                if (dss.Tables.Count == 0)
                {
                    MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                    return;
                }
                else
                {
                    numcomp = Convert.ToInt16(dss.Tables[0].Rows[0]["codigo"].ToString().Trim());
                }

            }
            catch
            {
                MessageBox.Show("NO SE ACTUALIZO LA COMPRA, VUELTA A INTENTARLO");
            }
        }

        public void agregaralmacen()
        {
            //try
            //{

                string cmd3 = "";
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    
                    string cod = "";
                    double cantidad = 0;
                    int alma = 0, coduni=0;
                    // double impotar = 0, itbis = 0;
                    cod = Convert.ToString(row.Cells["codigo"].Value.ToString());
                    cantidad = Convert.ToDouble(row.Cells["cantidad"].Value.ToString());
                    alma = Convert.ToInt16(row.Cells["al"].Value.ToString());
                    coduni = Convert.ToInt16(row.Cells["idunidad"].Value.ToString());
                    //itbis = Convert.ToDouble(row.Cells["tbis"].Value.ToString());
                    //impotar = Convert.ToDouble(row.Cells["importe"].Value.ToString());

                    cmd3 = string.Format("exec actualizaexistencia '" + alma + "','" + cod + "','" + coduni + "','" + cantidad + "'");
                    utilidades.utility.conectarsupermercado(cmd3);
                    cmd3 = "";
                }
               // MessageBox.Show("NUEVOS ARTICULOS AGREGADOS AL ALMACEN");

                reimprimir();
                cancelar();

            //}
            //catch
            //{
            //    MessageBox.Show("ERROR GUARDANDO LOS ARTICULOS PARA EL ALMACEN");
            //}
        }

        public void agregardetalle()
        {
            //try
            //{

                string cmd3 = "";
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    string cod = "";
                    double cantidad = 0;
                    double costo = 0;
                    int alm = 0, uni = 0;
                    // double impotar = 0, itbis = 0;
                    cod = Convert.ToString(row.Cells["codigo"].Value.ToString());
                    cantidad = Convert.ToDouble(row.Cells["cantidad"].Value.ToString());
                    costo = Convert.ToDouble(row.Cells["costo1"].Value.ToString());
                    alm = Convert.ToInt16(row.Cells["al"].Value.ToString());
                    uni = Convert.ToInt16(row.Cells["idunidad"].Value.ToString());

                    cmd3 = string.Format("exec actualizadetallecompra '" + numcomp + "','" + cod + "','" + alm + "','" + uni + "','" + cantidad + "','" + costo + "'");
                    utilidades.utility.conectarsupermercado(cmd3);
                    cmd3 = "";
                }
                MessageBox.Show("COMPRA GUARDADA CORRECTAMENTE");
                agregaralmacen();
                //reimprimir();
                cancelar();

            //}
            //catch
            //{
            //    MessageBox.Show("ERROR GUARDANDO LOS ARTICULOS DE LA COMPRA");
            //}
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            //row.Cells["tbis"].Value.ToString();
            //switch (e.KeyCode)
            //{
            //    case Keys.Enter:
            //        //dataGridView1.CurrentRow.Cells[0]["codigo"].Value.ToString();
            //        //string co = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //       // dataGridView1.Rows.Cells["codigo"].Value.ToString()
            //        //SendKeys.Send("{tab}");

            //        if (string.IsNullOrEmpty(dataGridView1.Rows.Cells["codigo"].Value.ToString()))
            //        {
            //            Consulta_Articulo doForm = new Consulta_Articulo();
            //            if (doForm.ShowDialog() == DialogResult.OK)
            //            {
            //                //codart.Text = doForm.codigo.Text;
            //               // canart.Focus();
            //                SendKeys.Send("{enter}");
            //            }
            //            break;
            //        }
            //        else
            //        {
            //            return;
            //        }
            //        //break;
            //}
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void codart_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = utilidades.utility.conectarsupermercado("Select *from  articulo where codigo='" + codart.Text.Trim() + "'");

            if (ds.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                return;
            }

            //llenar los datos
            if (ds.Tables[0].Rows.Count > 0)
            {
                desart.Text = ds.Tables[0].Rows[0]["descripcion"].ToString().Trim();
                //preart.Text = ds.Tables[0].Rows[0]["precio_venta"].ToString().Trim();
                //it = Convert.ToDouble(ds.Tables[0].Rows[0]["itbis"].ToString().Trim());
            }

            else
            {

                desart.Text = "";
                preart.Text = "";
               // it = 0;
            }
        }

        public void limpiararticulo()
        {
            codart.Text = "";
            desart.Text = "";
            preart.Text = "";
            canart.Text = "";
            
        }

        public void cancelar()
        {
            codart.Text = "";
            desart.Text = "";
            preart.Text = "";
            canart.Text = "";
            txtcodigo.Text="";
            txtsuplidor.Text = "";
            nombresuplidor.Text = "";
            dataGridView1.Rows.Clear();
            txtfactura.Text = "";
            txtregistro.Text = "";
            txtcodigo.Text ="0";
            txtmonto.Text = "";
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            utilidades.utility.validar(this, errorProvider1);
            if (string.IsNullOrEmpty(codart.Text.Trim())) return;
            if (string.IsNullOrEmpty(desart.Text.Trim())) return;
            if (string.IsNullOrEmpty(canart.Text.Trim())) return;
            double can = 0, pre=0.00;
            int uni = 0, al = 0;
            can = Convert.ToDouble(canart.Text.Trim());
            pre = Convert.ToDouble(preart.Text.Trim());
            al = Convert.ToInt16(txtalmacen.Text.Trim());
            uni =Convert.ToInt16(txtunidad.SelectedValue);
            dataGridView1.Rows.Add(codart.Text.Trim(), desart.Text.Trim(),al,uni,txtunidad.Text.Trim(), canart.Text.Trim(), preart.Text.Trim());
            limpiararticulo();
            codart.Focus();
             sumatotal();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Consulta_Articulo doForm = new Consulta_Articulo();
            if (doForm.ShowDialog() == DialogResult.OK)
            {
                codart.Text = doForm.codigo.Text;
                canart.Focus();
                SendKeys.Send("{enter}");
            } 
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           Consulta_Suplidor doForm = new Consulta_Suplidor();
            if (doForm.ShowDialog() == DialogResult.OK)
            {
                txtsuplidor.Text = doForm.codigo.Text;
                canart.Focus();
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

        private void button3_Click(object sender, EventArgs e)
        {
            cancelar();
            sumatotal();
        }

        private void codart_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (string.IsNullOrEmpty(codart.Text.Trim()))
                    {
                        Consulta_Articulo doForm = new Consulta_Articulo();
                        if (doForm.ShowDialog() == DialogResult.OK)
                        {
                            codart.Text = doForm.codigo.Text;
                            codart.Focus();
                            SendKeys.Send("{enter}");
                        }
                        break;
                    }
                    else
                    {
                        return;
                    }
            }
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'unidadDataSet.unidad' Puede moverla o quitarla según sea necesario.
            this.unidadTableAdapter.Fill(this.unidadDataSet.unidad);
            // TODO: esta línea de código carga datos en la tabla 'unidadDataSet.unidad' Puede moverla o quitarla según sea necesario.
            this.unidadTableAdapter.Fill(this.unidadDataSet.unidad);
            txtcodigo.Text = "0";
        }

        private void txtsuplidor_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    if (string.IsNullOrEmpty(codart.Text.Trim()))
                    {
                        Consulta_Suplidor doForm = new Consulta_Suplidor();
                        if (doForm.ShowDialog() == DialogResult.OK)
                        {
                            txtsuplidor.Text = doForm.codigo.Text;
                            codart.Focus();
                            SendKeys.Send("{enter}");
                        }
                        break;
                    }
                    else
                    {
                        return;
                    }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consulta_Compra doForm = new Consulta_Compra();
            if (doForm.ShowDialog() == DialogResult.OK)
            {
                txtcodigo.Text = doForm.codigo.Text;
                //canart.Focus();
                SendKeys.Send("{enter}");
            }
        }

        public void consulta()
        {
            DataSet dss = utilidades.utility.conectarsupermercado("SELECT        dbo.detalle_compra.articulo, dbo.articulo.descripcion, dbo.detalle_compra.almacen, dbo.detalle_compra.unidad, dbo.detalle_compra.cantidad, dbo.detalle_compra.costo FROM            dbo.almacen INNER JOIN  dbo.detalle_compra ON dbo.almacen.codigo = dbo.detalle_compra.almacen INNER JOIN   dbo.compra ON dbo.detalle_compra.id_compra = dbo.compra.codigo INNER JOIN  dbo.unidad ON dbo.detalle_compra.unidad = dbo.unidad.codigo INNER JOIN   dbo.usuario ON dbo.compra.usuario = dbo.usuario.usuario INNER JOIN dbo.articulo ON dbo.detalle_compra.articulo = dbo.articulo.codigo WHERE dbo.detalle_compra.id_compra ='" + txtcodigo.Text.Trim() + "'");
            
            
            if (dss.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("aaaaaaaaaa");


                dataGridView1.DataSource = dss.Tables[0];


            }
        
        
        
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            //return;
            //if (string.IsNullOrEmpty(txtcodigo.Text.Trim())) return;
            //DataSet ds = utilidades.utility.conectarsupermercado("Select *from  compra where codigo='" + txtcodigo.Text.Trim() + "'");
           
            //if (ds.Tables.Count == 0)
            //{
            //    MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
            //    return;
            //}

            ////llenar los datos
            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    txtsuplidor.Text = ds.Tables[0].Rows[0]["suplidor"].ToString().Trim();
            //    txtregistro.Text = ds.Tables[0].Rows[0]["fecha_registro"].ToString().Trim();
            //    txtfactura.Text = ds.Tables[0].Rows[0]["fecha_factura"].ToString().Trim();
            //    txtmonto.Text = ds.Tables[0].Rows[0]["monto"].ToString().Trim();
            //    consulta();
            //    //txtdireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString().Trim();
            //   // txtsexo.Text = ds.Tables[0].Rows[0]["sexo"].ToString().Trim();

            //}
            
            
        }

        private void txtalmacen_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtalmacen.Text.Trim())) return;
            DataSet ds = utilidades.utility.conectarsupermercado("Select *from  almacen where codigo='" + txtalmacen.Text.Trim() + "'");

            if (ds.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                return;
            }

            //llenar los datos
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtnomalmacen.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();

            }

            else
            {

                txtnomalmacen.Text = "";

            }
        }

        private void txtsuplidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }

        private void txtalmacen_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }

        private void preart_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumerodecimal(e);
        }

        private void canart_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumerodecimal(e);
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }
    }
}
