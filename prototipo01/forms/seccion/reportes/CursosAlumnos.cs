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
    public partial class CursosAlumnos : Form
    {
        ControladorReports cr = new ControladorReports();

        public CursosAlumnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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

        void getCarne()
        {
            comboBox1.DataSource = cr.getAlumnos();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "carnet";
        }

        private void CursosAlumnos_Load(object sender, EventArgs e)
        {
            getCarne();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            forms.seccion.reportes.viewAsignacionCursos asig = new forms.seccion.reportes.viewAsignacionCursos(cr.getdpi(comboBox1.Text.ToString()));
            asig.Show();
        }
    }
}
