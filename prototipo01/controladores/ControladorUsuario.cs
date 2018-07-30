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
        ModelAsignacion db = new ModelAsignacion();
        


        public BindingList<UsuarioDto> listaUsuarios()
        {
            using (ModelAsignacion db = new ModelAsignacion())
            {
                var Query = (from n in db.usuario
                             select new UsuarioDto
                             {
                                 id_usuario = n.id_usuario,
                                 usuario_usuario = n.usuario_usuario,
                                 nombre_usuario = n.nombre_usuario,
                                 apellido_usuario = n.apellido_usuario,
                                 //password_usuario = n.password_usuario,
                                 telefono_usuario = n.telefono_usuario,
                                 correo_usuario = n.correo_usuario
                             }).ToList();

                BindingList<UsuarioDto> result = new BindingList<UsuarioDto>(Query);

                return result;

            }
        }


        public void guardarUsuario(String usuario_alias, String nombre, String apellido, String password, String email, String telefono, int privilegio)
        {
            //controladorUsuario.guardarUsuario("andres8m","Andrés","Canú","zxcv","andres.8m@hotmail.com","24454545");      
            usuario usuarioNuevo = new usuario();
            usuarioNuevo.usuario_usuario = usuario_alias;
            usuarioNuevo.nombre_usuario = nombre;
            usuarioNuevo.apellido_usuario = apellido;
            usuarioNuevo.password_usuario = password;
            usuarioNuevo.telefono_usuario = telefono;
            usuarioNuevo.correo_usuario = email;
            usuarioNuevo.nivel_privilegio = privilegio;

            db.usuario.Add(usuarioNuevo);     
            db.SaveChanges();
        }

        public usuario buscarUsuarioCorreo(string correo)
        {
            usuario user = null;
            using (var ctx = db)
            {
                 user = new usuario();
                 user = ctx.usuario
                              .Where(s => s.correo_usuario == correo)
                              .FirstOrDefault<usuario>();
            }

            return user;
        }

        public Boolean login(usuario usuarioLogin, String password)
        {
            if (usuarioLogin == null)
            {
                return false;
            }

            if (usuarioLogin.password_usuario == password)
            {
                /*ControladorBitacora controladorBitacora = new ControladorBitacora();
                controladorBitacora.guardarBitacora(usuarioLogin.id_usuario);*/
                return true;
            }

            return false;
        }


        public int getNivelPrivilegio(string email, string password)

        {

       
            using (var ctx = db)
            {
               
                 var Query = ctx.usuario
                             .Where(s => s.correo_usuario == email && s.password_usuario == password)
                             .FirstOrDefault<usuario>();


                return Query.nivel_privilegio;
            }

        }






    }
}
