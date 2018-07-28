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

namespace prototipo01.forms.salones
{



    public partial class Salones_Update : Form


    {
        ControladorSalones controladorSalones = new ControladorSalones();
        private int reference;
        public Salones_Update(int ID_reference)
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
            salon Model = controladorSalones.buscarSalon(reference);

            Txt_capacidad.Text = Model.capacidad_salon.ToString();
            Cbo_edificio.Text = Model.EDIFICIO_id_edificio.ToString();

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new listaSalones());
        }
        void updateSalon()
        {

            string capacidad;
            int ID_edificio;

            capacidad = Txt_capacidad.Text.ToString();
            ID_edificio = controladorSalones.getIdEdificio(Cbo_edificio.Text.ToString());



            controladorSalones.actualizarSalon(reference,capacidad, ID_edificio); MessageBox.Show("Se ha actualizado exitosamente el salon", "Actualizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_capacidad.Text) || string.IsNullOrEmpty(Cbo_edificio.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                updateSalon();
            }
        }
        private void dataEdificios()
        {
            Cbo_edificio.DataSource = controladorSalones.getEdificios();
            Cbo_edificio.DisplayMember = "Name";
            Cbo_edificio.ValueMember = "nombre_edificio";


        }
        private void Salones_Update_Load(object sender, EventArgs e)
        {

            dataEdificios();
            setData();
        }

        private void Txt_capacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }
    }
}
