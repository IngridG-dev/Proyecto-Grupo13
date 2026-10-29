using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CapaEntidad;
using CapaLogica;

namespace Proyecto_Grupo13.Gerente
{
    public partial class ucMasVendidos : UserControl
    {
        private const int TOP_GRAFICO = 10;   // cantidad de productos que muestra el gráfico

        private readonly CL_Estadistica logica = new CL_Estadistica();

        // Rango de fechas aplicado (null = sin filtro, o sea, todo el historial)
        private DateTime? filtroDesde = null;
        private DateTime? filtroHasta = null;
        public ucMasVendidos()
        {
            InitializeComponent();

            // Las fechas solo filtran si el casillero del selector está tildado
            dtpInicio.ShowCheckBox = true;
            dtpInicio.Checked = false;
            dtpFin.ShowCheckBox = true;
            dtpFin.Checked = false;

            // Configuramos el DataGridView
            dgvMasVendidos.AllowUserToAddRows = false;
            dgvMasVendidos.ReadOnly = true;

            // Configuramos el ComboBox
            cmbBuscarPor.Items.Clear();
            cmbBuscarPor.Items.Add("Producto");
            cmbBuscarPor.Items.Add("Categoría");

            // Producto seleccionado por defecto
            cmbBuscarPor.SelectedIndex = 0;

            // Configuramos el gráfico principal y datos iniciales
            actualizarTodo();
            ConfigChartMasVendidos();

        }
        // Actualiza todos los datos de la pantalla según el filtro actual
        private void actualizarTodo()
        {
            // Evita consultar la base cuando Visual Studio dibuja el control en el diseñador
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            if (cmbBuscarPor.Text == "Categoría")
                MostrarCategorias();
            else
                MostrarProductos();

            MostrarVendedores();
        }

        // config del chart principal
        private void ConfigChartMasVendidos()
        {
            chartMasVendidos.Series.Clear();
            chartMasVendidos.ChartAreas.Clear();
            chartMasVendidos.Legends.Clear();

            ChartArea area = new ChartArea("AreaPrincipal");

            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = true;
            area.AxisX.Interval = 1; //muestra el nombre de todas las columnas en el eje X

            chartMasVendidos.ChartAreas.Add(area);
        }

        // productos más vendidos

        private void MostrarProductos()
        {
            labelVendidos.Text = "PRODUCTO MÁS VENDIDO:";

            // indicamos que la lista contiene ItemEstadistica
            List<Estadisticas> productos = logica.productosMasVendidos(filtroDesde, filtroHasta);
            {
                mostrarDestacado(productos);
                //la grilla muestra todos los productos, pero el gráfico solo los primeros
                CargarGrid(productos, "Producto");
                CargarGraficoPrincipal(productos.Take(TOP_GRAFICO).ToList(), "Producto");
            }
        }

        // categorias más vendidas
        private void MostrarCategorias()
        {
            labelVendidos.Text = "CATEGORÍA MÁS VENDIDA:";

            // indicamos que la lista contiene ItemEstadistica
            List<Estadisticas> categorias = logica.categoriasMasVendidas(filtroDesde, filtroHasta);
            {
                mostrarDestacado(categorias);
                CargarGrid(categorias, "Categoría");
                CargarGraficoPrincipal(categorias, "Categoría");
            }
        }
        // muestra el producto/categoría con más unidades vendidas (o "-" si no hay ventas)
        private void mostrarDestacado(List<Estadisticas> datos)
        {
            if (datos.Count == 0)
            {
                textResultadoPrincipal.Text = "-";
                textResultadoCantidad.Text = "0";
                return;
            }

            Estadisticas destacado = datos.OrderByDescending(d => d.CantidadVendida).First();

            textResultadoPrincipal.Text = destacado.Nombre;
            textResultadoCantidad.Text = destacado.CantidadVendida.ToString();
        }

        // cargar datos en el dataGridView y cambiar el encabezado de la primera columna según el tipo (Producto o Categoría)

        private void CargarGrid(List<Estadisticas> datos, string tipo)
        {
            dgvMasVendidos.Rows.Clear();

            // cambiamos el encabezado de la primera columna
            if (dgvMasVendidos.Columns.Count > 0)
            {
                dgvMasVendidos.Columns[0].HeaderText = tipo;
            }

            // agregamos los datos
            foreach (Estadisticas dato in datos)
            {
                dgvMasVendidos.Rows.Add(
                    dato.Nombre,
                    dato.CantidadVendida,
                    dato.Ingresos.ToString("C")
                );
            }
        }

        // chart de productos o categorias más vendidos, según el tipo

        private void CargarGraficoPrincipal(
            List<Estadisticas> datos,
            string tipo)
        {
            chartMasVendidos.Series.Clear();

            Series serie = new Series(tipo + " más vendidos");

            // categoría = gráfico circular
            // producto = gráfico de columnas
            if (tipo == "Categoría")
            {
                serie.ChartType = SeriesChartType.Pie; //cambia el tipo de gráfico a circular
                serie.Label = "#VALX: #VAL"; //muestra el nombre y la cantidad en cada porción del gráfico
            }
            else
            {
                serie.ChartType = SeriesChartType.Column; //cambia el tipo de gráfico a columnas
                serie.IsValueShownAsLabel = true; //muestra la cantidad en cada columna del gráfico
            }

            // agregamos cada elemento al gráfico
            foreach (Estadisticas dato in datos)
            {
                serie.Points.AddXY(
                    dato.Nombre,
                    dato.CantidadVendida
                );
            }

            chartMasVendidos.Series.Add(serie);

            // titulo
            chartMasVendidos.Titles.Clear();
            chartMasVendidos.Titles.Add(
                tipo == "Producto"
                    ? "PRODUCTOS MÁS VENDIDOS (TOP" + TOP_GRAFICO + ")"
                    : "CATEGORÍAS MÁS VENDIDAS");
        }

        // vendedores con más ventas
        private void MostrarVendedores()
        {
            // indicamos que la lista contiene VendedorEstadistica
            List<VendedorEstadistica> vendedores = logica.ventasPorVendedor(filtroDesde, filtroHasta);
            {
                if (vendedores.Count == 0)
                {
                    textVendedor.Text = "-";
                    textVentas.Text = "0";
                }
                else
                {
                    VendedorEstadistica vendedorDestacado = vendedores.OrderByDescending(v => v.Ventas).First();

                    textVendedor.Text = vendedorDestacado.Nombre;
                    textVentas.Text = vendedorDestacado.Ventas.ToString();
                }

                chartVendedores.Series.Clear();

                if (chartVendedores.ChartAreas.Count > 0)
                    chartVendedores.ChartAreas[0].AxisX.Interval = 1;

                Series serie = new Series("Ventas realizadas");
                serie.ChartType = SeriesChartType.Column;
                serie.IsValueShownAsLabel = true;

                foreach (VendedorEstadistica vendedor in vendedores)
                {
                    serie.Points.AddXY(vendedor.Nombre, vendedor.Ventas);
                }

                chartVendedores.Series.Add(serie);

                chartVendedores.Titles.Clear();
                chartVendedores.Titles.Add("VENTAS POR VENDEDOR");
            }
        }

        // boton buscar

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbBuscarPor.SelectedItem == null)
            {
                MessageBox.Show(
                    "Seleccione una opción para buscar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DateTime? desde = dtpInicio.Checked ? dtpInicio.Value.Date : (DateTime?)null;
            DateTime? hasta = dtpFin.Checked ? dtpFin.Value.Date : (DateTime?)null;

            if (desde.HasValue && hasta.HasValue && desde > hasta)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha fin.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            filtroDesde = desde;
            filtroHasta = hasta;
            actualizarTodo();
            if (dgvMasVendidos.Rows.Count == 0)
            {
                MessageBox.Show("No hay ventas en ese período.", "Sin resultados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        // Al volver a esta pantalla se actualizan los datos, manteniendo el filtro aplicado
        private void ucMasVendidos_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible) actualizarTodo();
        }

    }
}
