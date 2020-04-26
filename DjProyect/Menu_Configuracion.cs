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
    public partial class Menu_Configuracion : Menu
    {
        private int childFormNumber = 0;

        public Menu_Configuracion()
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
           // statusStrip.Visible = statusBarToolStripMenuItem.Checked;
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

        private void cREARUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_Usuario obj = new Mantenimiento_Usuario();
            obj.ShowDialog();
        }

        private void Menu_Configuracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulo obj = new Modulo();
            obj.txtusuario.Text = txtusu.Text;
            obj.Show();
            this.Close();
        }

        private void cONSULTAUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Usuario obj = new Consulta_Usuario();
            obj.ShowDialog();
        }

        private void cOMPROBANTEFISCALToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Mantenimiento_Comprobante_Fiscal obj = new Mantenimiento_Comprobante_Fiscal();
            obj.ShowDialog();
        }

        private void aGREGARRNCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_RNC_DesdeArchivo obj = new Agregar_RNC_DesdeArchivo();
            obj.ShowDialog();
        }
    }
}
