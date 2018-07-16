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
    public partial class listaEdificios : Form
    {
        public listaEdificios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edificio_Create  ed = new Edificio_Create();
            ed.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edificion_Update edup = new Edificion_Update();
            edup.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
