using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prototipo01.models;
using prototipo01.controladores;

namespace prototipo01
{
    public partial class Salon_Create : Form
    {


        ControladorSalones controladorSalones = new ControladorSalones();

        public Salon_Create()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listaSalones listsal = new listaSalones();
            listsal.Show();

            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Por favor ingrese todos los campos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


            int edificio = controladorSalones.getIdEdificio(comboBox1.Text.ToString());
            string nombre =textBox1.Text.ToString();
            string capacidad = textBox2.Text.ToString();



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                epError_Nombre.SetError(textBox1, "Ingrese nombre del salon");
                textBox1.Focus();
            }
            else
            {
                epError_Nombre.Clear();
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                epError_Capacidad.SetError(textBox2, "Ingrese la capacidad del salon");
                textBox2.Focus();
            }
            else
            {
                epError_Nombre.Clear();
            }
        }
    }
}
