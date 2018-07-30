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
using prototipo01.controladores;
using prototipo01.models;


namespace prototipo01.forms.facultad
{
    public partial class Facultad_Update : Form
    {

        ControladorFacultades controladorFacultades = new ControladorFacultades();

        private int reference;

        public Facultad_Update(int ID_reference)
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

        private void setData()
        {

            prototipo01.models.facultad Model = controladorFacultades.buscarFacultad(reference);

            Txt_nombre.Text = Model.nombre_facultad.ToString();
            textBox1.Text = Model.direccion_facultad.ToString();
            textBox2.Text = Model.telefono_facultad.ToString();
            textBox3.Text = Model.correo_facultad.ToString();
        }

        void updateFacultad()
        {
            string nombre, direccion, telefono, correo;
           // int ID_facultad;

             nombre = Txt_nombre.Text.ToString();
            direccion = textBox1.Text.ToString();
            telefono = textBox2.Text.ToString();
            correo = textBox3.Text.ToString();

            controladorFacultades.actualizarFacultad(reference, nombre, direccion, telefono, correo);
           // MessageBox.Show("Se ha actualizado exitosamente la facultad", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nombre = Txt_nombre.Text.ToString();
            //ID_facultad = controladorFacultades.getId_
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new Listado_facultades());
        }

               
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_nombre.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {
                try
                {
                    updateFacultad();
                    MessageBox.Show("Se ha modificado exitosamente la facultad", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txt_nombre.Text = "";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edicion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Facultad_Update_Load(object sender, EventArgs e)
        {
            setData();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
//Valery