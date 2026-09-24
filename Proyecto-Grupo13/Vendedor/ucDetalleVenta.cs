using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Documents;
using System.Windows.Forms;

namespace Proyecto_Grupo13.Vendedor
{
    public partial class ucDetalleVenta : UserControl
    {
        public ucDetalleVenta()
        {
            InitializeComponent();

            // Al iniciar, ocultamos el comprobante
            panelTicket.Visible = false;

            // Cargamos ventas de prueba
            CargarVentasPrueba();

            // Cargamos productos de prueba
            CargarProductosPrueba();
        }

        // ============================================================
        // VENTAS DE PRUEBA
        // ============================================================
        private void CargarVentasPrueba()
        {
            dataGridView1.Rows.Clear();

            // Agregamos los datos respetando el orden de tus 6 columnas del diseñador:
            // N° Venta | Fecha | Cliente | DNI | Total | Ver
            dataGridView1.Rows.Add("0001", "23/09/2026", "María González", "12345678", "45000", "Ver");
            dataGridView1.Rows.Add("0002", "23/09/2026", "Juan Pérez", "87654321", "32500", "Ver");
            dataGridView1.Rows.Add("0003", "22/09/2026", "Sofía Rodríguez", "11223344", "78000", "Ver");
            dataGridView1.Rows.Add("0004", "21/09/2026", "Carlos López", "44332211", "21500", "Ver");
        }

        // ============================================================
        // PRODUCTOS DE PRUEBA
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

        // ============================================================
        // CLICK SOBRE UNA VENTA
        // ============================================================

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evita error si se hace clic en el encabezado de las columnas
            if (e.RowIndex < 0) return;

            DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

            // Obtenemos los valores según el orden visual de las columnas (0, 1, 2, 4):
            string numeroVenta = filaSeleccionada.Cells[0].Value?.ToString() ?? ""; // N° Venta
            string fecha = filaSeleccionada.Cells[1].Value?.ToString() ?? ""; // Fecha
            string cliente = filaSeleccionada.Cells[2].Value?.ToString() ?? ""; // Cliente
            string dni = filaSeleccionada.Cells[3].Value?.ToString() ?? ""; // DNI
            string total = filaSeleccionada.Cells[4].Value?.ToString() ?? "0"; // Total

            lNumeroVenta.Text = "N° Venta: " + numeroVenta;
            lFechaTicket.Text = "Fecha: " + fecha;
            lCliente.Text = "Cliente: " + cliente;
            lDNI.Text = "DNI: " + dni;
            lTotal.Text = "Total: $" + total;

            // Limpiar productos anteriores de la tabla chiquita
            dataGridView2.Rows.Clear();

            // Agregar productos a la tabla chiquita según la venta
            switch (numeroVenta)
            {
                case "0001":
                    dataGridView2.Rows.Add("Cd Queen", "2", "15000", "30000");
                    dataGridView2.Rows.Add("Vinilo AC/DC", "1", "15000", "15000");
                    break;

                case "0002":
                    dataGridView2.Rows.Add("Tocadiscos Retro", "1", "20000", "20000");
                    dataGridView2.Rows.Add("Vinilo Metallica", "1", "12500", "12500");
                    break;

                case "0003":
                    dataGridView2.Rows.Add("Auricular JBL", "1", "55000", "55000");
                    dataGridView2.Rows.Add("Cd Milo J", "2", "11500", "23000");
                    break;

                case "0004":
                    dataGridView2.Rows.Add("Vinilo Rosie", "1", "21500", "21500");
                    break;
            }

            // Mostrar comprobante
            panelTicket.Visible = true;
            panelTicket.BringToFront();
            string detallePago = "";

            switch (numeroVenta)
            {
                case "0001": // Efectivo
                    int pagocon1 = 50000;
                    int total1 = 45000;
                    int vuelto1 = pagocon1 - total1;

                    detallePago = "• Método: Efectivo" + Environment.NewLine +
                                  "• Abonó con: $" + pagocon1 + Environment.NewLine +
                                  "• Vuelto: $" + vuelto1;
                    break;

                case "0002": // Crédito
                    detallePago = "• Método: Tarjeta de Crédito" + Environment.NewLine +
                                  "• Cuotas: 3 cuotas sin interés";
                    break;

                case "0003": // Transferencia
                    detallePago = "• Método: Transferencia Bancaria" + Environment.NewLine +
                                  "• N° Comprobante: #TR-88231";
                    break;

                case "0004": // Débito
                    detallePago = "• Método: Tarjeta de Débito";
                    break;
            }

            // Asignar al label del comprobante
            lDetallePago.Text = "Detalles de Pago:" + Environment.NewLine + detallePago;
        }
    }

}
