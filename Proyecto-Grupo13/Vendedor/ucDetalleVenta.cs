using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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

            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("NroVenta", "N° Venta");
            dataGridView1.Columns.Add("Fecha", "Fecha");
            dataGridView1.Columns.Add("Cliente", "Cliente");
            dataGridView1.Columns.Add("Total", "Total");

            dataGridView1.Rows.Add(
                "0001",
                "23/09/2026",
                "María González",
                "45000"
            );

            dataGridView1.Rows.Add(
                "0002",
                "23/09/2026",
                "Juan Pérez",
                "32500"
            );

            dataGridView1.Rows.Add(
                "0003",
                "22/09/2026",
                "Sofía Rodríguez",
                "78000"
            );

            dataGridView1.Rows.Add(
                "0004",
                "21/09/2026",
                "Carlos López",
                "21500"
            );
        }

        // ============================================================
        // PRODUCTOS DE PRUEBA
        // ============================================================
        private void CargarProductosPrueba()
        {
            // Si tenés un DataGridView dentro del comprobante
            // para mostrar los productos, por ahora usamos dataGridView2.

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
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evita hacer algo si se hace clic en el encabezado
            if (e.RowIndex < 0)
                return;

            // IMPORTANTE:
            // Aunque el evento sea dataGridView2_CellClick,
            // estamos obteniendo la fila de dataGridView1.
            DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

            string numeroVenta =
                filaSeleccionada.Cells["NroVenta"].Value?.ToString() ?? "";

            string fecha =
                filaSeleccionada.Cells["Fecha"].Value?.ToString() ?? "";

            string cliente =
                filaSeleccionada.Cells["Cliente"].Value?.ToString() ?? "";

            string total =
                filaSeleccionada.Cells["Total"].Value?.ToString() ?? "0";

            // Mostrar información en el ticket
            lNumeroVenta.Text = "N° Venta: " + numeroVenta;
            lFechaTicket.Text = "Fecha: " + fecha;
            lCliente.Text = "Cliente: " + cliente;
            lTotal.Text = "Total: $" + total;

            // Limpiar productos anteriores
            dataGridView2.Rows.Clear();

            // Agregar productos según la venta
            switch (numeroVenta)
            {
                case "0001":

                    dataGridView2.Rows.Add(
                        "Remera Oversize",
                        "2",
                        "15000",
                        "30000"
                    );

                    dataGridView2.Rows.Add(
                        "Pantalón Cargo",
                        "1",
                        "15000",
                        "15000"
                    );

                    break;

                case "0002":

                    dataGridView2.Rows.Add(
                        "Buzo Básico",
                        "1",
                        "20000",
                        "20000"
                    );

                    dataGridView2.Rows.Add(
                        "Gorra Negra",
                        "1",
                        "12500",
                        "12500"
                    );

                    break;

                case "0003":

                    dataGridView2.Rows.Add(
                        "Campera Deportiva",
                        "1",
                        "55000",
                        "55000"
                    );

                    dataGridView2.Rows.Add(
                        "Remera Básica",
                        "2",
                        "11500",
                        "23000"
                    );

                    break;

                case "0004":

                    dataGridView2.Rows.Add(
                        "Jean Clásico",
                        "1",
                        "21500",
                        "21500"
                    );

                    break;
            }

            // Mostrar comprobante
            panelTicket.Visible = true;
            panelTicket.BringToFront();
        }
    }
}
