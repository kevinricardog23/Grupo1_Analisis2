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

namespace prototipo01.forms.seccion.reportes
{
    public partial class AlumnosxCarrera : Form
    {

        ControladorReports cr = new ControladorReports();


        public AlumnosxCarrera()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {



            viewAlumnosCarrera vc = new viewAlumnosCarrera(cr.getIdCarrera(comboBox1.Text.ToString()));
            vc.Show();
        }

        void getCarreras()
        {
            comboBox1.DataSource = cr.getCarreras();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "nombre_carrera";
        }

        private void AlumnosxCarrera_Load(object sender, EventArgs e)
        {
            getCarreras();
        }
    }
}
