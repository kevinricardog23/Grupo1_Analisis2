using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo01.Dto
{
    class estudianteDto
    {
        public int dpi_alumno { get; set; }


        public string nombre_alumno { get; set; }


        public string apellido_alumno { get; set; }


        public string telefono_alumno { get; set; }


        public string correo_alumno { get; set; }

        public int FACULTAD_id_facultad { get; set; }
       

        public int CARRERA_id_carrera { get; set; }

        public int edad_alumno { get; set; }

        public string direccion_alumno { get; set; }

        public string estado_alumno { get; set; }
        public string carnet { get; set; }
    }
}
