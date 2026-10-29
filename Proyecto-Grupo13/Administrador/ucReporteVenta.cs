using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;
using System.Globalization;

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
            lblTotal.Text = "$" + v.montoPago.ToString("0.00");
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
    }
}
