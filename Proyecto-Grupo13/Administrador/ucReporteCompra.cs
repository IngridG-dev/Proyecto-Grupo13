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

namespace Proyecto_Grupo13.Administrador
{
    public partial class ucReporteCompra : UserControl
    {
        private DateTime? filtroDesde = null;
        private DateTime? filtroHasta = null;
        public ucReporteCompra()
        {
            InitializeComponent();
            dtpFechaInicio.ShowCheckBox = true;
            dtpFechaInicio.Checked = false;
            dtpFechaFin.ShowCheckBox = true;
            dtpFechaFin.Checked = false;
        }
        private void iconBtnBuscar_Click(object sender, EventArgs e)
        {
            DateTime? desde = dtpFechaInicio.Checked ? dtpFechaInicio.Value.Date : (DateTime?)null;
            DateTime? hasta = dtpFechaFin.Checked ? dtpFechaFin.Value.Date : (DateTime?)null;
            if (desde.HasValue && hasta.HasValue && desde > hasta)
            {
                MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha fin.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            filtroDesde = desde;
            filtroHasta = hasta;
            cargarCompras();

            if (dgvCompras.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron compras en ese rango de fechas.",
                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void iconBtnLimpiar_Click(object sender, EventArgs e)
        {

            textBuscar.Clear();
            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaInicio.Checked = false;
            dtpFechaFin.Value = DateTime.Today;
            dtpFechaFin.Checked = false;
            cboBuscarPor.SelectedIndex = 0;
            filtroDesde = null;
            filtroHasta = null;
            cargarCompras();

        }

        private void ucReporteCompra_Load(object sender, EventArgs e)
        {
            // Cargar opciones del combo de búsqueda
            cboBuscarPor.Items.Add("Numero de Compra");
            cboBuscarPor.Items.Add("Proveedor");
            cboBuscarPor.Items.Add("Administrador");
            cboBuscarPor.SelectedIndex = 0;
            gbDetalle.Visible = false;

            cargarCompras();
        }
        private void dgvCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                gbDetalle.Visible = true;

                DataGridViewRow fila = dgvCompras.Rows[e.RowIndex];

                // RECUPERAMOS EL OBJETO COMPRA DESDE EL TAG
                Compra oCompra = (Compra)fila.Tag;

                lblNumCompra.Text = oCompra.numeroCompra;
                lblFecha.Text = Convert.ToDateTime(oCompra.fechaRegistro).ToString("dd/MM/yyyy");
                lblProveedor.Text = oCompra.proveedor.razonSocial;
                lblAdmin.Text = oCompra.usuario.nombre;

                // ASIGNAMOS EL TIPO DE DOCUMENTO AL LABEL CORRESPONDIENTE DE TU DISEÑO:
                tipodoc.Text = oCompra.tipoDocumento; // (Asegúrate de colocar el Name de tu Label)

                List<DetalleCompra> detalle = new CL_Compra().ObtenerDetalleCompra(oCompra.id_compra);
                dgvDetalle.Rows.Clear();
                decimal totalDetalle = 0;

                foreach (DetalleCompra item in detalle)
                {
                    decimal subTotalCalculado = item.precioCompra * item.cantidad;

                    dgvDetalle.Rows.Add(
                        item.cantidad,
                        item.producto.nombreProducto,
                        item.precioCompra.ToString("0.00"),
                        subTotalCalculado.ToString("0.00")
                    );
                    totalDetalle += subTotalCalculado;
                }
                lblTotalDetalle.Text = "$ " + totalDetalle.ToString("0.00");
            }
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltroTexto();
        }

        private void iconBtnExcel_Click(object sender, EventArgs e)
        {
            if (dgvCompras.Rows.Count == 0)
            {
                MessageBox.Show("No hay compras cargadas para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog savefile = new SaveFileDialog()
            {
                FileName = $"Reporte_Compras_{DateTime.Now:yyyyMMdd_HHmm}.xlsx",
                Filter = "Archivos de Excel (*.xlsx)|*.xlsx"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var hoja = wb.Worksheets.Add("Reporte de Compras");

                        // --- CABECERA ESTÉTICA ---
                        hoja.Range("B2:F2").Merge().Value = "THE B-SIDE - REPORTE GENERAL DE COMPRAS";
                        hoja.Cell("B2").Style.Font.Bold = true;
                        hoja.Cell("B2").Style.Font.FontSize = 15;
                        hoja.Cell("B2").Style.Font.FontColor = XLColor.FromHtml("#1E283C"); // Azul oscuro

                        hoja.Cell("B3").Value = $"Período: {ReporteHelper.ObtenerTextoPeriodo(filtroDesde, filtroHasta, dgvCompras, 2, "las compras")}";
                        hoja.Cell("B3").Style.Font.Italic = true;
                        hoja.Cell("B3").Style.Font.FontColor = XLColor.DimGray;

                        hoja.Cell("B4").Value = $"Total de Compras en el período: {lblTotalCompras.Text}";
                        hoja.Cell("B4").Style.Font.Bold = true;

                        // --- TABLA DE DATOS ---
                        int filaInicio = 6;
                        int colInicio = 2; // Empezamos en la columna B por estética
                        int colIndex = colInicio;

                        // Encabezados (Omitimos columnas ocultas como el ID)
                        for (int i = 0; i < dgvCompras.Columns.Count; i++)
                        {
                            if (dgvCompras.Columns[i].Visible)
                            {
                                hoja.Cell(filaInicio, colIndex).Value = dgvCompras.Columns[i].HeaderText;
                                colIndex++;
                            }
                        }

                        // Filas
                        int filaActual = filaInicio + 1;
                        foreach (DataGridViewRow row in dgvCompras.Rows)
                        {
                            if (row.IsNewRow) continue;
                            colIndex = colInicio;

                            for (int j = 0; j < dgvCompras.Columns.Count; j++)
                            {
                                if (!dgvCompras.Columns[j].Visible) continue;

                                object valor = row.Cells[j].Value;
                                var celda = hoja.Cell(filaActual, colIndex);

                                if (valor != null)
                                {
                                    string nombreColumna = dgvCompras.Columns[j].HeaderText.ToLower();

                                    // Formato moneda para la columna Total
                                    if (nombreColumna.Contains("total"))
                                    {
                                        if (decimal.TryParse(valor.ToString().Replace("$", "").Trim(), out decimal monto))
                                        {
                                            celda.Value = monto;
                                            celda.Style.NumberFormat.Format = "$ #,##0.00";
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

                        // --- FORMATO DE TABLA AUTOMÁTICA ---
                        if (filaActual > filaInicio + 1)
                        {
                            var rangoTabla = hoja.Range(filaInicio, colInicio, filaActual - 1, colIndex - 1);
                            var tablaElegante = rangoTabla.CreateTable();
                            tablaElegante.Theme = XLTableTheme.TableStyleLight9; // Tema gris/azul limpio[cite: 2, 4]
                            tablaElegante.ShowAutoFilter = true;
                        }

                        hoja.Columns().AdjustToContents(); // Auto-ajuste perfecto
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Excel generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar a Excel: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDescargarPdf_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0 || string.IsNullOrEmpty(lblNumCompra.Text))
            {
                MessageBox.Show("Seleccione una compra de la grilla principal para exportar su comprobante.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog savefile = new SaveFileDialog()
            {
                FileName = $"Comprobante_Compra_{lblNumCompra.Text}.pdf",
                Filter = "PDF Files|*.pdf"
            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 40, 40, 40, 40);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Definición de fuentes y colores[cite: 4]
                    iTextSharp.text.Font fontTitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18, new BaseColor(30, 40, 60));
                    iTextSharp.text.Font fontSubtitulo = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12, BaseColor.DARK_GRAY);
                    iTextSharp.text.Font fontCabecera = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10, BaseColor.BLACK);
                    iTextSharp.text.Font fontNormal = FontFactory.GetFont(FontFactory.HELVETICA, 10, BaseColor.BLACK);

                    // --- 1. CABECERA ---
                    PdfPTable headerTable = new PdfPTable(2) { WidthPercentage = 100 };
                    headerTable.SetWidths(new float[] { 1f, 1f });

                    PdfPCell celdaLogo = new PdfPCell(new Phrase("THE B-SIDE", fontTitulo)) { Border = iTextSharp.text.Rectangle.NO_BORDER };
                    PdfPCell celdaTitulo = new PdfPCell(new Phrase("COMPROBANTE DE COMPRA", fontSubtitulo))
                    {
                        Border = iTextSharp.text.Rectangle.NO_BORDER,
                        HorizontalAlignment = Element.ALIGN_RIGHT
                    };

                    headerTable.AddCell(celdaLogo);
                    headerTable.AddCell(celdaTitulo);
                    pdfDoc.Add(headerTable);
                    pdfDoc.Add(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, BaseColor.LIGHT_GRAY, Element.ALIGN_CENTER, -1)));
                    pdfDoc.Add(new Paragraph(" "));

                    // --- 2. INFORMACIÓN DE LA COMPRA ---
                    PdfPTable infoTable = new PdfPTable(2) { WidthPercentage = 100 };
                    infoTable.AddCell(new PdfPCell(new Phrase($"N° Compra: {lblNumCompra.Text}", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    infoTable.AddCell(new PdfPCell(new Phrase($"Fecha: {lblFecha.Text}", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                    infoTable.AddCell(new PdfPCell(new Phrase($"Tipo de Documento: {tipodoc.Text}", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    infoTable.AddCell(new PdfPCell(new Phrase($"Proveedor: {lblProveedor.Text}", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    infoTable.AddCell(new PdfPCell(new Phrase($"Administrador: {lblAdmin.Text}", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

                    pdfDoc.Add(infoTable);
                    pdfDoc.Add(new Paragraph(" "));
                    pdfDoc.Add(new Paragraph(" "));

                    // --- 3. TABLA DE PRODUCTOS ---
                    PdfPTable tableDetalle = new PdfPTable(dgvDetalle.Columns.Count) { WidthPercentage = 100 };
                    tableDetalle.SetWidths(new float[] { 1f, 3f, 1.5f, 1.5f }); // Proporciones de las columnas (Cant, Nombre, Precio, SubTotal)

                    // Encabezados grises[cite: 4]
                    foreach (DataGridViewColumn col in dgvDetalle.Columns)
                    {
                        PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, fontCabecera))
                        {
                            BackgroundColor = new BaseColor(240, 240, 240),
                            BorderColor = BaseColor.LIGHT_GRAY,
                            Padding = 8,
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        tableDetalle.AddCell(pCell);
                    }

                    // Filas
                    foreach (DataGridViewRow row in dgvDetalle.Rows)
                    {
                        if (row.IsNewRow) continue;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            PdfPCell pCell = new PdfPCell(new Phrase(cell.Value?.ToString(), fontNormal))
                            {
                                BorderColor = BaseColor.LIGHT_GRAY,
                                Padding = 6,
                                HorizontalAlignment = (cell.ColumnIndex == 1) ? Element.ALIGN_LEFT : Element.ALIGN_CENTER
                            };
                            tableDetalle.AddCell(pCell);
                        }
                    }
                    pdfDoc.Add(tableDetalle);
                    pdfDoc.Add(new Paragraph(" "));

                    // --- 4. TOTAL FINAL ---
                    PdfPTable totalTable = new PdfPTable(1) { WidthPercentage = 100 };
                    PdfPCell celdaTotal = new PdfPCell(new Phrase($"TOTAL: {lblTotalDetalle.Text}", fontTitulo))
                    {
                        Border = iTextSharp.text.Rectangle.NO_BORDER,
                        HorizontalAlignment = Element.ALIGN_RIGHT,
                        PaddingTop = 10
                    };
                    totalTable.AddCell(celdaTotal);
                    pdfDoc.Add(totalTable);

                    pdfDoc.Close();
                    stream.Close();

                    MessageBox.Show("Comprobante PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cargarCompras()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            List<Compra> lista = new CL_Compra().ReporteComprasFiltro(new DateTime(2000, 1, 1), new DateTime(2100, 1, 1));

            if (filtroDesde.HasValue)
                lista = lista.Where(c => Convert.ToDateTime(c.fechaRegistro).Date >= filtroDesde.Value.Date).ToList();

            if (filtroHasta.HasValue)
                lista = lista.Where(c => Convert.ToDateTime(c.fechaRegistro).Date <= filtroHasta.Value.Date).ToList();

            lista = lista.OrderByDescending(c => Convert.ToDateTime(c.fechaRegistro))
                         .ThenByDescending(c => c.id_compra)
                         .ToList();

            dgvCompras.Rows.Clear();
            dgvDetalle.Rows.Clear();
            gbDetalle.Visible = false;

            foreach (Compra c in lista)
            {
                decimal totalEstaCompra = 0;
                foreach (DetalleCompra d in new CL_Compra().ObtenerDetalleCompra(c.id_compra))
                {
                    totalEstaCompra += d.precioCompra * d.cantidad;
                }

                // Agregamos la fila
                int rowIndex = dgvCompras.Rows.Add(
                    c.id_compra,
                    c.numeroCompra,
                    Convert.ToDateTime(c.fechaRegistro).ToString("dd/MM/yyyy"),
                    c.proveedor.razonSocial,
                    c.usuario.nombre,
                    totalEstaCompra.ToString("0.00"));

                
                dgvCompras.Rows[rowIndex].Tag = c;
            }

            AplicarFiltroTexto(); 
        }
        private void AplicarFiltroTexto()
        {
            string textoBusqueda = textBuscar.Text.Trim().ToUpper();
            int indiceColumna = -1;

            if (cboBuscarPor.SelectedIndex != -1)
            {
                string columnaFiltro = cboBuscarPor.SelectedItem.ToString();

                if (columnaFiltro == "Numero de Compra") indiceColumna = 1;
                else if (columnaFiltro == "Proveedor") indiceColumna = 3;
                else if (columnaFiltro == "Administrador") indiceColumna = 4;
            }

            dgvCompras.CurrentCell = null;

            foreach (DataGridViewRow row in dgvCompras.Rows)
            {
                if (row.IsNewRow) continue;

                if (indiceColumna == -1 || textoBusqueda == "")
                {
                    row.Visible = true;
                    continue;
                }

                string valorCelda = row.Cells[indiceColumna].Value?.ToString().ToUpper() ?? "";
                row.Visible = valorCelda.Contains(textoBusqueda);
            }

            gbDetalle.Visible = false;

            // "Total de Compras" muestra la cantidad de compras que se están viendo
            lblTotalCompras.Text = dgvCompras.Rows.Cast<DataGridViewRow>()
                .Count(r => !r.IsNewRow && r.Visible).ToString();
        }
        private void ucReporteCompra_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible) cargarCompras();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
