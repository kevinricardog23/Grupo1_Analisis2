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
            controladorEdificios.guardarEdificio(textBox1.Text.ToString(), textBox2.Text.ToString());
        }
    }
}
