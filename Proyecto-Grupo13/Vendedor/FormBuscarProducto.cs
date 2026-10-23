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

namespace Proyecto_Grupo13.Vendedor
{
    public partial class FormBuscarProducto : Form
    {
        private List<Producto> todosLosProductos = new List<Producto>(); // Lista para almacenar todos los productos
        public Producto productoSeleccionado { get; private set; } // Variable para almacenar el producto seleccionado
        public FormBuscarProducto()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            comboBoxBuscar.Items.Clear();
            comboBoxBuscar.Items.AddRange(new object[] { "Nombre", "Descripción", "Categoría" });
            comboBoxBuscar.SelectedIndex = 0;

            todosLosProductos = new CL_Producto().Listar();   // todos los productos de la base de datos
            MostrarProductos(todosLosProductos);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); // Cerramos esta ventanita
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            SeleccionarProducto();
        }
        private void MostrarProductos(List<Producto> lista)
        {
            dataGridView1.Rows.Clear();

            foreach (Producto item in lista)
            {
                int n = dataGridView1.Rows.Add(
                    item.codigo,
                    item.nombreProducto,
                    item.precioVenta.ToString("0.00"),
                    item.stock);

                dataGridView1.Rows[n].Tag = item;   // guardamos el producto completo en la fila
            }
        }

        private void AplicarFiltro()
        {
            string texto = textBuscar.Text.Trim().ToUpper();
            IEnumerable<Producto> filtrados = todosLosProductos;

            if (texto != "")
            {
                switch (comboBoxBuscar.Text)
                {
                    case "Descripción":
                        filtrados = todosLosProductos.Where(p => (p.descripcion ?? "").ToUpper().Contains(texto));
                        break;
                    case "Categoría":
                        filtrados = todosLosProductos.Where(p => p.categoria != null &&
                                                                 (p.categoria.descripcion ?? "").ToUpper().Contains(texto));
                        break;
                    default: // Nombre
                        filtrados = todosLosProductos.Where(p => (p.nombreProducto ?? "").ToUpper().Contains(texto));
                        break;
                }
            }

            MostrarProductos(filtrados.ToList());
        }

        private void SeleccionarProducto()
        {
            Producto p = dataGridView1.CurrentRow?.Tag as Producto;

            if (p == null)
            {
                MessageBox.Show("Seleccione un producto de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (p.stock <= 0)
            {
                MessageBox.Show("Este producto no tiene stock disponible.", "Sin stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            productoSeleccionado = p;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void iconBtnLimpiar_Click(object sender, EventArgs e)
        {
            textBuscar.Clear();
            comboBoxBuscar.SelectedIndex = 0;
            AplicarFiltro();
            textBuscar.Focus();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Aseguramos que no sea el encabezado
            {
                SeleccionarProducto();
            }
        }
    }
}
