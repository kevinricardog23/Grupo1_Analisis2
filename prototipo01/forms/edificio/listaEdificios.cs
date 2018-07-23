
using prototipo01.controladores;
using prototipo01.models;
using prototipo01.DTO;
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
    public partial class listaEdificios : Form
    {

        ControladorEdificios controladorEdificios = new ControladorEdificios();
        BindingList<edificioDto> edificiosDataSource = new BindingList<edificioDto>();

        private int ID_reference;
 

        public listaEdificios()
        {
            InitializeComponent();
           
            
        }


        private void refreshDataSource()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            edificiosDataSource = controladorEdificios.listaEdificios();
            dataGridView1.DataSource = edificiosDataSource;

        }




        private void button1_Click(object sender, EventArgs e)
        {
            Edificio_Create  ed = new Edificio_Create();
            ed.Show();
           // this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (ID_reference != 0)
            {
                Edificion_Update edup = new Edificion_Update(ID_reference);
                edup.Show();
                
            }else
            {
                MessageBox.Show("Por favor seleccione un edificio");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void dataGridView1_CurrentCellChanged(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void listaEdificios_Load_1(object sender, EventArgs e)
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

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)

        {

            DialogResult result = MessageBox.Show("¿Esta seguro de elimiar el edificio?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                controladorEdificios.eliminarEdificio(ID_reference);
                refreshDataSource();
            }


           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
