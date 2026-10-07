using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class DetalleCompra
    {
        public int id_detalleCompra { get; set; } 
        public decimal precioCompra { get; set; }
        public int cantidad { get; set; }
        public Compra compra { get; set; } // Relación con la clase Compra
        public Producto producto { get; set; } // Relación con la clase Producto

    }
}
