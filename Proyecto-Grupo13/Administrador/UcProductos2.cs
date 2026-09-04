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
    public partial class UcProductos2 : UserControl
    {
        public UcProductos2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //VALIDACIONES DE LOS TEXTBOX PARA QUE SOLO SE INGRESEN LETRAS O NUMEROS SEGUN CORRESPONDA
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
                // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten letras y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo se ingresen numeros y letras
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
                // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten letras y números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo se ingresen letras, números y espacios
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
                // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten letras, números y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo se ingresen números
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
                // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void labelBuscar_Click(object sender, EventArgs e) { }

        private void labelListaProductos_Click(object sender, EventArgs e) { }
        //Metodo para validar campos 
        private bool ValidarCamposVacios()
        {
            bool esValido = true;

            // Recorremos cada control que esté en el formulario
            foreach (Control control in this.Controls)
            {
                // Nos aseguramos de que el control sea realmente un TextBox
                if (control is TextBox cajaDeTexto)
                {
                    // Verificamos si está vacío o solo tiene espacios en blanco
                    if (string.IsNullOrWhiteSpace(cajaDeTexto.Text))
                    {
                        // Si falla, le cambiamos el color de fondo para alertar al usuario
                        cajaDeTexto.BackColor = Color.LightPink;
                        esValido = false;
                    }
                    else
                    {
                        cajaDeTexto.BackColor = Color.FromArgb(70, 75, 85);
                    }
                }
            }

            return esValido;
        }

        //METODO PARA FORMATEAR EL TEXTO: PRIMERA LETRA MAYUSCULA Y EL RESTO MINUSCULA
        private string formatearTexto(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return "";
            // Primera letra mayúscula, el resto minúscula
            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }

        //BOTONES PARA AGREGAR, ELIMINAR Y EDITAR PRODUCTOS
        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios() == true)
            {
                DialogResult ask = MessageBox.Show("¿Desea agregar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    string nombre = formatearTexto(textNombre.Text);

                    // Agregar el producto a la tabla (DataGridView)
                    dataGridView1.Rows.Add(nombre, textCodigo.Text, textDescripcion.Text, textStock.Text);

                    // Aquí iría la lógica para agregar el producto a la base de datos o lista (NOTA)
                    MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textNombre.Clear();
                    textCodigo.Clear();
                    textDescripcion.Clear();
                    comboBoxCatego.SelectedIndex = -1; // Limpiar selección del ComboBox
                    textStock.Clear();
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditarProd_Click(object sender, EventArgs e) { }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult ask = MessageBox.Show("¿Desea eliminar el producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    if (!dataGridView1.SelectedRows[0].IsNewRow)
                    {
                        // Eliminar la fila seleccionada del DataGridView
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        // Aquí iría la lógica para eliminar el producto de la base de datos o lista (NOTA)
                        MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar una fila en blanco.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
