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
                    string query = "SELECT u.id_usuario, u.nombreCompleto, u.dni, u.email, u.telefono, u.direccion, u.contraseña, u.estado FROM USUARIO u";
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
                                estado = dr["estado"].ToString()
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

        // LOGIN
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
                                estado = dr["estado"].ToString(),
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
    }

}
