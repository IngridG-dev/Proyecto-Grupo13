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
    public class CD_Usuario
    {
        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT u.id_usuario, u.nombreCompleto, u.dni, u.email, u.telefono, u.direccion, u.contraseña, u.estado FROM USUARIO u INNER JOIN ROL r ON u.id_rol = r.id_rol ORDER BY u.id_usuario";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                nombreCompleto = dr["nombreCompleto"].ToString(),
                                dni = Convert.ToInt32(dr["dni"]),
                                email = dr["email"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                direccion = dr["direccion"].ToString(),
                                contraseña = dr["contraseña"].ToString(),
                                estado = Convert.ToInt32(dr["estado"]),
                                fechaCreacion = dr["fechaCreacion"].ToString(),

                                rol = new Rol()
                                {
                                    id_rol = Convert.ToInt32(dr["id_rol"]),
                                    descripcion = dr["descripcion"].ToString()
                                }
                            });
                        }
                    }

                }
                catch
                {
                    lista = new List<Usuario>();
                }
            }
            return lista;
        }

        // LOGIN DE USUARIO, SE LE PASA EL DNI Y LA CONTRASEÑA, Y SI EXISTE UN USUARIO CON ESOS DATOS, SE DEVUELVE EL OBJETO USUARIO CON SU ROL.
        public Usuario Login(int dni, string contraseña)
        {
            Usuario usuario = null;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                // SQL query to select user details based on dni and contraseña
                // hace que no solamente obtengamos el usuario, sino también su rol.
                try
                {
                    string query = @"
                        SELECT 
                            u.id_usuario,
                            u.nombreCompleto,
                            u.dni,
                            u.email,
                            u.telefono,
                            u.direccion,
                            u.contraseña,
                            u.estado,
                            u.fechaCreacion,
                            r.id_rol,
                            r.descripcion
                        FROM USUARIO u
                        INNER JOIN ROL r ON u.id_rol = r.id_rol 
                        WHERE u.dni = @dni
                        AND u.contraseña = @contraseña";

                    SqlCommand cmd = new SqlCommand(query, oconexion);

                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            usuario = new Usuario()
                            {
                                id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                nombreCompleto = dr["nombreCompleto"].ToString(),
                                dni = Convert.ToInt32(dr["dni"]),
                                email = dr["email"].ToString(),
                                telefono = dr["telefono"].ToString(),
                                direccion = dr["direccion"].ToString(),
                                contraseña = dr["contraseña"].ToString(),
                                estado = Convert.ToInt32(dr["estado"]),
                                fechaCreacion = dr["fechaCreacion"].ToString(),

                                rol = new Rol()
                                {
                                    id_rol = Convert.ToInt32(dr["id_rol"]),
                                    descripcion = dr["descripcion"].ToString()
                                }
                            };
                        }
                    }
                }
                catch
                {
                    usuario = null;
                }
            }

            return usuario;
        }

        //REGISTRAR USUARIO 
        public int RegistrarUsuario(Usuario obj)
        {
            int id_usuarioGenerado = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @" INSERT INTO USUARIO (nombreCompleto, dni, email, telefono, direccion, contraseña, estado, id_rol)" +
                        "VALUES (@nombreCompleto, @dni, @email, @telefono, @direccion, @contraseña, @estado, @id_rol);" +
                        "SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@nombreCompleto", obj.nombreCompleto);
                    cmd.Parameters.AddWithValue("@dni", obj.dni);
                    cmd.Parameters.AddWithValue("@email", obj.email);
                    cmd.Parameters.AddWithValue("@telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("@direccion", obj.direccion);
                    cmd.Parameters.AddWithValue("@contraseña", obj.contraseña);
                    cmd.Parameters.AddWithValue("@estado", obj.estado);
                    cmd.Parameters.AddWithValue("@id_rol", obj.rol.id_rol);

                    oconexion.Open();

                    id_usuarioGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch
                {
                    id_usuarioGenerado = 0;
                }
            }

            return id_usuarioGenerado;
  
        }

        // EDITAR USUARIO
        public bool EditarUsuario(Usuario obj)
        {
            bool resultado = false;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        UPDATE USUARIO
                        SET
                            nombreCompleto = @nombreCompleto,
                            dni = @dni,
                            email = @email,
                            telefono = @telefono,
                            direccion = @direccion,
                            contraseña = @contraseña,
                            estado = @estado,
                            id_rol = @id_rol
                        WHERE id_usuario = @id_usuario";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id_usuario", obj.id_usuario);
                    cmd.Parameters.AddWithValue("@nombreCompleto", obj.nombreCompleto);
                    cmd.Parameters.AddWithValue("@dni", obj.dni);
                    cmd.Parameters.AddWithValue("@email", obj.email);
                    cmd.Parameters.AddWithValue("@telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("@direccion", obj.direccion);
                    cmd.Parameters.AddWithValue("@contraseña", obj.contraseña);
                    cmd.Parameters.AddWithValue("@estado", obj.estado);
                    cmd.Parameters.AddWithValue("@id_rol", obj.rol.id_rol);

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

        // ELIMINAR USUARIO
        public bool EliminarUsuario(int idUsuario)
        {
            bool resultado = false;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        DELETE FROM USUARIO
                        WHERE id_usuario = @id_usuario";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@id_usuario", idUsuario);

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

    }
}
