using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasApp.Clases
{
    public class BalanceModel
    {
        public int IdBalanceGeneral { get; set; }
        public string TipoCuenta { get; set; }
        public string NombreCuenta { get; set; }
        public decimal Monto { get; set; }
    }
}
