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
    class ControladorSalones
    {

        //Lista de salones capa Dto
        public BindingList<salonDto> listaSalones()
        {

            try
            {
                using (ModelDADOS db = new ModelDADOS())
                {
                    var Query = (from n in db.salon
                                 select new salonDto
                                 {
                                     id_salon = n.id_salon,
                                     capacidad_salon = n.capacidad_salon,
                                     EDIFICIO_id_edificio = n.EDIFICIO_id_edificio

                                 }).ToList();

                    BindingList<salonDto> result = new BindingList<salonDto>(Query);

                    return result;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }



        //get edificios

        public List<edificio> getEdificios()
        {


            using (ModelDADOS db = new ModelDADOS())
            {
                var std = (from edificio in db.edificio
                          select edificio).ToList();


                return std;
            }

        }


        //Metodo para guardar un nuevo salon
        public void guardarSalon(string capacidad_salon, int id_edificio)
        {

            using (ModelDADOS db = new ModelDADOS())
            {

                salon salonNuevo = new salon();
                salonNuevo.capacidad_salon = capacidad_salon;
                salonNuevo.EDIFICIO_id_edificio = id_edificio;


                db.salon.Add(salonNuevo);
                db.SaveChanges();

            }

        }


        //Metodo para actualizar un salon
        public void actualizarSalon(int id_salon, string capacidad_salon, int id_edificio)
        {

            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.salon
                        .Where(s => s.id_salon == id_salon)
                        .FirstOrDefault<salon>();

                    std.capacidad_salon = capacidad_salon;
                    std.EDIFICIO_id_edificio = id_edificio;
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }





        //obtener id del edificio
        public int getIdEdificio(string nombre_edificio)
        {
            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.edificio
                        .Where(s => s.nombre_edificio == nombre_edificio)
                        .FirstOrDefault<edificio>();

                    return std.id_edificio;
                }


            }
            catch (Exception)
            {
                throw;
            }

        }


        //Buscar salon
        public salon buscarSalon(int id_salon)
        {
            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.salon
                        .Where(s => s.id_salon == id_salon)
                        .FirstOrDefault<salon>();

                    return std;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }


        //Metodo para eliminar un salon
        public void eliminarSalon(int id_salon)
        {

            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.salon
                        .Where(s => s.id_salon == id_salon)
                        .FirstOrDefault<salon>();

                    db.salon.Remove(std);
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }

    }
}
