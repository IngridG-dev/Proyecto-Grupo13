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
                    
                    // 1. CABECERA DEL NEGOCIO
                    iTextSharp.text.Font fontEslogan = FontFactory.GetFont(
                        FontFactory.COURIER_BOLD, 8, BaseColor.BLACK);

                    pdfDoc.Add(new Paragraph("THE B-SIDE", fontTitulo)
                    {
                        Alignment = Element.ALIGN_CENTER
                    });

                    pdfDoc.Add(new Paragraph("MUSICA QUE TE ACOMPANA", fontEslogan)
                    {
                        Alignment = Element.ALIGN_CENTER
                    });

                    pdfDoc.Add(new Paragraph(
                        "Venta de CDs - Vinilos - Reproductores", fontNormal)
                    {
                        Alignment = Element.ALIGN_CENTER
                    });

                    pdfDoc.Add(new Paragraph(
                        "Direccion: 9 de Julio 1234", fontNormal)
                    {
                        Alignment = Element.ALIGN_CENTER
                    });

                    pdfDoc.Add(new Paragraph(
                        "Telefono: 379 123 4567", fontNormal)
                    {
                        Alignment = Element.ALIGN_CENTER
                    });

                    pdfDoc.Add(new Paragraph(
                        "Instagram: @thebside", fontNormal)
                    {
                        Alignment = Element.ALIGN_CENTER
                    });

                    pdfDoc.Add(new Paragraph("--------------------------------", fontNormal)
                    {
                        Alignment = Element.ALIGN_CENTER
                    });

                    pdfDoc.Add(new Paragraph("TICKET DE VENTA", fontSubtitulo)
                    {
                        Alignment = Element.ALIGN_CENTER
                    });

                    // 2. INFORMACIÓN DE LA VENTA
                    pdfDoc.Add(new Paragraph($"Numero de venta: {lblNumVenta.Text}", fontNormal));
                    pdfDoc.Add(new Paragraph($"Fecha: {lblFecha.Text}", fontNormal));
                    pdfDoc.Add(new Paragraph($"Vendedor: {lblVendedor.Text}", fontNormal));
                    pdfDoc.Add(new Paragraph($"Cliente: {lblCliente.Text}", fontNormal));
                    if (!string.IsNullOrEmpty(lblDNI.Text))
                    {
                        pdfDoc.Add(new Paragraph($"DNI: {lblDNI.Text}", fontNormal));
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

                    tablaTotales.AddCell(new PdfPCell(new Phrase("Metodo de pago: " + lblMetodoPago.Text, fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    tablaTotales.AddCell(new PdfPCell(new Phrase("Total: " + lblTotalDetalle.Text, fontTitulo)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

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
            if (dgvVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay ventas cargadas para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog savefile = new SaveFileDialog()
            {
                FileName = $"Reporte_Ventas_Detallado_{DateTime.Now:yyyyMMdd_HHmm}.xlsx",
                Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var hoja = wb.Worksheets.Add("Reporte de Ventas");

                        // --- CABECERA ESTÉTICA ---
                        hoja.Range("B2:J2").Merge().Value = "THE B-SIDE - REPORTE DETALLADO DE VENTAS";
                        hoja.Cell("B2").Style.Font.Bold = true;
                        hoja.Cell("B2").Style.Font.FontSize = 15;
                        hoja.Cell("B2").Style.Font.FontColor = XLColor.FromHtml("#1E283C");

                        string textoPeriodo = (filtroDesde.HasValue && filtroHasta.HasValue)
                            ? $"{filtroDesde.Value:dd/MM/yyyy} al {filtroHasta.Value:dd/MM/yyyy}"
                            : "Todas las ventas históricas";

                        hoja.Cell("B3").Value = $"Período: {textoPeriodo}";
                        hoja.Cell("B3").Style.Font.Italic = true;
                        hoja.Cell("B3").Style.Font.FontColor = XLColor.DimGray;

                        hoja.Cell("B4").Value = $"Total de Ventas listadas: {lMontoTotal.Text}";
                        hoja.Cell("B4").Style.Font.Bold = true;

                        // --- TABLA DE DATOS ---
                        int filaInicio = 6;
                        int colInicio = 2; // Empezamos en la columna B

                        // Encabezados fusionados
                        string[] encabezados = { "N° Venta", "Fecha", "Vendedor", "Cliente", "Total Venta", "Producto", "Cantidad", "Precio Unitario", "SubTotal" };
                        for (int i = 0; i < encabezados.Length; i++)
                        {
                            hoja.Cell(filaInicio, colInicio + i).Value = encabezados[i];
                        }

                        int filaActual = filaInicio + 1;

                        // Recorremos solo las ventas visibles en la grilla principal
                        foreach (DataGridViewRow rowVenta in dgvVentas.Rows)
                        {
                            if (rowVenta.IsNewRow || !rowVenta.Visible) continue;

                            Venta v = (Venta)rowVenta.Tag;
                            if (v == null) continue;

                            // Buscamos el detalle de esta venta en la BD
                            List<DetalleVenta> detalle = new CL_Venta().ObtenerDetalleVenta(v.id_venta);

                            // Por cada producto, imprimimos una fila en Excel
                            foreach (DetalleVenta item in detalle)
                            {
                                // 1. Datos estáticos de la venta
                                hoja.Cell(filaActual, colInicio).Value = v.id_venta.ToString("000000");
                                hoja.Cell(filaActual, colInicio + 1).Value = v.fechaCreacion.ToString("dd/MM/yyyy HH:mm");
                                hoja.Cell(filaActual, colInicio + 2).Value = v.usuario.nombre + " " + v.usuario.apellido;
                                hoja.Cell(filaActual, colInicio + 3).Value = v.cliente.nombre + " " + v.cliente.apellido;

                                hoja.Cell(filaActual, colInicio + 4).Value = v.montoPago;
                                hoja.Cell(filaActual, colInicio + 4).Style.NumberFormat.Format = "$ #,##0.00";

                                // 2. Datos dinámicos del producto
                                hoja.Cell(filaActual, colInicio + 5).Value = item.producto.nombreProducto;
                                hoja.Cell(filaActual, colInicio + 6).Value = item.cantidad;

                                hoja.Cell(filaActual, colInicio + 7).Value = item.precioUnitario;
                                hoja.Cell(filaActual, colInicio + 7).Style.NumberFormat.Format = "$ #,##0.00";

                                hoja.Cell(filaActual, colInicio + 8).Value = item.subtotal;
                                hoja.Cell(filaActual, colInicio + 8).Style.NumberFormat.Format = "$ #,##0.00";

                                filaActual++;
                            }
                        }

                        // --- FORMATO DE TABLA AUTOMÁTICA ---
                        if (filaActual > filaInicio + 1)
                        {
                            var rangoTabla = hoja.Range(filaInicio, colInicio, filaActual - 1, colInicio + 8);
                            var tablaElegante = rangoTabla.CreateTable();
                            tablaElegante.Theme = XLTableTheme.TableStyleLight9;
                            tablaElegante.ShowAutoFilter = true;
                        }

                        hoja.Columns().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Excel detallado generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
