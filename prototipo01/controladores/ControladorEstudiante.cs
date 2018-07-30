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
                                     estado_alumno = n.estado_alumno
                                     
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

        public void guardarEstudiante(int dpi_alumno, String nombre_alumno, String apellido_alumno, String telefono_alumno, String correo_alumno, int edad_alumno, String direccion_alumno, String estado_alumno, int FACULTAD_id_facultad, int CARRERA_id_carrera)
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
        public alumno buscarEstudiante(int dpi_alumno)
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
        public void actualizarEstudiante(int dpi_alumno, String nombre_alumno, String apellido_alumno, String telefono_alumno, String correo_alumno, int edad_alumno, String direccion_alumno, String estado_alumno)
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
                    std.estado_alumno = estado_alumno;
                    db.SaveChanges();

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



        
        public List<alumno> getID_carrera()
        {
            using (ModelAsignacion db = new ModelAsignacion())
            {
                var std = (from alumno in db.alumno
                           select alumno ).ToList();
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
                                     direccion_alumno = n.direccion_alumno
                                     

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