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
    public partial class UcProductos1 : UserControl
    {
        private int filaEditar = -1; // Variable para almacenar la fila que se está editando
        public UcProductos1()
        {
            InitializeComponent();
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

        private bool ValidarCamposVacios()
        {
            bool esValido = true;

            // Color normal de los TextBox
            Color colorNormal = Color.FromArgb(70, 75, 85);

            // =========================
            // NOMBRE
            // =========================
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                textNombre.BackColor = Color.LightPink;
                esValido = false;
            }
            else
            {
                textNombre.BackColor = colorNormal;
            }

            // =========================
            // CODIGO
            // =========================
            if (string.IsNullOrWhiteSpace(textCodigo.Text))
            {
                textCodigo.BackColor = Color.LightPink;
                esValido = false;
            }
            else
            {
                textCodigo.BackColor = colorNormal;
            }

            // =========================
            // DESCRIPCION
            // =========================
            if (string.IsNullOrWhiteSpace(textDescripcion.Text))
            {
                textDescripcion.BackColor = Color.LightPink;
                esValido = false;
            }
            else
            {
                textDescripcion.BackColor = colorNormal;
            }

            // =========================
            // STOCK
            // =========================
            if (string.IsNullOrWhiteSpace(textStock.Text))
            {
                textStock.BackColor = Color.LightPink;
                esValido = false;
            }
            else
            {
                textStock.BackColor = colorNormal;
            }
            // =========================
            // CATEGORIA
            // =========================
            if (comboBoxCategoria.SelectedIndex == -1)
            {
                comboBoxCategoria.BackColor = Color.LightPink;
                esValido = false;
            }
            else
            {
                comboBoxCategoria.BackColor = colorNormal;
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios() == true)
            {
                if (filaEditar != -1)
                {
                    DialogResult askEdit = MessageBox.Show("¿Desea guardar los cambios del producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (askEdit == DialogResult.Yes)
                    {
                        // Actualizar la fila seleccionada con los nuevos datos
                        dataGridView2.Rows[filaEditar].Cells[0].Value = formatearTexto(textNombre.Text);
                        dataGridView2.Rows[filaEditar].Cells[1].Value = textCodigo.Text;
                        dataGridView2.Rows[filaEditar].Cells[2].Value = textDescripcion.Text;
                        dataGridView2.Rows[filaEditar].Cells[3].Value = comboBoxCategoria.Text;
                        dataGridView2.Rows[filaEditar].Cells[4].Value = textStock.Text;
                        // Aquí iría la lógica para actualizar el producto en la base de datos o lista (NOTA)
                        MessageBox.Show("Producto editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpiar los campos de texto y restablecer el índice de la fila a editar
                        textNombre.Clear();
                        textCodigo.Clear();
                        textDescripcion.Clear();
                        comboBoxCategoria.SelectedIndex = -1; // Limpiar selección del ComboBox
                        textStock.Clear();
                        filaEditar = -1; // Reinicia el índice de la fila a editar
                    }
                    else
                    {
                        // Si el usuario no desea guardar los cambios, simplemente se limpia el índice de la fila a editar
                        filaEditar = -1; // Reinicia el índice de la fila a editar
                    }
                }
                else
                {
                    DialogResult ask = MessageBox.Show("¿Desea agregar el producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (ask == DialogResult.Yes)
                    {
                        string nombre = formatearTexto(textNombre.Text);

                        // Agregar el producto a la tabla (DataGridView)
                        dataGridView2.Rows.Add(nombre, textCodigo.Text, textDescripcion.Text, comboBoxCategoria.Text, textStock.Text);

                        // Aquí iría la lógica para agregar el producto a la base de datos o lista (NOTA)
                        MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textNombre.Clear();
                        textCodigo.Clear();
                        textDescripcion.Clear();
                        comboBoxCategoria.SelectedIndex = -1; // Limpiar selección del ComboBox
                        textStock.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                DialogResult ask = MessageBox.Show("¿Desea eliminar el producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == DialogResult.Yes)
                {
                    if (!dataGridView2.SelectedRows[0].IsNewRow)
                    {
                        // Eliminar la fila seleccionada del DataGridView
                        dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para editar.", "Sin selección",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            filaEditar = dataGridView2.SelectedRows[0].Index; //guarda el indice de la fila seleccionada
            if (dataGridView2.Rows[filaEditar].IsNewRow)
            {
                MessageBox.Show("No se puede editar una fila vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filaEditar = -1; // Reinicia el índice de la fila a editar
                return;
            }
            DataGridViewRow fila = dataGridView2.Rows[filaEditar]; // Obtiene la fila seleccionada

            //se pasa los datos de la tabla a los campos de texto para poder editarlos
            textNombre.Text = fila.Cells[0].Value?.ToString();
            textCodigo.Text = fila.Cells[1].Value?.ToString();
            textDescripcion.Text = fila.Cells[2].Value?.ToString();
            comboBoxCategoria.Text = fila.Cells[3].Value?.ToString();
            textStock.Text = fila.Cells[4].Value?.ToString();

            MessageBox.Show("Edite los campos y haga clic en 'Agregar Producto' para guardar los cambios.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void labelProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
