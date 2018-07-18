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
    public partial class listaSalones : Form
    {
        public listaSalones()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salon_Update sup = new Salon_Update();
            sup.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Salon_Create scre = new Salon_Create();
            scre.Show();   
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //dash ds = new dash();
            //ds.Show();

            //this.Dispose();
        }

        private void listaSalones_Load(object sender, EventArgs e)
        {

        }
    }
}
