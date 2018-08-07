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
using prototipo01.Clases;
using prototipo01.models;
using prototipo01.Dto;

namespace prototipo01.forms.pensum
{
    public partial class Pensum_Update : Form
    {
        ControladorPensum contraladorPensum = new ControladorPensum();
        private int reference;
        public Pensum_Update(int ID_reference)
        {
            InitializeComponent();
            reference = ID_reference;
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

        void setData()
        {
            prototipo01.models.pensum Model = contraladorPensum.buscarPensum(reference);
            comboBox1.DataSource = contraladorPensum.getCarreras();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "id_carrera";
        }
            

        private void Pensum_Update_Load(object sender, EventArgs e)
        {
            prototipo01.models.pensum Model = contraladorPensum.buscarPensum(reference);

            textBox1.Text = Model.id_pensum.ToString();
            comboBox1.DataSource = contraladorPensum.getCarreras();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "id_carrera";
            textBox2.Text = Model.nombre.ToString();
            textBox1.Enabled = false;

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new Listado_pensum());
        }

        void update()
        {
            string nombre;
            int id, idCarrera;

            nombre = textBox2.Text.ToString();
            id = Convert.ToInt32(textBox1.Text.ToString());
            idCarrera = Convert.ToInt32(comboBox1.SelectedValue);

            contraladorPensum.actualizarPensum(reference, idCarrera, nombre);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                update();
               
                MessageBox.Show("Se agrego correctamente el pensum", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ControladorBitacora controladorBitacora = new ControladorBitacora();
                controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Editar Pensum.");
                textBox1.Text = "";
                textBox2.Text="";
                setData();
            }
        }
        //Williams De La Cuesta
    }
}
