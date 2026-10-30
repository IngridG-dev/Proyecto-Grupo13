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
            // 1. Validar que la grilla tenga registros cargados
            if (dgvVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos cargados en la grilla para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Diálogo para guardar el archivo Excel
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
                        var hoja = wb.Worksheets.Add("Reporte de Ventas");

                        // --- CABECERA DE LA EMPRESA ---
                        hoja.Range("B2:E2").Merge().Value = "THE B-SIDE - REPORTE GENERAL DE VENTAS";
                        hoja.Cell("B2").Style.Font.Bold = true;
                        hoja.Cell("B2").Style.Font.FontSize = 14;
                        hoja.Cell("B2").Style.Font.FontColor = XLColor.FromHtml("#1E283C"); // Azul noche / Gris oscuro

                        hoja.Cell("B3").Value = $"Período: {dtpInicio.Value:dd/MM/yyyy} al {dtpFin.Value:dd/MM/yyyy}";
                        hoja.Cell("B3").Style.Font.Italic = true;
                        hoja.Cell("B3").Style.Font.FontColor = XLColor.Gray;

                        // --- TABLA DE VENTAS (Comienza en fila 5, Columna B) ---
                        int filaInicio = 5;
                        int colInicio = 2;

                        // A. Encabezados de las columnas (excluyendo la columna 'Ver' si existe)
                        int colIndex = colInicio;
                        for (int i = 0; i < dgvVentas.Columns.Count; i++)
                        {
                            // Ocultar columnas con botones o irrelevantes (ej: botón "Ver")
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

                                // Mapear tipos de datos para que Excel aplique formatos correctos
                                if (valor != null)
                                {
                                    string nombreColumna = dgvVentas.Columns[j].HeaderText.ToLower();

                                    if (nombreColumna.Contains("total") || nombreColumna.Contains("monto") || nombreColumna.Contains("precio"))
                                    {
                                        if (decimal.TryParse(valor.ToString().Replace("$", "").Trim(), out decimal monto))
                                        {
                                            celda.Value = monto;
                                            celda.Style.NumberFormat.Format = "$ #,##0.00"; // Formato Moneda
                                        }
                                        else
                                        {
                                            celda.Value = valor.ToString();
                                        }
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

                        // --- ESTILO DE TABLA ELEGANTE ---
                        int totalFilas = filaActual - 1;
                        int totalColumnas = colIndex - 1;

                        if (totalFilas >= filaInicio)
                        {
                            var rangoTabla = hoja.Range(filaInicio, colInicio, totalFilas, totalColumnas);
                            var tablaElegante = rangoTabla.CreateTable();
                            tablaElegante.Theme = XLTableTheme.TableStyleLight9; // Estilo limpio en tonos grises/azules
                            tablaElegante.ShowAutoFilter = true; // Activa filtros automáticos
                        }

                        // Autoajustar ancho de las columnas
                        hoja.Columns().AdjustToContents();

                        // Guardar archivo
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte de ventas exportado a Excel correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error al exportar a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
