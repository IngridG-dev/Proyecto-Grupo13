
using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;

namespace CapaLogica
{
    public class CL_Producto
    {
        private CD_Producto datos = new CD_Producto();

        // LISTAR PRODUCTOS
        public List<Producto> Listar()
        {
            return datos.Listar();
        }

        // VALIDAR DATOS DEL PRODUCTO
        private bool ValidarProducto(Producto obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj == null)
            {
                mensaje = "No se recibieron los datos del producto.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(obj.codigo))
            {
                mensaje = "Debe ingresar el código del producto.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(obj.nombreProducto))
            {
                mensaje = "Debe ingresar el nombre del producto.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(obj.descripcion))
            {
                mensaje = "Debe ingresar la descripción del producto.";
                return false;
            }

            if (obj.stockMinimo < 3)
            {
                mensaje = "El stock mínimo no puede ser menor a 3.";
                return false;
            }

            if (obj.categoria == null || obj.categoria.id_categoria <= 0)
            {
                mensaje = "Debe seleccionar una categoría.";
                return false;
            }

            return true;
        }

        // REGISTRAR PRODUCTO
        public bool RegistrarProducto(
            Producto obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (!ValidarProducto(obj, out mensaje))
                return false;

            if (datos.ExisteCodigo(obj.codigo))
            {
                mensaje = "Ya existe un producto con ese código.";
                return false;
            }

            return datos.RegistrarProducto(obj, out mensaje);
        }

        // EDITAR PRODUCTO
        public bool EditarProducto(
            Producto obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj == null || obj.id_producto <= 0)
            {
                mensaje = "Debe seleccionar un producto válido.";
                return false;
            }

            if (!ValidarProducto(obj, out mensaje))
                return false;

            if (datos.ExisteCodigo(
                obj.codigo, obj.id_producto))
            {
                mensaje = "Ya existe otro producto con ese código.";
                return false;
            }

            return datos.EditarProducto(obj, out mensaje);
        }

        // DESACTIVAR PRODUCTO
        public bool Desactivar(
            int idProducto, out string mensaje)
        {
            mensaje = string.Empty;

            if (idProducto <= 0)
            {
                mensaje = "Debe seleccionar un producto válido.";
                return false;
            }

            return datos.EliminarProducto(idProducto, out mensaje);
        }
    }
}
