using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prototipo01.controladores;
using prototipo01.Clases;

namespace prototipo01.forms.permisos
{
    public partial class CrearUsuario : Form
    {
        ControladorUsuario controladorUsuario = new ControladorUsuario();

        public CrearUsuario()
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
            this.Dispose();
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            if (Validacion.ValidarCorreo(textBoxEmail.Text) == true)
            {
                if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxApellidos.Text) || string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxAlias.Text) || string.IsNullOrEmpty(textBoxTelefono.Text) || string.IsNullOrEmpty(checkedListBox1.Text))
                {
                    MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    TextBox objTextBoxNombre = (TextBox)textBoxNombre;
                    TextBox objTextBoxApellidos = (TextBox)textBoxApellidos;
                    TextBox objTextBoxPass = (TextBox)textBoxPassword;
                    TextBox objTextBoxEmail = (TextBox)textBoxEmail;
                    TextBox objTextBoxUser = (TextBox)textBoxAlias;
                    TextBox objTextBoxTelefono = (TextBox)textBoxTelefono;

                    int nivel = 0;

                    if (checkedListBox1.SelectedIndex == 0)
                    {
                        nivel = 1;
                    }
                    else if (checkedListBox1.SelectedIndex == 1)
                    {
                        nivel = 2;
                    }


                    controladorUsuario.guardarUsuario(objTextBoxUser.Text, objTextBoxNombre.Text, objTextBoxApellidos.Text, objTextBoxPass.Text, objTextBoxEmail.Text, objTextBoxTelefono.Text, nivel);
                    MessageBox.Show("Informacion agregada correctamente", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxNombre.Text = "";
                    textBoxApellidos.Text = "";
                    textBoxPassword.Text = "";
                    textBoxEmail.Text = "";
                    textBoxAlias.Text = "";
                    textBoxTelefono.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingresa correctamente el correo", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void checkedListBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new Permisos());
        }
    }
}
