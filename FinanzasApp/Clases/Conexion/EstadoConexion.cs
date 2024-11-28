using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasApp.Clases.Conexion
{
    public class EstadoConexion
    {
        string connectionString = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

        public void GuardarCuenta(EstadoResultado cuenta)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO EstadoResultado 
                                 (IngresoOperativo, CostoVentas, GastosOperativos, OtrosIngresos, OtrosGastos, Impuestos) 
                                 VALUES 
                                 (@IngresoOperativo, @CostoVentas, @GastosOperativos, @OtrosIngresos, @OtrosGastos, @Impuestos)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Asignamos los valores
                    cmd.Parameters.AddWithValue("@IngresoOperativo", cuenta.IngresoOperativo);
                    cmd.Parameters.AddWithValue("@CostoVentas", cuenta.CostoVentas);
                    cmd.Parameters.AddWithValue("@GastosOperativos", cuenta.GastosOperativos);
                    cmd.Parameters.AddWithValue("@OtrosIngresos", cuenta.OtrosIngresos);
                    cmd.Parameters.AddWithValue("@OtrosGastos", cuenta.OtrosGastos);
                    cmd.Parameters.AddWithValue("@Impuestos", cuenta.Impuestos);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Obtener los datos del estado de resultados
        public DataTable ObtenerEstadoResultado()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM EstadoResultado";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dataTable);
                }
            }
            return dataTable;
        }
    }
}
