using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DjProyect
{
    public partial class Agregar_RNC_DesdeArchivo : Form1
    {
        public Agregar_RNC_DesdeArchivo()
        {
            InitializeComponent();
        }

        private void rn_TextChanged(object sender, EventArgs e)
        {
            string[] prueba, pp;
           
            //string resultado = File.ReadAllLines("C:\\Users\\drian\\Desktop\\DGII_RNC.txt").Where(X => X.Contains(rn.Text.Trim() + "|")).First();
           /* string resultado = File.ReadAllText("C:\\Users\\drian\\Desktop\\DGII_RNC.txt");

            
            prueba = (resultado.Split('|'));


              MessageBox.Show(resultado);
            */

            StreamReader read = new StreamReader("C:\\Users\\drian\\Desktop\\consulta_rnc.txt");
            string cad = "";
        /*    while (read.ReadLine() != null)
            {

          //  string resultado = File.ReadAllText("C:\\Users\\drian\\Desktop\\consulta_rnc.txt");
            //string resultado = File.ReadAllLines("C:\\Users\\drian\\Desktop\\DGII_RNC.txt").Where(X => X.Distinct(2)).First();
               // prueba = (resultado.Split('|'));
                
               
                cad += read.ReadLine() + "|";

                prueba = (cad.Split('|')); 
                nombre.Text += Convert.ToString(prueba[1]);
                categoria.Text += Convert.ToString(prueba[3]);
                direccion.Text = Convert.ToString(prueba[4]);
                telefono.Text = Convert.ToString(prueba[7]);
                fecha.Text = Convert.ToString(prueba[8]);
                estado.Text = Convert.ToString(prueba[9]);

                MessageBox.Show(prueba[1]);
                //prueba[1] = Convert.ToString("999");
                
            }
            read.Close();
            */
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\drian\Desktop\consulta_rnc.txt");
            foreach (string line in lines)
            {
               /* prueba = (line.Split('|')); 
                nombre.Text += Convert.ToString(prueba[1]);
                categoria.Text += Convert.ToString(prueba[3]);
                direccion.Text = Convert.ToString(prueba[4]);
                telefono.Text = Convert.ToString(prueba[7]);
                fecha.Text = Convert.ToString(prueba[8]);
                estado.Text = Convert.ToString(prueba[9]);
                MessageBox.Show(prueba[1]);*/
            }


           // prueba = (cad.Split('|'));
                for (int i = 1; i <= 6; i++)
                {
                  

                }
              //  MessageBox.Show(prueba[18]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double conteo = 0;
            string[] prueba;
            //guardar
            /*   string resultado = File.ReadAllLines("C:\\Users\\drian\\Desktop\\DGII_RNC.txt").Where(X => X.Contains(rn.Text.Trim() + "|")).First();
               string[] prueba;
               prueba = (resultado.Split('|'));
   */

            // MessageBox.Show(resultado);

            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\drian\OneDrive\Documents\Visual Studio 2013\Projects\DjProyect\DGII_RNC.txt");
            string[] lines = System.IO.File.ReadAllLines(@nombrearchivo.Text);

            foreach (string line in lines)
            {
                conteo++;
             
            }
            string mes = "EXISTEN " + Convert.ToString(conteo) + " REGISTRO EN ESTE ARCHIVO, ESPERE MIENTRAS SE REGISTRAN LOS DATOS";

             MessageBox.Show(Convert.ToString(mes));
            progreso.Maximum =Convert.ToInt32( conteo+1 );
           // lines = System.IO.File.ReadAllLines(@"C:\Users\drian\OneDrive\Documents\Visual Studio 2013\Projects\DjProyect\DGII_RNC.txt");
            foreach (string line in lines)
            {
                //MessageBox.Show(Convert.ToString(14));
                prueba = (line.Split('|'));
             
                if (Convert.ToInt64(prueba[0]) != 210000000)
                {
                    DataSet dss;
                    string cmd3 = string.Format("exec rnc '" + Convert.ToInt64(prueba[0]) + "','" + Convert.ToString(prueba[1]) + "','" + Convert.ToString(prueba[3]) + "','" + Convert.ToString(prueba[4]) + "','" + Convert.ToString(prueba[7]) + "','" + Convert.ToString(prueba[8]) + "','" + Convert.ToString(prueba[9]) + "'");
                    dss = utilidades.utility.conectarsupermercado(cmd3);
                    progreso.Value++;

                }

            }




            MessageBox.Show("GUARDADO CORRECTAMENTE");
                  
         /*   StreamReader sr = new StreamReader("C:\\Users\\drian\\Desktop\\DGII_RNC.txt");

                   int contar = 1;
                   
                    while (sr.Peek() != -1)
                    {
                        sr.ReadLine();
                        contar++;

                    }*/
                    
            
        }

        private void nombre1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                nombrearchivo.Text = openFileDialog1.FileName;


            }
        }
    }
}
