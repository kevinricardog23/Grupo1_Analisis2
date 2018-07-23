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
    public partial class Salon_Update : Form
    {


        ControladorSalones controladorSalones = new ControladorSalones();
        private int referencia;

        public Salon_Update(int ID_ref)
        {
            InitializeComponent();
            referencia = ID_ref;
        }


        //Set datos edificio
        private void setData()
        {
            salon Model = controladorSalones.buscarSalon(referencia);
            textBox2.Text = Model.capacidad_salon.ToString();



        }

        //SET DATA COMBOBOX

        private void setCombo()
        {
            comboBox1.DataSource = controladorSalones.getEdificios();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "nombre_edificio";
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listaSalones listsal = new listaSalones();
            listsal.Show();

            this.Dispose();
        }
    }
}
