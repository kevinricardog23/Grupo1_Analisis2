using System;
using prototipo01.DTO;
using prototipo01.Dto;
using prototipo01.models;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo01.controladores
{
    class ControladorCursos
    {

        //Lista de cursos capa Dto
        public BindingList<cursosDto> listaCursos()
        {

            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from n in db.curso
                                 select new cursosDto
                                 {
                                     id_curso = n.id_curso,
                                     nombre_curso = n.nombre_curso,
                                     PENSUM_id_pensum = n.PENSUM_id_pensum,                                    
                                     semestre_curso = n.semestre_curso,
                                     creditos=n.creditos
                                 }).ToList();

                    BindingList<cursosDto> result = new BindingList<cursosDto>(Query);

                    return result;
                }

            }
            catch (Exception)
            {
                throw;
            }


        }


        //Metodo para guardar un nuevo curso
        public void guardarCurso(int id_curso,String nombre_nombrecurso, int PENSUM_id_pensum, String semestre_curso, int creditos)
        {
            ModelAsignacion db = new ModelAsignacion();


            curso_model cursoNuevo = new curso_model();

            cursoNuevo.id_curso = id_curso;
            cursoNuevo.nombre_curso = nombre_nombrecurso;
            cursoNuevo.PENSUM_id_pensum = PENSUM_id_pensum;
            cursoNuevo.semestre_curso = semestre_curso;
            cursoNuevo.creditos = creditos;


            db.curso.Add(cursoNuevo);
            db.SaveChanges();

        }



        //devuelve pensum

        public List<pensum> getPensum()
        {


            using (ModelAsignacion db = new ModelAsignacion())
            {

                var std = (from pensum in db.pensum
                           select pensum).ToList();


                return std;
            }

        }

        //Modifica Cursos
        public void actualizarCursos(int id_curso, String nombre_nombrecurso, int PENSUM_id_pensum, String semestre_curso, int creditos)
        {

            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.curso
                        .Where(s => s.id_curso == id_curso)
                        .FirstOrDefault<curso_model>();

                    std.nombre_curso = nombre_nombrecurso;
                    std.PENSUM_id_pensum = PENSUM_id_pensum;
                    std.semestre_curso = semestre_curso;
                    std.creditos = creditos;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        //Buscar Cursos
        public curso_model buscarCursos(int id_cursos)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.curso
                        .Where(s => s.id_curso == id_cursos)
                        .FirstOrDefault<curso_model>();
                    return std;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }



        //Busqueda Por Barra
        public BindingList<cursosDto> listadoCursosPorCaracter(string search)
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from n in db.curso
                                 where n.nombre_curso.Contains(search)
                                 select new cursosDto
                                 {
                                     id_curso = n.id_curso,
                                     nombre_curso = n.nombre_curso,
                                     semestre_curso = n.semestre_curso,
                                     PENSUM_id_pensum = n.PENSUM_id_pensum,
                                     creditos = n.creditos
                                 }).ToList();
                    BindingList<cursosDto> result = new BindingList<cursosDto>(Query);
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        //Metodo para eliminar cursos
        public void eliminarCursos(int id_curso)
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.curso
                        .Where(s => s.id_curso == id_curso)
                        .FirstOrDefault<curso_model>();
                    db.curso.Remove(std);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }



        /* //Lista de edificios capa Dto
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
