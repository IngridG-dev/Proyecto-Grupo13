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
    public partial class FormBuscarProductos : Form
    {
        public FormBuscarProductos()
        {
            InitializeComponent();
        }

        public Producto productoSeleccionado { get; set; }
        public int idProveedorFiltro { get; set; } = 0; // Propiedad para almacenar el ID del proveedor seleccionado
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                int index = dgvProductos.SelectedRows[0].Index;

                productoSeleccionado = new Producto()
                {
                    // Asume que la columna 0 está oculta y tiene el ID
                    id_producto = Convert.ToInt32(dgvProductos.Rows[index].Cells[0].Value),
                    codigo = dgvProductos.Rows[index].Cells[1].Value.ToString(),
                    nombreProducto = dgvProductos.Rows[index].Cells[2].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la lista.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); // Cerramos esta ventanita
        }

        private void FormBuscarProductos_Load(object sender, EventArgs e)
        {
            // Cargar los productos en el DataGridView al cargar el formulario
            dgvProductos.Rows.Clear();
            List<Producto> lista = new CL_Producto().Listar();

            foreach (Producto item in lista)
            {
                if (item.proveedor.id_proveedor == idProveedorFiltro) // Filtra por el ID del proveedor
                    dgvProductos.Rows.Add(item.id_producto, item.codigo, item.nombreProducto, item.categoria.descripcion);
            }

            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                if (columna.Visible == true)
                {
                    comboBoxBuscar.Items.Add(columna.HeaderText);
                }
            }

            if (comboBoxBuscar.Items.Count > 0)
            {
                comboBoxBuscar.SelectedIndex = 0; 
            }
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxBuscar.SelectedItem == null) return;

            string columnaFiltro = comboBoxBuscar.SelectedItem.ToString();
            string textoBusqueda = textBuscar.Text.Trim().ToUpper();

            // Recorrer cada fila del DataGridView dgvProductos
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (!row.IsNewRow)
                {
                    // Busca la celda específica de la columna seleccionada
                    var celda = row.Cells.Cast<DataGridViewCell>().FirstOrDefault(c => c.OwningColumn.HeaderText == columnaFiltro);

                    if (celda != null && celda.Value != null)
                    {
                        // Verifica si el texto de la celda contiene lo que se escribió en el TextBox
                        string valorCelda = celda.Value.ToString().ToUpper();
                        row.Visible = valorCelda.Contains(textoBusqueda);
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void iconBtnLimpiar_Click(object sender, EventArgs e)
        {
            textBuscar.Clear();

            // Mostrar todas las filas nuevamente
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Visible = true;
                }
            }

            textBuscar.Focus(); // Coloca el foco en el TextBox para que el usuario pueda escribir de inmediato
        }
    }
}
