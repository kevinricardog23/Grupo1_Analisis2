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
    class ControladorEstudiante
    {
        public BindingList<estudianteDto> Listado_estudiante()
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from n in db.alumno
                                 select new estudianteDto
                                 {
                                     dpi_alumno = n.dpi_alumno,
                                     nombre_alumno = n.nombre_alumno,
                                     apellido_alumno = n.apellido_alumno,
                                     telefono_alumno = n.telefono_alumno,
                                     correo_alumno = n.correo_alumno,
                                     edad_alumno = n.edad_alumno,
                                     direccion_alumno = n.direccion_alumno,
                                     CARRERA_id_carrera = n.CARRERA_id_carrera,
                                     FACULTAD_id_facultad = n.FACULTAD_id_facultad,
                                      estado_alumno = n.estado_alumno,
                                      carnet_alumno = n.carnet
                                   

                                 }).ToList();

                    BindingList<estudianteDto> result = new BindingList<estudianteDto>(Query);
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        //ALUMNOS POR CATEDRATICO

        public BindingList<AlumnosCurso> AlumnosPorCurso()
        {

            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {

                    var Query = (from c in db.curso_estudiante
                                join o in db.curso
                    on c.CURSO_id_curso equals o.id_curso
                                select new AlumnosCurso
                                {
                                    nombre_curso = o.nombre_curso
                                }).ToList();



                    BindingList<AlumnosCurso> result = new BindingList<AlumnosCurso>(Query);


                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }





        public void actualizarEstudiante(int dpi_alumno, String nombre_alumno, String apellido_alumno, String telefono_alumno, String correo_alumno, int edad_alumno, String direccion_alumno, int FCULTAD_id_facultad, int CARRERA_id_carrera, String estado_alumno)
        {

            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.alumno
                        .Where(s => s.dpi_alumno == dpi_alumno)
                        .FirstOrDefault<alumno>();

                    std.nombre_alumno = nombre_alumno;
                    std.apellido_alumno = apellido_alumno;
                    std.telefono_alumno = telefono_alumno;
                    std.correo_alumno = correo_alumno;
                    std.edad_alumno = edad_alumno;
                    std.direccion_alumno = direccion_alumno;
                    
                    std.CARRERA_id_carrera = CARRERA_id_carrera;
                    std.FACULTAD_id_facultad = FCULTAD_id_facultad;
                    std.estado_alumno = estado_alumno;
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }
        public alumno buscarEstudiante(long dpi_alumno)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.alumno
                        .Where(s => s.dpi_alumno == dpi_alumno)
                        .FirstOrDefault<alumno>();

                    return std;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }
        public void guardarEstudiante(int dpi_alumno, String nombre_alumno, String apellido_alumno, String telefono_alumno, String correo_alumno, int edad_alumno, String direccion_alumno, String estado_alumno, int CARRERA_id_carrera, int FACULTAD_id_facultad)
        {
            ModelAsignacion db = new ModelAsignacion();


            alumno alumnoNuevo = new alumno();

            alumnoNuevo.dpi_alumno = dpi_alumno;
            alumnoNuevo.nombre_alumno = nombre_alumno;
            alumnoNuevo.apellido_alumno = apellido_alumno;
            alumnoNuevo.telefono_alumno = telefono_alumno;
            alumnoNuevo.correo_alumno = correo_alumno;
            alumnoNuevo.edad_alumno = edad_alumno;
            alumnoNuevo.direccion_alumno = direccion_alumno;
            alumnoNuevo.estado_alumno = estado_alumno;
            alumnoNuevo.CARRERA_id_carrera = CARRERA_id_carrera;
            alumnoNuevo.FACULTAD_id_facultad = FACULTAD_id_facultad;

            db.alumno.Add(alumnoNuevo);
            db.SaveChanges();

        }



      public alumno buscarEstudianteCarnet(String carnet)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.alumno
                        .Where(s => s.carnet == carnet)
                        .FirstOrDefault<alumno>();

                    return std;
                }


            }
            catch (Exception)
            {
               throw;
            }
        }
        
       





        //obtener id carrera
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





        //obtener id facultad
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
















        public void eliminarEstudiante(int id_alumno)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.alumno
                        .Where(s => s.dpi_alumno == id_alumno)
                        .FirstOrDefault<alumno>();

                    db.alumno.Remove(std);
                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //OBTIENE TODAS LA CARRERAS
        public List<carrera> getCarreras()
        {
            using (ModelAsignacion db = new ModelAsignacion())
            {
                var std = (from carrera in db.carrera
                           select carrera).ToList();
                return std;
            }
        }


        //OBTIENE TODAS LA FACULTADES
        public List<facultad> getFacultades()
        {
            using (ModelAsignacion db = new ModelAsignacion())
            {
                var std = (from facultad in db.facultad
                           select facultad).ToList();
                return std;
            }
        }





        public BindingList<estudianteDto> listaEstudiantesLike(string search)
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from n in db.alumno
                                 where n.nombre_alumno.Contains(search)
                                 select new estudianteDto
                                 {
                                     dpi_alumno = n.dpi_alumno,
                                     nombre_alumno = n.nombre_alumno,
                                     apellido_alumno = n.apellido_alumno,
                                     telefono_alumno = n.telefono_alumno,
                                     correo_alumno = n.correo_alumno,
                                     edad_alumno = n.edad_alumno,
                                     direccion_alumno = n.direccion_alumno,
                                     estado_alumno = n.estado_alumno,
                                     CARRERA_id_carrera = n.CARRERA_id_carrera,
                                     FACULTAD_id_facultad = n.FACULTAD_id_facultad


                                 }).ToList();

                    BindingList<estudianteDto> result = new BindingList<estudianteDto>(Query);

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
//kevin G