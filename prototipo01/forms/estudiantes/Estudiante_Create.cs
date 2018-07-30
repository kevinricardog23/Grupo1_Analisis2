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
namespace prototipo01.forms.estudiante
{
    public partial class Estudiante_Create : Form
    {
        ControladorEstudiante controladorEstudiantes = new ControladorEstudiante();
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
        private void Estudiante_Create_Load(object sender, EventArgs e)
        {
            cbo_estudiante.DataSource = controladorEstudiantes.getCarreras();
            cbo_estudiante.DisplayMember = "name";
            cbo_estudiante.ValueMember = "nombre_carrera";
            //ASI COMO ESTE


            cbo_facultad.DataSource = controladorEstudiantes.getFacultades();
            cbo_facultad.DisplayMember = "name";
            cbo_facultad.ValueMember = "nombre_facultad";
        }
        void createAlumno()
        {

            string nombre, apellido,correo, direccion, telefono, estado;
            int edad, dpi, carrera, facultad;

            
            dpi = Convert.ToInt32(Txt_dpi.Text.ToString());
            nombre = textBox1.Text.ToString();
            apellido = textBox2.Text.ToString();
            correo = textBox4.Text.ToString();
            direccion = textBox5.Text.ToString();
            telefono = textBox6.Text.ToString();
            estado = Rbtn_estado.Text.ToString();
            edad = Convert.ToInt32(textBox3.Text.ToString());
            carrera = Convert.ToInt32(cbo_estudiante.Text.ToString());

            facultad = Convert.ToInt32(cbo_facultad.Text.ToString());
            controladorEstudiantes.guardarEstudiante(dpi, nombre, apellido, correo, direccion, edad, estado,telefono, facultad, carrera);
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
            if (string.IsNullOrEmpty(Txt_dpi.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*codigo kevin*/
            else
            {
                try
                {
                    createAlumno();
                    MessageBox.Show("Se ha agregado exitosamente un nuevo Estudiante", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    Txt_dpi.Text = "";
                    Rbtn_estado.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                epError_Direccion.Clear();
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
                epError_Tel.Clear();
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new Listado_estudiante());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        

        private void Txt_dpi_Validated(object sender, EventArgs e)
        {
           /* if (Txt_dpi.Text.Trim() == "")
            {
                epError_Dpi.SetError(Txt_dpi, "Introduce DPI del estudiante");
                textBox6.Focus();
            }
            else
            {
               epError_Dpi.Clear();
            }*/
        }
    }
}
