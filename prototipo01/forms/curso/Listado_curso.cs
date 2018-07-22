using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.forms.curso
{
    public partial class Listado_curso : Form
    {
        public Listado_curso()
        {
            InitializeComponent();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim()=="")
            {
                epError.SetError(textBox1, "Introduce ID de Curso");
                textBox1.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }
    }
}
