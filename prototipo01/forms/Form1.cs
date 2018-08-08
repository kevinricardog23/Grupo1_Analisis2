using prototipo01.controladores;
using prototipo01.forms;
using prototipo01.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prototipo01.Clases;


namespace prototipo01
{
    public partial class Form1 : Form
    {
        

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

         
                //verficiacion de usuarios (LOGIN)
                if (string.IsNullOrEmpty(Txt_Correo.Text))
                {
                    MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(Txt_password.Text))
                {
                    MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                TextBox objTextBox = (TextBox)Txt_Correo;
                string email = objTextBox.Text;

                TextBox objTextBox2 = (TextBox)Txt_password;
                string pass = objTextBox2.Text;


                if (login(email,pass))
                {

                    ControladorUsuario controladorUsuario = new ControladorUsuario();

                    int n_privilegio = controladorUsuario.getNivelPrivilegio(email,pass);

                    if (n_privilegio == 1)
                    {
                        this.Hide();
                    
                    Dashboard dash = new Dashboard(n_privilegio);

                            
                        dash.Show();

                  
                        MessageBox.Show("Se ha ingresado exitosamente", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                    {
                        this.Hide();
                        Dashboard dash = new Dashboard(n_privilegio);
                        dash.Show();
                        MessageBox.Show("Se ha ingresado exitosamente", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }
                else
                {
                    MessageBox.Show("El usuario o contraseña es incorrecto", "Error de sesion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                  
        }





        public Boolean login(String correo, String password)
        {
            ControladorUsuario controladorUsuario = new ControladorUsuario();
            usuario user = controladorUsuario.buscarUsuarioCorreo(correo);

            if(user!=null)
            usuarioLogi.id_usuario = user.id_usuario;

            return controladorUsuario.login(user, password);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_password_Enter(object sender, EventArgs e)
        {
            
  
        }
    }


    

}
//eddy lopez, andres canu, jose arrecis