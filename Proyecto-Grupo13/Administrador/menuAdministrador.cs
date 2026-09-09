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
        {
            UserControl2 usuarios = new UserControl2(); // Crea una instancia del UserControl ucUsuarios
            panelContenido.Controls.Clear();// Limpia los controles existentes en el panelContenido
            usuarios.Dock = DockStyle.Fill; // Ajusta el UserControl para que ocupe todo el espacio del panelContenido
            panelContenido.Controls.Add(usuarios); // Agrega el UserControl al panelContenido
        }

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

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucRegistrarV registrarV = new ucRegistrarV(); // Crea una instancia del UserControl ucRegistrarV
            panelContenido.Controls.Clear(); // Limpia los controles existentes en el panelContenido
            registrarV.Dock = DockStyle.Fill; // Ajusta el UserControl para que ocupe todo el espacio del panelContenido
            panelContenido.Controls.Add(registrarV); // Agrega el UserControl al panelContenido
        }
    }
}
