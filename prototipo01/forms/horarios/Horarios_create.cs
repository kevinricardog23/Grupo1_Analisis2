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

namespace prototipo01.forms.horarios
{
    public partial class Horarios_create : Form
    {
        ControladorHorarios controladorHorarios = new ControladorHorarios();
        public Horarios_create()
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

        public string hora;
        public string obtener_hora_total()
        {
            hora = txtBox_hhinicio.Text + ":" + txtBox_mmFinal.Text + " " + cmbBox_Merid.Text + " - " + txtBox_hhFinal.Text + ":" + txtBox_mmFinal.Text + " " + cmbBox_Merid2.Text;
            return hora;
        }

        private void Btn_crear_Click(object sender, EventArgs e)
        {
            hora = txtBox_hhinicio.Text + ":" + txtBox_mmInicio.Text + " " + cmbBox_Merid.Text + " - " + txtBox_hhFinal.Text + ":" + txtBox_mmFinal.Text + " " + cmbBox_Merid2.Text;
            if (string.IsNullOrEmpty(txtBox_hhinicio.Text)|| string.IsNullOrEmpty(txtBox_mmInicio.Text) || string.IsNullOrEmpty(cmbBox_Merid.Text) || string.IsNullOrEmpty(txtBox_hhFinal.Text) || string.IsNullOrEmpty(txtBox_mmFinal.Text) || string.IsNullOrEmpty(cmbBox_Merid2.Text))
            {
                MessageBox.Show("Debe completar la informacion", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                controladorHorarios.guardarHorario(hora);
                MessageBox.Show("Informacion agregada correctamente", "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //CONTROL BICORA
                ControladorBitacora controladorBitacora = new ControladorBitacora();
                controladorBitacora.guardarBitacora(usuarioLogi.id_usuario, "Crear Horario.");
                txtBox_hhinicio.Text = "";
                txtBox_mmInicio.Text = "";
                txtBox_hhFinal.Text = "";
                txtBox_mmFinal.Text = "";
                cmbBox_Merid.Text = "";
                cmbBox_Merid2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ingreso de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            openForm(new Lista_Horarios());
        }
    }
}
