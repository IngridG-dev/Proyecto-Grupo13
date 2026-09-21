using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Cliente
    {
        // LISTAR CLIENTES
        public List<Cliente> ListarClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            { 
                try
                {
                    string query = @"
                        SELECT 
                            id_cliente,
                            nombreCompleto,
                            dni,
                            email,
                            telefono,
                            direccion,
                            fechaCreacion
                        FROM CLIENTE
                        ORDER BY id_cliente";

                    SqlCommand comando = new SqlCommand(query, conexion);
                    comando.CommandType = CommandType.Text;

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Cliente
                            {
                                id_cliente = Convert.ToInt32(reader["id_cliente"]),
                                nombreCompleto = reader["nombreCompleto"].ToString(),
                                dni = Convert.ToInt32(reader["dni"]),
                                email = reader["email"].ToString(),
                                telefono = reader["telefono"].ToString(),
                                direccion = reader["direccion"].ToString(),
                                fechaCreacion = reader["fechaCreacion"].ToString()
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<Cliente>();
                }
            }

            return lista;
        }


        // VERIFICAR SI EL DNI YA EXISTE
        // VERIFICAR SI EL DNI YA EXISTE EN LA BASE DE DATOS DE CLIENTES
        public bool ExisteDNI(int dni, int id_Cliente = 0)
        {
            bool existe = false;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                SELECT COUNT(*) 
                FROM CLIENTE 
                WHERE dni = @dni AND id_cliente <> @id_cliente";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.Parameters.AddWithValue("@id_cliente", id_Cliente);

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

        // REGISTRAR CLIENTE
        public bool RegistrarCliente(Cliente obj)
        {
            bool respuesta = false;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        INSERT INTO CLIENTE
                        (
                            nombreCompleto,
                            dni,
                            email,
                            telefono,
                            direccion
                        )
                        VALUES
                        (
                            @nombreCompleto,
                            @dni,
                            @email,
                            @telefono,
                            @direccion
                        )";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@nombreCompleto", obj.nombreCompleto);
                    comando.Parameters.AddWithValue("@dni", obj.dni);
                    comando.Parameters.AddWithValue("@email", obj.email);
                    comando.Parameters.AddWithValue("@telefono", obj.telefono);
                    comando.Parameters.AddWithValue("@direccion", obj.direccion);

                    conexion.Open();

                    respuesta = comando.ExecuteNonQuery() > 0;
                }
                catch (SqlException ex)
                {
                    // 2601 y 2627 corresponden a violaciones de UNIQUE
                    if (ex.Number == 2601 || ex.Number == 2627)
                    {
                        respuesta = false;
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return respuesta;
        }


        // EDITAR CLIENTE
        public bool EditarCliente(Cliente obj)
        {
            bool respuesta = false;

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        UPDATE CLIENTE
                        SET
                            nombreCompleto = @nombreCompleto,
                            dni = @dni,
                            email = @email,
                            telefono = @telefono,
                            direccion = @direccion
                        WHERE id_cliente = @id_cliente";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@id_cliente", obj.id_cliente);
                    comando.Parameters.AddWithValue("@nombreCompleto", obj.nombreCompleto);
                    comando.Parameters.AddWithValue("@dni", obj.dni);
                    comando.Parameters.AddWithValue("@email", obj.email);
                    comando.Parameters.AddWithValue("@telefono", obj.telefono);
                    comando.Parameters.AddWithValue("@direccion", obj.direccion);

                    conexion.Open();

                    respuesta = comando.ExecuteNonQuery() > 0;
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2601 || ex.Number == 2627)
                    {
                        respuesta = false;
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return respuesta;
        }


        // ELIMINAR CLIENTE
        public bool EliminarCliente(int idCliente)
        {
            bool respuesta = false;
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        DELETE FROM CLIENTE
                        WHERE id_cliente = @id_cliente";

                    SqlCommand comando = new SqlCommand(query, conexion);

                    comando.Parameters.AddWithValue("@id_cliente", idCliente);

                    conexion.Open();

                    respuesta = comando.ExecuteNonQuery() > 0;
                }
                catch (SqlException)
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }
    }
}