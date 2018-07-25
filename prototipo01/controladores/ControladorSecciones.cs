using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using prototipo01.models;
using prototipo01.Dto;
using prototipo01.controladores;

namespace prototipo01.controladores
{
    class ControladorSecciones
    {
        //Lista de secciones capa Dto
        public BindingList<seccionDto> listaSecciones()
        {

            try
            {
                using (ModelDADOS db = new ModelDADOS())
                {
                    var Query = (from n in db.seccion
                                 select new seccionDto
                                 {
                                     id_seccion = n.id_seccion,
                                     seccion_seccion = n.seccion_seccion,
                                     estado_seccion = n.estado_seccion

                                 }).ToList();

                    BindingList<seccionDto> result = new BindingList<seccionDto>(Query);

                    return result;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }



        //Metodo para guardar una nueva seccion
        public void guardarSeccion(string seccion, string estado)
        {

            using (ModelDADOS db = new ModelDADOS())
            {

                seccion seccionNueva = new seccion();

                seccionNueva.seccion_seccion = seccion;
                seccionNueva.estado_seccion = estado;

                db.seccion.Add(seccionNueva);
                db.SaveChanges();

            }

        }


        //Metodo para actualizar un seccion
        public void actualizarSeccion(int id_seccion, string nombre_seccion, string estado)
        {

            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.seccion
                        .Where(s => s.id_seccion == id_seccion)
                        .FirstOrDefault<seccion>();

                    std.seccion_seccion = nombre_seccion;
                    std.estado_seccion = estado;
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }





        //Buscar seccion
        public seccion buscarSeccion(int id_seccion)
        {
            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.seccion
                        .Where(s => s.id_seccion== id_seccion)
                        .FirstOrDefault<seccion>();

                    return std;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }



        //buscar seccion por iniciales

        public BindingList<seccionDto> listaSeccionesLike(string search)
        {
            try
            {
                using (ModelDADOS db = new ModelDADOS())
                {
                    var Query = (from n in db.seccion
                                 where n.seccion_seccion.Contains(search)
                                 select new seccionDto
                                 {
                                     id_seccion = n.id_seccion,
                                     seccion_seccion = n.seccion_seccion,
                                     estado_seccion = n.estado_seccion

                                 }).ToList();

                    BindingList<seccionDto> result = new BindingList<seccionDto>(Query);

                    return result;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }


        //Metodo para eliminar seccion
        public void eliminarSeccion(int id_seccion)
        {

            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.seccion
                        .Where(s => s.id_seccion == id_seccion)
                        .FirstOrDefault<seccion>();

                    db.seccion.Remove(std);
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
