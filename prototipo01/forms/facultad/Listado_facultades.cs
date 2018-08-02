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

namespace prototipo01.forms.facultad
{
    public partial class Listado_facultades : Form
    {

        ControladorFacultades controladorFacultades = new ControladorFacultades();
        BindingList<facultadesDto> facultadesDataSource = new BindingList<facultadesDto>();

        private int ID_reference;

        public Listado_facultades()
        {
            InitializeComponent();
        }

        private void refreshDataSource()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            facultadesDataSource = controladorFacultades.listaFacultades();
            dataGridView1.DataSource = facultadesDataSource;
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
            openForm(new Facultad_Create());
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_buscar.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openForm(new Facultad_Update (ID_reference));
        }


        //Cargar datasource a datagridview
        void setData()
        {
            refreshDataSource();
        }

        //buscar por iniciales 
        void search()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            facultadesDataSource = controladorFacultades.listaFacultadesLike(Txt_buscar.Text.ToString());
            dataGridView1.DataSource = facultadesDataSource;

        }

        private void Listado_facultades_Load(object sender, EventArgs e)
        {
            button1.Enabled = privilegios.bandera;
            button2.Enabled = privilegios.bandera;
            button3.Enabled = privilegios.bandera;
            setData();
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

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("¿Esta seguro de elimiar el catedratico?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                controladorFacultades.eliminarFacultad(ID_reference);
                refreshDataSource();
            }
        }
    }
}
//Valery