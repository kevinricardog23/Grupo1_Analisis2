using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01
{
    public partial class listaLaboratorios : Form
    {
        public listaLaboratorios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Laboratorio_Create lcre = new Laboratorio_Create();
            lcre.Show();

            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Laboratorio_Update lup = new Laboratorio_Update();
            lup.Show();

            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //dash pn = new dash();
            //pn.Show();

            //this.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
