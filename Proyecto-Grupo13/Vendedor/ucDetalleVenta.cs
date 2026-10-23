using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

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

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
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
            dataGridView1.Rows.Clear();
            panelTicket.Visible = false;

            if (SesionActual.usuarioLogueado == null)
                return;
            List<Venta> ventas = new CL_Venta().ListarVentasPorUsuario(SesionActual.usuarioLogueado.id_usuario, filtroDesde, filtroHasta);
            foreach (Venta v in ventas)
            {
                int n = dataGridView1.Rows.Add(
                    v.id_venta.ToString("000000"),
                    v.fechaCreacion.ToString("dd/MM/yyyy HH:mm:ss"),
                    v.cliente.nombre + " " + v.cliente.apellido,
                    v.cliente.dni.ToString(),
                    v.montoPago.ToString("0.00"),
                    "Ver"
                    );
                dataGridView1.Rows[n].Tag = v; // Guardamos el objeto Venta en la propiedad Tag de la fila
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
            if (dataGridView1.Rows.Count == 0)
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

            Venta v = dataGridView1.Rows[e.RowIndex].Tag as Venta;
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
    }
}
