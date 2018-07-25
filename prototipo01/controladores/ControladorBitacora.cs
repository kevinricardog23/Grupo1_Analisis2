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
        ModelDADOS db = new ModelDADOS();

        public bitacora guardarBitacora(int usuarioId)
        {
            bitacora bitacoraObj = new bitacora();
            bitacoraObj.fecha_bitacora = DateTime.Now;
            bitacoraObj.accionusario_bitacora = "Inicio de sesión en el sistema.";
            bitacoraObj.USUARIO_id_usuario = usuarioId;

            db.bitacora.Add(bitacoraObj);
            db.SaveChanges();

            return bitacoraObj;
        }


        public BindingList<bitacoraDto> listaBitacora()
        {
            using (ModelDADOS db = new ModelDADOS())
            {
                var Query = (from n in db.bitacora
                             select new bitacoraDto
                             {
                                 id_bitacora = n.id_bitacora,
                                 fecha_bitacora = n.fecha_bitacora,
                                 accionusario_bitacora = n.accionusario_bitacora,
                                 USUARIO_id_usuario = n.USUARIO_id_usuario                              
                             }).ToList();

                BindingList<bitacoraDto> result = new BindingList<bitacoraDto>(Query);

                return result;

            }
        }


    }
}
