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

        private void menuStripTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuGerente_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Maximizar la ventana al cargar
            this.SelectNextControl(this.ActiveControl, true, true, true, true); // Seleccionar el siguiente control en el formulario
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

        private void textUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUsuario_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null; // Evitar que el TextBox reciba el foco al hacer clic en él
        }

        private void textNumDocu_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null; // Evitar que el TextBox reciba el foco al hacer clic en él
        }
    }
}
