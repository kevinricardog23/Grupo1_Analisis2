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
    class ControladorCatedraticos
    {
        //Lista de edificios capa Dto
        public BindingList<catedraticoDto> listaCatedraticos()
        {

            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from n in db.catedratico
                                 select new catedraticoDto
                                 {

                                     dpi_catedratico = n.dpi_catedratico,
                                     nombre_catedratico = n.nombre_catedratico,
                                     apellido_catedratico = n.apellido_catedratico,
                                     telefono_catedratico = n.telefono_catedratico,
                                     correo_catedratico = n.correo_catedratico,
                                     edad_catedratico = n.edad_catedratico,
                                     direccion_catedratico = n.direccion_catedratico
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



        //FUNCION PARA BUSCAR UN CATEDRATICO


        public catedratico buscarCatedratico(int dpi_catedratico)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.catedratico
                        .Where(s => s.dpi_catedratico == dpi_catedratico)
                        .FirstOrDefault<catedratico>();

                    return std;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }


        //Metodo para actulizar informacion de catedratico

        public void actualizarCatedratico(int dpi_catedratico, String nombre_catedratico, String apellido_catedratico, String telefono_catedratico, String correo_catedratico, int edad_catedratico, String direccion_catedratico)
        {

            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.catedratico
                        .Where(s => s.dpi_catedratico == dpi_catedratico)
                        .FirstOrDefault<catedratico>();

                    std.nombre_catedratico = nombre_catedratico;
                    std.apellido_catedratico= apellido_catedratico;
                    std.telefono_catedratico = telefono_catedratico;
                    std.correo_catedratico = correo_catedratico;
                    std.edad_catedratico = edad_catedratico;
                    std.direccion_catedratico = direccion_catedratico;
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }




        //Metodo para guardar un nuevo catedratico
        public void guardarCatedratico(int dpi_catedratico, String nombre_catedratico, String apellido_catedratico, String telefono_catedratico, String correo_catedratico, int edad_catedratico, String direccion_catedratico)
        {
            ModelAsignacion db = new ModelAsignacion();


            catedratico catedraticoNuevo = new catedratico();

            catedraticoNuevo.dpi_catedratico = dpi_catedratico;
            catedraticoNuevo.nombre_catedratico = nombre_catedratico;
            catedraticoNuevo.apellido_catedratico= apellido_catedratico;
            catedraticoNuevo.telefono_catedratico = telefono_catedratico;
            catedraticoNuevo.correo_catedratico = correo_catedratico;
            catedraticoNuevo.edad_catedratico = edad_catedratico;
            catedraticoNuevo.direccion_catedratico = direccion_catedratico;

            db.catedratico.Add(catedraticoNuevo);
            db.SaveChanges();

        }



        //buscar catedratico por iniciales

        public BindingList<catedraticoDto> listaCatedraticosLike(string search)
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var Query = (from n in db.catedratico
                                 where n.nombre_catedratico.Contains(search)
                                 select new catedraticoDto
                                 {
                                     dpi_catedratico = n.dpi_catedratico,
                                     nombre_catedratico = n.nombre_catedratico,
                                     apellido_catedratico = n.apellido_catedratico,
                                     telefono_catedratico = n.telefono_catedratico,
                                     correo_catedratico = n.correo_catedratico,
                                     edad_catedratico = n.edad_catedratico,
                                     direccion_catedratico = n.direccion_catedratico

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

        public void eliminarCatedratico(int idCatedratico)
        {

            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.catedratico
                        .Where(s => s.dpi_catedratico == idCatedratico)
                        .FirstOrDefault<catedratico>();

                    db.catedratico.Remove(std);
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }



        //ARRECIS - HUGO



    }
}
