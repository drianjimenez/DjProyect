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
    public partial class Mostrar_cxp_sinpagar : Mostrar
    {
        public Mostrar_cxp_sinpagar()
        {
            InitializeComponent();
        }

        private void Mostrar_cxp_sinpagar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cxp_facturasinpagarDataSet.vista_cxp_sinpagar' Puede moverla o quitarla según sea necesario.
            this.vista_cxp_sinpagarTableAdapter.Fill(this.cxp_facturasinpagarDataSet.vista_cxp_sinpagar);

        }
    }
}
