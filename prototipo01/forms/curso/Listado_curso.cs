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
using prototipo01.Dto;

namespace prototipo01.forms.curso
{
    public partial class Listado_curso : Form
    {


        ControladorCursos controladorCursos = new ControladorCursos(); //LOGICA CRUD CURSOIS
        BindingList<cursosDto> cursosDataSource = new BindingList<cursosDto>(); //LISTA CURSOS

        public Listado_curso()
        {
            InitializeComponent();

            if (textBox1.Text.Trim() == "")
            {
                epError.SetError(textBox1, "Introduce informacion a buscar");
                textBox1.Focus();
            }
            else
            {
                epError.Clear();
            }
        }



        //REFRESCAR EL DATAGRIDVIEW
        private void refreshDataSource()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            cursosDataSource = controladorCursos.listaCursos();
            dataGridView1.DataSource = cursosDataSource;

        }


        //SOBREPONER FORM EN PANEL
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

        private void textBox1_Validated(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new Cursos_Create());
        }

        private void Listado_curso_Load(object sender, EventArgs e)
        {
            refreshDataSource();
        }
    }
}
