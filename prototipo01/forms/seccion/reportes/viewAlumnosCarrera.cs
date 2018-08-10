using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prototipo01.DTO;
using prototipo01.Dto;
using prototipo01.controladores;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace prototipo01.forms.seccion.reportes
{
    public partial class viewAlumnosCarrera : Form
    {

        BindingList<AlumnosCarreraDto> DataSource_ = new BindingList<AlumnosCarreraDto>();
        ControladorReports cr = new ControladorReports();
        private int ID;

        public viewAlumnosCarrera(int referece)
        {
            InitializeComponent();
            ID = referece;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {


        }

        private void viewAlumnosCarrera_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;

            DataSource_ = cr.getAlumnosCarrera(ID);
            forms.seccion.reportes.DsAlumnosCarrera Ds = new forms.seccion.reportes.DsAlumnosCarrera();

            var newArray = new AlumnosCarreraDto[DataSource_.Count];
            foreach (var whatever in DataSource_)
            {
                Ds.Tables[0].Rows.Add
                    (new object[]
                    {
                       whatever.nombre_alumno.ToString(),
                       whatever.apellido_alumno.ToString()
                    }
                    );

            }

            ReportDocument oRep = new ReportDocument();
           

           

            string path = Application.StartupPath;

            string ruta = path.Substring(0, path.Length-9) + "ReportM/rptAlumnosCarrera.rpt";

            oRep.Load(ruta);
            
            oRep.SetDataSource(Ds);
            crystalReportViewer1.ReportSource = oRep;
        }
    }
}
