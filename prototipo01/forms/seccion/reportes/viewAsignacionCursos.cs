using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prototipo01.Dto;
using prototipo01.DTO;
using prototipo01.controladores;
using CrystalDecisions.CrystalReports.Engine;

namespace prototipo01.forms.seccion.reportes
{
    public partial class viewAsignacionCursos : Form
    {

        private int ID;

        BindingList<AsignacionCursosDto> DataSource_ = new BindingList<AsignacionCursosDto>();
        ControladorReports cr = new ControladorReports();

        public viewAsignacionCursos(int reference)
        {
            InitializeComponent();
            ID = reference;
        }

        private void viewAsignacionCursos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DataSource_ = cr.getAsignacionCursos(ID);
            forms.seccion.reportes.DsAsignacionCursos Ds = new forms.seccion.reportes.DsAsignacionCursos();

            var newArray = new AsignacionCursosDto[DataSource_.Count];
            foreach (var whatever in DataSource_)
            {
                Ds.Tables[0].Rows.Add
                    (new object[]
                    {
                       whatever.carnet.ToString(),
                       whatever.nombre_alumno.ToString(),
                       whatever.apellido_alumno.ToString(),
                       whatever.nombre_curso.ToString()
                    }
                    );

            }

            ReportDocument oRep = new ReportDocument();


            string path = Application.StartupPath;

            string ruta = path.Substring(0, path.Length - 9) + "ReportM/rptAsignacionCursos.rpt";

            oRep.Load(ruta);
            oRep.SetDataSource(Ds);
            crystalReportViewer1.ReportSource = oRep;

        }
    }
}
