
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


        private void openForm(object formHijo)
        {
           
            this.Controls.Clear();
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Controls.Add(fh);
            this.Tag = fh;
            fh.Show();

        }


        //Set datos edificio
        private void setData()
        {
            edificio Model = controladorEdificios.buscarEdificio(reference);
            txtBox1.Text = Model.nombre_edificio.ToString();
            txtBox2.Text = Model.ubicacion_edificio.ToString();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            openForm(new Btn_Buscar());
            this.Dispose();


        }

        private void txtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void txtBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Edificion_Update_Load(object sender, EventArgs e)
        {
            setData();

        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {


            if (txtBox1.Text.Trim() == "")
            {
                epErrorNombre.SetError(txtBox1, "Introduce Nombre para el edificio");
                txtBox1.Focus();

            }
            else
            {
                epErrorNombre.Clear();

            }

            if (txtBox2.Text.Trim() == "")
            {
                epErrorDescripcion.SetError(txtBox2, "Introduce una Descripcion");
                txtBox2.Focus();

            }
            else
            {
                epErrorDescripcion.Clear();

            }




            TextBox objTextBox = (TextBox)txtBox1;
            string nombre = objTextBox.Text;

            TextBox objTextBox2 = (TextBox)txtBox2;
            string ubicacion = objTextBox2.Text;



            controladorEdificios.actualizarEdificio(reference, nombre, ubicacion);

        }
    }
}
//Se aplicaron los normas de estandarizacion