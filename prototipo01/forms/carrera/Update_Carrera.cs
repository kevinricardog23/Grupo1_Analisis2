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
    }
}
