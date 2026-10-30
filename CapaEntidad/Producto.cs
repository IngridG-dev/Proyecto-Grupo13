using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Producto
    {
        public int id_producto { get; set; }
        public string codigo { get; set; }
        public string nombreProducto { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public int stockMinimo { get; set; }
        public int estado { get; set; }
        public decimal precioVenta { get; set; }
        public Categoria categoria { get; set; } // Relación con la clase Categoria
        public Proveedor proveedor { get; set; } // Relación con la clase Proveedor
        public string artista { get; set; }

    }
}
