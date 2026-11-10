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
            comboBoxBuscar.SelectedIndex = -1;
            CargarClientes();
        }

        private void CargarClientes()
        {// Limpiamos cualquier DataSource previo y las filas
            dgvClientes.DataSource = null;
            dgvClientes.Rows.Clear();

            List<Cliente> lista = objCL_Cliente.ListarClientes();

            foreach (Cliente cliente in lista)
            {
                // conectamos el nombre y apellido solo para mostrarlo
                string nombreMostrar = cliente.nombre + " " + cliente.apellido;

                // agregamos la fila manualmente (DNI, Nombre Completo)
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

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxBuscar.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un criterio de búsqueda.", "Buscar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxBuscar.Focus();
                return;
            }
            string busqueda = textBuscar.Text.Trim();
            if (string.IsNullOrWhiteSpace(busqueda))
            {
                MessageBox.Show("Ingresa un DNI o nombre para buscar.", "Buscar cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBuscar.Focus();
                return;
            }
            List<Cliente> lista = objCL_Cliente.ListarClientes();
            dgvClientes.DataSource = null;
            dgvClientes.Rows.Clear();
            foreach (Cliente cliente in lista)
            {
                string dni = cliente.dni.ToString();
                string nombreCompleto = (cliente.nombre + " " + cliente.apellido).Trim();
                bool coincide = false;
                
                if (comboBoxBuscar.Text == "DNI")
                {
                    coincide = dni.Contains(busqueda);
                }
                else if (comboBoxBuscar.Text == "Nombre")
                {
                    coincide = nombreCompleto.IndexOf(busqueda, StringComparison.OrdinalIgnoreCase) >= 0;
                }

                if (coincide)
                {
                    int indice = dgvClientes.Rows.Add(cliente.dni, nombreCompleto);
                    dgvClientes.Rows[indice].Tag = cliente;
                }
            }
            if (dgvClientes.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron clientes que coincidan con la búsqueda.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void iconBtnLimpiar_Click(object sender, EventArgs e)
        {
            textBuscar.Clear();
            comboBoxBuscar.SelectedIndex = -1;
            CargarClientes();
            dgvClientes.ClearSelection(); // Limpiar la selección en el DataGridView
            dgvClientes.CurrentCell = null; // Asegurarse de que no haya una celda activa
            textBuscar.Focus(); // Establecer el foco en el TextBox de búsqueda
        }
    }
}