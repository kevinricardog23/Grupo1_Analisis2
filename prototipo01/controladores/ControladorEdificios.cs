using prototipo01.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo01.controladores
{
    class ControladorEdificios
    {

        ModelDADOS db = new ModelDADOS();

        public void guardarEdificio(String nombre_edificio, String ubicacion_edificio)
        {
            

            edificio edificioNuevo = new edificio();

            edificioNuevo.nombre_edificio = nombre_edificio;
            edificioNuevo.ubicacion_edificio = ubicacion_edificio;

            db.edificio.Add(edificioNuevo);
            db.SaveChanges();

        }

    }
}
