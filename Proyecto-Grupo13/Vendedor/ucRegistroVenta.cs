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

        private void textProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingrese un carácter no alfabético
                // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten letras y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Evita que se ingrese un carácter no numérico
                // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten números y el punto decimal.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            // Calcular subtotal
            decimal subTotal = precio * cantidad;

            // SI ESTAMOS EDITANDO
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
            dataGridView1.Rows.Add(new object[]
            {
        textBoxCodProduct.Text,
        textProducto.Text,
        precio.ToString("0.00"),
        cantidad,
        subTotal.ToString("0.00")
            });

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
            numericCantidad.Value = 0;
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
            MessageBox.Show("Venta registrada con éxito.", "Registro de Venta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Limpiar el DataGridView y los TextBox
            dataGridView1.Rows.Clear();
            totalAPagar = 0;
            textTotalPagar.Text = "0.00";
            textPagaCon.Clear();
            textCambio.Clear();
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

                // Asignar al NumericUpDown (validando que el valor no supere sus límites)
                numericCantidad.Value = Math.Max(numericCantidad.Minimum, Math.Min(numericCantidad.Maximum, cantidad));

                filaEditando = fila; // Guardar el índice de la fila en edición
                iconBtnAgregarV.Text = "Actualizar";
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
    }
}