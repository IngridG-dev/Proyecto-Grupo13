using Proyecto_Grupo13.Administrador;
using Proyecto_Grupo13.Gerente;
using Proyecto_Grupo13.Vendedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace Proyecto_Grupo13
{
    public partial class Inicio : Form
    {
        private CL_Usuario objCL_Usuario = new CL_Usuario();
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el menú activo y hace que vuelva automáticamente a Inicio
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validar si faltan completar datos (DNI o Contraseña vacíos)
            if (string.IsNullOrWhiteSpace(textNumeroDocum.Text) || string.IsNullOrWhiteSpace(textContraseña.Text))
            {
                MessageBox.Show(
                    "Falta completar los datos.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            int dni;

            //Verificar que el DNI sea un número válido
            if (!int.TryParse(textNumeroDocum.Text, out dni))
            {
                MessageBox.Show(
                    "Ingrese un DNI válido.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string contraseña = textContraseña.Text;

            //Buscar usuario
            Usuario usuario = objCL_Usuario.Login(dni, contraseña);

            // Si no existe o la contraseña/DNI son incorrectos
            if (usuario == null)
            {
                MessageBox.Show(
                    "Documento o contraseña incorrectos.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            //Verificar estado
            if (usuario.estado != 1)
            {
                MessageBox.Show(
                    "El usuario se encuentra inactivo.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Ocultar la pantalla de Login ANTES de abrir el menú
            this.Hide();

            // Abrir formulario según el rol usando ShowDialog()
            if (usuario.rol.descripcion == "ADMINISTRADOR")
            {
                menuAdministrador form = new menuAdministrador();
                form.ShowDialog(); // La ejecución se pausa aquí hasta que se cierre el menú
            }
            else if (usuario.rol.descripcion == "VENDEDOR")
            {
                menuVendedor form = new menuVendedor();
                form.ShowDialog();
            }
            else if (usuario.rol.descripcion == "GERENTE")
            {
                menuGerente form = new menuGerente();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show(
                    "El usuario no tiene un rol válido.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                this.Show(); // Volver a mostrar el login si no tiene un rol válido
                return;
            }

            //Al cerrar el menú (con la 'X' o con un botón "Cerrar Sesión"), el código continúa aquí:
            textNumeroDocum.Clear();
            textContraseña.Clear();

            //Se vuelve a mostrar el inicio y se enfoca el primer campo
            this.Show();
            textNumeroDocum.Focus();
        }
    }
}
