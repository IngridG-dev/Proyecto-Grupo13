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
                int idCompra = Convert.ToInt32(fila.Cells[0].Value);

                lblNumCompra.Text = fila.Cells[1].Value.ToString();
                lblFecha.Text = fila.Cells[2].Value.ToString();
                lblProveedor.Text = fila.Cells[3].Value.ToString();
                lblAdmin.Text = fila.Cells[4].Value.ToString();

                List<DetalleCompra> detalle = new CL_Compra().ObtenerDetalleCompra(idCompra);
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
            if (dgvDetalle.Rows.Count == 0) return;

            SaveFileDialog savefile = new SaveFileDialog() { FileName = $"DetalleCompra_{lblNumCompra.Text}.xlsx", Filter = "Excel Files | *.xlsx" };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    var hoja = wb.Worksheets.Add("Detalle Compra");
                    for (int i = 0; i < dgvDetalle.Columns.Count; i++) hoja.Cell(1, i + 1).Value = dgvDetalle.Columns[i].HeaderText;
                    for (int i = 0; i < dgvDetalle.Rows.Count; i++)
                        for (int j = 0; j < dgvDetalle.Columns.Count; j++)
                            hoja.Cell(i + 2, j + 1).Value = dgvDetalle.Rows[i].Cells[j].Value?.ToString();

                    wb.SaveAs(savefile.FileName);
                    MessageBox.Show("Excel generado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDescargarPdf_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0) return;

            SaveFileDialog savefile = new SaveFileDialog()
            {
                FileName = $"Ticket_Compra_{lblNumCompra.Text}.pdf",
                Filter = "PDF Files|*.pdf"

            };

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    // Tamaño personalizado simulando ticket de 80mm
                    iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(226f, 500f);
                    Document pdfDoc = new Document(pageSize, 10f, 10f, 10f, 10f);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    // Fuentes monoespaciadas estilo recibo
                    iTextSharp.text.Font fontTitulo = FontFactory.GetFont(FontFactory.COURIER_BOLD, 12);
                    iTextSharp.text.Font fontNormal = FontFactory.GetFont(FontFactory.COURIER, 9);
                    iTextSharp.text.Font fontNegrita = FontFactory.GetFont(FontFactory.COURIER_BOLD, 9);

                    // 1. CABECERA
                    pdfDoc.Add(new Paragraph("THE B-SIDE", fontTitulo) { Alignment = Element.ALIGN_CENTER });
                    pdfDoc.Add(new Paragraph($"Dirección: Junin 1932\nTel. 11223344", fontNormal) { Alignment = Element.ALIGN_CENTER });
                    pdfDoc.Add(new Paragraph("********************************", fontNormal) { Alignment = Element.ALIGN_CENTER });
                    pdfDoc.Add(new Paragraph("TICKET DE COMPRA", fontNormal) { Alignment = Element.ALIGN_CENTER });
                    pdfDoc.Add(new Paragraph("********************************", fontNormal) { Alignment = Element.ALIGN_CENTER });

                    // 2. TABLA DE PRODUCTOS
                    PdfPTable tablaItems = new PdfPTable(2);
                    tablaItems.WidthPercentage = 100;
                    tablaItems.SetWidths(new float[] { 3f, 1f });

                    // Celdas de cabecera sin bordes
                    PdfPCell celdaDesc = new PdfPCell(new Phrase("Descripción", fontNegrita)) { Border = iTextSharp.text.Rectangle.NO_BORDER };
                    PdfPCell celdaPrecio = new PdfPCell(new Phrase("Precio", fontNegrita)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT };
                    tablaItems.AddCell(celdaDesc);
                    tablaItems.AddCell(celdaPrecio);

                    // Filas de productos desde la grilla
                    foreach (DataGridViewRow row in dgvDetalle.Rows)
                    {
                        if (row.IsNewRow) continue;
                        string nombre = row.Cells[1].Value.ToString();
                        string subtotal = row.Cells[3].Value.ToString(); // Precio * Cantidad

                        PdfPCell cDesc = new PdfPCell(new Phrase(nombre, fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER };
                        PdfPCell cSub = new PdfPCell(new Phrase(subtotal, fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT };

                        tablaItems.AddCell(cDesc);
                        tablaItems.AddCell(cSub);
                    }
                    pdfDoc.Add(tablaItems);
                    pdfDoc.Add(new Paragraph("********************************", fontNormal) { Alignment = Element.ALIGN_CENTER });

                    // 3. TOTALES
                    PdfPTable tablaTotales = new PdfPTable(2);
                    tablaTotales.WidthPercentage = 100;
                    tablaTotales.SetWidths(new float[] { 2f, 1f });

                    tablaTotales.AddCell(new PdfPCell(new Phrase("Total", fontTitulo)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    tablaTotales.AddCell(new PdfPCell(new Phrase(lblTotalDetalle.Text.Replace("$ ", ""), fontTitulo)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

                    // Efectivo y Cambio (Valores estáticos para replicar el diseño visual)
                    tablaTotales.AddCell(new PdfPCell(new Phrase("Efectivo", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    tablaTotales.AddCell(new PdfPCell(new Phrase(lblTotalDetalle.Text.Replace("$ ", ""), fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                    tablaTotales.AddCell(new PdfPCell(new Phrase("Vuelto", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    tablaTotales.AddCell(new PdfPCell(new Phrase("0.00", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

                    pdfDoc.Add(tablaTotales);
                    pdfDoc.Add(new Paragraph("********************************", fontNormal) { Alignment = Element.ALIGN_CENTER });

                    // 4. DATOS BANCARIOS (Simulados como en el diseño)
                    PdfPTable tablaBanco = new PdfPTable(2);
                    tablaBanco.WidthPercentage = 100;
                    tablaBanco.SetWidths(new float[] { 2f, 1f });

                    tablaBanco.AddCell(new PdfPCell(new Phrase("Tarjeta bancaria", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    tablaBanco.AddCell(new PdfPCell(new Phrase("--- 234", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                    tablaBanco.AddCell(new PdfPCell(new Phrase("Cód. Aprobación", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    tablaBanco.AddCell(new PdfPCell(new Phrase("#123456", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

                    pdfDoc.Add(tablaBanco);
                    pdfDoc.Add(new Paragraph("********************************", fontNormal) { Alignment = Element.ALIGN_CENTER });

                    // 5. PIE DE PÁGINA
                    pdfDoc.Add(new Paragraph("¡GRACIAS POR SU COMPRA!", fontNegrita) { Alignment = Element.ALIGN_CENTER });

                    pdfDoc.Close();
                    MessageBox.Show("Ticket PDF generado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cargarCompras()
        {
            // Evita consultar la base cuando Visual Studio dibuja el control en el diseñador
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            // Se traen TODAS las compras y las fechas se filtran acá
            List<Compra> lista = new CL_Compra().ReporteComprasFiltro(new DateTime(2000, 1, 1), new DateTime(2100, 1, 1));

            if (filtroDesde.HasValue)
                lista = lista.Where(c => Convert.ToDateTime(c.fechaRegistro).Date >= filtroDesde.Value.Date).ToList();

            if (filtroHasta.HasValue)
                lista = lista.Where(c => Convert.ToDateTime(c.fechaRegistro).Date <= filtroHasta.Value.Date).ToList();

            // Las más nuevas primero
            lista = lista.OrderByDescending(c => Convert.ToDateTime(c.fechaRegistro))
                         .ThenByDescending(c => c.id_compra)
                         .ToList();

            dgvCompras.Rows.Clear();
            dgvDetalle.Rows.Clear();
            gbDetalle.Visible = false;

            foreach (Compra c in lista)
            {
                // El total de cada compra se calcula con su detalle
                decimal totalEstaCompra = 0;
                foreach (DetalleCompra d in new CL_Compra().ObtenerDetalleCompra(c.id_compra))
                {
                    totalEstaCompra += d.precioCompra * d.cantidad;
                }

                dgvCompras.Rows.Add(
                    c.id_compra,   // Columna oculta
                    c.numeroCompra,
                    Convert.ToDateTime(c.fechaRegistro).ToString("dd/MM/yyyy"),
                    c.proveedor.razonSocial,
                    c.usuario.nombre,
                    totalEstaCompra.ToString("0.00"));
            }

            AplicarFiltroTexto();   // vuelve a aplicar lo escrito en el buscador
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
    }
}
