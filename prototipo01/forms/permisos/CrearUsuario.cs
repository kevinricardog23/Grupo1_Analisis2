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

namespace prototipo01.forms.permisos
{
    public partial class CrearUsuario : Form
    {
        ControladorUsuario controladorUsuario = new ControladorUsuario();

        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            controladorUsuario.guardarUsuario("andres8m", "Andrés", "Canú", "zxcv", "andres8m@hotmail.com", "24454545");
        }
    }
}
