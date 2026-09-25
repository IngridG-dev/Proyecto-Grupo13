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

            buscarProveedor.ShowDialog();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //abrir el formulario de búsqueda de productos
            FormBuscarProductos buscarProducto = new FormBuscarProductos();
            buscarProducto.ShowDialog();
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
            if (string.IsNullOrWhiteSpace(textProducto.Text))
            {
                MessageBox.Show("Complete los campos para registrar un producto.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un precio de compra válido.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal.TryParse(textPrecioV.Text, out decimal precioVenta);
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
        textCodProduct.Text,
        textProducto.Text,
        precio.ToString("0.00"),
        precioVenta.ToString("0.00"),
        cantidad,
        subTotal.ToString("0.00")
            });

            // Cancelar cualquier modo edición previo
            filaEditando = -1;
            iconBtnActualizarC.Enabled = false; // Deshabilitar el botón Actualizar
            iconBtnAgregarC.Enabled = true; // Habilitar el botón Agregar

            CalcularTotal();
            LimpiarCampos();
        }
            // Limpiar campos del formulario
        private void LimpiarCampos()
        {
            textCodProduct.Clear();
            textProducto.Clear();
            textPrecio.Clear();
            textPrecioV.Clear();
            numericCantidad.Value = numericCantidad.Minimum;
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
                string codigoProducto =
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
                textCodProduct.Text = codigoProducto;
                textProducto.Text = producto;
                textPrecio.Text = precio.ToString("0.00");
                textPrecioV.Text = precioVenta.ToString("0.00");

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
            // Validar que Tipo de Documento no esté sin seleccionar
            if (comboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento (Boleta o Factura).", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboTipoDocumento.Focus();
                return;
            }

            // Validar datos del Proveedor
            if (string.IsNullOrWhiteSpace(textNumDocumento.Text) ||
                string.IsNullOrWhiteSpace(textRazonSocial.Text))
            {
                MessageBox.Show("Debe completar todos los datos del proveedor antes de registrar la compra.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que haya al menos un producto en el DataGridView
            if (dataGridView1.Rows.Count == 0 || (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                MessageBox.Show("Debe agregar al menos un producto a la lista antes de registrar la compra.", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación y registro
            MessageBox.Show("Compra registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar proveedor y tipo de documento
            comboTipoDocumento.SelectedIndex = -1;
            textNumDocumento.Clear();
            textRazonSocial.Clear();

            // Limpiar productos y controles llamando a tu método de limpieza
            LimpiarCampos();

            // Limpiar tabla y totales
            dataGridView1.Rows.Clear();
            totalAPagar = 0;
            textTotalPagar.Text = "0.00";
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
            if (string.IsNullOrWhiteSpace(textProducto.Text))
            {
                MessageBox.Show("Complete los campos para actualizar el producto.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un precio de compra válido.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal.TryParse(textPrecioV.Text, out decimal precioVenta);
            int cantidad = (int)numericCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subTotal = precio * cantidad;

            // ACTUALIZAR LA FILA SELECCIONADA
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
    }
}
