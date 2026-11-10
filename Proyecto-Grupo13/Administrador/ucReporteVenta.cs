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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Proyecto_Grupo13.Administrador
{
    public partial class ucReporteVenta : UserControl
    {
        private DateTime? filtroDesde = null;
        private DateTime? filtroHasta = null;
        private string filtroTexto = ""; // Variable para almacenar el texto de búsqueda ingresado
        private string filtroCriterio = ""; // Variable para almacenar el criterio de búsqueda seleccionado
        public ucReporteVenta()
        {
            InitializeComponent();
            // Las fechas solo filtran si el casillero del selector está tildado
            dtpInicio.ShowCheckBox = true;
            dtpInicio.Checked = false;
            dtpFin.ShowCheckBox = true;
            dtpFin.Checked = false;

            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.ReadOnly = true;
            dgvVentas.MultiSelect = false;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.ReadOnly = true;
            panelDetalle.Visible = false;   // se muestra cuando se hace click en una venta

            comboBoxBuscar.Items.Clear();
            comboBoxBuscar.Items.AddRange(new object[] { "N° Venta", "Vendedor", "DNI Cliente" });
            comboBoxBuscar.SelectedIndex = 0;

            cargarVentas();
        }
        private void cargarVentas()
        {
            // Evita consultar la base cuando Visual Studio dibuja el control en el diseñador
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            // Fechas: se filtran en la base. Texto: se filtra acá.
            List<Venta> ventas = new CL_Venta().ListarTodasLasVentas(filtroDesde, filtroHasta);
            MostrarVentas(FiltrarPorTexto(ventas));
        }
        private List<Venta> FiltrarPorTexto(List<Venta> ventas)
        {
            if (string.IsNullOrWhiteSpace(filtroTexto)) return ventas;

            switch (filtroCriterio)
            {
                case "N° Venta":
                    int numero;
                    if (!int.TryParse(filtroTexto, out numero)) return new List<Venta>();
                    return ventas.Where(v => v.id_venta == numero).ToList();

                case "DNI Cliente":
                    return ventas.Where(v => v.cliente.dni.ToString().Contains(filtroTexto)).ToList();

                case "Vendedor":
                    // Ignora mayúsculas y tildes; acepta varias palabras ("lucas lopez")
                    string[] palabras = Normalizar(filtroTexto)
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    return ventas.Where(v =>
                    {
                        string nombre = Normalizar(v.usuario.nombre + " " + v.usuario.apellido);
                        return palabras.All(w => nombre.Contains(w));
                    }).ToList();
            }

            return ventas;
        }
        // Pasa a mayúsculas y le saca las tildes: "Ángel" -> "ANGEL"
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

        private void MostrarVentas(List<Venta> ventas)
        {
            dgvVentas.Rows.Clear();
            //decimal totalVentas = 0;

            foreach (Venta v in ventas)
            {
                // Orden de columnas: N° Venta | Fecha | Vendedor | Cliente | Total | Ver
                int n = dgvVentas.Rows.Add(
                    v.id_venta.ToString("000000"),
                    v.fechaCreacion.ToString("dd/MM/yyyy HH:mm"),
                    v.usuario.nombre + " " + v.usuario.apellido,
                    v.cliente.nombre + " " + v.cliente.apellido,
                    v.montoPago.ToString("0.00"),
                    "Ver");

                dgvVentas.Rows[n].Tag = v;   // guardamos la venta completa en la fila
            }

            lMontoTotal.Text = ventas.Count.ToString();   // cantidad de ventas realizadas
            LimpiarDetalle();
        }

        private void LimpiarDetalle()
        {
            label.Text = "N° Venta:";
            label7.Text = "Fecha:";
            label8.Text = "Vendedor:";
            label9.Text = "Cliente:";
            label10.Text = "DNI:";
            label2.Text = "Total:";
            label11.Text = "Método de Pago:";
            dgvDetalle.Rows.Clear();
            panelDetalle.Visible = false;
        }

        private void iconBtnBuscar_Click(object sender, EventArgs e)
        {
            DateTime? desde = dtpInicio.Checked ? dtpInicio.Value.Date : (DateTime?)null;
            DateTime? hasta = dtpFin.Checked ? dtpFin.Value.Date : (DateTime?)null;

            if (desde.HasValue && hasta.HasValue && desde > hasta)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha fin.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string texto = textBuscar.Text.Trim();

            if (comboBoxBuscar.Text == "N° Venta" && texto != "" && !int.TryParse(texto, out _))
            {
                MessageBox.Show("Ingrese un número de venta válido.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            filtroDesde = desde;
            filtroHasta = hasta;
            filtroCriterio = comboBoxBuscar.Text;
            filtroTexto = texto;

            cargarVentas();

            if (dgvVentas.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron ventas con esos criterios.",
                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iconBtnLimpiar_Click(object sender, EventArgs e)
        {
            dtpInicio.Value = DateTime.Today;
            dtpInicio.Checked = false;
            dtpFin.Value = DateTime.Today;
            dtpFin.Checked = false;

            comboBoxBuscar.SelectedIndex = 0;
            textBuscar.Clear();

            filtroDesde = null;
            filtroHasta = null;
            filtroCriterio = "";
            filtroTexto = "";

            cargarVentas();
        }

        private void textBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;   // evita el "beep" de Windows
                iconBtnBuscar_Click(sender, EventArgs.Empty);
            }
        }
        private void textBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;

            if (comboBoxBuscar.Text == "Vendedor")
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
            }
            else
            {
                if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            }
        }

        private void comboBoxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBuscar.Clear();
        }
        private void ucReporteVenta_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible) cargarVentas();
        }

        //detalle de una venta
        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Venta v = dgvVentas.Rows[e.RowIndex].Tag as Venta;
            if (v == null) return;

            panelDetalle.Visible = true;
            lblNumVenta.Text = v.id_venta.ToString("000000");
            lblFecha.Text = v.fechaCreacion.ToString("dd/MM/yyyy HH:mm");
            lblVendedor.Text = v.usuario.nombre + " " + v.usuario.apellido;
            lblCliente.Text = v.cliente.nombre + " " + v.cliente.apellido;
            lblDNI.Text = v.cliente.dni.ToString();
            lblTotalDetalle.Text = "$" + v.montoPago.ToString("0.00");
            lblMetodoPago.Text = v.metodoPago.descripcion;

            dgvDetalle.Rows.Clear();
            foreach (DetalleVenta d in new CL_Venta().ObtenerDetalleVenta(v.id_venta))
            {
                // Orden: Nombre Producto | Cantidad | Precio | SubTotal
                dgvDetalle.Rows.Add(
                    d.producto.nombreProducto,
                    d.cantidad,
                    d.precioUnitario.ToString("0.00"),
                    d.subtotal.ToString("0.00"));
            }

        }

        private void btnDescargarPdf_Click(object sender, EventArgs e)
        {
            // Validar que haya productos en el detalle cargado
            if (dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Seleccione una venta para exportar su detalle a PDF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Diálogo para guardar el archivo
            SaveFileDialog savefile = new SaveFileDialog()
            {
                FileName = $"Ticket_Venta_{lblNumVenta.Text.Replace("N° Venta:", "").Trim()}_{DateTime.Now:yyyyMMdd}.pdf",
                Filter = "PDF Files|*.pdf"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    // Tamaño formato Ticket Térmico 80mm (226pt de ancho)[cite: 4]
                    iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(226f, 600f);
                    Document pdfDoc = new Document(pageSize, 10f, 10f, 10f, 10f);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Fuentes Courier estilo recibo
                    iTextSharp.text.Font fontTitulo = FontFactory.GetFont(FontFactory.COURIER_BOLD, 12, BaseColor.BLACK);
                    iTextSharp.text.Font fontSubtitulo = FontFactory.GetFont(FontFactory.COURIER_BOLD, 9, BaseColor.BLACK);
                    iTextSharp.text.Font fontNormal = FontFactory.GetFont(FontFactory.COURIER, 8, BaseColor.BLACK);
                    iTextSharp.text.Font fontNegrita = FontFactory.GetFont(FontFactory.COURIER_BOLD, 8, BaseColor.BLACK);

                    // 1. CABECERA CON MARCA
                    pdfDoc.Add(new Paragraph("THE B-SIDE", fontTitulo) { Alignment = Element.ALIGN_CENTER });
                    pdfDoc.Add(new Paragraph("TICKET DE VENTA", fontSubtitulo) { Alignment = Element.ALIGN_CENTER });
                    pdfDoc.Add(new Paragraph("--------------------------------", fontNormal) { Alignment = Element.ALIGN_CENTER });

                    // 2. INFORMACIÓN DE LA VENTA
                    pdfDoc.Add(new Paragraph($"{lblNumVenta.Text}", fontNormal));
                    pdfDoc.Add(new Paragraph($"{lblFecha.Text}", fontNormal));
                    pdfDoc.Add(new Paragraph($"{lblVendedor.Text}", fontNormal));
                    pdfDoc.Add(new Paragraph($"{lblCliente.Text}", fontNormal));
                    if (!string.IsNullOrEmpty(lblDNI.Text))
                    {
                        pdfDoc.Add(new Paragraph($"{lblDNI.Text}", fontNormal));
                    }
                    pdfDoc.Add(new Paragraph("--------------------------------", fontNormal) { Alignment = Element.ALIGN_CENTER });

                    // 3. TABLA DE DETALLE DE PRODUCTOS (4 Columnas)
                    PdfPTable tablaDetalle = new PdfPTable(4) { WidthPercentage = 100 };
                    tablaDetalle.SetWidths(new float[] { 3f, 1f, 1.5f, 1.5f }); // Proporciones de columnas

                    // Encabezados sin bordes
                    tablaDetalle.AddCell(new PdfPCell(new Phrase("Producto", fontNegrita)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    tablaDetalle.AddCell(new PdfPCell(new Phrase("Cant", fontNegrita)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_CENTER });
                    tablaDetalle.AddCell(new PdfPCell(new Phrase("Precio", fontNegrita)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                    tablaDetalle.AddCell(new PdfPCell(new Phrase("SubTotal", fontNegrita)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

                    // Filas provenientes de dgvDetalle
                    foreach (DataGridViewRow row in dgvDetalle.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string prod = row.Cells[0].Value?.ToString() ?? "";
                        string cant = row.Cells[1].Value?.ToString() ?? "";
                        string prec = row.Cells[2].Value?.ToString() ?? "";
                        string subt = row.Cells[3].Value?.ToString() ?? "";

                        tablaDetalle.AddCell(new PdfPCell(new Phrase(prod, fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                        tablaDetalle.AddCell(new PdfPCell(new Phrase(cant, fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_CENTER });
                        tablaDetalle.AddCell(new PdfPCell(new Phrase(prec, fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                        tablaDetalle.AddCell(new PdfPCell(new Phrase(subt, fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                    }

                    pdfDoc.Add(tablaDetalle);
                    pdfDoc.Add(new Paragraph("--------------------------------", fontNormal) { Alignment = Element.ALIGN_CENTER });

                    // 4. TOTAL Y MÉTODO DE PAGO
                    PdfPTable tablaTotales = new PdfPTable(2) { WidthPercentage = 100 };
                    tablaTotales.SetWidths(new float[] { 1.5f, 2f });

                    tablaTotales.AddCell(new PdfPCell(new Phrase(lblMetodoPago.Text, fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    tablaTotales.AddCell(new PdfPCell(new Phrase(lblTotalDetalle.Text, fontTitulo)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

                    pdfDoc.Add(tablaTotales);
                    pdfDoc.Add(new Paragraph("--------------------------------", fontNormal) { Alignment = Element.ALIGN_CENTER });

                    // 5. PIE
                    pdfDoc.Add(new Paragraph("¡GRACIAS POR SU COMPRA!", fontSubtitulo) { Alignment = Element.ALIGN_CENTER });

                    pdfDoc.Close();
                    stream.Close();

                    MessageBox.Show("Ticket PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void iconBtnExcel_Click(object sender, EventArgs e)
        {
            // 1. Verificar que exista una venta seleccionada
            DataGridViewRow rowVenta = dgvVentas.CurrentRow;

            if (rowVenta == null || rowVenta.IsNewRow)
            {
                MessageBox.Show(
                    "Seleccione una venta para exportar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 2. Verificar que existan detalles cargados
            if (dgvDetalle.Rows.Cast<DataGridViewRow>()
                .All(f => f.IsNewRow))
            {
                MessageBox.Show(
                    "La venta seleccionada no tiene detalles para exportar.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // 3. Diálogo para guardar el Excel
            SaveFileDialog savefile = new SaveFileDialog()
            {
                FileName = $"Reporte_Venta_{DateTime.Now:yyyyMMdd}.xlsx",
                Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var hoja = wb.Worksheets.Add("Reporte de Ventas");

                        // ==========================================
                        // 4. TÍTULO Y PERÍODO DEL REPORTE
                        // ==========================================

                        hoja.Range("A1:I1").Merge();
                        hoja.Cell("A1").Value = "THE B-SIDE - REPORTE GENERAL DE VENTAS";

                        hoja.Cell("A1").Style.Font.Bold = true;
                        hoja.Cell("A1").Style.Font.FontSize = 16;
                        hoja.Cell("A1").Style.Font.FontColor = XLColor.White;
                        hoja.Cell("A1").Style.Fill.BackgroundColor =
                            XLColor.FromHtml("#1E283C");

                        hoja.Cell("A1").Style.Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Center;

                        hoja.Cell("A1").Style.Alignment.Vertical =
                            XLAlignmentVerticalValues.Center;

                        hoja.Row(1).Height = 30;

                        // Período seleccionado
                        hoja.Range("A2:I2").Merge();

                        hoja.Cell("A2").Value =
                            $"Período: {dtpInicio.Value:dd/MM/yyyy} al {dtpFin.Value:dd/MM/yyyy}";

                        hoja.Cell("A2").Style.Font.Italic = true;
                        hoja.Cell("A2").Style.Font.FontColor = XLColor.Gray;
                        hoja.Cell("A2").Style.Font.FontSize = 11;

                        // ==========================================
                        // 5. ENCABEZADOS DE LA TABLA
                        // ==========================================

                        string[] encabezados =
                        {
                    "N° Venta",
                    "Fecha",
                    "Vendedor",
                    "Cliente",
                    "Total Venta",
                    "Nombre Producto",
                    "Cantidad",
                    "Precio",
                    "SubTotal"
                };

                        for (int i = 0; i < encabezados.Length; i++)
                        {
                            hoja.Cell(4, i + 1).Value = encabezados[i];
                        }

                        // ==========================================
                        // 6. OBTENER DATOS GENERALES DE LA VENTA
                        // ==========================================

                        string numVenta =
                            rowVenta.Cells[0].FormattedValue?.ToString() ?? "";

                        string fecha =
                            rowVenta.Cells[1].FormattedValue?.ToString() ?? "";

                        string vendedor =
                            rowVenta.Cells[2].FormattedValue?.ToString() ?? "";

                        string cliente =
                            rowVenta.Cells[3].FormattedValue?.ToString() ?? "";

                        string totalTexto =
                            rowVenta.Cells[4].FormattedValue?.ToString() ?? "";

                        int filaExcel = 5;

                        // ==========================================
                        // 7. RECORRER LOS DETALLES DE LA VENTA
                        // ==========================================

                        foreach (DataGridViewRow rowDetalle in dgvDetalle.Rows)
                        {
                            if (rowDetalle.IsNewRow)
                                continue;

                            // Datos del producto
                            string nombreProducto =
                                rowDetalle.Cells[0].FormattedValue?.ToString() ?? "";

                            string cantidad =
                                rowDetalle.Cells[1].FormattedValue?.ToString() ?? "";

                            string precioTexto =
                                rowDetalle.Cells[2].FormattedValue?.ToString() ?? "";

                            string subtotalTexto =
                                rowDetalle.Cells[3].FormattedValue?.ToString() ?? "";

                            // Repetimos los datos generales de la venta
                            hoja.Cell(filaExcel, 1).Value = numVenta;
                            hoja.Cell(filaExcel, 2).Value = fecha;
                            hoja.Cell(filaExcel, 3).Value = vendedor;
                            hoja.Cell(filaExcel, 4).Value = cliente;

                            // Total de la venta
                            if (decimal.TryParse(totalTexto,
                                System.Globalization.NumberStyles.Any,
                                System.Globalization.CultureInfo.InvariantCulture,
                                out decimal totalVenta))
                            {
                                hoja.Cell(filaExcel, 5).Value = totalVenta;
                                hoja.Cell(filaExcel, 5).Style.NumberFormat.Format =
                                    "$ #,##0.00";
                            }
                            else
                            {
                                hoja.Cell(filaExcel, 5).Value = totalTexto;
                            }

                            // Información del producto
                            hoja.Cell(filaExcel, 6).Value = nombreProducto;

                            if (int.TryParse(cantidad, out int cant))
                            {
                                hoja.Cell(filaExcel, 7).Value = cant;
                            }
                            else
                            {
                                hoja.Cell(filaExcel, 7).Value = cantidad;
                            }

                            // Precio unitario
                            if (decimal.TryParse(precioTexto,
                                System.Globalization.NumberStyles.Any,
                                System.Globalization.CultureInfo.InvariantCulture,
                                out decimal precio))
                            {
                                hoja.Cell(filaExcel, 8).Value = precio;
                                hoja.Cell(filaExcel, 8).Style.NumberFormat.Format =
                                    "$ #,##0.00";
                            }
                            else
                            {
                                hoja.Cell(filaExcel, 8).Value = precioTexto;
                            }

                            // Subtotal del producto
                            if (decimal.TryParse(subtotalTexto,
                                System.Globalization.NumberStyles.Any,
                                System.Globalization.CultureInfo.InvariantCulture,
                                out decimal subtotal))
                            {
                                hoja.Cell(filaExcel, 9).Value = subtotal;
                                hoja.Cell(filaExcel, 9).Style.NumberFormat.Format =
                                    "$ #,##0.00";
                            }
                            else
                            {
                                hoja.Cell(filaExcel, 9).Value = subtotalTexto;
                            }

                            filaExcel++;
                        }

                        // ==========================================
                        // 8. APLICAR DISEÑO A LA TABLA
                        // ==========================================

                        var rangoDatos = hoja.Range(4, 1, filaExcel - 1, 9);

                        var tabla = rangoDatos.CreateTable();

                        tabla.Theme = XLTableTheme.TableStyleMedium9;
                        tabla.ShowAutoFilter = true;

                        // Ajustar columnas al contenido
                        hoja.Columns().AdjustToContents();

                        // Ancho mínimo para evitar columnas demasiado pequeñas
                        hoja.Column(6).Width = Math.Max(hoja.Column(6).Width, 22);

                        // Centrar cantidades
                        hoja.Column(7).Style.Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Center;

                        // Alinear importes
                        hoja.Range(5, 5, filaExcel - 1, 5)
                            .Style.Alignment.Horizontal =
                            XLAlignmentHorizontalValues.Right;

                        // Congelar encabezados
                        hoja.SheetView.FreezeRows(4);

                        // Configurar impresión horizontal
                        hoja.PageSetup.PageOrientation =
                            XLPageOrientation.Landscape;

                        hoja.PageSetup.FitToPages(1, 0);

                        // ==========================================
                        // 9. GUARDAR ARCHIVO
                        // ==========================================

                        wb.SaveAs(savefile.FileName);

                        MessageBox.Show(
                            "Reporte Excel generado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"Ocurrió un error al exportar: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}
