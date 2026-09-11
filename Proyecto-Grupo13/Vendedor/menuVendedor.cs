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
    }
}
