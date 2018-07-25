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
                                     iId_seccion = n.id_seccion,
                                     sSeccion_seccion = n.seccion_seccion,
                                     sEstado_seccion = n.estado_seccion

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
        public void guardarSeccion(string sSeccion, string sEstado)
        {

            using (ModelDADOS db = new ModelDADOS())
            {

                seccion seccionNueva = new seccion();

                seccionNueva.seccion_seccion = sSeccion;
                seccionNueva.estado_seccion = sEstado;

                db.seccion.Add(seccionNueva);
                db.SaveChanges();

            }

        }


        //Metodo para actualizar un seccion
        public void actualizarSeccion(int iId_seccion, string sNombre_seccion, string sEstado)
        {

            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.seccion
                        .Where(s => s.id_seccion == iId_seccion)
                        .FirstOrDefault<seccion>();

                    std.seccion_seccion = sNombre_seccion;
                    std.estado_seccion = sEstado;
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }





        //Buscar seccion
        public seccion buscarSeccion(int iId_seccion)
        {
            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.seccion
                        .Where(s => s.id_seccion== iId_seccion)
                        .FirstOrDefault<seccion>();

                    return std;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }


        //Metodo para eliminar seccion
        public void eliminarSeccion(int iId_seccion)
        {

            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.seccion
                        .Where(s => s.id_seccion == iId_seccion)
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
//Se aplicaron las normas de estandarizacion -Valery