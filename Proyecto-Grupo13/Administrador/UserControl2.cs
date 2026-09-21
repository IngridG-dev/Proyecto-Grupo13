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
using System.Xml.Serialization;

namespace Proyecto_Grupo13.Administrador
{
    public partial class UserControl2 : UserControl
    {
        private CL_Usuario objCL_Usuario = new CL_Usuario();
        private int filaEditar = -1; // Variable para almacenar la fila que se está editando
        public UserControl2()
        {
            InitializeComponent();

            CargarRoles();
            CargarEstados();
            CargarUsuarios();
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
        // LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            textNombre.Clear();
            textDNI.Clear();
            textEmail.Clear();
            textTelefono.Clear();
            textDireccion.Clear();
            comboBoxRol.SelectedIndex = -1;
            comboBoxEstado.SelectedIndex = -1;
            textContraseña.Clear(); // limpiar el TextBox de Contraseña
            textContraseña.Visible = false; // Ocultar el TextBox de Contraseña
        }

        // BOTON AGREGAR

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Primero validamos los campos
            if (!ValidarCamposVacios())
            {
                MessageBox.Show(
                    "Faltan completar campos.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }
            if(!ValidarDNIUnico()) //validar que el DNI sea único
            {
                return;
            }

            // EDITAR USUARIO

            if (filaEditar != -1)
            {
                DialogResult askEdit = MessageBox.Show(
                    "¿Desea guardar los cambios del usuario?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (askEdit != DialogResult.Yes)
                {
                    filaEditar = -1;
                    return;
                }


                Rol rolSeleccionado = (Rol)comboBoxRol.SelectedItem;


                Usuario usuario = new Usuario()
                {
                    // Recuperamos el ID guardado en Tag
                    id_usuario = Convert.ToInt32(
                        dataGridView1.Rows[filaEditar].Tag
                    ),

                    nombreCompleto =
                        formatearTexto(textNombre.Text),

                    dni =
                        Convert.ToInt32(textDNI.Text),

                    email =
                        textEmail.Text.Trim(),

                    telefono =
                        textTelefono.Text.Trim(),

                    direccion =
                        textDireccion.Text.Trim(),

                    contraseña =
                        textContraseña.Text,

                    estado =
                        comboBoxEstado.Text == "Activo" ? 1 : 0,

                    rol =
                        rolSeleccionado
                };


                string mensaje;

                bool respuesta =
                    objCL_Usuario.EditarUsuario(
                        usuario,
                        out mensaje
                    );


                if (respuesta)
                {
                    MessageBox.Show(
                        "Usuario editado exitosamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    CargarUsuarios();
                    LimpiarCampos();

                    filaEditar = -1;
                }
                else
                {
                    MessageBox.Show(
                        mensaje != ""
                            ? mensaje
                            : "No se pudo editar el usuario.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }

                return;
            }


            // REGISTRAR NUEVO USUARIO

            DialogResult ask = MessageBox.Show(
                "¿Seguro que desea insertar este nuevo usuario?",
                "Confirmar inserción",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1
            );


            if (ask != DialogResult.Yes)
                return;


            Rol rol = (Rol)comboBoxRol.SelectedItem;


            Usuario nuevoUsuario = new Usuario()
            {
                nombreCompleto =
                    formatearTexto(textNombre.Text),

                dni =
                    Convert.ToInt32(textDNI.Text),

                email =
                    textEmail.Text.Trim(),

                telefono =
                    textTelefono.Text.Trim(),

                direccion =
                    textDireccion.Text.Trim(),

                contraseña =
                    textContraseña.Text,

                estado =
                    comboBoxEstado.Text == "Activo" ? 1 : 0,

                rol =
                    rol
            };


            string Mensaje;

            int idUsuarioGenerado =
                objCL_Usuario.RegistrarUsuario(
                    nuevoUsuario,
                    out Mensaje
                );


            if (idUsuarioGenerado != 0)
            {
                MessageBox.Show(
                    "El usuario " +
                    nuevoUsuario.nombreCompleto +
                    " se insertó correctamente.",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Volvemos a consultar la BD
                CargarUsuarios();

                // Limpiamos los campos
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(
                    Mensaje != ""
                        ? Mensaje
                        : "No se pudo registrar el usuario.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // BOTON ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Por favor, seleccione un usuario para eliminar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            DataGridViewRow fila =
                dataGridView1.SelectedRows[0];


            if (fila.IsNewRow)
            {
                MessageBox.Show(
                    "No se puede eliminar una fila vacía.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }


            DialogResult ask = MessageBox.Show(
                "¿Seguro que desea eliminar el usuario seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            );


            if (ask != DialogResult.Yes)
                return;


            // Recuperamos el ID real de SQL Server
            int idUsuario =
                Convert.ToInt32(fila.Tag);


            bool respuesta =
                objCL_Usuario.EliminarUsuario(idUsuario);


            if (respuesta)
            {
                MessageBox.Show(
                    "El usuario se eliminó correctamente.",
                    "Eliminado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarUsuarios();
                LimpiarCampos();

                filaEditar = -1;
            }
            else
            {
                MessageBox.Show(
                    "No se pudo eliminar el usuario.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // BOTON EDITAR
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un usuario para editar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            filaEditar = dataGridView1.SelectedRows[0].Index;

            if (dataGridView1.Rows[filaEditar].IsNewRow)
            {
                MessageBox.Show("No se puede editar una fila vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                filaEditar = -1;
                return;
            }

            DataGridViewRow fila = dataGridView1.Rows[filaEditar];

            textNombre.Text = fila.Cells[0].Value?.ToString();
            textDNI.Text = fila.Cells[1].Value?.ToString();
            textEmail.Text = fila.Cells[2].Value?.ToString();
            textTelefono.Text = fila.Cells[3].Value?.ToString();
            textDireccion.Text = fila.Cells[4].Value?.ToString();

            // Seleccionar el objeto Rol correcto dentro del ComboBox
            string descripcionRol = fila.Cells[5].Value?.ToString();
            foreach (Rol item in comboBoxRol.Items)
            {
                if (item.descripcion == descripcionRol)
                {
                    comboBoxRol.SelectedItem = item;
                    break;
                }
            }

            comboBoxEstado.Text = fila.Cells[6].Value?.ToString();
            textContraseña.Clear();

            MessageBox.Show("Edite los campos y haga clic en 'Agregar' para guardar los cambios.", "Editar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Configuramos el label y el texbox de contraseña
        //para que sean visibles si se selecciona el rol admi, gerente o vendedor
        //Se oculta si el usuario es Cliente
        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rolSeleccionado = comboBoxRol.Text;
            if (rolSeleccionado == "ADMINISTRADOR" || rolSeleccionado == "GERENTE" || rolSeleccionado == "VENDEDOR")
            {
                textContraseña.Visible = true; // Activar el TextBox de Contraseña
                lContraseña.Visible = true; // Activar el Label de Contraseña
            }
            else
            {
                lContraseña.Visible = false; // Desactivar el Label de Contraseña
                textContraseña.Visible = false; // Desactivar el TextBox de Contraseña
                textContraseña.Clear(); // Limpiar el TextBox de Contraseña
            }
        }


        //CARGAR USUARIOS DESDE LA BASE DE DATOS
        private void CargarUsuarios()
        {
            dataGridView1.Rows.Clear();

            List<Usuario> lista = objCL_Usuario.ListarUsuarios();

            foreach (Usuario item in lista)
            {
                int indice = dataGridView1.Rows.Add(
                    item.nombreCompleto,
                    item.dni,
                    item.email,
                    item.telefono,
                    item.direccion,
                    item.rol.descripcion,
                    item.estado == 1 ? "Activo" : "Inactivo"
                );

                // Guardamos el ID de SQL Server en el Tag de la fila
                dataGridView1.Rows[indice].Tag = item.id_usuario;
            }
        }

        //CARGAR ROLES
        private void CargarRoles()
        {
            comboBoxRol.Items.Clear();

            // Consultamos los roles reales guardados en SQL Server
            List<Rol> listaRoles = new CL_Rol().Listar();

            foreach (Rol item in listaRoles)
            {
                comboBoxRol.Items.Add(item);
            }

            comboBoxRol.DisplayMember = "descripcion";
            comboBoxRol.ValueMember = "id_rol";
            comboBoxRol.SelectedIndex = -1;
        }

        //CARGAR ESTADOS
        private void CargarEstados()
        {
            comboBoxEstado.Items.Clear();

            comboBoxEstado.Items.Add("Activo");
            comboBoxEstado.Items.Add("Inactivo");

            comboBoxEstado.SelectedIndex = -1;
        }
        private void btnBuscar_Click(object sender, EventArgs e) { }
        private void textNombre_TextChanged(object sender, EventArgs e) { }
        private void textDireccion_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        // VALIDAR DNI ÚNICO
        private bool ValidarDNIUnico()
        {
            if (string.IsNullOrWhiteSpace(textDNI.Text))
                return true;

            if (!int.TryParse(textDNI.Text, out int dni))
                return false;

            int idUsuario = 0;

            // Si estamos editando, obtenemos el ID del usuario actual
            if (filaEditar != -1)
            {
                idUsuario = Convert.ToInt32(
                    dataGridView1.Rows[filaEditar].Tag
                );
            }

            bool existe = objCL_Usuario.ExisteDNI(dni, idUsuario);

            if (existe)
            {
                MessageBox.Show(
                    "Este DNI ya está registrado.",
                    "DNI duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textDNI.BackColor = Color.LightPink;
                textDNI.Focus();

                return false;
            }

            textDNI.BackColor = Color.FromArgb(70, 75, 85);

            return true;
        }

        private void textDNI_Leave(object sender, EventArgs e)
        {
            ValidarDNIUnico();
        }
    }
}
