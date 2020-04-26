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
    public partial class Menu_Inventario : Menu
    {
        private int childFormNumber = 0;

        public Menu_Inventario()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void aRTICULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aGREGARARTICULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_Articulo obj = new Mantenimiento_Articulo();
            //obj.MdiParent = this;
            obj.Show();

        }

        private void Menu_Inventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }

        private void Menu_Inventario_Load(object sender, EventArgs e)
        { 
            
           
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void aGREGARARTICULOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Mantenimiento_Articulo obj = new Mantenimiento_Articulo();
            //obj.MdiParent = this;
            obj.ShowDialog();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulo obj = new Modulo();
            obj.txtusuario.Text = txtusu.Text;
            obj.Show();
            this.Close();
        }

        private void cREARDEPARTAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_Departamento obj = new Mantenimiento_Departamento();
            obj.ShowDialog();
        }

        private void lIQUIDARPRECIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liquidar_Precio obj = new Liquidar_Precio();
            obj.ShowDialog();

        }

        private void rEPORTEDEARTICULOPORDEPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Articulo_Departamento obj = new Reporte_Articulo_Departamento();
            obj.ShowDialog();
        }

        private void cONSULTADEARTIICULOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Articulo obj = new Consulta_Articulo();
            obj.ShowDialog();
        }
    }
}
