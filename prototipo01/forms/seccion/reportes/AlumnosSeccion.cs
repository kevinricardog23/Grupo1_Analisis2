using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.forms.seccion.reportes
{
    public partial class AlumnosSeccion : Form
    {
        public AlumnosSeccion()
        {
            InitializeComponent();
        }

        private void AlumnosSeccion_Load(object sender, EventArgs e)
        {

        }

        public void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            Clases.Validacion.SoloNumeros(e);
          
        }

     
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }
    }
}
