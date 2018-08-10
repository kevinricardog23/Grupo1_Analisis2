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

        alumno alumno = new alumno();



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

            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
            dgvCmb.ValueType = typeof(bool);
            dgvCmb.Name = "Chk";
            dgvCmb.HeaderText = "Asignar";
            dataGridView1.Columns.Add(dgvCmb);


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


            List<int> cursos = new List<int>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[5].Value))
                {
                    // what you want to do
                    cursos.Add(Convert.ToInt32(row.Cells[0].Value));

                }
            }


            foreach (int x in cursos)
            {
                seccion_curso sec = controladorCursos.buscarSeccionCurso(x);

                if (sec != null)
                {
                    controladorCursos.guardarSeccionEstudiante(sec.id_seccion, alumno.dpi_alumno);
                }

               
            }


            MessageBox.Show("Asignado correctamente", "Asignacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
   
            


        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Asignacion_Cursos_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String dpiStr = textBox1.Text + textBox2.Text + textBox3.Text;
            long numVal = Int64.Parse(dpiStr);

            alumno = controladorEstudiante.buscarEstudianteCarnet(dpiStr);

            if (alumno == null)
            {
                MessageBox.Show("Alumno no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show(alm.nombre_alumno + " " + alm.apellido_alumno, "Alumno encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelNombre.Text = alumno.nombre_alumno + " " + alumno.apellido_alumno;
                refreshDataSource();
            }
        }
    }
}
