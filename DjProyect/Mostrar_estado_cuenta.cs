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
    public partial class Mostrar_estado_cuenta : Mostrar
    {
        public Mostrar_estado_cuenta()
        {
            InitializeComponent();
        }

        private void Mostrar_estado_cuenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'vista_estado_cuentaDataSet.vista_estado_cuenta' Puede moverla o quitarla según sea necesario.
            //this.vista_estado_cuentaTableAdapter.Fill(this.vista_estado_cuentaDataSet.vista_estado_cuenta);

        }
    }
}
