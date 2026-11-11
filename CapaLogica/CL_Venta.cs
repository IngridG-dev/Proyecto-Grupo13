using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaLogica
{
    public class CL_Venta
    {
        private CD_Venta objCapaDatos = new CD_Venta();
        public List<MetodoPago> ListarMetodosPago()
        {
            return objCapaDatos.ListarMetodosPago();
        }

        public bool RegistrarVenta(Venta obj, DataTable detalle, out int idVenta, out string mensaje)
        {
            idVenta = 0;
            mensaje = string.Empty;

            if (obj == null || obj.usuario == null || obj.usuario.id_usuario <= 0)
            {
                mensaje = "No hay un usuario válido para registrar la venta.";
                return false;
            }
            if (obj.cliente == null || obj.cliente.id_cliente <= 0)
            {
                mensaje = "Debe seleccionar un cliente.";
                return false;
            }
            if (obj.metodoPago == null || obj.metodoPago.id_metodoPago <= 0)
            {
                mensaje = "Debe seleccionar una forma de pago.";
                return false;
            }
            if (detalle == null || detalle.Rows.Count == 0)
            {
                mensaje = "Debe agregar al menos un producto a la venta.";
                return false;
            }

            foreach (DataRow fila in detalle.Rows) // Validar que las cantidades y precios de venta sean mayores a 0
            {
                if (Convert.ToInt32(fila["Cantidad"]) <= 0)
                {
                    mensaje = "Las cantidades deben ser mayores a 0.";
                    return false;
                }
                if (Convert.ToDecimal(fila["PrecioVenta"]) <= 0)
                {
                    mensaje = "Los precios de venta deben ser mayores a 0.";
                    return false;
                }
            }

            obj.montoPago = detalle.Rows.Cast<DataRow>()
                .Sum(f => Convert.ToDecimal(f["PrecioVenta"]) * Convert.ToInt32(f["Cantidad"])); // Calcular el monto total de la venta sumando los subtotales de cada producto

            return objCapaDatos.RegistrarVenta(obj, detalle, out idVenta, out mensaje);
        }
        public List<Venta> ListarVentasPorUsuario(int idUsuario, DateTime? desde, DateTime? hasta)
        {
            if (idUsuario <= 0) return new List<Venta>();
            return objCapaDatos.ListarVentas(idUsuario, desde, hasta); //evita que un vendedor vea las ventas de otro vendedor, solo las suyas
        }

        public List<Venta> ListarTodasLasVentas(DateTime? desde, DateTime? hasta)
        {
            return objCapaDatos.ListarVentas(0, desde, hasta); // retornando 0 como idUsuario, lo que indica que no se filtra por usuario
        }

        public List<DetalleVenta> ObtenerDetalleVenta(int idVenta) // Método para obtener los detalles de una venta específica
        {
            if (idVenta <= 0) return new List<DetalleVenta>();
            return objCapaDatos.ObtenerDetalleVenta(idVenta);
        }
    }
}
