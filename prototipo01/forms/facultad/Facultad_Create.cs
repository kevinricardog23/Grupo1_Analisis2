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

namespace prototipo01.forms.facultad
{
    public partial class Facultad_Create : Form
    {

        ControladorFacultades controladorFacultades = new ControladorFacultades();

        public Facultad_Create()
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
            string nombre, direccion, telefono, correo;
           // int id;

           // id = Convert.ToInt32(Txt_id.Text.ToString());
            nombre = Txt_nombre.Text.ToString();
            direccion = textBox1.Text.ToString();
            telefono = textBox2.Text.ToString();
            correo = textBox3.Text.ToString();

            controladorFacultades.guardarFacultad(nombre, direccion, telefono, correo);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openForm(new Listado_facultades());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new Listado_facultades());
        }

        private void Facultad_Create_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (Validacion.ValidarCorreo(textBox3.Text) == true)
            {
                if (string.IsNullOrEmpty(Txt_nombre.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    try
                    {
                        createCatedratico();
                        MessageBox.Show("Se ha agregado exitosamente una nueva Facultad", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //Control bitacora
                        ControladorBitacora controladorBitacora = new ControladorBitacora();
                        controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Crear facultad");
                        //Txt_id.Text = "";
                        Txt_nombre.Text = "";
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingresa correctamente el correo", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
}
}
//Valery