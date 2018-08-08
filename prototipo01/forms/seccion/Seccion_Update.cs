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
using prototipo01.Clases;

namespace prototipo01
{
    public partial class Txt_ciclo : Form
    {

        ControladorSecciones controladorSecciones = new ControladorSecciones();
        private int reference;

        public Txt_ciclo(int id_reference)
        {
            InitializeComponent();
            reference = id_reference;
        }

        //Set datos seccion
        private void setData()
        {
            seccion_curso Model = controladorSecciones.buscarSeccion(reference);
            Txt_Nombre.Text = Model.seccion_seccion.ToString();
            Text_Estado.Text = Model.estado_seccion.ToString();
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

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            if (string.IsNullOrEmpty(Text_Estado.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }


            if ((string.IsNullOrEmpty(Text_Estado.Text) == false) &&(string.IsNullOrEmpty(Text_Estado.Text) == false))
            {

                string nombre = Txt_Nombre.Text.ToString();
                string estado = Txt_estado.Text.ToString();
                int catedratico = controladorSecciones.getIdCatedratico(cbo_catedratico.Text.ToString());
                int curso = controladorSecciones.getIdCurso(cbo_curso.Text.ToString());
                int laboratorio = controladorSecciones.getIdLaboratorio(cbo_laboratorio.Text.ToString());
                int salon = controladorSecciones.getIdSaon(cbo_salon.Text.ToString());
                int horario = controladorSecciones.getIdHorario(cbo_horario.Text.ToString());
                

                try
                { 
                controladorSecciones.actualizarSeccion(reference, nombre, estado, catedratico, curso, laboratorio, salon, horario, "octavo");
                MessageBox.Show("Informacion agregada correctamente", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Txt_Nombre.Text = "";
                Text_Estado.Text = "";
                    //CONTROL BICORA
                    ControladorBitacora controladorBitacora = new ControladorBitacora();
                    controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Editar Seccion.");
                }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        }

        private void Seccion_Update_Load(object sender, EventArgs e)
        {
            setData();

            dataCatedratico();
            dataSalon();
            dataHorario();
            dataCurso();
            dataLaboratorio();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new listaSecciones());
        }
    }
}
