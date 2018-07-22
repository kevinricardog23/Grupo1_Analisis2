using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.forms.seccion.reportes
{
    public partial class AlumnosxCarrera : Form
    {
        public AlumnosxCarrera()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_CodFacu.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(Txt_CodCarrera.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(Cbo_Jornada.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
