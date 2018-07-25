using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prototipo01.models;
using prototipo01.Dto;
using prototipo01.controladores;

namespace prototipo01
{
    public partial class listaSecciones : Form
    {
       
        BindingList<seccionDto> seccionesDataSource = new BindingList<seccionDto>();
        ControladorSecciones controladorSecciones = new ControladorSecciones();

        private int ID_reference;

        public listaSecciones()
        {
            InitializeComponent();
        }


        private void refreshDataSource()
        {
            this.Dgv_ListaSecciones.DataSource = null;
            this.Dgv_ListaSecciones.Rows.Clear();
            seccionesDataSource = controladorSecciones.listaSecciones();
            Dgv_ListaSecciones.DataSource = seccionesDataSource;

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




        //BUSCAR POR INICIALES
        void search()
        {
            this.Dgv_ListaSecciones.DataSource = null;
            this.Dgv_ListaSecciones.Rows.Clear();
            seccionesDataSource = controladorSecciones.listaSeccionesLike(Txt_Buscar.Text.ToString());
            Dgv_ListaSecciones.DataSource = seccionesDataSource;
        }




        private void button3_Click(object sender, EventArgs e)
        {
            openForm(new Seccion_Update(ID_reference));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de elimiar la Seccion?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                controladorSecciones.eliminarSeccion(ID_reference);
                refreshDataSource();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new Seccion_Create());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //dash ds = new dash();
            //ds.Show();

            //this.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void listaSecciones_Load(object sender, EventArgs e)
        {
            refreshDataSource();
        }

        private void Dgv_ListaSecciones_SelectionChanged(object sender, EventArgs e)
        {
            if (Dgv_ListaSecciones.SelectedCells.Count > 0)
            {
                int selectedrowindex = Dgv_ListaSecciones.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = Dgv_ListaSecciones.Rows[selectedrowindex];

                ID_reference = Convert.ToInt32(selectedRow.Cells[0].Value);

            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            refreshDataSource();
        }
    }
}
