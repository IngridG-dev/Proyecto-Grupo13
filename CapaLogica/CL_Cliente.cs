using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaLogica
{
    public class CL_Cliente
    {
        private CD_Cliente objCD_Cliente = new CD_Cliente();


        // LISTAR CLIENTES
        public List<Cliente> ListarClientes()
        {
            return objCD_Cliente.ListarClientes();
        }


        // VERIFICAR DNI
        public bool ExisteDNI(int dni, int id_Cliente = 0)
        {
            return objCD_Cliente.ExisteDNI(dni, id_Cliente);
        }

        // REGISTRAR CLIENTE
        public bool RegistrarCliente(Cliente obj)
        {
            return objCD_Cliente.RegistrarCliente(obj);
        }


        // EDITAR CLIENTE
        public bool EditarCliente(Cliente obj)
        {
            return objCD_Cliente.EditarCliente(obj);
        }


        // ELIMINAR CLIENTE
        public bool EliminarCliente(int idCliente)
        {
            return objCD_Cliente.EliminarCliente(idCliente);
        }

        // VERIFICAR SI EL DNI YA EXISTE EN LA BASE DE DATOS DE CLIENTES (GLOBAL)
        public bool ExisteDNIGlobal(string dniBuscado)
        {
            return objCD_Cliente.ExisteDNIGlobal(dniBuscado);
        }
    }
}