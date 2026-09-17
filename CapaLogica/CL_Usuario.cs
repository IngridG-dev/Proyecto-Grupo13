using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class CL_Usuario
    {
        private CD_Usuario objCD_Usuario = new CD_Usuario(); // Instancia de la clase CD_Usuario
        public List<Usuario> ListarUsuarios()
        {
            return objCD_Usuario.ListarUsuarios(); // Llamada al método ListarUsuarios de la clase CD_Usuario
        }
    }
}
