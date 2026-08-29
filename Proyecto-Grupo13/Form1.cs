using Proyecto_Grupo13.Administrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Grupo13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            menuAdmin menuAdmin = new menuAdmin();
            menuAdmin.Show();
        }
    }
}
