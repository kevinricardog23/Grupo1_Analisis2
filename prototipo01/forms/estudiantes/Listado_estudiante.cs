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

namespace prototipo01.forms.estudiante
{
    public partial class Listado_estudiante : Form
    {

        ControladorEstudiante controladorEstudiantes = new ControladorEstudiante();
        BindingList<estudianteDto> alumnoDataSource = new BindingList<estudianteDto>();
        private int ID_reference;
        public Listado_estudiante()
        {
            InitializeComponent();
        }
        private void refreshDataSource()
        {
            this.Dgb_estudiantes.DataSource = null;
            this.Dgb_estudiantes.Rows.Clear();
            alumnoDataSource = controladorEstudiantes.Listado_estudiante();
            Dgb_estudiantes.DataSource = alumnoDataSource;

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
        void search()
        {
            this.Dgb_estudiantes.DataSource = null;
            this.Dgb_estudiantes.Rows.Clear();
            alumnoDataSource = controladorEstudiantes.listaEstudiantesLike(Txt_buscar.Text.ToString());
            Dgb_estudiantes.DataSource = alumnoDataSource;
        }
        private void Btn_crear_Click(object sender, EventArgs e)
        {
            openForm(new Estudiante_Create());

        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            openForm(new Estudiante_Update(ID_reference));
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {

            search();
            if (string.IsNullOrEmpty(Txt_buscar.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de eliminar el estudiante?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

               controladorEstudiantes.eliminarEstudiante(ID_reference);
                refreshDataSource();

            }
        }
        void setData()
        {

            refreshDataSource();

        }
        
        private void Dgb_estudiantes_SelectionChanged(object sender, EventArgs e)
        {

            if (Dgb_estudiantes.SelectedCells.Count > 0)
            {
                int selectedrowindex = Dgb_estudiantes.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = Dgb_estudiantes.Rows[selectedrowindex];

                ID_reference = Convert.ToInt32(selectedRow.Cells[0].Value);

            }
        }

        private void Listado_estudiante_Load(object sender, EventArgs e)
        {
            setData();

        }

        private void Dgb_estudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //
    }
}
