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
    public partial class Seccion_Update : Form
    {
        public Seccion_Update()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //listaSecciones listsec = new listaSecciones();
            //listsec.Show();

            this.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
        }
    }
}
