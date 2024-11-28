using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasApp.Clases.Conexion
{
    public class BalanceConexion
    {
        string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        public void GuardarCuenta(Cuentas cuenta)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO BalanceGeneral (TipoCuenta, NombreCuenta, Monto) 
                                 VALUES (@TipoCuenta, @NombreCuenta, @Monto)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TipoCuenta", cuenta.TipoCuenta);
                    cmd.Parameters.AddWithValue("@NombreCuenta", cuenta.NombreCuenta);
                    cmd.Parameters.AddWithValue("@Monto", cuenta.Monto);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable ObtenerBalanceGeneral()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TipoCuenta, NombreCuenta, Monto, FechaRegistro FROM BalanceGeneral";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
    }
}
