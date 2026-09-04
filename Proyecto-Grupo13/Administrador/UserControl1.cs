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
    public partial class ucUsuarios : UserControl
    {
        public ucUsuarios()
        {
            InitializeComponent();
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e){}
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}



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
        private void textDni_KeyPress(object sender, KeyPressEventArgs e)
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
        private void textDireccionCalle_KeyPress(object sender, KeyPressEventArgs e)
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



        // CONFIGURAMOS LOS BOTONES DE AGREGAR Y ELIMINAR REGISTROS DE LA TABLA
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos que no haya campos vacíos antes de insertar en la tabla
            if (ValidarCamposVacios() == true)
            {
                // Hacemos una pregunta de confirmación antes de insertar el nuevo usuario
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar este nuevo usuario?", "Confirmar inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                // Si aprieta "Sí", se procede a insertar el nuevo usuario en la tabla
                if (ask == DialogResult.Yes)
                {
                    // Formateamos el texto del nombre
                    string nombre = formatearTexto(textNombre.Text);

                    // Agregamos los datos a la tabla
                    dataGridView1.Rows.Add(nombre, textDni.Text, textEmail.Text, textTelefono.Text, textDireccionCalle.Text, comboBoxRol.Text, comboBoxEstado.Text);

                    MessageBox.Show("El usuario " + nombre + " se insertó correctamente en la tabla.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiamos los campos
                    textNombre.Clear();
                    textDni.Clear();
                    textDireccionCalle.Clear();
                    textEmail.Clear();
                    textTelefono.Clear();
                    comboBoxRol.SelectedIndex = -1;
                    comboBoxEstado.SelectedIndex = -1;

                    textNombre.Focus();
                }
                // Si aprieta "NO" no se hace nada y se cancela la insercion
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

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
