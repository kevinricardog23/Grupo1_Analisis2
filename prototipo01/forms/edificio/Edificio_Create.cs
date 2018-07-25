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
    public partial class Edificio_Create : Form
    {
        ControladorEdificios controladorEdificios = new ControladorEdificios();
        

        public Edificio_Create()
        {
            InitializeComponent();
        }



        //SOBREPONER FORM EN PANEL
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            openForm(new listaEdificios());
        }

        

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            controladorEdificios.guardarEdificio(textBox1.Text.ToString(), textBox2.Text.ToString());
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                epError_Nombre.SetError(textBox1, "Introduce Nombre para el edificio");
                textBox1.Focus();
            }
            else
            {
                epError_Nombre.Clear();
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == "")
            {
                epError_Ubicacion.SetError(textBox2, "Introduce una ubicacion");
                textBox2.Focus();
            }
            else
            {
                epError_Ubicacion.Clear();
            }
        }
    }
}
