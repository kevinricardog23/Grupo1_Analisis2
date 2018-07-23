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

namespace prototipo01
{
    public partial class Salon_Create : Form
    {


        ControladorSalones controladorSalones = new ControladorSalones();

        public Salon_Create()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listaSalones listsal = new listaSalones();
            listsal.Show();

            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int edificio = controladorSalones.getIdEdificio(comboBox1.Text.ToString());
            string capacidad = textBox2.Text.ToString();

            controladorSalones.guardarSalon(capacidad,edificio);





        }

        private void Salon_Create_Load(object sender, EventArgs e)
        {

            comboBox1.DataSource = controladorSalones.getEdificios();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "nombre_edificio";

        }
    }
}
