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
                    // Se agregaron u.fechaCreacion, r.id_rol y r.descripcion a la consulta
                    string query = @"
                SELECT 
                    u.id_usuario, 
                    u.nombre, 
                    u.apellido, 
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
                ORDER BY u.id_usuario";

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
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
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
                catch (Exception)
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
                            u.nombre,
                            u.apellido,
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
                                nombre = dr["nombre"].ToString(),
                                apellido = dr["apellido"].ToString(),
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
        public int RegistrarUsuario(Usuario obj, out string mensaje)
        {
            int id_usuarioGenerado = 0;
            mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    // Se incluye fechaCreacion enviando GETDATE() desde SQL
                    string query = @" 
                INSERT INTO USUARIO (nombre, apellido, dni, email, telefono, direccion, contraseña, estado, id_rol, fechaCreacion)
                VALUES (@nombre, @apellido, @dni, @email, @telefono, @direccion, @contraseña, @estado, @id_rol, GETDATE());
                SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("@apellido", obj.apellido);
                    cmd.Parameters.AddWithValue("@dni", obj.dni);
                    cmd.Parameters.AddWithValue("@email", obj.email);
                    cmd.Parameters.AddWithValue("@telefono", obj.telefono);
                    cmd.Parameters.AddWithValue("@direccion", obj.direccion);
                    cmd.Parameters.AddWithValue("@contraseña", (object)obj.contraseña ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@estado", obj.estado);
                    cmd.Parameters.AddWithValue("@id_rol", obj.rol.id_rol);

                    oconexion.Open();
                    id_usuarioGenerado = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    id_usuarioGenerado = 0;
                    mensaje = ex.Message; // Retorna el error exacto de SQL a la UI
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
                            nombre = @nombre,
                            apellido = @apellido,
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
                    cmd.Parameters.AddWithValue("@nombre", obj.nombre);
                    cmd.Parameters.AddWithValue("@apellido", obj.apellido);
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
        //VERIFICAR SI EL DNI YA EXISTE EN LA BASE DE DATOS
        public bool ExisteDNI(int dni, int id_Usuario = 0)
        {
            bool existe = false;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = @"
                        SELECT COUNT(*) 
                        FROM USUARIO 
                        WHERE dni = @dni AND id_usuario <> @id_usuario";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@dni", dni);
                    cmd.Parameters.AddWithValue("@id_usuario", id_Usuario);
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
