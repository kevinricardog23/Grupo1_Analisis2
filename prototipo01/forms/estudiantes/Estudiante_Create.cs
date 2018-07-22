using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.forms.estudiante
{
    public partial class Estudiante_Create : Form
    {
        public Estudiante_Create()
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


            openForm(new Listado_estudiante());

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")                 
            {
                epError_Nombres.SetError(textBox1, "Introduce Nombre para el estudiante");
                textBox1.Focus();
            }
            else
            {
                epError_Nombres.Clear();
            }

            if (textBox2.Text.Trim() == "")
            {
                epError_Apellidos.SetError(textBox2, "Introduce apellidos del estudiante");
                textBox2.Focus();
            }
            else
            {
                epError_Apellidos.Clear();
            }

            if (textBox3.Text.Trim() == "")
            {
                epError_Pass.SetError(textBox3, "Introduce la contraseña del estudiante");
                textBox3.Focus();
            }
            else
            {
                epError_Pass.Clear();
            }

            if (textBox4.Text.Trim() == "")
            {
                epError_Correo.SetError(textBox4, "Introduce un correo del estudiante");
                textBox4.Focus();
            }
            else
            {
                epError_Correo.Clear();
            }

            if (textBox5.Text.Trim() == "")
            {
                epError_Tel.SetError(textBox5, "Introduce el telefono del estudiante");
                textBox5.Focus();
            }
            else
            {
                epError_Tel.Clear();
            }

            if (textBox6.Text.Trim() == "")
            {
                epError_Direccion.SetError(textBox6, "Introduce la direccion del estudiante");
                textBox6.Focus();
            }
            else
            {
                epError_Direccion.Clear();
            }
        }
    }
}
