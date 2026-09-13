using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Grupo13.Vendedor
{
    public partial class ucClientes : UserControl
    {
        private int filaEditar = -1; // Variable para almacenar la fila que se está editando
        public ucClientes()
        {
            InitializeComponent();
        }

        //VALIDACIONES DE LOS CAMPOS DE TEXTO 
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y espacios en el campo de nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en el campo de DNI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras, números, '@', '.' y espacios en el campo de correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en el campo de teléfono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras, números y espacios en el campo de dirección.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Validar que los campos no estén vacíos
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

            return esValido;
        }
        // Formatear el texto ingresado en el campo de nombre
        private string formatearTexto(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return "";
            // Primera letra mayúscula, el resto minúscula
            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }

        //CONFIGURACIÓN DEL BOTÓN AGREGAR Y EDITAR CLIENTE
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios() == true)
            {
                if (filaEditar != -1)
                {
                    // Editar la fila existente
                    GridClientes.Rows[filaEditar].Cells[0].Value = textNombre.Text;
                    GridClientes.Rows[filaEditar].Cells[1].Value = textDNI.Text;
                    GridClientes.Rows[filaEditar].Cells[2].Value = textEmail.Text;
                    GridClientes.Rows[filaEditar].Cells[3].Value = textTelefono.Text;
                    GridClientes.Rows[filaEditar].Cells[4].Value = textDireccion.Text;

                    MessageBox.Show("Cliente editado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos
                    textNombre.Clear();
                    textDNI.Clear();
                    textEmail.Clear();
                    textTelefono.Clear();
                    textDireccion.Clear();

                    // Restaurar color
                    Color colorNormal = Color.FromArgb(70, 75, 85);
                    textNombre.BackColor = colorNormal;
                    textDNI.BackColor = colorNormal;
                    textEmail.BackColor = colorNormal;
                    textTelefono.BackColor = colorNormal;
                    textDireccion.BackColor = colorNormal;

                    filaEditar = -1;
                }
                else
                {
                    // Agregar nuevo cliente
                    DialogResult ask = MessageBox.Show(
                        "¿Seguro que desea insertar este nuevo cliente?","Confirmar inserción",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (ask == DialogResult.Yes)
                    {
                        string nombre = formatearTexto(textNombre.Text);

                        GridClientes.Rows.Add(
                            nombre,
                            textDNI.Text,
                            textEmail.Text,
                            textTelefono.Text,
                            textDireccion.Text
                        );

                        MessageBox.Show("El cliente " + nombre + " se insertó correctamente en la tabla.","Guardar",MessageBoxButtons.OK,MessageBoxIcon.Information);

                        // Limpiar campos
                        textNombre.Clear();
                        textDNI.Clear();
                        textDireccion.Clear();
                        textEmail.Clear();
                        textTelefono.Clear();
                        textNombre.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Faltan completar campos.","Atención",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (GridClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.", "Sin selección",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Verifica si la fila seleccionada es una fila nueva (vacía)
            filaEditar = GridClientes.SelectedRows[0].Index; //guarda el indice de la fila seleccionada
            if (GridClientes.Rows[filaEditar].IsNewRow)
            {
                // Muestra un mensaje de error si se intenta editar una fila vacía
                MessageBox.Show("No se puede editar una fila vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filaEditar = -1; // Reinicia el índice de la fila a editar
                return;
            }
            DataGridViewRow fila = GridClientes.Rows[filaEditar]; // Obtiene la fila seleccionada

            //se pasa los datos de la tabla a los campos de texto para poder editarlos
            textNombre.Text = fila.Cells[0].Value?.ToString();
            textDNI.Text = fila.Cells[1].Value?.ToString();
            textEmail.Text = fila.Cells[2].Value?.ToString();
            textTelefono.Text = fila.Cells[3].Value?.ToString();
            textDireccion.Text = fila.Cells[4].Value?.ToString();

            MessageBox.Show("Edite los campos y haga clic en 'Agregar' para guardar los cambios.", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}