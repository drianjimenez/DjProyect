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
    public partial class Mantenimiento_Articulo : base_mantenimiento
    {
        public Mantenimiento_Articulo()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {

        }

        private void Mantenimiento_Articulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'itbisDataSet.itbis' Puede moverla o quitarla según sea necesario.
            this.itbisTableAdapter.Fill(this.itbisDataSet.itbis);
            // TODO: esta línea de código carga datos en la tabla 'unidadDataSet.unidad' Puede moverla o quitarla según sea necesario.
            this.unidadTableAdapter.Fill(this.unidadDataSet.unidad);
            // TODO: esta línea de código carga datos en la tabla 'departamentoDataSet.departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter.Fill(this.departamentoDataSet.departamento);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            salvar();
        }

        public void salvar()
        {
            DataSet dss;

            string cmd = string.Format("Exec actualizaarticulo '{0}','{1}','{2}','{3}','{4}','{5}'", txtcodigo.Text.Trim(), txtdescripcion.Text.Trim(), txtfecha.Value.ToShortDateString(), txtdepartamento.SelectedValue, txtsuplidor.Text.Trim(), txtreorden.Text.Trim());
            dss = utilidades.utility.conectarsupermercado(cmd);


            if (dss.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL GUARDAR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                MessageBox.Show("GUARDADO CORRECTAMENTE");

                blanquear();
                txtcodigo.Text = "";
                txtcodigo.Focus();
            }

        } 
        
        public void blanquear()
        {
            txtdescripcion.Text = "";
            txtsuplidor.Text = "";
            txtreorden.Text = "";
            txtfecha.Text = "";
            txtdepartamento.SelectedValue = -1;
            txtnomsuplidor.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtcodigo.Text = "";
            txtcodigo.Focus();
            blanquear();
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
                txtnomsuplidor.Text = ds.Tables[0].Rows[0]["nombre"].ToString().Trim();

            }

            else
            {

                txtnomsuplidor.Text = "";

            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
            this.txtcodigo.CharacterCasing = CharacterCasing.Upper;
            if (string.IsNullOrEmpty(txtcodigo.Text.Trim())) return;
            DataSet ds = utilidades.utility.conectarsupermercado("Select *from  articulo where codigo='" + txtcodigo.Text.Trim() + "'");
            if (ds.Tables.Count == 0)
            {
                MessageBox.Show("ERROR AL CONECTAR A LA BASE DE DATOS");
                return;
            }

            //llenar los datos
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtdescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString().Trim();
                txtsuplidor.Text = ds.Tables[0].Rows[0]["suplidor"].ToString().Trim();
                txtreorden.Text = ds.Tables[0].Rows[0]["punto_reorden"].ToString().Trim();
                txtfecha.Text = ds.Tables[0].Rows[0]["fecha_registro"].ToString().Trim();
                txtdepartamento.SelectedValue = ds.Tables[0].Rows[0]["departamento"].ToString().Trim();
            }
            else
            {
                blanquear();
            }
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {
            this.txtdescripcion.CharacterCasing = CharacterCasing.Upper;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void txtreorden_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtreorden_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumerodecimal(e);
        }

        private void txtsuplidor_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consulta_Articulo doForm = new Consulta_Articulo();
            if (doForm.ShowDialog() == DialogResult.OK)
            {
                txtcodigo.Text = doForm.codigo.Text;
                txtcodigo.Focus();
                SendKeys.Send("{enter}");
            }
        }

        

    }
}
