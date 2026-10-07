using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleVenta
    {
        public int id_detalleVenta { get; set; }
        public int cantidad { get; set; }
        public Venta venta { get; set; } // Relación con la clase Venta
        public Producto producto { get; set; } // Relación con la clase Producto
    }
}
