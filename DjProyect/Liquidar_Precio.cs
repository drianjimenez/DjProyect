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
    public partial class Liquidar_Precio : base_mantenimiento
    {
        public Liquidar_Precio()
        {
            InitializeComponent();
        }
       
        private void Liquidar_Precio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'itbisDataSet.itbis' Puede moverla o quitarla según sea necesario.
            this.itbisTableAdapter.Fill(this.itbisDataSet.itbis);
            // TODO: esta línea de código carga datos en la tabla 'porciento_gananciaDataSet.porciento_ganancia' Puede moverla o quitarla según sea necesario.
            this.porciento_gananciaTableAdapter.Fill(this.porciento_gananciaDataSet.porciento_ganancia);
            // TODO: esta línea de código carga datos en la tabla 'unidadDataSet.unidad' Puede moverla o quitarla según sea necesario.
            this.unidadTableAdapter.Fill(this.unidadDataSet.unidad);
            // TODO: esta línea de código carga datos en la tabla 'unidadDataSet.unidad' Puede moverla o quitarla según sea necesario.
            this.unidadTableAdapter.Fill(this.unidadDataSet.unidad);
            txtprecio.Text = "0.00";
            
        }

        public void limpiar()
        {
            codart.Text = "";
            txtcosto.Text = "0.00";
            txtprecio.Text = "0.00";
            txtdes.Text = "";
            txtadicional.Text = "0.00";
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
                //DataSet dss = utilidades.utility.conectarsupermercado("Select *from  itbis where codigo='" + ds.Tables[0].Rows[0]["itbis"].ToString().Trim() + "'");
               
                txtdes.Text = ds.Tables[0].Rows[0]["descripcion"].ToString().Trim();
                //txtcosto.Text = ds.Tables[0].Rows[0]["costo"].ToString().Trim();
                //txtitbis.Text = (dss.Tables[0].Rows[0]["valor"].ToString().Trim());
                //txtporciento.Text = (ganancia.Tables[0].Rows[0]["valor"].ToString().Trim());
                 //por=Convert.ToDouble(ganancia.Tables[0].Rows[0]["valor"].ToString().Trim())/10;
                 
         
            }

            else
            {

                txtdes.Text = "";
                //txtitbis.Text = "";
                //it = 0;
            }
        }

        public void evaluar()
        {

            double adi = Convert.ToDouble(txtadicional.Text.Trim());
            double cos = Convert.ToDouble(txtcosto.Text.Trim());
            double itb = Convert.ToDouble(txtitbis.Text.Trim())/100;
            double por = Convert.ToDouble(txtporciento.Text.Trim()) /10;
            
            txtprecio.Text = Convert.ToString((cos*por)+(cos*itb)+adi+cos);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Consulta_Articulo doForm = new Consulta_Articulo();
            if (doForm.ShowDialog() == DialogResult.OK)
            {
                codart.Text = doForm.codigo.Text;
                //canart.Focus();
                SendKeys.Send("{enter}");
            } 
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdes.Text.Trim()))
            {
                MessageBox.Show("DEBE DIGITAR EL CODIGO DEL PRODUCTO");
                errorProvider1.SetError(txtdes, (string.IsNullOrEmpty(txtdes.Text.Trim())) ? "Campos obligatorios" : "");
                return;
            }
            if (string.IsNullOrEmpty(txtcosto.Text.Trim()))
            {
                MessageBox.Show("DEBE DIGITAR EL COSTO DEL PRODUCTO");
                errorProvider1.SetError(txtcosto, (string.IsNullOrEmpty(txtcosto.Text.Trim())) ? "Campos obligatorios" : "");
                return;
            }
            insectarart();
            limpiar();
        }

        public void insectarart()
        {
            utilidades.utility.validar(this, errorProvider1);
            if (string.IsNullOrEmpty(codart.Text.Trim())) return;
            if (string.IsNullOrEmpty(txtprecio.Text.Trim())) return;
            if (string.IsNullOrEmpty(txtcosto.Text.Trim())) return;
            //double can = 0;
            //double pre, imp, itbis;
            //can = Convert.ToDouble(canart.Text.Trim());
            //pre = Convert.ToDouble(preart.Text.Trim());
            //imp = can * pre;
            //itbis = can * it;
            dataGridView1.Rows.Add(codart.Text.Trim(), txtdes.Text.Trim(),txtitbis.SelectedValue,txtitbis.Text.Trim(),txtunidad.SelectedValue, txtunidad.Text.Trim(),txtporciento.SelectedValue,txtporciento.Text.Trim(),txtcosto.Text.Trim(), txtprecio.Text.Trim());
            //total = total + imp;
            //sumatotal();
            // impo.Text = "";
            //txtitbis.Text = "";
            // txtitbis.Text =Convert.ToString(totalimpuesto);
            // impo.Text += Convert.ToDouble(total);
            //limpiararticulo();
            //codart.Focus();
        }

        private void txtadicional_TextChanged(object sender, EventArgs e)
        {
        }

        public void agregardetalle()
        {
            try
            {

                string cmd3 = "";
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    string cod = "";
                    double unidad = 0;
                    double precio = 0, costo=0,porciento=0,itbis=0;
                    cod = Convert.ToString(row.Cells["codigo"].Value.ToString());
                    unidad = Convert.ToDouble(row.Cells["coduni"].Value.ToString());
                    precio = Convert.ToDouble(row.Cells["precio"].Value.ToString());
                    costo = Convert.ToDouble(row.Cells["costo"].Value.ToString());
                    itbis = Convert.ToDouble(row.Cells["id_itbis"].Value.ToString());
                    porciento = Convert.ToDouble(row.Cells["id_ganancia"].Value.ToString());
                    cmd3 = string.Format("exec actualizaprecio '" + unidad + "','" + cod + "','" + precio + "','" + costo + "','" + porciento + "','" + itbis + "'");
                    utilidades.utility.conectarsupermercado(cmd3);
                    cmd3 = "";
                }
                MessageBox.Show("PRECIOS REGISTRADO EXITOSAMENTE");
               //limpiar();

            }
            catch
            {
                MessageBox.Show("ERROR AGREGANDO LOS PRECIOS");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count==0)
            {
                MessageBox.Show("DEBE AGREGAR UN PRODUCTO A LA QUE LE ASIGNARA PRECIO");
                errorProvider1.SetError(codart, (string.IsNullOrEmpty(codart.Text.Trim())) ? "Campos obligatorios" : "");
                return;
            }
            agregardetalle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("DESEA BORRAR PRODUCTO", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

            }
            if (result == DialogResult.No)
            {
                MessageBox.Show("NO SE BORRO");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limpiar();
            dataGridView1.Rows.Clear();
        }

        private void txtcosto_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
           // if (string.IsNullOrEmpty(txtcosto.Text.Trim())) return;
            if (string.IsNullOrEmpty(txtcosto.Text.Trim()))
            {
                MessageBox.Show("DEBE DIGITAR EL COSTO DEL PRODUCTO");
                errorProvider1.SetError(txtcosto, (string.IsNullOrEmpty(txtcosto.Text.Trim())) ? "Campos obligatorios" : "");
                return;
            }

            if (string.IsNullOrEmpty(txtdes.Text.Trim()))
            {
                MessageBox.Show("DEBE DIGITAR EL CODIGO DEL PRODUCTO");
                errorProvider1.SetError(txtdes, (string.IsNullOrEmpty(txtdes.Text.Trim())) ? "Campos obligatorios" : "");
                return;
            }
            evaluar();
        }

        private void txtcosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumerodecimal(e);
        }

        private void txtadicional_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumerodecimal(e);
        }
        
    }
}
