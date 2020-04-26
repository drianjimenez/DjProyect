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
    public partial class Factura_Devolucion : base_consulta
    {
        public Factura_Devolucion()
        {
            InitializeComponent();
        }

        private void Factura_Devolucion_Load(object sender, EventArgs e)
        {

        }

        private void numero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numero.Text.Trim())) return;
            try
            {
                DataSet ds = utilidades.utility.conectarsupermercado("Select *from  factura where numero='" + numero.Text.Trim() + "'");
                //DataSet dss = utilidades.utility.conectarsupermercado("select *from vista_detalle_factura WHERE factura_numero =" + numero.Text.Trim());
                if (ds.Tables.Count == 0)
                {
                    MessageBox.Show("ERROR AL CONECTAR CON LA BASE DE DATOS");
                    return;
                }

                //llenar los datos
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Devolucion_Venta obj = new Devolucion_Venta();
                    obj.numero.Text = numero.Text;
                    obj.txtusuario.Text = codigo.Text;
                    obj.Show();
                    Close();
                }

                else
                {
                    MessageBox.Show("DOCUMENTO NO EXISTE");
                    return;

                }

            }
            catch
            {

            }
        }

        private void numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.utility.validarnumero(e);
        }
    }
}
