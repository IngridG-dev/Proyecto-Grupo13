using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int id_venta { get; set; }
        public Usuario usuario { get; set; } // Relación con la clase Usuario
        public Cliente cliente { get; set; } // Relación con la clase Cliente
        public string tipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public decimal montoPago { get; set; }
        public decimal cambio { get; set; }
        public decimal total { get; set; }
        public string fechaCreacion { get; set; }
    }
}
