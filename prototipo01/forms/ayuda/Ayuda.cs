using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.forms.ayuda
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            switch (Dashboard.seleccionDeDashboard)
            {

                case "Salones":
                    label2.Text = "Salones: \n\nEn esta area usted podra crear y eliminar los salones deseados y poder visualizarlos en pantalla.";
                    break;
                case "Secciones":
                    label2.Text = "Secciones: \n\nEn esta area usted podra crear y eliminar Secciones para los cursos que desea ademas que poder visualizarlos en pantalla.";
                    break;
                case "Laboratorios":
                    label2.Text = "Laboratorios: \n\nEn el siguiente bloque de programa usted podra consultar el pensum actual, asi como los antiguos, para darle la opcion de investigar los cursos que comprenden ciertas carreras.";
                    break;




                case "Facultades":
                    label2.Text = "Facultades: \n\nEn el siguiente bloque de programa usted podra consultar, actulizar y eliminar facultades, esto con el objetivo de darle a usted, el usuario, la capacidad de personalizar su sistema a sus necesidades.";
                    break;
                case "Carreras":
                    label2.Text = "Carreras: \n\nEn el siguiente bloque de programa usted podra consultar, actulizar y eliminar las carreras, esto con el objetivo de darle a usted, el usuario, la capacidad de personalizar su sistema a sus necesidades.";
                    break;
                case "Pensum":
                    label2.Text = "Pensum: \n\nEn el siguiente bloque de programa usted podra consultar el pensum actual, asi como los antiguos, para darle la opcion de investigar los cursos que comprenden ciertas carreras.";
                    break;
                case "Cursos":
                    label2.Text = "Cursos: \n\nEn el siguiente bloque de programa usted podra consultar los cursos asi como los datos que conllevan estos, salones, secciones, catedraticos, etc. Esto con un fin informativo.";
                    break;
                default:
                    label2.Text = "Error de codigo.";
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
