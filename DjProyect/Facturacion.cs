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
    public partial class Facturacion : Form1
    {
        public Facturacion()
        {
            InitializeComponent();
            
        }
        string estado = "DE CONTADO";
        int numfac = 0;
            double it = 0, totalimpuesto=0, total=0;
        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string co = Convert.ToString(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
           
           
        }

        private void dataGridViewX1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (string.IsNullOrEmpty(.Text.Trim())) return;
            
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DESEA BORRAR PRODUCTO","",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

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

        

        private void Facturacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'unidadDataSet.unidad' Puede moverla o quitarla según sea necesario.
            this.unidadTableAdapter.Fill(this.unidadDataSet.unidad);
            codart.Focus();
            impo.Text = "0.00";
            codcli.Text = "0";
        }

        private void art_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = utilidades.utility.conectarsupermercado("Select *from  articulo where codigo='" + codart.Text.Trim() + "'");
                DataSet dss = utilidades.utility.conectarsupermercado("select * from vista_unidad_precio where codart='" + codart.Text.Trim() + "'");
                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                    return;
                }

                //llenar los datos
                if (ds.Tables[0].Rows.Count > 0)
                {
                    desart.Text = ds.Tables[0].Rows[0]["descripcion"].ToString().Trim();

                }

                else
                {

                    desart.Text = "";
                  
                    it = 0;
                }

                if (dss.Tables[0].Rows.Count > 0)
                {
                    txtunidad.DataSource = dss.Tables[0];
                  txtunidad.DisplayMember = "nombre";
                  txtunidad.ValueMember = "dbo.unidad.codigo";
                    //txtprecio.DataSource = dss.Tables[0];
                    //txtprecio.DisplayMember = "precio";
                    


                }
            }
            catch
            {

            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            insectarart();
        }

        public void insectarart()
        {
            utilidades.utility.validar(this, errorProvider1);
            if (string.IsNullOrEmpty(codart.Text.Trim())) return;
            if (string.IsNullOrEmpty(desart.Text.Trim())) return;
            if (string.IsNullOrEmpty(canart.Text.Trim())) return;
            double can = 0;
            double pre, imp, itbis;
            can = Convert.ToDouble(canart.Text.Trim());
            pre = Convert.ToDouble(txtprecio.Text.Trim());
            imp = can*pre;
            imp = Math.Round(imp, 2);
            can = Math.Round(can, 2);
            itbis = imp*0.18;
            itbis = Math.Round(itbis, 2);
            dataGridView1.Rows.Add(codart.Text.Trim(), desart.Text.Trim(), can, pre, itbis, imp,txtunidad.SelectedValue);
            sumatotal();
            limpiararticulo();
            codart.Focus();
        }


        public void limpiararticulo()
        {
            codart.Text = "";
            desart.Text = "";
            txtprecio.Text = "";
            canart.Text = "";
            it = 0;
        }

        private void codcli_TextChanged(object sender, EventArgs e)
        {
           // if (string.IsNullOrEmpty(codcli.Text.Trim())) return;
            DataSet ds = utilidades.utility.conectarsupermercado("Select *from  cliente where codigo='" + codcli.Text.Trim() + "'");
            DataSet dss = utilidades.utility.conectarsupermercado("Select *from  cliente_credito where cliente='" + codcli.Text.Trim() + "'");
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
            if(Convert.ToBoolean(dss.Tables[0].Rows[0]["aprovacion"].ToString().Trim())==true)
            {
                credito.Visible = true;
                estado = "CREDITO";
            }
            else
            {
                estado = "DE CONTADO";
                credito.Visible = false;
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Consulta_Cliente doForm = new Consulta_Cliente();
            if (doForm.ShowDialog() == DialogResult.OK)
            {
                codcli.Text = doForm.codigo.Text;
                canart.Focus();
                SendKeys.Send("{enter}");
            }
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            Consulta_Articulo doForm = new Consulta_Articulo();
            if (doForm.ShowDialog() == DialogResult.OK)
            {
                codart.Text = doForm.codigo.Text;
                canart.Focus();
                SendKeys.Send("{enter}");
            } 
        }

        private void Facturacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.F9: // mayúsculas
                //cliente.Text += "\nTecla W en el formulario";
                    Desglose obj = new Desglose();
                    obj.Show();
                   // textBox3.Text += "\r\nTecla W en el formulario (KeyPress)";
                    break;

                case (char)Keys.F7:
                    RNC obj2 = new RNC();
                    obj2.Show();
                    break;
               
            }
        }

        private void Facturacion_KeyDown(object sender, KeyEventArgs e)
        {
            // da igual mayúsculas que minúsculas
            switch (e.KeyCode)
            {
                case Keys.F9:
                    grabar();
                    break;
                case Keys.F7:
                   RNC doForm = new RNC();
                    if (doForm.ShowDialog() == DialogResult.OK)
                    {
                        RNC.Text = doForm.rn.Text.Trim();
                        RNC.Visible = true;
                        CONSUMIDOR_FINAL.Visible = true;
                        VALIDO.Visible = true;
                        //txttipo.Visible = true;
                        //MessageBox.Show("paso por aqui");
                        CONSUMIDOR_FINAL.Text = doForm.nom.Text;
                        VALIDO.Text = doForm.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        txttipo.Text = "0";
                        txttipo.Text +=  Convert.ToString(doForm.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        if (doForm.dataGridView1.CurrentRow.Cells[0].Value.ToString() == "14" || doForm.dataGridView1.CurrentRow.Cells[0].Value.ToString()=="15")
                        {
                            txttipo.Text = Convert.ToString(doForm.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        }
                            SendKeys.Send("{enter}");
                    } 
                    break;
            }
        }

        private void Facturacion_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyValue)
            {
                case (char)Keys.F9:
                  Desglose obj = new Desglose();
                    obj.Show();
                    break;

                case (char)Keys.F7:
                    RNC doForm = new RNC();
                    if (doForm.ShowDialog() == DialogResult.OK)
                    {
                        cliente.Text = doForm.rn.Text.Trim();
                        RNC.Visible = true;
                        
                       // NOMBREDE.Text = doForm.nom.Text;
                        //VALIDO.Text = doForm.rn.Text;
                        SendKeys.Send("{enter}");
                    } 
                    break;
                case (char)Keys.F2:
                    reimprimir();
                    break;
            }
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            grabar();
        }



       public void agregarfactura()
        {
            try
            {
                DataSet dss;
                string cmd2 = "";
                cmd2 = string.Format(" exec actualizafactura '" + codcli.Text.Trim() + "','" + impo.Text.Trim() + "','" + ncf.Text.Trim() + "','" + txttipo.Text.Trim() + "','" + txtusuario.Text.Trim() + "','" + estado + "'");
                //dss.Clear();
                dss = utilidades.utility.conectarsupermercado(cmd2);
                if (dss.Tables.Count == 0)
                  {
                MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                return;
                 }
                else
                {
                    numfac = Convert.ToInt16(dss.Tables[0].Rows[0]["numero"].ToString().Trim());
                }

            }
            catch
            {
                MessageBox.Show("NO SE ACTUALIZO LA FACTURA, VUELVA A INTENTARLO");
            }
        }




       public void desglose(double efe, double tar,double che,double dev)
        {
            DataSet dss;

            string cmd = string.Format("Exec actualizadesglose '{0}','{1}','{2}','{3}','{4}'", numfac,efe,tar,che,dev);
            dss = utilidades.utility.conectarsupermercado(cmd);


            if (dss.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL GUARDAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /*else
            {
                MessageBox.Show("DESGLOSE AGREGADO CON EXITO");

            }*/


        }





        public void guardarcomprobante()
       {
           DataSet dss;

           string cmd = string.Format("Exec actualizafactura_vs_comprobante '{0}','{1}','{2}'",numfac ,RNC.Text.Trim(), CONSUMIDOR_FINAL.Text.Trim());
           dss = utilidades.utility.conectarsupermercado(cmd);


           if (dss.Tables.Count == 0)
           {
               MessageBox.Show("ERROR AL GUARDAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }

           else
           {
              // MessageBox.Show("COMPROBANTE AGREGADO CORRECTAMENTE");

           }

            
          
       }

        public void reimprimir()
        {
            DataSet tabla = new DataSet();
            string comandos = " SELECT        dbo.factura.numero, dbo.articulo.descripcion, dbo.desglose.efectivo, dbo.desglose.tarjeta, dbo.desglose.cheque, dbo.desglose.devuelta, dbo.cliente.nombre, dbo.detalle_factura.cantidad,      dbo.detalle_factura.precio, dbo.detalle_factura.itbis, dbo.detalle_factura.importe, dbo.factura.fecha, dbo.factura.monto, dbo.factura.ncf, dbo.factura.usuario, dbo.factura.estado,   dbo.factura_vs_comprobante.nombre AS nombre_de, dbo.tipo_comprobante.tipo, dbo.empresa.nombre AS empresa, dbo.empresa.rnc, dbo.sucursal.nombre AS sucursal, dbo.sucursal.telefono FROM            dbo.articulo INNER JOIN  dbo.detalle_factura ON dbo.articulo.codigo = dbo.detalle_factura.articulo INNER JOIN  dbo.factura ON dbo.detalle_factura.factura_numero = dbo.factura.numero INNER JOIN   dbo.desglose ON dbo.factura.numero = dbo.desglose.numero INNER JOIN   dbo.usuario ON dbo.factura.usuario = dbo.usuario.usuario INNER JOIN    dbo.cliente ON dbo.factura.cliente = dbo.cliente.codigo INNER JOIN   dbo.factura_vs_comprobante ON dbo.factura.numero = dbo.factura_vs_comprobante.numero INNER JOIN  dbo.tipo_comprobante ON dbo.factura.comprobante = dbo.tipo_comprobante.cod_tipo INNER JOIN  dbo.sucursal ON dbo.usuario.sucursal = dbo.sucursal.codigo INNER JOIN  dbo.empresa ON dbo.sucursal.empresa = dbo.empresa.codigo";
                //int pas = dataGridView1.CurrentCell.RowIndex;
            //textBox1.Text = Convert.ToString(dataGridView1.Rows[pas].Cells[0].Value);

            comandos += " where dbo.factura.numero='" + numfac + "'";
            
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
       public void comprobante()
       {
           DataSet ds = utilidades.utility.conectarsupermercado("Select * from comprobante");
           DataSet dss = utilidades.utility.conectarsupermercado("Select *from  tipo_comprobante where cod_tipo='" + txttipo.Text.Trim() + "'");
           if (ds.Tables.Count == 0)
           {
               MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
               return;
           }

           //llenar los datos
           if (ds.Tables[0].Rows.Count > 0)
           {
               ncf.Text = ds.Tables[0].Rows[0]["serie"].ToString().Trim();
               ncf.Text += ds.Tables[0].Rows[0]["divicion"].ToString().Trim();
               ncf.Text += ds.Tables[0].Rows[0]["sucursal"].ToString().Trim();
               ncf.Text += ds.Tables[0].Rows[0]["caja"].ToString().Trim();
               ncf.Text += txttipo.Text.Trim();
           }
           else
           {
               ncf.Text = "";
           }
           if (dss.Tables[0].Rows.Count > 0)
           {
               ncf.Text += dss.Tables[0].Rows[0]["secuencia"].ToString().Trim();
               long aumento = Convert.ToInt64(dss.Tables[0].Rows[0]["secuencia"].ToString().Trim());
               string nuevo=numConCeros(aumento);
             // MessageBox.Show("original", Convert.ToString(aumento));
              aumentarcomprobante(nuevo);
               /*DataSet dd = utilidades.utility.aumentarcomprobante(aumento, Convert.ToInt16(txttipo.Text.Trim()));
               if (dd.Tables.Count == 0)
               {
                   MessageBox.Show("ERROR ASIGNANDO COMPROBANTE");
                   return;
               }*/
           }
       }
       public String numConCeros(long numeroOrig)
       {
           String res = "";
           
           numeroOrig = numeroOrig + 1;
           if (numeroOrig >= 1)
              res = "0000000" + numeroOrig;
           if (numeroOrig >= 10)
               res = "000000" + numeroOrig;
           if (numeroOrig >= 100)
               res = "00000" + numeroOrig;
           if (numeroOrig >= 1000)
               res = "0000" + numeroOrig;
           if (numeroOrig >= 10000)
               res = "000" + numeroOrig;
           if (numeroOrig >= 100000)
               res = "00" + numeroOrig;
           if (numeroOrig >= 1000000)
               res = "0" + numeroOrig;
           if (numeroOrig >= 10000000)
               res = "" + numeroOrig;
           
           return res;
       }
        public void aumentarcomprobante(string nume)
       {
                     
           DataSet ds = utilidades.utility.conectarsupermercado("update tipo_comprobante set secuencia='" + nume + "' where cod_tipo='"+txttipo.Text.Trim()+"'");
          
       }

        public void agregardetalle()
       {
           try
           {
               
               string cmd3 = "";
               foreach (DataGridViewRow row in dataGridView1.Rows)
               {

                   string cod ="";
                   double cantidad = 0;
                   double precio = 0;
                   double impotar = 0, itbis=0;
                   cod = Convert.ToString(row.Cells["codigo"].Value.ToString());
                   cantidad = Convert.ToDouble(row.Cells["cantidad"].Value.ToString());
                   precio = Convert.ToDouble(row.Cells["precio"].Value.ToString());
                   itbis = Convert.ToDouble(row.Cells["tbis"].Value.ToString());
                   impotar = Convert.ToDouble(row.Cells["importe"].Value.ToString());

                   cmd3 += string.Format("  exec actualizadetallefactura '" + numfac + "','" + cod + "','" + cantidad + "','" + precio + "','" + itbis + "','" + impotar + "'");
                  // utilidades.utility.conectarsupermercado(cmd3);
                   //cmd3 = "";
               }
               utilidades.utility.conectarsupermercado(cmd3);
               MessageBox.Show("FACTURA GUARDADA CORRECTAMENTE");
               
               
           }
           catch
           {
               MessageBox.Show("ERROR GUARDANDO EL DETALLE DE LA FACTURA");
           }
       }



        public void reducirexistencia()
        {
            try
            {

                string cmd3 = "";
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    string art = "";
                    double cantidad = 0;
                    int unid = 0;
                    int alma = 2;
                    art = Convert.ToString(row.Cells["codigo"].Value.ToString());
                    cantidad = Convert.ToDouble(row.Cells["cantidad"].Value.ToString());
                    unid= Convert.ToInt16(row.Cells["unidad2"].Value.ToString());
                    //itbis = Convert.ToDouble(row.Cells["tbis"].Value.ToString());
                    //impotar = Convert.ToDouble(row.Cells["importe"].Value.ToString());

                    cmd3 = string.Format("exec reducirexistencia '" + alma + "','" + art + "','" + unid + "','" + cantidad + "'");
                    utilidades.utility.conectarsupermercado(cmd3);
                    cmd3 = "";
                }
                //MessageBox.Show("EXISTENCIA REDUCIDA CORRECTAMENTE");
                

            }
            catch
            {
                MessageBox.Show("ERROR REDUCIENDO LAS EXISTENCIA");
            }
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
                            canart.Focus();
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

        private void canart_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumerodecimal(e);
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            //reimprimir();
            limpiar();
        }

        public void limpiar()
        {
            codcli.Text = "";
            codcli.Text = "0";
            cliente.Text = "";
            codart.Text = "";
            desart.Text = "";
            txtprecio.Text = "";
            canart.Text = "";
            impo.Text = "";
            txttipo.Text = "02";
            RNC.Text = "";
            CONSUMIDOR_FINAL.Text = "";
            VALIDO.Text = "";
            RNC.Visible = false;
            CONSUMIDOR_FINAL.Visible = false;
            VALIDO.Visible = false;
            credito.Visible = false;
            dataGridView1.Rows.Clear();
            total = 0;
            totalimpuesto = 0;
            txtitbis.Text = "";

        }

        private void canart_TextChanged(object sender, EventArgs e)
        {
           /* double valor=0;
            valor = Convert.ToDouble(canart.Text.Trim());
            canart.Text = string.Format("{0:n2}", (Math.Truncate(valor * 100) / 100));
            * */
        }

        public void sumatotal()
        {
            totalimpuesto = 0;
            total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

               
                double impotar = 0, itbis = 0;
                itbis = Convert.ToDouble(row.Cells["tbis"].Value.ToString());
                impotar = Convert.ToDouble(row.Cells["importe"].Value.ToString());
                impotar = Math.Round(impotar,2);
                
                total =total+ impotar;
                totalimpuesto =totalimpuesto+ itbis;
                totalimpuesto = Math.Round(totalimpuesto,2);
                
            }
                impo.Text =Convert.ToString(total);
                txtitbis.Text =Convert.ToString(totalimpuesto);

        }

        

        private void canart_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    insectarart();
                    break;
            }
        }

        public void grabar()
        {
            try
            {
                
                if (impo.Text == "0.00")
                {
                    MessageBox.Show("NO PUEDE GRABAR UNA FACTURA EN BLANCO");
                }
                else
                {
                    Desglose obj = new Desglose();
                    obj.impo.Text = this.impo.Text.Trim();
                    if (obj.ShowDialog() == DialogResult.OK)
                    {
                        comprobante();
                        agregarfactura();
                        desglose(Convert.ToDouble(obj.txtefectivo.Text.Trim()), Convert.ToDouble(obj.txttarjeta.Text.Trim()), Convert.ToDouble(obj.txtcheque.Text.Trim()), Convert.ToDouble(obj.txtdevuelta.Text.Trim()));
                        agregardetalle();
                        guardarcomprobante();
                        reducirexistencia();
                        ventacredito();
                        reimprimir();
                        limpiar();

                    }

                }
            }
            catch
            {
                MessageBox.Show("ERROR AL INTENTAR GUARDAR LA FACTURA");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        public void ventacredito()
        {
            if(credito.Visible==true)
            {
                try
                {
                    DataSet dss;
                    string cmd2 = "";
                    double descuento = 0;
                    MessageBox.Show("PASAR AL DEPARTAMENTO DE COBROS PARA REALIZAR EL PAGO");
                    cmd2 = string.Format(" exec actualizadetallecobro '" + numfac + "','" + impo.Text.Trim() + "','" + impo.Text.Trim() + "','" + descuento + "','" + estado + "','" + codcli.Text.Trim() + "'");
                    //dss.Clear();
                    dss = utilidades.utility.conectarsupermercado(cmd2);
                    if (dss.Tables.Count == 0)
                    {
                        MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                        return;
                    }
                    else
                    {
                        //numfac = Convert.ToInt16(dss.Tables[0].Rows[0]["numero"].ToString().Trim());
                    }

                }
                catch
                {
                    MessageBox.Show("NO SE AGREGO AL CREDITO DEL CLIENTE, VUELVA A INTENTARLO");
                }
            }
        }

        private void txtunidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtunidad.Text.Trim())) return;
                DataSet dss = utilidades.utility.conectarsupermercado("SELECT        TOP (100) PERCENT dbo.unidad.nombre, dbo.unidad_vs_articulo.precio, dbo.unidad_vs_articulo.codart, dbo.almacen_vs_articulo.codigo, dbo.almacen_vs_articulo.coduni FROM            dbo.almacen_vs_articulo INNER JOIN  dbo.unidad_vs_articulo ON dbo.almacen_vs_articulo.coduni = dbo.unidad_vs_articulo.coduni INNER JOIN dbo.unidad ON dbo.almacen_vs_articulo.coduni = dbo.unidad.codigo AND dbo.unidad_vs_articulo.coduni = dbo.unidad.codigo WHERE dbo.almacen_vs_articulo.codigo = 2 and codart='" + codart.Text.Trim() + "' and dbo.almacen_vs_articulo.coduni=" + txtunidad.SelectedValue);


                if (dss.Tables.Count == 0)
                {
                    MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                    return;
                }

                txtprecio.DataSource = dss.Tables[0];

                txtprecio.DisplayMember = "precio";
            }
            catch
            {
                MessageBox.Show("NO SE PUDO OBTENER LA INFORMACION");
            }
        }

        private void txtunidad_Click(object sender, EventArgs e)
        {

            
        }

        private void ncf_TextChanged(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        
        
    }
}
