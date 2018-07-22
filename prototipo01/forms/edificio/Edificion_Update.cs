using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01
{
    public partial class Edificion_Update : Form
    {
        public Edificion_Update()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //listaEdificios listed = new listaEdificios();
            //listed.Show();

            this.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                epErrorNombre.SetError(textBox1, "Introduce Nombre para el edificio");
                textBox1.Focus();
            }
            else
            {
                epErrorNombre.Clear();
            }

            if (textBox2.Text.Trim() == "")
            {
                epErrorDescripcion.SetError(textBox1, "Introduce una Descripcion");
                textBox1.Focus();
            }
            else
            {
                epErrorDescripcion.Clear();
            }
        }
    }
}
