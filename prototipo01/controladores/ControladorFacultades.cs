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
    class ControladorFacultades
    {
       public BindingList<facultadesDto> listaFacultades()
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from n in db.facultad
                                 select new facultadesDto
                                 {
                                     id_facultad = n.id_facultad,
                                     nombre_facultad = n.nombre_facultad,
                                     direccion_facultad = n.direccion_facultad,
                                     telefono_facultad = n.telefono_facultad,
                                     correo_facultad = n.correo_facultad
                                 }).ToList();

                    BindingList<facultadesDto> result = new BindingList<facultadesDto>(Query);

                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        //Funcion para buscar facultad

        public facultad buscarFacultad(int id_facultad)
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.facultad
                        .Where(s => s.id_facultad == id_facultad)
                        .FirstOrDefault<facultad>();

                    return std;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        //Metodo para actualizar informacion de facultad
        public void actualizarFacultad(int id_facultad, String nombre_facultad, String direccion_facultad, String telefono_facultad, String correo_facultad )
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.facultad
                        .Where(s => s.id_facultad == id_facultad)
                        .FirstOrDefault<facultad>();

                    std.nombre_facultad = nombre_facultad;
                    std.direccion_facultad = direccion_facultad;
                    std.telefono_facultad = telefono_facultad;
                    std.correo_facultad = correo_facultad;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        //Metodo para guardar una facultad
        public void guardarFacultad(String nombre_facultad, String direccion_facultad, String telefono_facultad, String correo_facultad)
        {
            ModelAsignacion db = new ModelAsignacion();

            facultad facultadNuevo = new facultad();

           // facultadNuevo.id_facultad = id_facultad;
            facultadNuevo.nombre_facultad = nombre_facultad;
            facultadNuevo.direccion_facultad = direccion_facultad;
            facultadNuevo.telefono_facultad = telefono_facultad;
            facultadNuevo.correo_facultad = correo_facultad;

            db.facultad.Add(facultadNuevo);
            db.SaveChanges();
        }


        //Buscar facultad por iniciales 
        public BindingList<facultadesDto> listaFacultadesLike(string search)
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from n in db.facultad
                                 where n.nombre_facultad.Contains(search)
                                 select new facultadesDto
                                 {
                                     
                                     nombre_facultad = n.nombre_facultad,
                                     direccion_facultad = n.direccion_facultad,
                                     telefono_facultad = n.telefono_facultad,
                                     correo_facultad = n.correo_facultad

                                 }).ToList();

                    BindingList<facultadesDto> result = new BindingList<facultadesDto>(Query);

                    return result;
                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        //Metodo para eliminar facultad

        public void eliminarFacultad(int id_facultad)
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.facultad
                        .Where(s => s.id_facultad == id_facultad)
                        .FirstOrDefault<facultad>();

                    db.facultad.Remove(std);
                    db.SaveChanges();

                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        //Valery
    }
}
