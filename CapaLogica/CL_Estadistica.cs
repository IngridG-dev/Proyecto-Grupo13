using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaLogica
{
    public class CL_Estadistica
    {
        private CD_Estadistica objCapaDatos = new CD_Estadistica();

        public List<Estadisticas> productosMasVendidos(DateTime? desde, DateTime? hasta)
        {
            return objCapaDatos.productosMasVendidos(desde, hasta);
        }

        public List<Estadisticas> categoriasMasVendidas(DateTime? desde, DateTime? hasta)
        {
            return objCapaDatos.categoriasMasVendidas(desde, hasta);
        }

        public List<VendedorEstadistica> ventasPorVendedor(DateTime? desde, DateTime? hasta)
        {
            return objCapaDatos.ventasPorVendedor(desde, hasta);
        }
    }
}
