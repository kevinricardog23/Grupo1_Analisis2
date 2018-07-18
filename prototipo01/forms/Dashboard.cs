using prototipo01.forms.carrera;
using prototipo01.forms.curso;
using prototipo01.forms.facultad;
using prototipo01.forms.pensum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.forms
{
    //cH
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            openForm(new Home());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openForm(object formHijo)
        {
            if (this.container.Controls.Count > 0)       
                this.container.Controls.RemoveAt(0);
                Form fh = formHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.container.Controls.Add(fh);
                this.container.Tag = fh;
                fh.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openForm(new listaEdificios());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openForm(new listaSalones());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openForm(new listaSecciones());
        }
        //el
        private void button5_Click(object sender, EventArgs e)
        {
            openForm(new listaLaboratorios());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openForm(new Listado_facultades());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openForm(new Listado_carreras());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openForm(new Listado_pensum());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openForm(new Listado_curso());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new Home());
        }
    }
}
