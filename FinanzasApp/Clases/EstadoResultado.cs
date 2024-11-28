using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanzasApp.Clases
{
    public class EstadoResultado
    {
        public decimal IngresoOperativo { get; set; }
        public decimal CostoVentas { get; set; }
        public decimal GastosOperativos { get; set; }
        public decimal OtrosIngresos { get; set; }
        public decimal OtrosGastos { get; set; }
        public decimal Impuestos { get; set; }
        public decimal UtilidadNeta { get; set; }

    }
}
