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


        private void button3_Click(object sender, EventArgs e)
        {
            Seccion_Update sup = new Seccion_Update(ID_reference);
            sup.Show();

            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de elimiar el edificio?", "Eliminar", MessageBoxButtons.YesNo);

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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Seccion_Create scre = new Seccion_Create();
            scre.Show();

            //this.Hide();
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
    }
}
