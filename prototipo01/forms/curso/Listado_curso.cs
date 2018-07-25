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

            if (txtBox1.Text.Trim() == "")
            {
                epError.SetError(txtBox1, "Introduce ID de Curso");
                txtBox1.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Crear_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Listado_curso_Load(object sender, EventArgs e)
        {

        }
    }
}
//Se aplicaron las normas de estandarizacion