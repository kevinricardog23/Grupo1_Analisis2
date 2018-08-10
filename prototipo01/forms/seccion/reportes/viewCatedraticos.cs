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
using prototipo01.DTO;
using CrystalDecisions.CrystalReports.Engine;

namespace prototipo01.forms.seccion.reportes
{
    public partial class viewCatedraticos : Form
    {

        BindingList<catedraticoDto> DataSource_ = new BindingList<catedraticoDto>();
        ControladorReports cr = new ControladorReports();

        public viewCatedraticos()
        {
            InitializeComponent();
        }

        private void viewCatedraticos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DataSource_ = cr.getCatedraticos();
            forms.seccion.reportes.DsCatedraticos Ds= new forms.seccion.reportes.DsCatedraticos();

            var newArray = new catedraticoDto[DataSource_.Count];
            foreach (var whatever in DataSource_)
            {
                Ds.Tables[0].Rows.Add
                    (new object[]
                    {
                      whatever.dpi_catedratico.ToString(),
                      whatever.nombre_catedratico.ToString(),
                      whatever.apellido_catedratico.ToString(),
                      whatever.telefono_catedratico.ToString(),
                      whatever.correo_catedratico.ToString()
                    
                    }
                    );

            }

            ReportDocument oRep = new ReportDocument();
           

            string path = Application.StartupPath;

            string ruta = path.Substring(0, path.Length - 9) + "ReportM/rptCatedraticos.rpt";

            oRep.Load(ruta);
            oRep.SetDataSource(Ds);
            crystalReportViewer1.ReportSource = oRep;
        }
    }
}
