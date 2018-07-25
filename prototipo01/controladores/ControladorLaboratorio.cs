using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using prototipo01.controladores;
using prototipo01.Dto;
using prototipo01.models;


namespace prototipo01.controladores
{
    class ControladorLaboratorio
    {
        //Lista de laboratorios capa Dto
        public BindingList<laboratorioDto> listLaboratorios()
        {

            try
            {
                using (ModelDADOS db = new ModelDADOS())
                {
                    var Query = (from n in db.laboratorio
                                 select new laboratorioDto
                                 {

                                     iId_laboratorio = n.id_laboratorio,
                                     sDescripcion_laboratorio = n.descripcion_laboratorio,
                                     iCATEDRATICO_dpi_catedratico = n.CATEDRATICO_dpi_catedratico,
                                     iHORARIO_id_horario = n.HORARIO_id_horario,
                                     iSALON_id_salon = n.SALON_id_salon

                                 }).ToList();

                    BindingList<laboratorioDto> result = new BindingList<laboratorioDto>(Query);

                    return result;
                }

            }
            catch (Exception)
            {
                throw;
            }

        }



        //get salones

        public List<salon> getSalones()
        {


            using (ModelDADOS db = new ModelDADOS())
            {
                var std = (from salon in db.salon
                           select salon).ToList();


                return std;
            }

        }


        //get catedraticos

        public List<catedratico> getCatedraticos()
        {


            using (ModelDADOS db = new ModelDADOS())
            {
                var std = (from catedratico in db.catedratico
                           select catedratico).ToList();


                return std;
            }

        }




        //Metodo para guardar un nuevo laboratorio
        public void guardarlaboratorio(string sNombre_laboratorio, int iDpi_catedratico, int iId_horario, int iId_salon)
        {

            using (ModelDADOS db = new ModelDADOS())
            {

                laboratorio laboratorioNuevo = new laboratorio();

                laboratorioNuevo.descripcion_laboratorio = sNombre_laboratorio;
                laboratorioNuevo.CATEDRATICO_dpi_catedratico = iDpi_catedratico;
                laboratorioNuevo.HORARIO_id_horario = iId_horario;
                laboratorioNuevo.SALON_id_salon = iId_salon;

                db.laboratorio.Add(laboratorioNuevo);
                db.SaveChanges();

            }

        }


        //Metodo para actualizar laboratorio
        public void actualizarLaboratorio(int iId_laboratorio,string sNombre_laboratorio, int iDpi_catedratico, int iId_horario,int iId_salon)
        {

            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.laboratorio
                        .Where(s => s.id_laboratorio== iId_laboratorio)
                        .FirstOrDefault<laboratorio>();


                    std.descripcion_laboratorio = sNombre_laboratorio;
                    std.CATEDRATICO_dpi_catedratico = iDpi_catedratico;
                    std.HORARIO_id_horario = iId_horario;
                    std.SALON_id_salon = iId_salon;
                    db.SaveChanges();

                }

            }
            catch (Exception)
            {
                throw;
            }

        }





 


        //Buscar laboratorio
        public laboratorio buscarLaboratorio(int iId_laboratorio)
        {
            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.laboratorio
                        .Where(s => s.id_laboratorio == iId_laboratorio )
                        .FirstOrDefault<laboratorio>();

                    return std;
                }


            }
            catch (Exception)
            {
                throw;
            }
        }


        //Metodo para eliminar laboratorio
        public void eliminarLaboratorio(int iId_laboratorio)
        {

            try
            {

                using (ModelDADOS db = new ModelDADOS())
                {
                    var std = db.laboratorio
                        .Where(s => s.id_laboratorio == iId_laboratorio)
                        .FirstOrDefault<laboratorio>();

                    db.laboratorio.Remove(std);
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