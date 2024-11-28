using FinanzasApp.Clases;
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
    public partial class Balance_General : Form
    {
        private readonly BalanceConexion balanceController = new BalanceConexion();
        private DataTable dataTable;

        public Balance_General()
        {
            InitializeComponent();
            InitializeDataTable();

        }

        private void InitializeDataTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("TipoCuenta");
            dataTable.Columns.Add("NombreCuenta");
            dataTable.Columns.Add("Monto", typeof(decimal));
            dataTable.Columns.Add("Categoria");
        }

        private void Balance_General_Load(object sender, EventArgs e)
        {
            cmbTipoActivos.Items.AddRange(new string[] { "Circulante", "Fijo", "Diferido" });
            cmbTipoPasivos.Items.AddRange(new string[] { "Corto Plazo", "Largo Plazo" });

            cmbTipoActivos.SelectedIndex = 0;
            cmbTipoPasivos.SelectedIndex = 0;
        }

        private void AgregarCuenta(string categoria, string tipo, string nombre, string monto)
        {
            if (decimal.TryParse(monto, out decimal montoDecimal))
            {
                dataTable.Rows.Add(tipo, nombre, montoDecimal, categoria);
                MessageBox.Show($"{categoria} agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            AgregarCuenta("Activo", cmbTipoActivos.Text, txtNombreCuenta.Text, txtMonto.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            AgregarCuenta("Pasivo", cmbTipoPasivos.Text, txtNombreCuenta.Text, txtMonto.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarCuenta("Capital", "Capital", txtNombreCuenta.Text, txtMonto.Text);
        }

        private decimal CalcularTotal(string categoria)
        {
            decimal total = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                if (row["Categoria"].ToString() == categoria)
                {
                    total += Convert.ToDecimal(row["Monto"]);
                }
            }

            return total;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            decimal totalActivos = CalcularTotal("Activo");
            decimal totalPasivos = CalcularTotal("Pasivo");
            decimal totalCapital = CalcularTotal("Capital");

            MessageBox.Show($"Total Activos: {totalActivos:C}\nTotal Pasivos: {totalPasivos:C}\nTotal Capital: {totalCapital:C}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GuardarEnBaseDatos();
        }
        private void GuardarEnBaseDatos()
        {
            foreach (DataRow row in dataTable.Rows)
            {
                Cuentas cuenta = new Cuentas
                {
                    TipoCuenta = row["TipoCuenta"].ToString(),
                    NombreCuenta = row["NombreCuenta"].ToString(),
                    Monto = Convert.ToDecimal(row["Monto"]),
                    Categoria = row["Categoria"].ToString()
                };

                balanceController.GuardarCuenta(cuenta);
            }

            MessageBox.Show("Datos guardados en la base de datos exitosamente.");
        }
    }
}
