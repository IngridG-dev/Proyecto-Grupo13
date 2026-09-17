using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nombreCompleto { get; set; }
        public int dni { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string contraseña { get; set; }
        public string estado { get; set }
        public Rol rol { get; set; } // Relación con la clase Rol
        public string fechaCreacion { get; set; }
    }
}
