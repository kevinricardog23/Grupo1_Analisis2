using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.forms.facultad
{
    public partial class Listado_facultades : Form
    {
        public Listado_facultades()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_buscar.Text))
            {
                MessageBox.Show("Debe ingrear informacion a buscar", "Error de busqueda de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
