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
    class ControladorReports
    {


        //GET ID CARRERA


        public int getIdCarrera(string nombre_carrera)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.carrera
                        .Where(s => s.nombre_carrera == nombre_carrera)
                        .FirstOrDefault<carrera>();

                    return std.id_carrera;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        //get Carreras

        public List<carrera> getCarreras()
        {


            using (ModelAsignacion db = new ModelAsignacion())
            {
                var std = (from carrera in db.carrera
                           select carrera).ToList();


                return std;
            }

        }



        //REPORT ALUMUNOS POR CARRERA

        public BindingList<AlumnosCarreraDto> getAlumnosCarrera(int id_carrera)
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from a in db.alumno
                                 where a.CARRERA_id_carrera == id_carrera

                                 select new AlumnosCarreraDto
                                 {
                                     nombre_alumno = a.nombre_alumno,
                                     apellido_alumno = a.apellido_alumno

                                 }).ToList();

                    BindingList<AlumnosCarreraDto> result = new BindingList<AlumnosCarreraDto>(Query);
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        //#####################################################################

        //REPORT ASIGNACION DE CURSOS POR ALUMNO

        //#####################################################################





        //get alumnos

        public List<alumno> getAlumnos()
        {


            using (ModelAsignacion db = new ModelAsignacion())
            {
                var std = (from alumno in db.alumno
                           select alumno).ToList();


                return std;
            }

        }


        //get dpi
        public int getdpi(string carne)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.alumno
                        .Where(s => s.carnet == carne)
                        .FirstOrDefault<alumno>();

                    return std.dpi_alumno;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }


        //CURSOS POR ESTUDIANTE

        public BindingList<AsignacionCursosDto> getAsignacionCursos(int dpi)
        {

            using (ModelAsignacion db = new ModelAsignacion())
            {
                var queryCursos = (from a in db.curso_estudiante
                                   from b in db.seccion_curso
                                   from c in db.curso
                                   from d in db.alumno
                                   where (a.ALUMNO_dpi_alumno == dpi) && b.curso_id == (a.CURSO_id_curso) && c.id_curso == (b.curso_id) && d.dpi_alumno == (dpi)

                                   select new AsignacionCursosDto
                                   {
                                        carnet = d.carnet,
                                        nombre_alumno = d.nombre_alumno,
                                        apellido_alumno = d.apellido_alumno,
                                        nombre_curso = c.nombre_curso
                                      
                                   }).ToList();

                return new BindingList<AsignacionCursosDto>(queryCursos);

            }


        }


        //#####################################################################

        //REPORT CATEDRATICOS

        //#####################################################################

        public BindingList<catedraticoDto> getCatedraticos()
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from a in db.catedratico
                                
                                 select new catedraticoDto
                                 {
                                     dpi_catedratico = a.dpi_catedratico,
                                     nombre_catedratico = a.nombre_catedratico,
                                     apellido_catedratico = a.apellido_catedratico,
                                     telefono_catedratico = a.telefono_catedratico,
                                     correo_catedratico = a.correo_catedratico
                             

                                 }).ToList();

                    BindingList<catedraticoDto> result = new BindingList<catedraticoDto>(Query);
                    return result;
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