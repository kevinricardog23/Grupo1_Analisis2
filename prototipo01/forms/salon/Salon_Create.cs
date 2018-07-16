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
    public partial class Salon_Create : Form
    {
        public Salon_Create()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listaSalones listsal = new listaSalones();
            listsal.Show();

            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
