using prototipo01.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prototipo01.controladores
{
    class ControladorUsuario
    {
        ModelDADOS db = new ModelDADOS();

        public void guardarUsuario(String usuario_alias, String nombre, String apellido, String password, String email, String telefono)
        {
            //controladorUsuario.guardarUsuario("andres8m","Andrés","Canú","zxcv","andres.8m@hotmail.com","24454545");

            usuario usuarioNuevo = new usuario();
            usuarioNuevo.usuario_usuario = usuario_alias;
            usuarioNuevo.nombre_usuario = nombre;
            usuarioNuevo.apellido_usuario = apellido;
            usuarioNuevo.password_usuario = password;
            usuarioNuevo.telefono_usuario = telefono;
            usuarioNuevo.correo_usuario = email;

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
                return true;
            }

            return false;
        }

    }
}
