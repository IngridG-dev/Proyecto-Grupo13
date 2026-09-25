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

        //CONFIGURACION DE BOTONES
        // Evento para agregar un producto al DataGridView
        private void iconBtnAgregarV_Click(object sender, EventArgs e)
        {
            // Validar que el producto no esté vacío
            if (string.IsNullOrWhiteSpace(textProducto.Text))
            {
                MessageBox.Show("Ingrese un producto.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el precio sea correcto
            if (!decimal.TryParse(textPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un precio válido.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener cantidad
            int cantidad = (int)numericCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validar que el stock sea correcto
            if (!int.TryParse(textStock.Text, out int stockDisponible))
            {
                MessageBox.Show("El valor del stock no es válido o está vacío.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Comparamos la cantidad a vender con el stock disponible
            if (cantidad > stockDisponible)
            {
                MessageBox.Show($"La cantidad a agregar ({cantidad}) no puede ser mayor al stock disponible ({stockDisponible}).",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calcular subtotal
            decimal subTotal = precio * cantidad;

            // SI ESTÁ EDITANDO
            if (filaEditando != -1)
            {
                // Obtener el subtotal anterior
                decimal subTotalAnterior = Convert.ToDecimal(
                    dataGridView1.Rows[filaEditando].Cells["SubTotal"].Value
                );

                // Actualizar los valores de la fila
                dataGridView1.Rows[filaEditando].Cells["CodigoProducto"].Value =
                    textBoxCodProduct.Text;

                dataGridView1.Rows[filaEditando].Cells["Producto"].Value =
                    textProducto.Text;

                dataGridView1.Rows[filaEditando].Cells["Precio"].Value =
                    precio.ToString("0.00");

                dataGridView1.Rows[filaEditando].Cells["Cantidad"].Value =
                    cantidad;

                dataGridView1.Rows[filaEditando].Cells["SubTotal"].Value =
                    subTotal.ToString("0.00");
                dataGridView1.Rows[filaEditando].Cells["Stock"].Value = textStock.Text;

                // Actualizar el total general
                CalcularTotal();

                textTotalPagar.Text = totalAPagar.ToString("0.00");

                // Salir del modo edición
                filaEditando = -1;
                iconBtnAgregarV.Text = "Agregar";

                LimpiarCampos();

                return;
            }

            // SI NO ESTAMOS EDITANDO SE AGREGA PRODUCTO NUEVO
            int nuevaFila = dataGridView1.Rows.Add(new object[]
            {
        textBoxCodProduct.Text,
        textProducto.Text,
        precio.ToString("0.00"),
        cantidad,
        subTotal.ToString("0.00")
            });

            dataGridView1.Rows[nuevaFila].Cells["Stock"].Value = textStock.Text;

            // Sumar al total general
            CalcularTotal();

            // Limpiar campos
            LimpiarCampos();
        }

        // Limpiar campos del formulario
        private void LimpiarCampos()
        {
            textBoxCodProduct.Clear();
            textProducto.Clear();
            textPrecio.Clear();
            textStock.Clear();
            numericCantidad.Value = 1;

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
            // VALIDAR CLIENTE
            if (string.IsNullOrWhiteSpace(textNumDocumento.Text) ||
                string.IsNullOrWhiteSpace(textNombreComple.Text))
            {
                MessageBox.Show(
                    "Debe completar todos los datos del cliente antes de registrar la venta.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }
            //VALIDAR TIPO DE DOCUMENTO
            if (comboTipoDocumento.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar un tipo de documento.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                comboTipoDocumento.Focus();
                return;
            }

            // VALIDAR FORMA DE PAGO
            if (comboFormaPago.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Debe seleccionar una forma de pago.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                comboFormaPago.Focus();
                return;
            }

            // VALIDAR PRODUCTOS
            if (dataGridView1.Rows.Count == 0 ||
                (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                MessageBox.Show(
                    "Debe agregar al menos un producto a la venta.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // OBTENER FORMA DE PAGO
            string formaPago = comboFormaPago.Text;

            // SI ES EFECTIVO, VALIDAR "PAGA CON"
            if (formaPago == "Efectivo")
            {
                if (string.IsNullOrWhiteSpace(textPagaCon.Text))
                {
                    MessageBox.Show(
                        "Debe ingresar el monto con el que paga el cliente.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    textPagaCon.Focus();
                    return;
                }
                //verificar que el monto ingresado sea un número válido
                if (!decimal.TryParse(textPagaCon.Text, out decimal pagaCon))
                {
                    MessageBox.Show(
                        "Ingrese un monto válido en 'Paga con'.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    textPagaCon.Focus();
                    return;
                }
                //verificar que el monto ingresado sea mayor o igual al total a pagar
                if (pagaCon < totalAPagar)
                {
                    MessageBox.Show(
                        "El monto ingresado en 'Paga con' es menor al total a pagar.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    textPagaCon.Focus();
                    return;
                }
                // Calcular el cambio
                decimal cambio = pagaCon - totalAPagar;
                textCambio.Text = cambio.ToString("0.00");
            }
            else
            {
                // Si NO es efectivo, no necesitamos Paga con ni Cambio
                textPagaCon.Clear();
                textCambio.Clear();
            }

            // REGISTRAR VENTA
            MessageBox.Show(
                "Venta registrada con éxito.",
                "Registro de Venta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // LIMPIAR DATOS
            dataGridView1.Rows.Clear();

            totalAPagar = 0;
            textTotalPagar.Text = "0.00";

            textPagaCon.Clear();
            textCambio.Clear();

            textNumDocumento.Clear();
            textNombreComple.Clear();

            comboFormaPago.SelectedIndex = -1;
            comboTipoDocumento.SelectedIndex = -1;

            LimpiarCampos();

            filaEditando = -1;
            iconBtnAgregarV.Text = "Agregar";
        }

        private void buttonBuscar2_Click(object sender, EventArgs e)
        {
            // 1. Creamos una "instancia" de tu formulario buscador
            FormBuscarProducto modalBuscador = new FormBuscarProducto();

            // 2. Usamos ShowDialog() en lugar de Show()
            // Esto es clave: hace que la ventana se abra bloqueando el fondo (modal)
            // para que el usuario no pueda tocar la ventana de ventas hasta que cierre el buscador.
            modalBuscador.ShowDialog();
        }

        private void ucRegistroVenta_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Botón Editar
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int fila = e.RowIndex;

                // Obtener los valores de forma segura evitando NullReferenceException
                string codigoProducto = dataGridView1.Rows[fila].Cells["CodigoProducto"].Value?.ToString() ?? "";
                string producto = dataGridView1.Rows[fila].Cells["Producto"].Value?.ToString() ?? "";

                // Lectura segura de Precio (soporta decimales)
                decimal.TryParse(dataGridView1.Rows[fila].Cells["Precio"].Value?.ToString(), out decimal precio);

                // Lectura segura de Cantidad (evita FormatException)
                object valCantidad = dataGridView1.Rows[fila].Cells["Cantidad"].Value;
                int cantidad = 0;

                if (valCantidad != null)
                {
                    // Si el valor viene como decimal/double/string, convertimos primero a decimal y luego a entero
                    if (decimal.TryParse(valCantidad.ToString(), out decimal cantDecimal))
                    {
                        cantidad = (int)cantDecimal;
                    }
                }

                // Mostrar los valores en los controles
                textBoxCodProduct.Text = codigoProducto;
                textProducto.Text = producto;
                textPrecio.Text = precio.ToString("0.00");
                textStock.Text = dataGridView1.Rows[fila].Cells["Stock"].Value?.ToString() ?? "";

                // Asignar al NumericUpDown (validando que el valor no supere sus límites)
                numericCantidad.Value = Math.Max(numericCantidad.Minimum, Math.Min(numericCantidad.Maximum, cantidad));

                filaEditando = fila; // Guardar el índice de la fila en edición
                iconBtnAgregarV.Text = "Actualizar";
                iconBtnCancelar.Visible = true;
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
        }
    }
}