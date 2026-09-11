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
    public partial class ucVerDetalleV : UserControl
    {
        public ucVerDetalleV()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconBtnDescargar_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textMontoCambio_TextChanged(object sender, EventArgs e)
        {

        }

        //VALIDACIONES DE CAMPOS
        private void textnumDocume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textDocumentoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textNomCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten letras en este campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //CONFIGURACION DE BOTONES
        private void iconLimpiar_Click(object sender, EventArgs e)
        {
            textFecha.Clear();
            textnumDocume.Clear();
            textUsuario.Clear();
            textDocumentoCliente.Clear();
            textNomCliente.Clear();
            textTipoDoc.Clear();

            dataGridView2.Rows.Clear();
            textMontoTotal.Clear();
            textMontoPago.Clear();
            textMontoCambio.Clear();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
       