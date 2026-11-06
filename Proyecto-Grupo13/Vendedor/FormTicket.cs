
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
            SaveFileDialog savefile = new SaveFileDialog()
            {
                FileName = $"Ticket_Venta_{_idVenta}.pdf",
                Filter = "Archivos PDF (*.pdf)|*.pdf",
                Title = "Guardar ticket de venta"
            };

            if (savefile.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                using (FileStream stream = new FileStream(
                    savefile.FileName,
                    FileMode.Create))
                {
                    Document pdfDoc = new Document(
                        PageSize.A4, 40, 40, 40, 40);

                    PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    // ==================================
                    // FUENTES
                    // ==================================

                    PdfFont fontTitulo = FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        20,
                        new BaseColor(30, 40, 60));

                    PdfFont fontSubtitulo = FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        13,
                        BaseColor.DARK_GRAY);

                    PdfFont fontCabecera = FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        10,
                        BaseColor.BLACK);

                    PdfFont fontNormal = FontFactory.GetFont(
                        FontFactory.HELVETICA,
                        10,
                        BaseColor.BLACK);

                    PdfFont fontTotal = FontFactory.GetFont(
                        FontFactory.HELVETICA_BOLD,
                        16,
                        new BaseColor(30, 40, 60));

                    // ==================================
                    // 1. CABECERA
                    // ==================================

                    Paragraph titulo = new Paragraph(
                        "THE B-SIDE",
                        fontTitulo);

                    titulo.Alignment = Element.ALIGN_CENTER;
                    titulo.SpacingAfter = 5;

                    pdfDoc.Add(titulo);

                    Paragraph subtitulo = new Paragraph(
                        "TICKET DE VENTA",
                        fontSubtitulo);

                    subtitulo.Alignment = Element.ALIGN_CENTER;
                    subtitulo.SpacingAfter = 10;

                    pdfDoc.Add(subtitulo);

                    pdfDoc.Add(new Paragraph(
                        new Chunk(
                            new iTextSharp.text.pdf.draw.LineSeparator(
                                1f,
                                100f,
                                BaseColor.LIGHT_GRAY,
                                Element.ALIGN_CENTER,
                                -1))));

                    pdfDoc.Add(new Paragraph(" "));

                    // ==================================
                    // 2. INFORMACIÓN DE LA VENTA
                    // ==================================

                    PdfPTable tablaVenta = new PdfPTable(2);
                    tablaVenta.WidthPercentage = 100;

                    tablaVenta.AddCell(CrearCelda(
                        "N° Venta: " + _idVenta,
                        fontNormal));

                    tablaVenta.AddCell(CrearCelda(
                        "Fecha: " + _fecha.ToString("dd/MM/yyyy HH:mm"),
                        fontNormal,
                        Element.ALIGN_RIGHT));

                    tablaVenta.AddCell(CrearCelda(
                        "Tipo de documento: " + _tipoDocumento,
                        fontNormal));

                    tablaVenta.AddCell(CrearCelda(
                        "Forma de pago: " + _formaPago,
                        fontNormal,
                        Element.ALIGN_RIGHT));

                    pdfDoc.Add(tablaVenta);

                    pdfDoc.Add(new Paragraph(" "));

                    // ==================================
                    // 3. INFORMACIÓN DEL CLIENTE
                    // ==================================

                    pdfDoc.Add(new Paragraph(
                        "INFORMACIÓN DEL CLIENTE",
                        fontSubtitulo));

                    PdfPTable tablaCliente = new PdfPTable(1);
                    tablaCliente.WidthPercentage = 100;

                    tablaCliente.AddCell(CrearCelda(
                        "Nombre: " + _cliente,
                        fontNormal));

                    tablaCliente.AddCell(CrearCelda(
                        "Documento: " + _dni,
                        fontNormal));

                    pdfDoc.Add(tablaCliente);

                    pdfDoc.Add(new Paragraph(" "));

                    // ==================================
                    // 4. INFORMACIÓN DEL VENDEDOR
                    // ==================================

                    pdfDoc.Add(new Paragraph(
                        "VENDEDOR",
                        fontSubtitulo));

                    pdfDoc.Add(new Paragraph(
                        _vendedor,
                        fontNormal));

                    pdfDoc.Add(new Paragraph(" "));

                    // ==================================
                    // 5. DETALLE DE PRODUCTOS
                    // ==================================

                    pdfDoc.Add(new Paragraph(
                        "PRODUCTOS",
                        fontSubtitulo));

                    PdfPTable tablaDetalle = new PdfPTable(4);
                    tablaDetalle.WidthPercentage = 100;

                    tablaDetalle.SetWidths(
                        new float[] { 3f, 1f, 1.5f, 1.5f });

                    string[] encabezados =
                    {
                        "Producto",
                        "Cantidad",
                        "Precio unitario",
                        "Subtotal"
                    };

                    foreach (string encabezado in encabezados)
                    {
                        PdfPCell celda = new PdfPCell(
                            new Phrase(encabezado, fontCabecera));

                        celda.BackgroundColor =
                            new BaseColor(230, 230, 230);

                        celda.HorizontalAlignment =
                            Element.ALIGN_CENTER;

                        celda.Padding = 7;

                        celda.BorderColor = BaseColor.LIGHT_GRAY;

                        tablaDetalle.AddCell(celda);
                    }

                    foreach (DataRow fila in _detalle.Rows)
                    {
                        string producto = fila["Producto"].ToString();

                        if (_detalle.Columns.Contains("CodigoProducto"))
                        {
                            string codigo = fila["CodigoProducto"].ToString();

                            if (!string.IsNullOrEmpty(codigo))
                            {
                                producto = codigo + " - " + producto;
                            }
                        }

                        int cantidad =
                            Convert.ToInt32(fila["Cantidad"]);

                        decimal precio =
                            Convert.ToDecimal(fila["PrecioVenta"]);

                        decimal subtotal = cantidad * precio;

                        tablaDetalle.AddCell(CrearCelda(
                            producto, fontNormal));

                        tablaDetalle.AddCell(CrearCelda(
                            cantidad.ToString(),
                            fontNormal,
                            Element.ALIGN_CENTER));

                        tablaDetalle.AddCell(CrearCelda(
                            "$ " + precio.ToString("N2"),
                            fontNormal,
                            Element.ALIGN_CENTER));

                        tablaDetalle.AddCell(CrearCelda(
                            "$ " + subtotal.ToString("N2"),
                            fontNormal,
                            Element.ALIGN_CENTER));
                    }

                    pdfDoc.Add(tablaDetalle);

                    pdfDoc.Add(new Paragraph(" "));

                    // ==================================
                    // 6. TOTAL
                    // ==================================

                    PdfPTable tablaTotal = new PdfPTable(1);
                    tablaTotal.WidthPercentage = 100;

                    PdfPCell celdaTotal = new PdfPCell(
                        new Phrase(
                            "TOTAL A PAGAR: $ " + _total.ToString("N2"),
                            fontTotal));

                    celdaTotal.Border =
                        PdfRectangle.NO_BORDER;

                    celdaTotal.HorizontalAlignment =
                        Element.ALIGN_RIGHT;

                    celdaTotal.Padding = 10;

                    tablaTotal.AddCell(celdaTotal);

                    pdfDoc.Add(tablaTotal);

                    // ==================================
                    // 7. PAGO Y CAMBIO
                    // ==================================

                    if (_formaPago.Equals(
                        "Efectivo",
                        StringComparison.OrdinalIgnoreCase))
                    {
                        PdfPTable tablaPago = new PdfPTable(1);
                        tablaPago.WidthPercentage = 100;

                        tablaPago.AddCell(CrearCelda(
                            "Paga con: $ " + _pagaCon.ToString("N2"),
                            fontNormal));

                        tablaPago.AddCell(CrearCelda(
                            "Cambio: $ " + _cambio.ToString("N2"),
                            fontNormal));

                        pdfDoc.Add(tablaPago);
                    }

                    pdfDoc.Add(new Paragraph(" "));

                    // ==================================
                    // 8. MENSAJE FINAL
                    // ==================================

                    Paragraph agradecimiento = new Paragraph(
                        "¡GRACIAS POR SU COMPRA!",
                        fontSubtitulo);

                    agradecimiento.Alignment =
                        Element.ALIGN_CENTER;

                    agradecimiento.SpacingBefore = 15;

                    pdfDoc.Add(agradecimiento);

                    Paragraph mensajeFinal = new Paragraph(
                        "Conserve este comprobante.",
                        fontNormal);

                    mensajeFinal.Alignment =
                        Element.ALIGN_CENTER;

                    pdfDoc.Add(mensajeFinal);

                    pdfDoc.Close();
                }

                MessageBox.Show(
                    "Ticket PDF generado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Abrimos el PDF generado.
                System.Diagnostics.Process.Start(
                    new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = savefile.FileName,
                        UseShellExecute = true
                    });
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el ticket PDF: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
