using prototipo01.controladores;
using prototipo01.Dto;
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

namespace prototipo01.forms.asignacion
{
    public partial class Asignacion_Cursos : Form
    {
        ControladorEstudiante controladorEstudiante = new ControladorEstudiante();
        ControladorCursos controladorCursos = new ControladorCursos(); //LOGICA CRUD CURSOIS
        BindingList<cursosDto> cursosDataSource = new BindingList<cursosDto>(); //LISTA CURSOS



        public Asignacion_Cursos()
        {
            InitializeComponent();
        
        }

        //REFRESCAR EL DATAGRIDVIEW
        private void refreshDataSource()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            cursosDataSource = controladorCursos.listaCursos();
            dataGridView1.DataSource = cursosDataSource;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Se han asignado los cursos exitosamente", "Asignacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

     /*   private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String dpiStr = textBox1.Text + textBox2.Text + textBox3.Text;       
            long numVal = Int64.Parse(dpiStr);

            alumno alm = controladorEstudiante.buscarEstudianteCarnet(dpiStr);

            if (alm == null)
            {
                MessageBox.Show("Alumno no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(alm.nombre_alumno + " " + alm.apellido_alumno , "Alumno encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refreshDataSource();
            }
            


        }*/
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Asignacion_Cursos_Load(object sender, EventArgs e)
        {
        }
    }
}
