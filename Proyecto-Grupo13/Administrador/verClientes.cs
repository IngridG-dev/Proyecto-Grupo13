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

namespace Proyecto_Grupo13.Administrador
{
    public partial class verClientes : UserControl
    {
        public verClientes()
        {
            InitializeComponent();
        }

        private void verClientes_Load(object sender, EventArgs e)
        {
            // 1. Traemos los datos y los asignamos a la grilla
            List<Cliente> listaCliente = new CL_Cliente().ListarClientes();
            dataGridClientes.DataSource = listaCliente;

            // 2. Le cambiamos el título a las columnas para que se vean bien
            dataGridClientes.Columns["id_cliente"].HeaderText = "ID";
            dataGridClientes.Columns["nombreCompleto"].HeaderText = "Nombre Completo";
            dataGridClientes.Columns["dni"].HeaderText = "D.N.I.";
            dataGridClientes.Columns["email"].HeaderText = "Correo Electrónico";

            // Opcional: Si quieres que el ID del cliente no se vea en la pantalla (porque al admin no le importa el número), lo ocultas así:
            dataGridClientes.Columns["id_cliente"].Visible = false;

            // 3. Hacemos que las columnas se ajusten automáticamente al tamaño de la pantalla
            dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
