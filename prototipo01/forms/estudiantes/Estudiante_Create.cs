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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            openForm(new Listado_estudiante());

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
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
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
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                epError_Apellidos.SetError(textBox2, "Introduce apellidos del estudiante");
                textBox2.Focus();
            }
            else
            {
                epError_Apellidos.Clear();
            }
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            if (textBox3.Text.Trim() == "")
            {
                epError_Pass.SetError(textBox3, "Introduce la contraseña del estudiante");
                textBox3.Focus();
            }
            else
            {
                epError_Pass.Clear();
            }
        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
            if (textBox4.Text.Trim() == "")
            {
                epError_Correo.SetError(textBox4, "Introduce un correo del estudiante");
                textBox4.Focus();
            }
            else
            {
                epError_Correo.Clear();
            }
        }

        private void textBox5_Validated(object sender, EventArgs e)
        {
            if (textBox5.Text.Trim() == "")
            {
                epError_Tel.SetError(textBox5, "Introduce direccion del estudiante");
                textBox5.Focus();
            }
            else
            {
                epError_Tel.Clear();
            }
        }

        private void textBox6_Validated(object sender, EventArgs e)
        {
            if (textBox6.Text.Trim() == "")
            {
                epError_Direccion.SetError(textBox6, "Introduce telefono del estudiante");
                textBox6.Focus();
            }
            else
            {
                epError_Direccion.Clear();
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new Listado_estudiante());
        }
    }
}
