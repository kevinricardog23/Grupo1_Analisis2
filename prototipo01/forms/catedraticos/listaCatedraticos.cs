using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.forms.catedraticos
{
    public partial class listaCatedraticos : Form
    {
        public listaCatedraticos()
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

       /* private void button1_Click(object sender, EventArgs e)
        {
            openForm(new Catedratico_Create());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openForm(new Catedratico_Update());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox1.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        */
        private void Btn_Crear_Click(object sender, EventArgs e)
        {
            openForm(new Catedratico_Create());
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox1.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            openForm(new Catedratico_Update());
        }
    }
}
