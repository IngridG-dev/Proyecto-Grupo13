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
    public partial class menuAdmin : Form
    {
        public menuAdmin()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ucUsuarios usuarios = new ucUsuarios(); // Crea una instancia del UserControl ucUsuarios
            panelContenido.Controls.Clear(); // Limpia los controles existentes en el panelContenido
            usuarios.Dock = DockStyle.Fill; // Ajusta el UserControl para que ocupe todo el espacio del panelContenido
            panelContenido.Controls.Add(usuarios); // Agrega el UserControl al panelContenido
        }
    }
}
