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

        private void txtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


            openForm(new Listado_estudiante());

        }

     
        private void txtBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void txtBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {

        }

        private void txtBox1_Validated(object sender, EventArgs e)
        {
            if (txtBox1.Text.Trim() == "")
            {
                epError_Nombres.SetError(txtBox1, "Introduce Nombre para el estudiante");
                txtBox1.Focus();
            }
            else
            {
                epError_Nombres.Clear();
            }
        }

        private void txtBox2_Validated(object sender, EventArgs e)
        {
            if (txtBox2.Text.Trim() == "")
            {
                epError_Apellidos.SetError(txtBox2, "Introduce apellidos del estudiante");
                txtBox2.Focus();
            }
            else
            {
                epError_Apellidos.Clear();
            }
        }

        private void txtBox3_Validated(object sender, EventArgs e)
        {
            if (txtBox3.Text.Trim() == "")
            {
                epError_Pass.SetError(txtBox3, "Introduce la contraseña del estudiante");
                txtBox3.Focus();
            }
            else
            {
                epError_Pass.Clear();
            }
        }

        private void txtBox4_Validated(object sender, EventArgs e)
        {
            if (txtBox4.Text.Trim() == "")
            {
                epError_Correo.SetError(txtBox4, "Introduce un correo del estudiante");
                txtBox4.Focus();
            }
            else
            {
                epError_Correo.Clear();
            }
        }

        private void txtBox5_Validated(object sender, EventArgs e)
        {
            if (txtBox5.Text.Trim() == "")
            {
                epError_Tel.SetError(txtBox5, "Introduce direccion del estudiante");
                txtBox5.Focus();
            }
            else
            {
                epError_Tel.Clear();
            }
        }

        private void txtBox6_Validated(object sender, EventArgs e)
        {
            if (txtBox6.Text.Trim() == "")
            {
                epError_Direccion.SetError(txtBox6, "Introduce telefono del estudiante");
                txtBox6.Focus();
            }
            else
            {
                epError_Direccion.Clear();
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
//Se aplicaron las normas de estandarizacion de codigo