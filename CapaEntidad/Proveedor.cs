using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Proveedor
    {
        public int id_proveedor { get; set; }
        public int documento { get; set; }
        public string razonSocial { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public int estado { get; set; }
        public string fechaCreacion { get; set; }

    }
}
