using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public string nombreCompleto { get; set; }
        public int dni { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string fechaCreacion { get; set; }
    }
}
