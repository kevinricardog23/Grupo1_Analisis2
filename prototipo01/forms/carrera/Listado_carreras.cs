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
using prototipo01.Dto;

namespace prototipo01.forms.carrera
{
    public partial class Listado_carreras : Form
    {

        ControladorCarrera controladorCarrera = new ControladorCarrera();
        BindingList<carreraDto> carrerasDataSource = new BindingList<carreraDto>();

        private int ID_reference;

        private void refreshDataSource()
        {
            this.Dgv_carreras.DataSource = null;
            this.Dgv_carreras.Rows.Clear();
            carrerasDataSource = controladorCarrera.listaCarreras();
            Dgv_carreras.DataSource = carrerasDataSource;

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
        public Listado_carreras()
        {
            InitializeComponent();
        }

        private void Listado_carreras_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
