using CapaEntidad;
using CapaLogica;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Grupo13.Vendedor
{
    public partial class ucDetalleVenta : UserControl
    {
        //filtro de fechas actual (null = sin filtro, tiene todas las ventas)
        private DateTime? filtroDesde = null;
        private DateTime? filtroHasta = null;
        public ucDetalleVenta()
        {
            InitializeComponent();

            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.ReadOnly = true;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.MultiSelect = false;
            // Al iniciar, ocultamos el comprobante
            panelTicket.Visible = false;

            cargarVentas();
            configDGDetalle();

        }

        // ============================================================
        // VENTAS DEL VENDEDOR
        // ============================================================
        private void cargarVentas()
        {
            dgvVentas.Rows.Clear();
            panelTicket.Visible = false;

            if (SesionActual.usuarioLogueado == null)
                return;
            List<Venta> ventas = new CL_Venta().ListarVentasPorUsuario(SesionActual.usuarioLogueado.id_usuario, filtroDesde, filtroHasta);
            foreach (Venta v in ventas)
            {
                int n = dgvVentas.Rows.Add(
                    v.id_venta.ToString("000000"),
                    v.fechaCreacion.ToString("dd/MM/yyyy HH:mm:ss"),
                    v.cliente.nombre + " " + v.cliente.apellido,
                    v.cliente.dni.ToString(),
                    v.montoPago.ToString("0.00"),
                    "Ver"
                    );
                dgvVentas.Rows[n].Tag = v; // Guardamos el objeto Venta en la propiedad Tag de la fila
            }
            textNumVentas.Text = ventas.Count.ToString();
            textVendedor.Text = SesionActual.usuarioLogueado.nombre + " " + SesionActual.usuarioLogueado.apellido;
        }

        // Crea las columnas de la grilla chica del comprobante si el diseñador no las tiene
        private void configDGDetalle()
        {
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.ReadOnly = true;

            if (dataGridView2.Columns.Count == 0)
            {
                dataGridView2.Columns.Add("Producto", "Producto");
                dataGridView2.Columns.Add("Cantidad", "Cantidad");
                dataGridView2.Columns.Add("Precio", "Precio");
                dataGridView2.Columns.Add("Subtotal", "Subtotal");
            }
        }

        // ============================================================
        // Filtro de fechas
        // ============================================================
        private void CargarProductosPrueba()
        {
            if (dataGridView2.Columns.Count == 0)
            {
                dataGridView2.Columns.Add("Producto", "Producto");
                dataGridView2.Columns.Add("Cantidad", "Cantidad");
                dataGridView2.Columns.Add("Precio", "Precio");
                dataGridView2.Columns.Add("Subtotal", "Subtotal");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;
            if (desde > hasta)
            {
                MessageBox.Show("La fecha desde no puede ser posterior a la fecha hasta.");
                return;
            }
            filtroDesde = desde;
            filtroHasta = hasta;
            cargarVentas();
            if (dgvVentas.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron ventas en ese rango de fechas.");
            }
        }
        private void btnVerTodas_Click(object sender, EventArgs e)
        {
            filtroDesde = null;
            filtroHasta = null;
            dtpDesde.Value = DateTime.Now;
            dtpHasta.Value = DateTime.Now;
            cargarVentas();
        }
        //Al volver a la pantalla principal, se reinicia la lista (por si se registra una venta nueva)
        private void ucDetalleVenta_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                cargarVentas();
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) 
                return;

            Venta v = dgvVentas.Rows[e.RowIndex].Tag as Venta;
            if (v == null)
                return;
            lNumeroVenta.Text = "N° Venta: " + v.id_venta.ToString("000000");
            lFechaTicket.Text = "Fecha: " + v.fechaCreacion.ToString("dd/MM/yyyy HH:mm:ss");
            lCliente.Text = "Cliente: " + v.cliente.nombre + " " + v.cliente.apellido;
            lDNI.Text = "DNI: " + v.cliente.dni;
            lTotal.Text = "Total: $" + v.montoPago.ToString("0.00");

            // Productos de esa venta
            dataGridView2.Rows.Clear();
            foreach (DetalleVenta d in new CL_Venta().ObtenerDetalleVenta(v.id_venta))
            {
                dataGridView2.Rows.Add(
                    d.producto.nombreProducto,
                    d.cantidad,
                    d.precioUnitario.ToString("0.00"),
                    d.subtotal.ToString("0.00"));
            }

            lDetallePago.Text = "Detalles de Pago:" + Environment.NewLine +
                                "• Método: " + v.metodoPago.descripcion + Environment.NewLine +
                                "• Documento: " + v.tipoDocumento;

            panelTicket.Visible = true;
            panelTicket.BringToFront();
        }

        private void btnDescargarPdf_Click(object sender, EventArgs e)
        {
            // Validar que haya datos en el comprobante
            if (dataGridView2.Rows.Count == 0 || string.IsNullOrEmpty(lNumeroVenta.Text))
            {
                MessageBox.Show("Seleccione una venta de la grilla principal para exportar su comprobante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog savefile = new SaveFileDialog()
            {
                FileName = $"Comprobante_Venta_{lNumeroVenta.Text.Replace("N° Venta:", "").Trim()}.pdf",
                Filter = "PDF Files|*.pdf"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        // 1. TAMAÑO NORMAL A4 (En lugar del ticket angosto)
                        Document pdfDoc = new Document(PageSize.A4, 40, 40, 40, 40);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // 2. FUENTES CON ESTILO CORPORATIVO
                        iTextSharp.text.Font fontTituloGris = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, new BaseColor(30, 40, 60)); // Tu azul oscuro de THE B-SIDE
                        iTextSharp.text.Font fontSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.DARK_GRAY);
                        iTextSharp.text.Font fontCabecera = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.BLACK);
                        iTextSharp.text.Font fontNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);

                        // --- CABECERA PRINCIPAL ---
                        PdfPTable headerTable = new PdfPTable(2) { WidthPercentage = 100 };
                        headerTable.SetWidths(new float[] { 1f, 1f });

                        PdfPCell celdaLogo = new PdfPCell(new Phrase("THE B-SIDE", fontTituloGris)) { Border = iTextSharp.text.Rectangle.NO_BORDER };
                        PdfPCell celdaTitulo = new PdfPCell(new Phrase("COMPROBANTE DE Venta", fontSubtitulo))
                        {
                            Border = iTextSharp.text.Rectangle.NO_BORDER,
                            HorizontalAlignment = Element.ALIGN_RIGHT
                        };

                        headerTable.AddCell(celdaLogo);
                        headerTable.AddCell(celdaTitulo);
                        pdfDoc.Add(headerTable);

                        // Línea separadora gris
                        pdfDoc.Add(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, BaseColor.LIGHT_GRAY, Element.ALIGN_CENTER, -1)));
                        pdfDoc.Add(new Paragraph(" "));

                        // --- INFORMACIÓN DE LA COMPRA (En dos columnas) ---
                        PdfPTable infoTable = new PdfPTable(2) { WidthPercentage = 100 };

                        // Fila 1: N° Venta y Fecha
                        infoTable.AddCell(new PdfPCell(new Phrase($"N° Venta: {lNumeroVenta.Text.Replace("N° Venta:", "").Trim()}", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                        infoTable.AddCell(new PdfPCell(new Phrase($"{lFechaTicket.Text}", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

                        // Fila 2: Proveedor y Vendedor (Usuario/Admin)
                        infoTable.AddCell(new PdfPCell(new Phrase($"Cliente: {lCliente.Text.Replace("Cliente: ", "")}", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });

                        // Obtenemos el nombre del vendedor desde SesionActual
                        string nombreVendedor = SesionActual.usuarioLogueado != null
                            ? SesionActual.usuarioLogueado.nombre + " " + SesionActual.usuarioLogueado.apellido
                            : "Usuario Desconocido";

                        infoTable.AddCell(new PdfPCell(new Phrase($"Vendedor: {nombreVendedor}", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                        pdfDoc.Add(infoTable);
                        pdfDoc.Add(new Paragraph(" "));
                        pdfDoc.Add(new Paragraph(" "));

                        // --- TABLA DE PRODUCTOS ---
                        // Ocupa todo el ancho de la hoja (WidthPercentage = 100)
                        PdfPTable tablaDetalle = new PdfPTable(4) { WidthPercentage = 100 };
                        tablaDetalle.SetWidths(new float[] { 1f, 3f, 1.5f, 1.5f }); // Cantidad, Producto, Precio, SubTotal

                        // Encabezados con fondo gris
                        tablaDetalle.AddCell(new PdfPCell(new Phrase("Cantidad", fontCabecera)) { BackgroundColor = new BaseColor(240, 240, 240), BorderColor = BaseColor.LIGHT_GRAY, Padding = 8, HorizontalAlignment = Element.ALIGN_CENTER });
                        tablaDetalle.AddCell(new PdfPCell(new Phrase("Nombre Producto", fontCabecera)) { BackgroundColor = new BaseColor(240, 240, 240), BorderColor = BaseColor.LIGHT_GRAY, Padding = 8, HorizontalAlignment = Element.ALIGN_CENTER });
                        tablaDetalle.AddCell(new PdfPCell(new Phrase("Precio Compra", fontCabecera)) { BackgroundColor = new BaseColor(240, 240, 240), BorderColor = BaseColor.LIGHT_GRAY, Padding = 8, HorizontalAlignment = Element.ALIGN_CENTER });
                        tablaDetalle.AddCell(new PdfPCell(new Phrase("SubTotal", fontCabecera)) { BackgroundColor = new BaseColor(240, 240, 240), BorderColor = BaseColor.LIGHT_GRAY, Padding = 8, HorizontalAlignment = Element.ALIGN_CENTER });

                        // Recorremos la grilla
                        foreach (DataGridViewRow row in dataGridView2.Rows)
                        {
                            if (row.IsNewRow) continue;

                            string prod = row.Cells[0].Value?.ToString() ?? "";
                            string cant = row.Cells[1].Value?.ToString() ?? "";
                            string prec = row.Cells[2].Value?.ToString() ?? "";
                            string subt = row.Cells[3].Value?.ToString() ?? "";

                            // Celdas de datos con bordes suaves
                            tablaDetalle.AddCell(new PdfPCell(new Phrase(cant, fontNormal)) { BorderColor = BaseColor.LIGHT_GRAY, Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });
                            tablaDetalle.AddCell(new PdfPCell(new Phrase(prod, fontNormal)) { BorderColor = BaseColor.LIGHT_GRAY, Padding = 6, HorizontalAlignment = Element.ALIGN_LEFT });
                            tablaDetalle.AddCell(new PdfPCell(new Phrase(prec, fontNormal)) { BorderColor = BaseColor.LIGHT_GRAY, Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });
                            tablaDetalle.AddCell(new PdfPCell(new Phrase(subt, fontNormal)) { BorderColor = BaseColor.LIGHT_GRAY, Padding = 6, HorizontalAlignment = Element.ALIGN_CENTER });
                        }

                        pdfDoc.Add(tablaDetalle);
                        pdfDoc.Add(new Paragraph(" "));
                        pdfDoc.Add(new Paragraph(" "));

                        // --- TOTAL FINAL ---
                        PdfPTable totalTable = new PdfPTable(1) { WidthPercentage = 100 };

                        // Usamos la misma fuente grande del título para el total, tal como en tu imagen
                        PdfPCell celdaTotal = new PdfPCell(new Phrase($"{lTotal.Text.Replace("TOTAL:", "").Trim()}", fontTituloGris))
                        {
                            Border = iTextSharp.text.Rectangle.NO_BORDER,
                            HorizontalAlignment = Element.ALIGN_RIGHT,
                            PaddingTop = 10
                        };

                        totalTable.AddCell(celdaTotal);
                        pdfDoc.Add(totalTable);

                        pdfDoc.Close();
                        stream.Close();

                        MessageBox.Show("Comprobante PDF normal generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar a PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void iconBtnExcel_Click(object sender, EventArgs e)
        {
            // Validar que la grilla tenga registros cargados
            if (dgvVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos cargados en la grilla para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Diálogo para guardar el archivo Excel
            SaveFileDialog savefile = new SaveFileDialog()
            {
                FileName = $"Reporte_Ventas_{DateTime.Now:yyyyMMdd_HHmm}.xlsx",
                Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var hoja = wb.Worksheets.Add("Mis Ventas");

                        // --- CABECERA DE LA EMPRESA ---
                        hoja.Range("B2:E2").Merge().Value = "THE B-SIDE - REPORTE DE VENTAS";
                        hoja.Cell("B2").Style.Font.Bold = true;
                        hoja.Cell("B2").Style.Font.FontSize = 14;
                        hoja.Cell("B2").Style.Font.FontColor = XLColor.FromHtml("#1E283C"); // Azul oscuro de tu app

                        // Opcional: Mostrar el período si tienes los datepickers
                         hoja.Cell("B3").Value = $"Período: {dtpDesde.Value:dd/MM/yyyy} al {dtpHasta.Value:dd/MM/yyyy}";
                         hoja.Cell("B3").Style.Font.Italic = true;
                         hoja.Cell("B3").Style.Font.FontColor = XLColor.Gray;

                        // --- TABLA DE VENTAS (Comienza en fila 5, Columna B) ---
                        int filaInicio = 5;
                        int colInicio = 2;

                        // A. Encabezados de las columnas (excluyendo la columna 'Ver')
                        int colIndex = colInicio;
                        for (int i = 0; i < dgvVentas.Columns.Count; i++)
                        {
                            // Saltar la columna del botón "Ver" (si se llama así)
                            if (dgvVentas.Columns[i].HeaderText.Equals("Ver", StringComparison.OrdinalIgnoreCase))
                                continue;

                            hoja.Cell(filaInicio, colIndex).Value = dgvVentas.Columns[i].HeaderText;
                            colIndex++;
                        }

                        // B. Cargar Filas de Datos
                        int filaActual = filaInicio + 1;
                        foreach (DataGridViewRow row in dgvVentas.Rows)
                        {
                            if (row.IsNewRow) continue;

                            colIndex = colInicio;
                            for (int j = 0; j < dgvVentas.Columns.Count; j++)
                            {
                                if (dgvVentas.Columns[j].HeaderText.Equals("Ver", StringComparison.OrdinalIgnoreCase))
                                    continue;

                                object valor = row.Cells[j].Value;
                                var celda = hoja.Cell(filaActual, colIndex);

                                if (valor != null)
                                {
                                    string nombreColumna = dgvVentas.Columns[j].HeaderText.ToLower();

                                    if (nombreColumna.Contains("total"))
                                    {
                                        if (decimal.TryParse(valor.ToString().Replace("$", "").Trim(), out decimal monto))
                                        {
                                            celda.Value = monto;
                                            celda.Style.NumberFormat.Format = "$ #,##0.00"; // Formato Moneda
                                        }
                                        else celda.Value = valor.ToString();
                                    }
                                    else if (nombreColumna.Contains("fecha"))
                                    {
                                        celda.Value = valor.ToString();
                                        celda.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                    }
                                    else
                                    {
                                        celda.Value = valor.ToString();
                                    }
                                }
                                colIndex++;
                            }
                            filaActual++;
                        }

                        // --- ESTILO DE TABLA AUTOMÁTICO ---
                        int totalFilas = filaActual - 1;
                        int totalColumnas = colIndex - 1;

                        if (totalFilas >= filaInicio)
                        {
                            var rangoTabla = hoja.Range(filaInicio, colInicio, totalFilas, totalColumnas);
                            var tablaElegante = rangoTabla.CreateTable();
                            tablaElegante.Theme = XLTableTheme.TableStyleLight9;
                            tablaElegante.ShowAutoFilter = true;
                        }

                        hoja.Columns().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte de ventas exportado a Excel correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panelTicket_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
