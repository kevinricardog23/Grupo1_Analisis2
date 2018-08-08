using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prototipo01.models;
using prototipo01.controladores;
using prototipo01.Clases;

namespace prototipo01.forms.curso
{
    public partial class Cursos_Update : Form
    {
        ControladorCursos controladorCursos = new ControladorCursos();
        public Cursos_Update()
        {
            InitializeComponent();
        }

        public int reference;

        //constructor
        public Cursos_Update(int ID_reference)
        {
            InitializeComponent();
            reference = ID_reference;
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new Listado_curso());
        }

        private void Cursos_Update_Load(object sender, EventArgs e)
        {
            setData();
        }

        //Cargar datos de cursos
        private void setData()
        {
            curso_model Model = controladorCursos.buscarCursos(reference);
            txtBox_nombre.Text = Model.nombre_curso.ToString();
            txtBox_Creditos.Text = Model.creditos.ToString();
            txtBox_semestre.Text = Model.semestre_curso.ToString();
            cmbBox_Pensum.Text = Model.PENSUM_id_pensum.ToString();
        }


        void updateCursos()
        {

            string nombre, semestre;
            int id_curso, id_pensum, creditos;

            id_curso = 0;
            nombre = txtBox_nombre.Text.ToString();
            id_pensum = Convert.ToInt32(cmbBox_Pensum.Text.ToString());
            creditos = Convert.ToInt32(txtBox_Creditos.Text.ToString());
            semestre = txtBox_semestre.Text.ToString();

            controladorCursos.actualizarCursos(reference,nombre, id_pensum, semestre, creditos);
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(txtBox_nombre.Text) || string.IsNullOrEmpty(txtBox_semestre.Text) || string.IsNullOrEmpty(txtBox_Creditos.Text) || string.IsNullOrEmpty(cmbBox_Pensum.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                updateCursos();
                MessageBox.Show("Informacion agregada correctamente", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //CONTROL BICORA
                ControladorBitacora controladorBitacora = new ControladorBitacora();
                controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Modificacion de Cursos");
                txtBox_nombre.Text = "";
                txtBox_Creditos.Text = "";
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
