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

        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new Laboratorio_Create());
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_buscar.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void listaLaboratorios_Load(object sender, EventArgs e)
        {

        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openForm(new Laboratorio_Update());
        }
    }
}
