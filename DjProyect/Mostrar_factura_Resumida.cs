﻿using System;
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
    public partial class Mostrar_factura_Resumida : Mostrar
    {
        public Mostrar_factura_Resumida()
        {
            InitializeComponent();
        }

        private void Mostrar_factura_Resumida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'factura_sin_detalleDataSet.vista_facturasindetalle' Puede moverla o quitarla según sea necesario.
            this.vista_facturasindetalleTableAdapter.Fill(this.factura_sin_detalleDataSet.vista_facturasindetalle);
            // TODO: esta línea de código carga datos en la tabla 'factura_sin_detalleDataSet.vista_facturasindetalle' Puede moverla o quitarla según sea necesario.
           // this.vista_facturasindetalleTableAdapter.Fill(this.factura_sin_detalleDataSet.vista_facturasindetalle);
            // TODO: esta línea de código carga datos en la tabla 'vista_factura_DataSet.vista_factura' Puede moverla o quitarla según sea necesario.
            //this.vista_facturaTableAdapter.Fill(this.vista_factura_DataSet.vista_factura);

        }
    }
}
