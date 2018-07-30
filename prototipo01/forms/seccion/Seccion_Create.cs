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

namespace prototipo01
{
    public partial class Seccion_Create : Form
    {
        ControladorSecciones controladorSecciones = new ControladorSecciones();

        public Seccion_Create()
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



        private void dataCatedratico()
        {
            cbo_catedratico.DataSource = controladorSecciones.getCatedraticos();
            cbo_catedratico.DisplayMember = "Name";
            cbo_catedratico.ValueMember = "nombre_catedratico";
        }

        private void dataCurso()
        {
            cbo_curso.DataSource = controladorSecciones.getCursos();
            cbo_curso.DisplayMember = "Name";
            cbo_curso.ValueMember = "nombre_curso";
        }

        private void dataLaboratorio()
        {
            cbo_laboratorio.DataSource = controladorSecciones.getLaboratorios();
            cbo_laboratorio.DisplayMember = "Name";
            cbo_laboratorio.ValueMember = "descripcion_laboratorio";
        }



        private void dataSalon()
        {
            cbo_salon.DataSource = controladorSecciones.getSalones();
            cbo_salon.DisplayMember = "Name";
            cbo_salon.ValueMember = "nombre_salon";
        }



        private void dataHorario()
        {
            cbo_horario.DataSource = controladorSecciones.getHorarios();
            cbo_horario.DisplayMember = "Name";
            cbo_horario.ValueMember = "horario_horario";
        }











        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openForm(new listaSecciones());
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Nombre.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(Txt_Estado.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((string.IsNullOrEmpty(Txt_Nombre.Text)) == false && (string.IsNullOrEmpty(Txt_Estado.Text)== false))
            {

                string nombre = Txt_Nombre.Text.ToString();
                string estado = Txt_Estado.Text.ToString();



                try
                {
                    //controladorSecciones.guardarSeccion(nombre, estado);
                    MessageBox.Show("Informacion agregada correctamente", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Txt_Nombre.Text = "";
                    Txt_Estado.Text = "";
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }


        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new listaSecciones());
        }

        private void Seccion_Create_Load(object sender, EventArgs e)
        {
            dataCatedratico();
            dataSalon();
            dataHorario();
            dataCurso();
            dataLaboratorio();
        }
    }
}
