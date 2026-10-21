using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Grupo13.Administrador
{
    public partial class usRegistrarCom : UserControl
    {
        private int filaEditando = -1;
        decimal totalAPagar = 0;
        public usRegistrarCom()
        {
            InitializeComponent();
        }

        //VALIDACIONES DE CAMPOS
        private void textPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números y un punto decimal en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //abrir el formulario de búsqueda de proveedores
            FormProveedor buscarProveedor = new FormProveedor();
            if (buscarProveedor.ShowDialog() == DialogResult.OK)
            {
                int nuevoId = buscarProveedor.proveedorSeleccionado.id_proveedor;
                int idActual = textNumDocumento.Tag == null ? 0 : Convert.ToInt32(textNumDocumento.Tag);

                if (idActual != 0 && idActual != nuevoId)
                {
                    bool hayProductos = dataGridView1.Rows.Cast<DataGridViewRow>().Any(r => !r.IsNewRow);

                    if (hayProductos)
                    {
                        DialogResult r = MessageBox.Show(
                            "Al cambiar de proveedor se quitarán los productos ya agregados. ¿Continuar?",
                            "Cambiar proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (r == DialogResult.No) return;

                        dataGridView1.Rows.Clear();
                        CalcularTotal();
                    }

                    textCodProduct.Clear();
                    LimpiarCampos();
                    filaEditando = -1;
                    iconBtnActualizarC.Enabled = false;
                }

                textNumDocumento.Tag = nuevoId;
                textNumDocumento.Text = buscarProveedor.proveedorSeleccionado.documento.ToString();
                textRazonSocial.Text = buscarProveedor.proveedorSeleccionado.razonSocial;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //Validar que se haya seleccionado un proveedor antes de buscar productos
            if (textNumDocumento.Tag == null || string.IsNullOrWhiteSpace(textNumDocumento.Text))
            {
                MessageBox.Show("Primero seleccione un proveedor.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Abrir el formulario de búsqueda de productos
            FormBuscarProductos buscarProducto = new FormBuscarProductos();
            buscarProducto.idProveedorFiltro = Convert.ToInt32(textNumDocumento.Tag); // Pasar el ID del proveedor al formulario de búsqueda
            if (buscarProducto.ShowDialog() == DialogResult.OK)
            {
                // Guardamos el ID oculto en el Tag del TextBox para usarlo al registrar la compra
                textCodProduct.Tag = buscarProducto.productoSeleccionado.id_producto;
                textCodProduct.Text = buscarProducto.productoSeleccionado.codigo;
                textProducto.Text = buscarProducto.productoSeleccionado.nombreProducto;
            }
        }

        private void textCodProduct_KeyPress(object sender, KeyPressEventArgs e) {
            // Validar que solo se ingresen numeros y letras
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
                                  // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten letras y números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void textProducto_KeyPress(object sender, KeyPressEventArgs e){
            // Permite letras, números, espacios, caracteres de control y signos de puntuación/símbolos
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsPunctuation(e.KeyChar) &&
                !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        //VALIDACIONES
        private void textNumDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese un carácter no numérico
                                  // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textNombreComple_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese un carácter no alfabético
                                  // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten letras y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxCodProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo se ingresen numeros y letras
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
                                  // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten letras y números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese un carácter no alfabético
                                  // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten letras y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconBtnAgregarC_Click(object sender, EventArgs e)
        {
            // Validaciones básicas
            if (textCodProduct.Tag == null || Convert.ToInt32(textCodProduct.Tag) <= 0)
            {
                MessageBox.Show("Seleccione un producto.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textPrecioCompra.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un precio de compra válido.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(textPrecioVenta.Text, out decimal precioVenta) || precioVenta <= 0)
            {
                MessageBox.Show("El precio de venta tiene que ser mayor a 0. Ingrese el precio de venta o elija un porcentaje.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int cantidad = (int)numericCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subTotal = precio * cantidad;

            // SIEMPRE AGREGA UN PRODUCTO NUEVO
            dataGridView1.Rows.Add(new object[]
            {
                Convert.ToInt32(textCodProduct.Tag), // [Columna Oculta] ID del producto
                textCodProduct.Text,                 // Código
                textProducto.Text,                   // Producto
                precio.ToString("0.00"),             // Precio Compra
                precioVenta.ToString("0.00"),        // Precio Venta
                cantidad,                            // Cantidad
                subTotal.ToString("0.00")            // SubTotal
            });

            // Cancelar cualquier modo edición previo
            filaEditando = -1;
            iconBtnActualizarC.Enabled = false; // Deshabilitar el botón Actualizar
            

            CalcularTotal();
            LimpiarCampos();
        }
            // Limpiar campos del formulario
        private void LimpiarCampos()
        {
            textCodProduct.Clear();
            textCodProduct.Tag = null;
            textProducto.Clear();
            textPrecioCompra.Clear();
            textPrecioVenta.Clear();
            numericCantidad.Value = numericCantidad.Minimum;
            iconBtnAgregarC.Enabled = true; // Habilitar el botón Agregar
        }
        // Calcular el total general de la venta
        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow)
                    continue;

                if (decimal.TryParse(
                    fila.Cells["SubTotal"].Value?.ToString(),
                    out decimal subTotal))
                {
                    total += subTotal;
                }
            }

            totalAPagar = total;
            textTotalPagar.Text = totalAPagar.ToString("0.00");
        }

        private void textCodProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar errores si se hace clic en el encabezado
            if (e.RowIndex < 0)
                return;

            // Evitar errores si se hace clic en la fila vacía del final (asterisco *)
            if (dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                MessageBox.Show("Debe seleccionar una fila que contenga un producto válido.",
                                "Acción no permitida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            // BOTÓN EDITAR
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int fila = e.RowIndex;

                // Obtener Código del producto
                textCodProduct.Tag = dataGridView1.Rows[fila].Cells["IdProducto"].Value;
                textCodProduct.Text =
                    dataGridView1.Rows[fila].Cells["CodigoProducto"].Value?.ToString() ?? "";

                // Obtener nombre del producto
                string producto =
                    dataGridView1.Rows[fila].Cells["Producto"].Value?.ToString() ?? "";

                // Obtener precio de compra
                decimal.TryParse(
                    dataGridView1.Rows[fila].Cells["PrecioCompra"].Value?.ToString(),
                    out decimal precio
                );

                // Obtener precio de venta
                decimal.TryParse(
                    dataGridView1.Rows[fila].Cells["PrecioVenta"].Value?.ToString(),
                    out decimal precioVenta
                );

                // Obtener cantidad
                object valorCantidad = dataGridView1.Rows[fila].Cells["Cantidad"].Value;
                int cantidad = 0;

                if (valorCantidad != null && decimal.TryParse(valorCantidad.ToString(), out decimal cantidadDecimal))
                {
                    cantidad = (int)cantidadDecimal;
                }

                // Cargar los datos en los controles de la pantalla
                textProducto.Text = producto;
                textPrecioCompra.Text = precio.ToString("0.00");
                textPrecioVenta.Text = precioVenta.ToString("0.00");

                // Verificar que la cantidad esté dentro de los límites del NumericUpDown
                numericCantidad.Value = Math.Max(
                    numericCantidad.Minimum,
                    Math.Min(numericCantidad.Maximum, cantidad)
                );

                // Guardar el índice de la fila y HABILITAR el botón Actualizar
                filaEditando = fila;
                iconBtnActualizarC.Enabled = true;
                iconBtnAgregarC.Enabled = false;
            }

            // BOTÓN ELIMINAR (Debe ir afuera del bloque de editar)
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este producto de la compra?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);

                    // Recalcular el total de la compra
                    CalcularTotal();
                }
            }
        }

        private void iconBtnRegistrarC_Click(object sender, EventArgs e)
        {
            // Validar Tipo Documento y Proveedor
            if (comboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textNumDocumento.Text)) // Asume que guardaste el ID del proveedor en textNumDocumento.Tag al buscarlo
            {
                MessageBox.Show("Debe seleccionar un proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                MessageBox.Show("Debe agregar al menos un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Armar el DataTable con los detalles de la grilla
            DataTable detalleCompra = new DataTable();
            detalleCompra.Columns.Add("IdProducto", typeof(int));
            detalleCompra.Columns.Add("PrecioCompra", typeof(decimal));
            detalleCompra.Columns.Add("PrecioVenta", typeof(decimal));
            detalleCompra.Columns.Add("Cantidad", typeof(int));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    detalleCompra.Rows.Add(
                        Convert.ToInt32(row.Cells["IdProducto"].Value), // Reemplaza "IdProducto" con el nombre real de tu columna oculta
                        Convert.ToDecimal(row.Cells["PrecioCompra"].Value),
                        Convert.ToDecimal(row.Cells["PrecioVenta"].Value),
                        Convert.ToInt32(row.Cells["Cantidad"].Value)
                    );
                }
            }

            int correlativo = new CL_Compra().ObtenerCorrelativo();
            // 2. Construir el objeto Compra
                if(SesionActual.usuarioLogueado == null)
            {
                MessageBox.Show("No hay un usuario logueado. Por favor, inicie sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                Compra oCompra = new Compra { 
                    usuario = new Usuario() { id_usuario = SesionActual.usuarioLogueado.id_usuario },
                    proveedor = new Proveedor() { id_proveedor = Convert.ToInt32(textNumDocumento.Tag) },
                    tipoDocumento = comboTipoDocumento.Text,
                    numeroCompra = string.Format("{0:000000}", correlativo), // Formatear con ceros a la izquierda
                };

            // 3. Enviar a Capa Lógica
            string mensaje;
            bool resultado = new CL_Compra().RegistrarCompra(oCompra, detalleCompra, out mensaje);

            if (resultado)
            {
                MessageBox.Show("Compra registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar controles
                comboTipoDocumento.SelectedIndex = -1;
                textNumDocumento.Clear();
                textNumDocumento.Tag = null;
                textRazonSocial.Clear();
                dataGridView1.Rows.Clear();
                CalcularTotal();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconBtnActualizarC_Click(object sender, EventArgs e)
        {
            // Verificar que realmente haya una fila seleccionada para editar
            if (filaEditando == -1)
            {
                MessageBox.Show("Seleccione primero un producto de la lista para actualizar.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validaciones básicas
            if (textCodProduct.Tag == null || Convert.ToInt32(textCodProduct.Tag) <= 0)
            {
                MessageBox.Show("Seleccione un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textProducto.Text))
            {
                MessageBox.Show("Complete los campos para actualizar el producto.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textPrecioCompra.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un precio de compra válido.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal.TryParse(textPrecioVenta.Text, out decimal precioVenta);
            int cantidad = (int)numericCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subTotal = precio * cantidad;

            // ACTUALIZAR LA FILA SELECCIONADA
            dataGridView1.Rows[filaEditando].Cells["IdProducto"].Value = Convert.ToInt32(textCodProduct.Tag);
            dataGridView1.Rows[filaEditando].Cells["CodigoProducto"].Value = textCodProduct.Text;
            dataGridView1.Rows[filaEditando].Cells["Producto"].Value = textProducto.Text;
            dataGridView1.Rows[filaEditando].Cells["PrecioCompra"].Value = precio.ToString("0.00");
            dataGridView1.Rows[filaEditando].Cells["PrecioVenta"].Value = precioVenta.ToString("0.00");
            dataGridView1.Rows[filaEditando].Cells["Cantidad"].Value = cantidad;
            dataGridView1.Rows[filaEditando].Cells["SubTotal"].Value = subTotal.ToString("0.00");

            // Salir del modo edición y deshabilitar botón Actualizar
            filaEditando = -1;
            iconBtnActualizarC.Enabled = false;

            CalcularTotal();
            LimpiarCampos();
        }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            filaEditando = -1;
            iconBtnActualizarC.Enabled = false;

            // Volvemos a habilitar el botón Agregar
            iconBtnAgregarC.Enabled = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxPorcentaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validamos que haya un precio de compra ingresado y un porcentaje seleccionado
            if (!string.IsNullOrEmpty(textPrecioCompra.Text) && comboBoxPorcentaje.SelectedItem != null)
            {
                try
                {
                    // Parseamos los valores
                    decimal precioCompra = Convert.ToDecimal(textPrecioCompra.Text);

                    // Si tu ComboBox tiene el símbolo "%" (ej. "15%"), lo limpiamos. Si son solo números, omití el Replace.
                    string porcentajeTexto = comboBoxPorcentaje.SelectedItem.ToString().Replace("%", "");
                    decimal porcentaje = Convert.ToDecimal(porcentajeTexto);

                    // Calculamos el precio de venta: Precio Compra + (Precio Compra * Porcentaje / 100)
                    decimal precioVenta = precioCompra + (precioCompra * (porcentaje / 100));

                    // Mostramos el resultado en el TextBox de Precio Venta con dos decimales
                    textPrecioVenta.Text = precioVenta.ToString("0.00");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor, ingrese un precio de compra válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
