using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Grupo13.Vendedor
{
    public partial class ucDetalleVenta : UserControl
    {
        public ucDetalleVenta()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificamos que el clic sea en una fila válida y no en los encabezados
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                // 1. Rellenamos los Labels del ticket
                // Asegúrate de cambiar los textos entre comillas por los Nombres(Name) exactos de tus columnas
                lNumeroVenta.Text = "N° Venta: " + filaSeleccionada.Cells["NombreColNroVenta"].Value.ToString();
                lFechaTicket.Text = "Fecha: " + filaSeleccionada.Cells["NombreColFecha"].Value.ToString();
                lCliente.Text = "Cliente: " + filaSeleccionada.Cells["NombreColCliente"].Value.ToString();
                lTotal.Text = "Total: $" + filaSeleccionada.Cells["NombreColTotal"].Value.ToString();

                // 2. Hacemos que el panel del ticket aparezca en pantalla
                panelTicket.Visible = true;

                // 3. (A futuro) Aquí puedes llamar a la base de datos para cargar los productos de esta venta
                // int idVenta = Convert.ToInt32(filaSeleccionada.Cells["NombreColNroVenta"].Value);
                // CargarProductosDelTicket(idVenta);
            }
   
        }
    }
}
