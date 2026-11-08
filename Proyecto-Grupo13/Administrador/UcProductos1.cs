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

namespace Proyecto_Grupo13.Administrador
{
    public partial class UcProductos1 : UserControl
    {
        private int filaEditar = -1; // Variable para almacenar la fila que se está editando
        private readonly Color colorNormal = Color.FromArgb(70, 75, 85); // Color normal de los TextBox

        public UcProductos1()
        {
            InitializeComponent();

            // Nos aseguramos de que el combo de categoría avise cuando cambia (una sola vez)
            comboBoxCategoria.SelectedIndexChanged -= comboBoxCategoria_SelectedIndexChanged;
            comboBoxCategoria.SelectedIndexChanged += comboBoxCategoria_SelectedIndexChanged;

            ConfigurarGrill();
            CargarProductosGrid();
            CargarComboBoxCategorias();
            CargarComboBoxProveedores();
            comboBoxBuscar.Items.Clear(); // Limpiar los ítems existentes
            comboBoxBuscar.Items.AddRange(new object[] { "Nombre", "Código", "Categoría", "Artista" }); // Criterios de búsqueda
            ActualizarCamposMusicales(); // Actualizar campos musicales al iniciar

        }

        // Configuración inicial del DataGridView
        private void ConfigurarGrill()
        {
            dataGridView2.AutoGenerateColumns = false; // Evitar que se generen columnas automáticamente
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells; // Ajustar el tamaño de las columnas al contenido
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Selección de fila completa
            dataGridView2.MultiSelect = false; // No permitir selección múltiple
            dataGridView2.AllowUserToAddRows = false; // No permitir agregar filas manualmente
            dataGridView2.AllowUserToDeleteRows = false; // No permitir eliminar filas manualmente
            dataGridView2.ReadOnly = true; // Hacer el DataGridView de solo lectura

            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", HeaderText = "ID", DataPropertyName = "id_producto", Visible = false });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Artista", HeaderText = "Artista", DataPropertyName = "artista" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Nombre", HeaderText = "Nombre / Album", DataPropertyName = "nombreProducto" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Codigo", HeaderText = "Código", DataPropertyName = "codigo" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Descripcion", HeaderText = "Descripción", DataPropertyName = "descripcion" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Categoria", HeaderText = "Categoría", DataPropertyName = "categoria.descripcion" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "StockActual", HeaderText = "Stock Actual", DataPropertyName = "stock" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "StockMinimo", HeaderText = "Stock Mínimo", DataPropertyName = "stockMinimo" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "PrecioVenta", HeaderText = "Precio Venta", DataPropertyName = "precioVenta" });
            dataGridView2.Columns.Add(new DataGridViewTextBoxColumn { Name = "Proveedor", HeaderText = "Proveedor", DataPropertyName = "proveedor.nombre" });
        }

        private void CargarProductosGrid()
        {
            dataGridView2.Rows.Clear();
            List<Producto> lista = new CL_Producto().Listar();

            foreach (Producto item in lista)
            {
                int n = dataGridView2.Rows.Add(
                    item.id_producto,
                    item.artista, // en reproductores queda en blanco, en CDs y vinilos se muestra
                    item.nombreProducto,
                    item.codigo,
                    item.descripcion,
                    item.categoria.descripcion,
                    item.stock,
                    item.stockMinimo,
                    item.precioVenta.ToString("0.00"),
                    item.proveedor?.razonSocial ?? "");

                dataGridView2.Rows[n].Tag = item; // Guardamos el producto completo en la fila

                // Stock en el mínimo o por debajo: hay que reponer
                if (item.stock <= item.stockMinimo)
                {
                    DataGridViewCell celda = dataGridView2.Rows[n].Cells["StockActual"];
                    celda.Style.BackColor = Color.LightPink;
                    celda.Style.ForeColor = Color.Black;
                }
            }
        }

        // ============================================================
        // VALIDACIONES DE LOS TEXTBOX
        // ============================================================
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite letras, números, espacios, caracteres de control y signos de puntuación/símbolos
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsPunctuation(e.KeyChar) &&
                !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textArtista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsPunctuation(e.KeyChar) &&
                !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo números y letras
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras y números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                !char.IsPunctuation(e.KeyChar) &&
                !char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo números
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ============================================================
        // VALIDAR CAMPOS
        // ============================================================
        // Pinta el campo de rosa si no es válido y devuelve si lo es
        private bool MarcarCampo(Control campo, bool esValido)
        {
            campo.BackColor = esValido ? colorNormal : Color.LightPink;
            campo.ForeColor = esValido ? Color.White : Color.Black;
            return esValido;
        }

        private bool ValidarCamposVacios()
        {
            bool esValido = true;

            esValido &= MarcarCampo(textNombre, !string.IsNullOrWhiteSpace(textNombre.Text));
            esValido &= MarcarCampo(textCodigo, !string.IsNullOrWhiteSpace(textCodigo.Text));
            esValido &= MarcarCampo(textDescripcion, !string.IsNullOrWhiteSpace(textDescripcion.Text));
            esValido &= MarcarCampo(textStock, !string.IsNullOrWhiteSpace(textStock.Text));
            esValido &= MarcarCampo(comboBoxCategoria, comboBoxCategoria.SelectedIndex != -1);
            esValido &= MarcarCampo(comboBoxProveedor, comboBoxProveedor.SelectedIndex != -1);

            // El artista solo es obligatorio si es CD o vinilo
            if (textArtista.Enabled)
            {
                esValido &= MarcarCampo(textArtista, !string.IsNullOrWhiteSpace(textArtista.Text));
            }

            return esValido;
        }

        // Primera letra mayúscula y el resto minúscula
        private string formatearTexto(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) return "";
            return char.ToUpper(texto[0]) + texto.Substring(1).ToLower();
        }

        // Valida que el código no esté repetido en la grilla
        private bool ValidarCodigoUnico()
        {
            if (string.IsNullOrWhiteSpace(textCodigo.Text))
                return true;

            string codigoIngresado = textCodigo.Text.Trim();

            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                if (fila.IsNewRow) continue;

                // Si estamos editando, ignoramos la fila actual para que no se detecte a sí misma
                if (filaEditar != -1 && fila.Index == filaEditar) continue;

                string codigoFila = fila.Cells["Codigo"].Value?.ToString();

                if (codigoIngresado.Equals(codigoFila, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Este Código ya está registrado en la lista.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    textCodigo.BackColor = Color.LightPink;
                    textCodigo.Focus();
                    return false;
                }
            }

            textCodigo.BackColor = colorNormal;
            return true;
        }

        private void textCodigo_Leave(object sender, EventArgs e)
        {
            ValidarCodigoUnico();
        }

        // Arma el producto con lo que hay en pantalla
        private Producto ConstruirProducto(int idProducto)
        {
            bool esMusica = textArtista.Enabled;   // CD o vinilo

            return new Producto()
            {
                id_producto = idProducto,
                codigo = textCodigo.Text.Trim(),

                // En CDs y vinilos el nombre es el álbum: se deja como se escribe ("Led Zeppelin IV")
                nombreProducto = esMusica ? textNombre.Text.Trim() : formatearTexto(textNombre.Text),
                descripcion = textDescripcion.Text.Trim(),
                stockMinimo = Convert.ToInt32(textStock.Text),
                estado = 1,
                categoria = (Categoria)comboBoxCategoria.SelectedItem,
                proveedor = (Proveedor)comboBoxProveedor.SelectedItem,

                // El artista se guarda como se escribe ("AC/DC")
                artista = esMusica ? textArtista.Text.Trim() : null
            };
        }

        // ============================================================
        // BOTONES: AGREGAR, ELIMINAR, EDITAR, ACTUALIZAR, CANCELAR
        // ============================================================
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposVacios())
            {
                MessageBox.Show("Faltan completar campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCodigoUnico()) return;

            DialogResult ask = MessageBox.Show("¿Desea agregar este nuevo producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask != DialogResult.Yes) return;

            string mensaje;
            bool resultado = new CL_Producto().RegistrarProducto(ConstruirProducto(0), out mensaje);

            if (resultado)
            {
                MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductosGrid();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(mensaje, "Error al registrar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para eliminar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult ask = MessageBox.Show("¿Desea eliminar el producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask != DialogResult.Yes) return;

            int idProducto = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["Id"].Value);

            string mensaje;
            if (new CL_Producto().Desactivar(idProducto, out mensaje))
            {
                MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductosGrid();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un producto para editar.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow fila = dataGridView2.SelectedRows[0];
            Producto p = fila.Tag as Producto;

            if (p == null)
            {
                MessageBox.Show("No se puede editar una fila vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            filaEditar = fila.Index;

            textNombre.Text = p.nombreProducto;
            textCodigo.Text = p.codigo;
            textDescripcion.Text = p.descripcion;
            textStock.Text = p.stockMinimo.ToString();

            // Al elegir la categoría se habilita o deshabilita el artista
            comboBoxCategoria.SelectedValue = p.categoria.id_categoria;

            if (p.proveedor != null)
                comboBoxProveedor.SelectedValue = p.proveedor.id_proveedor;
            else
                comboBoxProveedor.SelectedIndex = -1;

            textArtista.Text = p.artista ?? "";

            iconBtnActualizar.Visible = true;
            iconBtnCancelar.Visible = true;
            btnAgregar.Enabled = false;
            MessageBox.Show("Edite los campos y haga clic en 'Actualizar' para guardar los cambios.", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void iconBtnActualizar_Click(object sender, EventArgs e)
        {
            if (filaEditar == -1) return;

            if (!ValidarCamposVacios())
            {
                MessageBox.Show("Faltan completar campos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validamos que el código no exista (ignorando la fila que estamos editando)
            if (!ValidarCodigoUnico()) return;

            DialogResult askEdit = MessageBox.Show("¿Desea guardar los cambios del producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (askEdit != DialogResult.Yes) return;

            int idProducto = Convert.ToInt32(dataGridView2.Rows[filaEditar].Cells["Id"].Value);

            string mensaje;
            bool resultado = new CL_Producto().EditarProducto(ConstruirProducto(idProducto), out mensaje);

            if (resultado)
            {
                MessageBox.Show("Producto editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductosGrid();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconBtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            textNombre.Clear();
            textCodigo.Clear();
            textDescripcion.Clear();
            textStock.Clear();
            textArtista.Clear();
            comboBoxCategoria.SelectedIndex = -1;   // también deshabilita el artista y vuelve la etiqueta a "Nombre:"
            comboBoxProveedor.SelectedIndex = -1;

            // Se sacan los colores rosa de una validación anterior
            foreach (Control campo in new Control[] { textNombre, textCodigo, textDescripcion, textStock,
                                                      textArtista, comboBoxCategoria, comboBoxProveedor })
            {
                campo.BackColor = colorNormal;
                campo.ForeColor = Color.White;
            }

            filaEditar = -1; // Reiniciamos la variable de edición

            iconBtnActualizar.Visible = false;
            iconBtnCancelar.Visible = false;
            btnAgregar.Enabled = true;
        }

        // ============================================================
        // BÚSQUEDA
        // ============================================================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (comboBoxBuscar.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un criterio de búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            FiltrarGrilla();
        }

        // Borrador: limpia la búsqueda y vuelve a mostrar TODOS los productos
        private void iconLimpiar_Click(object sender, EventArgs e)
        {
            comboBoxBuscar.SelectedIndex = -1;
            textBuscar.Clear();
            FiltrarGrilla();
            dataGridView2.ClearSelection();
        }

        private void FiltrarGrilla()
        {
            string columna = null;

            switch (comboBoxBuscar.Text)
            {
                case "Nombre": columna = "Nombre"; break;
                case "Código": case "Codigo": columna = "Codigo"; break;
                case "Categoría": case "Categoria": columna = "Categoria"; break;
                case "Artista": columna = "Artista"; break;
            }

            string texto = Normalizar(textBuscar.Text.Trim());

            dataGridView2.CurrentCell = null;   // necesario para poder ocultar filas

            foreach (DataGridViewRow fila in dataGridView2.Rows)
            {
                if (fila.IsNewRow) continue;

                if (columna == null || texto == "")
                {
                    fila.Visible = true;
                    continue;
                }

                fila.Visible = Normalizar(fila.Cells[columna].Value?.ToString()).Contains(texto);
            }
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

        // ============================================================
        // COMBOS Y CATEGORÍA (CD/VINILO LLEVAN ARTISTA; REPRODUCTOR NO)
        // ============================================================
        private void CargarComboBoxCategorias()
        {
            List<Categoria> listaCategorias = new CL_Categoria().Listar();

            comboBoxCategoria.DataSource = listaCategorias;
            comboBoxCategoria.DisplayMember = "descripcion"; // Lo que el usuario ve
            comboBoxCategoria.ValueMember = "id_categoria";  // El ID oculto por detrás
            comboBoxCategoria.SelectedIndex = -1;            // Iniciar limpio
        }

        private void CargarComboBoxProveedores()
        {
            List<Proveedor> listaProveedores = new CL_Proveedor().ListarProveedores();

            comboBoxProveedor.DataSource = listaProveedores;
            comboBoxProveedor.DisplayMember = "razonSocial";
            comboBoxProveedor.ValueMember = "id_proveedor";
            comboBoxProveedor.SelectedIndex = -1;
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarCamposMusicales();
        }

        private void ActualizarCamposMusicales()
        {
            Categoria categoria = comboBoxCategoria.SelectedItem as Categoria;
            bool habilitar = categoria != null && CL_Producto.requiereArtista(categoria.descripcion);

            textArtista.Enabled = habilitar;
            textArtista.Visible = habilitar;
            labelArtista.Visible = habilitar;


            // En CDs y vinilos el "Nombre" es el álbum; en reproductores, la marca y el modelo
            lNombreP.Text = habilitar ? "Álbum:" : "Nombre:";

            if (!habilitar)
            {
                textArtista.Clear();
            }
        }

        private void labelProductos_Click(object sender, EventArgs e) { }

        private void UcProductos1_Load(object sender, EventArgs e) { }

        private void comboBoxCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
