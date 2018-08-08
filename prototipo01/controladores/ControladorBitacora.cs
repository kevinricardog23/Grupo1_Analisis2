using prototipo01.Dto;
using prototipo01.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo01.controladores
{
    class ControladorBitacora
    {
        ModelAsignacion db = new ModelAsignacion();

        public bitacora guardarBitacora(int usuarioId, string accion)
        {
            bitacora bitacoraObj = new bitacora();
            bitacoraObj.fecha_hora_bitacora = DateTime.Now;
            bitacoraObj.accionusario_bitacora = accion;
            bitacoraObj.usuario_id_usuario = usuarioId;

            db.bitacora.Add(bitacoraObj);
            db.SaveChanges();

            return bitacoraObj;
        }


        public BindingList<bitacoraDto> listaBitacora()
        {
            using (ModelAsignacion db = new ModelAsignacion())
            {
                var Query = (from n in db.bitacora
                             orderby n.id_bitacora descending
                             select new bitacoraDto
                             {
                                 id_bitacora = n.id_bitacora,
                                 fecha_bitacora = n.fecha_hora_bitacora,
                                 accionusario_bitacora = n.accionusario_bitacora,
                                 USUARIO_id_usuario = n.usuario_id_usuario                              
                             }).ToList();

                BindingList<bitacoraDto> result = new BindingList<bitacoraDto>(Query);

                return result;

            }
        }


    }
}
