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
    public partial class Mostrar_ventas_diarias : Mostrar
    {
        public Mostrar_ventas_diarias()
        {
            InitializeComponent();
        }

        private void Mostrar_ventas_diarias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ventas_diariasDataSet.reporteventas' Puede moverla o quitarla según sea necesario.
            //this.reporteventasTableAdapter.Fill(this.ventas_diariasDataSet.reporteventas);

        }
    }
}
