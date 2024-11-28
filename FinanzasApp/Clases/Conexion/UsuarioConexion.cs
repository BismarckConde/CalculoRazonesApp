using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasApp.Clases.Conexion
{
    public class UsuarioConexion
    {
        public bool RegisterUser(string username, string password)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "INSERT INTO Usuario (NombreUsuario, Contrasena) VALUES (@Username, @Password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Login(string username, string password)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Usuario WHERE NombreUsuario = @Username AND Contrasena = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }
    }
}
