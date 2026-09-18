using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class CL_Usuario
    {
        private CD_Usuario objCD_Usuario = new CD_Usuario(); // Instancia de la clase CD_Usuario
        public List<Usuario> ListarUsuarios()
        {
            return objCD_Usuario.ListarUsuarios(); // Llamada al método ListarUsuarios de la clase CD_Usuario
        }

        // Método para registrar un nuevo usuario
        public Usuario Login(int dni, string contraseña)
        {
            return objCD_Usuario.Login(dni, contraseña);
        }

        // REGISTRAR USUARIO
        public int RegistrarUsuario(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (string.IsNullOrWhiteSpace(obj.nombreCompleto))
                Mensaje += "Debe ingresar el nombre completo.\n";

            if (obj.dni == 0)
                Mensaje += "Debe ingresar el DNI.\n";

            if (string.IsNullOrWhiteSpace(obj.email))
                Mensaje += "Debe ingresar el email.\n";

            if (string.IsNullOrWhiteSpace(obj.telefono))
                Mensaje += "Debe ingresar el teléfono.\n";

            if (string.IsNullOrWhiteSpace(obj.direccion))
                Mensaje += "Debe ingresar la dirección.\n";

            if (obj.rol == null || obj.rol.id_rol == 0)
                Mensaje += "Debe seleccionar un rol.\n";

            if (Mensaje != string.Empty)
                return 0;

            return objCD_Usuario.RegistrarUsuario(obj, out Mensaje);
        }

        // EDITAR USUARIO
        public bool EditarUsuario(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.id_usuario == 0)
            {
                Mensaje += "Debe seleccionar un usuario.\n";
            }

            if (string.IsNullOrWhiteSpace(obj.nombreCompleto))
            {
                Mensaje += "Debe ingresar el nombre completo.\n";
            }

            if (obj.dni == 0)
            {
                Mensaje += "Debe ingresar el DNI.\n";
            }

            if (string.IsNullOrWhiteSpace(obj.email))
            {
                Mensaje += "Debe ingresar el email.\n";
            }

            if (string.IsNullOrWhiteSpace(obj.telefono))
            {
                Mensaje += "Debe ingresar el teléfono.\n";
            }

            if (string.IsNullOrWhiteSpace(obj.direccion))
            {
                Mensaje += "Debe ingresar la dirección.\n";
            }

            if (obj.rol == null || obj.rol.id_rol == 0)
            {
                Mensaje += "Debe seleccionar un rol.\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }

            return objCD_Usuario.EditarUsuario(obj);
        }

        // ELIMINAR USUARIO
        public bool EliminarUsuario(int idUsuario)
        {
            if (idUsuario == 0)
            {
                return false;
            }

            return objCD_Usuario.EliminarUsuario(idUsuario);
        }
    }
}
