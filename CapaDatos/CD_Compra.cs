using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Compra
    {
        public bool RegistrarCompra(Compra obj, DataTable DetalleCompra, out string mensaje)
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
                            // 1. Insertar la Compra
                            string queryCompra = @"
                                INSERT INTO Compra (tipoDocumento, numeroCompra, fechaRegistro, id_usuario, id_proveedor) 
                                VALUES (@tipoDocumento, @numeroCompra, GETDATE(), @id_usuario, @id_proveedor);
                                SELECT SCOPE_IDENTITY();";

                            SqlCommand cmdCompra = new SqlCommand(queryCompra, conexion, transaccion);
                            cmdCompra.Parameters.AddWithValue("@tipoDocumento", obj.tipoDocumento);
                            cmdCompra.Parameters.AddWithValue("@numeroCompra", obj.numeroCompra);
                            cmdCompra.Parameters.AddWithValue("@id_usuario", obj.usuario.id_usuario);
                            cmdCompra.Parameters.AddWithValue("@id_proveedor", obj.proveedor.id_proveedor);

                            int idCompraGenerada = Convert.ToInt32(cmdCompra.ExecuteScalar());

                            // 2. Insertar Detalles iterando sobre el DataTable
                            foreach (DataRow row in DetalleCompra.Rows)
                            {
                                string queryDetalle = @"
                                    INSERT INTO Detalle_Compra (id_compra, id_producto, precioCompra, cantidad) 
                                    VALUES (@id_compra, @id_producto, @precioCompra, @cantidad);
                                    
                                    -- Actualizar Stock y Precio de Venta en la tabla Producto
                                    UPDATE Producto 
                                    SET stock = stock + @cantidad, 
                                        precioVenta = @precioVenta 
                                    WHERE id_producto = @id_producto;";

                                SqlCommand cmdDetalle = new SqlCommand(queryDetalle, conexion, transaccion);
                                cmdDetalle.Parameters.AddWithValue("@id_compra", idCompraGenerada);
                                cmdDetalle.Parameters.AddWithValue("@id_producto", Convert.ToInt32(row["IdProducto"]));
                                cmdDetalle.Parameters.AddWithValue("@precioCompra", Convert.ToDecimal(row["PrecioCompra"]));
                                cmdDetalle.Parameters.AddWithValue("@precioVenta", Convert.ToDecimal(row["PrecioVenta"]));
                                cmdDetalle.Parameters.AddWithValue("@cantidad", Convert.ToInt32(row["Cantidad"]));

                                cmdDetalle.ExecuteNonQuery();
                            }

                            // 3. Confirmar la transacción si todo salió bien
                            transaccion.Commit();
                            respuesta = true;
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            mensaje = "Error en la transacción: " + ex.Message;
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

        public int ObtenerCorrelativo()
        {
            int id = 0;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Busca el último ID registrado y le suma 1
                    string query = "SELECT ISNULL(MAX(id_compra), 0) + 1 FROM Compra";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    oconexion.Open();
                    id = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception)
                {
                    id = 0;
                }
            }
            return id;
        }

        // Trae todas las compras en un rango de fechas (sin importar el usuario)
        public List<Compra> ReporteComprasFiltro(DateTime fechaDesde, DateTime fechaHasta)
        {
            List<Compra> lista = new List<Compra>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        SELECT c.id_compra, c.numeroCompra, c.fechaRegistro, 
                               p.razonSocial AS Proveedor, u.nombre + ' ' + u.apellido AS Administrador
                        FROM COMPRA c
                        INNER JOIN PROVEEDOR p ON c.id_compra = p.id_proveedor
                        INNER JOIN USUARIO u ON c.id_usuario = u.id_usuario
                        WHERE CONVERT(date, c.fechaRegistro) BETWEEN @fechaDesde AND @fechaHasta
                        ORDER BY c.fechaRegistro DESC";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@fechaDesde", fechaDesde.Date);
                    cmd.Parameters.AddWithValue("@fechaHasta", fechaHasta.Date);

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Compra()
                            {
                                id_compra = Convert.ToInt32(dr["id_compra"]),
                                numeroCompra = dr["numeroCompra"].ToString(),
                                fechaRegistro = dr["fechaRegistro"].ToString(),
                                proveedor = new Proveedor() { razonSocial = dr["Proveedor"].ToString() },
                                usuario = new Usuario() { nombre = dr["Administrador"].ToString() }
                            });
                        }
                    }
                }
                catch
                {
                    lista = new List<Compra>();
                }
            }
            return lista;
        }

        // 2. Obtener el detalle (los productos) de una compra seleccionada
        public List<DetalleCompra> ObtenerDetalleCompra(int idCompra)
        {
            List<DetalleCompra> lista = new List<DetalleCompra>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        SELECT p.nombreProducto, dc.precioCompra, dc.cantidad
                        FROM Detalle_Compra dc
                        INNER JOIN PRODUCTO p ON dc.id_producto = p.id_producto
                        WHERE dc.id_compra = @idCompra";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@idCompra", idCompra);

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new DetalleCompra()
                            {
                                producto = new Producto() { nombreProducto = dr["nombreProducto"].ToString() },
                                precioCompra = Convert.ToDecimal(dr["precioCompra"]),
                                cantidad = Convert.ToInt32(dr["cantidad"])
                            });
                        }
                    }
                }
                catch
                {
                    lista = new List<DetalleCompra>();
                }
            }
            return lista;
        }
    }
}
