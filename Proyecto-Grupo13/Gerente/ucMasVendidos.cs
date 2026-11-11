using CapaEntidad;
using CapaLogica;
using ClosedXML;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Presentation;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

using pdfFont = iTextSharp.text.Font;
using pdfColor = iTextSharp.text.BaseColor;


namespace Proyecto_Grupo13.Gerente
{
    public partial class ucMasVendidos : UserControl
    {
        private const int TOP_GRAFICO = 10;   // cantidad de productos que muestra el gráfico

        private readonly CL_Estadistica logica = new CL_Estadistica(); // instancia de la capa lógica para acceder a los métodos de estadísticas

        // Rango de fechas aplicado (null = sin filtro, o sea, todo el historial)
        private DateTime? filtroDesde = null;
        private DateTime? filtroHasta = null;
        private DateTime? evolucionDesde = null;
        private DateTime? evolucionHasta = null;
        public ucMasVendidos()
        {
            InitializeComponent();

            // Las fechas solo filtran si el casillero del selector está tildado
            dtpInicio.ShowCheckBox = true;
            dtpInicio.Checked = false;
            dtpFin.ShowCheckBox = true;
            dtpFin.Checked = false;

            // Configuramos el ComboBox de productos y categorias
            cmbBuscarPor.Items.Clear();
            cmbBuscarPor.Items.Add("Producto");
            cmbBuscarPor.Items.Add("Categoría");
            cmbBuscarPor.SelectedIndex = 0; // Producto seleccionado por defecto
            //config de meses para la evolucion
            cmbMes.Items.Clear();
            cmbMes.Items.AddRange(new object[] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Dicembre"});
            cmbMes.SelectedIndex = DateTime.Now.Month - 1;
            //config comboBox de años
            cmbAño.Items.Clear();
            for (int año = DateTime.Now.Year - 5; año <= DateTime.Now.Year +1; año++)
            {
                cmbAño.Items.Add(año);
            }
            cmbAño.SelectedItem = DateTime.Now.Year;

            // Configuramos el gráfico principal y datos iniciales
            ConfigChartMasVendidos();
            actualizarTodo();
            mostrarEvolucion();

        }
        // Actualiza todos los datos de la pantalla según el filtro actual
        private void actualizarTodo()
        {
            // Evita consultar la base cuando Visual Studio dibuja el control en el diseñador
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) 
                return;

            if (cmbBuscarPor.Text == "Categoría")
                MostrarCategorias();
            else
                MostrarProductos();

            MostrarVendedores();
            mostrarMetodoPago();
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
            List<Estadisticas> productos = logica.productosMasVendidos(filtroDesde, filtroHasta); // devuelve una lista de productos con sus ventas y sus ingresos
            {
                mostrarDestacado(productos);
                //la grilla muestra todos los productos, pero el gráfico solo los primeros
                CargarGrid(productos, "Producto");
                CargarGraficoPrincipal(productos.Take(TOP_GRAFICO).ToList(), "Producto");
                CargarGraficoIngresos(productos.OrderByDescending(p => p.Ingresos).Take(TOP_GRAFICO).ToList(), "Producto");
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
                CargarGraficoIngresos(categorias, "Categoría");
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
                    dato.Ingresos.ToString("C2", new CultureInfo("es-AR"))
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
            List<VendedorEstadistica> vendedores = logica.ventasPorVendedor(filtroDesde, filtroHasta); // devuelve una lista de vendedores con sus ventas y sus ingresos
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

      
        // Al volver a esta pantalla se actualizan los datos, manteniendo el filtro aplicado
        private void ucMasVendidos_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible) actualizarTodo();
        }

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

        private void dgvMasVendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // gráfico de INGRESOS: columnas para productos, circular para categorías
        private void CargarGraficoIngresos(List<Estadisticas> datos, string tipo)
        {
            chartIngresos.Series.Clear();

            Series serie = new Series("Ingresos");

            if (tipo == "Categoría")
            {
                serie.ChartType = SeriesChartType.Pie;
                serie.Label = "#VALX: $ #VAL{#, ##0}";
            }
            else
            {
                serie.ChartType = SeriesChartType.Column;
                serie.IsValueShownAsLabel = true;
                serie.LabelFormat = "$ #,##0.00";
            }

            foreach (Estadisticas dato in datos)
            {
                serie.Points.AddXY(dato.Nombre, dato.Ingresos);
            }

            chartIngresos.Series.Add(serie);

            chartIngresos.Titles.Clear();
            chartIngresos.Titles.Add(
                tipo == "Producto"
                    ? "INGRESOS POR PRODUCTO (TOP " + TOP_GRAFICO + ")"
                    : "INGRESOS POR CATEGORÍA");
        }
        //evolucion de ventas por periodo (mes, año)
        //las columnas son los ingresos y la linea son la cantidad de ventas

        // EVOLUCIÓN DE VENTAS POR MES Y AÑO (SOLO LÍNEA)
        private void mostrarEvolucion()
        {
            if (!evolucionDesde.HasValue || !evolucionHasta.HasValue)
                return;

            List<Periodo> periodos = logica.ventasPorPeriodo(
                evolucionDesde,
                evolucionHasta,
                "Día"
            );

            chartEvolucion.Series.Clear();
            chartEvolucion.ChartAreas.Clear();
            chartEvolucion.Legends.Clear();
            chartEvolucion.Titles.Clear();

            if (periodos.Count == 0)
            {
                chartEvolucion.Titles.Add("SIN VENTAS EN EL PERÍODO");
                return;
            }

            // CONFIGURACIÓN DEL ÁREA
            ChartArea area = new ChartArea("AreaEvolucion");

            area.BackColor = Color.White;

            // EJE X: DÍAS
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisX.Interval = 2;
            area.AxisX.LabelStyle.Angle = -45;
            area.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8);
            area.AxisX.LabelStyle.ForeColor = Color.DimGray;
            area.AxisX.LineColor = Color.LightGray;
            area.AxisX.IsLabelAutoFit = true;

            // EJE Y: INGRESOS
            area.AxisY.MajorGrid.Enabled = true;
            area.AxisY.MajorGrid.LineColor = Color.Gainsboro;
            area.AxisY.Title = "Ingresos($) ";
            area.AxisY.LabelStyle.Format = "C0";
            area.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 8);
            area.AxisY.LabelStyle.ForeColor = Color.DimGray;
            area.AxisY.LineColor = Color.LightGray;
            area.AxisY.Minimum = 0;

            chartEvolucion.ChartAreas.Add(area);

            // SERIE: LÍNEA DE INGRESOS
            Series ingresos = new Series("Ingresos");

            ingresos.ChartArea = "AreaEvolucion";
            ingresos.ChartType = SeriesChartType.Line;

            // APARIENCIA DE LA LÍNEA
            ingresos.Color = Color.MediumPurple;
            ingresos.BorderWidth = 3;

            // PUNTOS DE LA LÍNEA
            ingresos.MarkerStyle = MarkerStyle.Circle;
            ingresos.MarkerSize = 7;
            ingresos.MarkerColor = Color.MediumPurple;
            ingresos.MarkerBorderColor = Color.White;
            ingresos.MarkerBorderWidth = 2;

            // EVITAR ETIQUETAS QUE SOBRECARGUEN EL GRÁFICO
            ingresos.IsValueShownAsLabel = false;

            // CARGAR LOS DATOS
            foreach (Periodo p in periodos)
            {
                ingresos.Points.AddXY(p.Etiqueta, p.Ingresos);
            }

            chartEvolucion.Series.Add(ingresos);

            // TÍTULO
            Title titulo = new Title(
                "EVOLUCIÓN DE INGRESOS - " +
                cmbMes.Text.ToUpper() + " " + cmbAño.Text
            );

            titulo.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            titulo.ForeColor = Color.FromArgb(70, 70, 70);

            chartEvolucion.Titles.Add(titulo);

            // FONDO
            chartEvolucion.BackColor = Color.White;
        }


        private void mostrarMetodoPago()
        {
            List<Estadisticas> metodos = logica.ventasPorMetodoPago(filtroDesde, filtroHasta);

            chartMetodoPago.Series.Clear();
            chartMetodoPago.Legends.Clear();
            chartMetodoPago.Titles.Clear();

            chartMetodoPago.Legends.Add(new Legend("Default"));

            // FUENTE DE LA REFERENCIA LATERAL
            chartMetodoPago.Legends["Default"].Font = new System.Drawing.Font("Segoe UI", 8);

            if (metodos.Count == 0)
            {
                chartMetodoPago.Titles.Add("SIN VENTAS REGISTRADAS");
                return;
            }

            Series serie = new Series("Métodos de pago");

            serie.ChartType = SeriesChartType.Pie;

            // TEXTO DENTRO DEL CÍRCULO
            serie.Label = "#VALX: #PERCENT{P1}";
            serie.Font = new System.Drawing.Font("Segoe UI", 7, FontStyle.Regular);
            serie.LabelForeColor = Color.White;

            serie["PieLabelStyle"] = "inside";

            serie.Legend = "Default";

            foreach (Estadisticas metodo in metodos)
            {
                serie.Points.AddXY(metodo.Nombre, metodo.CantidadVendida);
            }

            chartMetodoPago.Series.Add(serie);

            Title titulo = new Title("VENTAS POR MÉTODO DE PAGO");
            titulo.Font = new System.Drawing.Font("Segoe UI", 10, FontStyle.Bold);
            titulo.ForeColor = Color.FromArgb(70, 70, 70);

            chartMetodoPago.Titles.Add(titulo);
        }


        private void iconBtnFiltro_Click(object sender, EventArgs e)
        {
            if (cmbMes.SelectedIndex == -1 || cmbAño.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un mes y un año.");
                return;
            }

            int mes = cmbMes.SelectedIndex + 1;
            int año = Convert.ToInt32(cmbAño.SelectedItem);

            evolucionDesde = new DateTime(año, mes, 1);

            evolucionHasta = evolucionDesde.Value.AddMonths(1).AddDays(-1);

            mostrarEvolucion();
        }

        private void ucMasVendidos_Load(object sender, EventArgs e)
        {

        }

        private void iconBtnExcel_Click(object sender, EventArgs e)
        {
            
        }
        private string ObtenerPeriodoReporte()
        {
            if (filtroDesde.HasValue && filtroHasta.HasValue)
            {
                return filtroDesde.Value.ToString("dd/MM/yyyy") +
                       " al " +
                       filtroHasta.Value.ToString("dd/MM/yyyy");
            }

            if (filtroDesde.HasValue)
                return "Desde " + filtroDesde.Value.ToString("dd/MM/yyyy");

            if (filtroHasta.HasValue)
                return "Hasta " + filtroHasta.Value.ToString("dd/MM/yyyy");

            return "Todo el historial";
        }

        private void iconBtnPDF_Click(object sender, EventArgs e)
        {
            if (dgvMasVendidos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog guardar = new SaveFileDialog();

            guardar.Filter = "Archivo PDF (*.pdf)|*.pdf";
            guardar.FileName = "ReporteMasVendidos_" + DateTime.Now.ToString("yyyyMMdd");

            if (guardar.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                using (FileStream stream = new FileStream(
                    guardar.FileName, FileMode.Create))
                {
                    Document documento = new Document(
                        PageSize.A4, 35, 35, 40, 40);

                    PdfWriter.GetInstance(documento, stream);

                    documento.Open();

                    // FUENTES
                    pdfFont fuenteTitulo = FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD, 16, pdfColor.WHITE);

                    pdfFont fuenteSubtitulo = FontFactory.GetFont(
                        FontFactory.HELVETICA, 10, pdfColor.DARK_GRAY);

                    pdfFont fuenteEncabezado = FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD, 10, pdfColor.WHITE);

                    pdfFont fuenteDatos = FontFactory.GetFont(
                        FontFactory.HELVETICA, 9, pdfColor.BLACK);

                    // TÍTULO
                    PdfPTable tablaTitulo = new PdfPTable(1);
                    tablaTitulo.WidthPercentage = 100;

                    PdfPCell celdaTitulo = new PdfPCell(
                        new Phrase(
                            "REPORTE DE " + cmbBuscarPor.Text.ToUpper() + " MÁS VENDIDOS",
                            fuenteTitulo
                        )
                    );

                    celdaTitulo.BackgroundColor = new pdfColor(102, 76, 153);
                    celdaTitulo.HorizontalAlignment = Element.ALIGN_CENTER;
                    celdaTitulo.Padding = 12;
                    celdaTitulo.Border = PdfPCell.NO_BORDER;

                    tablaTitulo.AddCell(celdaTitulo);

                    documento.Add(tablaTitulo);

                    // PERÍODO
                    Paragraph periodo = new Paragraph(
                        "Período: " + ObtenerPeriodoReporte(),
                        fuenteSubtitulo);

                    periodo.SpacingBefore = 10;
                    periodo.SpacingAfter = 15;

                    documento.Add(periodo);

                    // TABLA DE DATOS
                    int cantidadColumnas = dgvMasVendidos.Columns.Count;

                    PdfPTable tabla = new PdfPTable(cantidadColumnas);
                    tabla.WidthPercentage = 100;
                    tabla.HeaderRows = 1;

                    // ENCABEZADOS
                    foreach (DataGridViewColumn columna in dgvMasVendidos.Columns)
                    {
                        PdfPCell celda = new PdfPCell(
                            new Phrase(columna.HeaderText, fuenteEncabezado)
                        );

                        celda.BackgroundColor = new pdfColor(72, 61, 139);
                        celda.HorizontalAlignment = Element.ALIGN_CENTER;
                        celda.Padding = 8;

                        tabla.AddCell(celda);
                    }

                    // FILAS
                    foreach (DataGridViewRow fila in dgvMasVendidos.Rows)
                    {
                        if (fila.IsNewRow)
                            continue;

                        foreach (DataGridViewCell celdaOriginal in fila.Cells)
                        {
                            PdfPCell celda = new PdfPCell(
                                new Phrase(
                                    celdaOriginal.Value?.ToString() ?? "",
                                    fuenteDatos
                                )
                            );

                            celda.HorizontalAlignment = Element.ALIGN_CENTER;
                            celda.VerticalAlignment = Element.ALIGN_MIDDLE;
                            celda.Padding = 7;

                            tabla.AddCell(celda);
                        }
                    }

                    documento.Add(tabla);

                    // PIE DEL INFORME
                    Paragraph pie = new Paragraph(
                        "\nFecha de generación: " +
                        DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                        fuenteSubtitulo);

                    pie.Alignment = Element.ALIGN_RIGHT;
                    documento.Add(pie);

                    documento.Close();
                }

                MessageBox.Show("El informe PDF se descargó correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Process.Start(new ProcessStartInfo
                {
                    FileName = guardar.FileName,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartIngresos_Click(object sender, EventArgs e)
        {

        }
    }
}
