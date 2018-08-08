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


namespace prototipo01.forms.carrera
{
    public partial class Update_Carrera : Form
    {

        ControladorCarrera controladorCarrera = new ControladorCarrera();
        private int reference;
        public Update_Carrera(int ID_reference)
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


        void setData()
        {
            prototipo01.models.carrera Model = controladorCarrera.buscarCarrera(reference);

            Txt_nombre.Text = Model.nombre_carrera.ToString();
            // Cbo_facultad.Text = Model.FACULTAD_id_facultad.ToString();
            Txt_jornada.Text = Model.jornada_carrera.ToString();

        }

        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_atras_Click(object sender, EventArgs e)
        {
            openForm(new Listado_carreras());
        }

        void updateCarrera()
        {

            string jornada, nombre;
            int ID_facultad;

            nombre = Txt_nombre.Text.ToString();
            ID_facultad = controladorCarrera.getIdFacultad(Cbo_facultad.Text.ToString());
            jornada = Txt_jornada.Text.ToString();


            controladorCarrera.actualizarCarrera(reference, nombre, ID_facultad, jornada); MessageBox.Show("Se ha actualizado exitosamente la carrera", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_nombre.Text) || string.IsNullOrEmpty(Cbo_facultad.Text) || string.IsNullOrEmpty(Txt_jornada.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                updateCarrera();
                MessageBox.Show("Se edito correctamente la carrera", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ControladorBitacora controladorBitacora = new ControladorBitacora();
                controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Editar Carrera.");
                Txt_nombre.Text = "";
                Txt_jornada.Text = "";
                dataFacultades();
               
            }



        }

        private void dataFacultades()
        {
            prototipo01.models.carrera Model = controladorCarrera.buscarCarrera(reference);
            Cbo_facultad.DataSource = controladorCarrera.getfacultades();
            Cbo_facultad.DisplayMember = "Name";
            Cbo_facultad.ValueMember = "nombre_facultad";


        }

        private void Txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void Txt_jornada_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void Update_Carrera_Load(object sender, EventArgs e)
        {
            setData();
            dataFacultades();

        }

        private void Update_Carrera_Load_1(object sender, EventArgs e)
        {
            setData();
            dataFacultades();

        }
    }
}
//FREDY FLORES