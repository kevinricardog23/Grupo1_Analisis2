using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo01.Dto
{
    class seccionDto
    {


        public int id_seccion { get; set; }

        public string seccion_seccion { get; set; }

        public string estado_seccion { get; set; }

        public int? catedratico_id { get; set; }

        public int? curso_id { get; set; }

        public int? laboratorio_id { get; set; }

        public int? salon_id { get; set; }

        public int? horario_id { get; set; }

        public string ciclo { get; set; }

    }
}
