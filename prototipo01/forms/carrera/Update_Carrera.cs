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
            //    Cbo_edificio.Text = Model.EDIFICIO_id_edificio.ToString();
            Txt_jornada.Text = Model.jornada_carrera.ToString();

        }

        private void Lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void Btn_atras_Click(object sender, EventArgs e)
        {
            openForm(new Listado_carreras());
        }

        void updateSalon()
        {

            string jornada, nombre;
            int ID_facultad;

            nombre = Txt_nombre.Text.ToString();
            ID_facultad = controladorCarrera.getIdFacultad(Cbo_facultad.Text.ToString());
            jornada = Txt_nombre.Text.ToString();


            controladorCarrera.actualizarCarrera(reference, nombre, ID_facultad, jornada); MessageBox.Show("Se ha actualizado exitosamente el salon", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                updateSalon();
                Txt_jornada.Text = "";
                Cbo_facultad.Text = "";
                Txt_nombre.Text = "";
            }
        }
    }
}
