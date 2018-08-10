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
using prototipo01.models;
using prototipo01.Clases;

namespace prototipo01.forms.permisos
{
    public partial class EditarUsuario : Form
    {

        ControladorUsuario controladorUsuario = new ControladorUsuario();


        private int reference;

        public EditarUsuario(int ID_reference)
        {
            InitializeComponent();

            reference = ID_reference;
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



        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new permisos.Permisos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validacion.ValidarCorreo(textBoxEmail.Text) == true) { 
            if (string.IsNullOrEmpty(textBoxNombre.Text) || string.IsNullOrEmpty(textBoxApellidos.Text) || string.IsNullOrEmpty(textBoxPassword.Text) || string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxAlias.Text) || string.IsNullOrEmpty(textBoxTelefono.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ControladorUsuario controladorUsuario = new ControladorUsuario();

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
                    nivel = 0;
                }


                controladorUsuario.editarUsuario(reference,objTextBoxUser.Text, objTextBoxNombre.Text, objTextBoxApellidos.Text, objTextBoxPass.Text, objTextBoxEmail.Text, objTextBoxTelefono.Text, nivel);
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



        private void dataUsuario()
        {
            usuario Model = controladorUsuario.buscarUsuario(reference);

            textBoxNombre.Text = Model.nombre_usuario.ToString();
            textBoxApellidos.Text = Model.apellido_usuario.ToString();
            textBoxPassword.Text = Model.password_usuario.ToString();
            textBoxEmail.Text = Model.correo_usuario.ToString();
            textBoxTelefono.Text = Model.telefono_usuario.ToString();
            textBoxAlias.Text = Model.usuario_usuario.ToString();

            if (Model.nivel_privilegio == 0)
            {
                checkedListBox1.SetItemChecked(0,true);
            }
            else
            {
                checkedListBox1.SetItemChecked(1, true);
            }


          
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            dataUsuario();
        }
    }
}
