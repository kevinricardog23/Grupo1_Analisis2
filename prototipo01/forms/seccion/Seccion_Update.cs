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

namespace prototipo01
{
    public partial class Seccion_Update : Form
    {

        ControladorSecciones controladorSecciones = new ControladorSecciones();
        private int reference;

        public Seccion_Update(int id_reference)
        {
            InitializeComponent();
            reference = id_reference;
        }

        //Set datos seccion
        private void setData()
        {
            seccion Model = controladorSecciones.buscarSeccion(reference);
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
                string nombre_seccion = Txt_Nombre.Text.ToString();
                string estado_seccion = Text_Estado.Text.ToString();

                controladorSecciones.actualizarSeccion(reference,nombre_seccion,estado_seccion);
            }


        }

        private void Seccion_Update_Load(object sender, EventArgs e)
        {
            setData();
        }
    }
}
