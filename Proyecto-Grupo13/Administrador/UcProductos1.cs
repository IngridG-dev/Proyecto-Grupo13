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
            // Permite letras, números, espacios, caracteres de control y signos de puntuación/símbolos
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsPunctuation(e.KeyChar) &&
                !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
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
            // Permite letras, números, espacios, caracteres de control y signos de puntuación/símbolos
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsPunctuation(e.KeyChar) &&
                !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true; // Evita que el carácter se ingrese en el TextBox
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
                textNombre.ForeColor = Color.Black;
                esValido = false;
            }
            else
            {
                textNombre.BackColor = colorNormal;
                textNombre.ForeColor = Color.White;
            }

            // =========================
            // CODIGO
            // =========================
            if (string.IsNullOrWhiteSpace(textCodigo.Text))
            {
                textCodigo.BackColor = Color.LightPink;
                textCodigo.ForeColor = Color.Black;
                esValido = false;
            }
            else
            {
                textCodigo.BackColor = colorNormal;
                textCodigo.ForeColor = Color.White;
            }

            // =========================
            // DESCRIPCION
            // =========================
            if (string.IsNullOrWhiteSpace(textDescripcion.Text))
            {
                textDescripcion.BackColor = Color.LightPink;
                textDescripcion.ForeColor = Color.Black;
                esValido = false;
            }
            else
            {
                textDescripcion.BackColor = colorNormal;
                textDescripcion.ForeColor = Color.White;
            }

            // =========================
            // STOCK
            // =========================
            if (string.IsNullOrWhiteSpace(textStock.Text))
            {
                textStock.BackColor = Color.LightPink;
                textStock.ForeColor = Color.Black;
                esValido = false;
            }
            else
            {
                textStock.BackColor = colorNormal;
                textStock.ForeColor = Color.White;
            }
            // =========================
            // CATEGORIA
            // =========================
            if (comboBoxCategoria.SelectedIndex == -1)
            {
                comboBoxCategoria.BackColor = Color.LightPink;
                comboBoxCategoria.ForeColor = Color.Black;
                esValido = false;
            }
            else
            {
                comboBoxCategoria.BackColor = colorNormal;
                comboBoxCategoria.ForeColor = Color.White;
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
        //METODO PARA VALIDAR QUE EL CODIGO SEA UNICO EN EL DATAGRIDVIEW
        private bool ValidarCodigoUnico()
        {
            if (string.IsNullOrWhiteSpace(textCodigo.Text))
                return true;

            string codigoIngresado = textCodigo.Text.Trim();

            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                if (fila.IsNewRow) continue; // Ignorar la fila vacía del final

                // Si estamos editando, ignoramos la fila actual para que no se detecte a sí misma como duplicada
                if (filaEditar != -1 && fila.Index == filaEditar) continue;

                // Suponiendo que el Código está en la columna 1 (ajusta el índice si es otra columna)
                string codigoFila = fila.Cells[1].Value?.ToString();

                if (codigoIngresado.Equals(codigoFila, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Este Código ya está registrado en la lista.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    textCodigo.BackColor = Color.LightPink;
                    textCodigo.Focus();

                    return false;
                }
            }
            textCodigo.BackColor = Color.FromArgb(70, 75, 85);
            return true;
        }

        //BOTONES PARA AGREGAR, ELIMINAR Y EDITAR PRODUCTOS
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validamos campos vacíos
            if (!ValidarCamposVacios())
            {
                MessageBox.Show("Faltan completar campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validamos que el código no exista en el DataGridView
            if (!ValidarCodigoUnico()) return;

            DialogResult ask = MessageBox.Show("¿Desea agregar este nuevo producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                string nombre = formatearTexto(textNombre.Text);

                // Agregamos la fila (Asegúrate de que el orden coincida con tus columnas)
                dataGridView2.Rows.Add(
                    nombre,
                    textCodigo.Text,
                    textDescripcion.Text,
                    comboBoxCategoria.Text,
                    textStock.Text
                );

                MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
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
                MessageBox.Show("Por favor, seleccione un producto para editar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            filaEditar = dataGridView2.SelectedRows[0].Index;

            if (dataGridView2.Rows[filaEditar].IsNewRow)
            {
                MessageBox.Show("No se puede editar una fila vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filaEditar = -1;
                return;
            }

            DataGridViewRow fila = dataGridView2.Rows[filaEditar];

            // Pasamos los datos de las celdas a los controles
            textNombre.Text = fila.Cells[0].Value?.ToString();
            textCodigo.Text = fila.Cells[1].Value?.ToString();
            textDescripcion.Text = fila.Cells[2].Value?.ToString();
            comboBoxCategoria.Text = fila.Cells[3].Value?.ToString();
            textStock.Text = fila.Cells[4].Value?.ToString();

            // Mostramos los botones de actualizar y cancelar
            iconBtnActualizar.Visible = true;
            iconBtnCancelar.Visible = true;

            MessageBox.Show("Edite los campos y haga clic en 'Actualizar' para guardar los cambios.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void labelProductos_Click(object sender, EventArgs e)
        {

        }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void iconBtnActualizar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposVacios())
            {
                MessageBox.Show("Faltan completar campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validamos que el código no exista (ignorando la fila que estamos editando)
            if (!ValidarCodigoUnico()) return;

            if (filaEditar != -1)
            {
                DialogResult askEdit = MessageBox.Show("¿Desea guardar los cambios del producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (askEdit == DialogResult.Yes)
                {
                    // Actualizamos la fila directamente en el DataGridView
                    dataGridView2.Rows[filaEditar].Cells[0].Value = formatearTexto(textNombre.Text);
                    dataGridView2.Rows[filaEditar].Cells[1].Value = textCodigo.Text;
                    dataGridView2.Rows[filaEditar].Cells[2].Value = textDescripcion.Text;
                    dataGridView2.Rows[filaEditar].Cells[3].Value = comboBoxCategoria.Text;
                    dataGridView2.Rows[filaEditar].Cells[4].Value = textStock.Text;

                    MessageBox.Show("Producto editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
            }
        }
        private void LimpiarCampos()
        {
            textNombre.Clear();
            textCodigo.Clear();
            textDescripcion.Clear();
            textStock.Clear();
            comboBoxCategoria.SelectedIndex = -1;

            filaEditar = -1; // Reiniciamos la variable de edición

            // Restauramos los botones a su estado normal 
            iconBtnActualizar.Visible = false;
            iconBtnCancelar.Visible = false;
        }

        private void textCodigo_Leave(object sender, EventArgs e)
        {
            ValidarCodigoUnico();
        }
    }
}
