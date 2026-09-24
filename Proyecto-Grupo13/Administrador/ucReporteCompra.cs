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
    public partial class ucReporteCompra : UserControl
    {
        public ucReporteCompra()
        {
            InitializeComponent();
            ConfigurarTablas();
            CargarComprasEstaticas();
        }

        // Método para cargar datos de compras de manera estática
        private void ConfigurarTablas()
        {
            // Configuración de columnas para la tabla principal (Izquierda)
            dgvCompras.Columns.Clear();
            dgvCompras.Columns.Add("Numero", "N° Compra");
            dgvCompras.Columns.Add("Fecha", "Fecha");
            dgvCompras.Columns.Add("Proveedor", "Proveedor");
            dgvCompras.Columns.Add("Total", "Monto Total");

            // Agregamos el botón "Ver" al final de la fila
            DataGridViewButtonColumn btnVer = new DataGridViewButtonColumn();
            btnVer.Name = "btnVer";
            btnVer.HeaderText = "Ver";
            btnVer.Text = "Ver Detalle";
            btnVer.UseColumnTextForButtonValue = true;
            dgvCompras.Columns.Add(btnVer);

            // Configuración de columnas para la mini-tabla del ticket (Derecha)
            // Asegurate de tener un DataGridView llamado dgvDetalles en tu panel derecho
            dgvDetalles.Columns.Clear();
            dgvDetalles.Columns.Add("Cant", "Cant.");
            dgvDetalles.Columns.Add("Descripcion", "Descripción");
            dgvDetalles.Columns.Add("Precio", "Precio Unit.");
            dgvDetalles.Columns.Add("SubTotal", "SubTotal");
        }


        // Método para cargar compras de manera estática
        private void CargarComprasEstaticas()
        {
            // Cargamos 3 compras de prueba en la tabla principal
            dgvCompras.Rows.Add("COMP-0001", "24/09/2026", "ONErpm", "$ 150,000");
            dgvCompras.Rows.Add("COMP-0002", "20/09/2026", "CD Baby", "$ 45,500");
            dgvCompras.Rows.Add("COMP-0003", "15/09/2026", "DistroKid", "$ 12,000");
        }
       
        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que se haya hecho clic en una fila válida y específicamente en la columna del botón "Ver"
            if (e.RowIndex >= 0 && dgvCompras.Columns[e.ColumnIndex].Name == "btnVer")
            {
                panelTicket.Visible = true;  // Mostramos el panel derecho con el ticket
                // Obtenemos el N° de Compra de la fila seleccionada
                string numeroCompra = dgvCompras.Rows[e.RowIndex].Cells["Numero"].Value.ToString();
                string proveedor = dgvCompras.Rows[e.RowIndex].Cells["Proveedor"].Value.ToString();
                string fecha = dgvCompras.Rows[e.RowIndex].Cells["Fecha"].Value.ToString();
                string total = dgvCompras.Rows[e.RowIndex].Cells["Total"].Value.ToString();
                string usuario = "Admin123";
                CargarTicketDerecho(numeroCompra, proveedor, fecha, total, usuario);
            }
        }

        private void CargarTicketDerecho(string numeroCompra, string proveedor, string fecha, string total, string usuario)
        {
            lblTicketNumero.Text = numeroCompra;
            lblTicketFecha.Text = fecha;
            lblTicketProveedor.Text = proveedor;
            lblTicketUsuario.Text = usuario;

            // Limpiamos los detalles anteriores
            dgvDetalles.Rows.Clear();

            // Simulamos la carga de productos dependiendo de qué compra se seleccionó
            if (numeroCompra == "COMP-0001")
            {
                dgvDetalles.Rows.Add("10", "Vinilo Taylor Swift", "$ 5,000", "$ 50,000");
                dgvDetalles.Rows.Add("5", " Vinilo 1989 Taylor Swift", "$ 20,000", "$ 100,000");
            }
            else if (numeroCompra == "COMP-0002")
            {
                dgvDetalles.Rows.Add("2", "CD Chase Atlantic", "$ 22,750", "$ 45,500");
            }
            else if (numeroCompra == "COMP-0003")
            {
                dgvDetalles.Rows.Add("20", "CD Arirang BTS", "$ 600", "$ 12,000");
            }
        } 
        
        private void labelBuscarPor2_Click(object sender, EventArgs e){}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
       
        private void textnumDocume_TextChanged(object sender, EventArgs e) { }
        
        private void iconBtnBuscar_Click(object sender, EventArgs e) { }
        
        private void iconBtnLimpiar_Click(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
