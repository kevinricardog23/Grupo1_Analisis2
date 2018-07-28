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

namespace prototipo01.forms.curso
{
    public partial class Cursos_Create : Form
    {
        ControladorCursos controladorCursos = new ControladorCursos();
        public Cursos_Create()
        {
            InitializeComponent();
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new Listado_curso());
        }


        void createCursos()
        {

            string nombre, ciclo, semestre;
            int id_curso, id_pensum;

            id_curso = Convert.ToInt32(txtbox_ID.Text.ToString());
            nombre = txtBox_nombre.Text.ToString();
            id_pensum = Convert.ToInt32(cmbBox_Pensum.Text.ToString());
            ciclo = txtBox_Ciclo.Text.ToString();
            semestre = txtBox_semestre.Text.ToString();

            controladorCursos.guardarCurso(id_curso, nombre, id_pensum, ciclo, semestre);
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_ID.Text) || string.IsNullOrEmpty(txtBox_nombre.Text) || string.IsNullOrEmpty(txtBox_Ciclo.Text) || string.IsNullOrEmpty(txtBox_semestre.Text) || string.IsNullOrEmpty(cmbBox_Pensum.Text)  )
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                createCursos();
                MessageBox.Show("Informacion agregada correctamente", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbox_ID.Text = "";
                txtBox_nombre.Text = "";
                txtBox_Ciclo.Text = "";
                txtBox_semestre.Text = "";
                cmbBox_Pensum.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
