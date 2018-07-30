using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo01.Dto
{
    class cursosDto
    {
        public int id_curso { get; set; }
        public string nombre_curso { get; set; }
        public int PENSUM_id_pensum { get; set; }
        public string semestre_curso { get; set; }
        public int? creditos { get; set; }
    }
}
