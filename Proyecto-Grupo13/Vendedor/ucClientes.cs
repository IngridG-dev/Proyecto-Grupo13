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
using CapaEntidad;
using CapaLogica;

namespace Proyecto_Grupo13.Vendedor
{
    public partial class ucClientes : UserControl
    {
        private CL_Cliente objCL_Cliente = new CL_Cliente(); // Instancia de la clase CL_Cliente
        private int filaEditar = -1; // Variable para almacenar la fila que se está editando
        public ucClientes()
        {
            InitializeComponent();
            cargarClientes();
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
                textNombre.ForeColor = Color.Black;
                esValido = false;
            }
            else
            {
                textNombre.BackColor = colorNormal;
                textNombre.ForeColor = Color.White;
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
            // DIRECCIÓN
            if (string.IsNullOrWhiteSpace(textDireccion.Text))
            {
                textDireccion.BackColor = Color.LightPink;
                textDireccion.ForeColor = Color.Black;
                esValido = false;
            }
            else
            {
                textDireccion.BackColor = colorNormal;
                textDireccion.ForeColor = Color.White;
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

            // Valida que no haya vacíos
            if (!ValidarCamposVacios())
            {
                MessageBox.Show("Faltan completar campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Corta la ejecución aquí
            }

            // Validar que el DNI no exista en la BD
            if (!ValidarDNIUnico())
            {
                return; // El mensaje de error ya lo muestra el método ValidarDNIUnico
            }

            // Crea el objeto con la información de las cajas de texto
            Cliente objCliente = new Cliente()
            {
                nombreCompleto = formatearTexto(textNombre.Text),
                dni = Convert.ToInt32(textDNI.Text),
                email = textEmail.Text,
                telefono = textTelefono.Text,
                direccion = textDireccion.Text
            };

            // Evalua si se está editando o creando un cliente nuevo
            if (filaEditar != -1) // MODO EDITAR
            {
                // Obtenemos el ID guardado en el Tag
                objCliente.id_cliente = Convert.ToInt32(GridClientes.Rows[filaEditar].Tag);

                // Ejecutamos la consulta en la BD
                bool resultado = objCL_Cliente.EditarCliente(objCliente);

                if (resultado)
                {
                    // Si la BD se actualizó, actualizamos la tablita visual
                    GridClientes.Rows[filaEditar].Cells[0].Value = objCliente.nombreCompleto;
                    GridClientes.Rows[filaEditar].Cells[1].Value = objCliente.dni;
                    GridClientes.Rows[filaEditar].Cells[2].Value = objCliente.email;
                    GridClientes.Rows[filaEditar].Cells[3].Value = objCliente.telefono;
                    GridClientes.Rows[filaEditar].Cells[4].Value = objCliente.direccion;

                    MessageBox.Show("Cliente editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo editar el cliente en la Base de Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // MODO AGREGAR NUEVO
            {
                DialogResult ask = MessageBox.Show("¿Seguro que desea registrar este nuevo cliente?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (ask == DialogResult.Yes)
                {
                    // Ejecutamos la inserción en la BD
                    bool resultado = objCL_Cliente.RegistrarCliente(objCliente);

                    if (resultado)
                    {
                        // Si se registró exitosamente, recargamos toda la tabla para asegurarnos
                        // de que obtenemos el ID_CLIENTE autogenerado por SQL Server
                        cargarClientes();

                        MessageBox.Show("El cliente " + objCliente.nombreCompleto + " se registró correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el cliente en la Base de Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

     
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (GridClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente para editar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            filaEditar = GridClientes.SelectedRows[0].Index; // guarda el indice de la fila seleccionada

            // Verifica si la fila seleccionada es una fila nueva (vacía)
            if (GridClientes.Rows[filaEditar].IsNewRow)
            {
                MessageBox.Show("No se puede editar una fila vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filaEditar = -1; // Reinicia el índice
                return;
            }

            DataGridViewRow fila = GridClientes.Rows[filaEditar]; // Obtiene la fila seleccionada

            // Pasa los datos de la tabla a los campos de texto para poder editarlos
            textNombre.Text = fila.Cells[0].Value?.ToString();
            textDNI.Text = fila.Cells[1].Value?.ToString();
            textEmail.Text = fila.Cells[2].Value?.ToString();
            textTelefono.Text = fila.Cells[3].Value?.ToString();
            textDireccion.Text = fila.Cells[4].Value?.ToString();

            btnAgregar.Text = "Actualizar";

            MessageBox.Show("Edite los datos en los campos de texto y haga clic en 'ACTUALIZAR' para aplicar los cambios.", "Modo Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //CARGAR CLIENTES DE LA BASE DE DATOS
        private void cargarClientes()
        {
            GridClientes.Rows.Clear();

            var listaClientes = objCL_Cliente.ListarClientes();

            foreach (Cliente cliente in listaClientes)
            {
                int fila = GridClientes.Rows.Add(
                    cliente.nombreCompleto,
                    cliente.dni,
                    cliente.email,
                    cliente.telefono,
                    cliente.direccion
                );

                // Guarda el ID de la BD en el Tag de la fila para futuras referencias (editar, eliminar)
                GridClientes.Rows[fila].Tag = cliente.id_cliente;
            }
        }

        //VALIDAR DNI UNICO
        private bool ValidarDNIUnico()
        {
            if (string.IsNullOrWhiteSpace(textDNI.Text))
                return true;

            if (!int.TryParse(textDNI.Text, out int dni))
                return false;

            int idCliente = 0;

            // Si estamos editando, obtenemos el ID del cliente actual
            if (filaEditar != -1)
            {
                idCliente = Convert.ToInt32(GridClientes.Rows[filaEditar].Tag);
            }

            bool existe = objCL_Cliente.ExisteDNI(dni, idCliente);

            if (existe)
            {
                MessageBox.Show(
                    "Este DNI ya está registrado en el sistema.",
                    "DNI duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textDNI.BackColor = Color.LightPink;
                textDNI.Focus();

                return false;
            }

            // Retorna al color normal (ajusta el RGB si usas otro fondo)
            textDNI.BackColor = Color.FromArgb(70, 75, 85);

            return true;
        }

        // EVENTO LEAVE DEL TEXTBOX
        private void textDNI_Leave(object sender, EventArgs e)
        {
            ValidarDNIUnico();
        }
        // metodo auxiliar para limpiar los campos rapidamente, evita el codigo duplicado
        private void LimpiarCampos()
        {
            textNombre.Clear();
            textDNI.Clear();
            textEmail.Clear();
            textTelefono.Clear();
            textDireccion.Clear();

            Color colorNormal = Color.FromArgb(70, 75, 85);
            textNombre.BackColor = colorNormal;
            textDNI.BackColor = colorNormal;
            textEmail.BackColor = colorNormal;
            textTelefono.BackColor = colorNormal;
            textDireccion.BackColor = colorNormal;

            filaEditar = -1; // Reiniciamos el estado de edición

            // Cambiamos el texto del botón de nuevo a "Agregar"
            btnAgregar.Text = "Agregar";
            // Pone el foco en el campo de nombre para que el usuario pueda empezar a escribir directamente
            textNombre.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Validar que se haya seleccionado un criterio de búsqueda
            if (comboBoxBuscar.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Por favor, seleccione un criterio en 'Buscar por'.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            //Validar que el texto de búsqueda no esté vacío
            if (string.IsNullOrWhiteSpace(textBuscar.Text))
            {
                MessageBox.Show(
                    "Debes completar el campo de búsqueda.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                textBuscar.Focus(); // Pone el foco en el campo de texto para escribir directamente
                return;
            }

            string columnaFiltro = comboBoxBuscar.SelectedItem.ToString();
            string textoBusqueda = textBuscar.Text.Trim().ToUpper();

            //Mapear el nombre seleccionado al índice de la columna en la DataGridView
            int indiceColumna = -1;

            switch (columnaFiltro)
            {
                case "Nombre Completo":
                    indiceColumna = 0;
                    break;
                case "DNI":
                    indiceColumna = 1;
                    break;
                case "Email":
                    indiceColumna = 2;
                    break;
                case "Telefono":
                case "Teléfono":
                    indiceColumna = 3;
                    break;
                case "Direccion":
                case "Dirección":
                    indiceColumna = 4;
                    break;
            }

            if (indiceColumna == -1) return;

            // Ocultar o mostrar las filas según la coincidencia
            GridClientes.CurrentCell = null; // Quita la selección actual para evitar errores al ocultar filas

            foreach (DataGridViewRow fila in GridClientes.Rows)
            {
                if (fila.IsNewRow) continue;

                string valorCelda = fila.Cells[indiceColumna].Value != null
                    ? fila.Cells[indiceColumna].Value.ToString().ToUpper()
                    : "";

                // Si la casilla contiene el texto buscado (o si el buscador está vacío), se muestra la fila
                if (string.IsNullOrEmpty(textoBusqueda) || valorCelda.Contains(textoBusqueda))
                {
                    fila.Visible = true;
                }
                else
                {
                    fila.Visible = false;
                }
            }
        }
    }
}