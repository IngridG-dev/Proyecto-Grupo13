using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_Compra
    {
        private CD_Compra objCapaDatos = new CD_Compra();

        public bool RegistrarCompra(Compra obj, DataTable DetalleCompra, out string mensaje)
        {
            if (obj.proveedor.id_proveedor == 0)
            {
                mensaje = "Debe seleccionar un proveedor válido.";
                return false;
            }
            if (DetalleCompra.Rows.Count == 0)
            {
                mensaje = "Debe agregar al menos un producto a la compra.";
                return false;
            }

            return objCapaDatos.RegistrarCompra(obj, DetalleCompra, out mensaje);
        }

        public int ObtenerCorrelativo()
        {
            return objCapaDatos.ObtenerCorrelativo();
        }
    }
}
