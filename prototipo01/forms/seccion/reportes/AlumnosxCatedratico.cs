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
using prototipo01.DTO;
using prototipo01.Dto;

namespace prototipo01.forms.seccion.reportes
{
    public partial class AlumnosxCatedratico : Form
    {

        ControladorEstudiante controladorEstudiante = new ControladorEstudiante();
        BindingList<AlumnosCurso> alumnosCursoDataSource = new BindingList<AlumnosCurso>(); 


        public AlumnosxCatedratico()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
        }

  
        private void AlumnosxCatedratico_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            forms.seccion.reportes.viewCatedraticos vcat = new forms.seccion.reportes.viewCatedraticos();
            vcat.Show();
        }
    }
}
