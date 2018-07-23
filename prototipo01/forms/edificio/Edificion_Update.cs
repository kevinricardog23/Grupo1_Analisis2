
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
using prototipo01.models;


namespace prototipo01
{
    public partial class Edificion_Update : Form
    {

        ControladorEdificios controladorEdificios = new ControladorEdificios();
      

        public int reference;

        public Edificion_Update(int ID_reference)
        {
            InitializeComponent();
            reference = ID_reference;
        }


        //Set datos edificio
        private void setData()
        {
            edificio Model = controladorEdificios.buscarEdificio(reference);
            textBox1.Text = Model.nombre_edificio.ToString();
            textBox2.Text = Model.ubicacion_edificio.ToString();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listaEdificios listed = new listaEdificios();
            listed.Show();

            this.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            if (textBox1.Text.Trim() == "")
             {
                 epErrorNombre.SetError(textBox1, "Introduce Nombre para el edificio");
                 textBox1.Focus();
                
             }
             else
             {
                 epErrorNombre.Clear();
                
            }

             if (textBox2.Text.Trim() == "")
             {
                 epErrorDescripcion.SetError(textBox2, "Introduce una Descripcion");
                 textBox2.Focus();
              
            }
             else
             {
                 epErrorDescripcion.Clear();
               
            }
             

      

                TextBox objTextBox = (TextBox)textBox1;
                string nombre = objTextBox.Text;

                TextBox objTextBox2 = (TextBox)textBox2;
                string ubicacion = objTextBox2.Text;



                controladorEdificios.actualizarEdificio(reference, nombre, ubicacion);
         

        }

        private void Edificion_Update_Load(object sender, EventArgs e)
        {
            setData();

        }
    }
}
