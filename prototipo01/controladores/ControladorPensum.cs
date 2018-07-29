using prototipo01.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using prototipo01.Dto;

namespace prototipo01.controladores
{
    public class ControladorPensum
    {
        ModelAsignacion db = new ModelAsignacion();
        public BindingList<PensumDto> listaPensum()
        {    
            using (ModelAsignacion db = new ModelAsignacion())
            {
                var Query = (from n in db.pensum
                             select new PensumDto
                             {
                                 id = n.id_pensum,
                                 id_carrera = n.CARRERA_id_carrera
                                 //nombre_pensum = n
                             }).ToList();

                BindingList<PensumDto> result = new BindingList<PensumDto>(Query);

                return result;

            }
        }


        public void guardarPensum(int idCarrera, String nombre)
        {
            pensum pensumNuevo = new pensum();
            //usuarioNuevo.id_pensum = usuario_alias;
            pensumNuevo.CARRERA_id_carrera = idCarrera;
            pensumNuevo.nombre = nombre;
            db.pensum.Add(pensumNuevo);
            db.SaveChanges();
        }

        public pensum buscarPensum(int idPensum)
        {
            try
            {

                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.pensum
                        .Where(s => s.id_pensum == idPensum)
                        .FirstOrDefault<pensum>();

                    return std;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }

        public void actualizarPensum(int idPensum, int carrera, String nombre)
        {
            try
            {
                using (ModelAsignacion db = new ModelAsignacion())
                {
                    var std = db.pensum
                        .Where(s => s.id_pensum == idPensum)
                        .FirstOrDefault<pensum>();

                    std.nombre = nombre;
                    std.CARRERA_id_carrera = carrera;
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }


        //GET CARRERAS

        public List<carrera> getCarreras()
        {
            using (ModelAsignacion db = new ModelAsignacion())
            {

                var std = (from carrera in db.carrera
                           select carrera).ToList();

                return std;

            }
        }

    }
}

