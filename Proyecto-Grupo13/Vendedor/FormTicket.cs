
using CapaEntidad;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using PdfFont = iTextSharp.text.Font;
using PdfRectangle = iTextSharp.text.Rectangle;

namespace Proyecto_Grupo13.Vendedor
{
    public partial class FormTicket : Form
    {
        private int _idVenta;
        private DateTime _fecha;
        private string _cliente;
        private string _dni;
        private string _vendedor;
        private string _tipoDocumento;
        private string _formaPago;
        private DataTable _detalle;
        private decimal _total;
        private decimal _pagaCon;
        private decimal _cambio;

        public FormTicket(
            int idVenta,
            DateTime fecha,
            string cliente,
            string dni,
            string vendedor,
            string tipoDocumento,
            string formaPago,
            DataTable detalle,
            decimal total,
            decimal pagaCon,
            decimal cambio)
        {
            InitializeComponent();

            _idVenta = idVenta;
            _fecha = fecha;
            _cliente = cliente;
            _dni = dni;
            _vendedor = vendedor;
            _tipoDocumento = tipoDocumento;
            _formaPago = formaPago;
            _detalle = detalle.Copy();
            _total = total;
            _pagaCon = pagaCon;
            _cambio = cambio;

            CargarDatosTicket();
        }

        // ==========================================
        // CARGAR LOS DATOS EN EL FORMULARIO
        // ==========================================

        private void CargarDatosTicket()
        {
            lblNumeroVenta.Text = _idVenta.ToString();

            lblFecha.Text = _fecha.ToString("dd/MM/yyyy HH:mm");

            lblTipoDocumento.Text = _tipoDocumento;

            lblCliente.Text = _cliente;

            lblDocumento.Text = _dni;

            lblVendedor.Text = _vendedor;

            lblTotal.Text = "$ " + _total.ToString("N2");

            lblFormaPago.Text = _formaPago;

            if (_formaPago.Equals("Efectivo",
                StringComparison.OrdinalIgnoreCase))
            {
                lblPagoCon.Text = "$ " + _pagaCon.ToString("N2");
                lblCambio.Text = "$ " + _cambio.ToString("N2");
            }
            else
            {
                lblPagoCon.Text = "No corresponde";
                lblCambio.Text = "No corresponde";
            }

            // Limpiamos la grilla.
            dgvProductosTicket.Rows.Clear();

            // Cargamos los productos vendidos.
            foreach (DataRow fila in _detalle.Rows)
            {
                string producto = fila["Producto"].ToString();

                string codigo = "";

                if (_detalle.Columns.Contains("CodigoProducto"))
                {
                    codigo = fila["CodigoProducto"].ToString();
                }

                if (!string.IsNullOrEmpty(codigo))
                {
                    producto = codigo + " - " + producto;
                }

                int cantidad = Convert.ToInt32(fila["Cantidad"]);

                decimal precio = Convert.ToDecimal(fila["PrecioVenta"]);

                decimal subtotal = cantidad * precio;

                dgvProductosTicket.Rows.Add(
                    producto,
                    cantidad,
                    precio.ToString("N2"),
                    subtotal.ToString("N2")
                );
            }
        }

        // ==========================================
        // BOTÓN IMPRIMIR TICKET - GENERAR PDF
        // ==========================================

        private void iconBtnTicket_Click(object sender, EventArgs e)
        {
            // Validar que haya productos en el detalle cargado
            if (dgvProductosTicket.Rows.Count == 0)
            {
                MessageBox.Show("Seleccione una venta para exportar su detalle a PDF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Diálogo para guardar el archivo
            SaveFileDialog savefile = new SaveFileDialog()
            {
                FileName = $"Ticket_Venta_{lblNumeroVenta.Text.Replace("N° Venta:", "").Trim()}_{DateTime.Now:yyyyMMdd}.pdf",
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
                    iTextSharp.text.Font fontNegrita = FontFactory.GetFont(FontFactory.COURIER_BOLD, 6, BaseColor.BLACK);

                    // 1. CABECERA CON MARCA
                    pdfDoc.Add(new Paragraph("THE B-SIDE", fontTitulo) { Alignment = Element.ALIGN_CENTER });
                    pdfDoc.Add(new Paragraph("TICKET DE VENTA", fontSubtitulo) { Alignment = Element.ALIGN_CENTER });
                    pdfDoc.Add(new Paragraph("--------------------------------", fontNormal) { Alignment = Element.ALIGN_CENTER });

                    // 2. INFORMACIÓN DE LA VENTA
                    pdfDoc.Add(new Paragraph($"{lblNumeroVenta.Text}", fontNormal));
                    pdfDoc.Add(new Paragraph($"{lblFecha.Text}", fontNormal));
                    pdfDoc.Add(new Paragraph($"{lblVendedor.Text}", fontNormal));
                    pdfDoc.Add(new Paragraph($"{lblCliente.Text}", fontNormal));
                    if (!string.IsNullOrEmpty(lblDocumento.Text))
                    {
                        pdfDoc.Add(new Paragraph($"{lblDocumento.Text}", fontNormal));
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

                    // Filas provenientes de dgvProductosTicket
                    foreach (DataGridViewRow row in dgvProductosTicket.Rows)
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

                    tablaTotales.AddCell(new PdfPCell(new Phrase(lblFormaPago.Text, fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    if(_formaPago.Equals("Efectivo", StringComparison.OrdinalIgnoreCase))
                    {
                        tablaTotales.AddCell(new PdfPCell(new Phrase($"Pago con: {lblPagoCon.Text}", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER});
                        tablaTotales.AddCell(new PdfPCell(new Phrase($"Cambio: {lblCambio.Text}", fontNormal)) { Border = iTextSharp.text.Rectangle.NO_BORDER });
                    }
                    tablaTotales.AddCell(new Paragraph(new Phrase("TOTAL:", fontNegrita)));
                    tablaTotales.AddCell(new PdfPCell(new Phrase(lblTotal.Text, fontTitulo)) { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });

                    pdfDoc.Add(tablaTotales);
                    pdfDoc.Add(new Paragraph("--------------------------------", fontNormal) { Alignment = Element.ALIGN_CENTER });

                    // 5. PIE
                    pdfDoc.Add(new Paragraph("¡GRACIAS POR SU COMPRA!", fontSubtitulo) { Alignment = Element.ALIGN_CENTER });
                    pdfDoc.Add(new Paragraph("Conserve este comprobante", fontSubtitulo) { Alignment = Element.ALIGN_CENTER });

                    pdfDoc.Close();
                    stream.Close();

                    MessageBox.Show("Ticket PDF generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // ==========================================
        // MÉTODO AUXILIAR PARA CREAR CELDAS
        // ==========================================

        private PdfPCell CrearCelda(
            string texto,
            PdfFont fuente,
            int alineacion = Element.ALIGN_LEFT)
        {
            PdfPCell celda = new PdfPCell(
                new Phrase(texto ?? "", fuente));

            celda.Border = PdfRectangle.NO_BORDER;

            celda.Padding = 5;

            celda.HorizontalAlignment = alineacion;

            return celda;
        }
    }
}
