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

namespace prototipo01.forms.salones
{
    public partial class listaSalones : Form
    {
        ControladorSalones controladorSalones = new ControladorSalones();
        BindingList<salonDto> salonesDataSource = new BindingList<salonDto>(); //LISTA SALONES

        private int ID_reference;

        private void refreshDataSource()
        {
            this.Dgv_salones.DataSource = null;
            this.Dgv_salones.Rows.Clear();
            salonesDataSource = controladorSalones.listaSalones();
            Dgv_salones.DataSource = salonesDataSource;

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

        public listaSalones()
        {
            InitializeComponent();
        }

        //PROCEDIMIENTO PARA CARGAR DATASOURCE A DATACRIDVIEW
        void setData()
        {
            refreshDataSource();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            openForm(new Salones_Create());
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (ID_reference != 0)
            {

                openForm(new Salones_Update(ID_reference));

            }
            else
            {
                MessageBox.Show("Por favor seleccione un edificio");
            }
        }

        private void listaSalones_Load(object sender, EventArgs e)

        {
            Btn_crear.Enabled = privilegios.bandera;
            Btn_editar.Enabled = privilegios.bandera;
            Btn_eliminar.Enabled = privilegios.bandera;
            setData();
        }

        //BUSCAR POR INICIALES
        void search()
        {
            this.Dgv_salones.DataSource = null;
            this.Dgv_salones.Rows.Clear();
            salonesDataSource = controladorSalones.listaSalonesLike(Txt_buscar.Text.ToString());
            Dgv_salones.DataSource = salonesDataSource;
        }

        private void Dgv_salones_SelectionChanged(object sender, EventArgs e)
        {

            if (Dgv_salones.SelectedCells.Count > 0)
            {
                int selectedrowindex = Dgv_salones.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = Dgv_salones.Rows[selectedrowindex];

                ID_reference = Convert.ToInt32(selectedRow.Cells[0].Value);

            }

        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro de elimiar el Salon?", "Eliminar", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                controladorSalones.eliminarSalon(ID_reference);
                refreshDataSource();


            }

            ControladorBitacora controladorBitacora = new ControladorBitacora();
            controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Eliminar aula.");
        }

        private void Txt_buscar_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
