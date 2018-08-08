using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prototipo01.models;
using prototipo01.Dto;
using System.ComponentModel;

namespace prototipo01.controladores
{
    class ControladorHorarios
    {

        //Metodo para guardar un nuevo horario
        public void guardarHorario(String hora)
        {
            ModelAsignacion db = new ModelAsignacion();


            horario horanueva = new horario();

            horanueva.horario_horario = hora;
            db.horario.Add(horanueva);
            db.SaveChanges();

        }


        //Metodo para eliminar un horario
        public void eliminarhorario(int id_horario)
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.horario
                        .Where(s => s.id_horario == id_horario)
                        .FirstOrDefault<horario>();
                    db.horario.Remove(std);
                    db.SaveChanges();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Lista de horarios
        public BindingList<horariosDto> listaHorarios()
        {

            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from n in db.horario
                                 select new horariosDto
                                 {
                                     id_horario = n.id_horario,
                                     horario_horario = n.horario_horario,
                                 }).ToList();

                    BindingList<horariosDto> result = new BindingList<horariosDto>(Query);

                    return result;
                }

            }
            catch (Exception)
            {
                throw;
            }


        }

        /*//Lista de edificios capa Dto
        public BindingList<edificioDto> listaEdificios()
        {

            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from n in db.edificio
                                 select new edificioDto
                                 {
                                     id_edificio = n.id_edificio,
                                     nombre_edificio = n.nombre_edificio,
                                     ubicacion_edificio = n.ubicacion_edificio

                                 }).ToList();

                    BindingList<edificioDto> result = new BindingList<edificioDto>(Query);

                    return result;
                }

            }
            catch (Exception)
            {
                throw;
            }


        }




        //Metodo para guardar un nuevo edificion
        public void guardarEdificio(String nombre_edificio, String ubicacion_edificio)
        {
            ModelAsignacion db = new ModelAsignacion();


            edificio edificioNuevo = new edificio();

            edificioNuevo.nombre_edificio = nombre_edificio;
            edificioNuevo.ubicacion_edificio = ubicacion_edificio;

            db.edificio.Add(edificioNuevo);
            db.SaveChanges();

        }



        //Funcion para buscar edificio

        public edificio buscarEdificio(int id_edificio)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.edificio
                        .Where(s => s.id_edificio == id_edificio)
                        .FirstOrDefault<edificio>();

                    return std;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }


        //buscar edificio por iniciales

        public BindingList<edificioDto> listaEdificiosLike(string search)
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from n in db.edificio
                                 where n.nombre_edificio.Contains(search)
                                 select new edificioDto
                                 {
                                     id_edificio = n.id_edificio,
                                     nombre_edificio = n.nombre_edificio,
                                     ubicacion_edificio = n.ubicacion_edificio

                                 }).ToList();

                    BindingList<edificioDto> result = new BindingList<edificioDto>(Query);

                    return result;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }




        //Metodo para actualizar un edificio
        public void actualizarEdificio(int id_edificio, String nombre_edificio, String ubicacion_edificio)
        {

            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.edificio
                        .Where(s => s.id_edificio == id_edificio)
                        .FirstOrDefault<edificio>();

                    std.nombre_edificio = nombre_edificio;
                    std.ubicacion_edificio = ubicacion_edificio;
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }


        //Metodo para eliminar un edificio
        public void eliminarEdificio(int id_edificio)
        {

            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.edificio
                        .Where(s => s.id_edificio == id_edificio)
                        .FirstOrDefault<edificio>();

                    db.edificio.Remove(std);
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }
            
        }*/

    }
}
