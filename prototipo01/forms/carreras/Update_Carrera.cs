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

        ControladorCarrera ControladorCarrera = new ControladorCarrera();
        public int reference;
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
            carrera Model = controladorCarrera.buscarCarrera(reference);

            Txt_nombre.Text = Model.nombre_carrera.ToString();
            Txt_jornada.Text = Model.jornada_carrera.ToString();
            Cbo_facultad.Text = Model.FACULTAD_id_facultad.ToString();

        }
    }
}
