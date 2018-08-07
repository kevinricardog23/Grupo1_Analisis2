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
using prototipo01.Clases;

namespace prototipo01.forms.curso
{
    public partial class Listado_curso : Form
    {


        ControladorCursos controladorCursos = new ControladorCursos(); //LOGICA CRUD CURSOIS
        BindingList<cursosDto> cursosDataSource = new BindingList<cursosDto>(); //LISTA CURSOS
        private int ID_reference;

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

        //BUSCAR POR INICIALES
        void search()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            cursosDataSource = controladorCursos.listadoCursosPorCaracter(textBox1.Text.ToString());
            dataGridView1.DataSource = cursosDataSource;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

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
            button1.Enabled = privilegios.bandera;
            button2.Enabled = privilegios.bandera;
            button3.Enabled = privilegios.bandera;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ID_reference != 0)
            {
                openForm(new Cursos_Update(ID_reference));
            }
            else
            {
                MessageBox.Show("Por favor seleccione un curso");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                ID_reference = Convert.ToInt32(selectedRow.Cells[0].Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de elimiar el curso?", "Eliminar", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                controladorCursos.eliminarCursos(ID_reference);
                refreshDataSource();
            }
        }
    }
}
