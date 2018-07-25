using prototipo01.models;
using prototipo01.DTO;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo01.controladores
{
    class ControladorEdificios
    {

      


        //Lista de edificios capa Dto
        public BindingList<edificioDto> listaEdificios()
        {

            try
            {
                using (ModelDADOS db = new ModelDADOS())
                {
                    var Query = (from n in db.edificio
                                 select new edificioDto
                                 {
                                     iId_edificio = n.id_edificio,
                                     sNombre_edificio = n.nombre_edificio,
                                     sUbicacion_edificio = n.ubicacion_edificio

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
        public void guardarEdificio(String sNombre_edificio, String sUbicacion_edificio)
        {
            ModelDADOS db = new ModelDADOS();


            edificio edificioNuevo = new edificio();

            edificioNuevo.nombre_edificio = sNombre_edificio;
            edificioNuevo.ubicacion_edificio = sUbicacion_edificio;

            db.edificio.Add(edificioNuevo);
            db.SaveChanges();

        }



        //Funcion para buscar edificio

        public edificio buscarEdificio(int iId_edificio)
        {
            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.edificio
                        .Where(s => s.id_edificio == iId_edificio)
                        .FirstOrDefault<edificio>();

                    return std;
                }
                
                
            }
            catch (Exception)
            {
                throw;
            }
        }



        //Metodo para actualizar un edificio
        public void actualizarEdificio(int iId_edificio, String sNombre_edificio, String sUbicacion_edificio)
        {

            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std =db.edificio
                        .Where(s => s.id_edificio == iId_edificio)
                        .FirstOrDefault<edificio>();

                    std.nombre_edificio = sNombre_edificio;
                    std.ubicacion_edificio = sUbicacion_edificio;
                    db.SaveChanges();
                
                }

            }
            catch (Exception)
            {
                throw;
            }

        }


        //Metodo para eliminar un edificio
        public void eliminarEdificio(int iId_edificio)
        {

            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.edificio
                        .Where(s => s.id_edificio == iId_edificio)
                        .FirstOrDefault<edificio>();

                    db.edificio.Remove(std);
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }



        //ARRECIS


    }
} //Se aplicaron las normas de estandarizacion -Valery
