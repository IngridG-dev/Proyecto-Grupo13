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

namespace Proyecto_Grupo13.Vendedor
{
    public partial class ucRegistroVenta : UserControl
    {
        private int filaEditando = -1; // Variable para almacenar el índice de la fila que se está editando
        decimal totalAPagar = 0;
        public ucRegistroVenta()
        {
            InitializeComponent();
            cargarMetodoPago();
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

        private void textProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, números, espacios, caracteres de control y signos de puntuación/símbolos
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsPunctuation(e.KeyChar) &&
                !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese un carácter no permitido
            }
        }
        private void textNombreComple_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese un carácter no alfabético
                // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten letras y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textPrecio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;

                MessageBox.Show(
                    "Solo se permiten números y el punto decimal.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            // Evitar más de un punto decimal
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void textStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese un carácter no numérico
                // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            string separador = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string tecla = e.KeyChar.ToString();

            if (!char.IsDigit(e.KeyChar) && tecla != separador)
            {
                e.Handled = true;
                MessageBox.Show($"Solo se permiten números y el separador decimal ({separador}).", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tecla == separador && ((TextBox)sender).Text.Contains(separador))
                e.Handled = true;
        }
        

        //CONFIGURACION DE BOTONES
        // Evento para agregar un producto al DataGridView
        private void iconBtnAgregarV_Click(object sender, EventArgs e)
        {
            if (textBoxCodProduct.Tag == null || Convert.ToInt32(textBoxCodProduct.Tag) <= 0)
            {
                MessageBox.Show("Seleccione un producto con la lupa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProducto = Convert.ToInt32(textBoxCodProduct.Tag);

            if (!decimal.TryParse(textPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textStock.Text, out int stockDisponible))
            {
                MessageBox.Show("El valor del stock no es válido o está vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cantidad = (int)numericCantidad.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1) EDITANDO: la cantidad reemplaza a la anterior
            if (filaEditando != -1)
            {
                if (cantidad > stockDisponible)
                {
                    MessageBox.Show($"La cantidad ({cantidad}) no puede ser mayor al stock disponible ({stockDisponible}).",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataGridViewRow filaEdit = dataGridView1.Rows[filaEditando];
                filaEdit.Cells["Cantidad"].Value = cantidad;
                filaEdit.Cells["SubTotal"].Value = (precio * cantidad).ToString("0.00");

                filaEditando = -1;
                // Sumar al total general
             CalcularTotal();
                // Limpiar campos
             LimpiarCampos();
                return;
            }
            // 2) ¿EL PRODUCTO YA ESTÁ EN LA VENTA? -> se suma a la fila existente
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.IsNewRow) continue;
                if (Convert.ToInt32(fila.Cells["IdProducto"].Value) != idProducto) continue;

                int cantidadActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                int nuevaCantidad = cantidadActual + cantidad;

                if (nuevaCantidad > stockDisponible)
                {
                    MessageBox.Show(
                        $"Ya tiene {cantidadActual} en la venta y el stock disponible es {stockDisponible}. " +
                        $"Puede agregar {Math.Max(0, stockDisponible - cantidadActual)} más como máximo.",
                        "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                fila.Cells["Precio"].Value = precio.ToString("0.00");
                fila.Cells["Cantidad"].Value = nuevaCantidad;
                fila.Cells["SubTotal"].Value = (precio * nuevaCantidad).ToString("0.00");

                CalcularTotal();
                LimpiarCampos();
                return;
            }

            // 3) PRODUCTO NUEVO EN LA VENTA
            if (cantidad > stockDisponible)
            {
                MessageBox.Show($"La cantidad a agregar ({cantidad}) no puede ser mayor al stock disponible ({stockDisponible}).",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int nueva = dataGridView1.Rows.Add();
            DataGridViewRow filaNueva = dataGridView1.Rows[nueva];
            filaNueva.Cells["IdProducto"].Value = idProducto;
            filaNueva.Cells["CodigoProducto"].Value = textBoxCodProduct.Text;
            filaNueva.Cells["Producto"].Value = textProducto.Text;
            filaNueva.Cells["Precio"].Value = precio.ToString("0.00");
            filaNueva.Cells["Cantidad"].Value = cantidad;
            filaNueva.Cells["SubTotal"].Value = (precio * cantidad).ToString("0.00");
            filaNueva.Cells["Stock"].Value = stockDisponible;

            CalcularTotal();
            LimpiarCampos();
        }

        // Limpiar campos del formulario
        private void LimpiarCampos()
        {
            textBoxCodProduct.Clear();
            textBoxCodProduct.Tag = null;
            textProducto.Clear();
            textPrecio.Clear();
            textStock.Clear();
            numericCantidad.Value = 1;

            buttonBuscar2.Enabled = true;
            iconBtnCancelar.Visible = false;
            iconBtnAgregarV.Text = "Agregar";
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

        private void iconBtnCrearVenta_Click(object sender, EventArgs e)
        {
            // CLIENTE (tiene que venir de la lupa)
            if (textNumDocumento.Tag == null || Convert.ToInt32(textNumDocumento.Tag) <= 0)
            {
                MessageBox.Show("Debe seleccionar un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TIPO DE DOCUMENTO
            if (comboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de documento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboTipoDocumento.Focus();
                return;
            }

            // FORMA DE PAGO
            if (comboFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una forma de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboFormaPago.Focus();
                return;
            }

            // PRODUCTOS
            bool hayProductos = dataGridView1.Rows.Cast<DataGridViewRow>().Any(r => !r.IsNewRow);
            if (!hayProductos)
            {
                MessageBox.Show("Debe agregar al menos un producto a la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SI ES EFECTIVO, VALIDAR "PAGA CON"
            if (string.Equals(comboFormaPago.Text, "Efectivo", StringComparison.OrdinalIgnoreCase))
            {
                if (!decimal.TryParse(textPagaCon.Text, out decimal pagaCon))
                {
                    MessageBox.Show("Ingrese un monto válido en 'Paga con'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textPagaCon.Focus();
                    return;
                }

                if (pagaCon < totalAPagar)
                {
                    MessageBox.Show("El monto ingresado en 'Paga con' es menor al total a pagar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textPagaCon.Focus();
                    return;
                }

                textCambio.Text = (pagaCon - totalAPagar).ToString("0.00");
            }
            else
            {
                textPagaCon.Clear();
                textCambio.Clear();
            }

            // USUARIO LOGUEADO
            if (SesionActual.usuarioLogueado == null)
            {
                MessageBox.Show("No hay un usuario logueado. Por favor, inicie sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ARMAR EL DETALLE DESDE LA GRILLA
            DataTable detalleVenta = new DataTable();
            detalleVenta.Columns.Add("IdProducto", typeof(int));
            detalleVenta.Columns.Add("Producto", typeof(string));
            detalleVenta.Columns.Add("PrecioVenta", typeof(decimal));
            detalleVenta.Columns.Add("Cantidad", typeof(int));

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                detalleVenta.Rows.Add(
                    Convert.ToInt32(row.Cells["IdProducto"].Value),
                    row.Cells["Producto"].Value.ToString(),
                    Convert.ToDecimal(row.Cells["Precio"].Value),
                    Convert.ToInt32(row.Cells["Cantidad"].Value));
            }

            Venta oVenta = new Venta()
            {
                usuario = new Usuario() { id_usuario = SesionActual.usuarioLogueado.id_usuario },
                cliente = new Cliente() { id_cliente = Convert.ToInt32(textNumDocumento.Tag) },
                tipoDocumento = comboTipoDocumento.Text,
                metodoPago = new MetodoPago() { id_metodoPago = Convert.ToInt32(comboFormaPago.SelectedValue) }
            };

            string mensaje;
            bool resultado = new CL_Venta().RegistrarVenta(oVenta, detalleVenta, out mensaje);

            if (!resultado)
            {
                MessageBox.Show(mensaje, "Error al registrar la venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Venta registrada con éxito.", "Registro de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // LIMPIAR PANTALLA
            dataGridView1.Rows.Clear();
            totalAPagar = 0;
            textTotalPagar.Text = "0.00";
            textPagaCon.Clear();
            textCambio.Clear();

            textNumDocumento.Clear();
            textNumDocumento.Tag = null;
            textNombreComple.Clear();

            comboFormaPago.SelectedIndex = -1;
            comboTipoDocumento.SelectedIndex = -1;

            filaEditando = -1;
            LimpiarCampos();
        }

        private void buttonBuscar2_Click(object sender, EventArgs e)
        {
            using (FormBuscarProducto modal = new FormBuscarProducto())
            {
                if (modal.ShowDialog() == DialogResult.OK && modal.productoSeleccionado != null)
                {
                    // Procesar el producto seleccionado
                    Producto producto = modal.productoSeleccionado;
                    textBoxCodProduct.Tag = producto.id_producto; // Guardar el ID del producto en el Tag
                    textBoxCodProduct.Text = producto.codigo;
                    textProducto.Text = producto.nombreProducto;
                    textPrecio.Text = producto.precioVenta.ToString("0.00"); // Formatear el precio de venta a dos decimales
                    textStock.Text = producto.stock.ToString();
                    numericCantidad.Value = 1; // Reiniciar la cantidad a 1
                }
            }
        }

        private void ucRegistroVenta_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dataGridView1.Rows[e.RowIndex].IsNewRow) return;

            // Botón Editar
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                textBoxCodProduct.Tag = fila.Cells["IdProducto"].Value;
                textBoxCodProduct.Text = fila.Cells["CodigoProducto"].Value?.ToString() ?? "";
                textProducto.Text = fila.Cells["Producto"].Value?.ToString() ?? "";
                textPrecio.Text = fila.Cells["Precio"].Value?.ToString() ?? "";
                textStock.Text = fila.Cells["Stock"].Value?.ToString() ?? "";
                int.TryParse(fila.Cells["Cantidad"].Value?.ToString(), out int cantidad); // Intentar convertir la cantidad a entero de manera segura
                numericCantidad.Value = Math.Max(numericCantidad.Minimum, Math.Min(numericCantidad.Maximum, cantidad)); // Asegurarse de que la cantidad esté dentro de los límites del NumericUpDown

                filaEditando = e.RowIndex; // Guardar el índice de la fila en edición
                iconBtnAgregarV.Text = "Actualizar";
                iconBtnCancelar.Visible = true;
                buttonBuscar2.Enabled = false; // Deshabilitar el botón de búsqueda mientras se edita
            }
             // Botón Eliminar
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
              DialogResult result = MessageBox.Show(
               "¿Está seguro de que desea eliminar este producto de la venta?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
              );
                if (result == DialogResult.Yes)
                {
                 dataGridView1.Rows.RemoveAt(e.RowIndex);
                 if (filaEditando != -1) // Si se estaba editando una fila, reiniciar el estado de edición
                 {
                   filaEditando = -1;
                   LimpiarCampos();
                 }
                  // Actualizar el total general después de eliminar
                 CalcularTotal();
                }
            }
        }

        private void textPagaCon_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(textPagaCon.Text, out decimal pagaCon))
            {
                decimal cambio = pagaCon - totalAPagar;

                if (cambio >= 0)
                {
                    textCambio.Text = cambio.ToString("0.00");
                }
                else
                {
                    textCambio.Text = "0.00";
                }
            }
            else
            {
                textCambio.Text = "0.00";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (FormBuscarCliente modal = new FormBuscarCliente())
            {
                // Mostrar el buscador como ventana modal
                DialogResult result = modal.ShowDialog();

                // Si se seleccionó un cliente (se hizo doble clic)
                if (result == DialogResult.OK && modal.ClienteSeleccionado != null)
                {
                    // Completar los campos con los datos retornados
                    textNumDocumento.Tag = modal.ClienteSeleccionado.id_cliente;
                    textNumDocumento.Text = modal.ClienteSeleccionado.dni.ToString();
                    textNombreComple.Text = modal.ClienteSeleccionado.nombre + " " + modal.ClienteSeleccionado.apellido;
                }
            }
        }

        private void textNombreComple_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFormaPago.SelectedIndex == -1)
            {
                // Si no hay forma de pago seleccionada
                textPagaCon.Enabled = false;
                textCambio.Enabled = false;

                textPagaCon.Clear();
                textCambio.Clear();

                return;
            }

            // Si selecciona EFECTIVO
            if (comboFormaPago.Text == "Efectivo")
            {
                textPagaCon.Enabled = true;
                textCambio.Enabled = true;

                textPagaCon.Focus();
            }
            else
            {
                // Si selecciona TARJETA, TRANSFERENCIA, etc.
                textPagaCon.Enabled = false;
                textCambio.Enabled = false;

                textPagaCon.Clear();
                textCambio.Clear();
            }
        }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            filaEditando = -1;
        }
        private void cargarMetodoPago()
        {
           comboFormaPago.Items.Clear();
            comboFormaPago.DataSource = new CL_Venta().ListarMetodosPago(); // Llamada a la capa lógica para obtener los métodos de pago
            comboFormaPago.DisplayMember = "descripcion"; // Propiedad a mostrar en el ComboBox
            comboFormaPago.ValueMember = "id_metodoPago"; // Propiedad que representa el valor del ComboBox
            comboFormaPago.SelectedIndex = -1; // No seleccionar ningún elemento por defecto
        }
    }
}