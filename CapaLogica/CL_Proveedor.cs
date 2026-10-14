using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaLogica.CL_Proveedor;

namespace CapaLogica
{
        public class CL_Proveedor
        {
            private CD_Proveedor objCL_Datos = new CD_Proveedor();

        // LISTAR PROVEEDORES
        public List<Proveedor> ListarProveedores()
            {
                return objCL_Datos.ListarProveedores();
            }

            // REGISTRAR PROVEEDOR
            public int RegistrarProveedor(Proveedor obj, out string mensaje)
            {
                return objCL_Datos.RegistrarProveedor(obj, out mensaje);
            }

            // EDITAR PROVEEDOR
            public bool EditarProveedor(Proveedor obj)
            {
                return objCL_Datos.EditarProveedor(obj);
            }

            // ELIMINAR PROVEEDOR
            public bool EliminarProveedor(int idProveedor)
            {
                return objCL_Datos.EliminarProveedor(idProveedor);
            }

            // VERIFICAR DOCUMENTO
            public bool ExisteDocumento(long documento, int idProveedor = 0)
            {
                return objCL_Datos.ExisteDocumento(documento, idProveedor);
            }
        }
    }
