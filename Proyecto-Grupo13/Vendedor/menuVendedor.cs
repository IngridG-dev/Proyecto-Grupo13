using Proyecto_Grupo13.Administrador;
using System;
using CapaEntidad;
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
    public partial class menuVendedor : Form
    {
        public menuVendedor()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuVendedor_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.SelectNextControl(this.ActiveControl, true, true, true, true);
            if(SesionActual.usuarioLogueado != null)
            {
                // Cargar Nombre Completo y Documento
                textUsuario.Text = $"{SesionActual.usuarioLogueado.nombre} {SesionActual.usuarioLogueado.apellido}";
                textNumDocu.Text = SesionActual.usuarioLogueado.dni.ToString();
                // 2. Bloquear edición y desactivar la tabulación por teclado
                textUsuario.ReadOnly = true;
                textNumDocu.ReadOnly = true;
                textUsuario.TabStop = false;
                textNumDocu.TabStop = false;
                // 3. Quitar la selección azul y remover el foco inicial
                textUsuario.SelectionStart = 0;
                textUsuario.SelectionLength = 0;
                this.ActiveControl = null;
            }
        }

        private void iconToolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ucRegistroVenta registrarVenta = new ucRegistroVenta(); // Crea una instancia del UserControl ucRegistroVenta
            panelContenidoV.Controls.Clear(); // Limpia cualquier control existente en el panel
            registrarVenta.Dock = DockStyle.Fill; // Ajusta el UserControl para que ocupe todo el espacio disponible
            panelContenidoV.Controls.Add(registrarVenta); // Agrega el UserControl al panel
        }

        private void iconUsuarios_Click(object sender, EventArgs e)
        {
            ucClientes clientes = new ucClientes(); // Crea una instancia del UserControl ucClientes
            panelContenidoV.Controls.Clear(); // Limpia cualquier control existente en el panel
            clientes.Dock = DockStyle.Fill; // Ajusta el UserControl para que ocupe todo el espacio disponible
            panelContenidoV.Controls.Add(clientes); // Agrega el UserControl al panel
        }

        private void verDetalleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ucDetalleVenta detalleVenta = new ucDetalleVenta(); // Crea una instancia del UserControl ucDetalleVenta
            panelContenidoV.Controls.Clear(); // Limpia cualquier control existente en el panel
            detalleVenta.Dock = DockStyle.Fill; // Ajusta el UserControl para que ocupe todo el espacio disponible
            panelContenidoV.Controls.Add(detalleVenta); // Agrega el UserControl al panel
        }

        private void iconProductos_Click(object sender, EventArgs e)
        {
            ucProductos productos = new ucProductos(); // Crea una instancia del UserControl ucProductos
            panelContenidoV.Controls.Clear(); // Limpia cualquier control existente en el panel
            productos.Dock = DockStyle.Fill; // Ajusta el UserControl para que ocupe todo el espacio disponible
            panelContenidoV.Controls.Add(productos); // Agrega el UserControl al panel
        }

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null; // Remueve el foco del TextBox para que no se pueda editar
        }

        private void textNumDocu_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null; // Remueve el foco del TextBox para que no se pueda editar
        }
    }
}
