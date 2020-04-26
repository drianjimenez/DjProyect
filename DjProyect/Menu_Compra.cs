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
    public partial class Menu_Compra : Menu
    {
        private int childFormNumber = 0;

        public Menu_Compra()
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

        private void cREARSUPLIDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimiento_Suplidor obj = new Mantenimiento_Suplidor();
            obj.ShowDialog();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulo obj = new Modulo();
            obj.txtusuario.Text = txtusu.Text;
            obj.Show();
            this.Close();
        }

        private void rEGISTRARCOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra obj = new Compra();
            obj.txtusuario.Text = txtusu.Text;
            obj.MdiParent = this.MdiParent;
            obj.ShowDialog();
            //this.Close();
        }

        private void cONSULTACOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Consulta_Compra obj = new Consulta_Compra();
            //obj.txtusuario.Text = txtusu.Text;
            obj.ShowDialog();
        }

        private void rEPORTECOMPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cOMPRAPORCODIGOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Compra obj = new Reporte_Compra();
            //obj.txtusuario.Text = txtusu.Text;
            obj.ShowDialog();
        }

        private void cOMPRARESUMIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Compra_Detallada obj = new Reporte_Compra_Detallada();
            //obj.txtusuario.Text = txtusu.Text;
            obj.ShowDialog();
        }

        private void rEGISTRARCOMPRAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Compra obj = new Compra();
            obj.txtusuario.Text = txtusu.Text;
            obj.MdiParent = this.MdiParent;
            obj.ShowDialog();
        }

        private void cONSULTACOMPRAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            Consulta_Compra obj = new Consulta_Compra();
            //obj.txtusuario.Text = txtusu.Text;
            obj.ShowDialog();
        }

        private void sUPLIDORToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
