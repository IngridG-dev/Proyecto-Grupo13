using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Grupo13.Administrador
{
    public partial class FormTicketCompra : Form
    {
        // Propiedades para recibir los datos desde el registro
        public Compra DatosCompra { get; set; }
        public DataTable DetalleProductos { get; set; }
        public decimal TotalPagado { get; set; }
        public FormTicketCompra()
        {
            InitializeComponent();
        }

        private void FormTicketCompra_Load(object sender, EventArgs e)
        {
            // 1. Llenar los datos de cabecera con el estilo solicitado
            lblNumCompra.Text = "Número de compra: " + DatosCompra.numeroCompra;

            // Administrador (Usuario logueado)
            lblAdmin.Text = "Nombre Administrador: " + (DatosCompra.usuario != null ? DatosCompra.usuario.nombre : "Admin");

            // Proveedor
            lblProveedor.Text = "Proveedor: " + (DatosCompra.proveedor != null ? DatosCompra.proveedor.razonSocial : "No especificado");

            // Fecha y Hora separadas
            DateTime fechaActual = DateTime.Now;
            lblFecha.Text = "Fecha: " + fechaActual.ToString("dd/MM/yyyy");
            lblHora.Text = "Hora: " + fechaActual.ToString("HH:mm");

            // 2. Configurar y llenar la grilla del ticket
            // Ajustes visuales básicos para que parezca un ticket
            dgvTicket.AllowUserToAddRows = false;
            dgvTicket.RowHeadersVisible = false;
            dgvTicket.ReadOnly = true;
            dgvTicket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTicket.BackgroundColor = System.Drawing.Color.White;

            dgvTicket.Rows.Clear();

            // Si las columnas no están creadas desde el diseñador, las creamos por código:
            if (dgvTicket.Columns.Count == 0)
            {
                dgvTicket.Columns.Add("Cant", "N.");
                dgvTicket.Columns.Add("Articulo", "Artículos");
                dgvTicket.Columns.Add("Precio", "PrecIO.");
                dgvTicket.Columns.Add("Total", "Total");

                // Ajustar anchos relativos
                dgvTicket.Columns[0].FillWeight = 15; // Cantidad pequeña
                dgvTicket.Columns[1].FillWeight = 45; // Nombre más grande
                dgvTicket.Columns[2].FillWeight = 20;
                dgvTicket.Columns[3].FillWeight = 20;
            }

            foreach (DataRow fila in DetalleProductos.Rows)
            {
                int cantidad = Convert.ToInt32(fila["Cantidad"]);
                decimal precio = Convert.ToDecimal(fila["PrecioCompra"]);
                decimal subtotal = cantidad * precio;

                string nombreProducto = fila["NombreProducto"].ToString();
                // Agregamos la fila simulando el desglose de artículos, unidades y precio
                dgvTicket.Rows.Add(
                    cantidad,
                    nombreProducto,
                    "$" + precio.ToString("0.00"),
                    "$" + subtotal.ToString("0.00")
                );
            }

            // 3. Llenar el Total General
            lblTotal.Text = "Total de la compra: $" + TotalPagado.ToString("0.00");
        }

        private void iconBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
