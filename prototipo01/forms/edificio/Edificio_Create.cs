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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            


            this.Dispose();
        }

        

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            controladorEdificios.guardarEdificio(txtBox1.Text.ToString(), txtBox2.Text.ToString());
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (txtBox1.Text.Trim() == "")
            {
                epError_Nombre.SetError(txtBox1, "Introduce Nombre para el edificio");
                txtBox1.Focus();
            }
            else
            {
                epError_Nombre.Clear();
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            if (txtBox2.Text.Trim() == "")
            {
                epError_Ubicacion.SetError(txtBox2, "Introduce una ubicacion");
                txtBox2.Focus();
            }
            else
            {
                epError_Ubicacion.Clear();
            }
        }
    }
}
