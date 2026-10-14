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
    public class CD_Proveedor
    {
        //LISTAR PROVEEDORES
        public List<Proveedor> ListarProveedores()
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        SELECT 
                            id_proveedor, 
                            razonSocial, 
                            documento, 
                            email, 
                            telefono, 
                            estado
                        FROM PROVEEDOR 
                        ORDER BY id_proveedor";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Proveedor()
                            {
                                id_proveedor = Convert.ToInt32(dr["id_proveedor"]),
                                razonSocial = dr["razonSocial"].ToString(),
                                documento = Convert.ToInt64(dr["documento"]),
                                email = dr["email"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                estado = Convert.ToInt32(dr["estado"])
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Proveedor>();
                }
            }
            return lista;
        }

        // REGISTRAR PROVEEDOR
        public int RegistrarProveedor(Proveedor obj, out string mensaje)
        {
            int id_proveedorGenerado = 0;
            mensaje = string.Empty;

            

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @" 
                        INSERT INTO PROVEEDOR (razonSocial, documento, email, telefono, estado, fechaCreacion)
                        VALUES (@razonSocial, @documento, @email, @telefono, @estado, GETDATE());
                        SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@razonSocial", obj.razonSocial);
                    cmd.Parameters.AddWithValue("@documento", obj.documento);
                    cmd.Parameters.AddWithValue("@email", obj.email);
                    cmd.Parameters.AddWithValue("@telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("@estado", obj.estado);

                    oconexion.Open();
                    id_proveedorGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    id_proveedorGenerado = 0;
                    mensaje = ex.Message;
                }
            }

            return id_proveedorGenerado;
        }

        // EDITAR PROVEEDOR
        public bool EditarProveedor(Proveedor obj)
        {
            bool resultado = false;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        UPDATE PROVEEDOR
                        SET
                            razonSocial = @razonSocial,
                            documento = @documento,
                            email = @email,
                            telefono = @telefono,
                            estado = @estado
                        WHERE id_proveedor = @id_proveedor";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id_proveedor", obj.id_proveedor);
                    cmd.Parameters.AddWithValue("@razonSocial", obj.razonSocial);
                    cmd.Parameters.AddWithValue("@documento", obj.documento);
                    cmd.Parameters.AddWithValue("@email", obj.email);
                    cmd.Parameters.AddWithValue("@telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("@estado", obj.estado);

                    oconexion.Open();

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    resultado = filasAfectadas > 0;
                }
                catch
                {
                    resultado = false;
                }
            }

            return resultado;
        }

        // ELIMINAR PROVEEDOR
        public bool EliminarProveedor(int idProveedor)
        {
            bool resultado = false;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        DELETE FROM PROVEEDOR
                        WHERE id_proveedor = @id_proveedor";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id_proveedor", idProveedor);

                    oconexion.Open();

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    resultado = filasAfectadas > 0;
                }
                catch
                {
                    resultado = false;
                }
            }

            return resultado;
        }

        // VERIFICAR SI EL DOCUMENTO YA EXISTE EN LA BASE DE DATOS
        public bool ExisteDocumento(long documento, int id_proveedor = 0)
        {
            bool existe = false;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        SELECT COUNT(*) 
                        FROM PROVEEDOR 
                        WHERE documento = @documento AND id_proveedor <> @id_proveedor";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.Parameters.AddWithValue("@id_proveedor", id_proveedor);

                    oconexion.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    existe = count > 0;
                }
                catch
                {
                    existe = false;
                }
            }
            return existe;
        }
    }
}
