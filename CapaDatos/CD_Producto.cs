
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Producto
    {
        // LISTAR PRODUCTOS
        public List<Producto> Listar(int idProveedor = 0)
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                string query = @"
            SELECT
                p.id_producto,
                p.codigo,
                p.nombreProducto,
                p.descripcion,
                p.stock,
                p.stockMinimo,
                p.estado,
                p.precioVenta,
                c.id_categoria,
                c.descripcion AS categoriaDescripcion,
                pr.id_proveedor,
                pr.razonSocial
            FROM Producto p
            INNER JOIN Categoria c
                ON p.id_categoria = c.id_categoria
            LEFT JOIN Proveedor pr
                ON p.id_proveedor = pr.id_proveedor
            WHERE p.estado = 1
              AND (@idProveedor = 0 OR p.id_proveedor = @idProveedor)
            ORDER BY p.id_producto DESC;";

                using (SqlCommand comando = new SqlCommand(query, oconexion))
                {
                    comando.Parameters.AddWithValue("@idProveedor", idProveedor);

                    oconexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Producto
                            {
                                id_producto = Convert.ToInt32(reader["id_producto"]),
                                codigo = reader["codigo"].ToString(),
                                nombreProducto = reader["nombreProducto"].ToString(),
                                descripcion = reader["descripcion"].ToString(),
                                stock = Convert.ToInt32(reader["stock"]),
                                stockMinimo = Convert.ToInt32(reader["stockMinimo"]),
                                estado = Convert.ToInt32(reader["estado"]),
                                precioVenta = Convert.ToDecimal(reader["precioVenta"]),

                                categoria = new Categoria
                                {
                                    id_categoria = Convert.ToInt32(reader["id_categoria"]),
                                    descripcion = reader["categoriaDescripcion"].ToString()
                                },

                                proveedor = reader["id_proveedor"] != DBNull.Value
                                    ? new Proveedor
                                    {
                                        id_proveedor = Convert.ToInt32(reader["id_proveedor"]),
                                        razonSocial = reader["razonSocial"].ToString()
                                    }
                                    : null
                            });
                        }
                    }
                }
            }

            return lista;
        }


        // VERIFICAR SI EL CODIGO YA EXISTE
        public bool ExisteCodigo(
            string codigo, int idProducto = 0)
        {
            using (SqlConnection oconexion =
                new SqlConnection(Conexion.cadena))
            {
                string query = @"
                    SELECT COUNT(*)
                    FROM Producto
                    WHERE codigo = @codigo
                      AND id_producto <> @id_producto";

                using (SqlCommand comando =
                    new SqlCommand(query, oconexion))
                {
                    comando.Parameters.AddWithValue(
                        "@codigo", codigo);

                    comando.Parameters.AddWithValue(
                        "@id_producto", idProducto);

                    oconexion.Open();

                    return Convert.ToInt32(
                        comando.ExecuteScalar()) > 0;
                }
            }
        }

        // REGISTRAR PRODUCTO
        public bool RegistrarProducto(Producto obj, out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    string query = @"
                INSERT INTO Producto
                (
                    codigo,
                    nombreProducto,
                    descripcion,
                    stock,          -- Stock actual inicia en 0 (aumenta con compras)
                    stockMinimo,    -- Stock mínimo configurado en el mantenedor
                    precioVenta,    -- Precio de venta inicia en 0 (se define en compras/ventas)
                    estado,
                    id_categoria,
                    id_proveedor
                )
                VALUES
                (
                    @codigo,
                    @nombreProducto,
                    @descripcion,
                    0,              
                    @stockMinimo,
                    0,                           
                    @estado,
                    @id_categoria,
                    @id_proveedor
                )";

                    using (SqlCommand comando = new SqlCommand(query, oconexion))
                    {
                        comando.Parameters.AddWithValue("@codigo", obj.codigo);
                        comando.Parameters.AddWithValue("@nombreProducto", obj.nombreProducto);
                        comando.Parameters.AddWithValue("@descripcion", obj.descripcion);
                        comando.Parameters.AddWithValue("@stockMinimo", obj.stockMinimo);
                        comando.Parameters.AddWithValue("@estado", obj.estado == 1);
                        comando.Parameters.AddWithValue("@id_categoria", obj.categoria.id_categoria);
                        comando.Parameters.AddWithValue("@id_proveedor", obj.proveedor.id_proveedor);

                        oconexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }

        // EDITAR PRODUCTO (Solo actualiza datos generales y stock mínimo, sin alterar stock actual ni precio venta por aquí)
        public bool EditarProducto(Producto obj, out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    string query = @"
                UPDATE Producto
                SET
                    codigo = @codigo,
                    nombreProducto = @nombreProducto,
                    descripcion = @descripcion,
                    stockMinimo = @stockMinimo,
                    estado = @estado,
                    id_categoria = @id_categoria
                WHERE id_producto = @id_producto";

                    using (SqlCommand comando = new SqlCommand(query, oconexion))
                    {
                        comando.Parameters.AddWithValue("@id_producto", obj.id_producto);
                        comando.Parameters.AddWithValue("@codigo", obj.codigo);
                        comando.Parameters.AddWithValue("@nombreProducto", obj.nombreProducto);
                        comando.Parameters.AddWithValue("@descripcion", obj.descripcion);
                        comando.Parameters.AddWithValue("@stockMinimo", obj.stockMinimo);
                        comando.Parameters.AddWithValue("@estado", obj.estado == 1);
                        comando.Parameters.AddWithValue("@id_categoria", obj.categoria.id_categoria);

                        oconexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }
        // ELIMINAR PRODUCTO (DESACTIVAR)
        public bool EliminarProducto(
            int idProducto, out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oconexion =
                    new SqlConnection(Conexion.cadena))
                {
                    string query = @"
                        UPDATE Producto
                        SET estado = 0
                        WHERE id_producto = @id_producto
                          AND estado = 1";

                    using (SqlCommand comando =
                        new SqlCommand(query, oconexion))
                    {
                        comando.Parameters.AddWithValue(
                            "@id_producto", idProducto);

                        oconexion.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }
    }
}

