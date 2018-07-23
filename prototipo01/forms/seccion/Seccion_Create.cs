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

namespace prototipo01
{
    public partial class Seccion_Create : Form
    {
        ControladorSecciones controladorSecciones = new ControladorSecciones();

        public Seccion_Create()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //listaSecciones listsec = new listaSecciones();
            //listsec.Show();

            this.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Nombre.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(Txt_Estado.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((string.IsNullOrEmpty(Txt_Nombre.Text)) == false && (string.IsNullOrEmpty(Txt_Estado.Text)== false))
            {

                string nombre = Txt_Nombre.Text.ToString();
                string estado = Txt_Estado.Text.ToString();

                controladorSecciones.guardarSeccion(nombre,estado);
            }


        }
    }
}
