using FinanzasApp.VistaMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanzasApp
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void cREARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Balance_General Form = new Balance_General();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void cARGARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cargar_Balance Form = new Cargar_Balance();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void cREARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Estado_Resultado Form = new Estado_Resultado();
            Form.ShowDialog(this);
            Form.Dispose();
        }

        private void cARGARToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cargar_Estado Form = new Cargar_Estado();
            Form.ShowDialog(this);
            Form.Dispose();
        }
    }
}
