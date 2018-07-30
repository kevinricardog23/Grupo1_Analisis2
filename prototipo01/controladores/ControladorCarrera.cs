using System;
using prototipo01.DTO;
using prototipo01.Dto;
using prototipo01.models;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo01.controladores
{
    class ControladorCarrera
  
    {

        //Lista de carreras
        public BindingList<carreraDto> listaCarreras()
        {

            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from n in db.carrera
                                 select new carreraDto
                                 {
                                     id_carrera = n.id_carrera,
                                     nombre_carrera = n.nombre_carrera,
                                     FACULTAD_id_facultad = n.FACULTAD_id_facultad,
                                     jornada_carrera = n.jornada_carrera

                                 }).ToList();

                    BindingList<carreraDto> result = new BindingList<carreraDto>(Query);

                    return result;
                }

            }
            catch (Exception)
            {
                throw;
            }


        }


        //Metodo para guardar una nueva carrera
        public void guardarCarrera(int id_carrera, String nombre_carrera, int FACULTAD_id_facultad, String jornada_carrera)
        {
            ModelAsignacion db = new ModelAsignacion();

            carrera carreraNueva = new carrera();

            carreraNueva.id_carrera = id_carrera;
            carreraNueva.nombre_carrera = nombre_carrera;
            carreraNueva.FACULTAD_id_facultad = FACULTAD_id_facultad;
            carreraNueva.jornada_carrera = jornada_carrera;


            db.carrera.Add(carreraNueva);
            db.SaveChanges();

        }


        //metodo para eliminar carrera

        public void eliminarCarrea(int id_carrera)
        {

            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.carrera
                        .Where(s => s.id_carrera == id_carrera)
                        .FirstOrDefault<carrera>();

                    db.carrera.Remove(std);
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }


        //obtener facultad

        public List<facultad> getfacultades()
        {


            using (ModelAsignacion db = new ModelAsignacion())
            {
                var std = (from facultad in db.facultad
                           select facultad).ToList();


                return std;
            }

        }

        //Metodo para actualizar una carrera

        public void actualizarCarrera(int id_carrera, string nombre_carrera, int id_facultad, string jornada_carrera)
        {

            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.carrera
                        .Where(s => s.id_carrera == id_carrera)
                        .FirstOrDefault<carrera>();

                    std.nombre_carrera = nombre_carrera;
                    std. FACULTAD_id_facultad = id_facultad;
                    std.jornada_carrera = jornada_carrera;
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        //Obtener id de facultad

        public int getIdFacultad(string nombre_facultad)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.facultad
                        .Where(s => s.nombre_facultad == nombre_facultad)
                        .FirstOrDefault<facultad>();

                    return std.id_facultad;
                }


            }
            catch (Exception)
            {
                throw;
            }

        }

        //Buscar una carrera
        public carrera buscarCarrera(int id_carrera)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.carrera
                        .Where(s => s.id_carrera == id_carrera)
                        .FirstOrDefault<carrera>();

                    return std;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
