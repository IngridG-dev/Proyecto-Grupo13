using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proyecto_Grupo13.Administrador
{
    public partial class ucProveedor : UserControl
    {
        private CL_Proveedor objCL_Proveedor = new CL_Proveedor();
        private int filaEditar = -1; // Variable para almacenar la fila que se está editando
        public ucProveedor()
        {
            InitializeComponent();
            CargarEstados();
            CargarProveedores();
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
        private bool ValidarCamposVacios(out string mensajeError)
        {
            bool esValido = true;
            mensajeError = "";
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

            // DOCUMENTO
            if (string.IsNullOrWhiteSpace(textDocumento.Text))
            {
                textDocumento.BackColor = Color.LightPink;
                textDocumento.ForeColor = Color.Black;
                esValido = false;
            }
            else
            {
                textDocumento.BackColor = colorNormal;
                textDocumento.ForeColor = Color.White;
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


        // Metodo para cargar la grilla con los datos de la base de datos
        private void CargarProveedores()
        {
            dataGridProveedor.Rows.Clear(); // Limpiamos la grilla antes de cargar

            List<Proveedor> lista = objCL_Proveedor.ListarProveedores();

            foreach (Proveedor item in lista)
            {
                // Agregamos la fila a la grilla
                int indice = dataGridProveedor.Rows.Add(
                    item.id_proveedor,
                    item.razonSocial,
                    item.documento,
                    item.email,
                    item.telefono,
                    item.estado == 1 ? "Activo" : "Inactivo"
                );
                // Guardamos el objeto Proveedor en la propiedad Tag de la fila para poder acceder a él más tarde si es necesario
                dataGridProveedor.Rows[indice].Tag = item;
            }
        }

        // Metodo para cargar los estados en el ComboBox
        private void CargarEstados()
        {
            comboBoxEstado.Items.Clear();
            comboBoxEstado.Items.Add("Activo");
            comboBoxEstado.Items.Add("Inactivo");
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
            textDocumento.Clear();
            textEmail.Clear();
            textTelefono.Clear();
            comboBoxEstado.SelectedIndex = -1;

            filaEditar = -1; // Reiniciamos la variable

            // Habilitamos/Deshabilitamos botones para evitar errores
            btnAgregar.Enabled = true;
            iconBtnActualizar.Visible = false;
            iconBtnCancelar.Visible = false;

            // Limpiamos los colores de advertencia
            Color colorNormal = Color.FromArgb(70, 75, 85);
            textRazonSocial.BackColor = colorNormal;
            textDocumento.BackColor = colorNormal;
            textEmail.BackColor = colorNormal;
            textTelefono.BackColor = colorNormal;
            comboBoxEstado.BackColor = colorNormal;
        }

        // VALIDAR DNI ÚNICO
        private bool ValidarDNIUnico()
        {
            if (string.IsNullOrWhiteSpace(textDocumento.Text))
                return true;

            int idProveedor = 0;

            // Si estamos editando, obtenemos el ID del proveedor actual desde el Tag
            if (filaEditar != -1)
            {
                idProveedor = ((Proveedor)dataGridProveedor.Rows[filaEditar].Tag).id_proveedor;
            }

            // Llamamos a la validación de la capa lógica (asumiendo que ExisteDocumento recibe string o int según tu BD)
            bool existe = objCL_Proveedor.ExisteDocumento(Convert.ToInt64(textDocumento.Text.Trim()), idProveedor);

            if (existe)
            {
                MessageBox.Show("Este DNI/CUIT ya está registrado.", "Documento duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDocumento.BackColor = Color.LightPink;
                textDocumento.Focus();
                return false;
            }

            textDocumento.BackColor = Color.FromArgb(70, 75, 85);
            return true;
        }

        //BOTONES AGREGAR, ELIMINAR, EDITAR, ACTUALIZA, CANCELAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string mensajeError;
            if (!ValidarCamposVacios(out mensajeError))
            {
                MessageBox.Show(mensajeError, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarDNIUnico()) return;

            DialogResult ask = MessageBox.Show("¿Seguro que desea insertar este nuevo proveedor?", "Confirmar inserción", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (ask != DialogResult.Yes) return;

            Proveedor nuevoProveedor = new Proveedor()
            {
                razonSocial = formatearTexto(textRazonSocial.Text.Trim()),
                documento = Convert.ToInt64(textDocumento.Text.Trim()),
                email = textEmail.Text.Trim(),
                telefono = textTelefono.Text.Trim(),
                estado = comboBoxEstado.Text == "Activo" ? 1 : 0
            };

            string Mensaje;
            int idGenerado = objCL_Proveedor.RegistrarProveedor(nuevoProveedor, out Mensaje);

            if (idGenerado != 0)
            {
                MessageBox.Show("El proveedor " + nuevoProveedor.razonSocial + " se insertó correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProveedores();
                LimpiarFormulario();
            }
            else
            {
                MessageBox.Show(Mensaje != "" ? Mensaje : "No se pudo registrar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validamos que se haya seleccionado una fila en el DataGridView
            if (dataGridProveedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor para eliminar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtenemos la fila seleccionada
            DataGridViewRow fila = dataGridProveedor.SelectedRows[0];

            // Validamos que la fila seleccionada no sea una fila nueva (vacía)
            if (fila.IsNewRow)
            {
                MessageBox.Show("No se puede eliminar una fila vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmamos la eliminación con el usuario
            DialogResult ask = MessageBox.Show("¿Seguro que desea eliminar este proveedor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            // Si el usuario confirma la eliminación
            if (ask == DialogResult.Yes)
            {
                int idProveedor = ((Proveedor)fila.Tag).id_proveedor;

                bool respuesta = objCL_Proveedor.EliminarProveedor(idProveedor);

                if (respuesta)
                {
                    MessageBox.Show("Proveedor eliminado correctamente.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedores();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        // BOTON EDITAR: CARGA LOS DATOS DE LA FILA SELECCIONADA EN LOS CAMPOS DE TEXTO PARA PODER EDITARLOS
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridProveedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un proveedor para editar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            filaEditar = dataGridProveedor.SelectedRows[0].Index;

            if (dataGridProveedor.Rows[filaEditar].IsNewRow)
            {
                MessageBox.Show("No se puede editar una fila vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filaEditar = -1;
                return;
            }

            // Recuperamos el objeto directamente del Tag
            Proveedor proveedorSeleccionado = (Proveedor)dataGridProveedor.Rows[filaEditar].Tag;

            textRazonSocial.Text = proveedorSeleccionado.razonSocial;
            textDocumento.Text = proveedorSeleccionado.documento.ToString();
            textEmail.Text = proveedorSeleccionado.email;
            textTelefono.Text = proveedorSeleccionado.telefono;
            comboBoxEstado.Text = proveedorSeleccionado.estado == 1 ? "Activo" : "Inactivo";

            iconBtnActualizar.Visible = true;
            iconBtnCancelar.Visible = true;
            btnAgregar.Enabled = false;

            MessageBox.Show("Edite los campos y haga clic en 'Actualizar' para guardar los cambios.", "Editar Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iconBtnActualizar_Click(object sender, EventArgs e)
        {
            if (filaEditar == -1)
            {
                MessageBox.Show("No hay ningún proveedor seleccionado para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mensajeError;
            if (!ValidarCamposVacios(out mensajeError))
            {
                MessageBox.Show(mensajeError, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarDNIUnico()) return;

            DialogResult ask = MessageBox.Show("¿Seguro que desea actualizar este proveedor?", "Confirmar actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (ask != DialogResult.Yes) return;

                Proveedor proveedorEditado = new Proveedor()
                {
                    id_proveedor = ((Proveedor)dataGridProveedor.Rows[filaEditar].Tag).id_proveedor,
                    razonSocial = formatearTexto(textRazonSocial.Text.Trim()),
                    documento = Convert.ToInt64(textDocumento.Text.Trim()),
                    email = textEmail.Text.Trim(),
                    telefono = textTelefono.Text.Trim(),
                    estado = comboBoxEstado.Text == "Activo" ? 1 : 0
                };

                bool respuesta = objCL_Proveedor.EditarProveedor(proveedorEditado);

                if (respuesta)
                {
                    MessageBox.Show("Proveedor actualizado correctamente.", "Actualización exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedores();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el proveedor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void lDni_Click(object sender, EventArgs e)
        {

        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        // BOTON BUSCAR: FILTRA LA GRILLA SEGUN EL CRITERIO SELECCIONADO Y EL TEXTO INGRESADO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validamos que se haya seleccionado un criterio de búsqueda
            if (comboBoxBuscar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtenemos el criterio de búsqueda y el texto ingresado
            string columnaFiltro = comboBoxBuscar.SelectedItem.ToString();
            string textoBusqueda = textBuscar.Text.Trim().ToUpper();

            int indiceColumna = -1;

            // Determinamos el índice de la columna según el criterio seleccionado
            switch (columnaFiltro)
            {
                case "Razon Social":
                case "Razón Social":
                    indiceColumna = 1;
                    break;
                case "Documento":
                case "DNI":
                case "CUIT":
                    indiceColumna = 2;
                    break;
                case "Email":
                    indiceColumna = 3;
                    break;
                case "Teléfono":
                case "Telefono":
                    indiceColumna = 4;
                    break;
            }

            if (indiceColumna == -1) return;

            dataGridProveedor.CurrentCell = null; // Desmarcar cualquier celda seleccionada

            // Recorremos todas las filas del DataGridView y aplicamos el filtro
            foreach (DataGridViewRow fila in dataGridProveedor.Rows)
            {
                if (fila.IsNewRow) continue;
                string valorCelda = fila.Cells[indiceColumna].Value != null ? fila.Cells[indiceColumna].Value.ToString().ToUpper() : "";


                if (string.IsNullOrWhiteSpace(textoBusqueda) || valorCelda.Contains(textoBusqueda))
                {
                    fila.Visible = true;
                }
                else
                {
                    fila.Visible = false;
                }
            }
        }

        private void iconLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxBuscar.SelectedIndex = -1;
            textBuscar.Clear();
            // Mostramos todas las filas nuevamente
            dataGridProveedor.CurrentCell = null; // Desmarcar cualquier celda seleccionada
            CargarProveedores();
        }
    }
}
