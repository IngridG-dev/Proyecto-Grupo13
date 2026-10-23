using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Grupo13.Vendedor
{
    public partial class ucProductos : UserControl
    {
        public ucProductos()
        {
            InitializeComponent();
            dgvProductos.AllowUserToAddRows = false;   // saca la fila vacía del final
            dgvProductos.ReadOnly = true;              // el vendedor solo mira
            dgvProductos.MultiSelect = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            comboBoxBuscar.Items.Clear();
            comboBoxBuscar.Items.AddRange(new object[]
            {
                "Todos los campos", "Código", "Producto", "Categoría", "Descripción"
            });
            comboBoxBuscar.SelectedIndex = 0;

            cargarProductos();
        }

        // Trae los productos de la base, aplica el filtro actual y los muestra
        private void cargarProductos()
        {
            // Evita consultar la base cuando Visual Studio dibuja el control en el diseñador
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            List<Producto> lista = new CL_Producto().Listar();   // TODOS, sin filtro por proveedor
            MostrarProductos(Filtrar(lista));
        }

        private void MostrarProductos(List<Producto> lista)
        {
            dgvProductos.Rows.Clear();

            foreach (Producto p in lista)
            {
                // Orden: Código | Producto | Categoría | Descripción | Precio | Stock
                dgvProductos.Rows.Add(
                    p.codigo,
                    p.nombreProducto,
                    p.categoria?.descripcion,
                    p.descripcion,
                    p.precioVenta.ToString("0.00"),
                    p.stock);
            }
        }

        // Filtra por lo escrito. Ignora mayúsculas y tildes, y acepta varias palabras
        // en cualquier orden (por ejemplo: "queen greatest").
        private List<Producto> Filtrar(List<Producto> lista)
        {
            string[] palabras = Normalizar(textBuscar.Text)
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (palabras.Length == 0) return lista;

            return lista.Where(p =>
            {
                string campo;

                switch (comboBoxBuscar.Text)
                {
                    case "Código":
                        campo = p.codigo;
                        break;
                    case "Producto":
                        campo = p.nombreProducto;
                        break;
                    case "Categoría":
                        campo = p.categoria?.descripcion;
                        break;
                    case "Descripción":
                        campo = p.descripcion;
                        break;
                    default: // Todos los campos: las palabras pueden estar en campos distintos
                        campo = p.codigo + " " + p.nombreProducto + " " +
                                p.categoria?.descripcion + " " + p.descripcion;
                        break;
                }

                string texto = Normalizar(campo);
                return palabras.All(w => texto.Contains(w));
            }).ToList();
        }

        // Pasa a mayúsculas y le saca las tildes: "Álbum" -> "ALBUM"
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

        private void buscar()
        {
            cargarProductos();

            if (dgvProductos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron productos con ese criterio.",
                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void iconBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        private void textBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;   // evita el "beep" de Windows
                buscar();
            }
        }
        private void iconBtnLimpiar_Click(object sender, EventArgs e)
        {
            textBuscar.Clear();
            comboBoxBuscar.SelectedIndex = 0;
            cargarProductos();
            textBuscar.Focus();
        }
        private void ucProductos_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible) cargarProductos();
        }
    }
}
