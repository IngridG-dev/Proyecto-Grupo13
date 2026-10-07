using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int id_compra { get; set; }
        public string tipoDocumento { get; set; }
        public string numeroCompra { get; set; }
        public string fechaRegistro { get; set; }
        public Usuario usuario { get; set; } // Relación con la clase Usuario
        public Proveedor proveedor { get; set; } // Relación con la clase Proveedor

    }
}
