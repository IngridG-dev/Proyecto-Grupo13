using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Grupo13.Administrador
{
    public partial class FormBuscarProductos : Form
    {
        // Productos del proveedor elegido (sobre esta lista se hace la búsqueda)
        private List<Producto> productosDelProveedor = new List<Producto>();

        public Producto productoSeleccionado { get; set; }
        public int idProveedorFiltro { get; set; } = 0; // ID del proveedor elegido en Registrar Compra

        public FormBuscarProductos()
        {
            InitializeComponent();

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Producto p = dgvProductos.CurrentRow?.Tag as Producto; // Producto asociado a la fila seleccionada
            if (p == null)
            {
                MessageBox.Show("Seleccione un producto de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            productoSeleccionado = p; // producto completo, incluyendo el artista
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormBuscarProductos_Load(object sender, EventArgs e)
        {
            // Solo los productos que tienen proveedor y es el elegido
            productosDelProveedor = new CL_Producto().Listar()
                .Where(p => p.proveedor != null && p.proveedor.id_proveedor == idProveedorFiltro)
                .ToList();

            MostrarProductos(productosDelProveedor);

            // Las opciones de "Buscar por" son las columnas visibles de la grilla
            comboBoxBuscar.Items.Clear();
            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                if (columna.Visible)
                {
                    comboBoxBuscar.Items.Add(columna.HeaderText);
                }
            }

            if (comboBoxBuscar.Items.Count > 0)
            {
                comboBoxBuscar.SelectedIndex = 0;
            }
        }

        // Muestra la lista en la grilla. El orden coincide con las columnas del diseñador:
        // ID (oculta) | Codigo | Nombre / Album | Artista | Categoria
        private void MostrarProductos(List<Producto> lista)
        {
            dgvProductos.Rows.Clear();

            foreach (Producto item in lista)
            {
                int n = dgvProductos.Rows.Add(
                    item.id_producto,
                    item.codigo,
                    item.nombreProducto,
                    item.artista,   // en reproductores queda en blanco
                    item.categoria?.descripcion);

                dgvProductos.Rows[n].Tag = item; // Asocia el producto completo a la fila
            }
        }

        private void AplicarFiltro()
        {
            // Normalizar saca las tildes y pasa a mayúsculas: "Codigo" -> "CODIGO", "Nombre / Album" -> "NOMBRE / ALBUM"
            string criterio = Normalizar(comboBoxBuscar.Text);
            string texto = Normalizar(textBuscar.Text.Trim());

            List<Producto> filtrados = productosDelProveedor.Where(p =>
            {
                if (texto == "") return true;   // sin texto: se muestran todos

                string valor;

                if (criterio.Contains("CODIGO"))
                    valor = p.codigo;
                else if (criterio.Contains("NOMBRE") || criterio.Contains("ALBUM"))
                    valor = p.nombreProducto;
                else if (criterio.Contains("ARTISTA"))
                    valor = p.artista;
                else if (criterio.Contains("CATEGORIA"))
                    valor = p.categoria?.descripcion;
                else
                    valor = "";

                return Normalizar(valor).Contains(texto);
            }).ToList();

            MostrarProductos(filtrados);

            if (filtrados.Count == 0)
            {
                MessageBox.Show("No se encontraron productos con ese criterio.",
                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconBuscar_Click(object sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void iconBtnLimpiar_Click(object sender, EventArgs e)
        {
            textBuscar.Clear();
            MostrarProductos(productosDelProveedor);   // vuelven todos los productos del proveedor
            textBuscar.Focus(); // Coloca el foco en el TextBox para que el usuario pueda escribir de inmediato
        }

        // Pasa a mayúsculas y le saca las tildes: "Beyoncé" -> "BEYONCE"
        private static string Normalizar(string texto)
        {
            if (string.IsNullOrEmpty(texto)) return "";

            StringBuilder sb = new StringBuilder();
            foreach (char c in texto.Normalize(NormalizationForm.FormD))
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }
            return sb.ToString().ToUpperInvariant();
        }
    }
}