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
        {
            // Configurar el DataGridView para no generar columnas automáticamente
            dgvClientes.AutoGenerateColumns = false;

            // Asociar tus columnas manuales con los nombres exactos de las propiedades de la clase Cliente
            dgvClientes.Columns[0].DataPropertyName = "dni";
            dgvClientes.Columns[1].DataPropertyName = "nombreCompleto";

            // Asignar la lista al DataGridView
            List<Cliente> lista = objCL_Cliente.ListarClientes();
            dgvClientes.DataSource = lista;
        }
        private void dgvClientes_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {

            // Validar que se haya hecho clic en una fila válida (no en los encabezados)
            if (e.RowIndex >= 0)
            {
                // Obtenemos directamente el objeto Cliente enlazado a la fila
                ClienteSeleccionado = (Cliente)dgvClientes.Rows[e.RowIndex].DataBoundItem;

                this.DialogResult = DialogResult.OK; // Indica que se seleccionó con éxito
                this.Close(); // Cierra el formulario
            }
        }
    }
}