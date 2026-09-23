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
    public partial class ucProveedor : UserControl
    {
        private int filaEditar = -1; // Variable para almacenar la fila que se está editando
        public ucProveedor()
        {
            InitializeComponent();
            LimpiarFormulario();
        }
        // VALIDACIONES DE LOS TEXTBOX PARA QUE SOLO SE INGRESEN LETRAS O NUMEROS SEGUN CORRESPONDA
        private void textRazonSocial_KeyPress(object sender, KeyPressEventArgs e)
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
        private bool ValidarCamposVacios()
        {
            bool esValido = true;

            // Color normal de los TextBox
            Color colorNormal = Color.FromArgb(70, 75, 85);
            // RAZON SOCIAL
            if (string.IsNullOrWhiteSpace(textRazonSocial.Text))
            {
                textRazonSocial.BackColor = Color.LightPink;
                textRazonSocial.ForeColor = Color.Black;
                esValido = false;
            }
            else
            {
                textRazonSocial.BackColor = colorNormal;
                textRazonSocial.ForeColor = Color.White;
            }

            // DNI
            if (string.IsNullOrWhiteSpace(textDNI.Text))
            {
                textDNI.BackColor = Color.LightPink;
                textDNI.ForeColor = Color.Black;
                esValido = false;
            }
            else
            {
                textDNI.BackColor = colorNormal;
                textDNI.ForeColor = Color.White;
            }

            // EMAIL
            if (string.IsNullOrWhiteSpace(textEmail.Text))
            {
                textEmail.BackColor = Color.LightPink;
                textEmail.ForeColor = Color.Black;
                esValido = false;
            }
            else
            {
                textEmail.BackColor = colorNormal;
                textEmail.ForeColor = Color.White;
            }
            // TELÉFONO
            if (string.IsNullOrWhiteSpace(textTelefono.Text))
            {
                textTelefono.BackColor = Color.LightPink;
                textTelefono.ForeColor = Color.Black;
                esValido = false;
            }
            else
            {
                textTelefono.BackColor = colorNormal;
                textTelefono.ForeColor = Color.White;
            }
            // ESTADO
            if (comboBoxEstado.SelectedIndex == -1)
            {
                comboBoxEstado.BackColor = Color.LightPink;
                comboBoxEstado.ForeColor = Color.Black;
                esValido = false;
            }
            else
            {
                comboBoxEstado.BackColor = colorNormal;
                comboBoxEstado.ForeColor = Color.White;
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
        //METODO PARA LIMPIAR EL FORMULARIO Y REINICIAR ESTADO
        private void LimpiarFormulario()
        {
            textRazonSocial.Clear();
            textDNI.Clear();
            textEmail.Clear();
            textTelefono.Clear();
            comboBoxEstado.SelectedIndex = -1;

            filaEditar = -1; // Reiniciamos la variable

            // Habilitamos/Deshabilitamos botones para evitar errores
            btnAgregar.Enabled = true;
            iconBtnActualizar.Enabled = false;
            iconBtnCancelar.Enabled = false;
        }

        //BOTONES AGREGAR, ELIMINAR, EDITAR, ACTUALIZA, CANCELAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos que no haya campos vacíos antes de insertar en la tabla
            if (ValidarCamposVacios())
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea insertar este nuevo proveedor?", "Confirmar inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (ask == DialogResult.Yes)
                {
                    string nombre = formatearTexto(textRazonSocial.Text);
                    //agregamos los datos a la tabla
                    dataGridProveedor.Rows.Add(nombre, textDNI.Text, textEmail.Text, textTelefono.Text, comboBoxEstado.Text);
                    MessageBox.Show("Proveedor " + nombre + " agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                    textRazonSocial.Focus(); // Establece el foco en el TextBox de Razon Social
                }
            }
            else
            {
                MessageBox.Show("Faltan completar campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridProveedor.SelectedRows.Count > 0)
            {
                // Preguntamos si esta seguro de eliminar 
                DialogResult ask = MessageBox.Show("¿Seguro que desea eliminar el registro seleccionado?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                // Si dice que Si
                if (ask == DialogResult.Yes)
                {
                    // Verificamos que no intente borrar la ultima fila en blanco (la que usa el DataGridView para agregar nuevos datos a mano)
                    if (!dataGridProveedor.SelectedRows[0].IsNewRow)
                    {
                        // Borramos la fila usando el indice de la que esta seleccionada
                        dataGridProveedor.Rows.RemoveAt(dataGridProveedor.SelectedRows[0].Index);

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridProveedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor para editar.", "Sin selección",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            filaEditar = dataGridProveedor.SelectedRows[0].Index; //guarda el indice de la fila seleccionada
            if (dataGridProveedor.Rows[filaEditar].IsNewRow)
            {
                MessageBox.Show("No se puede editar una fila vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filaEditar = -1; // Reinicia el índice de la fila a editar
                return;
            }
            DataGridViewRow fila = dataGridProveedor.Rows[filaEditar]; // Obtiene la fila seleccionada

            //se pasa los datos de la tabla a los campos de texto para poder editarlos
            textRazonSocial.Text = fila.Cells[0].Value?.ToString();
            textDNI.Text = fila.Cells[1].Value?.ToString();
            textEmail.Text = fila.Cells[2].Value?.ToString();
            textTelefono.Text = fila.Cells[3].Value?.ToString();
            comboBoxEstado.Text = fila.Cells[4].Value?.ToString();
            
            MessageBox.Show("Edite los campos y haga clic en 'Actualizar' para guardar los cambios.", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnAgregar.Enabled = false; // Deshabilita el botón Agregar mientras se edita
            iconBtnActualizar.Enabled = true; // Habilita el botón Actualizar
            iconBtnCancelar.Enabled = true; // Habilita el botón Cancelar
        }

        private void iconBtnActualizar_Click(object sender, EventArgs e)
        {
            if (filaEditar == -1)
            {
                MessageBox.Show("No hay ningún proveedor seleccionado para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidarCamposVacios())
            {
                DialogResult askEdit = MessageBox.Show("¿Desea guardar los cambios del proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (askEdit == DialogResult.Yes)
                {
                    // Actualizar la fila seleccionada
                    dataGridProveedor.Rows[filaEditar].Cells[0].Value = formatearTexto(textRazonSocial.Text);
                    dataGridProveedor.Rows[filaEditar].Cells[1].Value = textDNI.Text;
                    dataGridProveedor.Rows[filaEditar].Cells[2].Value = textEmail.Text;
                    dataGridProveedor.Rows[filaEditar].Cells[3].Value = textTelefono.Text;
                    dataGridProveedor.Rows[filaEditar].Cells[4].Value = comboBoxEstado.Text;

                    MessageBox.Show("Proveedor actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarFormulario();
                }
            }
            else
            {
                MessageBox.Show("Faltan completar campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
