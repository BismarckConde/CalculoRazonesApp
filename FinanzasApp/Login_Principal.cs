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
    public partial class Login_Principal : Form
    {
        private UsuarioConexion userController = new UsuarioConexion();
        public Login_Principal()
        {
            InitializeComponent();
        }

        private void LbCrearUsuario_Click(object sender, EventArgs e)
        {
            Creacion_Usuario Form = new Creacion_Usuario();
            Form.ShowDialog(this);
            Form.Dispose();
            Form.Close();
        }

        private void IconbAceptar_Click(object sender, EventArgs e)
        {
            string username = txtUsuarioLogin.Text;
            string password = txrContraseñaLogin.Text;

            if (userController.Login(username, password))
            {
                Menu_Principal mainForm = new Menu_Principal();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
