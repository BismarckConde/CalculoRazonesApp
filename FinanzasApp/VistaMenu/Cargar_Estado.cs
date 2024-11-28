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
    public partial class Cargar_Estado : Form
    {
        private readonly EstadoConexion estadoResultadoController = new EstadoConexion();

        public Cargar_Estado()
        {
            InitializeComponent();
        }
    }
}
