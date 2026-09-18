using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class CL_Rol
    {
        private CD_Rol objCD_Rol = new CD_Rol();

        public List<Rol> Listar()
        {
            return objCD_Rol.Listar();
        }
    }
}
