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
namespace prototipo01.forms.estudiante
{
    public partial class Estudiante_Update : Form
    {
        ControladorEstudiante controladorEstudiantes = new ControladorEstudiante();

        private int reference;
        public Estudiante_Update(int ID_reference)
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
        void updateEstudiante()
        {
            string nombre, apellido, telefono, correo, direccion, estado;
            int edad, carrera, facultad;

            nombre = Txt_Nombres.Text.ToString();
            apellido = Txt_Apellidos.Text.ToString();
            telefono = Txt_Telefono.Text.ToString();
            correo = Txt_Correo.Text.ToString();
            edad = Convert.ToInt32(Txt_edad.Text.ToString());
            direccion = Txt_Direccion.Text.ToString();
            estado = Txt_estado.Text.ToString();
            facultad = controladorEstudiantes.getIdFacultad(cbo_facultad.Text.ToString());
            carrera = controladorEstudiantes.getIdCarrera(cbo_carrera.Text.ToString());
           
           
           


            controladorEstudiantes.actualizarEstudiante(reference, nombre, apellido, telefono, correo, edad, direccion,carrera, facultad, estado);
            MessageBox.Show("Se ha Actualizado exitosamente el estudiante", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void setData()
        {
            alumno Model = controladorEstudiantes.buscarEstudiante(reference);

            Txt_Nombres.Text = Model.nombre_alumno.ToString();
            Txt_Apellidos.Text = Model.apellido_alumno.ToString();
            Txt_Telefono.Text = Model.telefono_alumno.ToString();
            Txt_Correo.Text = Model.correo_alumno.ToString();
            Txt_edad.Text = Model.edad_alumno.ToString();
            Txt_Direccion.Text = Model.direccion_alumno.ToString();
            Txt_estado.Text = Model.estado_alumno.ToString();
           
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openForm(new Listado_estudiante());
        }

        private void Txt_Nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void Txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            
                if (string.IsNullOrEmpty(Txt_Nombres.Text) || string.IsNullOrEmpty(Txt_Apellidos.Text) || string.IsNullOrEmpty(Txt_edad.Text) || string.IsNullOrEmpty(Txt_Correo.Text) || string.IsNullOrEmpty(Txt_Direccion.Text) || string.IsNullOrEmpty(Txt_Telefono.Text)|| string.IsNullOrEmpty(Txt_estado.Text))
                {
                    MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                
            }
            else
            {
                try
                {
                    updateEstudiante();
                    MessageBox.Show("Se ha modificado exitosamente un nuevo Estudiante", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ControladorBitacora controladorBitacora = new ControladorBitacora();
                    controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Editar Estudiante.");
                    Txt_Nombres.Text = "";
                    Txt_Apellidos.Text = "";
                    Txt_Telefono.Text = "";
                    Txt_Correo.Text = "";
                    Txt_edad.Text = "";
                    Txt_Direccion.Text = "";
                    Txt_estado.Text = "";
                   
              
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edicion de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void Txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new Listado_estudiante());
        }

        private void Estudiante_Update_Load(object sender, EventArgs e)
        {
            setData();
            cbo_carrera.DataSource = controladorEstudiantes.getCarreras();
            cbo_carrera.DisplayMember = "name";
            cbo_carrera.ValueMember = "nombre_carrera";


            cbo_facultad.DataSource = controladorEstudiantes.getFacultades();
            cbo_facultad.DisplayMember = "name";
            cbo_facultad.ValueMember = "nombre_facultad";
        }

        private void Lbl_Correo_Click(object sender, EventArgs e)
        {

        }
    }
}
