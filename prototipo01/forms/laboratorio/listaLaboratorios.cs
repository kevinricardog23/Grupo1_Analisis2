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

namespace prototipo01
{
    public partial class listaLaboratorios : Form
    {

        BindingList<laboratorioDto> laboratorioDataSource = new BindingList<laboratorioDto>();
        ControladorLaboratorio controladorLaboratorio = new ControladorLaboratorio();

        private int ID_reference;

        public listaLaboratorios()
        {
            InitializeComponent();
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


        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new Laboratorio_Create());
        }


        private void refreshDataSource()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            laboratorioDataSource = controladorLaboratorio.listLaboratorios();
            dataGridView1.DataSource = laboratorioDataSource;

        }



        private void button3_Click(object sender, EventArgs e)
        {
            openForm(new Laboratorio_Update(ID_reference));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de elimiar el Laboratorio", "Eliminar", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                controladorLaboratorio.eliminarLaboratorio(ID_reference);
                refreshDataSource();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void listaLaboratorios_Load(object sender, EventArgs e)
        {
            refreshDataSource();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
