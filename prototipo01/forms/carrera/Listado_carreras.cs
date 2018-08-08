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

namespace prototipo01.forms.carrera
{
    public partial class Listado_carreras : Form
    {

        ControladorCarrera controladorCarrera = new ControladorCarrera();
        BindingList<carreraDto> carrerasDataSource = new BindingList<carreraDto>();

        private int ID_reference;

        private void refreshDataSource()
        {
            this.Dgv_carreras.DataSource = null;
            this.Dgv_carreras.Rows.Clear();
            carrerasDataSource = controladorCarrera.listaCarreras();
            Dgv_carreras.DataSource = carrerasDataSource;

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
        public Listado_carreras()
        {
            InitializeComponent();
        }

        void setData()
        {
            refreshDataSource();
        }

        private void Listado_carreras_Load(object sender, EventArgs e)
        {
            button1.Enabled = privilegios.bandera;
            button2.Enabled = privilegios.bandera;
            button3.Enabled = privilegios.bandera;
            setData();

            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new Create_Carrea());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ID_reference != 0)
            {
                openForm(new Update_Carrera(ID_reference));
            }
            else
            {
                MessageBox.Show("Por favor seleccione una carrera");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de elimiar la carrera?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                controladorCarrera.eliminarCarrera(ID_reference);
                refreshDataSource();
            }
            ControladorBitacora controladorBitacora = new ControladorBitacora();
            controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Eliminar Carrera.");
        }

        private void Dgv_carreras_SelectionChanged(object sender, EventArgs e)
        {

            if (Dgv_carreras.SelectedCells.Count > 0)
            {
                int selectedrowindex = Dgv_carreras.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = Dgv_carreras.Rows[selectedrowindex];

                ID_reference = Convert.ToInt32(selectedRow.Cells[0].Value);

            }

        }

        private void Dgv_carreras_SelectionChanged_1(object sender, EventArgs e)
        {


            if (Dgv_carreras.SelectedCells.Count > 0)
            {
                int selectedrowindex = Dgv_carreras.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = Dgv_carreras.Rows[selectedrowindex];

                ID_reference = Convert.ToInt32(selectedRow.Cells[0].Value);

            }

        }
    }
}

//FREDY FLORES
