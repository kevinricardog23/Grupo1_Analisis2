using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo01.Dto
{
    class laboratorioDto
    {
        
        public int id_laboratorio { get; set; }

        public string descripcion_laboratorio { get; set; }

        public int CATEDRATICO_dpi_catedratico { get; set; }

        public int HORARIO_id_horario { get; set; }

        public int SALON_id_salon { get; set; }
    }
}
