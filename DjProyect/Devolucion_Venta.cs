using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DjProyect
{
    public partial class Devolucion_Venta : base_mantenimiento
    {
        public Devolucion_Venta()
        {
            InitializeComponent();
        }
        double total=0.00;
        string estadonota = "DEVOLUCION";
        int nota = 0;
        string credito = "";
        int cliente = 0;
        private void buttonX2_Click(object sender, EventArgs e)
        {
            Consulta_Factura doForm = new Consulta_Factura();
            if (doForm.ShowDialog() == DialogResult.OK)
            {
                numero.Text = doForm.codigo.Text;
                numero.Focus();
                SendKeys.Send("{enter}");
            }
        }

        private void Devolucion_Venta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vista_detalle_facturaDataSet.vista_detalle_factura' Puede moverla o quitarla según sea necesario.
            this.vista_detalle_facturaTableAdapter.Fill(this.vista_detalle_facturaDataSet.vista_detalle_factura);
            // TODO: esta línea de código carga datos en la tabla 'vista_detalle_facturaDataSet.vista_detalle_factura' Puede moverla o quitarla según sea necesario.
            this.vista_detalle_facturaTableAdapter.Fill(this.vista_detalle_facturaDataSet.vista_detalle_factura);
            // TODO: esta línea de código carga datos en la tabla 'vista_detalle_facturaDataSet.vista_detalle_factura' Puede moverla o quitarla según sea necesario.
            this.vista_detalle_facturaTableAdapter.Fill(this.vista_detalle_facturaDataSet.vista_detalle_factura);
            // TODO: esta línea de código carga datos en la tabla 'vista_detalle_facturaDataSet.vista_detalle_factura' Puede moverla o quitarla según sea necesario.
            //this.vista_detalle_facturaTableAdapter.Fill(this.vista_detalle_facturaDataSet.vista_detalle_factura);
            //dataGridView1.Rows.Clear();
            impo.Text=Convert.ToString(total);
            seleccionartodo();
        }

        private void numero_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numero.Text.Trim())) return;
            try
            {
                DataSet ds = utilidades.utility.conectarsupermercado("Select *from  factura where numero='" + numero.Text.Trim() + "'");
                DataSet dss = utilidades.utility.conectarsupermercado("select *from vista_detalle_factura WHERE factura_numero =" + numero.Text.Trim());
                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                    return;
                }

                //llenar los datos
                if (ds.Tables[0].Rows.Count > 0)
                {
                    monto.Text = ds.Tables[0].Rows[0]["monto"].ToString().Trim();
                    comprobante.Text = ds.Tables[0].Rows[0]["ncf"].ToString().Trim();
                    credito = ds.Tables[0].Rows[0]["estado"].ToString().Trim();
                    cliente =Convert.ToInt16(ds.Tables[0].Rows[0]["cliente"].ToString().Trim());
                }

                else
                {

                    monto.Text = "";
                    comprobante.Text = "";

                }

                if (dss.Tables[0].Rows.Count > 0)
                {
                    dataGridView1.DataSource = dss.Tables[0];


                }
                else
                {
                    dataGridView1.Rows.Clear();
                }
            }
            catch
            {

            }

        }
            
        public void sumatotal()
        {
           
            total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Boolean est = Convert.ToBoolean(row.Cells["estado"].Value);

                if (est == true)
                {
                    double impotar = 0;
                    //itbis = Convert.ToDouble(row.Cells["tbis"].Value.ToString());
                    impotar = Convert.ToDouble(row.Cells["importeDataGridViewTextBoxColumn"].Value.ToString());
                    total = total + impotar;
                } 
                
                
            }
                impo.Text =Convert.ToString(total);
               

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            sumatotal();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sumatotal();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            sumatotal();
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            sumatotal();
        }

        private void monto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntodo_Click(object sender, EventArgs e)
        {
            seleccionartodo();
        }

        public void seleccionartodo()
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                row.Cells["estado"].Value = true;


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

                row.Cells["estado"].Value = false;


            }

        }

        public void aumentarexistencia()
        {
                try
            {

                string cmd3 = "";
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Boolean est = Convert.ToBoolean(row.Cells["estado"].Value);

                    if (est == true)
                    {
                       string cod = "";
                    double cantidad = 0;
                    int alma = 2, coduni=0;
                    // double impotar = 0, itbis = 0;
                    cod = Convert.ToString(row.Cells["articuloDataGridViewTextBoxColumn"].Value.ToString());
                    cantidad = Convert.ToDouble(row.Cells["cantidadDataGridViewTextBoxColumn"].Value.ToString());
                    //alma = Convert.ToInt16(row.Cells["al"].Value.ToString());
                    coduni = Convert.ToInt16(row.Cells["coduniDataGridViewTextBoxColumn"].Value.ToString());
                    //itbis = Convert.ToDouble(row.Cells["tbis"].Value.ToString());
                    //impotar = Convert.ToDouble(row.Cells["importe"].Value.ToString());

                    cmd3 = string.Format("exec actualizaexistencia '" + alma + "','" + cod + "','" + coduni + "','" + cantidad + "'");
                    utilidades.utility.conectarsupermercado(cmd3);
                    cmd3 = "";
                   
                    } 
                    
                }
                // MessageBox.Show("NUEVOS ARTICULOS AGREGADOS AL ALMACEN");

                //reimprimir();
                //cancelar();

            }
                catch
                {
                    MessageBox.Show("ERROR GUARDANDO LOS ARTICULOS PARA EL ALMACEN");
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
             try
            {
                 if(Convert.ToDouble(impo.Text.Trim())>0)
                 {
                    sumatotal();
                agregarnotacredito();
                
                actualizacomprobante();
                
                limpiar();
                Close();
                 }
                 else
                 {
                     MessageBox.Show("NO PUEDE GRABAR UNA DEVOLUCION CON VALOR DE CERO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                 }
                

            }
            catch
            {
                MessageBox.Show("ERROR AL GUARDAR");
            }
        }



        public void agregarnotacredito()
        {
            try
            {
                DataSet dss;
                string cmd2 = "";
                cmd2 = string.Format(" exec actualizadevolucion_venta '" + numero.Text.Trim() + "','" + comprobante.Text.Trim() + "','" + txtusuario.Text.Trim() + "','" + impo.Text.Trim() + "','" + estadonota +"'");
                dss = utilidades.utility.conectarsupermercado(cmd2);
                if (dss.Tables.Count == 0)
                {
                    MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                    return;
                }
                else
                {
                    nota = Convert.ToInt16(dss.Tables[0].Rows[0]["codigo"].ToString().Trim());
                    if(credito=="CREDITO")
                    {
                        DataSet ds = utilidades.utility.conectarsupermercado("update factura set estado='" + estadonota + "' where numero='" + numero.Text.Trim() + "'");
                        DataSet dsx = utilidades.utility.conectarsupermercado("delete from detalle_cobro  where cliente='" + cliente + "' and monto_original='" + monto.Text.Trim() + "'");
                    }
                    
                    agregardetalle();
                }

            }
            catch
            {
                MessageBox.Show("NO SE REALIZO LA NOTA DE CREDITO, VUELVA A INTENTARLO");
            }
        }



        public void agregardetalle()
        {
            try
            {

                string cmd3 = "";
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    Boolean est = Convert.ToBoolean(row.Cells["estado"].Value);

                    if (est == true)
                    {
                        string cod = "";
                        double cantidad = 0;
                        double importar = 0;
                        cod = Convert.ToString(row.Cells["articuloDataGridViewTextBoxColumn"].Value.ToString());
                        cantidad = Convert.ToDouble(row.Cells["cantidadDataGridViewTextBoxColumn"].Value.ToString());
                        importar = Convert.ToDouble(row.Cells["importeDataGridViewTextBoxColumn"].Value.ToString());

                        cmd3 = string.Format("exec actualizadetallecredito_venta'" + nota + "','" + cod + "','" + cantidad + "','" + importar + "'");
                        utilidades.utility.conectarsupermercado(cmd3);
                        cmd3 = "";
                    } 
                    
                }
                MessageBox.Show("GUARDADA CORRECTAMENTE");
                aumentarexistencia();
               // reimprimir();
               //limpiar();

            }
            catch
            {
               // MessageBox.Show("ERROR GUARDANDO LOS ARTICULOS DE LA FACTURA");
            }
        }

        public void limpiar()
        {
            numero.Text = "";
            comprobante.Text = "";
            monto.Text = "";
            impo.Text = "";
           // dataGridView1.Rows.Clear();
        }


        public void actualizacomprobante()
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
                txtsecuencia.Text = ds.Tables[0].Rows[0]["serie"].ToString().Trim();
                txtsecuencia.Text += ds.Tables[0].Rows[0]["divicion"].ToString().Trim();
                txtsecuencia.Text += ds.Tables[0].Rows[0]["sucursal"].ToString().Trim();
                txtsecuencia.Text += ds.Tables[0].Rows[0]["caja"].ToString().Trim();
                txtsecuencia.Text += txttipo.Text.Trim();
            }
            else
            {
                txtsecuencia.Text = "";
            }
            if (dss.Tables[0].Rows.Count > 0)
            {
                txtsecuencia.Text += dss.Tables[0].Rows[0]["secuencia"].ToString().Trim();
                long aumento = Convert.ToInt64(dss.Tables[0].Rows[0]["secuencia"].ToString().Trim());
                string nuevo = numConCeros(aumento);
                // MessageBox.Show("original", Convert.ToString(aumento));
                aumentarcomprobante(nuevo);
                
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

            DataSet ds = utilidades.utility.conectarsupermercado("update tipo_comprobante set secuencia='" + nume + "' where cod_tipo='" + txttipo.Text.Trim() + "'");

        }

        private void numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }
    }
}
