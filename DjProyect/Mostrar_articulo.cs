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
    public partial class Mostrar_articulo : Mostrar
    {
        public Mostrar_articulo()
        {
            InitializeComponent();
        }

        private void Mostrar_articulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vistaarticulo.vistaarticulo' Puede moverla o quitarla según sea necesario.
           // this.vistaarticuloTableAdapter.Fill(this.vistaarticulo.vistaarticulo);

        }
    }
}
