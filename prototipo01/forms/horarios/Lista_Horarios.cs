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

namespace prototipo01.forms.horarios
{
    public partial class Lista_Horarios : Form
    {


        ControladorHorarios controladorhorarios = new ControladorHorarios(); //LOGICA CRUD HORARIOS
        BindingList<horariosDto> horariosDataSource = new BindingList<horariosDto>(); //LISTA HORARIOS
        private int ID_reference;

        public Lista_Horarios()
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

        private void refreshDataSource()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            horariosDataSource = controladorhorarios.listaHorarios();
            dataGridView1.DataSource = horariosDataSource;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de elimiar el horario?", "Eliminar", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                controladorhorarios.eliminarhorario(ID_reference);
                //CONTROL BICORA
                ControladorBitacora controladorBitacora = new ControladorBitacora();
                controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Eliminacion de Horarios");
                refreshDataSource();
            }
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

        private void Lista_Horarios_Load(object sender, EventArgs e)
        {
            refreshDataSource();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openForm(new Horarios_create());
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new Seccion_Create());
        }
    }
}
