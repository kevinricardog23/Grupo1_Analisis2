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
        
        


        public Listado_pensum()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TextBox objTextBox = (TextBox)textBox2;
                string theText = objTextBox.Text;
               models.carrera res = comboBox1.SelectedItem as models.carrera;
               controladorPensum.guardarPensum(res.id_carrera, theText);
            }
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
            Clases.Validacion.SoloLetras(e);
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
            TextBox objTextBox = (TextBox)textBox2;
        
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                PensumDto cust = row.DataBoundItem as PensumDto;
                if (cust != null)
                {
                    objTextBox.Text = cust.nombre_pensum;
              
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Listado_pensum_Load(object sender, EventArgs e)
        {


            comboBox1.DataSource = controladorPensum.getCarreras();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "nombre_carrera";
        }
    }
}
