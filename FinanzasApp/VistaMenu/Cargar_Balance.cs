using FinanzasApp.Clases.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanzasApp.VistaMenu
{
    public partial class Cargar_Balance : Form
    {
        public Cargar_Balance()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e, object dataTable)
        {
            BalanceConexion balanceConexion = new BalanceConexion();

            dgvBalance.DataSource = dataTable;
        }
    }
}
