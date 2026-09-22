using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        // Configuramos el evento load del UserControl para que al cargar la pantalla se muestren los clientes en la grilla
        private void verClientes_Load(object sender, EventArgs e)
        {
            // Traemos los datos y los asignamos a la grilla
            List<Cliente> listaCliente = new CL_Cliente().ListarClientes();
            dataGridClientes.DataSource = listaCliente;

            // Le cambiamos el título a las columnas para que se vean bien
            dataGridClientes.Columns["id_cliente"].HeaderText = "ID";
            dataGridClientes.Columns["nombreCompleto"].HeaderText = "Nombre Completo";
            dataGridClientes.Columns["dni"].HeaderText = "D.N.I.";
            dataGridClientes.Columns["email"].HeaderText = "Correo Electrónico";

            // Para que no se vea la columna del ID, ya que no es necesario mostrarla
            dataGridClientes.Columns["id_cliente"].Visible = false;

            // Hacemos que las columnas se ajusten automáticamente al tamaño de la pantalla
            dataGridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Configuramos el evento click del botón de eliminar para eliminar un cliente seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 1. Validamos que haya una fila seleccionada en el DataGridView
            if (dataGridClientes.SelectedRows.Count > 0)
            {
                // 2. Preguntamos si realmente desea eliminar
                DialogResult opcion = MessageBox.Show("¿Está seguro de eliminar este cliente?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (opcion == DialogResult.Yes)
                {
                    // 3. Obtenemos el ID de la fila seleccionada 
                    int idSeleccionado = Convert.ToInt32(dataGridClientes.SelectedRows[0].Cells["id_cliente"].Value);
                    string mensaje = string.Empty;

                    // 4. Llamamos a la Capa Lógica
                    bool respuesta = new CL_Cliente().EliminarCliente(idSeleccionado);

                    if (respuesta)
                    {
                        // Eliminamos el RemoveAt y en su lugar volvemos a cargar la lista
                        MessageBox.Show("Cliente eliminado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Recargamos los datos para que desaparezca el eliminado
                        dataGridClientes.DataSource = new CL_Cliente().ListarClientes();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Configuramos el evento click del botón de buscar para filtrar los clientes según el criterio seleccionado
        private void iconBuscar_Click(object sender, EventArgs e)
        {
            // 1. Verificamos que haya seleccionado un filtro en el ComboBox
            if (comboBoxBuscar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona un filtro en 'Buscar por:'.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filtro = comboBoxBuscar.Text; // Qué eligió: "nombreCompleto", "dni", etc.
            string textoBusqueda = textBuscar.Text.Trim().ToUpper(); // Lo que escribió el usuario

            // 2. Traemos la lista completa de nuevo usando nuestra Capa Lógica
            List<Cliente> listaCompleta = new CL_Cliente().ListarClientes();
            List<Cliente> listaFiltrada = new List<Cliente>();

            // 3. Revisamos cliente por cliente a ver cuál coincide
            foreach (Cliente c in listaCompleta)
            {
                if (filtro == "Nombre Completo" && c.nombreCompleto.ToUpper().Contains(textoBusqueda))
                {
                    listaFiltrada.Add(c);
                }
                else if (filtro == "DNI" && c.dni.ToString().ToUpper().Contains(textoBusqueda))
                {
                    listaFiltrada.Add(c);
                }
            }

            // 4. Actualizamos la grilla con los resultados encontrados
            dataGridClientes.DataSource = listaFiltrada;
        }
    }
}
