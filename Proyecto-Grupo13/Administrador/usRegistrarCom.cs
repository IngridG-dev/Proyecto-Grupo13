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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconBtnCrearVenta_Click(object sender, EventArgs e)
        {

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
            // Validar que solo se ingresen numeros y letras
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
                                  // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten letras y números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void iconBtnAgregarC_Click(object sender, EventArgs e)
        {
            // Validar que el producto no esté vacío
            if (string.IsNullOrWhiteSpace(textProducto.Text))
            {
                MessageBox.Show("Complete los campos para registrar un producto.", "Advertencia",
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
                    textCodProduct.Text;

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
                iconBtnAgregarC.Text = "Agregar";

                LimpiarCampos();

                return;
            }
            // SI NO ESTAMOS EDITANDO SE AGREGA PRODUCTO NUEVO
            dataGridView1.Rows.Add(new object[]
            {
        textCodProduct.Text,
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
            textCodProduct.Clear();
            textProducto.Clear();
            textPrecio.Clear();
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

            // boton editar
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                int fila = e.RowIndex;

                // Obtener Código del producto
                string codigoProducto =
                    dataGridView1.Rows[fila].Cells["CodigoProducto"].Value?.ToString() ?? "";

                // Obtener nombre del producto
                string producto =
                    dataGridView1.Rows[fila].Cells["Producto"].Value?.ToString() ?? "";

                // Obtener precio
                decimal.TryParse(
                    dataGridView1.Rows[fila].Cells["Precio"].Value?.ToString(),
                    out decimal precio
                );

                // Obtener cantidad
                object valorCantidad =
                    dataGridView1.Rows[fila].Cells["Cantidad"].Value;

                int cantidad = 0;

                if (valorCantidad != null)
                {
                    if (decimal.TryParse(
                        valorCantidad.ToString(),
                        out decimal cantidadDecimal))
                    {
                        cantidad = (int)cantidadDecimal;
                    }
                }

                // Mostrar los datos nuevamente en los controles
                textCodProduct.Text = codigoProducto;
                textProducto.Text = producto;
                textPrecio.Text = precio.ToString("0.00");

                // Verificar que la cantidad esté dentro de los límites
                numericCantidad.Value = Math.Max(
                    numericCantidad.Minimum,
                    Math.Min(numericCantidad.Maximum, cantidad)
                );

                // Guardar qué fila estamos editando
                filaEditando = fila;

                // Cambiar el texto del botón
                iconBtnAgregarC.Text = "Actualizar";
            }


            // boton eliminar
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
    }
}
