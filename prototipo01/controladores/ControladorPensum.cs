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
        ModelDADOS db = new ModelDADOS();
        public BindingList<PensumDto> listaPensum()
        {    
            using (ModelDADOS db = new ModelDADOS())
            {
                var Query = (from n in db.pensum
                             select new PensumDto
                             {
                                 iId = n.id_pensum,
                                 iId_carrera = n.CARRERA_id_carrera,
                                 sNombre_pensum = n.nombre
                             }).ToList();

                BindingList<PensumDto> result = new BindingList<PensumDto>(Query);

                return result;

            }
        }


        public void guardarPensum(int iIdCarrera, String sNombre)
        {
            pensum pensumNuevo = new pensum();
            //usuarioNuevo.id_pensum = usuario_alias;
            pensumNuevo.CARRERA_id_carrera = iIdCarrera;
            pensumNuevo.nombre = sNombre;
            db.pensum.Add(pensumNuevo);
            db.SaveChanges();
        }

        public pensum buscarPensum(int iIdPensum)
        {
            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.pensum
                        .Where(s => s.id_pensum == iIdPensum)
                        .FirstOrDefault<pensum>();

                    return std;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }

        public void actualizarPensum(int iIdPensum, int iCarrera, String sNombre)
        {
            try
            {
                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.pensum
                        .Where(s => s.id_pensum == iIdPensum)
                        .FirstOrDefault<pensum>();

                    std.nombre = sNombre;
                    std.CARRERA_id_carrera = iCarrera;
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