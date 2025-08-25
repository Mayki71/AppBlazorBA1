using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBlazer.EntitiesA1
{
    public class RepresentateVentasListCls
    {
        public int Num_Empl { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaContrato { get; set; }
        public decimal Cuota { get; set; }
        public decimal Ventas { get; set; }
    }
}
