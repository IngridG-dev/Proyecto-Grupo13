using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permiso
    {
        public int id_permiso { get; set; }
        public Rol rol { get; set; } // Relación con la clase Rol
        public string nombreMenu { get; set; }
        public string fechaCreacion { get; set; }
    }
}
