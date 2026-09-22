using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Grupo13.Gerente
{
    public partial class menuGerente : Form
    {
        public menuGerente()
        {
            InitializeComponent();
        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reporteCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucEstadisticasV estadisticas = new ucEstadisticasV(); // Crear una instancia del UserControl
            estadisticas.Dock = DockStyle.Fill; // Ajustar el UserControl para que ocupe todo el espacio del panel
            panelContenido.Controls.Clear(); // Limpiar cualquier control existente en el panel
            panelContenido.Controls.Add(estadisticas); // Agregar el UserControl al panel
        }

        private void iconMenuProdVendidos_Click(object sender, EventArgs e)
        {
            ucMasVendidos prodMasVendidos = new ucMasVendidos(); // Crear una instancia del UserControl
            prodMasVendidos.Dock = DockStyle.Fill; // Ajustar el UserControl para que ocupe todo el espacio del panel
            panelContenido.Controls.Clear(); // Limpiar cualquier control existente en el panel
            panelContenido.Controls.Add(prodMasVendidos); // Agregar el UserControl al panel
        }
    }
}
