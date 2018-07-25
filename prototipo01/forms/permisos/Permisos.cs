using prototipo01.controladores;
using prototipo01.forms.bitacoraLogin;
using prototipo01.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.forms.permisos
{
    public partial class Permisos : Form
    {

        ControladorUsuario controladorUsuario = new ControladorUsuario();
        BindingList<UsuarioDto> usuarioDataSource = new BindingList<UsuarioDto>();

        public Permisos()
        {
            InitializeComponent();
            refreshGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearUsuario ed = new CrearUsuario();
            ed.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        public void refreshGrid()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            usuarioDataSource = controladorUsuario.listaUsuarios();
            dataGridView1.DataSource = usuarioDataSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openForm(new bitacoraL());
        }
    }
}
