using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto_Grupo13.Gerente
{
    public partial class ucMasVendidos : UserControl
    {
        public ucMasVendidos()
        {
            InitializeComponent();

            // Configuramos el ComboBox
            cmbBuscarPor.Items.Clear();
            cmbBuscarPor.Items.Add("Producto");
            cmbBuscarPor.Items.Add("Categoría");

            // Producto seleccionado por defecto
            cmbBuscarPor.SelectedIndex = 0;

            // Configuramos el gráfico principal
            ConfigChartMasVendidos();

            // Cargamos los datos iniciales
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

            chartMasVendidos.ChartAreas.Add(area);
        }

        // productos más vendidos

        private void MostrarProductos()
        {
            labelVendidos.Text = "PRODUCTO MÁS VENDIDO:";

            // indicamos que la lista contiene ItemEstadistica
            List<ItemEstadistica> productos = new List<ItemEstadistica>
            {
                new ItemEstadistica("CD Taylor Swift", 50, 50000),
                new ItemEstadistica("Vinilo Queen", 30, 30000),
                new ItemEstadistica("CD Metallica", 20, 20000),
                new ItemEstadistica("Tocadiscos", 10, 100000)
            };

            // buscamos el producto con más unidades vendidas
            ItemEstadistica destacado =
                productos.OrderByDescending(p => p.CantidadVendida).First();

            // mostramos el producto destacado
            textResultadoPrincipal.Text = destacado.Nombre;
            textResultadoCantidad.Text = destacado.CantidadVendida.ToString();

            // cargamos la grilla y el gráfico
            CargarGrid(productos, "Producto");
            CargarGraficoPrincipal(productos, "Producto");
        }

        // categorias más vendidas

        private void MostrarCategorias()
        {
            labelVendidos.Text = "CATEGORÍA MÁS VENDIDA:";

            // indicamos que la lista contiene ItemEstadistica
            List<ItemEstadistica> categorias = new List<ItemEstadistica>
            {
                new ItemEstadistica("CDs", 100, 100000),
                new ItemEstadistica("Vinilos", 50, 50000),
                new ItemEstadistica("Reproductores", 20, 200000)
            };

            // buscamos la categoría con más unidades vendidas
            ItemEstadistica destacada =
                categorias.OrderByDescending(c => c.CantidadVendida).First();

            // mostramos la categoría destacada
            textResultadoPrincipal.Text = destacada.Nombre;
            textResultadoCantidad.Text = destacada.CantidadVendida.ToString();

            // cargamos la grilla y el gráfico
            CargarGrid(categorias, "Categoría");
            CargarGraficoPrincipal(categorias, "Categoría");
        }

        // cargar datos en el dataGridView y cambiar el encabezado de la primera columna según el tipo (Producto o Categoría)

        private void CargarGrid(List<ItemEstadistica> datos, string tipo)
        {
            dgvMasVendidos.Rows.Clear();

            // cambiamos el encabezado de la primera columna
            if (dgvMasVendidos.Columns.Count > 0)
            {
                dgvMasVendidos.Columns[0].HeaderText = tipo;
            }

            // agregamos los datos
            foreach (ItemEstadistica dato in datos)
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
            List<ItemEstadistica> datos,
            string tipo)
        {
            chartMasVendidos.Series.Clear();

            Series serie = new Series(tipo + " más vendidos");

            // categoría = gráfico circular
            // producto = gráfico de columnas
            if (tipo == "Categoría")
            {
                serie.ChartType = SeriesChartType.Pie; //cambia el tipo de gráfico a circular
            }
            else
            {
                serie.ChartType = SeriesChartType.Column; //cambia el tipo de gráfico a columnas
            }

            serie.IsValueShownAsLabel = true;

            // agregamos cada elemento al gráfico
            foreach (ItemEstadistica dato in datos)
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
                tipo.ToUpper() + " MÁS VENDIDOS"
            );
        }

        // vendedores con más ventas

        private void MostrarVendedores()
        {
            // indicamos que la lista contiene VendedorEstadistica
            List<VendedorEstadistica> vendedores =
                new List<VendedorEstadistica>
            {
                new VendedorEstadistica("Juan Pérez", 25),
                new VendedorEstadistica("María López", 18),
                new VendedorEstadistica("Pedro Gómez", 12),
                new VendedorEstadistica("Ana Rodríguez", 8),
                new VendedorEstadistica("Lucas Fernández", 15)
            };

            // buscamos el vendedor con más ventas
            VendedorEstadistica vendedorDestacado =
                vendedores.OrderByDescending(v => v.Ventas).First();

            // mostramos el vendedor destacado
            textVendedor.Text = vendedorDestacado.Nombre;
            textVentas.Text = vendedorDestacado.Ventas.ToString();

            // limpiamos el gráfico
            chartVendedores.Series.Clear();

            Series serie = new Series("Ventas realizadas");

            serie.ChartType = SeriesChartType.Column;
            serie.IsValueShownAsLabel = true;

            // agregamos los vendedores al gráfico
            foreach (VendedorEstadistica vendedor in vendedores)
            {
                serie.Points.AddXY(
                    vendedor.Nombre,
                    vendedor.Ventas
                );
            }

            chartVendedores.Series.Add(serie);

            // titulo
            chartVendedores.Titles.Clear();
            chartVendedores.Titles.Add("VENTAS POR VENDEDOR");
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

            string opcion = cmbBuscarPor.SelectedItem.ToString();

            if (opcion == "Producto")
            {
                MostrarProductos();
            }
            else if (opcion == "Categoría")
            {
                MostrarCategorias();
            }
            MostrarVendedores();
        }

        // item estadistica para productos y categorias

        public class ItemEstadistica
        {
            public string Nombre { get; set; }

            public int CantidadVendida { get; set; }

            public decimal Ingresos { get; set; }

            public ItemEstadistica(
                string nombre,
                int cantidadVendida,
                decimal ingresos)
            {
                Nombre = nombre;
                CantidadVendida = cantidadVendida;
                Ingresos = ingresos;
            }
        }

        // vendedor estadistica para vendedores con más ventas

        public class VendedorEstadistica
        {
            public string Nombre { get; set; }

            public int Ventas { get; set; }

            public VendedorEstadistica(
                string nombre,
                int ventas)
            {
                Nombre = nombre;
                Ventas = ventas;
            }
        }
    }
}
