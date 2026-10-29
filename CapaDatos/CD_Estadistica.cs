using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Estadistica
    {
        public List<Estadisticas> productosMasVendidos(DateTime? desde, DateTime? hasta)
        {
            string query = @"
                SELECT p.nombreProducto AS nombre,
                       SUM(dv.cantidad) AS cantidadVendida,
                       SUM(dv.cantidad * ISNULL(dv.precioUnitario, 0)) AS ingresos
                FROM Detalle_Venta dv
                INNER JOIN Venta v ON dv.id_venta = v.id_venta
                INNER JOIN Producto p ON dv.id_producto = p.id_producto
                WHERE (@desde IS NULL OR v.fechaCreacion >= @desde)
                  AND (@hasta IS NULL OR v.fechaCreacion < @hasta)
                GROUP BY p.id_producto, p.nombreProducto
                ORDER BY SUM(dv.cantidad) DESC, p.nombreProducto";

            return listar(query, desde, hasta);
        }

        public List<Estadisticas> categoriasMasVendidas(DateTime? desde, DateTime? hasta)
        {
            string query = @"
                SELECT c.descripcion AS nombre,
                       SUM(dv.cantidad) AS cantidadVendida,
                       SUM(dv.cantidad * ISNULL(dv.precioUnitario, 0)) AS ingresos
                FROM Detalle_Venta dv
                INNER JOIN Venta v ON dv.id_venta = v.id_venta
                INNER JOIN Producto p ON dv.id_producto = p.id_producto
                INNER JOIN Categoria c ON p.id_categoria = c.id_categoria
                WHERE (@desde IS NULL OR v.fechaCreacion >= @desde)
                  AND (@hasta IS NULL OR v.fechaCreacion < @hasta)
                GROUP BY c.id_categoria, c.descripcion
                ORDER BY SUM(dv.cantidad) DESC, c.descripcion";

            return listar(query, desde, hasta);
        }

        public List<VendedorEstadistica> ventasPorVendedor(DateTime? desde, DateTime? hasta)
        {
            List<VendedorEstadistica> lista = new List<VendedorEstadistica>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        SELECT u.nombre + ' ' + u.apellido AS vendedor,
                               COUNT(*) AS ventas
                        FROM Venta v
                        INNER JOIN USUARIO u ON v.id_usuario = u.id_usuario
                        WHERE (@desde IS NULL OR v.fechaCreacion >= @desde)
                          AND (@hasta IS NULL OR v.fechaCreacion < @hasta)
                        GROUP BY u.id_usuario, u.nombre, u.apellido
                        ORDER BY COUNT(*) DESC, u.apellido";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    agregarFechas(cmd, desde, hasta);
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new VendedorEstadistica(
                                dr["vendedor"].ToString(),
                                Convert.ToInt32(dr["ventas"])));
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<VendedorEstadistica>();
                }
            }
            return lista;
        }

        // ejecuta una consulta de productos/categorías y arma la lista
        private List<Estadisticas> listar(string query, DateTime? desde, DateTime? hasta)
        {
            List<Estadisticas> lista = new List<Estadisticas>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    agregarFechas(cmd, desde, hasta);
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Estadisticas(
                                dr["nombre"].ToString(),
                                Convert.ToInt32(dr["cantidadVendida"]),
                                Convert.ToDecimal(dr["ingresos"])));
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Estadisticas>();
                }
            }
            return lista;
        }

        // se busca hasta el inicio del día siguiente
        private static void agregarFechas(SqlCommand cmd, DateTime? desde, DateTime? hasta)
        {
            cmd.Parameters.Add("@desde", SqlDbType.DateTime).Value =
                desde.HasValue ? (object)desde.Value.Date : DBNull.Value;
            cmd.Parameters.Add("@hasta", SqlDbType.DateTime).Value =
                hasta.HasValue ? (object)hasta.Value.Date.AddDays(1) : DBNull.Value;
        }
    }
}
