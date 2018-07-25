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
    class ControladorUsuario
    {
        ModelDADOS db = new ModelDADOS();


        public BindingList<UsuarioDto> listaUsuarios()
        {
            using (ModelDADOS db = new ModelDADOS())
            {
                var Query = (from n in db.usuario
                             select new UsuarioDto
                             {
                                 iId_usuario = n.id_usuario,
                                 sUsuario_usuario = n.usuario_usuario,
                                 sNombre_usuario = n.nombre_usuario,
                                 sApellido_usuario = n.apellido_usuario,
                                 //password_usuario = n.password_usuario,
                                 sTelefono_usuario = n.telefono_usuario,
                                 sCorreo_usuario = n.correo_usuario
                             }).ToList();

                BindingList<UsuarioDto> result = new BindingList<UsuarioDto>(Query);

                return result;

            }
        }


        public void guardarUsuario(String sUsuario_alias, String sNombre, String sApellido, String sPassword, String sEmail, String sTelefono)
        {
            //controladorUsuario.guardarUsuario("andres8m","Andrés","Canú","zxcv","andres.8m@hotmail.com","24454545");      
            usuario usuarioNuevo = new usuario();
            usuarioNuevo.usuario_usuario = sUsuario_alias;
            usuarioNuevo.nombre_usuario = sNombre;
            usuarioNuevo.apellido_usuario = sApellido;
            usuarioNuevo.password_usuario = sPassword;
            usuarioNuevo.telefono_usuario = sTelefono;
            usuarioNuevo.correo_usuario = sEmail;
            db.usuario.Add(usuarioNuevo);     
            db.SaveChanges();
        }

        public usuario buscarUsuarioCorreo(string sCorreo)
        {
            usuario user = null;
            using (var ctx = db)
            {
                 user = new usuario();
                 user = ctx.usuario
                              .Where(s => s.correo_usuario == sCorreo)
                              .FirstOrDefault<usuario>();
            }

            return user;
        }

        public Boolean login(usuario usuarioLogin, String sPassword)
        {
            if (usuarioLogin == null)
            {
                return false;
            }

            if (usuarioLogin.password_usuario == sPassword)
            {
                return true;
            }

            return false;
        }






    }
}
//Se aplicaron las normas de estandarizacion -Valery