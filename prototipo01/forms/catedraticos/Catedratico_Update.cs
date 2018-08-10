using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prototipo01.Dto;
using prototipo01.models;
using prototipo01.controladores;
using prototipo01.Clases;


namespace prototipo01.forms.catedraticos
{
    public partial class Catedratico_Update : Form
    {


        ControladorCatedraticos controladorCatedraticos = new ControladorCatedraticos();

        private int reference;


        public Catedratico_Update(int ID_reference)
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


        void updateCatedratico()
        {
            string nombre, apellido, telefono, correo, direccion;
            int edad;

            nombre = textBox1.Text.ToString();
            apellido = textBox2.Text.ToString();
            telefono = textBox3.Text.ToString();
            correo = textBox4.Text.ToString();
            direccion = textBox5.Text.ToString();

            edad = Convert.ToInt32(textBox6.Text.ToString());


            controladorCatedraticos.actualizarCatedratico(reference, nombre, apellido, telefono, correo, edad, direccion);
            MessageBox.Show("Se ha Actualizado exitosamente el catedratico", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        void setData()
        {
            catedratico Model = controladorCatedraticos.buscarCatedratico(reference);

            textBox1.Text = Model.nombre_catedratico.ToString();
            textBox2.Text = Model.apellido_catedratico.ToString();
            textBox3.Text = Model.telefono_catedratico.ToString();
            textBox4.Text = Model.correo_catedratico.ToString();
            textBox6.Text = Model.edad_catedratico.ToString();
            textBox5.Text = Model.direccion_catedratico.ToString();

        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openForm(new listaCatedraticos());

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validacion.ValidarCorreo(textBox4.Text) == true)
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text) || string.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {
                try
                {
                    updateCatedratico();
                    MessageBox.Show("Se ha modificado exitosamente un nuevo Catedratico", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    //CONTROL BICORA
                    ControladorBitacora controladorBitacora = new ControladorBitacora();
                    controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Editar Catedratico.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edicion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                }
            }
            else
            {
                MessageBox.Show("Porfavor ingresa correctamente el correo", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Catedratico_Update_Load(object sender, EventArgs e)
        {
            setData();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new listaCatedraticos());
        }
    }
}
