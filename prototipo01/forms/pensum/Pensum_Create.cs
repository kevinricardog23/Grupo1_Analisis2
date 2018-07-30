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
using prototipo01.models;
using prototipo01.Dto;

namespace prototipo01.forms.pensum
{
    public partial class Pensum_Create : Form
    {

        ControladorPensum controladorPensum = new ControladorPensum();

        public Pensum_Create()
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

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new Listado_pensum());
        }

        void create()
        {
            
            int idCarrera;
            string nombre;
            //idPensum = Convert.ToInt32(textBox1.Text.ToString());
            idCarrera = Convert.ToInt32(comboBox1.SelectedValue);
            nombre = textBox2.Text.ToString();
            controladorPensum.guardarPensum(idCarrera,nombre);
        }

        void setData()
        {
            
            comboBox1.DataSource = controladorPensum.getCarreras();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "id_carrera";
        }

        private void Pensum_Create_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = controladorPensum.getCarreras();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "id_carrera";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                create();
                MessageBox.Show("Se agrego correctamente el pensum", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //textBox1.Text = "";
                textBox2.Text = "";
                setData();
            }
        }

        //Williams De La Cuesta
    }
}
