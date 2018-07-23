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
using prototipo01.models;
using prototipo01.Dto;

namespace prototipo01
{
    public partial class listaSalones : Form
    {

        private int ID_reference;


        ControladorSalones controladorSalones = new ControladorSalones();
        BindingList<salonDto> edificiosDataSource = new BindingList<salonDto>();

        public listaSalones()
        {
            InitializeComponent();
        }



        private void refreshDataSource()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            edificiosDataSource = controladorSalones.listSalones();
            dataGridView1.DataSource = edificiosDataSource;

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Salon_Update sup = new Salon_Update(ID_reference);
            sup.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de elimiar el salon?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                controladorSalones.eliminarSalon(ID_reference);
                refreshDataSource();
            }
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
            refreshDataSource();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                ID_reference = Convert.ToInt32(selectedRow.Cells[0].Value);

            }

        }
    }
}
