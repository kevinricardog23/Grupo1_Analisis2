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
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from n in db.seccion_curso
                                 select new seccionDto
                                 {
                                     id_seccion = n.id_seccion,
                                     seccion_seccion = n.seccion_seccion,
                                     catedratico_id = n.catedratico_id,
                                     curso_id = n.curso_id,
                                     laboratorio_id = n.laboratorio_id,
                                     salon_id = n.salon_id,
                                     horario_id = n.horario_id,
                                     ciclo = n.ciclo,
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
        public void guardarSeccion(string seccion, string estado, int id_catedratico, int id_curso, int id_laboratorio, int id_salon, int id_horario, string ciclo)
        {

            using (ModelAsignacion db = new ModelAsignacion())
            {

                seccion_curso seccionNueva = new seccion_curso();

                seccionNueva.seccion_seccion = seccion;
                seccionNueva.estado_seccion = estado;
                seccionNueva.catedratico_id = id_catedratico;
                seccionNueva.curso_id = id_curso;
                seccionNueva.laboratorio_id = id_laboratorio;
                seccionNueva.salon_id = id_salon;
                seccionNueva.horario_id = id_horario;
                seccionNueva.estado_seccion = estado;
                seccionNueva.ciclo = ciclo;

                db.seccion_curso.Add(seccionNueva);
                db.SaveChanges();

            }

        }


        //Metodo para actualizar un seccion
        public void actualizarSeccion(int id_seccion , string seccion, string estado, int id_catedratico, int id_curso, int id_laboratorio, int id_salon, int id_horario, string ciclo)
        {

            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.seccion_curso
                        .Where(s => s.id_seccion == id_seccion)
                        .FirstOrDefault<seccion_curso>();

                    std.seccion_seccion = seccion;
                    std.estado_seccion = estado;
                    std.catedratico_id = id_catedratico;
                    std.curso_id = id_curso;
                    std.laboratorio_id = id_laboratorio;
                    std.salon_id = id_salon;
                    std.horario_id = id_horario;
                    std.estado_seccion = estado;
                    std.ciclo = ciclo;
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }




        //get catedraticos

        public List<catedratico> getCatedraticos()
        {


            using (ModelAsignacion db = new ModelAsignacion())
            {
                var std = (from catedratico in db.catedratico
                           select catedratico).ToList();


                return std;
            }

        }


        //obtener id catedratico
        public int getIdCatedratico(string nombre_catedratico)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.catedratico
                        .Where(s => s.nombre_catedratico == nombre_catedratico)
                        .FirstOrDefault<catedratico>();

                    return std.dpi_catedratico;
                }


            }
            catch (Exception)
            {
                throw;
            }

        }



        //get cursos

        public List<curso_model> getCursos()
        {


            using (ModelAsignacion db = new ModelAsignacion())
            {
                var std = (from curso_model in db.curso
                           select curso_model).ToList();


                return std;
            }

        }


        //obtener id curso
        public int getIdCurso(string nombre_curso)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.curso
                        .Where(s => s.nombre_curso == nombre_curso)
                        .FirstOrDefault<curso_model>();

                    return std.id_curso;
                }


            }
            catch (Exception)
            {
                throw;
            }

        }


        //get laboratorios

        public List<laboratorio> getLaboratorios()
        {


            using (ModelAsignacion db = new ModelAsignacion())
            {
                var std = (from laboratorio in db.laboratorio
                           select laboratorio).ToList();


                return std;
            }

        }


        //obtener id laboratorio
        public int getIdLaboratorio(string nombre_laboratorio)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.laboratorio
                        .Where(s => s.descripcion_laboratorio == nombre_laboratorio)
                        .FirstOrDefault<laboratorio>();

                    return std.id_laboratorio;
                }


            }
            catch (Exception)
            {
                throw;
            }

        }



        //get salon

        public List<salon> getSalones()
        {


            using (ModelAsignacion db = new ModelAsignacion())
            {
                var std = (from salon in db.salon
                           select salon).ToList();


                return std;
            }

        }


        //obtener id salon
        public int getIdSaon(string nombre_salon)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.salon
                        .Where(s => s.nombre_salon== nombre_salon)
                        .FirstOrDefault<salon>();

                    return std.id_salon;
                }


            }
            catch (Exception)
            {
                throw;
            }

        }


        //get horario

        public List<horario> getHorarios()
        {


            using (ModelAsignacion db = new ModelAsignacion())
            {
                var std = (from horario in db.horario
                           select horario).ToList();


                return std;
            }

        }

        //obtener id horario
        public int getIdHorario(string hora)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.horario
                        .Where(s => s.horario_horario == hora)
                        .FirstOrDefault<horario>();

                    return std.id_horario;
                }


            }
            catch (Exception)
            {
                throw;
            }

        }



        //Buscar seccion
        public seccion_curso buscarSeccion(int id_seccion)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.seccion_curso
                        .Where(s => s.id_seccion== id_seccion)
                        .FirstOrDefault<seccion_curso>();

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
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from n in db.seccion_curso
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

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.seccion_curso
                        .Where(s => s.id_seccion == id_seccion)
                        .FirstOrDefault<seccion_curso>();

                    db.seccion_curso.Remove(std);
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

//JOSE ARRECIS