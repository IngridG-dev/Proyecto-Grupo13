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
            // Capturar los datos de los TextBox
            string producto = textProducto.Text;
            decimal precio = Convert.ToDecimal(textPrecio.Text);
            int cantidad = Convert.ToInt32((int)numericCantidad.Value);

            // Calcular el Sub Total
            decimal subTotal = precio * cantidad;

            // Agregar la fila al DataGridView 
            dataGridView1.Rows.Add(new object[] {
                producto,
                precio.ToString("0.00"),
                cantidad,
                subTotal.ToString("0.00")
            });

            // Sumar al Total general y mostrarlo en pantalla
            totalAPagar += subTotal;
            textTotalPagar.Text = totalAPagar.ToString("0.00");
            // Limpiar los TextBox y el NumericUpDown
            textProducto.Clear();
            textPrecio.Clear();
            numericCantidad.Value = 0;
        }

        private void textPagaCon_TextChanged(object sender, EventArgs e)
        {
            // Verificamos que la caja no esté vacía para evitar errores
            if (!string.IsNullOrEmpty(textPagaCon.Text))
            {
                // Usamos TryParse por si el usuario escribe letras sin querer
                if (decimal.TryParse(textPagaCon.Text, out decimal pagaCon))
                {
                    decimal cambio = pagaCon - totalAPagar;

                    // Verificamos si el pago alcanza
                    if (cambio >= 0)
                    {
                        textCambio.Text = cambio.ToString("0.00");
                    }
                    else
                    {
                        textCambio.Text = "Falta dinero";
                    }
                }
            }
            // Si la caja está vacía, mostramos 0.00 como cambio
            else
            {
                textCambio.Text = "0.00";
            }
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

        }

        private void ucRegistroVenta_Load(object sender, EventArgs e)
        {

        }
    }
}