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

namespace FinanzasApp
{
    public partial class Creacion_Usuario : Form
    {
        private UsuarioConexion userController = new UsuarioConexion();
        public Creacion_Usuario()
        {
            InitializeComponent();
        }

        private void IconbAceptar_Click(object sender, EventArgs e)
        {
            string username = txtusuario.Text;
            string password = txtcontra.Text;

            if (userController.RegisterUser(username, password))
            {
                MessageBox.Show("Usuario registrado correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario.");
            }
        }
    }
}
