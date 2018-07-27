using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using prototipo01.models;
using prototipo01.controladores;
using prototipo01.Dto;

namespace prototipo01.controladores
{
    class ControladorEstudiante
    {
        public BindingList<estudianteDto> Listado_estudiante()
        {
            try
            {
                using (ModelDADOS db = new ModelDADOS())
                {
                    var Query = (from n in db.alumno
                                 select new estudianteDto
                                 {

                                 }
            }
        }
    }
}
