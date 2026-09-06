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
    public partial class UserControl2 : UserControl
    {
        private int filaEditar = -1; // Variable para almacenar la fila que se está editando
        public UserControl2()
        {
            InitializeComponent();
        }

        // VALIDACIONES DE LOS TEXTBOX PARA QUE SOLO SE INGRESEN LETRAS O NUMEROS SEGUN CORRESPONDA
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo se ingresen letras y espacios
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
                // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten letras y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        private void textDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo se ingresen números y espacios
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
                // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Validar que solo se ingresen letras, números, '@' y '.'
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
                // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten letras, números, '@' y '.'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
                // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
                // Mostrar un mensaje de advertencia
                MessageBox.Show("Solo se permiten letras, números y espacios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool ValidarCamposVacios()
        {
            bool esValido = true;

            // Color normal de los TextBox
            Color colorNormal = Color.FromArgb(70, 75, 85);
            // NOMBRE
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                textNombre.BackColor = Color.LightPink;
                esValido = false;
            }
            else
            {
                textNombre.BackColor = colorNormal;
            }

            // DNI
            if (string.IsNullOrWhiteSpace(textDNI.Text))
            {
                textDNI.BackColor = Color.LightPink;
                esValido = false;
            }
            else
            {
                textDNI.BackColor = colorNormal;
            }

            // EMAIL
            if (string.IsNullOrWhiteSpace(textEmail.Text))
            {
                textEmail.BackColor = Color.LightPink;
                esValido = false;
            }
            else
            {
                textEmail.BackColor = colorNormal;
            }
            // TELÉFONO
            if (string.IsNullOrWhiteSpace(textTelefono.Text))
            {
                textTelefono.BackColor = Color.LightPink;
                esValido = false;
            }
            else
            {
                textTelefono.BackColor = colorNormal;
            }
            // DIRECCIÓN
            if (string.IsNullOrWhiteSpace(textDireccion.Text))
            {
                textDireccion.BackColor = Color.LightPink;
                esValido = false;
            }
            else
            {
                textDireccion.BackColor = colorNormal;
            }
            // ROL
            if (comboBoxRol.SelectedIndex == -1)
            {
                comboBoxRol.BackColor = Color.LightPink;
                esValido = false;
            }
            else
            {
                comboBoxRol.BackColor = colorNormal;
            }
            // ESTADO
            if (comboBoxEstado.SelectedIndex == -1)
            {
                comboBoxEstado.BackColor = Color.LightPink;
                esValido = false;
            }
            else
            {
                comboBoxEstado.BackColor = colorNormal;
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

        //BOTONES AGREGAR, ELIMINAR, BUSCAR Y EDITAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos que no haya campos vacíos antes de insertar en la tabla
            if (ValidarCamposVacios() == true)
            {
                if (filaEditar != -1)
                {
                    DialogResult askEdit = MessageBox.Show("¿Desea guardar los cambios del producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (askEdit == DialogResult.Yes)
                    {
                        // Actualizar la fila seleccionada con los nuevos datos
                        dataGridView1.Rows[filaEditar].Cells[0].Value = formatearTexto(textNombre.Text);
                        dataGridView1.Rows[filaEditar].Cells[1].Value = textDNI.Text;
                        dataGridView1.Rows[filaEditar].Cells[2].Value = textEmail.Text;
                        dataGridView1.Rows[filaEditar].Cells[3].Value = textTelefono.Text;
                        dataGridView1.Rows[filaEditar].Cells[4].Value = textDireccion.Text;
                        dataGridView1.Rows[filaEditar].Cells[5].Value = comboBoxRol.Text;
                        dataGridView1.Rows[filaEditar].Cells[6].Value = comboBoxEstado.Text;
                        // Aquí iría la lógica para actualizar el producto en la base de datos o lista (NOTA)
                        MessageBox.Show("Producto editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Limpiar los campos de texto y restablecer el índice de la fila a editar
                        textNombre.Clear();
                        textDNI.Clear();
                        textEmail.Clear();
                        textTelefono.Clear();
                        textDireccion.Clear();
                        comboBoxRol.SelectedIndex = -1;
                        comboBoxEstado.SelectedIndex = -1;
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
                    // Hacemos una pregunta de confirmación antes de insertar el nuevo usuario
                    DialogResult ask = MessageBox.Show("¿Seguro que desea insertar este nuevo usuario?", "Confirmar inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                    // Si aprieta "Sí", se procede a insertar el nuevo usuario en la tabla
                    if (ask == DialogResult.Yes)
                    {
                        // Formateamos el texto del nombre
                        string nombre = formatearTexto(textNombre.Text);

                        // Agregamos los datos a la tabla
                        dataGridView1.Rows.Add(nombre, textDNI.Text, textEmail.Text, textTelefono.Text, textDireccion.Text, comboBoxRol.Text, comboBoxEstado.Text);

                        MessageBox.Show("El usuario " + nombre + " se insertó correctamente en la tabla.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiamos los campos
                        textNombre.Clear();
                        textDNI.Clear();
                        textDireccion.Clear();
                        textEmail.Clear();
                        textTelefono.Clear();
                        comboBoxRol.SelectedIndex = -1;
                        comboBoxEstado.SelectedIndex = -1;

                        textNombre.Focus();
                    }
                    // Si aprieta "NO" no se hace nada y se cancela la insercion
                }
            }
            else
            {
                MessageBox.Show("Faltan completar campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Preguntamos si esta seguro de eliminar 
                DialogResult ask = MessageBox.Show("¿Seguro que desea eliminar el registro seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                // Si dice que Si
                if (ask == DialogResult.Yes)
                {
                    // Verificamos que no intente borrar la ultima fila en blanco (la que usa el DataGridView para agregar nuevos datos a mano)
                    if (!dataGridView1.SelectedRows[0].IsNewRow)
                    {
                        // Borramos la fila usando el indice de la que esta seleccionada
                        dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                        MessageBox.Show("El registro se eliminó correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar una fila vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Si apreto el boton sin seleccionar nada en la tabla
                MessageBox.Show("Por favor, seleccione toda la fila que desea eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.", "Sin selección",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            filaEditar = dataGridView1.SelectedRows[0].Index; //guarda el indice de la fila seleccionada
            if (dataGridView1.Rows[filaEditar].IsNewRow)
            {
                MessageBox.Show("No se puede editar una fila vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filaEditar = -1; // Reinicia el índice de la fila a editar
                return;
            }
            DataGridViewRow fila = dataGridView1.Rows[filaEditar]; // Obtiene la fila seleccionada

            //se pasa los datos de la tabla a los campos de texto para poder editarlos
            textNombre.Text = fila.Cells[0].Value?.ToString();
            textDNI.Text = fila.Cells[1].Value?.ToString();
            textEmail.Text = fila.Cells[2].Value?.ToString();
            textTelefono.Text = fila.Cells[3].Value?.ToString();
            textDireccion.Text = fila.Cells[4].Value?.ToString();
            comboBoxRol.Text = fila.Cells[5].Value?.ToString();
            comboBoxEstado.Text = fila.Cells[6].Value?.ToString();

            MessageBox.Show("Edite los campos y haga clic en 'Agregar Producto' para guardar los cambios.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
