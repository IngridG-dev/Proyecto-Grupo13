using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Grupo13.Vendedor
{
    public partial class FormBuscarCliente : Form
    {
        // Propiedad pública para retornar el cliente seleccionado
        public Cliente ClienteSeleccionado { get; private set; }

        private CL_Cliente objCL_Cliente = new CL_Cliente();

        public FormBuscarCliente()
        {
            InitializeComponent();
        }

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CargarClientes()
        {// Limpiamos cualquier DataSource previo y las filas
            dgvClientes.DataSource = null;
            dgvClientes.Rows.Clear();

            List<Cliente> lista = objCL_Cliente.ListarClientes();

            foreach (Cliente cliente in lista)
            {
                // Concatenamos el nombre y apellido solo para mostrarlo
                string nombreMostrar = cliente.nombre + " " + cliente.apellido;

                // Agregamos la fila manualmente (DNI, Nombre Completo)
                int indice = dgvClientes.Rows.Add(cliente.dni, nombreMostrar);

                // Guardamos el objeto cliente entero en el Tag de la fila
                dgvClientes.Rows[indice].Tag = cliente;
            }
        }
        private void dgvClientes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            // Validar que se haya hecho clic en una fila válida (no en los encabezados)
            if (e.RowIndex >= 0)
            {
                // Extraemos el objeto Cliente directamente desde el Tag de la fila
                ClienteSeleccionado = (Cliente)dgvClientes.Rows[e.RowIndex].Tag;

                this.DialogResult = DialogResult.OK; // Indica que se seleccionó con éxito
                this.Close(); // Cierra el formulario
            }
        }
    }
}