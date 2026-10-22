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
    public partial class menuAdministrador : Form
    {
        public menuAdministrador()
        {
            InitializeComponent();
        }
        private void iconMenuUsuarios_Click(object sender, EventArgs e)
        { }

        private void iconMenuProductos_Click(object sender, EventArgs e)
        {
            UcProductos1 productos = new UcProductos1(); // Crea una instancia del UserControl UcProductos1
            panelContenido.Controls.Clear(); // Limpia los controles existentes en el panelContenido
            productos.Dock = DockStyle.Fill; // Ajusta el UserControl para que ocupe todo el espacio del panelContenido
            panelContenido.Controls.Add(productos); // Agrega el UserControl al panelContenido
        }

        private void iconMenuProveedor_Click(object sender, EventArgs e)
        {
            ucProveedor proveedor = new ucProveedor(); // Crea una instancia del UserControl ucProveedor
            panelContenido.Controls.Clear(); // Limpia los controles existentes en el panelContenido
            proveedor.Dock = DockStyle.Fill; // Ajusta el UserControl para que ocupe todo el espacio del panelContenido
            panelContenido.Controls.Add(proveedor); // Agrega el UserControl al panelContenido
        }

        private void iconMenuVentas_Click(object sender, EventArgs e){}

        private void menuAdministrador_Load(object sender, EventArgs e)
        {
            this.SelectNextControl(this.ActiveControl, true, true, true, true); // Selecciona el siguiente control en el formulario
            if (SesionActual.usuarioLogueado != null)
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

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usRegistrarCom registrarCom = new usRegistrarCom(); // Crea una instancia del UserControl usRegistrarCom
            panelContenido.Controls.Clear(); // Limpia los controles existentes en el panelContenido
            registrarCom.Dock = DockStyle.Fill; // Ajusta el UserControl para que ocupe todo el espacio del panelContenido
            panelContenido.Controls.Add(registrarCom); // Agrega el UserControl al panelContenido
        }

      

        private void reporteCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucReporteCompra reporteCompra = new ucReporteCompra(); // Crea una instancia del UserControl ucReporteCompra
            panelContenido.Controls.Clear();
            reporteCompra.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(reporteCompra);
        }

        private void reporteVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucReporteVenta reporteVenta = new ucReporteVenta(); // Crea una instancia del UserControl ucReporteVenta
            panelContenido.Controls.Clear();
            reporteVenta.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(reporteVenta);
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserControl2 usuarios = new UserControl2(); // Crea una instancia del UserControl ucUsuarios
            panelContenido.Controls.Clear();// Limpia los controles existentes en el panelContenido
            usuarios.Dock = DockStyle.Fill; // Ajusta el UserControl para que ocupe todo el espacio del panelContenido
            panelContenido.Controls.Add(usuarios); // Agrega el UserControl al panelContenido
       
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verClientes clientes = new verClientes(); // Crea una instancia del UserControl verClientes
            panelContenido.Controls.Clear(); // Limpia los controles existentes en el panelContenido
            clientes.Dock = DockStyle.Fill; // Ajusta el UserControl para que ocupe todo el espacio del panelContenido
            panelContenido.Controls.Add(clientes); // Agrega el UserControl al panelContenido
        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null; // Remueve el foco del control de texto para evitar que se seleccione al entrar
        }

        private void textNumDocu_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null; // Remueve el foco del control de texto para evitar que se seleccione al entrar
        }
    }
}
