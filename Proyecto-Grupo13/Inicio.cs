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

        private void Form1_Load(object sender, EventArgs e){}
        private void label1_Click(object sender, EventArgs e){}

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Validar si faltan completar datos (DNI o Contraseña vacíos)
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

            // Verificar que el DNI sea un número válido
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

            // Buscar usuario
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

            // Verificar estado
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

            // Abrir formulario según el rol
            if (usuario.rol.descripcion == "ADMINISTRADOR")
            {
                menuAdministrador form = new menuAdministrador();
                form.Show();
            }
            else if (usuario.rol.descripcion == "VENDEDOR")
            {
                menuVendedor form = new menuVendedor();
                form.Show();
            }
            else if (usuario.rol.descripcion == "GERENTE")
            {
                menuGerente form = new menuGerente();
                form.Show();
            }
            else
            {
                MessageBox.Show(
                    "El usuario no tiene un rol válido.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Ocultar login
            this.Hide();
        }

    }
}
