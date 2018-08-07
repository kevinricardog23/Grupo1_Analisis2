using prototipo01.Clases;
using prototipo01.controladores;
using prototipo01.Dto;
using prototipo01.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.forms.pensum
{
    public partial class Listado_pensum : Form
    {
        ControladorPensum controladorPensum = new ControladorPensum();
        BindingList<PensumDto> pensumsDataSource = new BindingList<PensumDto>();


        private int ID_reference;

        public Listado_pensum()
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
            openForm(new Pensum_Create());
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloLetras(e);
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Clases.Validacion.SoloNumeros(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        public void refreshGrid()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            pensumsDataSource = controladorPensum.listaPensum();
            dataGridView1.DataSource = pensumsDataSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*TextBox objTextBox = (TextBox)textBox2;
        
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                PensumDto cust = row.DataBoundItem as PensumDto;
                if (cust != null)
                {
                    objTextBox.Text = cust.nombre_pensum;
              
                }
            }*/

            openForm(new Pensum_Update(ID_reference));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de elimiar el pensum?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                controladorPensum.eliminarPensum(ID_reference);
                refreshGrid();
            }
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        void setData()//Cargar el datagridview
        {
            refreshGrid();
        }

        private void Listado_pensum_Load(object sender, EventArgs e)
        {
            setData();

            button1.Enabled = privilegios.bandera;
            button2.Enabled = privilegios.bandera;
            button3.Enabled = privilegios.bandera;

            this.Location = new Point(0, 0); //sobra si tienes la posición en el diseño
            this.Size = new Size(this.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
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

        //BUSCAR POR INICIALES
        void search()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            pensumsDataSource = controladorPensum.listaPensum(textBox1.Text.ToString());
            dataGridView1.DataSource = pensumsDataSource;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        //Williams De La Cuesta
    }
}
