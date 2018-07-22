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
    public partial class Edificio_Create : Form
    {
        public Edificio_Create()
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

        private void textBox1_Validated(object sender, EventArgs e)
        {
           
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                epError_Nombre.SetError(textBox1, "Introduce Nombre de Edificio");
                textBox1.Focus();
            }
            else
            {
                epError_Nombre.Clear();
            }

            if (textBox2.Text.Trim() == "")
            {
                epError_Descrip.SetError(textBox2, "Introduce una descripcion del edificio");
                textBox2.Focus();
            }
            else
            {
                epError_Descrip.Clear();
            }

            if (comboBox1.SelectedItem == null)
            {
                epError_Ubicacion.SetError(comboBox1, "Selecciona una opcion");
                comboBox1.Focus();
            }
            else
            {
                epError_Ubicacion.Clear();
            }

        }
    }
}
