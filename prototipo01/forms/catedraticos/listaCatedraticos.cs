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
using prototipo01.Clases;

namespace prototipo01.forms.catedraticos
{
    public partial class listaCatedraticos : Form
    {


        ControladorCatedraticos controladorCatedraticos = new ControladorCatedraticos();
        BindingList<catedraticoDto> catedraticosDataSource = new BindingList<catedraticoDto>(); //LISTA CATEDRATICOS

        private int ID_reference;

        public listaCatedraticos()
        {
            InitializeComponent();
        }


        private void refreshDataSource()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            catedraticosDataSource = controladorCatedraticos.listaCatedraticos();
            dataGridView1.DataSource = catedraticosDataSource;

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
            openForm(new Catedratico_Create());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openForm(new Catedratico_Update(ID_reference));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        
        
        // PROCEDIMIENTO PARA CARGAR DATASOURCE A DATAGRIDVIEW
        void setData()
        {

            refreshDataSource();

        }


        //BUSCAR POR INICIALES
        void search()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            catedraticosDataSource = controladorCatedraticos.listaCatedraticosLike(textBox1.Text.ToString());
            dataGridView1.DataSource = catedraticosDataSource;
        }





        private void listaCatedraticos_Load(object sender, EventArgs e)
        {
            setData();
        
            button1.Enabled = privilegios.bandera;
            button2.Enabled = privilegios.bandera;
            button3.Enabled = privilegios.bandera;

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

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de elimiar el catedratico?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                
                controladorCatedraticos.eliminarCatedratico(ID_reference);

                refreshDataSource();
                //CONTROL BICORA
                ControladorBitacora controladorBitacora = new ControladorBitacora();
                controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Eliminar Catedratico");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            search();
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
