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
    public partial class Mostrar_Compra_Detallada : Mostrar
    {
        public Mostrar_Compra_Detallada()
        {
            InitializeComponent();
        }

        private void Mostrar_Compra_Detallada_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'compraDataSet.vista_compra' Puede moverla o quitarla según sea necesario.
            //this.vista_compraTableAdapter.Fill(this.compraDataSet.vista_compra);

        }
    }
}
