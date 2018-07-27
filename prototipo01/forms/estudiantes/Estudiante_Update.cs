using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.forms.estudiante
{
    public partial class Estudiante_Update : Form
    {
        public Estudiante_Update()
        {
            InitializeComponent();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void Txt_Nombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void Txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            
                if (string.IsNullOrEmpty(Txt_Nombres.Text) || string.IsNullOrEmpty(Txt_Apellidos.Text) || string.IsNullOrEmpty(Txt_Contraseña.Text) || string.IsNullOrEmpty(Txt_Correo.Text) || string.IsNullOrEmpty(Txt_Direccion.Text) || string.IsNullOrEmpty(Txt_Telefono.Text))
                {
                    MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                
            }
        }

        private void Txt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new Listado_estudiante());
        }
    }
}
