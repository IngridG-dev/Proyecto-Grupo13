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

namespace Proyecto_Grupo13.Administrador
{
    public partial class FormProveedor : Form
    {
        public FormProveedor()
        {
            InitializeComponent();
        }

        public Proveedor proveedorSeleccionado { get; set; }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(dgvProveedores.SelectedRows.Count > 0)
            {
                int index = dgvProveedores.SelectedRows[0].Index;

                proveedorSeleccionado = new Proveedor()
                {
                    // Asume que la columna 0 está oculta y tiene el ID
                    id_proveedor = Convert.ToInt32(dgvProveedores.Rows[index].Cells[0].Value),
                    documento = Convert.ToInt64(dgvProveedores.Rows[index].Cells[1].Value),
                    razonSocial = dgvProveedores.Rows[index].Cells[2].Value.ToString(),
                    email = dgvProveedores.Rows[index].Cells[3].Value.ToString()
                };

                this.DialogResult = DialogResult.OK;
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Seleccione un proveedor de la lista.");
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); // Cerramos esta ventanita

        }

        private void FormProveedor_Load(object sender, EventArgs e)
        {
            // Cargar los proveedores en el DataGridView
            dgvProveedores.Rows.Clear();
            List<Proveedor> lista = new CL_Proveedor().ListarProveedores();

            // Agregar los proveedores al DataGridView
            foreach (Proveedor item in lista)
            {
                dgvProveedores.Rows.Add(item.id_proveedor, item.documento, item.razonSocial, item.email);
            }

            // Llenar el ComboBox con los nombres de las columnas visibles del DataGridView
            foreach (DataGridViewColumn column in dgvProveedores.Columns)
            {
                if (column.Visible == true)
                {
                    comboBoxBuscar.Items.Add(column.HeaderText);
                }
            }

            // Seleccionar el primer elemento del ComboBox por defecto
            if (comboBoxBuscar.Items.Count > 0)
            {
                comboBoxBuscar.SelectedIndex = 0; // Selecciona el primer elemento por defecto
            }
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxBuscar.SelectedItem == null) return;

            string columnaFiltro = comboBoxBuscar.SelectedItem.ToString();
            string textoBusqueda = textBuscar.Text.Trim().ToUpper();

            // Recorrer cada fila del DataGridView dgvProveedores
            foreach (DataGridViewRow row in dgvProveedores.Rows)
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

            // Vuelve a mostrar todas las filas de los proveedores
            foreach (DataGridViewRow row in dgvProveedores.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Visible = true;
                }
            }

            textBuscar.Focus();
        }
    }
}
