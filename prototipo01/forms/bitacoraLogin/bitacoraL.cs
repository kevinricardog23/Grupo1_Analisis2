using prototipo01.controladores;
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

namespace prototipo01.forms.bitacoraLogin
{
    public partial class bitacoraL : Form
    {

        ControladorBitacora controladorBitacora = new ControladorBitacora();
        BindingList<bitacoraDto> usuarioDataSource = new BindingList<bitacoraDto>();

        public bitacoraL()
        {
            InitializeComponent();
            refreshGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //SOBREPONER FORM EN PANEL
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
            usuarioDataSource = controladorBitacora.listaBitacora();
            dataGridView1.DataSource = usuarioDataSource;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new permisos.Permisos());
        }
    }
}
