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
        public MetodoPago metodoPago { get; set; } // Relación con la clase MetodoPago
        public string tipoDocumento { get; set; }
        public decimal montoPago { get; set; }
        public string fechaCreacion { get; set; }
    }
}
