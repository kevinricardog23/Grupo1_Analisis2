using prototipo01.forms.seccion.reportes;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            AlumnosxCatedratico alumnosc = new AlumnosxCatedratico();
            alumnosc.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CursosAlumnos cursosAlumnos = new CursosAlumnos();
            cursosAlumnos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

            AlumnosxCarrera scre = new AlumnosxCarrera();
            scre.Show();
        }
    }
}
