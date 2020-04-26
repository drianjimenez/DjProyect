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
    public partial class mostrar_cuentas_pendiente : Mostrar
    {
        public mostrar_cuentas_pendiente()
        {
            InitializeComponent();
        }

        private void mostrar_cuentas_pendiente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cobros_porcobrarDataSet.vista_cobros_porcobrar' Puede moverla o quitarla según sea necesario.
            this.vista_cobros_porcobrarTableAdapter.Fill(this.cobros_porcobrarDataSet.vista_cobros_porcobrar);

        }
    }
}
