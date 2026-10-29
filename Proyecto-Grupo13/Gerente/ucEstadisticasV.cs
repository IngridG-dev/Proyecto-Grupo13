using CapaEntidad;
using CapaLogica;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Grupo13.Gerente
{
    public partial class ucEstadisticasV : UserControl
    {
        public ucEstadisticasV()
        {
            InitializeComponent();
        }

        private void ucEstadisticasV_Load(object sender, EventArgs e)
        {
            // Al ingresar se cargan TODAS las ventas históricas de la empresa
            CargarVentas(null, null);
        }


        private void CargarVentas(DateTime? desde, DateTime? hasta)
        {
            CL_Venta logicaVenta = new CL_Venta();
            List<Venta> listaVentas = logicaVenta.ListarTodasLasVentas(desde, hasta);

            dgvVentas.Rows.Clear();

            int totalCantidadVentas = listaVentas.Count;
            int totalProductosVendidos = 0;
            decimal totalIngresos = 0;

            foreach (Venta v in listaVentas)
            {
                // 1. Calculamos la cantidad de productos sumando los detalles de esta venta específica
                int cantidadProductosFila = 0;
                List<DetalleVenta> detalles = logicaVenta.ObtenerDetalleVenta(v.id_venta); // Usamos tu método existente

                foreach (DetalleVenta dv in detalles)
                {
                    // Asume que tu clase DetalleVenta tiene una propiedad 'cantidad'
                    cantidadProductosFila += dv.cantidad;
                }

                // 2. Agregamos la fila a la grilla principal usando las propiedades correctas de tu Entidad
                dgvVentas.Rows.Add(
                    v.fechaCreacion.ToString("dd/MM/yyyy"),
                    cantidadProductosFila,
                    v.montoPago.ToString("0.00")
                );

                // 3. Acumulamos para los cuadros superiores
                totalProductosVendidos += cantidadProductosFila;
                totalIngresos += v.montoPago;
            }

            // Actualizamos los campos indicadores
            textCantVentas.Text = totalCantidadVentas.ToString();
            textProductosVendidos.Text = totalProductosVendidos.ToString();
            textIngresos.Text = "$ " + totalIngresos.ToString("0.00");
        }

        private void btnDescargarExcel_Click(object sender, EventArgs e)
        {
            if (dgvVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos cargados para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog savefile = new SaveFileDialog()
            {
                FileName = $"DashboardVentas_{DateTime.Now:yyyyMMdd}.xlsx",
                Filter = "Excel Files | *.xlsx"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    var hoja = wb.Worksheets.Add("Ventas");

                    // CABECERA Y TÍTULO
                    hoja.Range("B2:D2").Merge().Value = "REPORTE DE ESTADÍSTICAS DE VENTAS";
                    hoja.Cell("B2").Style.Font.Bold = true;
                    hoja.Cell("B2").Style.Font.FontSize = 16;
                    hoja.Cell("B2").Style.Font.FontColor = XLColor.FromHtml("#1e283c"); // Azul oscuro

                    hoja.Cell("B3").Value = $"Período: {dtpFechaInicio.Value:dd/MM/yyyy} al {dtpFechaFin.Value:dd/MM/yyyy}";
                    hoja.Cell("B3").Style.Font.Italic = true;
                    hoja.Cell("B3").Style.Font.FontColor = XLColor.Gray;

                    // CUADROS DE RESUMEN
                    hoja.Cell("B5").Value = "Total Ventas:";
                    hoja.Cell("B5").Style.Font.Bold = true;
                    hoja.Cell("C5").Value = Convert.ToInt32(textCantVentas.Text);

                    hoja.Cell("E5").Value = "Productos Vendidos:";
                    hoja.Cell("E5").Style.Font.Bold = true;
                    hoja.Cell("F5").Value = Convert.ToInt32(textProductosVendidos.Text);

                    hoja.Cell("H5").Value = "Ingresos:";
                    hoja.Cell("H5").Style.Font.Bold = true;

                    // Limpiamos el texto del ingreso para guardarlo como número real
                    decimal montoIngreso = Convert.ToDecimal(textIngresos.Text.Replace("$", "").Trim());
                    hoja.Cell("I5").Value = montoIngreso;
                    hoja.Cell("I5").Style.NumberFormat.Format = "$ #,##0.00"; // Formato moneda

                    // DATOS DE LA GRILLA (Comienza en fila 8)
                    int filaInicioTabla = 8;

                    // Encabezados
                    for (int i = 0; i < dgvVentas.Columns.Count; i++)
                    {
                        hoja.Cell(filaInicioTabla, i + 2).Value = dgvVentas.Columns[i].HeaderText; // Empieza en Columna B
                    }

                    // Filas
                    for (int i = 0; i < dgvVentas.Rows.Count; i++)
                    {
                        // Fecha
                        hoja.Cell(i + filaInicioTabla + 1, 2).Value = dgvVentas.Rows[i].Cells[0].Value?.ToString();

                        // Cantidad de Productos (Como Número)
                        hoja.Cell(i + filaInicioTabla + 1, 3).Value = Convert.ToInt32(dgvVentas.Rows[i].Cells[1].Value);

                        // Total Venta (Como Moneda Real)
                        decimal monto = Convert.ToDecimal(dgvVentas.Rows[i].Cells[2].Value);
                        hoja.Cell(i + filaInicioTabla + 1, 4).Value = monto;
                        hoja.Cell(i + filaInicioTabla + 1, 4).Style.NumberFormat.Format = "$ #,##0.00";
                    }

                    // APLICAR FORMATO DE TABLA AUTOMÁTICA
                    var rangoTabla = hoja.Range(filaInicioTabla, 2, filaInicioTabla + dgvVentas.Rows.Count, 4);
                    var tablaElegante = rangoTabla.CreateTable();
                    tablaElegante.Theme = XLTableTheme.TableStyleLight9; // Estilo limpio azul/gris claro
                    tablaElegante.ShowAutoFilter = false;

                    // Ajustar ancho de columnas automáticamente
                    hoja.Columns().AdjustToContents();

                    wb.SaveAs(savefile.FileName);
                    MessageBox.Show("Reporte Excel ejecutivo generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDescargarPDF_Click(object sender, EventArgs e)
        {
            if (dgvVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos cargados para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog savefile = new SaveFileDialog()
            {
                FileName = $"ReporteVentas_{DateTime.Now:yyyyMMdd}.pdf",
                Filter = "PDF Files|*.pdf"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 40, 40, 40, 40);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // FUENTES
                    iTextSharp.text.Font fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, new BaseColor(30, 40, 60)); // Azul oscuro
                    iTextSharp.text.Font fontSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.GRAY);
                    iTextSharp.text.Font fontCabecera = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.BLACK);
                    iTextSharp.text.Font fontNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);
                    iTextSharp.text.Font fontTotales = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, new BaseColor(30, 40, 60));

                    // CABECERA
                    PdfPTable headerTable = new PdfPTable(2) { WidthPercentage = 100 };
                    headerTable.SetWidths(new float[] { 1f, 1f });

                    // Si tenés el logo, descomentá esto:
                    // string rutaLogo = Path.Combine(Application.StartupPath, "Resources", "logo.png");
                    // iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaLogo);
                    // logo.ScaleToFit(80f, 80f);
                    // PdfPCell celdaLogo = new PdfPCell(logo) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_LEFT };

                    // Como no tenemos logo ahora, ponemos el nombre
                    PdfPCell celdaLogo = new PdfPCell(new Phrase("THE B-SIDE", fontTitulo)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_LEFT };

                    PdfPCell celdaTitulo = new PdfPCell(new Phrase("REPORTE DE VENTAS", fontTitulo)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT };

                    headerTable.AddCell(celdaLogo);
                    headerTable.AddCell(celdaTitulo);
                    pdfDoc.Add(headerTable);

                    pdfDoc.Add(new Paragraph($"Período: {dtpFechaInicio.Value:dd/MM/yyyy} al {dtpFechaFin.Value:dd/MM/yyyy}", fontSubtitulo) { Alignment = Element.ALIGN_RIGHT });
                    pdfDoc.Add(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, BaseColor.LIGHT_GRAY, Element.ALIGN_CENTER, -1)));
                    pdfDoc.Add(new Paragraph(" "));

                    // RESUMEN EJECUTIVO (Tarjetas)
                    PdfPTable tablaResumen = new PdfPTable(3) { WidthPercentage = 100 };
                    tablaResumen.AddCell(new PdfPCell(new Phrase("VENTAS TOTALES\n" + textCantVentas.Text, fontTotales)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_CENTER, Padding = 10, BackgroundColor = new BaseColor(245, 245, 250) });
                    tablaResumen.AddCell(new PdfPCell(new Phrase("PRODUCTOS\n" + textProductosVendidos.Text, fontTotales)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_CENTER, Padding = 10, BackgroundColor = new BaseColor(245, 245, 250) });
                    tablaResumen.AddCell(new PdfPCell(new Phrase("INGRESOS\n" + textIngresos.Text, fontTotales)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_CENTER, Padding = 10, BackgroundColor = new BaseColor(245, 245, 250) });
                    pdfDoc.Add(tablaResumen);
                    pdfDoc.Add(new Paragraph(" "));

                    // TABLA PRINCIPAL
                    PdfPTable pTable = new PdfPTable(dgvVentas.Columns.Count) { WidthPercentage = 100 };

                    // Encabezados
                    foreach (DataGridViewColumn col in dgvVentas.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, fontCabecera))
                        {
                            BackgroundColor = new BaseColor(230, 230, 230),
                            BorderColor = BaseColor.LIGHT_GRAY,
                            Padding = 6,
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        pTable.AddCell(pCell);
                    }

                    // Filas con efecto Zebra
                    bool fondoGris = false;
                    foreach (DataGridViewRow row in dgvVentas.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            PdfPCell pCell = new PdfPCell(new Phrase(cell.Value?.ToString(), fontNormal))
                            {
                                BorderColor = BaseColor.LIGHT_GRAY,
                                Padding = 5,
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                BackgroundColor = fondoGris ? new BaseColor(250, 250, 250) : BaseColor.WHITE
                            };
                            pTable.AddCell(pCell);
                        }
                        fondoGris = !fondoGris;
                    }

                    pdfDoc.Add(pTable);
                    pdfDoc.Add(new Paragraph(" "));
                    pdfDoc.Add(new Paragraph($"Generado el: {DateTime.Now:dd/MM/yyyy HH:mm}", fontSubtitulo));

                    pdfDoc.Close();
                    stream.Close();

                    MessageBox.Show("Reporte PDF ejecutivo generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            DateTime desde = dtpFechaInicio.Value.Date;
            DateTime hasta = dtpFechaFin.Value.Date;

            if (desde > hasta)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha fin.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarVentas(desde, hasta);
        }
    }
}