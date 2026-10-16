using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaLogica
{
    public class CL_Categoria
    {
        private CD_Categoria datos = new CD_Categoria();

        // LISTAR CATEGORÍAS
        public List<Categoria> Listar()
        {
            return datos.Listar();
        }
    }
}