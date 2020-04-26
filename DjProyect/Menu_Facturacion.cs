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
    public partial class Menu_Facturacion : Menu
    {
        private int childFormNumber = 0;

        public Menu_Facturacion()
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
            //this.Close();
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

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulo obj = new Modulo();
            obj.txtusuario.Text = txtusu.Text;
            obj.Show();
            this.Close();
        }

        private void fACTURACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion obj = new Facturacion();
            obj.txtusuario.Text = txtusu.Text;
           // obj.Show();
            obj.ShowDialog();
        }

        private void cONSULTAFACTURAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta_Factura obj = new Consulta_Factura();
            obj.ShowDialog();
        }

        private void dEVOLUCIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura_Devolucion obj = new Factura_Devolucion();
            obj.codigo.Text = txtusu.Text;
            obj.ShowDialog();
        }

        private void pORUSUARIOIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cuadre_Usuario obj = new Cuadre_Usuario();
            //obj.codigo.Text = txtusu.Text;
            obj.ShowDialog();
        }

        private void rEPORTEFACTURARESUMIDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Facturas obj = new Reporte_Facturas();
            obj.ShowDialog();
        }

        private void gENERARToolStripMenuItem_Click(object sender, EventArgs e)
        {
           cuadre_detallado  obj = new cuadre_detallado();
            obj.ShowDialog();
        }

        private void Menu_Facturacion_Load(object sender, EventArgs e)
        {

        }
    }
}
