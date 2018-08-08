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

namespace prototipo01.forms.catedraticos
{
    public partial class Catedratico_Create : Form
    {

        ControladorCatedraticos controladorCatedraticos = new ControladorCatedraticos();

        public Catedratico_Create()
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


        void createCatedratico()
        {

            string nombre, apellido, telefono, correo, direccion;
            int edad,dpi;

            
            dpi = Convert.ToInt32(textBox7.Text.ToString());
            nombre = textBox1.Text.ToString();
            apellido = textBox2.Text.ToString();
            telefono = textBox3.Text.ToString();
            correo = textBox4.Text.ToString();
            direccion = textBox5.Text.ToString();

            edad = Convert.ToInt32(textBox6.Text.ToString());

            controladorCatedraticos.guardarCatedratico(dpi,nombre,apellido,telefono,correo,edad,direccion);
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {
                try
                {
                    createCatedratico();
                    MessageBox.Show("Se ha agregado exitosamente un nuevo Catedratico", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    //CONTROL BICORA
                    ControladorBitacora controladorBitacora = new ControladorBitacora();
                    controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Crear Catedratico.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void Catedratico_Create_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new listaCatedraticos());
        }
    }
}
