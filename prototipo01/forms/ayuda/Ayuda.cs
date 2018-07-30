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
                case "Edificios":
                    label2.Text = "Edificios: \n\nEn el siguiente bloque de programa usted podra consultar los diferentes edificios de la UMG, podra ver los salones disponibles y los que se encuentra ocupados por clases o laboratorios.";
                    break;
                case "Salones":
                    label2.Text = "Salones: \n\nEn esta area usted podra crear y eliminar los salones deseados y poder visualizarlos en pantalla. \n el boton crear redirecciona a un formurario que debera llenar  asi mismo con la opcion de editar el cual debe seleccionar el dato de la tabla que desea editar y esta le desplega el formulario para editar la informacion si desea borrar debe de seleccionar la fila y presionar en eliminar";
                    break;
                case "Secciones":
                    label2.Text = "Secciones: \n\nEn esta area usted podra crear y eliminar Secciones para los cursos que desea ademas que poder visualizarlos en pantalla.";
                    break;
                case "Laboratorios":
                    label2.Text = "Laboratorios: \n\nEn el siguiente bloque de programa usted podra consultar el pensum actual, asi como los antiguos, para darle la opcion de investigar los cursos que comprenden ciertas carreras.";
                    break;
                case "Facultades":
                    label2.Text = "Facultades: \n\nEn el siguiente bloque de programa usted podra consultar, actulizar y eliminar facultades. BOTON CREAR: Al presionar este boton se desplegara una nueva pantalla donde podra ingresar una nueva facultad. BOTON ACTUALIZAR: Podra modificar la facultad de tiene seleccionada (para seleccionar solo debe dar click sobre ella). ";
                    break;
                case "Carreras":
                    label2.Text = "Carreras: \n\nEn el siguiente bloque de programa usted podra consultar, actulizar y eliminar las carreras, esto con el objetivo de darle a usted, el usuario, la capacidad de personalizar su sistema a sus necesidades.";
                    break;
                case "Pensum":
                    label2.Text = "Pensum: \nEn el siguiente bloque de programa usted podra consultar el pensum actual, asi como los antiguos. Para buscar un pensum debera ingresar el nombre del pensum. El boton de CREAR le ayudara para crear un nuevo pensum en el cual solo debe seleccionar la carrera e ingresar el nombre que identificara el pensum.\n Si desea modificar un pensum seleccionara el pensum que desea modificar y luego presionar el boton de 'EDITAR'. Para eliminar un Pensum debera seleccionar el pensum que desea eliminar y luego presionar el boton de ELIMINAR.";
                    break;
                case "Cursos":
                    label2.Text = "Cursos: \n\nEn el siguiente bloque de programa usted podra consultar los cursos asi como los datos que conllevan estos, salones, secciones, catedraticos, etc. Esto con un fin informativo.\nPara buscar informacion, ingrese los datos a buscar en la barra de abajo, para crear un nuevo curso, presione el boton de crear (verde), esto deplegara una pantalla donde usted debera ingresar sus campos, asegurese de que su informacion sea la correcta, para modificar presione el boton de editar (azul), este le desplegara una ventana en la cual usted podra editar los campos que desee, por ultimo para eliminar la informacion seleccione el dato que desea eliminar y presione el boton de eliminar (rojo), y el dato se eliminara.";
                    //Victor Hugo Jimenez Zepeda      ->Actualizacion de ayuda.
                    break;
                default:
                    label2.Text = "Por favor seleccione un bloque de la barra lateral para poder ayudarlo.";
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
