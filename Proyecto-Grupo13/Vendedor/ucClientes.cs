using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void textApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y espacios en el campo de apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // APELLIDO (NUEVO)
            if (string.IsNullOrWhiteSpace(textApellido.Text))
            {
                textApellido.BackColor = Color.LightPink;
                textApellido.ForeColor = Color.Black;
                esValido = false;
            }
            else
            {
                textApellido.BackColor = colorNormal;
                textApellido.ForeColor = Color.White;
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

            // 1.Valida que no haya vacíos
            if (!ValidarCamposVacios())
            {
                MessageBox.Show("Faltan completar campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que el DNI no exista en la BD
            if (!ValidarDNIUnico())
            {
                return;
            }

            // 3. Crea el objeto con la información de las cajas de texto
            Cliente objCliente = new Cliente()
            {
                nombre = formatearTexto(textNombre.Text),
                apellido = formatearTexto(textApellido.Text),
                dni = Convert.ToInt32(textDNI.Text),
                email = textEmail.Text,
                telefono = textTelefono.Text,
                direccion = textDireccion.Text
            };

            // 4. Inserción directa (Ya sin el if de filaEditar)
            DialogResult ask = MessageBox.Show("¿Seguro que desea registrar este nuevo cliente?", "Confirmar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ask == DialogResult.Yes)
            {
                bool resultado = objCL_Cliente.RegistrarCliente(objCliente);

                if (resultado)
                {
                    cargarClientes();
                    MessageBox.Show("El cliente " + objCliente.nombre + " " + objCliente.apellido + " se registró correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el cliente en la Base de Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            //Extraemos el objeto Cliente completo del Tag
            Cliente clienteSeleccionado = (Cliente)GridClientes.Rows[filaEditar].Tag;

            // Pasamos los datos exactos a los campos
            textNombre.Text = clienteSeleccionado.nombre;
            textApellido.Text = clienteSeleccionado.apellido;
            textDNI.Text = clienteSeleccionado.dni.ToString();
            textEmail.Text = clienteSeleccionado.email;
            textTelefono.Text = clienteSeleccionado.telefono;
            textDireccion.Text = clienteSeleccionado.direccion;

            btnActualizar.Visible = true;
            btnCancelar.Visible = true;
            btnAgregar.Enabled = false; // Deshabilita el botón de agregar mientras se edita

        }

        //CARGAR CLIENTES DE LA BASE DE DATOS
        private void cargarClientes()
        {
            GridClientes.Rows.Clear();
            var listaClientes = objCL_Cliente.ListarClientes();

            foreach (Cliente cliente in listaClientes)
            {
                // Concatenamos solo visualmente para la tabla
                string nombreMostrar = cliente.nombre + " " + cliente.apellido;

                int fila = GridClientes.Rows.Add(
                    nombreMostrar,
                    cliente.dni,
                    cliente.email,
                    cliente.telefono,
                    cliente.direccion
                );

                // Guardamos el objeto completo en la propiedad Tag de la fila para futuras referencias
                GridClientes.Rows[fila].Tag = cliente;
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
                idCliente = ((Cliente)GridClientes.Rows[filaEditar].Tag).id_cliente;
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
            textApellido.Clear();
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

            // Restauramos los botones a su estado normal
            btnActualizar.Visible = false;
            btnCancelar.Visible = false;
            btnAgregar.Enabled = true;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que no haya vacíos igual que al agregar
            if (!ValidarCamposVacios())
            {
                MessageBox.Show("Faltan completar campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validar que el DNI no exista (ValidarDNIUnico ya sabe manejar si es el mismo cliente editándose)
            if (!ValidarDNIUnico())
            {
                return;
            }

            // 3. Creamos el objeto AQUÍ adentro para que este botón lo reconozca
            Cliente objCliente = new Cliente()
            {
                nombre = formatearTexto(textNombre.Text),
                apellido = formatearTexto(textApellido.Text),
                dni = Convert.ToInt32(textDNI.Text),
                email = textEmail.Text,
                telefono = textTelefono.Text,
                direccion = textDireccion.Text
            };

            // 4. Modo Editar
            if (filaEditar != -1)
            {
                objCliente.id_cliente = ((Cliente)GridClientes.Rows[filaEditar].Tag).id_cliente;
                bool resultado = objCL_Cliente.EditarCliente(objCliente);

                if (resultado)
                {
                    GridClientes.Rows[filaEditar].Cells[0].Value = objCliente.nombre + " " + objCliente.apellido;
                    GridClientes.Rows[filaEditar].Cells[1].Value = objCliente.dni;
                    GridClientes.Rows[filaEditar].Cells[2].Value = objCliente.email;
                    GridClientes.Rows[filaEditar].Cells[3].Value = objCliente.telefono;
                    GridClientes.Rows[filaEditar].Cells[4].Value = objCliente.direccion;

                    MessageBox.Show("Cliente editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos(); // Esto va a ocultar los botones automáticamente
                }
                else
                {
                    MessageBox.Show("No se pudo editar el cliente en la Base de Datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}