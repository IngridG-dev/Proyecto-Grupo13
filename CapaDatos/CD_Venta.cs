using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Venta
    {
        public List<MetodoPago> ListarMetodosPago()
        {
            List<MetodoPago> lista = new List<MetodoPago>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT id_metodoPago, descripcion FROM Metodo_Pago ORDER BY descripcion";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new MetodoPago()
                            {
                                id_metodoPago = Convert.ToInt32(dr["id_metodoPago"]),
                                descripcion = dr["descripcion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<MetodoPago>();
                }
            }
            return lista;
        }

        public bool RegistrarVenta(Venta obj, DataTable detalle, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    using (SqlTransaction transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            // 1. Cabecera de la venta
                            string queryVenta = @"
                                INSERT INTO Venta (id_usuario, id_cliente, tipoDocumento, montoPago, fechaCreacion, id_metodoPago)
                                VALUES (@id_usuario, @id_cliente, @tipoDocumento, @montoPago, GETDATE(), @id_metodoPago);
                                SELECT SCOPE_IDENTITY();";

                            SqlCommand cmdVenta = new SqlCommand(queryVenta, conexion, transaccion);
                            cmdVenta.Parameters.AddWithValue("@id_usuario", obj.usuario.id_usuario);
                            cmdVenta.Parameters.AddWithValue("@id_cliente", obj.cliente.id_cliente);
                            cmdVenta.Parameters.AddWithValue("@tipoDocumento", obj.tipoDocumento);
                            cmdVenta.Parameters.AddWithValue("@montoPago", obj.montoPago);
                            cmdVenta.Parameters.AddWithValue("@id_metodoPago", obj.metodoPago.id_metodoPago);

                            int idVenta = Convert.ToInt32(cmdVenta.ExecuteScalar());

                            // 2. Por cada producto: descontar stock (solo si alcanza) y guardar el detalle
                            foreach (DataRow row in detalle.Rows)
                            {
                                string queryStock = @"
                                    UPDATE Producto
                                    SET stock = stock - @cantidad
                                    WHERE id_producto = @id_producto AND stock >= @cantidad;";

                                SqlCommand cmdStock = new SqlCommand(queryStock, conexion, transaccion);
                                cmdStock.Parameters.AddWithValue("@id_producto", Convert.ToInt32(row["IdProducto"]));
                                cmdStock.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row["Cantidad"]));


                                if (cmdStock.ExecuteNonQuery() == 0)
                                    throw new Exception("Stock insuficiente para el producto \"" + row["Producto"] + "\".");

                                string queryDetalle = @"
                                    INSERT INTO Detalle_Venta (id_venta, id_producto, cantidad, precioUnitario)
                                    VALUES (@id_venta, @id_producto, @cantidad, @precioUnitario);";

                                SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conexion, transaccion);
                                cmdDetalle.Parameters.AddWithValue("@id_venta", idVenta);
                                cmdDetalle.Parameters.AddWithValue("@id_producto", Convert.ToInt32(row["IdProducto"]));
                                cmdDetalle.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row["Cantidad"]));
                                cmdDetalle.Parameters.AddWithValue("@precioUnitario", Convert.ToDecimal(row["PrecioVenta"]));
                                cmdDetalle.ExecuteNonQuery();
                            }

                            transaccion.Commit();
                            respuesta = true;
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            mensaje = ex.Message;
                            respuesta = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    respuesta = false;
                }
            }
            return respuesta;
        }
        // Listar ventas por usuario con filtros de fecha
        public List<Venta> ListarVentasPorUsuario(int idUsuario, DateTime? desde, DateTime? hasta)
        {
            List<Venta> lista = new List<Venta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                SELECT v.id_venta, v.fechaCreacion, v.tipoDocumento, v.montoPago,
                       c.id_cliente, c.dni, c.nombre, c.apellido,
                       mp.id_metodoPago, mp.descripcion AS metodoPago
                FROM Venta v
                INNER JOIN Cliente c ON v.id_cliente = c.id_cliente
                INNER JOIN Metodo_Pago mp ON v.id_metodoPago = mp.id_metodoPago
                WHERE v.id_usuario = @id_usuario
                  AND (@desde IS NULL OR v.fechaCreacion >= @desde)
                  AND (@hasta IS NULL OR v.fechaCreacion < @hasta)
                ORDER BY v.fechaCreacion DESC, v.id_venta DESC";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
                    cmd.Parameters.Add("@desde", SqlDbType.DateTime).Value =
                        desde.HasValue ? (object)desde.Value.Date : DBNull.Value;
                    cmd.Parameters.Add("@hasta", SqlDbType.DateTime).Value =
                        hasta.HasValue ? (object)hasta.Value.Date.AddDays(1) : DBNull.Value;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Venta()
                            {
                                id_venta = Convert.ToInt32(dr["id_venta"]),
                                fechaCreacion = Convert.ToDateTime(dr["fechaCreacion"]),
                                tipoDocumento = dr["tipoDocumento"].ToString(),
                                montoPago = Convert.ToDecimal(dr["montoPago"]),
                                cliente = new Cliente()
                                {
                                    id_cliente = Convert.ToInt32(dr["id_cliente"]),
                                    dni = Convert.ToInt32(dr["dni"]),   // si tu Cliente.dni es string o long, ajustá esta línea
                                    nombre = dr["nombre"].ToString(),
                                    apellido = dr["apellido"].ToString()
                                },
                                metodoPago = new MetodoPago()
                                {
                                    id_metodoPago = Convert.ToInt32(dr["id_metodoPago"]),
                                    descripcion = dr["metodoPago"].ToString()
                                }
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Venta>();   // si falla, devuelve lista vacía (como el resto de tus Listar)
                }
            }
            return lista;
        }

        public List<DetalleVenta> ObtenerDetalleVenta(int idVenta)
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                SELECT dv.id_detalleVenta, dv.cantidad, dv.precioUnitario,
                       p.id_producto, p.codigo, p.nombreProducto
                FROM Detalle_Venta dv
                INNER JOIN Producto p ON dv.id_producto = p.id_producto
                WHERE dv.id_venta = @id_venta
                ORDER BY dv.id_detalleVenta";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@id_venta", idVenta);
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new DetalleVenta()
                            {
                                id_detalleVenta = Convert.ToInt32(dr["id_detalleVenta"]),
                                cantidad = Convert.ToInt32(dr["cantidad"]),
                                precioUnitario = dr["precioUnitario"] == DBNull.Value ? 0m : Convert.ToDecimal(dr["precioUnitario"]),
                                producto = new Producto()
                                {
                                    id_producto = Convert.ToInt32(dr["id_producto"]),
                                    codigo = dr["codigo"].ToString(),
                                    nombreProducto = dr["nombreProducto"].ToString()
                                }
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<DetalleVenta>();
                }
            }
            return lista;
        }

        public List<Venta> ListarTodasLasVentas(DateTime? fechaDesde = null, DateTime? fechaHasta = null)
        {
            List<Venta> lista = new List<Venta>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        SELECT id_venta, fechaCreacion, montoPago
                        FROM Venta
                        WHERE (@fechaDesde IS NULL OR CAST(fechaCreacion AS DATE) >= @fechaDesde)
                        AND (@fechaHasta IS NULL OR CAST(fechaCreacion AS DATE) <= @fechaHasta)
                        ORDER BY fechaCreacion DESC";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@fechaDesde", (object)fechaDesde?.Date ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@fechaHasta", (object)fechaHasta?.Date ?? DBNull.Value);

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Venta()
                            {
                                id_venta = Convert.ToInt32(dr["id_venta"]),
                                fechaCreacion = Convert.ToDateTime(dr["fechaCreacion"]),
                                montoPago = Convert.ToDecimal(dr["montoPago"])
                                // Propiedades mapeadas temporalmente para la grilla y tarjetas
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Venta>();
                }
            }
            return lista;
        }
    }
}