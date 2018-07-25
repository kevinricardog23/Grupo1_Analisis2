using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.forms.catedraticos
{
    public partial class Catedratico_Update : Form
    {
        public Catedratico_Update()
        {
            InitializeComponent();
        }

        private void openForm(object formHijo)
        {
            this.Controls.Clear();
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Controls.Add(fh);
            this.Tag = fh;
            fh.Show();

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openForm(new listaCatedraticos());

        }

        private void txtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void txtBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox1.Text) || string.IsNullOrEmpty(txtBox2.Text) || string.IsNullOrEmpty(txtBox3.Text) || string.IsNullOrEmpty(txtBox4.Text) || string.IsNullOrEmpty(txtBox5.Text) || string.IsNullOrEmpty(txtBox6.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
